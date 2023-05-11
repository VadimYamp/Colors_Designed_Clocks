using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Good_Day
{
    public partial class Screen : Form
    {
        byte[] X = new byte[4];
        byte[] Y = new byte[4];
        byte[] Z = new byte[4];
        int Year, DG, H, M, Sz, Pr, Ev;
        int[] D = new int[3];
        int[] Sat_H = new int[2];
        int[] Sat_M = new int[2];
        public Screen()
        {
        InitializeComponent();
        }

        private void Tick(object sender, EventArgs e)
        {
            Sat_H[0] = 19; Sat_M[0] = 24;
            Sat_H[1] = 17; Sat_M[1] = 30;

            H = DateTime.Now.Hour;
            M = DateTime.Now.Minute;
            DG = DateTime.Now.DayOfYear;
            Year = DateTime.Now.Year;

            //                            שנת תשפ"ג   
            D[1] = Convert.ToInt32(DateTime.Now.DayOfWeek) + 1;
            D[2] = ((365 * (Year - 2022)) + (DG - 240)) / 7 + 1;

            if (D[0] == 3)
            {
                DG--;
                if (D[1] == 1)
                {
                    D[1] = 7;
                }
                else
                {
                    D[1]--;
                }
            }
            if (H < 6)
            {
                D[0] = 3;
            }
            else
            {
                D[0] = H / 6 - 1;
            }

            switch (D[0])
            {
                case 0:
                    L1.Text = "בוקר טוב";
                    break;

                case 1:
                    L1.Text = "צהריים טובים";
                    break;

                case 2:
                    L1.Text = "ערב טוב";
                    break;

                case 3:
                    L1.Text = "לילה טוב";
                    break;

                default:
                    break;
            }
            switch (D[2])
            {
                //סתיו
                //שבוע 1
                case 1:
                    Sz = 2;
                    Pr = 5;
                     if (D[1] > 5)
                     {
                        L3.Text = "פָּרָשַׁת שֹׁפְטִים";
                     }
                     else
                    {
                        L3.Text = "סתיו שבוע 1";
                    }
                    L4.Text = "הדלקת נרות ב-18:34";
                    L5.Text = "צאת השבת ב-19:41";

                    Sat_H[0] = 18; Sat_M[0] = 34;
                    Sat_H[1] = 19; Sat_M[1] = 41;

                    X[0] = 0x60; Y[0] = 0x00; Z[0] = 0X00;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 2
                case 2:
                    Sz = 2;
                    Pr = 5;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת כִּי-תֵצֵא";
                    }
                    else
                    {
                        L3.Text = "סתיו שבוע 2";
                    }
                    L4.Text = "הדלקת נרות ב-18:25";
                    L5.Text = "צאת השבת ב-19:32";

                    Sat_H[0] = 18; Sat_M[0] = 25;
                    Sat_H[1] = 19; Sat_M[1] = 32;

                    X[0] = 0x60; Y[0] = 0x00; Z[0] = 0X00;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 3
                case 3:
                    Sz = 2;
                    Pr = 5;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת כִּי-תָבוֹא";
                    }
                    else
                    {
                        L3.Text = "סתיו שבוע 3";
                    }
                    L4.Text = "הדלקת נרות ב-18:15";
                    L5.Text = "צאת השבת ב-19:22";

                    Sat_H[0] = 18; Sat_M[0] = 15;
                    Sat_H[1] = 19; Sat_M[1] = 22;

                    X[0] = 0x00; Y[0] = 0x50; Z[0] = 0X00;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 4
                case 4:
                    Sz = 2;
                    Pr = 5;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת נִצָּבִים";
                    }
                    else
                    {
                        L3.Text = "סתיו שבוע 4";
                    }
                    L4.Text = "הדלקת נרות ב-18:06";
                    L5.Text = "צאת השבת ב-19:13";

                    Sat_H[0] = 18; Sat_M[0] = 06;
                    Sat_H[1] = 19; Sat_M[1] = 13;

                    X[0] = 0x00; Y[0] = 0x50; Z[0] = 0X00;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 5
                case 5:
                    Sz = 2;
                    Pr = 5;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת וַיֵּלֶךְ";
                    }
                    else
                    {
                        L3.Text = "סתיו שבוע 5";
                    }
                    L4.Text = "הדלקת נרות ב-17:56";
                    L5.Text = "צאת השבת ב-19:03";

                    Sat_H[0] = 17; Sat_M[0] = 56;
                    Sat_H[1] = 19; Sat_M[1] = 03;

                    X[0] = 0x00; Y[0] = 0x00; Z[0] = 0X40;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 6
                case 6:
                    Sz = 2;
                    Pr = 5;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת הַאֲזִינוּ";
                    }
                    else
                    {
                        L3.Text = "סתיו שבוע 6";
                    }
                    L4.Text = "הדלקת נרות ב-17:47";
                    L5.Text = "צאת השבת ב-18:54";

                    Sat_H[0] = 17; Sat_M[0] = 47;
                    Sat_H[1] = 18; Sat_M[1] = 54;

                    X[0] = 0x00; Y[0] = 0x00; Z[0] = 0X40;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 7
                case 7:
                    Sz = 2;
                    Pr = 5;
                    if (D[1] > 5)
                    {
                        L3.Text = "חג סוכות";
                    }
                    else
                    {
                        L3.Text = "סתיו שבוע 7";
                    }
                    L4.Text = "הדלקת נרות ב-17:39";
                    L5.Text = "צאת השבת ב-18:46";

                    Sat_H[0] = 17; Sat_M[0] = 39;
                    Sat_H[1] = 18; Sat_M[1] = 46;

                    X[0] = 0x00; Y[0] = 0xFF; Z[0] = 0X80;
                    X[1] = 0x00; Y[1] = 0x00; Z[1] = 0x00;
                    break;
                //שבוע 8
                case 8:
                    Sz = 2;
                    Pr = 5;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת בְּרֵאשִׁית";
                    }
                    else
                    {
                        L3.Text = "סתיו שבוע 8";
                    }
                    L4.Text = "הדלקת נרות ב-17:31";
                    L5.Text = "צאת השבת ב-18:38";

                    Sat_H[0] = 17; Sat_M[0] = 31;
                    Sat_H[1] = 18; Sat_M[1] = 38;

                    X[0] = 0x00; Y[0] = 0x50; Z[0] = 0X50;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 9
                case 9:
                    Sz = 2;
                    Pr = 5;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת נֹחַ";
                    }
                    else
                    {
                        L3.Text = "סתיו שבוע 9";
                    }
                    L4.Text = "הדלקת נרות ב-17:23";
                    L5.Text = "צאת השבת ב-18:30";

                    Sat_H[0] = 17; Sat_M[0] = 23;
                    Sat_H[1] = 18; Sat_M[1] = 30;

                    X[0] = 0x00; Y[0] = 0x50; Z[0] = 0X50;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 10
                case 10:
                    Sz = 2;
                    Pr = 5;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת לֶךְ-לְךָ";
                    }
                    else
                    {
                        L3.Text = "סתיו שבוע 10";
                    }
                    L4.Text = "הדלקת נרות ב-16:17";
                    L5.Text = "צאת השבת ב-17:24";

                    Sat_H[0] = 16; Sat_M[0] = 17;
                    Sat_H[1] = 17; Sat_M[1] = 24;

                    X[0] = 0x50; Y[0] = 0x00; Z[0] = 0X50;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 11
                case 11:
                    Sz = 2;
                    Pr = 5;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת וַיֵּרָא";
                    }
                    else
                    {
                        L3.Text = "סתיו שבוע 11";
                    }
                    L4.Text = "הדלקת נרות ב-16:12";
                    L5.Text = "צאת השבת ב-17:19";

                    Sat_H[0] = 16; Sat_M[0] = 12;
                    Sat_H[1] = 17; Sat_M[1] = 19;

                    X[0] = 0x50; Y[0] = 0x00; Z[0] = 0X50;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 12
                case 12:
                    Sz = 2;
                    Pr = 5;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת חַיֵּי-שָׂרָה";
                    }
                    else
                    {
                        L3.Text = "סתיו שבוע 12";
                    }
                    L4.Text = "הדלקת נרות ב-16:08";
                    L5.Text = "צאת השבת ב-17:15";

                    Sat_H[0] = 16; Sat_M[0] = 08;
                    Sat_H[1] = 17; Sat_M[1] = 15;

                    X[0] = 0x50; Y[0] = 0x50; Z[0] = 0X00;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 13
                case 13:
                    Sz = 2;
                    Pr = 5;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת תּוֹלְדוֹת";
                    }
                    else
                    {
                        L3.Text = "סתיו שבוע 13";
                    }
                    L4.Text = "הדלקת נרות ב-16:05";
                    L5.Text = "צאת השבת ב-17:12";

                    Sat_H[0] = 16; Sat_M[0] = 05;
                    Sat_H[1] = 17; Sat_M[1] = 12;

                    X[0] = 0x50; Y[0] = 0x50; Z[0] = 0X00;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;


                //חורף
                //שבוע 1
                case 14:
                    Sz = 0;
                    Pr = 1;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת וַיֵּצֵא";
                    }
                    else
                    {
                        L3.Text = "חורף שבוע 1";
                    }
                    L4.Text = "הדלקת נרות ב-16:04";
                    L5.Text = "צאת השבת ב-17:11";

                    Sat_H[0] = 16; Sat_M[0] = 04;
                    Sat_H[1] = 17; Sat_M[1] = 11;

                    X[0] = 0x60; Y[0] = 0x00; Z[0] = 0X00;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 2
                case 15:
                    Sz = 0;
                    Pr = 1;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת וַיִּשְׁלַח";
                    }
                    else
                    {
                        L3.Text = "חורף שבוע 2";
                    }
                    L4.Text = "הדלקת נרות ב-16:04";
                    L5.Text = "צאת השבת ב-17:11";

                    Sat_H[0] = 16; Sat_M[0] = 04;
                    Sat_H[1] = 17; Sat_M[1] = 11;

                    X[0] = 0x00; Y[0] = 0x50; Z[0] = 0X00;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 3
                case 16:
                    Sz = 0;
                    Pr = 1;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת וַיֵּשֶׁב";
                    }
                    else
                    {
                        L3.Text = "חורף שבוע 3";
                    }
                    L4.Text = "הדלקת נרות ב-16:06";
                    L5.Text = "צאת השבת ב-17:13";

                    Sat_H[0] = 16; Sat_M[0] = 06;
                    Sat_H[1] = 17; Sat_M[1] = 13;

                    X[0] = 0x00; Y[0] = 0x00; Z[0] = 0x40;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 4
                case 17:
                    Sz = 0;
                    Pr = 2;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת מִקֵּץ";
                    }
                    else
                    {
                        L3.Text = "חורף שבוע 4";
                    }
                    L4.Text = "הדלקת נרות ב-16:09";
                    L5.Text = "צאת השבת ב-17:16";

                    Sat_H[0] = 16; Sat_M[0] = 09;
                    Sat_H[1] = 17; Sat_M[1] = 16;

                    X[0] = 0x60; Y[0] = 0x00; Z[0] = 0x00;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 5
                case 18:
                    Sz = 0;
                    Pr = 2;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת וַיִּגַּשׁ";
                    }
                    else
                    {
                        L3.Text = "חורף שבוע 5";
                    }
                    L4.Text = "הדלקת נרות ב-16:14";
                    L5.Text = "צאת השבת ב-17:21";

                    Sat_H[0] = 16; Sat_M[0] = 14;
                    Sat_H[1] = 17; Sat_M[1] = 21;

                    X[0] = 0x00; Y[0] = 0x50; Z[0] = 0x00;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 6
                case 19:
                    Sz = 0;
                    Pr = 2;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת וַיְחִי";
                    }
                    else
                    {
                        L3.Text = "חורף שבוע 6";
                    }
                    L4.Text = "הדלקת נרות ב-16:19";
                    L5.Text = "צאת השבת ב-17:26";

                    Sat_H[0] = 16; Sat_M[0] = 19;
                    Sat_H[1] = 17; Sat_M[1] = 26;

                    X[0] = 0x00; Y[0] = 0x00; Z[0] = 0x40;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 7
                case 20:
                    Sz = 0;
                    Pr = 3;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת שְׁמוֹת";
                    }
                    else
                    {
                        L3.Text = "חורף שבוע 7";
                    }
                    L4.Text = "הדלקת נרות ב-16:25";
                    L5.Text = "צאת השבת ב-17:32";

                    Sat_H[0] = 16; Sat_M[0] = 25;
                    Sat_H[1] = 17; Sat_M[1] = 32;

                    X[0] = 0x60; Y[0] = 0x00; Z[0] = 0x00;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 8
                case 21:
                    Sz = 0;
                    Pr = 3;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת וָאֵרָא";
                    }
                    else
                    {
                        L3.Text = "חורף שבוע 8";
                    }
                    L4.Text = "הדלקת נרות ב-16:31";
                    L5.Text = "צאת השבת ב-17:38";

                    Sat_H[0] = 16; Sat_M[0] = 31;
                    Sat_H[1] = 17; Sat_M[1] = 38;

                    X[0] = 0x00; Y[0] = 0x50; Z[0] = 0x00;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 9
                case 22:
                    Sz = 0;
                    Pr = 3;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת בֹּא";
                    }
                    else
                    {
                        L3.Text = "חורף שבוע 9";
                    }
                    L4.Text = "הדלקת נרות ב-16:38";
                    L5.Text = "צאת השבת ב-17:45";

                    Sat_H[0] = 16; Sat_M[0] = 38;
                    Sat_H[1] = 17; Sat_M[1] = 45;

                    X[0] = 0x00; Y[0] = 0x00; Z[0] = 0x40;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 10
                case 23:
                    Sz = 0;
                    Pr = 4;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת בְּשַׁלַּח";
                    }
                    else
                    {
                        L3.Text = "חורף שבוע 10";
                    }
                    L4.Text = "הדלקת נרות ב-16:44";
                    L5.Text = "צאת השבת ב-17:51";

                    Sat_H[0] = 16; Sat_M[0] = 44;
                    Sat_H[1] = 17; Sat_M[1] = 51;

                    X[0] = 0x60; Y[0] = 0x00; Z[0] = 0x00;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 11
                case 24:
                    Sz = 0;
                    Pr = 4;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת יִתְרוֹ";
                    }
                    else
                    {
                        L3.Text = "חורף שבוע 11";
                    }
                    L4.Text = "הדלקת נרות ב-16:51";
                    L5.Text = "צאת השבת ב-17:58";

                    Sat_H[0] = 16; Sat_M[0] = 51;
                    Sat_H[1] = 17; Sat_M[1] = 58;

                    X[0] = 0x00; Y[0] = 0x50; Z[0] = 0x00;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 12
                case 25:
                    Sz = 0;
                    Pr = 4;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת מִשְׁפָּטִים";
                    }
                    else
                    {
                        L3.Text = "חורף שבוע 12";
                    }
                    L4.Text = "הדלקת נרות ב-16:57";
                    L5.Text = "צאת השבת ב-18:04";

                    Sat_H[0] = 16; Sat_M[0] = 57;
                    Sat_H[1] = 18; Sat_M[1] = 04;

                    X[0] = 0x00; Y[0] = 0x00; Z[0] = 0x40;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;


                //חודש אדר א
                //שבוע אמצע
                case 26:
                    Sz = 2;
                    Pr = 5;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת תְּרוּמָה";
                    }
                    else
                    {
                        L3.Text = "שבוע אמצע";
                    }
                    L4.Text = "הדלקת נרות ב-17:03";
                    L5.Text = "צאת השבת ב-18:10";

                    Sat_H[0] = 17; Sat_M[0] = 03;
                    Sat_H[1] = 18; Sat_M[1] = 10;

                    X[0] = 0x20; Y[0] = 0x20; Z[0] = 0x20;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;



                //אביב
                //שבוע 1
                case 27:
                    Sz = 2;
                    Pr = 5;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת תְּצַוֶּה";
                    }
                    else
                    {
                        L3.Text = "אביב שבוע 1";
                    }
                    L4.Text = "הדלקת נרות ב-17:09";
                    L5.Text = "צאת השבת ב-18:16";

                    Sat_H[0] = 17; Sat_M[0] = 09;
                    Sat_H[1] = 18; Sat_M[1] = 16;

                    X[0] = 0x00; Y[0] = 0x50; Z[0] = 0X50;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 2
                case 28:
                    Sz = 2;
                    Pr = 5;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת כִּי-תִשָּׂא";
                    }
                    else
                    {
                        L3.Text = "אביב שבוע 2";
                    }
                    L4.Text = "הדלקת נרות ב-17:14";
                    L5.Text = "צאת השבת ב-18:21";

                    Sat_H[0] = 17; Sat_M[0] = 14;
                    Sat_H[1] = 18; Sat_M[1] = 21;

                    X[0] = 0x00; Y[0] = 0x50; Z[0] = 0X50;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 3
                case 29:
                    Sz = 2;
                    Pr = 5;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת וַיַּקְהֵל,פְּקוּדֵי";
                    }
                    else
                    {
                        L3.Text = "אביב שבוע 3";
                    }
                    L4.Text = "הדלקת נרות ב-17:19";
                    L5.Text = "צאת השבת ב-18:26";

                    Sat_H[0] = 17; Sat_M[0] = 19;
                    Sat_H[1] = 18; Sat_M[1] = 26;

                    X[0] = 0x50; Y[0] = 0x00; Z[0] = 0X50;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 4
                case 30:
                    Sz = 2;
                    Pr = 5;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת וַיִּקְרָא";
                    }
                    else
                    {
                        L3.Text = "אביב שבוע 4";
                    }
                    L4.Text = "הדלקת נרות ב-18:24";
                    L5.Text = "צאת השבת ב-19:31";

                    Sat_H[0] = 18; Sat_M[0] = 24;
                    Sat_H[1] = 19; Sat_M[1] = 31;

                    X[0] = 0x50; Y[0] = 0x00; Z[0] = 0X50;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 5
                case 31:
                    Sz = 2;
                    Pr = 5;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת צַו";
                    }
                    else
                    {
                        L3.Text = "אביב שבוע 5";
                    }
                    L4.Text = "הדלקת נרות ב-18:29";
                    L5.Text = "צאת השבת ב-19:36";

                    Sat_H[0] = 18; Sat_M[0] = 29;
                    Sat_H[1] = 19; Sat_M[1] = 36;

                    X[0] = 0x50; Y[0] = 0x50; Z[0] = 0X00;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 6
                case 32:
                    Sz = 2;
                    Pr = 5;
                    if (D[1] > 5)
                    {
                        L3.Text = "חג פסח";
                    }
                    else
                    {
                        L3.Text = "אביב שבוע 6";
                    }
                    L4.Text = "הדלקת נרות ב-18:34";
                    L5.Text = "צאת השבת ב-19:41";

                    Sat_H[0] = 18; Sat_M[0] = 34;
                    Sat_H[1] = 19; Sat_M[1] = 41;

                    X[0] = 0x50; Y[0] = 0x50; Z[0] = 0X00;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 7
                case 33:
                    Sz = 2;
                    Pr = 5;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת שְׁמִינִי";
                    }
                    else
                    {
                        L3.Text = "אביב שבוע 7";
                    }
                    L4.Text = "הדלקת נרות ב-18:39";
                    L5.Text = "צאת השבת ב-19:46";

                    Sat_H[0] = 18; Sat_M[0] = 39;
                    Sat_H[1] = 19; Sat_M[1] = 46;

                    X[0] = 0x00; Y[0] = 0x40; Z[0] = 0x20;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 8
                case 34:
                    Sz = 2;
                    Pr = 5;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת תַּזְרִיעַ,מְצֹרָע";
                    }
                    else
                    {
                        L3.Text = "אביב שבוע 8";
                    }
                    L4.Text = "הדלקת נרות ב-18:44";
                    L5.Text = "צאת השבת ב-19:51";

                    Sat_H[0] = 18; Sat_M[0] = 44;
                    Sat_H[1] = 19; Sat_M[1] = 51;

                    X[0] = 0x60; Y[0] = 0x00; Z[0] = 0X00;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 9
                case 35:
                    Sz = 2;
                    Pr = 5;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת אַחֲרֵי-מות,קְדוֹשִׁים";
                    }
                    else
                    {
                        L3.Text = "אביב שבוע 9";
                    }
                    L4.Text = "הדלקת נרות ב-18:50";
                    L5.Text = "צאת השבת ב-19:57";

                    Sat_H[0] = 18; Sat_M[0] = 50;
                    Sat_H[1] = 19; Sat_M[1] = 57;

                    X[0] = 0x60; Y[0] = 0x00; Z[0] = 0X00;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 10
                case 36:
                    Sz = 2;
                    Pr = 5;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת אֱמֹר";
                    }
                    else
                    {
                        L3.Text = "אביב שבוע 10";
                    }
                    L4.Text = "הדלקת נרות ב-18:55";
                    L5.Text = "צאת השבת ב-20:02";

                    Sat_H[0] = 18; Sat_M[0] = 55;
                    Sat_H[1] = 20; Sat_M[1] = 02;

                    X[0] = 0x00; Y[0] = 0x50; Z[0] = 0X00;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 11
                case 37:
                    Sz = 2;
                    Pr = 5;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת בְּהַר,בְּחֻקֹּתַי";
                    }
                    else
                    {
                        L3.Text = "אביב שבוע 11";
                    }
                    L4.Text = "הדלקת נרות ב-19:00";
                    L5.Text = "צאת השבת ב-20:07";

                    Sat_H[0] = 19; Sat_M[0] = 00;
                    Sat_H[1] = 20; Sat_M[1] = 07;

                    X[0] = 0x00; Y[0] = 0x50; Z[0] = 0X00;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 12
                case 38:
                    Sz = 2;
                    Pr = 5;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת בַּמִּדְבָּר";
                    }
                    else
                    {
                        L3.Text = "1אביב שבוע 2";
                    }
                    L4.Text = "הדלקת נרות ב-19:05";
                    L5.Text = "צאת השבת ב-20:12";

                    Sat_H[0] = 19; Sat_M[0] = 05;
                    Sat_H[1] = 20; Sat_M[1] = 12;

                    X[0] = 0x00; Y[0] = 0x00; Z[0] = 0X40;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 13
                case 39:
                    Sz = 2;
                    Pr = 5;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת נָשֹׂא";
                    }
                    else
                    {
                        L3.Text = "אביב שבוע 13";
                    }
                    L4.Text = "הדלקת נרות ב-19:10";
                    L5.Text = "צאת השבת ב-20:17";

                    Sat_H[0] = 19; Sat_M[0] = 10;
                    Sat_H[1] = 20; Sat_M[1] = 17;

                    X[0] = 0x00; Y[0] = 0x00; Z[0] = 0X40;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;


                //קיץ
                //שבוע 1
                case 40:
                    Sz = 1;
                    Pr = 1;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת בְּהַעֲלֹתְךָ";
                    }
                    else
                    {
                        L3.Text = "קיץ שבוע 1";
                    }
                    L4.Text = "הדלקת נרות ב-19:14";
                    L5.Text = "צאת השבת ב-20:21";

                    Sat_H[0] = 19; Sat_M[0] = 14;
                    Sat_H[1] = 20; Sat_M[1] = 21;

                    X[0] = 0x00; Y[0] = 0x50; Z[0] = 0x50;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 2
                case 41:
                    Sz = 1;
                    Pr = 1;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת שְׁלַח";
                    }
                    else
                    {
                        L3.Text = "קיץ שבוע 2";
                    }
                    L4.Text = "הדלקת נרות ב-19:18";
                    L5.Text = "צאת השבת ב-20:25";

                    Sat_H[0] = 19; Sat_M[0] = 18;
                    Sat_H[1] = 20; Sat_M[1] = 25;

                    X[0] = 0x50; Y[0] = 0x00; Z[0] = 0x50;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 3
                case 42:
                    Sz = 1;
                    Pr = 1;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת קֹרַח";
                    }
                    else
                    {
                        L3.Text = "קיץ שבוע 3";
                    }
                    L4.Text = "הדלקת נרות ב-19:20";
                    L5.Text = "צאת השבת ב-20:27";

                    Sat_H[0] = 19; Sat_M[0] = 20;
                    Sat_H[1] = 20; Sat_M[1] = 27;

                    X[0] = 0x50; Y[0] = 0x50; Z[0] = 0x00;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 4
                case 43:
                    Sz = 1;
                    Pr = 2;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת חֻקַּת";
                    }
                    else
                    {
                        L3.Text = "קיץ שבוע 4";
                    }
                    L4.Text = "הדלקת נרות ב-19:22";
                    L5.Text = "צאת השבת ב-20:29";

                    Sat_H[0] = 19; Sat_M[0] = 22;
                    Sat_H[1] = 20; Sat_M[1] = 29;

                    X[0] = 0x00; Y[0] = 0x50; Z[0] = 0X50;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 5
                case 44:
                    Sz = 1;
                    Pr = 2;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת בָּלָק";
                    }
                    else
                    {
                        L3.Text = "קיץ שבוע 5";
                    }
                    L4.Text = "הדלקת נרות ב-19:23";
                    L5.Text = "צאת השבת ב-20:30";

                    Sat_H[0] = 19; Sat_M[0] = 23;
                    Sat_H[1] = 20; Sat_M[1] = 30;

                    X[0] = 0x50; Y[0] = 0x00; Z[0] = 0x50;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 6
                case 45:
                    Sz = 1;
                    Pr = 2;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת פִּנְחָס";
                    }
                    else
                    {
                        L3.Text = "קיץ שבוע 6";
                    }
                    L4.Text = "הדלקת נרות ב-19:22";
                    L5.Text = "צאת השבת ב-20:29";

                    Sat_H[0] = 19; Sat_M[0] = 22;
                    Sat_H[1] = 20; Sat_M[1] = 29;

                    X[0] = 0x50; Y[0] = 0x50; Z[0] = 0x00;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 7
                case 46:
                    Sz = 1;
                    Pr = 3;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת מַטּוֹת,מַסְעֵי";
                    }
                    else
                    {
                        L3.Text = "קיץ שבוע 7";
                    }
                    L4.Text = "הדלקת נרות ב-19:20";
                    L5.Text = "צאת השבת ב-20:27";

                    Sat_H[0] = 19; Sat_M[0] = 20;
                    Sat_H[1] = 20; Sat_M[1] = 27;

                    X[0] = 0x00; Y[0] = 0x50; Z[0] = 0x50;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 8
                case 47:
                    Sz = 1;
                    Pr = 3;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת דְּבָרִים";
                    }
                    else
                    {
                        L3.Text = "קיץ שבוע 8";
                    }
                    L4.Text = "הדלקת נרות ב-19:17";
                    L5.Text = "צאת השבת ב-20:24";

                    Sat_H[0] = 19; Sat_M[0] = 17;
                    Sat_H[1] = 20; Sat_M[1] = 24;

                    X[0] = 0x50; Y[0] = 0x00; Z[0] = 0x50;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 9
                case 48:
                    Sz = 1;
                    Pr = 3;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת וָאֶתְחַנַּן";
                    }
                    else
                    {
                        L3.Text = "קיץ שבוע 9";
                    }
                    L4.Text = "הדלקת נרות ב-19:12";
                    L5.Text = "צאת השבת ב-20:19";

                    Sat_H[0] = 19; Sat_M[0] = 12;
                    Sat_H[1] = 20; Sat_M[1] = 19;

                    X[0] = 0x50; Y[0] = 0x50; Z[0] = 0x00;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 10
                case 49:
                    Sz = 1;
                    Pr = 4;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת עֵקֶב";
                    }
                    else
                    {
                        L3.Text = "קיץ שבוע 10";
                    }
                    L4.Text = "הדלקת נרות ב-19:07";
                    L5.Text = "צאת השבת ב-20:14";

                    Sat_H[0] = 19; Sat_M[0] = 07;
                    Sat_H[1] = 20; Sat_M[1] = 14;

                    X[0] = 0x00; Y[0] = 0x50; Z[0] = 0x50;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 11
                case 50:
                    Sz = 1;
                    Pr = 4;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת רְאֵה";
                    }
                    else
                    {
                        L3.Text = "קיץ שבוע 11";
                    }
                    L4.Text = "הדלקת נרות ב-19:00";
                    L5.Text = "צאת השבת ב-20:07";

                    Sat_H[0] = 19; Sat_M[0] = 00;
                    Sat_H[1] = 20; Sat_M[1] = 07;

                    X[0] = 0x50; Y[0] = 0x00; Z[0] = 0x50;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
                //שבוע 12
                case 51:
                    Sz = 1;
                    Pr = 4;
                    if (D[1] > 5)
                    {
                        L3.Text = "פָּרָשַׁת שֹׁפְטִים";
                    }
                    else
                    {
                        L3.Text = "קיץ שבוע 12";
                    }
                    L4.Text = "הדלקת נרות ב-18:53";
                    L5.Text = "צאת השבת ב-20:00";

                    Sat_H[0] = 18; Sat_M[0] = 53;
                    Sat_H[1] = 20; Sat_M[1] = 00;

                    X[0] = 0x50; Y[0] = 0x50; Z[0] = 0x00;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;

                default:
                    Sz = 2;
                    Pr = 5;
                    L3.Text = "פָּרָשַׁת השבוע";
                    X[0] = 0x00; Y[0] = 0x00; Z[0] = 0x00;
                    X[1] = 0xFF; Y[1] = 0xFF; Z[1] = 0xFF;
                    break;
            }
            switch (D[1])
            {
                case 1:
                    L2.Text = "יום ראשון";
                    X[2] = X[0]; Y[2] = Y[0]; Z[2] = Z[0];
                    X[3] = X[1]; Y[3] = Y[1]; Z[3] = Z[1];
                    L1.Visible = true;
                    L4.Visible = false;
                    L5.Visible = false;
                    break;

                case 2:
                    L2.Text = "יום שני";
                    X[2] = X[0]; Y[2] = Y[0]; Z[2] = Z[0];
                    X[3] = X[1]; Y[3] = Y[1]; Z[3] = Z[1];
                    L1.Visible = true;
                    L4.Visible = false;
                    L5.Visible = false;
                    break;



                case 3:
                    L2.Text = "יום שלישי                       ";
                    switch (Sz)
                    {
                        case 0:
                            X[2] = 0x00; Y[2] = 0x50; Z[2] = 0x50;
                            X[3] = 0xFF; Y[3] = 0XFF; Z[3] = 0xFF;
                            break;

                        case 1:
                            X[2] = 0x60; Y[2] = 0x00; Z[2] = 0x00;
                            X[3] = 0xFF; Y[3] = 0XFF; Z[3] = 0xFF;
                            break;

                        default:
                            X[2] = X[0]; Y[2] = Y[0]; Z[2] = Z[0];
                            X[3] = X[1]; Y[3] = Y[1]; Z[3] = Z[1];
                            break;
                    }
                    L1.Visible = true;
                    L4.Visible = false;
                    L5.Visible = false;
                    break;

                case 4:
                    L2.Text = "יום רביעי                       ";
                    switch (Sz)
                    {
                        case 0:
                            X[2] = 0x50; Y[2] = 0x00; Z[2] = 0x50;
                            X[3] = 0xFF; Y[3] = 0xFF; Z[3] = 0xFF;
                            break;

                        case 1:
                            X[2] = 0x00; Y[2] = 0x50; Z[2] = 0x00;
                            X[3] = 0xFF; Y[3] = 0xFF; Z[3] = 0xFF;
                            break;

                        default:
                            X[2] = X[0]; Y[2] = Y[0]; Z[2] = Z[0];
                            X[3] = X[1]; Y[3] = Y[1]; Z[3] = Z[1];
                            break;
                    }
                    L1.Visible = true;
                    L4.Visible = false;
                    L5.Visible = false;
                    break;

                case 5:
                    L2.Text = "יום חמישי                       ";
                    switch (Sz)
                    {
                        case 0:
                            X[2] = 0x50; Y[2] = 0x50; Z[2] = 0x00;
                            X[3] = 0xFF; Y[3] = 0XFF; Z[3] = 0xFF;
                            break;

                        case 1:
                            X[2] = 0x00; Y[2] = 0x00; Z[2] = 0x40;
                            X[3] = 0xFF; Y[3] = 0XFF; Z[3] = 0xFF;
                            break;

                        default:
                            X[2] = X[0]; Y[2] = Y[0]; Z[2] = Z[0];
                            X[3] = X[1]; Y[3] = Y[1]; Z[3] = Z[1];
                            break;
                    }
                    L1.Visible = true;
                    L4.Visible = false;
                    L5.Visible = false;
                    break;



                case 6:
                    switch (Pr)
                    {
                        case 1:
                            X[0] = 0x00; Y[0] = 0xFF; Z[0] = 0xFF;
                            X[1] = 0x00; Y[1] = 0x00; Z[1] = 0x00;
                            X[2] = X[0]; Y[2] = Y[0]; Z[2] = Z[0];
                            X[3] = X[1]; Y[3] = Y[1]; Z[3] = Z[1];
                            break;

                        case 2:
                            X[0] = 0x90; Y[0] = 0x00; Z[0] = 0xC0;
                            X[1] = 0x00; Y[1] = 0x00; Z[1] = 0x00;
                            X[2] = X[0]; Y[2] = Y[0]; Z[2] = Z[0];
                            X[3] = X[1]; Y[3] = Y[1]; Z[3] = Z[1];
                            break;

                        case 3:
                            X[0] = 0xFF; Y[0] = 0x00; Z[0] = 0xC0;
                            X[1] = 0x00; Y[1] = 0x00; Z[1] = 0x00;
                            X[2] = X[0]; Y[2] = Y[0]; Z[2] = Z[0];
                            X[3] = X[1]; Y[3] = Y[1]; Z[3] = Z[1];
                            break;

                        case 4:
                            X[0] = 0xFF; Y[0] = 0xFF; Z[0] = 0x00;
                            X[1] = 0x00; Y[1] = 0x00; Z[1] = 0x00;
                            X[2] = X[0]; Y[2] = Y[0]; Z[2] = Z[0];
                            X[3] = X[1]; Y[3] = Y[1]; Z[3] = Z[1];
                            break;

                        default:
                            X[2] = X[0]; Y[2] = Y[0]; Z[2] = Z[0];
                            X[3] = X[1]; Y[3] = Y[1]; Z[3] = Z[1];
                            break;
                    }
                    L1.Visible = false;
                    L5.Visible = false;
                    if (H > Sat_H[0] || H == Sat_H[0] && M >= Sat_M[0] || H < 6)
                    {
                        L2.Text = "שבת שלום";
                        L4.Visible = false;
                    }
                    else
                    {
                        L2.Text = "יום השישי";
                        L4.Visible = true;
                    }
                    break;

                case 7:
                    switch (Pr)
                    {
                        case 1:
                            X[0] = 0x00; Y[0] = 0xFF; Z[0] = 0xFF;
                            X[1] = 0x00; Y[1] = 0x00; Z[1] = 0x00;
                            X[2] = X[0]; Y[2] = Y[0]; Z[2] = Z[0];
                            X[3] = X[1]; Y[3] = Y[1]; Z[3] = Z[1];
                            break;

                        case 2:
                            X[0] = 0x90; Y[0] = 0x00; Z[0] = 0xC0;
                            X[1] = 0x00; Y[1] = 0x00; Z[1] = 0x00;
                            X[2] = X[0]; Y[2] = Y[0]; Z[2] = Z[0];
                            X[3] = X[1]; Y[3] = Y[1]; Z[3] = Z[1];
                            break;

                        case 3:
                            X[0] = 0xFF; Y[0] = 0x00; Z[0] = 0xC0;
                            X[1] = 0x00; Y[1] = 0x00; Z[1] = 0x00;
                            X[2] = X[0]; Y[2] = Y[0]; Z[2] = Z[0];
                            X[3] = X[1]; Y[3] = Y[1]; Z[3] = Z[1];
                            break;

                        case 4:
                            X[0] = 0xFF; Y[0] = 0xFF; Z[0] = 0x00;
                            X[1] = 0x00; Y[1] = 0x00; Z[1] = 0x00;
                            X[2] = X[0]; Y[2] = Y[0]; Z[2] = Z[0];
                            X[3] = X[1]; Y[3] = Y[1]; Z[3] = Z[1];
                            break;

                        default:
                            X[2] = X[0]; Y[2] = Y[0]; Z[2] = Z[0];
                            X[3] = X[1]; Y[3] = Y[1]; Z[3] = Z[1];
                            break;
                    }
                    L1.Visible = false;
                    L4.Visible = false;
                    if (H >= 6 && H < Sat_H[1] || H == Sat_H[1] && M < Sat_M[1])
                    {
                        L2.Text = "שבת קודש";
                        L5.Visible = true;
                    }
                    else
                    {
                        L2.Text = "שבוע טוב";
                        L5.Visible = false;
                    }
                    break;



                default:
                    break;
            }

            BackColor = Color.FromArgb(Y[0], Z[0], X[0]);
            L1.BackColor = Color.FromArgb(Y[0], Z[0], X[0]);
            L2.BackColor = Color.FromArgb(Y[2], Z[2], X[2]);
            L3.BackColor = Color.FromArgb(Y[0], Z[0], X[0]);
            L4.BackColor = Color.FromArgb(Y[0], Z[0], X[0]);
            L5.BackColor = Color.FromArgb(Y[0], Z[0], X[0]);

            L1.ForeColor = Color.FromArgb(Y[1], Z[1], X[1]);
            L2.ForeColor = Color.FromArgb(Y[3], Z[3], X[3]);
            L3.ForeColor = Color.FromArgb(Y[1], Z[1], X[1]);
            L4.ForeColor = Color.FromArgb(Y[1], Z[1], X[1]);
            L5.ForeColor = Color.FromArgb(Y[1], Z[1], X[1]);

            switch (DG)
            {
                case 283:
                    Ev = 1;
                    break;

                case 292:
                    Ev = 2;
                    break;

                case 72:
                    Ev = 3;
                    break;

                case 211:
                    Ev = 4;
                    break;

                case 315:
                    Ev = 5;
                    break;

                case 71:
                    Ev = 6;
                    break;

                case 117:
                    Ev = 7;
                    break;

                case 136:
                    Ev = 8;
                    break;

                default:
                    Ev = 0;
                    break;
            }
            switch (Ev)
            {
                case 1:
                    Timer.Stop();
                    MessageBox.Show("יום הולדת לאבא ה-66");
                    break;

                case 2:
                    Timer.Stop();                    
                    MessageBox.Show("יום הולדת לסבתא ה-95");
                    break;

                case 3:
                    Timer.Stop();
                    MessageBox.Show("יום הולדת לאמא ה-65");
                    break;

                case 4:
                    Timer.Stop();
                    MessageBox.Show("יום הולדת למיכאל ה-43");
                    break;

                case 5:
                    Timer.Stop();
                    MessageBox.Show("יום שישי הבא ב-18.11.22 אזכרה לאלה בת פיינה");
                    break;

                case 6:
                    Timer.Stop();
                    MessageBox.Show("יום ראשון הבא ב-19.3.23 אזכרה לגרגורי בן רוזה");
                    break;

                case 7:
                    Timer.Stop();
                    MessageBox.Show("יום חמישי הבא ב-4.5.23 אזכרה לחנקה בת בסיה");
                    break;

                case 8:
                    Timer.Stop();
                    MessageBox.Show("יום שלישי הבא ב-23.5.23 אזכרה למשה בן חונה");
                    break;

                default:
                    break;
            }
        }
      }
}
