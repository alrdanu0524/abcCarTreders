using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abcCarTreders
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //close login form and open signup page
            this.Close();
            Console.WriteLine("exit");
            try { 
            signUp signUp = new signUp();
            signUp.Show();
            }
            
            catch(Exception ex) {

                Console.WriteLine(ex);
                    }
           
          

        }
    }
}
