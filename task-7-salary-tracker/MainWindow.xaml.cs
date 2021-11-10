using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace task_7_salary_tracker
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private ObservableCollection<Personnel> _salary;

        public ObservableCollection<Personnel> Personnels
        {
            get
            {
                return _salary;
            }
            set
            {
                _salary = value;
                INotifyPropertyChanged("Personnels");
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow()
        {
            Seller_sal = new ObservableCollection<>();
            InitializeComponent();
                        
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Per.Add(new Phone(WorkersList.Text, Convert.ToInt32(WorkersList.Text), Convert.ToInt32(WorkersList.Text)));

            }
            catch
            {
                MessageBox.Show("Возникла ошибка при добавлении телефона", "My App", MessageBoxButton.OK);
            }
        }
    }
    
}
