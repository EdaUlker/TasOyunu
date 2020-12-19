using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public class Cell
    {
        public Stone Stone { get; set; }
        public Button Button { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Cell()
        {

        }

        public Cell(int X,int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public Cell(int X, int Y,Button Button)
        {
            this.X = X;
            this.Y = Y;
            this.Button = Button;
        }
    }
}
