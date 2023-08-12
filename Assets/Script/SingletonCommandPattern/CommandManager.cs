using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.SingletonCommandManger
{
    public sealed class CommandManager
    {
        #region Variables
        private Stack<ICommand> _commandsBuffer = new Stack<ICommand>();

        private CommandManager() { }
        private static CommandManager instance = null;
        #endregion
        #region Singleton Constructor
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
        #endregion
        #region Public Methods
        public void PushCommand(ICommand command)
        {
            command.Execute();
            _commandsBuffer.Push(command);
        }

        public void PopCommand()
        {
            if (_commandsBuffer.Count == 0)
                return;

            _commandsBuffer.Pop().Undo();
  
        }
        #endregion
    }
}