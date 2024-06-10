using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;

namespace TaskManager
{
    public partial class DataGrid : Window
    {
        public DataGrid()
        {
            InitializeComponent();

            List<Person> person = new List<Person>()
            {
                new Person(1, "John", "12345"),
                new Person(2, "Robert", "12345"),
                new Person(3, "Jack", "12345"),
                new Person(4, "Tony", "12345")
            };
            dataGrid.ItemsSource = person;
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Person(int id, string name, string phoneNumber)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
        }
    }
}
