using Eval.Models;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eval.Controls
{
    public partial class SmallCard : UserControl
    {
        public SmallCard()
        {
            InitializeComponent();
        }
        public void InitializeSmallCard(Sport sport)
        {
            pictureBox.Image = sport.Photo;
        }
    }
}
