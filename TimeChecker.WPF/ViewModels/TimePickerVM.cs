using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public TimePickerVM()
        {
            _date = DateTime.Now;
        }
    }
}
