using Eval.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eval.Controls
{
    public partial class LargeCard : UserControl
    {
        public LargeCard()
        {
            InitializeComponent();
        }

        public void InitializeLargeCard(Sport sport)
        {
            pictureBox.Image = sport.Photo;
            labelOrigin.Text = sport.Origin;
            labelInventor.Text = sport.Inventor;
            labelDescription.Text = sport.Summary;
            labelPeriod.Text = sport.Period;
        }
    }
}
