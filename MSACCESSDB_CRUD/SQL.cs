using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
namespace MSACCESSDB_CRUD
{
    class SQL
    {
        public string ID { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string gender { get; set; }
        public string dob { get; set; }
        public string status { get; set; }
        public ListView datas { get; set; }
        public ComboBox combo { get; set; }
        public RadioButton Male { get; set; }
        public RadioButton Female { get; set; }
        public void Save()
        {
            //open connection
            OleDbConnection conn = DBConnection.connection();
            if (conn.State == System.Data.ConnectionState.Closed) return;
            OleDbCommand cmd = conn.CreateCommand();
            //calling query
            String query = "INSERT INTO data(firstname,lastname,gender,status,dob)";
            query += "VALUES (?,?,?,?,?)";
            cmd.CommandText = query;
            //Assign parameter(Value)
            cmd.Parameters.AddWithValue("firstname",this.firstname);
            cmd.Parameters.AddWithValue("lastname",this.lastname);
            cmd.Parameters.AddWithValue("lastname", this.gender);
            cmd.Parameters.AddWithValue("status",this.status);
            cmd.Parameters.AddWithValue("dob",this.dob);
            //execute query
            cmd.ExecuteNonQuery();
            MessageBox.Show("New Data is Inserted");
            cmd.Dispose();
            conn.Close();
        }
        public void Delete()
        {
            //open connection
            OleDbConnection conn = DBConnection.connection();
            if (conn.State == System.Data.ConnectionState.Closed) return;
            OleDbCommand cmd = conn.CreateCommand();
            //calling query
            String query = "DELETE FROM data WHERE ID = ?";           
            cmd.CommandText = query;
            //Assign parameter(Value)
            cmd.Parameters.AddWithValue("ID", this.ID);
            //execute query
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been succesfully removed");
            cmd.Dispose();
            conn.Close();
        }
        public void Update()
        {
            //open connection
            OleDbConnection conn = DBConnection.connection();
            if (conn.State == System.Data.ConnectionState.Closed) return;
            OleDbCommand cmd = conn.CreateCommand();
            //calling query
            String query = "UPDATE data SET firstname = ?, lastname = ?, gender = ?,";
            query += "status=?,dob=? WHERE ID = ?";
            cmd.CommandText = query;
            //Assign parameter(Value)
            cmd.Parameters.AddWithValue("firstname", this.firstname);
            cmd.Parameters.AddWithValue("lastname", this.lastname);
            cmd.Parameters.AddWithValue("lastname", this.gender);
            cmd.Parameters.AddWithValue("status", this.status);
            cmd.Parameters.AddWithValue("dob", this.dob);
            cmd.Parameters.AddWithValue("ID", this.ID);
            //execute query
            cmd.ExecuteNonQuery();
            MessageBox.Show("Information succesfully updated");
            cmd.Dispose();
            conn.Close();
        }
        public void Retrieve()
        {
            //open connection
            OleDbConnection conn = DBConnection.connection();
            if (conn.State == System.Data.ConnectionState.Closed) return;
            OleDbCommand cmd = conn.CreateCommand();
            //calling query
            String query = "SELECT * FROM data";
            cmd.CommandText = query;
            OleDbDataReader reader = cmd.ExecuteReader();
            datas.Items.Clear();
            while (reader.Read())
            {
                ListViewItem row = new ListViewItem(reader["ID"].ToString());
                row.SubItems.Add(reader["lastname"].ToString());
                row.SubItems.Add(reader["firstname"].ToString());
                datas.Items.Add(row);
            }
            cmd.Dispose();
            reader.Dispose();
            conn.Dispose();
        }
        public void Combobox()
        {
            try
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                DataSet dataset = new DataSet();
                //open connection
                OleDbConnection conn = DBConnection.connection();
                if (conn.State == System.Data.ConnectionState.Closed) return;
                OleDbCommand cmd = conn.CreateCommand();
                //calling query
                String query = "SELECT * FROM status";
                cmd.CommandText = query;
                adapter.SelectCommand = cmd;
                adapter.Fill(dataset);
                cmd.Dispose();
                adapter.Dispose();
                conn.Close();
                combo.DataSource = dataset.Tables[0];
                combo.ValueMember = "ID";
                combo.DisplayMember = "stats";
                combo.SelectedIndex = -1;
            }
            catch (Exception er)
            {
                MessageBox.Show(""+er);
            }
        }
        public void lvSelection()
        {
            OleDbConnection conn = DBConnection.connection();
            if (conn.State == System.Data.ConnectionState.Closed) return;
            OleDbCommand cmd = conn.CreateCommand();
            //calling query
            String query = "SELECT * FROM data WHERE ID = ?";
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("ID",this.ID);
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                this.ID = reader["ID"].ToString();
                string rbGender = reader["gender"].ToString();
                this.firstname = reader["firstname"].ToString();
                this.lastname = reader["lastname"].ToString();
                if (rbGender == "Male")    Male.Checked = true;
                if (rbGender == "Female")  Female.Checked = true;                
                this.status = reader["status"].ToString();
                this.dob = reader["dob"].ToString();
            }
        }
        public void Search(String key)
        {
            OleDbConnection conn = DBConnection.connection();
            if (conn.State == System.Data.ConnectionState.Closed) return;
            OleDbCommand cmd = conn.CreateCommand();
            string query = "SELECT * FROM data WHERE firstname LIKE ? ";
            query += "OR lastname LIKE ? OR ID LIKE ? ";
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("firstname", key + "%");
            cmd.Parameters.AddWithValue("lastname", key + "%");
            cmd.Parameters.AddWithValue("ID", key + "%");
            OleDbDataReader reader = cmd.ExecuteReader();
            datas.Items.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ListViewItem row = new ListViewItem(reader["ID"].ToString());
                    row.SubItems.Add(reader["lastname"].ToString());
                    row.SubItems.Add(reader["firstname"].ToString());

                    datas.Items.Add(row);
                }
            }

        }
    }
}
