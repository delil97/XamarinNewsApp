using System;
using System.Collections.Generic;
using System.Text;

namespace MyXamarinApp.Model
{
    public class Location
    {
        public string name { get; set; }
        public string gps { get; set; }
        public int id { get; set; }
        public string datetime { get; set; }
        public string summary { get; set; }
        public string url { get; set; }
        public string type { get; set; }
        public Location location { get; set; }
    }






}
