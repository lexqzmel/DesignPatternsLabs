using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7.Patern
{
    // Клас, що зберігає та відновлює стан товару
    class Caretaker
    {
        private Memento _memento;

        public void Backup(Product product)
        {
            _memento = product.CreateMemento();
        }

        public void Restore(Product product)
        {
            if (_memento != null)
            {
                product.RestoreMemento(_memento);
            }
        }
    }
}
