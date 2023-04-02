using System;
using TimeChecker.Types;

namespace TimeChecker.WPF.ViewModels.Commands
{
    public class NavigateToMonthCommand : CommandBase
    {
        private event Action<WorkPeriods> _action;

        public NavigateToMonthCommand(Action<WorkPeriods> action)
        {
            _action += action;
        }

        public override void Execute(object parameter)
        {
            if (parameter != null && parameter is int)
                _action?.Invoke((WorkPeriods)(int)parameter);
        }
    }
}
