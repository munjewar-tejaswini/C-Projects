using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace AdoDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student _student = new Student(); //Or var _student=new Student();
                //_student.Getdata();
                //_student.GetdataScalar();
                //_student.SaveData();
                //_student.getDataSet();
                _student.UpdateData();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception Cought: {0}", e.Message);
            }
            Console.ReadLine();
        }
    }
}
