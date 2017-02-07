using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitechInventorySystem.Data_Layer.Common
{
    public class DataModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propName)
        {
                if(this.PropertyChanged != null)
                        this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        #region Fields
        Guid _id;
        string _name;
        #endregion Fields

        #region Properties
        public Guid ID
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    this.NotifyPropertyChanged("ID");
                }
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    this.NotifyPropertyChanged("Name");
                }
            }
        }
        #endregion Properties
    }
}
