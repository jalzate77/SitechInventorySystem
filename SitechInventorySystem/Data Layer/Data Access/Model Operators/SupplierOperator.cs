using SitechInventorySystem.Data_Layer.Models;
using SitechInventorySystem.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitechInventorySystem.Data_Layer.Data_Access.Model_Operators
{
    public class SupplierOperator : BaseOperator
    {
        public SupplierOperator() : base("Supplier") { }

        public Guid Create(Supplier Data)
        {
            Values["Name"] = Data.Name.Trim();
            return Create();
        }

        public int Update(Supplier Data)
        {
            Values["Name"] = Data.Name.Trim();
            Conditions["id"] = Data.ID;
            return Update();
        }

        public int Delete(Supplier Data)
        {
            Conditions["id"] = Data.ID;
            return Delete();
        }

        public new List<Supplier> Read()
        {
            var data = base.Read();
            var coll = new List<Supplier>();
            foreach (var item in data)
            {
                coll.Add(new Supplier()
                {
                    ID = (Guid)data["id"],
                    Name = data["Name"].ToString(),
                    RecordState = (RecordState)data["RecordState"]
                });
            }
            return coll;
        }
    }
}
