using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    class AStar
    {
        int[,] harita;
        int X, Y;

        public AStar(List<Cell> taslar, List<Cell> duvarlar, int x, int y)
        {
            //0 lar gidilebilir
            harita = new int[x, y];
            for(int i=0;i<x;i++){
                for(int j=0;j<y;j++){
                    harita[i, j] = 0;
                }
            }
            //negatif sayılar gidilemez yerler
            foreach(Cell c in taslar){
                harita[c.X, c.Y] = -1;
            }

            foreach (Cell c in duvarlar)
            {
                harita[c.X, c.Y] = -1;
            }

            X = x;
            Y = y;

        }

        private double Maliyet(Cell baslangic, Cell hedef, Cell anlik)
        {
            //baslangica olan uzaklik + hedefe olan uzaklık
            double g_n = Math.Sqrt(Math.Pow(baslangic.X - anlik.X, 2) + Math.Pow(baslangic.Y - anlik.Y, 2));
            //hedefe uzaklik
            double h_n = Math.Sqrt(Math.Pow(hedef.X - anlik.X, 2) + Math.Pow(hedef.Y - anlik.Y, 2));

            return h_n + g_n;
        }

        bool gezildimi_engelvarmi(List<Cell> gezilen, Cell simdiki)
        {
            foreach(Cell c in gezilen){
                if (c.X == simdiki.X && c.Y == simdiki.Y)
                    return true;
            }

            //duvar veya taş varsa gitme
            if (harita[simdiki.X, simdiki.Y] < 0)
                return true;
            //hiç bir şey yok
            return false;
        }

        private List<Cell> Yolu_Dondur(List<Node> c, Cell hedef)
        {
            //yol ters inşa edilik. Stack ile düze çevir
            Stack<Cell> tersle = new Stack<Cell>();
            tersle.Push(hedef);
            bool tamam = false;
            Cell p = hedef;
            while (!tamam)
            {
                // öncekini bul
                for (int i=0;i< c.Count; i++)
                {
                    Node n = c[i];
                    if (n.kendi.X == p.X && n.kendi.Y == p.Y)
                    {
                        p = n.parent;
                        if (p == null)
                        {
                            tamam = true;
                            break;
                        }
                        tersle.Push(n.parent);
                        c.Remove(n);
                        break;
                    }
                }
            }

            // balangic bitis yolunu olustur
            List<Cell> cozumYolu = new List<Cell>();
            while (tersle.Count > 0)
            {
                cozumYolu.Add(tersle.Pop());
            }

            return cozumYolu;
        }

        //Cozum yolunu bul
        public List<Cell> yolu_bul(Cell baslangic, Cell bitis)
        {
            //her tas icin haritayı güncelle. Taş hedefe gidince orada taş olmayacak.
      
            List<Node> cozum = new List<Node>();
            
            List<Cell> gezilecek = new List<Cell>();
            List<Cell> gezilen = new List<Cell>();

            // baslangic nodeunu ekle
            cozum.Add(new Node(baslangic, null, 0));

            gezilecek.Add(baslangic);

            while (gezilecek.Count > 0)
            {
                double[] maliyetler = new double[gezilecek.Count];
                for (int i = 0; i < maliyetler.Length; i++)
                {
                    maliyetler[i] = Maliyet(baslangic, bitis, gezilecek[i]);
                }
                //en kücük maliyeti bul
                int min_index = 0;
                double min_maliyet = maliyetler[0];
                for (int i = 1; i < maliyetler.Length; i++)
                {
                    if (min_maliyet > maliyetler[i])
                    {
                        min_index = i;
                        min_maliyet = maliyetler[i];
                    }
                }

                Cell anlik = gezilecek[min_index];
                gezilecek.Remove(anlik);
                gezilen.Add(anlik);
                
                if (anlik.X == bitis.X && anlik.Y == bitis.Y)
                {
                    return Yolu_Dondur(cozum, anlik);
                }

                //anlik cell'in komşularına git
                //aşağı komşu
                if (anlik.X + 1 < X  && harita[anlik.X + 1, anlik.Y] == 0)
                {
                    
                    Cell tmp = new Cell(anlik.X + 1, anlik.Y);
                    if (!gezildimi_engelvarmi(gezilen, tmp))
                    {
                        cozum.Add(new Node(tmp, anlik, Maliyet(baslangic, bitis, tmp)));
                        gezilecek.Add((tmp));
                    }

                }
                //yukarı komşu
                if (anlik.X - 1 >= 0 && harita[anlik.X - 1, anlik.Y] == 0)
                {
                    Cell tmp = new Cell(anlik.X - 1, anlik.Y);
                    if (!gezildimi_engelvarmi(gezilen, tmp))
                    {
                        cozum.Add(new Node(tmp, anlik, Maliyet(baslangic, bitis, tmp)));
                        gezilecek.Add((tmp));
                    }
                }
                //sol
                if (anlik.Y - 1 >= 0 && harita[anlik.X, anlik.Y-1] == 0)
                {
                    Cell tmp = new Cell(anlik.X, anlik.Y-1);
                    if (!gezildimi_engelvarmi(gezilen, tmp))
                    {
                        cozum.Add(new Node(tmp, anlik, Maliyet(baslangic, bitis, tmp)));
                        gezilecek.Add((tmp));
                    }
                }

                //sag
                if (anlik.Y + 1 < Y && harita[anlik.X, anlik.Y + 1] == 0)
                {
                    Cell tmp = new Cell(anlik.X, anlik.Y + 1);
                    if (!gezildimi_engelvarmi(gezilen, tmp))
                    {
                        cozum.Add(new Node(tmp, anlik, Maliyet(baslangic, bitis, tmp)));
                        gezilecek.Add((tmp));
                    }
                }
            }

            return null;
        }


    }

    public class Node{
        public Cell kendi;
        public Cell parent;
        double M;
        public Node(Cell k, Cell p, double maliyet){
            parent = p;
            M = maliyet;
            kendi = k;
        }
    }
    
}
