using EFCExample.Models;
using EFCExample.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EFCExample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ServicePerson service = new ServicePerson();
            service.Create(new Person { PersonID = 1, FirstName = "Hugo", LastName = "Torrico" });                        
            List<Person> people = service.Get();
            lstPeople.ItemsSource = people;
        }
    }
}
