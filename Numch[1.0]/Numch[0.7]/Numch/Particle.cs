using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms.Layout;
using System.Windows.Forms.Design;

namespace Numch
{
    //<summary>
    //Particles shoud fade in from the bottom of the screen
    //and move upwards fading out slowlly. Color should
    //get darker the further away the particles go from the
    //bottom
    //</summary>
    public class Particle//Class to Create/Draw/Move particles on canvas
    {
        private Color _Color = new Color();
        public void CreateMany()
        {//Call create one in a for loop
        }
        private void CreateOne()
        {//Draw one particle in a pos
        }
        private void Fade()
        {//Increase darkness of color as you move up
        }
        private void MoveUp()
        {//Move the particles up
        }
        private void RandomColor()
        {//Generate a random color
            Random rnd = new Random();
            Color rndColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            _Color = rndColor;
        }
    }
}