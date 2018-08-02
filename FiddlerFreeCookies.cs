using Fiddler;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            
        }

        public void AutoTamperResponseAfter(Session oSession)
        {
            oSession.utilFindInResponse("", false);
            //oSession.utilReplaceRegexInResponse
            //oSession.oResponse.headers.Add();
            if (!isOnLoad)
            {
                return;
            }
            if (myCookiesCtrl.InjectInfo.IsInject)
            {
                if ((!myCookiesCtrl.InjectInfo.IsExactMatch && oSession.uriContains(myCookiesCtrl.InjectInfo.ContainUrl)) || (myCookiesCtrl.InjectInfo.IsExactMatch && oSession.fullUrl == myCookiesCtrl.InjectInfo.ContainUrl))
                {
                    //oSession.oResponse.headers.Add("Set-Cookie", myCookiesCtrl.InjectCookies);
                    foreach (var tempCookie in myCookiesCtrl.CookiesList)
                    {
                        oSession.oResponse.headers.Add("Set-Cookie", string.Format("{0}={1}", tempCookie.Key, tempCookie.Value));
                    }
                    myCookiesCtrl.FiddlerFreeCookiesSetCookieded(oSession.url, oSession.ResponseHeaders.ToString());
                    oSession["ui-backcolor"] = "Yellow";
                }
            }

            if(myCookiesCtrl.ChangeInfo.IsChange)
            {
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
                    oSession["ui-backcolor"] = "Firebrick";
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
