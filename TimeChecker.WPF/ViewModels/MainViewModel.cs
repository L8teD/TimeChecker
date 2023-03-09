using TimeChecker.Model;

namespace TimeChecker.WPF.ViewModels
{
    public class MainViewModel
    {
        private MainModel _model;
        public DataViewerVM DataViewer { get; set; }
        public MainViewModel()
        {
            _model= new MainModel();

            DataViewer = new DataViewerVM();
        }
    }
}
