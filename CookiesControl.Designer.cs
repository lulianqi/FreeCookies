namespace FreeCookies
{
    partial class CookiesControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CookiesControl));
            this.rtb_cookies = new System.Windows.Forms.RichTextBox();
            this.bt_getCookies = new System.Windows.Forms.Button();
            this.lv_cookie = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rtb_info = new System.Windows.Forms.RichTextBox();
            this.groupBox_urlFilter = new System.Windows.Forms.GroupBox();
            this.lb_info_1 = new System.Windows.Forms.Label();
            this.tb_urlFilter = new System.Windows.Forms.TextBox();
            this.ck_isInjeckCookies = new System.Windows.Forms.CheckBox();
            this.cb_injectAlways = new System.Windows.Forms.CheckBox();
            this.groupBox_editResponse = new System.Windows.Forms.GroupBox();
            this.ck_isChangeResponse = new System.Windows.Forms.CheckBox();
            this.ck_isRegex = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_responseReplace = new System.Windows.Forms.TextBox();
            this.rtb_reponse = new System.Windows.Forms.RichTextBox();
            this.pb_addHead = new System.Windows.Forms.PictureBox();
            this.pb_removeHead = new System.Windows.Forms.PictureBox();
            this.lv_editResponseHeads = new System.Windows.Forms.ListView();
            this.columnHeader_heads = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cb_onlyHead = new System.Windows.Forms.CheckBox();
            this.splitContainer_info = new System.Windows.Forms.SplitContainer();
            this.pb_editCookietSet = new System.Windows.Forms.PictureBox();
            this.editCookieControl = new FreeCookies.EditCookieControl();
            this.groupBox_urlFilter.SuspendLayout();
            this.groupBox_editResponse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_addHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_removeHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_info)).BeginInit();
            this.splitContainer_info.Panel1.SuspendLayout();
            this.splitContainer_info.Panel2.SuspendLayout();
            this.splitContainer_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editCookietSet)).BeginInit();
            this.SuspendLayout();
            // 
            // rtb_cookies
            // 
            this.rtb_cookies.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtb_cookies.Location = new System.Drawing.Point(0, 0);
            this.rtb_cookies.Name = "rtb_cookies";
            this.rtb_cookies.Size = new System.Drawing.Size(687, 88);
            this.rtb_cookies.TabIndex = 0;
            this.rtb_cookies.Text = "";
            this.rtb_cookies.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtb_cookies_KeyUp);
            // 
            // bt_getCookies
            // 
            this.bt_getCookies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_getCookies.Location = new System.Drawing.Point(0, 231);
            this.bt_getCookies.Name = "bt_getCookies";
            this.bt_getCookies.Size = new System.Drawing.Size(84, 25);
            this.bt_getCookies.TabIndex = 1;
            this.bt_getCookies.Text = "Get Cookies";
            this.bt_getCookies.UseVisualStyleBackColor = true;
            this.bt_getCookies.Click += new System.EventHandler(this.bt_getCookies_Click);
            // 
            // lv_cookie
            // 
            this.lv_cookie.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv_cookie.Dock = System.Windows.Forms.DockStyle.Top;
            this.lv_cookie.FullRowSelect = true;
            this.lv_cookie.Location = new System.Drawing.Point(0, 88);
            this.lv_cookie.Name = "lv_cookie";
            this.lv_cookie.Size = new System.Drawing.Size(687, 139);
            this.lv_cookie.TabIndex = 2;
            this.lv_cookie.UseCompatibleStateImageBehavior = false;
            this.lv_cookie.View = System.Windows.Forms.View.Details;
            this.lv_cookie.SelectedIndexChanged += new System.EventHandler(this.lv_cookie_SelectedIndexChanged);
            this.lv_cookie.DoubleClick += new System.EventHandler(this.lv_cookie_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "name";
            this.columnHeader1.Width = 84;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "value";
            this.columnHeader2.Width = 502;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Attributes";
            this.columnHeader3.Width = 87;
            // 
            // rtb_info
            // 
            this.rtb_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_info.HideSelection = false;
            this.rtb_info.Location = new System.Drawing.Point(0, 0);
            this.rtb_info.Name = "rtb_info";
            this.rtb_info.Size = new System.Drawing.Size(318, 235);
            this.rtb_info.TabIndex = 4;
            this.rtb_info.Text = "";
            // 
            // groupBox_urlFilter
            // 
            this.groupBox_urlFilter.Controls.Add(this.lb_info_1);
            this.groupBox_urlFilter.Controls.Add(this.tb_urlFilter);
            this.groupBox_urlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_urlFilter.Location = new System.Drawing.Point(0, 0);
            this.groupBox_urlFilter.Name = "groupBox_urlFilter";
            this.groupBox_urlFilter.Size = new System.Drawing.Size(365, 45);
            this.groupBox_urlFilter.TabIndex = 5;
            this.groupBox_urlFilter.TabStop = false;
            this.groupBox_urlFilter.Text = "Url Filter";
            // 
            // lb_info_1
            // 
            this.lb_info_1.AutoSize = true;
            this.lb_info_1.Location = new System.Drawing.Point(3, 24);
            this.lb_info_1.Name = "lb_info_1";
            this.lb_info_1.Size = new System.Drawing.Size(53, 12);
            this.lb_info_1.TabIndex = 1;
            this.lb_info_1.Text = "contain:";
            // 
            // tb_urlFilter
            // 
            this.tb_urlFilter.Location = new System.Drawing.Point(58, 20);
            this.tb_urlFilter.Name = "tb_urlFilter";
            this.tb_urlFilter.Size = new System.Drawing.Size(304, 21);
            this.tb_urlFilter.TabIndex = 0;
            this.tb_urlFilter.TextChanged += new System.EventHandler(this.tb_urlFilter_TextChanged);
            // 
            // ck_isInjeckCookies
            // 
            this.ck_isInjeckCookies.AutoSize = true;
            this.ck_isInjeckCookies.Location = new System.Drawing.Point(5, 54);
            this.ck_isInjeckCookies.Name = "ck_isInjeckCookies";
            this.ck_isInjeckCookies.Size = new System.Drawing.Size(108, 16);
            this.ck_isInjeckCookies.TabIndex = 6;
            this.ck_isInjeckCookies.Text = "Injeck Cookies";
            this.ck_isInjeckCookies.UseVisualStyleBackColor = true;
            this.ck_isInjeckCookies.CheckedChanged += new System.EventHandler(this.ck_isInjeckCookies_CheckedChanged);
            // 
            // cb_injectAlways
            // 
            this.cb_injectAlways.AutoSize = true;
            this.cb_injectAlways.Location = new System.Drawing.Point(113, 54);
            this.cb_injectAlways.Name = "cb_injectAlways";
            this.cb_injectAlways.Size = new System.Drawing.Size(102, 16);
            this.cb_injectAlways.TabIndex = 7;
            this.cb_injectAlways.Text = "Injeck Always";
            this.cb_injectAlways.UseVisualStyleBackColor = true;
            this.cb_injectAlways.CheckedChanged += new System.EventHandler(this.cb_injectAlways_CheckedChanged);
            // 
            // groupBox_editResponse
            // 
            this.groupBox_editResponse.Controls.Add(this.ck_isChangeResponse);
            this.groupBox_editResponse.Controls.Add(this.ck_isRegex);
            this.groupBox_editResponse.Controls.Add(this.label1);
            this.groupBox_editResponse.Controls.Add(this.tb_responseReplace);
            this.groupBox_editResponse.Controls.Add(this.rtb_reponse);
            this.groupBox_editResponse.Controls.Add(this.pb_addHead);
            this.groupBox_editResponse.Controls.Add(this.pb_removeHead);
            this.groupBox_editResponse.Controls.Add(this.lv_editResponseHeads);
            this.groupBox_editResponse.Controls.Add(this.cb_onlyHead);
            this.groupBox_editResponse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_editResponse.Location = new System.Drawing.Point(0, 76);
            this.groupBox_editResponse.Name = "groupBox_editResponse";
            this.groupBox_editResponse.Size = new System.Drawing.Size(365, 159);
            this.groupBox_editResponse.TabIndex = 38;
            this.groupBox_editResponse.TabStop = false;
            this.groupBox_editResponse.Text = "Change Response";
            this.groupBox_editResponse.Resize += new System.EventHandler(this.groupBox_editResponse_Resize);
            // 
            // ck_isChangeResponse
            // 
            this.ck_isChangeResponse.AutoSize = true;
            this.ck_isChangeResponse.Location = new System.Drawing.Point(5, 19);
            this.ck_isChangeResponse.Name = "ck_isChangeResponse";
            this.ck_isChangeResponse.Size = new System.Drawing.Size(102, 16);
            this.ck_isChangeResponse.TabIndex = 47;
            this.ck_isChangeResponse.Text = "Enable Change";
            this.ck_isChangeResponse.UseVisualStyleBackColor = true;
            this.ck_isChangeResponse.CheckedChanged += new System.EventHandler(this.ck_isChangeResponse_CheckedChanged);
            // 
            // ck_isRegex
            // 
            this.ck_isRegex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ck_isRegex.AutoSize = true;
            this.ck_isRegex.Location = new System.Drawing.Point(160, 44);
            this.ck_isRegex.Name = "ck_isRegex";
            this.ck_isRegex.Size = new System.Drawing.Size(54, 16);
            this.ck_isRegex.TabIndex = 46;
            this.ck_isRegex.Text = "Regex";
            this.ck_isRegex.UseVisualStyleBackColor = true;
            this.ck_isRegex.CheckedChanged += new System.EventHandler(this.ck_isRegex_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 45;
            this.label1.Text = "Replace";
            // 
            // tb_responseReplace
            // 
            this.tb_responseReplace.Location = new System.Drawing.Point(55, 43);
            this.tb_responseReplace.Name = "tb_responseReplace";
            this.tb_responseReplace.Size = new System.Drawing.Size(100, 21);
            this.tb_responseReplace.TabIndex = 44;
            this.tb_responseReplace.TextChanged += new System.EventHandler(this.tb_responseReplace_TextChanged);
            // 
            // rtb_reponse
            // 
            this.rtb_reponse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtb_reponse.Location = new System.Drawing.Point(3, 67);
            this.rtb_reponse.Name = "rtb_reponse";
            this.rtb_reponse.Size = new System.Drawing.Size(215, 89);
            this.rtb_reponse.TabIndex = 43;
            this.rtb_reponse.Text = "";
            this.rtb_reponse.TextChanged += new System.EventHandler(this.rtb_reponse_TextChanged);
            // 
            // pb_addHead
            // 
            this.pb_addHead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_addHead.BackColor = System.Drawing.Color.Transparent;
            this.pb_addHead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_addHead.Image = ((System.Drawing.Image)(resources.GetObject("pb_addHead.Image")));
            this.pb_addHead.Location = new System.Drawing.Point(319, 17);
            this.pb_addHead.Name = "pb_addHead";
            this.pb_addHead.Size = new System.Drawing.Size(20, 20);
            this.pb_addHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_addHead.TabIndex = 42;
            this.pb_addHead.TabStop = false;
            this.pb_addHead.Click += new System.EventHandler(this.pb_addHead_Click);
            this.pb_addHead.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pb_addHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // pb_removeHead
            // 
            this.pb_removeHead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_removeHead.BackColor = System.Drawing.Color.Transparent;
            this.pb_removeHead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_removeHead.Image = ((System.Drawing.Image)(resources.GetObject("pb_removeHead.Image")));
            this.pb_removeHead.Location = new System.Drawing.Point(340, 17);
            this.pb_removeHead.Name = "pb_removeHead";
            this.pb_removeHead.Size = new System.Drawing.Size(20, 20);
            this.pb_removeHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_removeHead.TabIndex = 41;
            this.pb_removeHead.TabStop = false;
            this.pb_removeHead.Click += new System.EventHandler(this.pb_removeHead_Click);
            this.pb_removeHead.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pb_removeHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // lv_editResponseHeads
            // 
            this.lv_editResponseHeads.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lv_editResponseHeads.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_editResponseHeads.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_heads});
            this.lv_editResponseHeads.Dock = System.Windows.Forms.DockStyle.Right;
            this.lv_editResponseHeads.LabelEdit = true;
            this.lv_editResponseHeads.Location = new System.Drawing.Point(218, 17);
            this.lv_editResponseHeads.Name = "lv_editResponseHeads";
            this.lv_editResponseHeads.Size = new System.Drawing.Size(144, 139);
            this.lv_editResponseHeads.TabIndex = 39;
            this.lv_editResponseHeads.UseCompatibleStateImageBehavior = false;
            this.lv_editResponseHeads.View = System.Windows.Forms.View.Details;
            this.lv_editResponseHeads.DoubleClick += new System.EventHandler(this.lv_editResponseHeads_DoubleClick);
            // 
            // columnHeader_heads
            // 
            this.columnHeader_heads.Text = "Heads";
            this.columnHeader_heads.Width = 241;
            // 
            // cb_onlyHead
            // 
            this.cb_onlyHead.AutoSize = true;
            this.cb_onlyHead.Location = new System.Drawing.Point(112, 19);
            this.cb_onlyHead.Name = "cb_onlyHead";
            this.cb_onlyHead.Size = new System.Drawing.Size(102, 16);
            this.cb_onlyHead.TabIndex = 48;
            this.cb_onlyHead.Text = "Only Add Head";
            this.cb_onlyHead.UseVisualStyleBackColor = true;
            this.cb_onlyHead.CheckedChanged += new System.EventHandler(this.cb_onlyHead_CheckedChanged);
            // 
            // splitContainer_info
            // 
            this.splitContainer_info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer_info.Location = new System.Drawing.Point(0, 262);
            this.splitContainer_info.Name = "splitContainer_info";
            // 
            // splitContainer_info.Panel1
            // 
            this.splitContainer_info.Panel1.Controls.Add(this.groupBox_urlFilter);
            this.splitContainer_info.Panel1.Controls.Add(this.groupBox_editResponse);
            this.splitContainer_info.Panel1.Controls.Add(this.ck_isInjeckCookies);
            this.splitContainer_info.Panel1.Controls.Add(this.pb_editCookietSet);
            this.splitContainer_info.Panel1.Controls.Add(this.cb_injectAlways);
            // 
            // splitContainer_info.Panel2
            // 
            this.splitContainer_info.Panel2.Controls.Add(this.rtb_info);
            this.splitContainer_info.Size = new System.Drawing.Size(687, 235);
            this.splitContainer_info.SplitterDistance = 365;
            this.splitContainer_info.TabIndex = 39;
            this.splitContainer_info.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer_info_SplitterMoved);
            // 
            // pb_editCookietSet
            // 
            this.pb_editCookietSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_editCookietSet.BackColor = System.Drawing.Color.Transparent;
            this.pb_editCookietSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_editCookietSet.Image = ((System.Drawing.Image)(resources.GetObject("pb_editCookietSet.Image")));
            this.pb_editCookietSet.Location = new System.Drawing.Point(335, 48);
            this.pb_editCookietSet.Name = "pb_editCookietSet";
            this.pb_editCookietSet.Size = new System.Drawing.Size(23, 22);
            this.pb_editCookietSet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_editCookietSet.TabIndex = 37;
            this.pb_editCookietSet.TabStop = false;
            this.pb_editCookietSet.Click += new System.EventHandler(this.pb_editCookietSet_Click);
            this.pb_editCookietSet.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pb_editCookietSet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // editCookieControl
            // 
            this.editCookieControl.Location = new System.Drawing.Point(87, 229);
            this.editCookieControl.Name = "editCookieControl";
            this.editCookieControl.Size = new System.Drawing.Size(592, 27);
            this.editCookieControl.TabIndex = 3;
            // 
            // CookiesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer_info);
            this.Controls.Add(this.editCookieControl);
            this.Controls.Add(this.lv_cookie);
            this.Controls.Add(this.bt_getCookies);
            this.Controls.Add(this.rtb_cookies);
            this.Name = "CookiesControl";
            this.Size = new System.Drawing.Size(687, 497);
            this.Load += new System.EventHandler(this.CookiesControl_Load);
            this.Resize += new System.EventHandler(this.CookiesControl_Resize);
            this.groupBox_urlFilter.ResumeLayout(false);
            this.groupBox_urlFilter.PerformLayout();
            this.groupBox_editResponse.ResumeLayout(false);
            this.groupBox_editResponse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_addHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_removeHead)).EndInit();
            this.splitContainer_info.Panel1.ResumeLayout(false);
            this.splitContainer_info.Panel1.PerformLayout();
            this.splitContainer_info.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_info)).EndInit();
            this.splitContainer_info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_editCookietSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_cookies;
        private System.Windows.Forms.Button bt_getCookies;
        private System.Windows.Forms.ListView lv_cookie;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private EditCookieControl editCookieControl;
        private System.Windows.Forms.RichTextBox rtb_info;
        private System.Windows.Forms.GroupBox groupBox_urlFilter;
        private System.Windows.Forms.Label lb_info_1;
        private System.Windows.Forms.TextBox tb_urlFilter;
        private System.Windows.Forms.CheckBox ck_isInjeckCookies;
        private System.Windows.Forms.CheckBox cb_injectAlways;
        private System.Windows.Forms.PictureBox pb_editCookietSet;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox_editResponse;
        private System.Windows.Forms.SplitContainer splitContainer_info;
        private System.Windows.Forms.ListView lv_editResponseHeads;
        private System.Windows.Forms.ColumnHeader columnHeader_heads;
        private System.Windows.Forms.PictureBox pb_addHead;
        private System.Windows.Forms.PictureBox pb_removeHead;
        private System.Windows.Forms.RichTextBox rtb_reponse;
        private System.Windows.Forms.CheckBox ck_isRegex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_responseReplace;
        private System.Windows.Forms.CheckBox ck_isChangeResponse;
        private System.Windows.Forms.CheckBox cb_onlyHead;
    }
}
