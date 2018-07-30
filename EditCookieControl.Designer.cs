namespace FreeCookies
{
    partial class EditCookieControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCookieControl));
            this.tb_editValue = new System.Windows.Forms.TextBox();
            this.tb_editName = new System.Windows.Forms.TextBox();
            this.toolTip_editCookieWindow = new System.Windows.Forms.ToolTip(this.components);
            this.pb_editCookieAdd = new System.Windows.Forms.PictureBox();
            this.pb_editCookieRemove = new System.Windows.Forms.PictureBox();
            this.pb_editCookietComfrim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editCookieAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editCookieRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editCookietComfrim)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_editValue
            // 
            this.tb_editValue.Location = new System.Drawing.Point(100, 3);
            this.tb_editValue.Name = "tb_editValue";
            this.tb_editValue.Size = new System.Drawing.Size(404, 21);
            this.tb_editValue.TabIndex = 0;
            // 
            // tb_editName
            // 
            this.tb_editName.Location = new System.Drawing.Point(3, 3);
            this.tb_editName.Name = "tb_editName";
            this.tb_editName.Size = new System.Drawing.Size(91, 21);
            this.tb_editName.TabIndex = 1;
            // 
            // pb_editCookieAdd
            // 
            this.pb_editCookieAdd.BackColor = System.Drawing.Color.Transparent;
            this.pb_editCookieAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_editCookieAdd.Image = ((System.Drawing.Image)(resources.GetObject("pb_editCookieAdd.Image")));
            this.pb_editCookieAdd.Location = new System.Drawing.Point(536, 3);
            this.pb_editCookieAdd.Name = "pb_editCookieAdd";
            this.pb_editCookieAdd.Size = new System.Drawing.Size(23, 22);
            this.pb_editCookieAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_editCookieAdd.TabIndex = 40;
            this.pb_editCookieAdd.TabStop = false;
            this.toolTip_editCookieWindow.SetToolTip(this.pb_editCookieAdd, "添加新Cookie");
            this.pb_editCookieAdd.Click += new System.EventHandler(this.pb_editCookieAdd_Click);
            this.pb_editCookieAdd.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pb_editCookieAdd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // pb_editCookieRemove
            // 
            this.pb_editCookieRemove.BackColor = System.Drawing.Color.Transparent;
            this.pb_editCookieRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_editCookieRemove.Image = ((System.Drawing.Image)(resources.GetObject("pb_editCookieRemove.Image")));
            this.pb_editCookieRemove.Location = new System.Drawing.Point(562, 3);
            this.pb_editCookieRemove.Name = "pb_editCookieRemove";
            this.pb_editCookieRemove.Size = new System.Drawing.Size(23, 22);
            this.pb_editCookieRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_editCookieRemove.TabIndex = 39;
            this.pb_editCookieRemove.TabStop = false;
            this.toolTip_editCookieWindow.SetToolTip(this.pb_editCookieRemove, "移除Cookie");
            this.pb_editCookieRemove.Click += new System.EventHandler(this.pb_editCookieRemove_Click);
            this.pb_editCookieRemove.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pb_editCookieRemove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // pb_editCookietComfrim
            // 
            this.pb_editCookietComfrim.BackColor = System.Drawing.Color.Transparent;
            this.pb_editCookietComfrim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_editCookietComfrim.Image = ((System.Drawing.Image)(resources.GetObject("pb_editCookietComfrim.Image")));
            this.pb_editCookietComfrim.Location = new System.Drawing.Point(510, 3);
            this.pb_editCookietComfrim.Name = "pb_editCookietComfrim";
            this.pb_editCookietComfrim.Size = new System.Drawing.Size(23, 22);
            this.pb_editCookietComfrim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_editCookietComfrim.TabIndex = 36;
            this.pb_editCookietComfrim.TabStop = false;
            this.toolTip_editCookieWindow.SetToolTip(this.pb_editCookietComfrim, "确认修改");
            this.pb_editCookietComfrim.Click += new System.EventHandler(this.pb_editCookietComfrim_Click);
            this.pb_editCookietComfrim.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pb_editCookietComfrim.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // EditCookieControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb_editCookieAdd);
            this.Controls.Add(this.pb_editCookieRemove);
            this.Controls.Add(this.pb_editCookietComfrim);
            this.Controls.Add(this.tb_editName);
            this.Controls.Add(this.tb_editValue);
            this.Name = "EditCookieControl";
            this.Size = new System.Drawing.Size(588, 27);
            this.Load += new System.EventHandler(this.EditCookieWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_editCookieAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editCookieRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editCookietComfrim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_editValue;
        private System.Windows.Forms.TextBox tb_editName;
        private System.Windows.Forms.PictureBox pb_editCookietComfrim;
        private System.Windows.Forms.PictureBox pb_editCookieRemove;
        private System.Windows.Forms.PictureBox pb_editCookieAdd;
        private System.Windows.Forms.ToolTip toolTip_editCookieWindow;
    }
}
