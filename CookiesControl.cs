using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeCookies
{
    public delegate void ListViewChangeEventHandler(object sender, ChangeCookieItemEventArgs e);
    public partial class CookiesControl : UserControl
    {
        public CookiesControl()
        {
            InitializeComponent();
        }

        CookiesInjectInfo cookiesInjectInfo = null;                        //cookies修改信息
        ResponseChangeInfo responseChangeInfo = null;                      //response修改信息
        List<KeyValuePair<string, string>> myCookiesList = null;           //cookie列表数据源
        string addAtr = "Path=/";                                          //cookie默认属性
        Timer myTimer = new Timer();
        int flushCookieTextTick = -1;                                      //cookies格式验证延时
        const int flushFormatTime = 3;
        const int flushColorTime = 20;
        List<KeyValuePair<ListViewItem,int>> editedItemList=null;          //处于标记状态的cookie列表
        Graphics graphicsForRtbCookies=null;
        Pen warnPen = null;

        public delegate void cookiesControlButtonEventHandler(object sender);
        public event cookiesControlButtonEventHandler OnGetCookies;

        private void CookiesControl_Load(object sender, EventArgs e)
        {
            cookiesInjectInfo = new CookiesInjectInfo();
            responseChangeInfo = new ResponseChangeInfo();
            myCookiesList=new List<KeyValuePair<string,string>>();
            editedItemList = new List<KeyValuePair<ListViewItem, int>>();

            cookiesInjectInfo.IsInject = ck_isInjeckCookies.Checked;
            cookiesInjectInfo.ContainUrl = cookiesInjectInfo.IsExactMatch ? tb_urlFilter.Text.Remove(0, 1) : tb_urlFilter.Text;
            cookiesInjectInfo.IsExactMatch = tb_urlFilter.Text.StartsWith("*");
            responseChangeInfo.IsChange = ck_isChangeResponse.Checked;
            responseChangeInfo.IsRegex = ck_isRegex.Checked;
            responseChangeInfo.IsOnlyAddHeads = cb_onlyHead.Checked;
            responseChangeInfo.ReplaceStr = tb_responseReplace.Text;
            responseChangeInfo.ResponseStr = rtb_reponse.Text;
            responseChangeInfo.ResponseAddHead = null;

            editCookieControl.SetListView(lv_cookie);
            editCookieControl.OnListViewChange += editCookieControl_OnListViewChange;

            graphicsForRtbCookies = rtb_cookies.CreateGraphics();
            warnPen = new Pen(Color.Yellow, 2f);

            myTimer.Interval = 200;
            myTimer.Tick += myTimer_Tick;
            myTimer.Start();

        }

        /// <summary>
        /// 获取Response修改信息
        /// </summary>
        public ResponseChangeInfo ChangeInfo
        {
            get { return responseChangeInfo; }
        }
        
        /// <summary>
        /// 获取Cookie修改信息
        /// </summary>
        public CookiesInjectInfo InjectInfo
        {
            get { return cookiesInjectInfo; }
        }

        public string InjectCookies
        {
            get { return rtb_cookies.Text; }
        }

        public List<KeyValuePair<string, string>> CookiesList
        {
            get { return myCookiesList; }
        }

        public string GetControlCookies()
        {
            return rtb_cookies.Text;
        }

        /// <summary>
        /// Fiddler 获取 cookie
        /// </summary>
        /// <param name="yourCookies">cookie 值</param>
        public void SetControlCookies(string yourCookies)
        {
            if (yourCookies=="")
            {
                PaintWarnInfo();
            }
            rtb_cookies.Text = yourCookies;
            ReFlushCookiesView(true);
        }

        /// <summary>
        /// 向free cookies 显示页面打印消息
        /// </summary>
        /// <param name="sender">消息发送者</param>
        /// <param name="yourMessage">消息内容</param>
        public void AddMessageInfo(string sender , string yourMessage)
        {
            switch (sender)
            {
                case null:
                    if (yourMessage != null)
                    {
                        rtb_info.AppendText("\r\n");
                        rtb_info.AppendText(yourMessage);
                    }
                    break;
                case "OnGetCookies_Error":
                    if (yourMessage != null)
                    {
                        PutError(yourMessage);
                    }
                    break;
                case "OnGetCookies":
                    if (yourMessage != null)
                    {
                        PutWarn(yourMessage);
                    }
                    break;
                default:
                    rtb_info.AppendText(yourMessage);
                    break;
            }
           
        }

        /// <summary>
        /// 完成一次cookies设置
        /// </summary>
        /// <param name="yourUri">被修改的请求的uri</param>
        /// <param name="yourHeads">修改后的heads头</param>
        public void FiddlerFreeCookiesSetCookieded(string yourUri,string yourHeads)
        {
            PutWarn(string.Format( "Set Cookie with 【{0}】",yourUri));
            PutInfo(yourHeads);
            if(!cb_injectAlways.Checked)
            {
                ck_isInjeckCookies.Checked = false;
                PutWarn("Set InjeckCookies unable");
            }
        }

        public void FiddlerFreeCookiesSetResponsed(string yourUri)
        {
            PutWarn(string.Format("Change response with 【{0}】", yourUri));
        }

        #region Inner Event
        void myTimer_Tick(object sender, EventArgs e)
        {
            if (flushCookieTextTick == 0)
            {
                ReFlushCookiesView(true);
                flushCookieTextTick = -1;
            }
            else if (flushCookieTextTick > 0)
            {
                flushCookieTextTick--;
            }
            else
            {
                //nothing to do
            }

            if(editedItemList.Count>0)
            {
                for(int i =editedItemList.Count-1 ;i>=0;i--)
                {
                    if(editedItemList[i].Value>0)
                    {
                        editedItemList[i] = new KeyValuePair<ListViewItem, int>(editedItemList[i].Key, editedItemList[i].Value-1);
                    }
                    else
                    {
                        editedItemList[i].Key.BackColor = SystemColors.Window;
                        editedItemList.RemoveAt(i);
                    }
                }

            }
        }
        private void bt_getCookies_Click(object sender, EventArgs e)
        {
            
            if (OnGetCookies != null)
            {
                this.OnGetCookies(null);
            }
        }


        private void lv_cookie_SelectedIndexChanged(object sender, EventArgs e)
        {
            editCookieControl.ReflushEditItem();
        }

        internal void editCookieControl_OnListViewChange(object sender, ChangeCookieItemEventArgs e)
        {
            ReFlushCookiesView(false);
            ListViewItem tempItem = e.EditItem;
            if(tempItem!=null)
            {
                bool isInList = false;
                for (int i = editedItemList.Count - 1; i >= 0; i--)
                {
                    if (editedItemList[i].Key == tempItem)
                    {
                        editedItemList[i] = new KeyValuePair<ListViewItem, int>(tempItem, flushColorTime);
                        isInList = true;
                        break;
                    }
                }

                if(!isInList)
                {
                    tempItem.BackColor = Color.PowderBlue;
                    editedItemList.Add(new KeyValuePair<ListViewItem, int>(tempItem, flushColorTime));
                }

            }
        }


        private void rtb_cookies_KeyUp(object sender, KeyEventArgs e)
        {
            flushCookieTextTick = flushFormatTime;
        }

        private void tb_urlFilter_TextChanged(object sender, EventArgs e)
        {
            cookiesInjectInfo.IsExactMatch = tb_urlFilter.Text.StartsWith("*");
            cookiesInjectInfo.ContainUrl = cookiesInjectInfo.IsExactMatch ? tb_urlFilter.Text.Remove(0, 1) : tb_urlFilter.Text;
        }

        private void ck_isInjeckCookies_CheckedChanged(object sender, EventArgs e)
        {
            cookiesInjectInfo.IsInject = ck_isInjeckCookies.Checked;
            groupBox_urlFilter.Enabled = !ck_isInjeckCookies.Checked;
            if(cb_injectAlways.Checked && !ck_isInjeckCookies.Checked)
            {
                cb_injectAlways.Checked = false;
            }
        }

        private void cb_injectAlways_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_injectAlways.Checked && !ck_isInjeckCookies.Checked)
            {
                ck_isInjeckCookies.Checked = true;
            }
        }

        private void lv_cookie_DoubleClick(object sender, EventArgs e)
        {
            EditCookieForm f = new EditCookieForm(lv_cookie.SelectedItems[0]);
            f.OnListViewChange += editCookieControl_OnListViewChange;
            f.ShowDialog();
            //f.ShowDialog(this);
        }

        private void pb_addHead_Click(object sender, EventArgs e)
        {
            //lv_editRequestHeads.Items.Add("name: value");
            AddResponseHead f = new AddResponseHead(lv_editResponseHeads,this,true);
            f.ShowDialog();
        }

        private void pb_removeHead_Click(object sender, EventArgs e)
        {
            if (lv_editResponseHeads.SelectedItems.Count > 0)
            {
                lv_editResponseHeads.Items.Remove(lv_editResponseHeads.SelectedItems[0]);
            }
            else
            {
                lv_editResponseHeads.Items.Clear();
            }
            ReflushAddResponseHeads();
        }

        private void lv_editResponseHeads_DoubleClick(object sender, EventArgs e)
        {
            if (lv_editResponseHeads.SelectedItems.Count > 0)
            {
                AddResponseHead f = new AddResponseHead(lv_editResponseHeads,this, false);
                f.ShowDialog();
            }
        }

        //pictureBox change for all
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Honeydew;
        }

        //pictureBox change for all
        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Transparent;
        }

        #region Edit Response
        private void ck_isChangeResponse_CheckedChanged(object sender, EventArgs e)
        {
            responseChangeInfo.IsChange = ck_isChangeResponse.Checked;
            tb_responseReplace.Enabled = rtb_reponse.Enabled = ck_isRegex.Enabled = !ck_isChangeResponse.Checked;
            if(!ck_isChangeResponse.Checked && cb_onlyHead.Checked)
            {
                cb_onlyHead.Checked = false;
            }
        }

        private void cb_onlyHead_CheckedChanged(object sender, EventArgs e)
        {
            responseChangeInfo.IsOnlyAddHeads = cb_onlyHead.Checked;
            if(cb_onlyHead.Checked && !ck_isChangeResponse.Checked)
            {
                ck_isChangeResponse.Checked = true;
            }
        }

        
        private void ck_isRegex_CheckedChanged(object sender, EventArgs e)
        {
            responseChangeInfo.IsRegex = ck_isRegex.Checked;
        }

        private void tb_responseReplace_TextChanged(object sender, EventArgs e)
        {
            responseChangeInfo.ReplaceStr = tb_responseReplace.Text;
        }

        private void rtb_reponse_TextChanged(object sender, EventArgs e)
        {
            responseChangeInfo.ResponseStr = rtb_reponse.Text;
        }
        #endregion

        #region UI Resize
        private void CookiesControl_Resize(object sender, EventArgs e)
        {
            //rtb_info.Width = this.Width - 364;
            //rtb_info.Height = this.Height - 285;
            //splitContainer_info.Location = new Point(0, 262);
            splitContainer_info.Height = this.Height - 280;
            tb_urlFilter.Width = groupBox_urlFilter.Width - 60;
            groupBox_editResponse.Height = splitContainer_info.Height - 80;
        }

        private void groupBox_editResponse_Resize(object sender, EventArgs e)
        {
            rtb_reponse.Height = groupBox_editResponse.Height - 72;
            tb_responseReplace.Width = groupBox_editResponse.Width - 265;
        }

        private void splitContainer_info_SplitterMoved(object sender, SplitterEventArgs e)
        {
            tb_urlFilter.Width = groupBox_urlFilter.Width - 60;
        }

        #endregion
       
        #endregion

        #region Inner Function
        private List<KeyValuePair<string, string>> GetCookieList(string yourCookieString, string cookieAttribute)
        {
            List<KeyValuePair<string, string>> tempCL=null;
            if(yourCookieString!=null)
            {
                string[] tempCS = yourCookieString.Split(';');
                if(tempCS.Length>0)
                {
                    tempCL = new List<KeyValuePair<string, string>>();
                    foreach(string eachCookies in tempCS)
                    {
                        string cookieKey = null;
                        string cookieVaule = null;
                        int splitIndex = eachCookies.IndexOf('=');
                        if(splitIndex<0)
                        {
                            return null;
                        }
                        cookieKey = eachCookies.Remove(splitIndex);
                        cookieKey = cookieKey.Trim();
                        cookieVaule = eachCookies.Substring(splitIndex + 1);
                        tempCL.Add(new KeyValuePair<string, string>(cookieKey, string.IsNullOrEmpty(cookieAttribute) ? cookieVaule: string.Format("{0}; {1}",cookieVaule,cookieAttribute)));
                    }
                }
            }
            return tempCL;
        }

        private List<KeyValuePair<string, string>> GetCookieList(string yourCookieString)
        {
            return GetCookieList(yourCookieString, null);
        }
        
        private void ReFlushCookiesView(bool isFormRawData)
        {
            if (isFormRawData)  //修改rtb_cookies，更新CookiesList及ListView
            {
                var tempCookiesList = GetCookieList(rtb_cookies.Text, addAtr);
                if (tempCookiesList != null)
                {
                    myCookiesList = tempCookiesList;
                    rtb_cookies.ForeColor = Color.Black;
                    lv_cookie.SuspendLayout();
                    lv_cookie.Items.Clear();
                    foreach (var kvCookiein in myCookiesList)
                    {
                        if (string.IsNullOrEmpty(addAtr))
                        {
                            lv_cookie.Items.Add(new ListViewItem(new string[] { kvCookiein.Key, kvCookiein.Value, "" }));
                        }
                        else
                        {
                            lv_cookie.Items.Add(new ListViewItem(new string[] { kvCookiein.Key, kvCookiein.Value.Remove(kvCookiein.Value.Length - addAtr.Length - 2), addAtr }));
                        }
                    }
                    lv_cookie.ResumeLayout();
                }
                else
                {
                    myCookiesList.Clear();
                    lv_cookie.Items.Clear();
                    editedItemList.Clear();
                    if (rtb_cookies.Text != "")
                    {
                        rtb_cookies.ForeColor = Color.Red;
                    }
                }
                
                editCookieControl.ReflushEditItem();
            }
            else //修改ListView，更新CookiesList及rtb_cookies
            {
                myCookiesList.Clear();
                if(lv_cookie.Items.Count>0)
                {
                    StringBuilder sbCookies = new StringBuilder(lv_cookie.Items.Count * 20);
                    foreach(ListViewItem eachItem in lv_cookie.Items)
                    {
                        sbCookies.Append(string.Format(" {0}={1};",eachItem.SubItems[0].Text,eachItem.SubItems[1].Text));
                        myCookiesList.Add(new KeyValuePair<string, string>(eachItem.SubItems[0].Text, eachItem.SubItems[2].Text == "" ? eachItem.SubItems[1].Text : String.Format("{0}; {1}", eachItem.SubItems[1].Text, eachItem.SubItems[2].Text)));
                    }
                    if (sbCookies[sbCookies.Length-1]==';')
                    {
                        sbCookies.Remove(sbCookies.Length - 1, 1);
                    }
                    rtb_cookies.Text = sbCookies.ToString();
                }
                else
                {
                    rtb_cookies.Text = "";
                }
            }
        }

        private void PaintWarnInfo()
        {
            graphicsForRtbCookies.DrawRectangle(warnPen, new Rectangle(Point.Empty, rtb_cookies.Size));
        }

        private void PutInfo(string info)
        {
            rtb_info.SelectionColor = Color.Black;
            rtb_info.AppendText(info);
            rtb_info.AppendText("\r\n");
            rtb_info.SelectionColor = Color.Black;
        }

        private void PutWarn(string info)
        {
            rtb_info.SelectionColor = Color.Indigo;
            rtb_info.AppendText(info);
            rtb_info.AppendText("\r\n");
            rtb_info.SelectionColor = Color.Black;
        }

        private void PutError(string info)
        {
            rtb_info.SelectionColor = Color.Red;
            rtb_info.AppendText(info);
            rtb_info.AppendText("\r\n");
            rtb_info.SelectionColor = Color.Black;
        }

        public void ReflushAddResponseHeads()
        {
            responseChangeInfo.ResponseAddHead = null;
            if(lv_editResponseHeads.Items.Count>0)
            {
                responseChangeInfo.ResponseAddHead = new List<KeyValuePair<string, string>>();
                foreach(ListViewItem item in lv_editResponseHeads.Items)
                {
                    string headStr = item.Text;
                    string key = headStr.Remove(headStr.IndexOf(": "));
                    string value = headStr.Substring(headStr.IndexOf(": ") + 2);
                    responseChangeInfo.ResponseAddHead.Add(new KeyValuePair<string, string>(key, value));
                }
            }
        }

        #endregion


    }



    public class CookiesInjectInfo
    {
        public bool IsInject { get; set; }

        public bool IsExactMatch { get; set; }
        public string ContainUrl { get; set; }

    }

    public class ResponseChangeInfo
    {
        public bool IsChange { get; set; }
        public bool IsRegex { get; set; }
        public bool IsOnlyAddHeads { get; set; }
        public string ReplaceStr { get; set; }
        public string ResponseStr { get; set; }

        public List<KeyValuePair<string, string>> ResponseAddHead { get; set; }
    }

    public class ChangeCookieItemEventArgs : EventArgs
    {
        public ListViewItem EditItem { get; set; }
        public ChangeCookieItemEventArgs(ListViewItem yourItem)
        {
            EditItem = yourItem;
        }
    }

}
