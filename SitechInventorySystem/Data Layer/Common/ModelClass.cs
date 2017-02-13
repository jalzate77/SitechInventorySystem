using SitechInventorySystem.Enumerations;
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
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        #region Fields
        Guid _id;
        string _name;
        RecordState _recordstate;
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
                    NotifyPropertyChanged("ID");
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
                    NotifyPropertyChanged("Name");
                }
            }
        }

        public RecordState RecordState
        {
            get { return _recordstate; }
            set
            {
                if (_recordstate != value)
                {
                    _recordstate = value;
                    NotifyPropertyChanged("RecordState");
                }
            }
        }
        #endregion Properties
    }
}
