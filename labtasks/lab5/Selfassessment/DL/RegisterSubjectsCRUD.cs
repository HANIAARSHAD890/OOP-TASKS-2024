using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Teleassessment;


namespace Selfassessment
{
    internal class RegisterSubjectsCRUD
    {
        public static string connectionstring = "Server=DESKTOP-Q5NL4LD\\SQLEXPRESS;Database=UAMS;Trusted_Connection = True";
        private static object subtype;

        public static List<Subject> GetAllSubjects(int StudentID)
        {
            string query = string.Format("SELECT * FROM RegisterSubjects WHERE " + "StudentID={0}", StudentID);
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query,connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            List<Subject> subjectsRegistered = new List<Subject>();
            while (reader.Read()) 
            {
                Subject s  = new Subject(
                    Convert.ToString(reader["Subjecttitle"]));
                s.subcode = Convert.ToInt32(reader["ID"]);
                subjectsRegistered.Add(s);
            }
            connection.Close();
            return subjectsRegistered;
        }
        public static bool RegisterSubject(Subject s, int ID)
        {
            string query = string.Format("INSERT INTO RegisterSubjects(Subjecttitle,StudentID) VALUES('{0}',{1})",s.subtype,ID);
            using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    int RowsAffected = command.ExecuteNonQuery();
                    if (ConsoleUtilityUI.IsRowAffected(RowsAffected))
                    {
                        return true;
                    }

                return false;
               }
        }
         
        public static void RegisterAllSubjects(int SubNo,int ID)
        {
            bool ISSubjectRegister=false;
            for (int i = 0; i < SubNo; i++)
            {

                Subject s = SubjectUI.TakeInputForSubjectSQL();
                ISSubjectRegister= RegisterSubject(s,ID);
                if (ISSubjectRegister)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Subject NOT Registered");
                }
            }
        }
   
    }
   
}
