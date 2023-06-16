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
            sports.Add(new Sport("Jigoro Kano", Properties.Resources.judo_icon, "Judo", "Japon", "1882", Properties.Resources.judo, "Le judo est un art martial japonais qui repose sur des techniques de projection et de lutte qui permettent de maîtriser l’adversaire, avec un focus mis sur la condition physique, la discipline mentale et l’esprit sportif."));
            sports.Add(new Sport("", Properties.Resources.swimming_icon, "Natation", "Grande-Bretagne", "19ème siècle", Properties.Resources.swimming, "La natation aux Jeux Olympiques est un sport aussi bien individuel que d’équipe dans lequel les concurrents propulsent leur corps dans l’eau d’une piscine, en salle ou en plein air, en utilisant l’une des nages suivantes : nage libre, dos, brasse et papillon."));
            sports.Add(new Sport("Larry Stevenson ?", Properties.Resources.skateboarding_icon, "Skateboard", "Californie (USA)", "1950", Properties.Resources.skateboarding, "Le skateboard est autant un sport qu’une activité de loisir, qui consiste à rouler et à exécuter des figures sur une planche à roulettes - un skateboard."));
            sports.Add(new Sport("", Properties.Resources.surfing, "Surf", "Pérou, Polynésie puis Hawaï (USA)", "Antiquité", Properties.Resources.surfing, "Le surf est un sport aquatique dans lequel un athlète exécute des manoeuvres sur une vague tout en se tenant debout sur une planche."));
            sports.Add(new Sport("", Properties.Resources.surfing, "Taekwondo", "Corée", "50 avant J-C", Properties.Resources.taekwondo, "Le taekwondo est un art martial coréen traditionnel pratiqué dans 206 pays, qui enseigne bien plus que des techniques de combat physique. Taekwondo est un mot coréen composé de trois parties : ‘Tae’, qui signifie pied ou fouler, ‘Kwon’, qui signifie poing ou combat, et ‘Do’, qui désigne voie ou discipline."));

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
