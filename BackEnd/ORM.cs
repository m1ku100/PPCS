using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace BackEnd
{
    public class ORM
    {
        private Db db;
        private string table;
        private string pk;
        protected char c_prefix = '_'; // prefix untuk membedakan properti tertentu sebagai kolom

        public string table_
        {
            set { this.table = value; }
        }

        public string pk_
        {
            set { this.pk = value; }
        }

        private List<string> internProperties;

        public Dictionary<string, string> Properties;

        public ORM()
        {
            db = new Db();
            Properties = new Dictionary<string, string>();
            internProperties = new List<string>();
        }

        public int save(int id = 0)
        {
            bindProperties(this);

            if (this.Properties.Count > 0)
            {
                if (id != 0)
                {
                    this.Properties[this.pk] = id.ToString();
                }

                string update = string.Empty;

                foreach (string column in this.Properties.Keys)
                {
                    if (column != this.pk)
                        update += column + " =@" + column + " , ";
                }

                update = update.Trim();
                update = update.Substring(0, update.Length - 1);

                string sql = "UPDATE " + this.table + " SET " + update + " WHERE " + this.pk + "= @pk LIMIT 1";

                int pk_index_intern = this.internProperties.IndexOf(this.pk);

                this.internProperties.RemoveAt(pk_index_intern);
                this.internProperties.RemoveAt(pk_index_intern);

                this.internProperties.Add("@pk");
                this.internProperties.Add(this.Properties[this.pk]);

                return this.db.nQuery(sql, this.internProperties.ToArray());
            }

            return 0;
        }

        public int delete(int id = 0)
        {
            if (id > 0)
            {

                string sql = "DELETE FROM " + this.table + " WHERE " + this.pk + "= @pk LIMIT 1";
                return this.db.nQuery(sql, new string[] { "pk", id.ToString() });
            }

            return 0;
        }

        public int create()
        {
            if (this.Properties.Count == 0)
            {
                bindProperties(this);
            }

            if (this.Properties.Count > 0)
            {
                List<string> fields = this.Properties.Keys.ToList();
                List<string> fieldsvals = this.Properties.Values.ToList();

                int pk_index = fields.IndexOf(this.pk);
                int pk_index_intern = this.internProperties.IndexOf(this.pk);

                fields.RemoveAt(pk_index);
                fieldsvals.RemoveAt(pk_index);

                this.internProperties.RemoveAt(pk_index_intern);
                this.internProperties.RemoveAt(pk_index_intern);

                string sFields = String.Join(",", fields);

                for (int i = 0; i < fieldsvals.Count; i++)
                {
                    fields[i] = "@" + fields[i];
                }

                string sql = "INSERT INTO " + this.table + "(" + sFields + ")" + " VALUES(" + String.Join(",", fields) + ")";

                int result = this.db.nQuery(sql, this.internProperties.ToArray());

                this.Properties.Clear();
                this.internProperties.Clear();

                return result;
            }
            else
            {
                string sql = "INSERT INTO " + this.table + "()" + " VALUES()";
                return this.db.nQuery(sql);
            }
        }

        private void bindProperties(object o)
        {
            foreach (PropertyInfo pi in o.GetType().GetProperties())
            {
                if (pi.Name[0] == this.c_prefix) // prefix kolom table
                {
                    object property = pi.GetValue(o, null);
                    if (property != null)
                    {
                        this.Properties[pi.Name.Substring(1)] = property.ToString();

                        this.internProperties.Add(pi.Name.Substring(1));
                        this.internProperties.Add(property.ToString());
                    }
                }
            }
        }
    }
}
