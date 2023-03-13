using System.Windows.Input;
using TimeChecker.Model;

namespace TimeChecker.WPF.ViewModels
{
    public class MainViewModel
    {
        private MainModel _model;
        public DataViewerVM DataViewer { get; set; }
        public ICommand NavigateCommand { get; }
        public MainViewModel()
        {
            _model= new MainModel();

            DataViewer = new DataViewerVM();
        }
    }
}
