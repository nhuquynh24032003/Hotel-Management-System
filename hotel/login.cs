using BUS;
using DTO;
namespace hotel
{
    public partial class login : Form
    {
        BUS_TaiKhoan bTK = new BUS_TaiKhoan();

        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            

            if(txt_name.Text != "" && txt_pass.Text != "")
            {
                if (bTK.checkLogin(txt_name.Text, txt_pass.Text))
                {
                    this.Hide();
                    home home = new home();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }
            else
            {
                MessageBox.Show("Not Enough Information");
            }

        }
    }
}