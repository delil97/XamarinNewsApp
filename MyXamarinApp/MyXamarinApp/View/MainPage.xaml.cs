using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MyXamarinApp;
using System.Net.Http;
using System.Xml.Linq;
using System.IO;
using MyXamarinApp.Model;
using Newtonsoft.Json;
using MyXamarinApp.ViewModel;

namespace MyXamarinApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
      // lstTemp.ItemsSource = new List<Location>(); //Only needed for UWP

            InitializeComponent();
            BindingContext = App.NewsModel;
        }
       
    }
}
