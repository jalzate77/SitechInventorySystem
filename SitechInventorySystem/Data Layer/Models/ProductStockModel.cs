using SitechInventorySystem.Data_Layer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitechInventorySystem.Data_Layer.Models
{
    public class ProductStock : DataModel
    {
        #region Fields
        string _remarks;
        #endregion Fields

        #region Properties
        public string Remarks
        {
            get { return _remarks; }
            set
            {
                if (_remarks != value)
                {
                    _remarks = value;
                    NotifyPropertyChanged("Remarks");
                }
            }
        }
        #endregion Properties
    }
}
