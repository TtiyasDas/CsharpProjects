using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1.DataConnection
{
    public class StudentIDBConnection
    {
        string sqlConnectionStr = "Data Source = TIYAS; Initial Catalog = StudentDB; Integrated Security = True;";
        public string InsertStudent(StudentModel studentmodelObj) 
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("insert into Student values("+studentmodelObj.Roll+",'"+studentmodelObj.Name+"','"+studentmodelObj.Email+"',"+studentmodelObj.Age+")", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return "Student Details Saved Successfully";
        }
        public string UpdateStudent(StudentModel studentmodelObj)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("update Student set Name='" + studentmodelObj.Name + "', Email='" +studentmodelObj.Email+ "', Age=" + studentmodelObj.Age + " where Roll="+studentmodelObj.Roll+")", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return "Student Details Update Successfully";
       }
        public string DeleteStudentbyRoll(int Roll)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("delete from Student where Roll=" + studentmodelObj.Roll + "", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return "Roll" + Roll + " Details Deleted Successfully ";
        }
        public DataTable SelectStudent()
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("select * from Student", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dt;
        }
        public DataTable EditStudentbyRoll(int Roll)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("select * from Student where Roll="+Roll+"", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dt;
        }
    }

}