using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class MacroCommands
    {
        private List<Command> _commands;

        public MacroCommands()
        {
            _commands = new List<Command>();
        }

        public void AddCommand(Command command)
        {
            _commands.Add(command);
        }

        public void ExecuteCommands()
        {
            foreach (Command command in _commands)
            {
                command.Execute();
            }
        }

        public void UndoCommands()
        {
            for (int i = _commands.Count - 1; i >= 0; i--)
            {
                _commands[i].Undo();
            }
        }
    }
}
