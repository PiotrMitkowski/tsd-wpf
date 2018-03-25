using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLibrary
{
    public class Book: INotifyPropertyChanged
    {
        private string _title;
        public int Id { get; private set; }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                this._title = value;
                OnPropertyChanged("Title");
            }
        }

        public string Author {
            get
            {
                return _author;
            }
            set
            {
                this._author = value;
                OnPropertyChanged("Author");
            }
        }

        private bool _isRead;
        private string _author;
        private int _year;
        private BookFormat _format;

        public bool IsRead {
            get
            {
                return _isRead;
            }
            set
            {
                this._isRead = value;
                OnPropertyChanged("IsRead");
            }
        }

        public int Year {
            get
            {
                return _year;
            }
            set
            {
                this._year = value;
                OnPropertyChanged("Year");
            }
        }

        public BookFormat Format {
            get
            {
                return _format;
            }
            set
            {
                this._format = value;
                OnPropertyChanged("Format");
            }
                
        }

        public Book(int id)
        {
            Id = id;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public enum BookFormat
    {
        PaperBack, EBook
    }

    public static class MyBookCollection
    {
        public static ObservableCollection<Book> GetMyCollection()
        {
            return new ObservableCollection<Book>()
            {
                new Book(1){ Author = "J.K. Rowling", Format = BookFormat.EBook, IsRead = true, Title = "Harry Potter and the Philosopher's Stone", Year=1997},

                new Book(1)
                {
                    Author = "J.K. Rowling", Format = BookFormat.EBook, IsRead = true, Title = "Harry Potter and the Chamber of Secrets",
                    Year = 1998
                },

                new Book(3){ Author = "J.K. Rowling", Format = BookFormat.PaperBack, IsRead = true, Title = "Harry Potter and the Prisoner of Azkaban", Year = 1999},

                new Book(4){ Author = "Jonathan Swift", Format = BookFormat.PaperBack, IsRead = false, Title = "Travels into Several Remote Nations of the World. In Four Parts. By Lemuel Gulliver, First a Surgeon, and then a Captain of several Ships", Year=1972},

                new Book(5){Author = "Wayne Thomas Batson", Format = BookFormat.EBook, IsRead = true, Title = "Isle of Swords", Year = 2007},

                new Book(5){Author = "Louis A. Meyer", Format = BookFormat.EBook, IsRead = true, Title = "Under the Jolly Roger", Year = 200},
                
            };

        }
    }
}
