using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Transfer_Market.Properties;

namespace Transfer_Market
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        public static Image temb;
        private void search_button_Click(object sender, EventArgs e)
        {
            string selectedPosition = "Position: " + position_combobox.SelectedItem?.ToString();
            string minprice = "Min.Price: " + min_price_textbox.Text;
            string maxprice = "Max.Price: " + max_price_textbox.Text;
            string minage = "Min.Age: " + min_age_textbox.Text;
            string maxage = "Max.Age: " + max_age_textbox.Text;

            string selectedPositionCB = position_combobox.SelectedItem.ToString();
            PlayersMarket form2 = new PlayersMarket(selectedPositionCB);

            form2.minpri = int.Parse(min_price_textbox.Text);
            form2.maxpri = int.Parse(max_price_textbox.Text);
            form2.minage = int.Parse(min_age_textbox.Text);
            form2.maxage = int.Parse(max_age_textbox.Text);

            form2.SetPositionLabel(selectedPosition);
            form2.SetminpriceLabel(minprice);
            form2.SetmaxpriceLabel(maxprice);
            form2.SetminageLabel(minage);
            form2.SetmaxageLabel(maxage);

            this.Hide();
            form2.ShowDialog();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void SetClubImage(string clubName)
        {
            switch (clubName)
            {
                case "Man United":
                    ClubpictureBox.BackgroundImage = Resources.ManUnited;
                    temb = Resources.ManUnited;
                    break;
                case "Man City":
                    ClubpictureBox.BackgroundImage = Resources.ManCity;
                    temb = Resources.ManCity;
                    break;
                case "Arsenal":
                    ClubpictureBox.BackgroundImage = Resources.Arsenal;
                    temb = Resources.Arsenal;
                    break;
                case "Liverpool":
                    ClubpictureBox.BackgroundImage = Resources.Liverpool;
                    temb = Resources.Liverpool;
                    break;
                case "Aston Villa":
                    ClubpictureBox.BackgroundImage = Resources.Aston_Villa;
                    temb = Resources.Aston_Villa;
                    break;
                case "Chelsea":
                    ClubpictureBox.BackgroundImage = Resources.Chelsea; 
                    temb = Resources.Chelsea;
                    break;
                case "Bournemouth":
                    ClubpictureBox.BackgroundImage = Resources.Bournemouth;
                    temb = Resources.Bournemouth;
                    break;
                case "Brentford":
                    ClubpictureBox.BackgroundImage = Resources.Brentford;
                    temb = Resources.Brentford;
                    break;
                case "Brighton":
                    ClubpictureBox.BackgroundImage = Resources.Brighton;
                    temb = Resources.Brighton;
                    break;
                case "Newcastle":
                    ClubpictureBox.BackgroundImage = Resources.NewcastleUnited;
                    temb = Resources.NewcastleUnited;
                    break;
                case "Crystal-Palace":
                    ClubpictureBox.BackgroundImage = Resources.Crystal_Palace;
                    temb = Resources.Crystal_Palace;
                    break;
                case "Fulham":
                    ClubpictureBox.BackgroundImage = Resources.Fulham;
                    temb = Resources.Fulham;
                    break;
                case "Luton Town":
                    ClubpictureBox.BackgroundImage = Resources.Luton_Town;
                    temb = Resources.Luton_Town;
                    break;
                case "Burnley":
                    ClubpictureBox.BackgroundImage = Resources.Burnley;
                    temb = Resources.Burnley;
                    break;
                case "Everton":
                    ClubpictureBox.BackgroundImage = Resources.Everton;
                    temb = Resources.Everton;
                    break;
                case "Tottenham":
                    ClubpictureBox.BackgroundImage = Resources.Tottenham;
                    temb = Resources.Tottenham;
                    break;
                case "Wolverhampton":
                    ClubpictureBox.BackgroundImage = Resources.Wolverhampton;
                    temb = Resources.Wolverhampton;
                    break;
                case "Sheffield":
                    ClubpictureBox.BackgroundImage = Resources.Sheffield;
                    temb = Resources.Sheffield;
                    break;
                case "West_Ham":
                    ClubpictureBox.BackgroundImage = Resources.West_Ham;
                    temb = Resources.West_Ham;
                    break;
                case "Nottingham_Forest":
                    ClubpictureBox.BackgroundImage = Resources.Nottingham_Forest;
                    temb = Resources.Nottingham_Forest;
                    break;
                default:
                    ClubpictureBox.BackgroundImage = null;
                    break;
            }
        }
        private void club_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedClub = club_combobox.SelectedItem.ToString();
            SetClubImage(selectedClub);
        }
    }
}
