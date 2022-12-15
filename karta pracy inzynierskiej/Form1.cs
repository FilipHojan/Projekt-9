using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace karta_pracy_inzynierskiej
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool x = false;
        bool y = false;
        bool z = false;

        /*
         */

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (x == true)
            {
                if (textBox1.Text == "Politechnika Poznańska" || textBox1.Text == "politechnika Poznańska" || textBox1.Text == "Politechnika poznańska" || textBox1.Text == "politechnika poznańska" || textBox1.Text == "Politechnika Poznanska")
                {
                    textBox1.Text = "Politechnika Poznańska";
                    MessageBox.Show("Zapisano jako: \n Politechnika Poznańska");
                }
                else
                {
                    x = false;
                    MessageBox.Show("ERROR \n Podpowiedź: \n Spójrz na logo formularza :)");
                }
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                x = true;
            }
        }
        /*
         */

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        /*
         */

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        /*
         */

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (y == true)
            {
                if (textBox10.Text == "Ogolnoakademicki" || textBox10.Text == "Ogólnoakademicki" || textBox10.Text == "ogólnoakademicki" || textBox10.Text == "ogolnoakademicki")
                {
                    textBox10.Text = "Ogólnoakademicki";
                    MessageBox.Show("Zapisano jako: \n Ogólnoakademicki");
                }
                else
                {
                    y = false;
                    MessageBox.Show("ERROR");
                }
            }
        }
        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                y = true;
            }
        }

        /*
         */

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (z == true)
            {
                if (textBox11.Text == "Stacjonarne" || textBox11.Text == "stacjonarne")
                {
                    textBox1.Text = "Stacjonarne";
                    MessageBox.Show("Zapisano jako: \n Stacjonarne");
                }
                else if (textBox11.Text == "Zaoczne" || textBox11.Text == "zaoczne")
                {
                    textBox1.Text = "Zaoczne";
                    MessageBox.Show("Zapisano jako: \n Zaoczne");
                }
                else
                {
                    z = false;
                    MessageBox.Show("ERROR");
                }
            }
        }
        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {

                z = true;
            }
        }

        /*
         */

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        /*
         */

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        /*
         */

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        /*
         */

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        /*
         */

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        /*
         */

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        /*
         */

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        /*
         */

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        /*
         */

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {

        }





























        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }









        private void button1_Click(object sender, EventArgs e)
        {
            /*
            SautinSoft.PdfVision v = new SautinSoft.PdfVision();

            string screen = @"screenshot.png";
            v.PageStyle.PageSize.Auto();

            // Create screen with 1920*1040 px.
            Rectangle rect = new Rectangle(0, 0, 1920, 1040);
            Bitmap bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.Right, rect.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
            bmp.Save(screen, ImageFormat.Png);

            // Create object of Image class from file.
            System.Drawing.Image image = Image.FromFile(screen);

            byte[] imgBytes = null;

            using (MemoryStream ms = new System.IO.MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imgBytes = ms.ToArray();
            }

            // Convert image stream to PDF file.
            FileInfo outFile = new FileInfo(@"Result.pdf");
            int ret = v.ConvertImageStreamToPDFFile(imgBytes, outFile.FullName);
            if (ret == 0)
            {
                // Open the resulting PDF document in a default PDF Viewer.
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outFile.FullName) { UseShellExecute = true });
            }
            */
        }




    }
}
