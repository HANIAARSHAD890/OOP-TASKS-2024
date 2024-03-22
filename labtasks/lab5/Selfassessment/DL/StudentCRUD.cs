using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Teleassessment
{
    internal class StudentCRUD
    {
        public static string connectionstring = "Server=DESKTOP-Q5NL4LD\\SQLEXPRESS;Database=UAMS;Trusted_Connection = True";

        public static List<Student> ListofStudents = new List<Student>();
        public static void displayStudents()
        {
            for (int x = 0; x < ListofStudents.Count; x++)
            {
                Console.WriteLine($"student no{x}: {ListofStudents[x].Name}");
            }
        }
        public static Student AddStudent(Student s)
        {

            string query = string.Format("INSERT INTO Student(Name,Age,FSCMarks,ECATMarks)  VALUES('{0}',{1},{2},{3})", s.Name, s.Age, s.Fscmarks, s.Ecatmarks);
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    return s;
                }
                return null;
            }

        }
        public static Student ReturnStudent(int index)
        {
            return ListofStudents[index];
        }
        public static void DisplayStudents()
        {
            for (int x = 0; x < ListofStudents.Count; x++)
            {
                Console.WriteLine($"Student no {x}: {ListofStudents[x].Name}\t\t\t\t{ListofStudents[x].Ecatmarks}\t\t\t\t{ListofStudents[x].Fscmarks}\t\t\t\t{ListofStudents[x].Fscmarks}");
            }

        }
        public static void DisplayMerit()
        {
            for (int x = 0; x < ListofStudents.Count; x++)
            {
                Console.WriteLine($"{ListofStudents[x].Name}\t\t\t\t{ListofStudents[x].MeritCal()}");
            }

        }
        public static void AdmissionList()
        {
            for (int x = 0; x < ListofStudents.Count; x++)
            {
                Console.WriteLine($"{ListofStudents[x].Name}\t\t\t\t{ListofStudents[x].Admissioned()}");
            }

        }
        public static void DisplayFee()
        {
            for (int i = 0; i < ListofStudents.Count; i++)
            {
                Console.WriteLine($"{ListofStudents[i].Name}\t\t\t\t{ListofStudents[i].CalculateFee(ListofStudents[i].registerDegree)}");
            }
        }
        public static List<Student> GetAllStudents()
        {
            List<Student> StudentList = new List<Student>();

            string query = "SELECT * from Student";

            SqlConnection connection1 = new SqlConnection(connectionstring);
            connection1.Open();

            SqlCommand Command = new SqlCommand(query, connection1);
            SqlDataReader reader = Command.ExecuteReader();
            while (reader.Read())
            {
                Student s = new Student(
                        Convert.ToString(reader["Name"]),
                        Convert.ToInt32(reader["Age"]),
                     Convert.ToDouble(reader["FSCMarks"]),
                       Convert.ToDouble(reader["ECATMarks"])
                        );
                s.ID = Convert.ToInt32(reader["ID"]);

                StudentList.Add(s);

            }
            connection1.Close();
            return StudentList;
         

        }
        public static Student GetStudent(int ID)
        {

            string query = string.Format("SELECT * from Student where " + "ID={0}",ID);

            SqlConnection connection2 = new SqlConnection(connectionstring);
            connection2.Open();

            SqlCommand Command = new SqlCommand(query, connection2);
            SqlDataReader reader = Command.ExecuteReader();
            reader.Read();/// for the poiter to come down
                Student s = new Student(
                   Convert.ToString(reader["Name"]),
                   Convert.ToInt32(reader["Age"]),
                Convert.ToDouble(reader["FSCMarks"]),
                  Convert.ToDouble(reader["ECATMarks"])
                   );
                s.ID = Convert.ToInt32(reader["ID"]);

                return s;
            
        
        }
        public static bool  UpdateStudent(Student s)  /// DOM usage
        {
        
            string query = string.Format("UPDATE Student SET " + "Name='{0}',FSCMarks={1},ECATMarks={2} where "+ "ID={3}",s.Name, s.Fscmarks,s.Ecatmarks,s.ID);

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand Command = new SqlCommand(query, connection);
                connection.Open();
                int RowsAffected= Command.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    return true;
                }
                return false;
            }
        }
        public static bool DeleteStudent(int ID)
        {

            string query = string.Format("DELETE FROM STUDENT where " + "ID={0}", ID);

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand Command = new SqlCommand(query, connection);
                connection.Open();
                int RowsAffected = Command.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    return true;
                }
                return false;
            }




        }
        public static void DisplayStudentInfo(Student s)
        {
            Console.WriteLine(string.Format("Student ID: {0}", s.ID));
            Console.WriteLine(string.Format("Student Name: {0}", s.Name));
            Console.WriteLine(string.Format("Student FSC: {0}", s.Fscmarks));
            Console.WriteLine(string.Format("Student ECAT: {0}", s.Ecatmarks));
            Console.WriteLine(string.Format("Student Age: {0}", s.Age));
        }
        public static void DisplayAllStudentInfo(List<Student>Students)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                DisplayStudentInfo(Students[i]);
            } 
        }
       

    }
}
