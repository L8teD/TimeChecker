using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TimeChecker.WPF.ViewModels.Commands;

namespace TimeChecker.WPF.ViewModels
{
    public class TimePickerVM : ViewModelBase
    {
        private DateTime? _date;

        public DateTime? Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }

        public ICommand TimeChangedCommand { get; }

        public TimePickerVM()
        {
            _date = DateTime.Now;

            TimeChangedCommand = new TimeChangedCommand(OnTimeChanged);
        }

        private void OnTimeChanged(DateTime time)
        {
            Date = time;
        }
    }
}
