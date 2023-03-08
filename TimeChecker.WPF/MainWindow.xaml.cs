using System.Windows;
using TimeChecker.WPF.ViewModels;

namespace TimeChecker.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel mainViewModel;
        public MainWindow()
        {
            mainViewModel = new MainViewModel();

            this.DataContext = mainViewModel;
            InitializeComponent();
        }
    }
}
