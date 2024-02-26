using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillShop.Classes
{
    public class PillStore
    {
        private List<Pill> _Pills = new List<Pill>(); // Список таблет у магазині

        // Додати таблету до магазину
        public void AddPill(Pill Pill)
        {
            _Pills.Add(Pill);
        }

        // Видалити таблету з магазину
        public void RemovePill(Pill Pill)
        {
            _Pills.Remove(Pill);
        }

        // Пошук таблет за назвою
        public List<Pill> SearchByTitle(string title)
        {
            return _Pills.Where(Pill => Pill.Title.Contains(title)).ToList();
        }

        // Пошук таблет за виробником
        public List<Pill> SearchByProducer(string Producer)
        {
            return _Pills.Where(Pill => Pill.Producer.Contains(Producer)).ToList();
        }

        // Пошук таблет за ціною
        public List<Pill> SearchByPrice(double price)
        {
            return _Pills.Where(Pill => Pill.Price == price).ToList();
        }

        // Отримати список всіх таблет у магазині
        public List<Pill> GetAllPills()
        {
            return _Pills;
        }
    }
}
