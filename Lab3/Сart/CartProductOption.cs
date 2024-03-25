using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сart
{
    internal class CartProductOption
    {
        private ICommand addCommand;
        private ICommand subtractCommand;
        private ICommand deleteCommand;
        public CartProductOption(ICommand add, ICommand subtract, ICommand delete)
        {
            this.addCommand = add;
            this.subtractCommand = subtract;
            this.deleteCommand = delete;
        }
        public void clickAdd()
        {
            addCommand.Execute();
        }
        public void clickSubtract()
        {
            subtractCommand.Execute();
        }
        public void clickDelete()
        {
            deleteCommand.Execute();
        }
    }
}
