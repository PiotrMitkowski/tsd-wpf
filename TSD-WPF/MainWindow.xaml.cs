using HomeLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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

namespace TSD_WPF
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public delegate void EventFiredEventHandler();
        ObservableCollection<Book> booksList;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            booksList = new ObservableCollection<Book>(MyBookCollection.GetMyCollection());
            BooksListBox.ItemsSource = booksList;
            this.EventFired += new EventFiredEventHandler(eventFired);
        }

        private void eventFired()
        {
            if(BooksListBox.SelectedItem != null)
            {
                var itemToRemove = BooksListBox.SelectedItem as Book;
                booksList.Remove(itemToRemove);
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            booksList.Add(new Book(booksList.Count + 1));
            BooksListBox.SelectedIndex = booksList.Count - 1;
        }

        public event EventFiredEventHandler EventFired
        {
            add { this.bookForm.EventFired += value; }
            remove { this.bookForm.EventFired -= value; }
        }
    }
}
