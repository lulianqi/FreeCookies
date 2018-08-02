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
    public partial class EditCookieControl : UserControl
    {
        public EditCookieControl()
        {
            InitializeComponent();
        }

        
        public event ListViewChangeEventHandler OnListViewChange;

        ListView cookieLv = null;
        ListViewItem editItem = null;

        public ListViewItem EditItem
        {
            get { return editItem; }
        }

        public EditCookieControl(ListView yourLv)
        {
            cookieLv = yourLv;
        }

        public void SetListView(ListView yourLv)
        {
            cookieLv = yourLv;
        }

        private void EditCookieWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void ListViewChange()
        {
            if(OnListViewChange!=null)
            {
                this.OnListViewChange(this, new ChangeCookieItemEventArgs(editItem));
            }
        }

        private void GetEditCookieItem()
        {
            if(cookieLv.SelectedItems!=null)
            {
                if (cookieLv.SelectedItems.Count > 0)
                {
                    editItem = cookieLv.SelectedItems[0];
                }
                else
                {
                    editItem = null;
                }
            }
            else
            {
                editItem = null;
            }
        }

        public void ReflushEditItem()
        {
            GetEditCookieItem();
            if (editItem != null)
            {
                tb_editName.Text = editItem.SubItems[0].Text;
                tb_editValue.Text = editItem.SubItems[1].Text;
            }
        }

        private void pb_editCookietComfrim_Click(object sender, EventArgs e)
        {
            if(editItem!=null)
            {
                editItem.SubItems[0].Text = tb_editName.Text;
                editItem.SubItems[1].Text = tb_editValue.Text;
                ListViewChange();
            }
            else
            {
                tb_editName.Text = "";
                tb_editValue.Text = "";
            }
        }

        private void pb_editCookieAdd_Click(object sender, EventArgs e)
        {
            if (tb_editName.Text != "")
            {
                cookieLv.Items.Add(new ListViewItem(new string[] { tb_editName.Text, tb_editValue.Text ,""}));
                ListViewChange();
            }
        }

        private void pb_editCookieRemove_Click(object sender, EventArgs e)
        {
            if(editItem!=null)
            {
                if (cookieLv.SelectedItems.Count == 0)
                {
                    cookieLv.Items.Remove(editItem);
                }
                else if (cookieLv.SelectedItems.Count>0)
                {
                    List<ListViewItem> itemToRemove = new List<ListViewItem>();
                    foreach (ListViewItem rmItem in cookieLv.SelectedItems)
                    {
                        itemToRemove.Add(rmItem);
                    }
                    foreach (ListViewItem rmItem in itemToRemove)
                    {
                        cookieLv.Items.Remove(rmItem);
                    }
                }
                ListViewChange();
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


    }
}
