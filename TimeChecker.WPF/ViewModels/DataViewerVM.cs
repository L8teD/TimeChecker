using System;
using System.Collections.ObjectModel;

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
    }
}
