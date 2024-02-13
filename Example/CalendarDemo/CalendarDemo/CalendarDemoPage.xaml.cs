using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace CalendarDemo
{
    public partial class CalendarDemoPage : ContentPage
    {
        CalendarDemoViewModel Vm
        {
            get { return BindingContext as CalendarDemoViewModel; }
        }

        public CalendarDemoPage()
        {
            InitializeComponent();
            BindingContext = new CalendarDemoViewModel();
        }
    }
}
