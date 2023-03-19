using System.Windows.Input;
using TimeChecker.Model;
using TimeChecker.WPF.ViewModels.Commands;

namespace TimeChecker.WPF.ViewModels
{
    public class CalendarVM
    {
        public DataViewerVM DataViewer { get; set; }

        public ICommand NavigateToMonth { get; }

        public CalendarVM(MainModel model)
        {
            DataViewer = new DataViewerVM(model);

            NavigateToMonth = new NavigateToMonthCommand(DataViewer.UpdateItems);
        }

        //private void 
    }
}
