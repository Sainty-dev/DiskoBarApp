using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DiskoBarApp.Model
{
    public class Glass : INotifyPropertyChanged
    {
        [JsonProperty("strGlass")]
        public string GlassName { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class GlassList : INotifyPropertyChanged
    {
        [JsonProperty("drinks")]
        public IList<Glass>  Glasses { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
