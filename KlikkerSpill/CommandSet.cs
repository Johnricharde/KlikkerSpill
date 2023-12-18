using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerSpill
{
    class CommandSet
    {
        ICommand[] _commands = new ICommand[]
        {
            new Exit(),
            new Click(),
            new Upgrade(),
            new IncreaseUpgrade(),
        };

        void RunCommand(char charInput)
        {
            var command = FindCommand(charInput);
        }

        private ICommand FindCommand(char charInput)
        {
            foreach (var command in _commands)
                if (command.Character == charInput) return command;

            return null;
        }
    }
}
