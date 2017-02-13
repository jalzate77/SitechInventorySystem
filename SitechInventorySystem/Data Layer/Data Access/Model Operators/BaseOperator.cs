using SitechInventorySystem.Data_Layer.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitechInventorySystem.Data_Layer.Data_Access.Model_Operators
{
    public class BaseOperator
    {
        protected Dictionary<string, object> Values { get; set; }
        protected Dictionary<string, object> Conditions { get; set; }
        protected string TableName { get; private set; }

        private SqlConnection con;
        private Guid id;
        private readonly string selectTemplate = @"select * from {tablename}";
        private readonly string insertTemplate = @"insert into {tablename} output inserted.id values(NewID(){paramters},1)";
        private readonly string updateTemplate = @"update {tablename} set {updatevalues} where {conditions};";
        private readonly string deleteTemplate = @"delete from {tablename} where {conditions};";
        private StringBuilder tempStr;
        private int affectedRows;

        public BaseOperator(string TableName)
        {
            this.TableName = TableName;
            ResetOperator();
            Values = new Dictionary<string, object>();
            Conditions = new Dictionary<string, object>();
        }

        protected Guid Create()
        {
            if (Values == null || Values.Count == 0)
                return Guid.Empty;

            ResetOperator();
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = con;
                cmd.CommandText = insertTemplate.Replace("{tablename}", TableName);
                foreach (var item in Values)
                {
                    tempStr.Append(",@" + item.Key);
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }
                cmd.CommandText = cmd.CommandText.Replace("{paramters}", tempStr.ToString());
                con.Open();
                id = (Guid)cmd.ExecuteScalar();
                con.Close();
            }

            ResetParamters();
            return id;
        }

        protected int Update()
        {
            if (Values == null || Values.Count == 0)
                return -1;
            if (Conditions == null || Conditions.Count == 0)
                return -1;

            ResetOperator();
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = con;
                cmd.CommandText = updateTemplate.Replace("{tablename}", TableName);
                foreach (var item in Values)
                {
                    tempStr.Append(item.Key + " = @" + item.Key + ",");
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }
                cmd.CommandText = cmd.CommandText.Replace("{updatevalues}", tempStr.ToString().TrimEnd(','));
                tempStr.Clear();
                foreach (var item in Conditions)
                {
                    tempStr.Append(item.Key + " = @" + item.Key + ",");
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }
                cmd.CommandText = cmd.CommandText.Replace("{conditions}", tempStr.ToString().TrimEnd(','));
                con.Open();
                affectedRows = cmd.ExecuteNonQuery();
                con.Close();
            }

            ResetParamters();
            return affectedRows;
        }

        protected int Delete()
        {
            ResetOperator();
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = con;
                cmd.CommandText = deleteTemplate.Replace("{tablename}", TableName);
                foreach (var item in Conditions)
                {
                    tempStr.Append(item.Key + " = @" + item.Key + ",");
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }
                cmd.CommandText = cmd.CommandText.Replace("{conditions}", tempStr.ToString().TrimEnd(','));
                con.Open();
                affectedRows = cmd.ExecuteNonQuery();
                con.Close();
            }

            ResetParamters();
            return affectedRows;
        }

        protected Dictionary<string, object> Read()
        {
            ResetOperator();
            var values = new  Dictionary < string, object> ();
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = con;
                cmd.CommandText = selectTemplate.Replace("{tablename}", TableName);
                con.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read())
                    values = Enumerable.Range(0, reader.FieldCount).ToDictionary(reader.GetName, reader.GetValue);
                con.Close();
            }

            return values;
        }

        private void ResetOperator()
        {
            id = Guid.Empty;
            if (tempStr == null)
                tempStr = new StringBuilder();
            tempStr.Clear();

            if (con == null)
                con = new SqlConnection(Database.ConnectionString);
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }

        private void ResetParamters()
        {
            Values.Clear();
            Conditions.Clear();
        }
    }
}
