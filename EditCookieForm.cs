using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeCookies
{
    public partial class EditCookieForm : Form
    {
        public event ListViewChangeEventHandler OnListViewChange;
        ListViewItem editItem;
        public EditCookieForm(ListViewItem yourEditItem)
        {
            InitializeComponent();
            editItem = yourEditItem;
        }

        private void EditCookieForm_Load(object sender, EventArgs e)
        {
            tb_name.Text = editItem.SubItems[0].Text;
            rtb_value.Text = editItem.SubItems[1].Text;
            tb_attribute.Text = editItem.SubItems[2].Text;
            UpdataSetText();
        }


        private void tb_attribute_TextChanged(object sender, EventArgs e)
        {
            UpdataSetText();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            editItem.SubItems[0].Text = tb_name.Text;
            editItem.SubItems[1].Text = rtb_value.Text;
            editItem.SubItems[2].Text = tb_attribute.Text;
            if (OnListViewChange!=null)
            {
                this.OnListViewChange(this, new ChangeCookieItemEventArgs(editItem));
            }
            this.Close();
        }

       
        private void UpdataSetText()
        {
            if (tb_attribute.Text != "")
            {
                rtb_setValue.Text = string.Format("Set-Cookie: {0}={1}; {2}", tb_name.Text, rtb_value.Text, tb_attribute.Text);
            }
            else
            {
                rtb_setValue.Text = string.Format("Set-Cookie: {0}={1}", tb_name.Text, rtb_value.Text);
            }
        }
    }
}
