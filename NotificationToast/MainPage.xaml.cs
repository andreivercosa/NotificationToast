using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Widget;
using Xamarin.Forms;

namespace NotificationToast
{
    public partial class MainPage : ContentPage, INotification
    {
        void longo(object sender, System.EventArgs e)
        {
            Demorado("Vai demorar.....");
        }
        void rapido(object sender, System.EventArgs e)
        {
            Rapido("Rapidinho!");
        }

        public MainPage()
        {
            InitializeComponent();
        }

        public void Demorado(string msg)
        {
            Toast.MakeText(Android.App.Application.Context, msg, ToastLength.Long).Show();

        }

        public void Rapido(string msg)
        {
            Toast.MakeText(Android.App.Application.Context, msg, ToastLength.Short).Show();
        }
    }
}
