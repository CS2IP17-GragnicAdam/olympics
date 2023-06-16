
using System.Drawing;

namespace Eval.Models
{
    public class Sport
    {
        public string Inventor { get; set; }
        public Image Logo { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }
        public string Period { get; set; }
        public Image Photo { get; set; }
        public string Summary { get; set; }

        public Sport()
        {

        }

        public Sport(string inventor, Image logo, string name, string origin, string period, Image photo, string summary)
        {
            Inventor = inventor;
            Logo = logo;
            Name = name;
            Origin = origin;
            Period = period;
            Photo = photo;
            Summary = summary;
        }
    }
}
