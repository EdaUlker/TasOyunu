using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace deneme
{
    public class Stone
    {
        public Cell Cell { get; set; }
        public static readonly int TARGETSTONE=0;
        public static readonly int NORMALSTONE = 1;
        public Image image { get; set; }

        public int StoneType { get; set; }

        public Stone()
        {

        }

        public Stone(Image image, int StoneType)
        {
            this.image = image;
            this.StoneType = StoneType;
        }

        public Stone(Image image, int StoneType,Cell cell)
        {
            this.image = image;
            this.StoneType = StoneType;
            this.Cell = Cell;
        }

     

    }
}
