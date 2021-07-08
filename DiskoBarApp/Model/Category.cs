using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DiskoBarApp.Model
{
    public class Category : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("stringCategory")]
        public string CategoryName { get; set; }
    }

    public class CategoryList : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        [JsonProperty("drinks")]
        public IList<Category> Categories { get; set; }
    }
}
