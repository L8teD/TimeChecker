using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeChecker.WPF.ViewModels
{
    public class ViewItem : ViewModelBase
    {
        private string _date;
        public string Date
        {
            get=>_date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }


        private TimePickerVM _pickerIn;
        public TimePickerVM PickerIn
        {
            get => _pickerIn;
            set
            {
                _pickerIn = value;
                OnPropertyChanged(nameof(PickerIn));
            }
        }

        private TimePickerVM _pickerOut;
        public TimePickerVM PickerOut
        {
            get => _pickerOut;
            set
            {
                _pickerOut = value;
                OnPropertyChanged(nameof(PickerOut));
            }
        }
    }
}
