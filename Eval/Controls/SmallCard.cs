using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Eval.Models;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eval.Controls
{
    public partial class SmallCard : UserControl
    {
        public Sport sport;
        public SmallCard()
        {
            InitializeComponent();
        }

        public void InitializeSmallCard(Sport sport)
        {
            this.sport = sport;
            pictureBox.Image = sport.Photo;
            pictureLogo.Image = sport.Logo;
            labelName.Text = sport.Name;
            pictureBox.MouseClick += PictureBox_MouseClick;
        }

        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            string text = "Sport : " + sport.Name + "\n";
            text += "Origine : " + sport.Origin + "\n";
            text += "Période : " + sport.Period + "\n";
            text += "Inventeur : " + sport.Inventor + "\n";
            MessageBox.Show(text);
        }
    }
}
