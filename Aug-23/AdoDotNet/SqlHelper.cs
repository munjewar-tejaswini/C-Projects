using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AdoDotNet
{
  public class SqlHelper
    {
        private SqlConnection _sqlConnection;
        private SqlCommand _sqlCommand;
        public string sqlQuery = null;
        public SqlDataAdapter _sqlDataAdapter;


        public string connectionString = @"Data Source=.;Initial Catalog=DemoStudent;Integrated Security=True;Pooling=False"; //database properties -> Connection String

        public SqlHelper()
        {
            _sqlConnection = new SqlConnection(connectionString); //Allocation memory to _sqlConnection
            //to check wteather the connection is open or not
            if (_sqlConnection.State == System.Data.ConnectionState.Closed)
            _sqlConnection.Open();  //used to open the connection
            Console.WriteLine("Connection is Open");
        }

        public SqlDataReader ExecuteQuery(string sqlQuery)
        {
            _sqlCommand = new SqlCommand(sqlQuery, _sqlConnection); //alternative for below commands
            //_sqlCommand.CommandText = sqlQuery;
            //_sqlCommand.Connection = _sqlConnection; //set relation bet collection and command
            return _sqlCommand.ExecuteReader();
        }

        public string ExecuteScalar(string sqlQuery)
        {
            _sqlCommand = new SqlCommand(sqlQuery, _sqlConnection); 
            return _sqlCommand.ExecuteScalar().ToString();
        }

        //no. of rows affected by whatever DML operation we are performing
        public bool ExecuteNonQuery(string sql)
        {
            var result = false;
            _sqlCommand = new SqlCommand(sql, _sqlConnection);
            var count = _sqlCommand.ExecuteNonQuery();
            return result;
        }

        //using this we are creating local copy of data
        //public DataSet GetDataSet(string sqlQuery) //dataset is a collection of Tables
        //{
        //    var ds = new DataSet();
        //    _sqlDataAdapter = new SqlDataAdapter(sqlQuery, connectionString);
        //    _sqlDataAdapter.Fill(ds, "student");
        //    return ds;
        //}

        public DataTable GetDataSet(string sqlQuery)
        {
            var ds = new DataSet();
            _sqlDataAdapter = new SqlDataAdapter(sqlQuery, connectionString);
            _sqlDataAdapter.Fill(ds, "student");
            return ds.Tables[0];
        }

        public void Update(int rno, string sname)
        {
            var ds = new DataSet();
            sqlQuery = "select * from [Table]";
            _sqlDataAdapter = new SqlDataAdapter(sqlQuery, connectionString);
            SqlCommandBuilder sb = new SqlCommandBuilder(_sqlDataAdapter);
            _sqlDataAdapter.Fill(ds, "student");
            DataTable dt = ds.Tables[0];
            dt.Rows[0][0] = rno;
            dt.Rows[0][1] = sname;
          
            _sqlDataAdapter.Update(dt);

        }
     
    }
}
