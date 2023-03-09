using System;

namespace TimeChecker.WPF.ViewModels
{
    public class ViewItem : ViewModelBase
    {
        private DateTime _date;
        public DateTime Date
        {
            get => _date;
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

        public ViewItem(DateTime date)
        {
            _date = date;
            PickerIn = new TimePickerVM();
            PickerOut = new TimePickerVM();
        }
    }
}
