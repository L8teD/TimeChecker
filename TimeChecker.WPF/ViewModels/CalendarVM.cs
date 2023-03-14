using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TimeChecker.WPF.ViewModels
{
    public class CalendarVM
    {
        public DataViewerVM DataViewer { get; set; }

        public ICommand NavigateToMonth { get; }

        public CalendarVM()
        {
            DataViewer = new DataViewerVM();

        }

        //private void 
    }
}
