using System.Windows;

namespace Modson
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var accessorService = new ModsonService.ModsonDatabaseAccessorService();
            _gridControl.BeginDataUpdate();
            try
            {
                var dbConfig = ModsonDatabaseConnectionSettings.Settings;
                var connectionString = $"Server={dbConfig.Host};Port={dbConfig.Port};" +
                                          $"User Id={dbConfig.User};Password={dbConfig.Password};Database={dbConfig.DatabaseName};";
                _gridControl.ItemsSource = accessorService.GetUsers(connectionString);
            }
            finally
            {
                _gridControl.EndDataUpdate();
            }
        }
    }
}
