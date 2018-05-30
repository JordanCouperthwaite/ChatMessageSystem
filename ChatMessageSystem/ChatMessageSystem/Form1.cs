using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatMessageSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnPressExit_Click(object sender, EventArgs e)
        {
      
            var result = MessageBox.Show("Are you sure you would like to exit?",  "ChatMessageSystem-Exit", MessageBoxButtons.YesNo);
            
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ChatBoxForm ss = new ChatBoxForm();
            ss.Show();
            this.Hide();
        }
    }
}
