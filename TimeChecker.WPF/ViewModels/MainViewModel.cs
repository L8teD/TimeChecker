using System.Windows.Input;
using TimeChecker.Model;

namespace TimeChecker.WPF.ViewModels
{
    public class MainViewModel
    {
        private MainModel _model;
        public CalendarVM Calendar { get; set; }
        public ICommand NavigateCommand { get; }
        public MainViewModel()
        {
            _model= new MainModel();

            Calendar = new CalendarVM(_model);
        }
    }
}
