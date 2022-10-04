using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        ObservableCollection<Person> people = new ObservableCollection<Person>();

        public ObservableCollection<Person> People { get { return people; } }
        public ListViewGroup()
        {   
            InitializeComponent();

            GroupView.ItemsSource = people;
            people.Add(new Person("Alpha", "A")
            {
                new Employee{ DisplayName = "Antonio Banderas"}
            });
            people.Add(new Person("Bravo", "B")
            {
                new Employee { DisplayName = "Bill Wrestler" },
                new Employee { DisplayName = "Burt Indybrick" }
            });
            people.Add(new Person("Charlie", "C")
            {
                new Employee { DisplayName = "Celine Dion" },
                new Employee { DisplayName = "Christopher Lloyd"}   
            });
            people.Add(new Person("Delta", "D")
            {
                new Employee { DisplayName = "Dr. Geri-Beth Hooper" },
                new Employee { DisplayName = "Dr. Keith Joyce-Purdy" }
            });
            people.Add(new Person("Romeo", "R")
            {
                new Employee { DisplayName = "Rob Finnerty" }
            });
            people.Add(new Person("Sierra", "S")
            {
                new Employee { DisplayName = "Sheri Spruce" }
            });

         
        }
    }
}