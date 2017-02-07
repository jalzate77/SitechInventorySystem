using SitechInventorySystem.Data_Layer.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitechInventorySystem.Data_Layer.Models
{
    public class Brand : DataModel
    {
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
