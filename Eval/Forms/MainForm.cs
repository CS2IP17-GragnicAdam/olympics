using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eval.Models;
using Eval.Enums;
using Eval.Controls;
using System.Windows.Forms;

namespace Eval
{
    public partial class MainForm : Form
    {
        private ModeView modeView = ModeView.Small;
        private List<Sport> sports;

        public MainForm()
        {
            InitializeComponent();

            affichagePetitesCartesToolStripMenuItem.Checked = true;

            sports = new List<Sport>();

            sports.Add(new Sport("James W. Naismith", Properties.Resources.basketball_icon, "Basketball", "Massachusetts (USA)", "1891", Properties.Resources.basketball, "Le basketball est un sport d’équipe pratiqué sur un terrain rectangulaire, sur lequel deux équipes composées de cinq joueurs s’affrontent et tentent de marquer en lançant le ballon dans le cerceau et le filet de l’adversaire, à savoir dans le panier."));
            sports.Add(new Sport("", Properties.Resources.sport_climbing_icon, "Escalade sportive", "Bardonecchia (Italie)", "1985", Properties.Resources.sport_climbing, "L’escalade sportive est une discipline moderne issue de l’escalade traditionnelle. Il existe trois disciplines différentes : le bloc, la difficulté et la vitesse. Dans chacune d’entre elles, des points d’ancrage permanents sont fixés à un mur artificiel pour permettre la grimpe."));

            showSports();
        }

        private void showSports()
        {
            flowLayoutPanel.Controls.Clear();

            foreach (Sport sport in sports)
            {
                if (modeView == ModeView.Large)
                {
                    LargeCard largeCard = new LargeCard();
                    largeCard.InitializeLargeCard(sport);
                    flowLayoutPanel.Controls.Add(largeCard);
                } else
                {
                    SmallCard smallCard = new SmallCard();
                    smallCard.InitializeSmallCard(sport);
                    flowLayoutPanel.Controls.Add(smallCard);
                }
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void affichageLargesCartesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modeView = ModeView.Large;
            affichageLargesCartesToolStripMenuItem.Checked = true;
            affichagePetitesCartesToolStripMenuItem.Checked = false;
            showSports();
        }

        private void affichagePetitesCartesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modeView = ModeView.Small;
            affichagePetitesCartesToolStripMenuItem.Checked = true;
            affichageLargesCartesToolStripMenuItem.Checked = false;
            showSports();
        }
    }
}
