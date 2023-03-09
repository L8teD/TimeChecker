using System;
using System.Windows.Input;
using TimeChecker.WPF.ViewModels.Commands;

namespace TimeChecker.WPF.ViewModels
{
    public class TimePickerVM : ViewModelBase
    {
        private DateTime? _time;

        public DateTime? Time
        {
            get => _time;
            set
            {
                _time = value;
                OnPropertyChanged(nameof(Time));
            }
        }

        public ICommand TimeChangedCommand { get; }

        public TimePickerVM()
        {
            _time = DateTime.Now;
            TimeChangedCommand = new TimeChangedCommand(OnTimeChanged);
        }

        private void OnTimeChanged(DateTime time)
        {
            Time = time;
        }
    }
}
