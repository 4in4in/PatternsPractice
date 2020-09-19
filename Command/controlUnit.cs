using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class controlUnit
    {
        private List<command> commands = new List<command>();
        private int current = 0;

        public void storeCommand(command cmd)
        {
            commands.Add(cmd);
        }

        public void executeCommand()
        {
            commands[current].execute();
            current++;
        }

        public void undo()
        {
            current--;
            commands[current].unExecute();
        }

        public void redo()
        {
            current--;
            storeCommand(commands[current]);
            executeCommand();
        }
    }
}
