using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.SingletonCommandManger
{
    public sealed class CommandManager
    {
        private Stack<ICommand> _commandsBuffer = new Stack<ICommand>();

        private CommandManager() { }
        private static CommandManager instance = null;
        public static CommandManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CommandManager();
                }
                return instance;
            }
        }
        public void PushCommand(ICommand command)
        {
            command.Execute();
            _commandsBuffer.Push(command);
        }
        // TODO?
        //public void Rewind()
        //{
        //    while (_commandsBuffer.Count > 0)
        //    {
        //        PopCommand();
        //    }
        //}
        public void PopCommand()
        {
            if (_commandsBuffer.Count == 0)
                return;

            _commandsBuffer.Pop().Undo();
  
        }
    }
}