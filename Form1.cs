using System;
using System.Net;
using System.Text;
using System.Windows.Forms;

//script for sale
//inbox telegram: @Anh2Ten
// Price: 300$ USDT or BITCOIN


namespace Xiaomi_IMEI_information
{
    partial class Form1 : Form
    {
        WebClient client = new WebClient();

        public Form1()
        {
            InitializeComponent();
            LoadCaptcha();
        }

        private void LoadCaptcha()
        {
            try
            {
                byte[] imageBytes = client.DownloadData("https://anhotaku.xyz/api/mi/captcha.php");
                pictureBox1.Image = Image.FromStream(new System.IO.MemoryStream(imageBytes));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string imeiText = imei.Text;
                string captchaCode = captcha.Text;

                string getUrl = $"https://anhotaku.xyz/api/mi/api.php?imei={imeiText}&code={captchaCode}";

                string response = client.DownloadString(getUrl);

                MessageBox.Show(response);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            LoadCaptcha();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadCaptcha();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void captcha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
