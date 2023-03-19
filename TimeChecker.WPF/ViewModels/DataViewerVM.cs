using System;
using System.Collections.ObjectModel;
using TimeChecker.Model;
using TimeChecker.Model.Calendar;
using TimeChecker.Types;

namespace TimeChecker.WPF.ViewModels
{
    public class DataViewerVM
    {
        private MainModel _model;
        public ObservableCollection<ViewItem> DataItems { get; set; }

        public DataViewerVM(MainModel model)
        {
            _model = model;

            DataItems = new ObservableCollection<ViewItem>();

            UpdateItems(TypeConverter.DateTimeToPeriods(DateTime.Now));
        }

        public void UpdateItems(WorkPeriods period)
        {
            WorkPeriod? workPeriod = _model.GetWorkPeriods().Find(p => p.Period == period);

            if (workPeriod != null && DataItems != null)
            {
                DataItems.Clear();
                foreach (var day in workPeriod.GetPeriod())
                    DataItems.Add(new ViewItem(new DateTime(2023, day.Month, day.Day), day.DayType));
            }
        }

    }
}
