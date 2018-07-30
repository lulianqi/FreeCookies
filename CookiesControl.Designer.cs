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
            this.pb_editCookietSet = new System.Windows.Forms.PictureBox();
            this.groupBox_editResponse = new System.Windows.Forms.GroupBox();
            this.splitContainer_info = new System.Windows.Forms.SplitContainer();
            this.pb_editRequestDelHaeds = new System.Windows.Forms.PictureBox();
            this.lv_editRequestHeads = new System.Windows.Forms.ListView();
            this.columnHeader_heads = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editCookieControl = new FreeCookies.EditCookieControl();
            this.groupBox_urlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editCookietSet)).BeginInit();
            this.groupBox_editResponse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_info)).BeginInit();
            this.splitContainer_info.Panel1.SuspendLayout();
            this.splitContainer_info.Panel2.SuspendLayout();
            this.splitContainer_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editRequestDelHaeds)).BeginInit();
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
            this.lv_cookie.MultiSelect = false;
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
            this.cb_injectAlways.Location = new System.Drawing.Point(119, 54);
            this.cb_injectAlways.Name = "cb_injectAlways";
            this.cb_injectAlways.Size = new System.Drawing.Size(102, 16);
            this.cb_injectAlways.TabIndex = 7;
            this.cb_injectAlways.Text = "Injeck Always";
            this.cb_injectAlways.UseVisualStyleBackColor = true;
            this.cb_injectAlways.CheckedChanged += new System.EventHandler(this.cb_injectAlways_CheckedChanged);
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
            this.pb_editCookietSet.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pb_editCookietSet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // groupBox_editResponse
            // 
            this.groupBox_editResponse.Controls.Add(this.pb_editRequestDelHaeds);
            this.groupBox_editResponse.Controls.Add(this.lv_editRequestHeads);
            this.groupBox_editResponse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_editResponse.Location = new System.Drawing.Point(0, 76);
            this.groupBox_editResponse.Name = "groupBox_editResponse";
            this.groupBox_editResponse.Size = new System.Drawing.Size(365, 159);
            this.groupBox_editResponse.TabIndex = 38;
            this.groupBox_editResponse.TabStop = false;
            this.groupBox_editResponse.Text = "Change Response";
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
            // 
            // pb_editRequestDelHaeds
            // 
            this.pb_editRequestDelHaeds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_editRequestDelHaeds.BackColor = System.Drawing.Color.Transparent;
            this.pb_editRequestDelHaeds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_editRequestDelHaeds.Image = ((System.Drawing.Image)(resources.GetObject("pb_editRequestDelHaeds.Image")));
            this.pb_editRequestDelHaeds.Location = new System.Drawing.Point(338, 17);
            this.pb_editRequestDelHaeds.Name = "pb_editRequestDelHaeds";
            this.pb_editRequestDelHaeds.Size = new System.Drawing.Size(24, 24);
            this.pb_editRequestDelHaeds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_editRequestDelHaeds.TabIndex = 40;
            this.pb_editRequestDelHaeds.TabStop = false;
            // 
            // lv_editRequestHeads
            // 
            this.lv_editRequestHeads.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lv_editRequestHeads.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_editRequestHeads.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_heads});
            this.lv_editRequestHeads.Dock = System.Windows.Forms.DockStyle.Right;
            this.lv_editRequestHeads.Location = new System.Drawing.Point(218, 17);
            this.lv_editRequestHeads.Name = "lv_editRequestHeads";
            this.lv_editRequestHeads.Size = new System.Drawing.Size(144, 139);
            this.lv_editRequestHeads.TabIndex = 39;
            this.lv_editRequestHeads.UseCompatibleStateImageBehavior = false;
            this.lv_editRequestHeads.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_heads
            // 
            this.columnHeader_heads.Text = "Heads";
            this.columnHeader_heads.Width = 241;
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
            ((System.ComponentModel.ISupportInitialize)(this.pb_editCookietSet)).EndInit();
            this.groupBox_editResponse.ResumeLayout(false);
            this.splitContainer_info.Panel1.ResumeLayout(false);
            this.splitContainer_info.Panel1.PerformLayout();
            this.splitContainer_info.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_info)).EndInit();
            this.splitContainer_info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_editRequestDelHaeds)).EndInit();
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
        private System.Windows.Forms.PictureBox pb_editRequestDelHaeds;
        private System.Windows.Forms.ListView lv_editRequestHeads;
        private System.Windows.Forms.ColumnHeader columnHeader_heads;
    }
}
