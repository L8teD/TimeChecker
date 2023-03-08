using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeChecker.WPF.ViewModels.Commands
{
    public class TimeChangedCommand : CommandBase
    {
        private event Action<DateTime> OnChanged;

        public TimeChangedCommand(Action<DateTime> action)
        {
            OnChanged += action;
        }

        public override void Execute(object parameter)
        {
            if(parameter.GetType() == typeof(DateTime))
                OnChanged?.Invoke((DateTime)parameter);
        }
    }
}
