using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboMiner
{
    public class Map
    {
        public Map(int size)
        {
            var sequence = Enumerable.Range(1, 20).ToList();
            var quantities = Enumerable.Range(1, 3).ToList();

            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    var randomOrder = sequence.OrderBy(p => Guid.NewGuid()).First();
                    var quantity = quantities.OrderBy(p => Guid.NewGuid()).First();
                    var dot = new Dot(x, y);
                    if (new[] { 1 }.Contains(randomOrder))
                        dot.Material = new Gold(quantity);
                    else if (new[] { 2, 3, 4 }.Contains(randomOrder))
                        dot.Material = new Silver(quantity * 2);
                    else if (new[] { 5, 6, 7, 8, 9, 10 }.Contains(randomOrder))
                        dot.Material = new Cooper(quantity * 3);

                    Dots.Add(dot);
                }
            }



        }

        public List<Dot> Dots { get; set; } = new List<Dot>();



        public int Size => (int)Math.Sqrt(Dots.Count);
    }
}
