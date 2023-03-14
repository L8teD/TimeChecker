using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TimeChecker.Model.Calendar;

namespace TimeChecker.WPF.ViewModels
{
    public class DataViewerVM
    {
        public ObservableCollection<ViewItem> DataItems { get; set; }

        public DataViewerVM()
        {
            DataItems = new ObservableCollection<ViewItem>();

            DataItems.Add(new ViewItem(DateTime.Now.AddDays(0)));
            DataItems.Add(new ViewItem(DateTime.Now.AddDays(1)));
            DataItems.Add(new ViewItem(DateTime.Now.AddDays(2)));
        }

        public void UpdateItems(WorkPeriod period)
        {
            
        }
    }
}
