using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AdoDotNet
{
   public class Student
    {
        public SqlHelper _sqlHelper;
        public string sqlQuery;
        public Student()
        {
            _sqlHelper = new SqlHelper();
        }

        public void Getdata()
        {
            sqlQuery = "select * from [Table]";
            //sqlQuery = "select count(*) from [Table]";
            var sqlReader = _sqlHelper.ExecuteQuery(sqlQuery); //sql Reader is collection of rows(sequential)

            //if(sqlReader.Read())
            //{
            //    Console.WriteLine("\nNo. of Rows Present: {0}",sqlReader[0].ToString());
            //}
            while (sqlReader.Read())
            {
                Console.WriteLine(string.Format("\nRoll Number: {0} \nName: {1} \nMarks: {2} \nMobile Number: {3}", sqlReader[0].ToString(),
                    sqlReader[1].ToString(), sqlReader[2].ToString(), sqlReader[3].ToString()));
            }
            sqlReader.Close();             
        }


        public void GetdataScalar()
        {
            sqlQuery = "select count(*) from [Table]";
            var count = _sqlHelper.ExecuteScalar(sqlQuery);
            Console.WriteLine("\nNo. of Rows Present: {0}", count.ToString());
        }


        public void SaveData()
        {
            Console.WriteLine("Enter Roll No: ");
            string rn = Console.ReadLine();
            sqlQuery = string.Format(@"insert into [Table] values({0},'{1}', {2}, {3})",rn,"Sita",79,1245789632);
            
            if(_sqlHelper.ExecuteNonQuery(sqlQuery))
            {
                Console.WriteLine("Record Inserted..!");
            }
            else
            {
                Console.WriteLine("Error..!");
            }
        }


        public void getDataSet()
        {
            sqlQuery = "select * from [Table]";
            DataTable dt=_sqlHelper.GetDataSet(sqlQuery);
            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine(string.Format("\nRoll Number: {0} \nName: {1} \nMarks: {2} \nMobile Number: {3}",
                    dr[0].ToString(),dr[1].ToString(), dr[2].ToString(), dr[3].ToString()));
            }
            dt.WriteXml(@"C:\Users\munjewar_t\Documents\Visual Studio 2015\Projects\Test.xml"); // creates xml file of dataset
        }

        public void UpdateData()
        {
            _sqlHelper.Update(13, "Deeptesha");
            Console.WriteLine("Updated..!");
        }
    }
}
