using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniexam
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        RadioButton rb1 = new RadioButton();
        RadioButton rb2 = new RadioButton();
        RadioButton rb3 = new RadioButton();
        RadioButton rb4 = new RadioButton();
        RadioButton rb5 = new RadioButton();
        RadioButton rb6 = new RadioButton();
        RadioButton rb7 = new RadioButton();
        RadioButton rb8 = new RadioButton();
        RadioButton rb9 = new RadioButton();
        RadioButton rb10 = new RadioButton();
        RadioButton rb11 = new RadioButton();
        RadioButton rb12 = new RadioButton();
        RadioButton rb13 = new RadioButton();
        RadioButton rb14 = new RadioButton();
        RadioButton rb15 = new RadioButton();
        RadioButton rb16 = new RadioButton();
        RadioButton rb17 = new RadioButton();
        RadioButton rb18 = new RadioButton();
        RadioButton rb19 = new RadioButton();
        RadioButton rb20 = new RadioButton();

        private void Form1_Load(object sender, EventArgs e)
        {

            Button btn = new Button();
            btn.Text = "kaydet";

            btn.Top = 750;
            btn.Left = 100;
            btn.Click += Btn_Click;
            this.Controls.Add(btn);

            GroupBox gr1 = new GroupBox();
            gr1.Left = 20;
            gr1.Top = 20;
            gr1.Text = "Soru 1";
            gr1.Width = 500;
            gr1.Height = 140;
            this.Controls.Add(gr1);

            Label lbl = new Label();
            lbl.Top = 30;
            lbl.Left = 30;
            lbl.Text = "Turkiyenin baskenti neresidir?";
            lbl.Width = 150;
            gr1.Controls.Add(lbl);

            rb1.Top = 70;
            rb1.Left = 30;
            rb1.Text = "istanbul";
            gr1.Controls.Add(rb1);

            rb2.Top = 70;
            rb2.Left = 140;
            rb2.Text = "ankara";
            gr1.Controls.Add(rb2);

            rb3.Top = 70;
            rb3.Left = 250;
            rb3.Text = "izmir";
            gr1.Controls.Add(rb3);

            rb4.Top = 70;
            rb4.Left = 360;
            rb4.Text = "bursa";
            gr1.Controls.Add(rb4);

            GroupBox gr2 = new GroupBox();
            gr2.Left = 20;
            gr2.Top = gr1.Height + 30;
            gr2.Text = "Soru 2";
            gr2.Width = 500;
            gr2.Height = 140;
            this.Controls.Add(gr2);

            Label lbl2 = new Label();
            lbl2.Top = 30;
            lbl2.Left = 30;
            lbl2.Text = "Turkiyenin yüzölçümü en büyük şehri hangisidir?";
            lbl2.Width = 350;
            gr2.Controls.Add(lbl2);

            rb5.Top = 70;
            rb5.Left = 30;
            rb5.Text = "erzurum";
            gr2.Controls.Add(rb5);

            rb6.Top = 70;
            rb6.Left = 140;
            rb6.Text = "konya";
            gr2.Controls.Add(rb6);

            rb7.Top = 70;
            rb7.Left = 250;
            rb7.Text = "izmir";
            gr2.Controls.Add(rb7);

            rb8.Top = 70;
            rb8.Left = 360;
            rb8.Text = "çanakkale";
            gr2.Controls.Add(rb8);

            GroupBox gr3 = new GroupBox();
            gr3.Left = 20;
            gr3.Top = gr1.Height * 2 + 40;
            gr3.Text = "Soru 3";
            gr3.Width = 500;
            gr3.Height = 140;
            this.Controls.Add(gr3);

            Label lbl3 = new Label();
            lbl3.Top = 30;
            lbl3.Left = 30;
            lbl3.Text = "istanbul hangi yilda fethedilmiştir?";
            lbl3.Width = 450;
            gr3.Controls.Add(lbl3);

            rb9.Top = 70;
            rb9.Left = 30;
            rb9.Text = "1881";
            gr3.Controls.Add(rb9);

            rb10.Top = 70;
            rb10.Left = 140;
            rb10.Text = "1923";
            gr3.Controls.Add(rb10);

            rb11.Top = 70;
            rb11.Left = 250;
            rb11.Text = "1453";
            gr3.Controls.Add(rb11);

            rb12.Top = 70;
            rb12.Left = 360;
            rb12.Text = "2003";
            gr3.Controls.Add(rb12);


            GroupBox gr4 = new GroupBox();
            gr4.Left = 20;
            gr4.Top = gr1.Height * 3 + 50;
            gr4.Text = "Soru 4";
            gr4.Width = 500;
            gr4.Height = 140;
            this.Controls.Add(gr4);

            Label lbl4 = new Label();
            lbl4.Top = 30;
            lbl4.Left = 30;
            lbl4.Text = "Turkiyenin en kalabalik sehri hangisidir?";
            lbl4.Width = 450;
            gr4.Controls.Add(lbl4);

            rb13.Top = 70;
            rb13.Left = 30;
            rb13.Text = "antalya";
            gr4.Controls.Add(rb13);

            rb14.Top = 70;
            rb14.Left = 140;
            rb14.Text = "konya";
            gr4.Controls.Add(rb14);

            rb15.Top = 70;
            rb15.Left = 250;
            rb15.Text = "izmir";
            gr4.Controls.Add(rb15);

            rb16.Top = 70;
            rb16.Left = 360;
            rb16.Text = "istanbul";
            gr4.Controls.Add(rb16);


            GroupBox gr5 = new GroupBox();
            gr5.Left = 20;
            gr5.Top = gr1.Height * 4 + 50;
            gr5.Text = "Soru 5";
            gr5.Width = 500;
            gr5.Height = 140;
            this.Controls.Add(gr5);

            Label lbl5 = new Label();
            lbl5.Top = 30;
            lbl5.Left = 30;
            lbl5.Text = "Hangisi ic anadolu sehridir?";
            lbl5.Width = 450;
            gr5.Controls.Add(lbl5);

            rb17.Top = 70;
            rb17.Left = 30;
            rb17.Text = "kayseri";
            gr5.Controls.Add(rb17);

            rb18.Top = 70;
            rb18.Left = 140;
            rb18.Text = "tunceli";
            gr5.Controls.Add(rb18);

            rb19.Top = 70;
            rb19.Left = 250;
            rb19.Text = "izmir";
            gr5.Controls.Add(rb19);

            rb20.Top = 70;
            rb20.Left = 360;
            rb20.Text = "adana";
            gr5.Controls.Add(rb20);

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int sum = 0;

            if (rb2.Checked)
            {
                sum += 20;
            }
            if (rb6.Checked)
            {
                sum += 20;
            }
            if (rb11.Checked)
            {
                sum += 20;
            }
            if (rb16.Checked)
            {
                sum += 20;
            }
            if (rb17.Checked)
            {
                sum += 20;
            }

            MessageBox.Show(sum + " puan aldiniz");

        }
    }
}
