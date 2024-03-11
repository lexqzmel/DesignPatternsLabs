using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillShop.Classes.Pill
{
    public class PillShop
    {
        private List<Pill> Pills = new List<Pill>();

        // Додати таблетку в магазин
        public void AddPill(Pill pill)
        {
            Pills.Add(Pill);
        }

        // Отримати список всіх таблеток у магазині
        public List<Pill> GetAllPills()
        {
            List<Pill> clonedPills = new List<Pill>();

            foreach (var Pill in Pills)
            {
                clonedPills.Add((Pill)Pill.Clone());
            }

            return clonedPills;
        }
    }
}
