using Fiddler;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

[assembly: Fiddler.RequiredVersion("2.3.5.0")]
namespace FreeCookies
{
    public class FiddlerFreeCookies:IAutoTamper
    {

        private bool isOnLoad = false;
        private TabPage tabPage; //创建插件的选项卡页
        private CookiesControl myCookiesCtrl; //MyControl自定义控件

        public void OnBeforeUnload()
        {
            throw new NotImplementedException();
        }

        public void OnLoad()
        {
            FiddlerObject.log(string.Format("【TestExtension】:{0}", "OnLoad"));
            if (!isOnLoad)
            {

                tabPage = new TabPage();
                tabPage.Text = "free cookies";
                if (FiddlerApplication.UI.tabsViews.ImageList != null)
                {
                    Image myIco = FreeCookies.Resources.MyResource.edit;
                    FiddlerApplication.UI.tabsViews.ImageList.Images.Add(myIco);
                    tabPage.ImageIndex = FiddlerApplication.UI.tabsViews.ImageList.Images.Count - 1;
                }
                myCookiesCtrl = new CookiesControl();
                myCookiesCtrl.Dock = DockStyle.Fill;
                myCookiesCtrl.OnGetCookies += myCtrl_OnGetCookies;
                tabPage.Controls.Add(myCookiesCtrl);
                FiddlerApplication.UI.tabsViews.TabPages.Add(tabPage);
                isOnLoad = true;
            }
        }

        void myCtrl_OnGetCookies(object sender)
        {
            Session tempSession = Fiddler.FiddlerObject.UI.GetFirstSelectedSession();
            if(tempSession!=null)
            {
                var tempCookies = tempSession.RequestHeaders["Cookie"];
                myCookiesCtrl.SetControlCookies(tempCookies);
                if(tempCookies=="")
                {
                    myCookiesCtrl.AddMessageInfo("OnGetCookies_Error", string.Format("【{0}】\r\nthis http session not has any cookie", tempSession.url));
                }
                else
                {
                    myCookiesCtrl.AddMessageInfo("OnGetCookies", string.Format("【{0}】\r\nGeted new cookies", tempSession.url));
                }
            }
            else
            {
                Fiddler.FiddlerObject.UI.ShowAlert(new frmAlert("STOP", "please select a session", "OK"));
            }
        }
        public void AutoTamperRequestAfter(Session oSession)
        {
            
        }

        public void AutoTamperRequestBefore(Session oSession)
        {
            //oSession.bBufferResponse = true;
            //oSession.LoadResponseFromFile(@"C:\Users\administer\AppData\Local\Programs\Fiddler\ResponseTemplates\200_SimpleHTML.dat");
            if (!isOnLoad)
            {
                return;
            }
            if (myCookiesCtrl.RawResponseEditInfo.IsRawModel && myCookiesCtrl.RawResponseEditInfo.IsEnable && myCookiesCtrl.RawResponseEditInfo.IsDirectResponse)
            {
                if (oSession.RequestMethod == "CONNECT")
                {
                    //MemoryStream msSslDecryptEndpointCreated;
                    //msSslDecryptEndpointCreated = new MemoryStream(Encoding.UTF8.GetBytes(string.Format("HTTP/1.1 200 DecryptEndpoint Created\r\nTimestamp: {0}\r\nFiddlerGateway: AutoResponder\r\nConnection: close\r\n\r\nThis is a Fiddler-generated response to the client's request for a CONNECT tunnel.\r\n",System.DateTime.Now.ToString("HH:mm:ss.fff"))));
                    //oSession.LoadResponseFromStream(msSslDecryptEndpointCreated, null);
                    return;
                }

                if ((!myCookiesCtrl.InjectInfo.IsExactMatch && oSession.uriContains(myCookiesCtrl.InjectInfo.ContainUrl)) || (myCookiesCtrl.InjectInfo.IsExactMatch && oSession.fullUrl == myCookiesCtrl.InjectInfo.ContainUrl))
                {
                    MemoryStream ms = new MemoryStream(myCookiesCtrl.RawResponseEditInfo.httpResponse.GetRawHttpResponse());
                    oSession.LoadResponseFromStream(ms, null);
                    myCookiesCtrl.FiddlerFreeCookiesSetResponsed(oSession.url);
                    oSession["ui-backcolor"] = "Powderblue";
                    oSession["ui-bold"] = "true";
                    oSession["ui-color"] = "Red";
                }
            }
        }

        public void AutoTamperResponseAfter(Session oSession)
        {
            if (!isOnLoad)
            {
                return;
            }

            if (myCookiesCtrl.InjectInfo.IsInject)
            {
                if (oSession.RequestMethod == "CONNECT")
                {
                    return;
                }
                if ((!myCookiesCtrl.InjectInfo.IsExactMatch && oSession.uriContains(myCookiesCtrl.InjectInfo.ContainUrl)) || (myCookiesCtrl.InjectInfo.IsExactMatch && oSession.fullUrl == myCookiesCtrl.InjectInfo.ContainUrl))
                {
                    foreach (var tempCookie in myCookiesCtrl.CookiesList)
                    {
                        oSession.oResponse.headers.Add("Set-Cookie", string.Format("{0}={1}", tempCookie.Key, tempCookie.Value));
                    }
                    myCookiesCtrl.FiddlerFreeCookiesSetCookieded(oSession.url, oSession.ResponseHeaders.ToString());
                    oSession["ui-backcolor"] = "Yellow";
                }
            }

            if (myCookiesCtrl.RawResponseEditInfo.IsRawModel&& myCookiesCtrl.RawResponseEditInfo.IsEnable)
            {
                if(myCookiesCtrl.RawResponseEditInfo.IsDirectResponse)
                {
                    return;
                }
                
                if (oSession.RequestMethod == "CONNECT")
                {
                    return;
                }

                if ((!myCookiesCtrl.InjectInfo.IsExactMatch && oSession.uriContains(myCookiesCtrl.InjectInfo.ContainUrl)) || (myCookiesCtrl.InjectInfo.IsExactMatch && oSession.fullUrl == myCookiesCtrl.InjectInfo.ContainUrl))
                {
                    oSession.responseCode = myCookiesCtrl.RawResponseEditInfo.httpResponse.ResponseCode;
                    oSession.ResponseHeaders.RemoveAll();
                    foreach (var tempKv in myCookiesCtrl.RawResponseEditInfo.httpResponse.ResponseHeads)
                    {
                        oSession.ResponseHeaders.Add(tempKv.Key, tempKv.Value);
                    }
                    oSession.ResponseBody = myCookiesCtrl.RawResponseEditInfo.httpResponse.ResponseEntity;

                    myCookiesCtrl.FiddlerFreeCookiesSetResponsed(oSession.url);
                    oSession["ui-backcolor"] = "Powderblue";
                }
            }

            else if(myCookiesCtrl.ChangeInfo.IsChange)
            {
                if (oSession.RequestMethod == "CONNECT")
                {
                    return;
                }
                if ((!myCookiesCtrl.InjectInfo.IsExactMatch && oSession.uriContains(myCookiesCtrl.InjectInfo.ContainUrl)) || (myCookiesCtrl.InjectInfo.IsExactMatch && oSession.fullUrl == myCookiesCtrl.InjectInfo.ContainUrl))
                {
                    if (myCookiesCtrl.ChangeInfo.ResponseAddHead != null)
                    {
                        foreach (var kv in myCookiesCtrl.ChangeInfo.ResponseAddHead)
                        {
                            oSession.oResponse.headers.Add(kv.Key, kv.Value);
                        }
                    }

                    if (!myCookiesCtrl.ChangeInfo.IsOnlyAddHeads)
                    {
                        if (myCookiesCtrl.ChangeInfo.ReplaceStr == "")
                        {
                            oSession.ResponseBody = (oSession.GetResponseBodyEncoding()).GetBytes(myCookiesCtrl.ChangeInfo.ResponseStr);
                        }
                        else
                        {
                            oSession.utilDecodeResponse();
                            if (myCookiesCtrl.ChangeInfo.IsRegex)
                            {
                                oSession.utilReplaceRegexInResponse(myCookiesCtrl.ChangeInfo.ReplaceStr, myCookiesCtrl.ChangeInfo.ResponseStr);
                            }
                            else
                            {
                                oSession.utilReplaceInResponse(myCookiesCtrl.ChangeInfo.ReplaceStr, myCookiesCtrl.ChangeInfo.ResponseStr);
                            }
                        }
                    }
                    myCookiesCtrl.FiddlerFreeCookiesSetResponsed(oSession.url);
                    oSession["ui-backcolor"] = "Powderblue";
                }
            }

        }

        public void AutoTamperResponseBefore(Session oSession)
        {
            
        }

        public void OnBeforeReturningError(Session oSession)
        {
            
        }

    }
}
