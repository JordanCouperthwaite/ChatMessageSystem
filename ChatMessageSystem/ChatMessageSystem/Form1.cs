using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            //user prompt to exit the program.
            var result = MessageBox.Show("Are you sure you would like to exit?",  "ChatMessageSystem-Exit", MessageBoxButtons.YesNo);
            
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //SQL connection created.
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wolf\Documents\ChatMessageSystemDB.mdf;Integrated Security=True;Connect Timeout=30");
            /*Selects all the instances where the specified Username and Password are input, there will only be one as Username is unique.
             * If an instance is found, count will equal 1 which fufills the if statement and confirms Authentication to the server. */
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From LoginTable where UserName = '" + txtBoxUsername.Text + "' and Password = '" + txtBoxPassword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                ChatBoxForm ss = new ChatBoxForm();
                ss.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username/Password, please try again.", "Authentication Failed.", MessageBoxButtons.OK);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();

        }
    }
}
