using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;
using System.Threading;

namespace Slot_Machine_WinForm
{
    public partial class MainForm : Form
    {
        int new_money = 0;
        int convert_txt = 0;
        int convert_lbl = 0;
        const int MAX_MONEY = 1000;
        Random num = new Random();
        const int MAX_RANDOM = 6;
        const int MIN_RANDOM = 1;
        int random = 0;
        const int DOWN_UP_THE_BET = 10;
        const int MIN_MONEY = 0;
        const int NUM_PIC = 3;
        const int RONALDO = 1;
        const int KROOS = 2;
        const int FIRMINO = 3;
        const int NEYMAR = 4;
        const int BENAYOUN = 5;
        const int HAT_TRICK = 7;
        const int PAIR = 2;
        public MainForm()
        {
            InitializeComponent();
            bet_txtbx.ReadOnly = true;
        }

        private void bet_txtbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Money_Minus_Bet();
                Randon_PIC();
                Compare_The_Tags();
                End_Game();
            }
            if (e.KeyCode == Keys.Up)
            {
                Up_The_Bet();
            }
            else if (e.KeyCode == Keys.Down)
            {
                Down_The_Bet();
            }
        }
        private void Up_The_Bet()
        {
            convert_txt = Convert.ToInt32(bet_txtbx.Text);
            convert_txt += DOWN_UP_THE_BET;
            bet_txtbx.Text = convert_txt.ToString();
            if (Convert.ToInt32(bet_txtbx.Text) < MIN_MONEY || Convert.ToInt32(bet_txtbx.Text) > Convert.ToInt32(current_money_lbl.Text))
            {
                MessageBox.Show("Come on be serious!");
                bet_txtbx.Text = "0";
            }
        }
        private void Down_The_Bet()
        {
            convert_txt = Convert.ToInt32(bet_txtbx.Text);
            convert_txt -= DOWN_UP_THE_BET;
            bet_txtbx.Text = convert_txt.ToString();
            if (Convert.ToInt32(bet_txtbx.Text) < MIN_MONEY || Convert.ToInt32(bet_txtbx.Text) > Convert.ToInt32(current_money_lbl.Text))
            {
                MessageBox.Show("Come on be serious!");
                bet_txtbx.Text = "0";
            }
        }
        private void End_Game()
        {
            if (Convert.ToInt32(current_money_lbl.Text) == MIN_MONEY)
            {
                WindowsMediaPlayer lost = new WindowsMediaPlayer();
                lost.URL = "MosheCohen-MishakeyKlafim.mp3";
                lost.controls.play();
                MessageBox.Show("You lost you're money");
                this.Close();

            }
            else if (Convert.ToInt32(current_money_lbl.Text) >= MAX_MONEY)
            {
                WindowsMediaPlayer we_are_the_champions = new WindowsMediaPlayer();
                we_are_the_champions.URL = "Queen_We_Are_The_Champions_Ringtone_(by Fringster.com).mp3";
                we_are_the_champions.controls.play();
                MessageBox.Show("We ran out of money!");
                this.Close();
            }
        }
        private void Randon_PIC()
        {
            for (int i = 0; i < NUM_PIC; i++)
            {
                    random = num.Next(MIN_RANDOM, MAX_RANDOM);
                    if (i == 0)
                    {
                        if (random == 1)
                        {
                            symbol1_pcbx.Image = Image.FromFile("7.jpeg");
                            symbol1_pcbx.Tag = RONALDO;
                        }
                        else if (random == 2)
                        {
                            symbol1_pcbx.Image = Image.FromFile("8.jpeg");
                            symbol1_pcbx.Tag = KROOS;
                        }
                        else if (random == 3)
                        {
                            symbol1_pcbx.Image = Image.FromFile("9.jpeg");
                            symbol1_pcbx.Tag = FIRMINO;
                        }
                        else if (random == 4)
                        {
                            symbol1_pcbx.Image = Image.FromFile("10.jpeg");
                            symbol1_pcbx.Tag = NEYMAR;
                        }
                        else if (random == 5)
                        {
                            symbol1_pcbx.Image = Image.FromFile("15.jpg");
                            symbol1_pcbx.Tag = BENAYOUN;
                        }
                    }
                    if (i == 1)
                    {
                        if (random == 1)
                        {
                            symbol2_pcbx.Image = Image.FromFile("7.jpeg");
                            symbol2_pcbx.Tag = RONALDO;
                        }
                        else if (random == 2)
                        {
                            symbol2_pcbx.Image = Image.FromFile("8.jpeg");
                            symbol2_pcbx.Tag = KROOS;
                        }
                        else if (random == 3)
                        {
                            symbol2_pcbx.Image = Image.FromFile("9.jpeg");
                            symbol2_pcbx.Tag = FIRMINO;
                        }
                        else if (random == 4)
                        {
                            symbol2_pcbx.Image = Image.FromFile("10.jpeg");
                            symbol2_pcbx.Tag = NEYMAR;
                        }
                        else if (random == 5)
                        {
                            symbol2_pcbx.Image = Image.FromFile("15.jpg");
                            symbol2_pcbx.Tag = BENAYOUN;
                        }
                    }
                    if (i == 2)
                    {
                        if (random == 1)
                        {
                            symbol3_pcbx.Image = Image.FromFile("7.jpeg");
                            symbol3_pcbx.Tag = RONALDO;
                        }
                        else if (random == 2)
                        {
                            symbol3_pcbx.Image = Image.FromFile("8.jpeg");
                            symbol3_pcbx.Tag = KROOS;
                        }
                        else if (random == 3)
                        {
                            symbol3_pcbx.Image = Image.FromFile("9.jpeg");
                            symbol3_pcbx.Tag = FIRMINO;
                        }
                        else if (random == 4)
                        {
                            symbol3_pcbx.Image = Image.FromFile("10.jpeg");
                            symbol3_pcbx.Tag = NEYMAR;
                        }
                        else if (random == 5)
                        {
                            symbol3_pcbx.Image = Image.FromFile("15.jpg");
                            symbol3_pcbx.Tag = BENAYOUN;
                        }
                    }
            }
        }
        private void Compare_The_Tags()
        {
            if (Convert.ToInt32(symbol1_pcbx.Tag) == Convert.ToInt32(symbol2_pcbx.Tag) && Convert.ToInt32(symbol1_pcbx.Tag) == Convert.ToInt32(symbol3_pcbx.Tag))
            {
                convert_txt = Convert.ToInt32(bet_txtbx.Text);
                convert_txt *= HAT_TRICK;
                new_money += convert_txt;
                current_money_lbl.Text = new_money.ToString();
            }
            if (Convert.ToInt32(symbol1_pcbx.Tag) == Convert.ToInt32(symbol2_pcbx.Tag) || Convert.ToInt32(symbol1_pcbx.Tag) == Convert.ToInt32(symbol3_pcbx.Tag) || Convert.ToInt32(symbol2_pcbx.Tag) == Convert.ToInt32(symbol3_pcbx.Tag))
            {
                convert_txt = Convert.ToInt32(bet_txtbx.Text);
                convert_txt *= PAIR;
                new_money += convert_txt;
                current_money_lbl.Text = new_money.ToString();
            }
            if (Convert.ToInt32(symbol1_pcbx.Tag) == BENAYOUN || Convert.ToInt32(symbol2_pcbx.Tag) == BENAYOUN || Convert.ToInt32(symbol3_pcbx.Tag) == BENAYOUN)
            {
                convert_txt = Convert.ToInt32(bet_txtbx.Text);
                new_money += convert_txt;
                current_money_lbl.Text = new_money.ToString();
            }
        }
        private void Money_Minus_Bet()
        {
            convert_txt = Convert.ToInt32(bet_txtbx.Text);
            convert_lbl = Convert.ToInt32(current_money_lbl.Text);
            new_money = convert_lbl - convert_txt;
            current_money_lbl.Text = new_money.ToString();
        }

        private void jupingPicTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
