using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserNameSpace;
namespace Login_Form
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string inputPass = txtBpassword.Text;
            string inputID = txtBusername.Text;

            Administrator systemAdmin = new Administrator("Lebron", "admin123", "5678");

            if (systemAdmin.verifyLogin(inputID, inputPass))
            {
                MessageBox.Show("NakaLOGIN KANA SAWAKAS.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                systemAdmin.updatePassword("BagongPassword123");
                MessageBox.Show("Bagong password yarn?");

                systemAdmin.updateAdminName("Curry");
                MessageBox.Show("Bagong Name yarn?");

            }
            else
            {
                MessageBox.Show("Mali ka ng nilagay dodong");
            }
        }
    }
}

namespace UserNameSpace
{
    public class User
    {
        private string user_id;
        protected string user_password;

        public User(string id, string pass)
        {
            this.user_id = id;
            this.user_password = pass;
        }

        public bool verifyLogin(string id, string pass)
        {
            if (this.user_id.Equals(id) && this.user_password.Equals(pass))
            {
                return true;
            }
            return false;
        }

        private void updatePassword(string newPassword)
        {

            this.user_password = newPassword;
        }
    }


    public class Administrator : User
    {
        private string admin_name;

        public Administrator(string name, string id, string pass) : base(id, pass)
        {
            this.admin_name = name;


        }

        public void updatePassword(string newPassword)
        {
            this.user_password = newPassword;
        }

        public void updateAdminName(string name)
        {
            this.admin_name = name;
        }

    }


}