using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using _5951071068_NguyenNhan_Buoi2.Models;
using static _5951071068_NguyenNhan_Buoi2.Models.Student;

namespace _5951071068_NguyenNhan_Buoi2.Controllers
{
    public class StudentController : ApiController
    {
        private SqlConnection _conn;
        private SqlDataAdapter adapter;
        // GET api/<controller>
        public IEnumerable<Student> Get()
        {
            _conn = new SqlConnection("Data Source=.;Initial Catalog=Nawab;Integrated Security=True");
            DataTable tb = new DataTable();
            var query = "SELECT * FROM Student";
            adapter = new SqlDataAdapter
            {
                SelectCommand = new SqlCommand(query, _conn)
            };
            adapter.Fill(tb);
            List<Student> students = new List<Models.Student>(tb.Rows.Count);
            if (tb.Rows.Count > 0)
            {
                foreach (DataRow studentRecord in tb.Rows)
                {
                    students.Add(new ReadStudent(studentRecord));
                }
            }


            return students;
        }

        // GET api/<controller>/5
        public IEnumerable<Student> Get(int id)
        {
            _conn = new SqlConnection("Data Source=.;Initial Catalog=Nawab;Integrated Security=True");
            DataTable tb = new DataTable();
            var query = "SELECT * FROM Student where id=" + id;
            adapter = new SqlDataAdapter
            {
                SelectCommand = new SqlCommand(query, _conn)
            };
            adapter.Fill(tb);
            List<Student> students = new List<Models.Student>(tb.Rows.Count);
            if (tb.Rows.Count > 0)
            {
                foreach (DataRow studentRecord in tb.Rows)
                {
                    students.Add(new ReadStudent(studentRecord));
                }
            }


            return students;
        }

        // POST api/<controller>
        public string Post([FromBody] CreateStudent value)
        {
            _conn = new SqlConnection("Data Source=.;Initial Catalog=Nawab;Integrated Security=True");
            var query = "INSERT INTO Student(f_name,m_name,l_name,address,birthDate, score) values(@f_name,@m_name,@l_name,@address,@birthDate,@score)";
            SqlCommand insertCommand = new SqlCommand(query, _conn);
            insertCommand.Parameters.AddWithValue("@f_name", value.f_name);
            insertCommand.Parameters.AddWithValue("@m_name", value.m_name);
            insertCommand.Parameters.AddWithValue("@l_name", value.l_name);
            insertCommand.Parameters.AddWithValue("@address", value.address);
            insertCommand.Parameters.AddWithValue("@birthDate", value.birthDate);
            insertCommand.Parameters.AddWithValue("@score", value.score);

            _conn.Open();
            int result = insertCommand.ExecuteNonQuery();
            if (result > 0)
            {
                return "Them thanh cong";
            }
            else
            {
                return "Them that bai";
            }


        }

        // PUT api/<controller>/5
        public string Put(int id, [FromBody] CreateStudent value)
        {
            _conn = new SqlConnection("Data Source=.;Initial Catalog=Nawab;Integrated Security=True");
            var query = "update Student set f_name=@f_name,m_name=@m_name,l_name=@l_name,address=@address,birthDate=@birthDate, score=@score where id= " + id;
            SqlCommand insertCommand = new SqlCommand(query, _conn);
            insertCommand.Parameters.AddWithValue("@f_name", value.f_name);
            insertCommand.Parameters.AddWithValue("@m_name", value.m_name);
            insertCommand.Parameters.AddWithValue("@l_name", value.l_name);
            insertCommand.Parameters.AddWithValue("@address", value.address);
            insertCommand.Parameters.AddWithValue("@birthDate", value.birthDate);
            insertCommand.Parameters.AddWithValue("@score", value.score);

            _conn.Open();
            int result = insertCommand.ExecuteNonQuery();
            if (result > 0)
            {
                return "Cap nhat thanh cong";
            }
            else
            {
                return "Cap nhat that bai";
            }
        }

        // DELETE api/<controller>/5
        public string Delete(int id)
        {
            _conn = new SqlConnection("Data Source=.;Initial Catalog=Nawab;Integrated Security=True");
            var query = "delete from Student where id= " + id;
            SqlCommand insertCommand = new SqlCommand(query, _conn);


            _conn.Open();
            int result = insertCommand.ExecuteNonQuery();
            if (result > 0)
            {
                return "Xoa thanh cong";
            }
            else
            {
                return "Xoa that bai";
            }
        }
    }
}