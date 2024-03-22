using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selfassessment;

namespace Teleassessment
{
    internal class DegProgCRUD
    {
        public static string connectionstring = "Server=DESKTOP-Q5NL4LD\\SQLEXPRESS;Database=UAMS;Trusted_Connection = True";

        public static List<DegProg> ListOfDeg = new List<DegProg>();
        public static DegProg ReturnDeg(int indexD)
        {
            return ListOfDeg[indexD];
        }
      

        public static List<Subject> GetAllSubjects(int DegID)
        {
            string query = string.Format("SELECT * FROM DegSubjects WHERE " + "DegID={0}", DegID);
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<Subject> subjectsRegistered = new List<Subject>();
            while (reader.Read())
            {

                Subject s = new Subject(
                    Convert.ToString(reader["SubType"]),
                   Convert.ToInt32(reader["CreditHours"]),
                     Convert.ToInt32(reader["SubjectFee"])

                   );
                s.DegID = Convert.ToInt32(reader["DegID"]);
                s.subcode = Convert.ToInt32(reader["SubjectCode"]);
                subjectsRegistered.Add(s);
            }
            connection.Close();
            return subjectsRegistered;
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
        public static bool AddSubject(Subject s,int DegID)
        {
            string query = string.Format("INSERT INTO DegSubjects(SubType,CreditHours,SubjectFee,DegID)  VALUES('{0}',{1},{2},{3})", s.subtype, s.credithours, s.generatefees,DegID);
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    return true;
                }
                return false;
            }

        }

        public static void SubjectsForDeg(int SubNo, int DegID)
        {
            bool ISSubjectAdded = false;
            for (int i = 0; i < SubNo; i++)
            {

                Subject s = SubjectUI.Inputsubject();
                ISSubjectAdded =AddSubject(s, DegID);
                if (ISSubjectAdded)
                {
                    continue;
                }
                else 
                {
                    Console.WriteLine("Subject not added ");
                }

            }
        }
        public static List<DegProg> GetAlldegrees()
        {

            string query = string.Format("SELECT * FROM DegreePrograms");
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<DegProg> AllDegrees = new List<DegProg>();
            while (reader.Read())
            {
                DegProg d = new DegProg(
                    Convert.ToString(reader["DegTitle"]),
                      Convert.ToInt32(reader["DegDuration"]),

                      Convert.ToInt32(reader["DegSeats"]),
                Convert.ToDouble(reader["degMerit"]));
                d.DegID = Convert.ToInt32(reader["degID"]);

                AllDegrees.Add(d);
            }
            connection.Close();
            return AllDegrees;
        }

        public static DegProg AddDegree(DegProg s)
        {
            string query = string.Format("INSERT INTO DegreePrograms(DegTitle,DegDuration,DegSeats,degMerit)  VALUES('{0}',{1},{2},{3})", s.Degtitle, s.Durationdeg, s.Seats, s.Merit);
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
    public static DegProg GetDegree(int Id)
        {
            string query = string.Format("SELECT * from DegreePrograms where " + "DegID={0}", Id);
            SqlConnection connection2 = new SqlConnection(connectionstring);
            connection2.Open();

            SqlCommand Command = new SqlCommand(query, connection2);
            SqlDataReader reader = Command.ExecuteReader();
            reader.Read();
            DegProg s = new DegProg(
                   Convert.ToString(reader["DegTitle"]),
                   Convert.ToInt32(reader["DegDuration"]),
                Convert.ToInt32(reader["DegSeats"]),
                  Convert.ToDouble(reader["degMerit"])
                   );
            s.DegID = Convert.ToInt32(reader["DegID"]);


            return s;
        }

        public static bool Updatedegree(DegProg d, int ID)  /// DOM usage
        {

            string query = string.Format("UPDATE DegreePrograms SET " + "DegTitle='{0}',DegDuration={1},DegSeats={2},degMerit={3} where " + "DegID={4}", d.Degtitle, d.Durationdeg, d.Seats, d.Merit, ID);

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
        public static bool DeleteDegree(int Id1)
        {
            string query = string.Format("DELETE FROM DegreePrograms where " + "DegID={0}", Id1);

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
    }
}
