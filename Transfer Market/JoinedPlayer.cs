using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transfer_Market
{
    public partial class JoinedPlayer : Form
    {
        SearchForm form1 = new SearchForm();
        public JoinedPlayer()
        {
            InitializeComponent();
        }
        public void SetPlayerImage(Image image)
        {
            pictureBox1.BackgroundImage = image;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void homebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.ShowDialog();
        }
    }
}
