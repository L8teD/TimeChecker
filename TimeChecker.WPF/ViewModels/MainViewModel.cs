namespace TimeChecker.WPF.ViewModels
{
    public class MainViewModel
    {
        public DataViewerVM DataViewer { get; set; }
        public MainViewModel()
        {
            DataViewer = new DataViewerVM();
        }
    }
}
