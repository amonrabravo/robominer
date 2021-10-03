using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboMiner
{
    public abstract class Material
    {

        public Material(int quantity)
        {
            Quantity = quantity;
        }

        public int Quantity { get; set; }

        public int Value { get; protected set; }
    }

    public class Gold : Material
    {
        public Gold(int quantity) : base(quantity)
        {
            Value = 10;
        }
    }

    public class Silver : Material
    {
        public Silver(int quantity) : base(quantity)
        {
            Value = 5;
        }
    }

    public class Cooper : Material
    {
        public Cooper(int quantity) : base(quantity)
        {
            Value = 1;
        }
    }


}
