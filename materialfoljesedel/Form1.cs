using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace materialfoljesedel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 1);
            Pen blokromat = new Pen(Color.Black, 1);
            Pen svartkromat = new Pen(Color.Black, 1);
            Pen sealer = new Pen(Color.Black, 1);
            Pen blokromattr = new Pen(Color.Black, 1);
            Pen vate = new Pen(Color.Black, 1);
            Point pt = new Point(20, 160);
            Point pt1 = new Point(470, 160);
            Point pt2 = new Point(20, 240);
            Point pt3 = new Point(470, 240);
            Point pt4 = new Point(20, 280);
            Point pt5 = new Point(470, 280);
            Point pt6 = new Point(20, 320);
            Point pt7 = new Point(470, 320);
            Point pt8 = new Point(20, 360);
            Point pt9 = new Point(470, 360);
            Point pt10 = new Point(20, 400);
            Point pt11 = new Point(470, 400);
            Point pt12 = new Point(20, 440);
            Point pt13 = new Point(470, 440);
            Point pt14 = new Point(20, 480);
            Point pt15 = new Point(470, 480);
            Point pt16 = new Point(20, 520);
            Point pt17 = new Point(470, 520);
            Point pt18 = new Point(260, 240);
            Point pt19 = new Point(260, 360);
            Point pt20 = new Point(260, 440);
            Point pt21 = new Point(260, 560);
            Point pt22 = new Point(780, 120);
            Point pt23 = new Point(470, 120);

            // Create location and size of rectangle.
            int x1 = 470;
            int y1 = 80;
            int width1 = 310;
            int height1 = 340;

            



            int x = 20;
            int y = 80;
            int width = 450;
            int height = 480;
           
            // Draw rectangle to screen.

            e.Graphics.DrawString("Material", new Font("Times New Roman", 45, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 45, 20);
            e.Graphics.DrawString("Följesedel", new Font("Times New Roman", 45, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Gray, 215, 20);
            if (count11 == 0)
            {

               
                e.Graphics.DrawString(dateTimePicker3.Value.ToString("yyyy-MM-dd"), new Font("Arial", 55, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Red, 480, 15);
            }
            
            e.Graphics.DrawString("Arbetsoperation", new Font("Times New Roman", 36, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 505, 80);
            e.Graphics.DrawString(label24.Text, new Font("Times New Roman", 30, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 95, 400);
            e.Graphics.DrawString("Kund", new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 25, 85);
            e.Graphics.DrawString(textBox1.Text, new Font("Times New Roman", 32, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 25, 110);

            e.Graphics.DrawString("Artikelbenämning", new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 25, 165);
            e.Graphics.DrawString(textBox2.Text, new Font("Times New Roman", 32, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 25, 190);

            e.Graphics.DrawString("Artikel nr", new Font("Times New Roman", 14, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 25, 240);
            e.Graphics.DrawString(textBox3.Text, new Font("Times New Roman", 28, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 120, 250);

            e.Graphics.DrawString("Antal", new Font("Times New Roman", 14, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 265, 240);
            e.Graphics.DrawString(textBox4.Text, new Font("Times New Roman", 28, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 320, 250);

            e.Graphics.DrawString("Order nr", new Font("Times New Roman", 14, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 25, 280);
            e.Graphics.DrawString(textBox5.Text, new Font("Times New Roman", 28, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 120, 290);

            e.Graphics.DrawString("Önskad Lev. tid", new Font("Times New Roman", 14, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 265, 280);
            e.Graphics.DrawString(dateTimePicker1.Value.ToString("yyyy-MM-dd"), new Font("Times New Roman", 24, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 320, 295);

            e.Graphics.DrawString("Antal pallar", new Font("Times New Roman", 14, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 25, 320);
            e.Graphics.DrawString(textBox7.Text, new Font("Times New Roman", 28, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 120, 330);

            e.Graphics.DrawString("Antal kragar", new Font("Times New Roman", 14, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 265, 320);
            e.Graphics.DrawString(textBox8.Text, new Font("Times New Roman", 28, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 350, 330);


            e.Graphics.DrawString("Anmärkning", new Font("Times New Roman", 14, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 25, 360);
            e.Graphics.DrawString(textBox9.Text, new Font("Times New Roman", 28, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 120, 370);

            e.Graphics.DrawString("Antal st per skena / kg i trumma", new Font("Times New Roman", 14, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 25, 440);
            e.Graphics.DrawString(textBox10.Text, new Font("Times New Roman", 24, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 120, 455);

            e.Graphics.DrawString("Produktionsdatum", new Font("Times New Roman", 14, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 265, 440);
            e.Graphics.DrawString(dateTimePicker2.Value.ToString("yyyy-MM-dd"), new Font("Times New Roman", 24, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 320, 455);

            e.Graphics.DrawString("Antal pallar", new Font("Times New Roman", 14, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 25, 480);
            e.Graphics.DrawString(textBox12.Text, new Font("Times New Roman", 28, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 120, 490);

            e.Graphics.DrawString("Antal kragar", new Font("Times New Roman", 14, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 265, 480);
            e.Graphics.DrawString(textBox13.Text, new Font("Times New Roman", 28, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 350, 490);

            e.Graphics.DrawString("Lev. antal st/kg", new Font("Times New Roman", 14, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 25, 520);
            e.Graphics.DrawString(textBox14.Text, new Font("Times New Roman", 28, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 120, 530);


            e.Graphics.DrawString("Sign.", new Font("Times New Roman", 14, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 265, 520);
            e.Graphics.DrawString(textBox15.Text, new Font("Arial", 28, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 320, 530);



            //HangZink
            e.Graphics.DrawString(label1.Text, new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 492, 130);
            e.Graphics.DrawString("Blåkromat (3+)", new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 525, 162);
            e.Graphics.DrawString("Svartkromat (3+)", new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 525, 195);
            e.Graphics.DrawString("Sealer", new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 525, 225);

            //Hangnikel
            e.Graphics.DrawString(label3.Text, new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 492, 270);
            e.Graphics.DrawString(checkBox10.Text, new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 525, 297);
            e.Graphics.DrawString(checkBox7.Text, new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 525, 327);

            e.Graphics.DrawString(checkBox8.Text, new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 525, 357);
            e.Graphics.DrawString(checkBox9.Text, new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 525, 387);

            //TrumaZink
            e.Graphics.DrawString(label2.Text, new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 640, 130);
            e.Graphics.DrawString("Blåkromat (3+)", new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 670, 163);
            e.Graphics.DrawString(checkBox4.Text, new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 670, 195);

            //TrummaSvart
            e.Graphics.DrawString(label4.Text, new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 640, 250);
            e.Graphics.DrawString(checkBox12.Text, new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 670, 277);
            //TrummaNickel
            e.Graphics.DrawString(label4.Text, new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 640, 327);
            e.Graphics.DrawString(checkBox13.Text, new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 670, 357);




            e.Graphics.DrawRectangle(blackPen, x, y, width, height);
            e.Graphics.DrawRectangle(blackPen, x1, y1, width1, height1);
            e.Graphics.DrawLine(blackPen, pt, pt1);
            e.Graphics.DrawLine(blackPen, pt2, pt3);
            e.Graphics.DrawLine(blackPen, pt4, pt5);
            e.Graphics.DrawLine(blackPen, pt6, pt7);
            e.Graphics.DrawLine(blackPen, pt8, pt9);
            e.Graphics.DrawLine(blackPen, pt10, pt11);
            e.Graphics.DrawLine(blackPen, pt12, pt13);
            e.Graphics.DrawLine(blackPen, pt14, pt15);
            e.Graphics.DrawLine(blackPen, pt16, pt17);
            e.Graphics.DrawLine(blackPen, pt18, pt19);
            e.Graphics.DrawLine(blackPen, pt20, pt21);
            e.Graphics.DrawLine(blackPen, pt22, pt23);
            Bitmap btm = Properties.Resources.Swedecote_Logo1;
            Image img = btm;
            e.Graphics.DrawImage(img, 500, 440, 280, 60);
            Image img1 = Properties.Resources.uncheckedx60;

            e.Graphics.DrawString(lblAdress.Text, new Font("Microsoft Sans Serif", 10, FontStyle.Regular, GraphicsUnit.Pixel),Brushes.Black, 495, 525);
            e.Graphics.DrawString(label19.Text, new Font("Microsoft Sans Serif", 10, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 500, 545);

            if (count == 1)
            {
                //e.Graphics.FillRectangle(Brushes.Black, new Rectangle(492, 162, 24, 24));
                e.Graphics.DrawImage(img1, 488, 155, 37, 37);

            }
            
            if (count1 == 1)
            {
                //e.Graphics.FillRectangle(Brushes.Black, new Rectangle(492, 192, 24, 24));
                e.Graphics.DrawImage(img1, 488, 185, 37, 37);
            }

            if (count2 == 1)
            {
                //e.Graphics.FillRectangle(Brushes.Black, new Rectangle(492, 222, 24, 24));
                e.Graphics.DrawImage(img1, 488, 215, 37, 37);
            }

            if (count3 == 1)
            {
                //e.Graphics.FillRectangle(Brushes.Black, new Rectangle(650, 162, 24, 24));
                e.Graphics.DrawImage(img1, 636, 155, 37, 37);
            }
            if (count4 == 1)
            {
               // e.Graphics.FillRectangle(Brushes.Black, new Rectangle(650, 192, 24, 24));
                e.Graphics.DrawImage(img1, 636, 185, 37, 37);
            }
            if (count5 == 1)
            {
                // e.Graphics.FillRectangle(Brushes.Black, new Rectangle(650, 192, 24, 24));
                e.Graphics.DrawImage(img1, 488, 290, 37, 37);
            }
            if (count6 == 1)
            {
                // e.Graphics.FillRectangle(Brushes.Black, new Rectangle(650, 192, 24, 24));
                e.Graphics.DrawImage(img1, 488, 320, 37, 37);
            }
            if (count7 == 1)
            {
                // e.Graphics.FillRectangle(Brushes.Black, new Rectangle(650, 192, 24, 24));
                e.Graphics.DrawImage(img1, 488, 350, 37, 37);
            }
            if (count8 == 1)
            {
                // e.Graphics.FillRectangle(Brushes.Black, new Rectangle(650, 192, 24, 24));
                e.Graphics.DrawImage(img1, 488, 380, 37, 37);
            }
            if (count9 == 1)
            {
                // e.Graphics.FillRectangle(Brushes.Black, new Rectangle(650, 192, 24, 24));
                e.Graphics.DrawImage(img1, 636, 270, 37, 37);
            }
            if (count10 == 1)
            {
                // e.Graphics.FillRectangle(Brushes.Black, new Rectangle(650, 192, 24, 24));
                e.Graphics.DrawImage(img1, 636, 350, 37, 37);
            }



           //HangZink
            //e.Graphics.DrawRectangle(blokromat, blokromatx, blokromaty, blokromatwidth, blokromatheight);
            e.Graphics.DrawImage(Properties.Resources.checked_checkbox_60px, 488, 155,37, 37);
            e.Graphics.DrawImage(Properties.Resources.checked_checkbox_60px, 488, 185, 37, 37);
            e.Graphics.DrawImage(Properties.Resources.checked_checkbox_60px, 488, 215, 37, 37);

            //TrummaBLO
            e.Graphics.DrawImage(Properties.Resources.checked_checkbox_60px, 636, 155, 37, 37);
            e.Graphics.DrawImage(Properties.Resources.checked_checkbox_60px, 636, 185, 37, 37);

            //HangNikel
            e.Graphics.DrawImage(Properties.Resources.checked_checkbox_60px, 488, 290, 37, 37);
            e.Graphics.DrawImage(Properties.Resources.checked_checkbox_60px, 488, 320, 37, 37);
            e.Graphics.DrawImage(Properties.Resources.checked_checkbox_60px, 488, 350, 37, 37);
            e.Graphics.DrawImage(Properties.Resources.checked_checkbox_60px, 488, 380, 37, 37);

            //TrummaSvart
            e.Graphics.DrawImage(Properties.Resources.checked_checkbox_60px, 636, 270, 37, 37);
            

            //TrummaNikel
            e.Graphics.DrawImage(Properties.Resources.checked_checkbox_60px, 636, 350, 37, 37);
            


        }
        int count = 0;
        int count1 = 0;
        int count2 = 0;
        int count3 = 0;
        int count4 = 0;
        int count5 = 0;
        int count6 = 0;
        int count7 = 0;
        int count8 = 0;
        int count9 = 0;
        int count10 = 0;
        int count11 = 0;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                count = 1;
            }
            else
            {
                count = 0;
            }
        }
        Control Control = new Control();
        protected override void OnResize(EventArgs e)
        {
            Control.Width += 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.FormatCustom = "yyyy-MM-dd";
            dateTimePicker2.FormatCustom = "yyyy-MM-dd";
            dateTimePicker3.FormatCustom = "yyyy-MM-dd";
            dateTimePicker3.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            dateTimePicker1.Value = DateTime.Today;

            
            


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                count1 = 1;
            }
            else
            {
                count1 = 0;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                count2 = 1;
            }
            else
            {
                count2 = 0;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                count3 = 1;
            }
            else
            {
                count3 = 0;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                count4 = 1;
            }
            else
            {
                count4 = 0;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                count5 = 1;
            }
            else
            {
                count5 = 0;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                count6 = 1;
            }
            else
            {
                count6 = 0;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                count7 = 1;
            }
            else
            {
                count7 = 0;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                count8 = 1;
            }
            else
            {
                count8 = 0;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                count9 = 1;
            }
            else
            {
                count9 = 0;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                count10 = 1;
            }
            else
            {
                count10 = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox13.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox12.Checked = false;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox15.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox14.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox5.Checked)
            {
                count11 = 1;
            }
            else
            {
                count11 = 0;
            }
            
        }

        

        


      

        

        

        private void print_Button_Click(object sender, EventArgs e)
        {
           
                
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Faktura", 900, 1190);


            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            
            printPreviewDialog1.FindForm().WindowState = FormWindowState.Maximized;
            printPreviewDialog1.FindForm().TopMost = true;
            printPreviewDialog1.ShowDialog();


            
        }
    }
}
