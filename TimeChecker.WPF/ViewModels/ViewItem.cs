using System;
using TimeChecker.Types;

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

        private TypeOfDay _typeOfDay;
        public TypeOfDay TypeOfDay
        {
            get => _typeOfDay;
            set
            {
                _typeOfDay = value;
                OnPropertyChanged(nameof(TypeOfDay));
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

        public ViewItem(DateTime date, TypeOfDay type)
        {
            _date = date;
            _typeOfDay = type;
            PickerIn = new TimePickerVM();
            PickerOut = new TimePickerVM();
        }
    }
}
