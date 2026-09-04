using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Linq;

namespace elevenday
{
    internal class Class1:INotifyPropertyChanged
    {
        //private int id { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        private int _id { get; set; }
        private string _name { get; set; }
        public int id
        {
            get { return _id; }
            set { _id = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(id)));
            }
            
        }
        public string  name
        {
            get { return _name; }
            set
            {
                _name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(name)));
            }

        }
        public Class1(int id,string name)
        {
            this._id = id;
            this._name = name;
        }

    }
}
