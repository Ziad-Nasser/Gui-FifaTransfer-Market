using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transfer_Market.Properties;

namespace Transfer_Market
{
    public partial class PlayersMarket : Form
    {

        public int minpri;
        public int maxpri;
        public int minage;
        public int maxage; 

        private string selectedPosition;
        private void LoadPlayerImages()
        {
 
            switch (selectedPosition)
            {                
                case "GK":
                    pictureBox1.BackgroundImage = Properties.Resources.Onana;
                    pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox2.BackgroundImage = Properties.Resources.Altay_Bayindir;
                    pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox3.BackgroundImage = Properties.Resources.Heaton;
                    pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
                    break;

                case "CB":
                    pictureBox1.BackgroundImage = Properties.Resources.Harry_Maguire;
                    pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox2.BackgroundImage = Properties.Resources.Lindelof;
                    pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox3.BackgroundImage = Properties.Resources.Varane;
                    pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox4.BackgroundImage = Properties.Resources.Lisandro_Martínez;
                    pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox5.BackgroundImage = Properties.Resources.Shaw;
                    pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox6.BackgroundImage = Properties.Resources.Wan_Bissaka;
                    pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox7.BackgroundImage = Properties.Resources.Dalot;
                    pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox8.BackgroundImage = Properties.Resources.Reguilon;
                    pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
                    break;

                case "CM":
                    pictureBox1.BackgroundImage = Properties.Resources.Casemiro;
                    pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox2.BackgroundImage = Properties.Resources.Bruno_Fernandes;
                    pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox3.BackgroundImage = Properties.Resources.Van_de_Beek;
                    pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox4.BackgroundImage = Properties.Resources.Amrabat;
                    pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox5.BackgroundImage = Properties.Resources.Mason_Mount;
                    pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox6.BackgroundImage = Properties.Resources.Eriksen;
                    pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox7.BackgroundImage = Properties.Resources.Scott_Mctominay;
                    pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox8.BackgroundImage = Properties.Resources.Mejbri;
                    pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
                    break;

                case "ST":
                    pictureBox1.BackgroundImage = Properties.Resources.Antony;
                    pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox2.BackgroundImage = Properties.Resources.Alejandro_Garnacho;
                    pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox3.BackgroundImage = Properties.Resources.Rashford;
                    pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox4.BackgroundImage = Properties.Resources.Antony_Martial;
                    pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox5.BackgroundImage = Properties.Resources.Hojlund;
                    pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox6.BackgroundImage = Properties.Resources.Amad_Diallo;
                    pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox7.BackgroundImage = Properties.Resources.Facundo_Pellistri;
                    pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox8.BackgroundImage = Properties.Resources.Sancho;
                    pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                default:
                    break;
            }
        }

        PurchasePlayer form5;
        public static Image pc1;
        public static Image pc2;
        public static Image pc3;
        public static Image pc4;

        public PlayersMarket(string position = "")
        {
            InitializeComponent();
            this.selectedPosition = position;
            LoadPlayerImages();
            Club.BackgroundImage = SearchForm.temb;
        }

        public void SetPositionLabel(string position)
        {
            positionlabel.Text = position;
        }
        public void SetminpriceLabel(string min)
        {
            min_pricelabel.Text = min;
        }
        public void SetmaxpriceLabel(string max)
        {
            max_pricelabel.Text = max;
        }
        public void SetminageLabel(string min)
        {
            min_agelabel.Text = min;
        }
        public void SetmaxageLabel(string max)
        {
            max_agelabel.Text = max;
        }
        private void Purchasep1button_Click(object sender, EventArgs e)
        {
            this.Hide();
            form5 = new PurchasePlayer(pictureBox1.BackgroundImage);
            form5.UpdateImage(pictureBox1.BackgroundImage);
            form5.ShowDialog();
        }


        private void Purchasep2button_Click(object sender, EventArgs e)
        {
            this.Hide();
            form5 = new PurchasePlayer(pictureBox1.BackgroundImage);
            form5.UpdateImage(pictureBox2.BackgroundImage);
            form5.ShowDialog();
        }

        private void Purchasep3button_Click(object sender, EventArgs e)
        {
            this.Hide();
            form5 = new PurchasePlayer(pictureBox1.BackgroundImage);
            form5.UpdateImage(pictureBox3.BackgroundImage);
            form5.ShowDialog();
        }
        private void Purchasep4button_Click(object sender, EventArgs e)
        {
            this.Hide();
            form5 = new PurchasePlayer(pictureBox1.BackgroundImage);
            form5.UpdateImage(pictureBox4.BackgroundImage);
            form5.ShowDialog();
        }
        private void Purchasep5button_Click(object sender, EventArgs e)
        {
            this.Hide();
            form5 = new PurchasePlayer(pictureBox1.BackgroundImage);
            form5.UpdateImage(pictureBox5.BackgroundImage);
            form5.ShowDialog();
        }
        private void Purchasep6button_Click(object sender, EventArgs e)
        {
            this.Hide();
            form5 = new PurchasePlayer(pictureBox1.BackgroundImage);
            form5.UpdateImage(pictureBox6.BackgroundImage);
            form5.ShowDialog();
        }
        private void Purchasep7button_Click(object sender, EventArgs e)
        {
            this.Hide();
            form5 = new PurchasePlayer(pictureBox1.BackgroundImage);
            form5.UpdateImage(pictureBox7.BackgroundImage);
            form5.ShowDialog();
        }
        private void Purchasep8button_Click(object sender, EventArgs e)
        {         
            this.Hide();
            form5 = new PurchasePlayer(pictureBox1.BackgroundImage);
            form5.UpdateImage(pictureBox8.BackgroundImage);
            form5.ShowDialog();
        }
        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm form1 = new SearchForm();
            form1.ShowDialog();
        }
    }
}
