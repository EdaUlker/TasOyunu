using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class anaForm : Form
    {
        
        Button[,] buttonCell = new Button[8, 8];
        Button btnTarget=null;
        const int MAXSTONECOUNT = 8;
        int targetCounter=0,stoneCounter=0;
        string Source;
        Stone CelltargetStone=null;
        Cell targetStoneCell = null;
        Button btnEngel = null;
        List<Cell> taslar = new List<Cell>();
        List<Cell> engeller = new List<Cell>();
        public anaForm()
        {
            InitializeComponent();
        }

        public List<Cell> a_star(Cell baslangic, Cell bitis, int x, int y)
        {

            AStar a = new AStar(taslar, engeller, x, y);
            List<Cell> yol = a.yolu_bul(baslangic, bitis);
            if (yol == null)
            {
                throw new Exception("Yol yok!");
            }
            return yol;
        }

        private void anaForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    buttonCell[i, j] = new Button();
                    buttonCell[i, j].Size = new Size(70, 70);
                    buttonCell[i, j].Name = "pctr" + i + "" + j;
                    buttonCell[i, j].Location = new Point(j * 70, i * 70);
                    buttonCell[i, j].AllowDrop = true;
                    buttonCell[i, j].BackgroundImageLayout = ImageLayout.Stretch;

                    if ((i + j) % 2 == 0)
                    {
                        buttonCell[i, j].BackColor = Color.Black;
                        
                    }
                    else
                    {
                        buttonCell[i, j].BackColor = Color.White;
                    }

                    buttonCell[i, j].ForeColor = Color.Red;
                    buttonCell[i, j].TextImageRelation = TextImageRelation.TextAboveImage;
                    buttonCell[i, j].DragEnter += new DragEventHandler(button_DragEnter);
                    buttonCell[i, j].DragDrop += new DragEventHandler(button_DragDrop);
                    


                    buttonCell[i, j].Tag = new Cell(i,j,buttonCell[i,j]);

                    panel2.Controls.Add(buttonCell[i, j]);

                }
            }
            pictureBox1.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            pictureBox1.AllowDrop = true;
            duvar.AllowDrop = true;
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && stoneCounter<MAXSTONECOUNT)
            {
                Source = "Stone";
                pictureBox1.DoDragDrop(pictureBox1.Image, DragDropEffects.Move);
            }

        }

        private void targetStone_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && targetCounter<1)
            {
                Source = "Target";
                targetStone.DoDragDrop(targetStone.Image, DragDropEffects.Move);
            }
        }

        private void duvar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Source = "Duvar";
                duvar.DoDragDrop(duvar.Image, DragDropEffects.Move);
            }
        }


        private void button_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Move;
                
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void button_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                Button pb = sender as Button;
                if (Source != null && Source.Equals("Target"))
                {
                    targetCounter++;
                    btnTarget = pb;
                    pb.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
                    e.Effect = DragDropEffects.None;
                    Source = null;
                    Cell cell = (Cell)pb.Tag;
                    targetStoneCell = cell;
                    CelltargetStone = new Stone(targetStone.Image, Stone.TARGETSTONE, cell);

                }

                else if (Source != null && Source.Equals("Duvar"))
                {
                    btnEngel = pb;
                    pb.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
                    e.Effect = DragDropEffects.None;
                    Source = null;
                    Cell cell = (Cell)pb.Tag;
                    engeller.Add(cell);

                    
                }
                else if (Source != null && Source.Equals("Stone"))
                {
                    stoneCounter++;
                    pb.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
                    e.Effect = DragDropEffects.None;
                    Source = null;
                    Cell cell = (Cell)pb.Tag;
                    taslar.Add(cell);
                    Stone stone = new Stone(pictureBox1.Image, Stone.NORMALSTONE, cell);
                    cell.Stone = stone;
                    int distance = DistanceFromTarget(pb);
                    pb.Text = distance.ToString();
                    

                }

                
                else
                {
                   
                }
            }

            catch(Exception ex)
            {
               
            }
           
         
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            while(taslar.Count>0) {
                List<Cell> cozumyolu;
                Cell baslangic = taslar[0];
                taslar.RemoveAt(0);
                cozumyolu =a_star(baslangic, targetStoneCell, 8, 8);

                //hareket ettir
                for(int j =1;j<cozumyolu.Count; j++)
                {
                    buttonCell[cozumyolu[j - 1].X, cozumyolu[j - 1].Y].BackgroundImage = null;
                    if(j != cozumyolu.Count-1)
                        buttonCell[cozumyolu[j].X, cozumyolu[j].Y].BackgroundImage = pictureBox1.Image;
                    anaForm.ActiveForm.Update();
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKural_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oyun tahtasına önce hedef taş yerleştirilir. Ardından duvarlar ve yan taşlar yerleştirilir. Başla butonuna basıldığında yan taşlar hedefe doğru harekete geçer.");

        }

        private int DistanceFromTarget(Button btnStone)
        {
            int Xdif, YDif;
            Cell targetCell, stoneCell;
            if (btnTarget != null && btnStone != null)
            {
                targetCell = (Cell)btnTarget.Tag;
                stoneCell = (Cell)btnStone.Tag;
                Xdif = (int)Math.Abs(targetCell.X - stoneCell.X);
                YDif = (int)Math.Abs(targetCell.Y - stoneCell.Y);
                return Xdif + YDif;
            }
            else
            {
                throw new Exception("Stone yanlış");
            }

        }
    }
}
