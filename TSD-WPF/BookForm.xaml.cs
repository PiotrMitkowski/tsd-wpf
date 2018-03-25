using HomeLibrary;
using System;
using System.Collections.Generic;
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
using static TSD_WPF.MainWindow;

namespace TSD_WPF
{
    /// <summary>
    /// Logika interakcji dla klasy BookForm.xaml
    /// </summary>
    public partial class BookForm : UserControl
    {
        public event EventFiredEventHandler EventFired;
        public BookForm()
        {
            InitializeComponent();
            typeSelect.ItemsSource = Enum.GetNames(typeof(BookFormat));
        }

        private void UserControl_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (DataContext != null)
            {
                var book = DataContext as Book;
                typeSelect.SelectedItem = Enum.GetName(typeof(BookFormat), book.Format);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext == null)
            {
                MessageBox.Show("No item selected", "Information", MessageBoxButton.OK);
            } 
            else
            {
                MessageBoxResult result = MessageBox.Show("Do you want to delete the following item?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    EventFired();
                }
            }
        }
    }
}
