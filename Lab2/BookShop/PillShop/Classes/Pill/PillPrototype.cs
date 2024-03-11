using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillShop.Classes.Pill
{
    public abstract class PillPrototype
    {
        public string title { get; set; }
        public string producer { get; set; }
        public double price { get; set; }
        public double count { get; set; }



        public abstract PillPrototype Clone();
        public abstract void ShowDetails();
    }
}
