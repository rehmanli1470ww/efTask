using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Whatsapp.Commands
{
    public class Command : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public Action<object>? AsyncAction { get; set; }
        public Predicate<object>? Predicate { get; set; }

        public Command(Action<object> asyncAction, Predicate<object> predicate = null)
        {
            AsyncAction = asyncAction ?? throw new ArgumentNullException(nameof(asyncAction));
            Predicate = predicate;

            if (Predicate == null)
                Predicate = (obj) => true;
        }

        public bool CanExecute(object? parameter)
        {
            return Predicate?.Invoke(parameter!) ?? false;
        }

        public void Execute(object? parameter)
        {
            if (AsyncAction != null)
            {
                AsyncAction.Invoke(parameter);
            }
        }



     
    }
}
