using EFCExample.Models;
using EFCExample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EFCExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CourseView : ContentPage
    {
        public CourseView()
        {
            InitializeComponent();
        }
        

        private void Button_Clicked(object sender, EventArgs e)
        {
            int CourseID = 0;
            DBDataAccess<Course> service = new DBDataAccess<Course>();            
            CourseID = service.Get().ToList().Count + 1;
            service.Create(new Course { CourseID = CourseID, Name = txtName.Text, Grade = txtGrade.Text });
            lstCourses.ItemsSource = service.Get();


            //ServiceCourse service = new ServiceCourse();
            //int CourseID = 0;
            //CourseID = service.Get().Count + 1;
            //service.Create(new Course {CourseID= CourseID, Name = txtName.Text, Grade = txtGrade.Text } );
            //lstCourses.ItemsSource = service.Get();

        }
    }
}