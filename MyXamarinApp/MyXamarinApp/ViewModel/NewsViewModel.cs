using MyXamarinApp.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;

namespace MyXamarinApp.ViewModel
{
   public class NewsViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Location> _newsApi = new ObservableCollection<Location>();

        public ObservableCollection<Location> newsApi
        {
            get
            {
                return this._newsApi;
            }

            set
            {
                this._newsApi =value;
                OnPropertyChanged("newsApi");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

        public async void WebQuestion()
        {
            try
            {

                string URL = "https://polisen.se/api/events";
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(new Uri(URL));
                if (response.IsSuccessStatusCode)
                {
                    
                    var content = await response.Content.ReadAsStringAsync();

                    var newsList = JsonConvert.DeserializeObject<ObservableCollection<Location>>(content);
                    newsApi = newsList;

                    //_newsApi.Clear();
                    //foreach (var item in newsList)
                    //{
                    //    _newsApi.Add(item);
                    //}
                    

                }         
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
    }
}
