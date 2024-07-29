using WinFormsApp;

namespace abcCarTreders
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        string s_name, s_pass,s_data,s_colom;
        private void button1_Click(object sender, EventArgs e)
        {
            saveItemDetais();
    }

        private void saveItemDetais()
        {
            try
            {
                s_name = txtName.Text;
                s_pass = txtPass.Text;
                s_colom = "name,password";
                s_data = $"'{s_name}', '{s_pass}'";

                string result = MC_DB.AddDataWithColumns("test", s_colom, s_data);
                if (result == "Success")
                {
                    // data save in Db 
                    MessageBox.Show("Your data has been successfully inserted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Show the error message
                    MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                clearData();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        private void clearData()
        {
            //cleate tf data and set cursor
            txtName.ResetText();
            txtPass.ResetText();
            txtName.Focus();
        }
    }
}
