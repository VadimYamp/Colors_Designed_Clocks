using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock7
{
    public partial class Screen : Form
    {
        public Screen()
        {
        InitializeComponent();
        }

        private void Tick(object sender, EventArgs e)
        {
            int S, M, H;
            string[] str = new string[2];
            byte[] X = new byte[4];
            byte[] Y = new byte[4];
            byte[] Z = new byte[4];
            int[] fl = new int[7];
            S = DateTime.Now.Second;
            M = DateTime.Now.Minute;
            H = DateTime.Now.Hour;


            fl[0] = 12 * (H % 2) + M / 5;
            fl[1] = 6 * (M % 5) + (S / 20) + 4;
            fl[2] = S / 20;
            fl[3] = M % 5;
            fl[4] = S / 20;
            fl[5] = (M / 5) % 3;
            fl[6] = (H % 6) / 2;
            if (fl[6] == 2)
            {
                fl[2] = (M / 5) % 3;
                fl[5] = S / 20;
            }

            switch (fl[0])
            {
                case 0:
                    L2.Text = "         רחוב              ";
                    break;

                case 1:
                    L2.Text = "         שכונה             ";
                    break;

                case 2:
                    L2.Text = "          עיר              ";
                    break;



                case 3:
                    L2.Text = "          ציר              ";
                    break;

                case 4:
                    L2.Text = "          מסך              ";
                    break;

                case 5:
                    L2.Text = "          חלל              ";
                    break;



                case 6:
                    L2.Text = "         כיתה                ";
                    break;

                case 7:
                    L2.Text = "        מחלקה               ";
                    break;

                case 8:
                    L2.Text = "        פלוגה               ";
                    break;



                case 9:
                    L2.Text = "       פונקציה               ";
                    break;

                case 10:
                    L2.Text = "      אפליקציה               ";
                    break;

                case 11:
                    L2.Text = "       פרוייקט               ";
                    break;



                case 12:
                    L2.Text = "         אֱלוּל                 ";
                    break;

                case 13:
                    L2.Text = "         תִּשְׁרֵי                 ";
                    break;

                case 14:
                    L2.Text = "         חֶשְׁוָן                 ";
                    break;



                case 15:
                    L2.Text = "         כִּסְלֵו                 ";
                    break;

                case 16:
                    L2.Text = "         טֵבֵת                  ";
                    break;

                case 17:
                    L2.Text = "         שְׁבָט                  ";
                    break;



                case 18:
                    L2.Text = "         אֲדָר                  ";
                    break;

                case 19:
                    L2.Text = "         נִיסָן                 ";
                    break;

                case 20:
                    L2.Text = "         אִייָּר                 ";
                    break;



                case 21:
                    L2.Text = "        סִיוָן                  ";
                    break;

                case 22:
                    L2.Text = "        תַּמּוּז                  ";
                    break;

                case 23:
                    L2.Text = "         אָב                   ";
                    break;

                default:
                    break;
            }
            switch (fl[1])
            {
                case 4:
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    L1.Text = "    4";
                    break;

                case 5:
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    L1.Text = "    5";
                    break;

                case 6:
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    L1.Text = "    6";
                    break;



                case 10:
                    X[1] = 0x00; Y[1] = 0xFF; Z[1] = 0xFF;
                    L1.Text = "   10";
                    break;

                case 11:
                    X[1] = 0x00; Y[1] = 0xFF; Z[1] = 0xFF;
                    L1.Text = "   11";
                    break;

                case 12:
                    X[1] = 0x00; Y[1] = 0xFF; Z[1] = 0xFF;
                    L1.Text = "   12";
                    break;



                case 16:
                    X[1] = 0xFF; Y[1] = 0x00; Z[1] = 0xFF;
                    L1.Text = "   16";
                    break;

                case 17:
                    X[1] = 0xFF; Y[1] = 0x00; Z[1] = 0xFF;
                    L1.Text = "   17";
                    break;

                case 18:
                    X[1] = 0xFF; Y[1] = 0x00; Z[1] = 0xFF;
                    L1.Text = "   18";
                    break;



                case 22:
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0x00;
                    L1.Text = "   22";
                    break;

                case 23:
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0x00;
                    L1.Text = "   23";
                    break;

                case 24:
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0x00;
                    L1.Text = "   24";
                    break;



                case 28:
                    X[1] = 0x00; Y[1] = 0xFF; Z[1] = 0x80;
                    L1.Text = "   28";
                    break;

                case 29:
                    X[1] = 0x00; Y[1] = 0xFF; Z[1] = 0x80;
                    L1.Text = "   29";
                    break;

                case 30:
                    X[1] = 0x00; Y[1] = 0xFF; Z[1] = 0x80;
                    L1.Text = "   30";
                    break;



                default:
                    break;
            }
            switch (fl[2])
            {
                case 0:
                    X[0] = 0x60; Y[0] = 0x00; Z[0] = 0x00;
                    break;

                case 1:
                    X[0] = 0x00; Y[0] = 0x50; Z[0] = 0x00;
                    break;

                case 2:
                    X[0] = 0x00; Y[0] = 0x00; Z[0] = 0x40;
                    break;

                default:
                    break;
            }
            switch (fl[3])
            {
                case 0:
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;

                case 1:
                    X[1] = 0x00; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;

                case 2:
                    X[1] = 0xFF; Y[1] = 0x00; Z[1] = 0xFF;
                    break;

                case 3:
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0x00;
                    break;

                case 4:
                    X[1] = 0x00; Y[1] = 0xFF; Z[1] = 0x80;
                    break;

                default:
                    break;

            }
            switch (fl[4])
            {
                case 0:
                    X[2] = 0xFF; Y[2] = 0x00; Z[2] = 0x00;
                    break;

                case 1:
                    X[2] = 0x00; Y[2] = 0xC0; Z[2] = 0x00;
                    break;

                case 2:
                    X[2] = 0x00; Y[2] = 0x00; Z[2] = 0x80;
                    break;

                default:
                    break;
            }
            switch (fl[5])
            {
                case 0:
                    X[3] = 0x00; Y[3] = 0x50; Z[3] = 0x50;
                    break;

                case 1:
                    X[3] = 0x50; Y[3] = 0x00; Z[3] = 0x50;
                    break;

                case 2:
                    X[3] = 0x50; Y[3] = 0x50; Z[3] = 0x00;
                    break;

                default:
                    break;
            }
            switch (fl[6])
            {
                case 0:
                    L0.ForeColor = Color.FromArgb(0xFF, 0xFF, 0xFF);
                    L1.ForeColor = Color.FromArgb(Y[1], Z[1], X[1]);
                    L2.ForeColor = Color.FromArgb(0xFF, 0xFF, 0xFF);

                    L0.BackColor = Color.FromArgb(Y[0], Z[0], X[0]);
                    L1.BackColor = Color.FromArgb(0x00, 0x00, 0x00);
                    L2.BackColor = Color.FromArgb(Y[3], Z[3], X[3]);
                    break;

                case 1:
                    L0.ForeColor = Color.FromArgb(Y[1], Z[1], X[1]);
                    L2.ForeColor = Color.FromArgb(Y[1], Z[1], X[1]);

                    L0.BackColor = Color.FromArgb(0x00, 0x00, 0x00);
                    L1.BackColor = Color.FromArgb(0x00, 0x00, 0x00);
                    L2.BackColor = Color.FromArgb(0x00, 0x00, 0x00);

                    if (((M / 5) % 3) == 1)
                    {
                        L1.ForeColor = Color.FromArgb(Y[2], Z[2], X[2]);
                    }
                    else
                    {
                        L1.ForeColor = Color.FromArgb(Y[1], Z[1], X[1]);
                    }

                    break;

                case 2:
                    L0.ForeColor = Color.FromArgb(0xFF, 0xFF, 0xFF);
                    L1.ForeColor = Color.FromArgb(Y[1], Z[1], X[1]);
                    L2.ForeColor = Color.FromArgb(0xFF, 0xFF, 0xFF);

                    L0.BackColor = Color.FromArgb(Y[3], Z[3], X[3]);
                    L1.BackColor = Color.FromArgb(0x00, 0x00, 0x00);
                    L2.BackColor = Color.FromArgb(Y[0], Z[0], X[0]);
                    break;

                default:
                    break;
            }

            if (H < 10)
            {
                L0.Text = DateTime.Now.ToString("      H:mm:ss    ");
            }
            else
            {
                L0.Text = DateTime.Now.ToString("     H:mm:ss     ");
            }
        }
    }
}