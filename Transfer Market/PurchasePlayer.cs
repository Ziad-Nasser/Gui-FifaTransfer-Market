using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transfer_Market.Properties;

namespace Transfer_Market
{
    public partial class PurchasePlayer : Form
    {

        JoinedPlayer form4 = new JoinedPlayer();
        public PurchasePlayer(Image image)
        {
            InitializeComponent();
            UpdateImage(image);
        }
        public void UpdateImage(Image image)
        {
            pictureBox1.BackgroundImage = image;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void purchasebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            form4.SetPlayerImage(pictureBox1.BackgroundImage);
            form4.ShowDialog();
        }
        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayersMarket form2 = new PlayersMarket();
            form2.ShowDialog();
        }
    }
}
