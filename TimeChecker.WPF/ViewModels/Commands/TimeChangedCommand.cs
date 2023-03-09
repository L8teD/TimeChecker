using System;

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
            MaterialDesignThemes.Wpf.TimeChangedEventArgs args = parameter as MaterialDesignThemes.Wpf.TimeChangedEventArgs;
            if (args != null)
                OnChanged?.Invoke(args.NewTime);
        }
    }
}
