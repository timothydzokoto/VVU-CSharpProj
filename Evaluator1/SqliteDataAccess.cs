using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluator1
{
    public class SqliteDataAccess
    {

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static void SaveUser(User user)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("insert into users (firstname, lastname, username, password) values (@FirstName, @LastName, @Username, @Password)", user);
            }
        }


        public static bool IsUser(string un, string ps)
        {
           
            using (var con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();
                string stm = "select * from users where username ='" + un + "' and password = '"  + ps + "'";

                var cmd = new SQLiteCommand(stm, con);
                string version = cmd.ExecuteScalar().ToString();

                SQLiteDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return true;
                }

                return false;

            }
        }

        public static void AddPupil(Pupil pupil)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("insert into pupils (sid, firstname, lastname, middlename, dob) values (@SId, @FirstName, @LastName, @MiddleName, @DOB)", pupil);
            }
        }

        public static List<Pupil> Allpupils()
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    var allPupils = con.Query<Pupil>("select * from pupils", new DynamicParameters());
                    return allPupils.ToList();
                }
                catch(NullReferenceException es)
                {

                }
                con.Close();
                return null;
            }
        }


        public static void DeletePupil(int pid)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                int v = con.Execute("delete from pupils where id = '" + pid + "'" );
                con.Close();
            }
        }

        public static void UpdatePupil(int pid, Pupil p)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                int v = con.Execute("update pupils set sid = @SId, firstname = @FirstName, lastname = @LastName, middlename = @MiddleName, dob = @DOB where id = '" + pid + "'", p);
                con.Close();

            }
        }

        public static void CreateSubject(string name)
        {
            

                using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
                {
                    con.Execute("CREATE TABLE IF NOT EXISTS " + name + " (id INTEGER NOT NULL, sid INTEGER NOT NULL UNIQUE, score1 REAL, score2 REAL, score3 REAL, score4 REAL, scorePercent REAL, exams REAL, examsPercent REAL, total REAL, PRIMARY KEY(id AUTOINCREMENT), FOREIGN KEY(sid) REFERENCES pupils(id) ON DELETE CASCADE ON UPDATE NO ACTION)");
                    con.Close();
                }

            
        }

        public static void DeleteSubject(string name)
        {
            
                using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
                {
                    con.Execute("drop table'" + name + "'");
                    con.Close();
                }
        }

        public static List<string> GetListTables()
        {
            List<string> tables = new List<string>();
            using (var con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();
                DataTable dt = con.GetSchema("Tables");
                foreach (DataRow row in dt.Rows)
                {
                    string tablename = (string)row[2];
                    tables.Add(tablename);
                }
                con.Close();
            }
            return tables;
        }

        public static List<string> GetListColumns(string table)
        {
            List<string> columns = new List<string>();
            
            using (var con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();

                SQLiteCommand command = new SQLiteCommand("PRAGMA table_info('"+ table + "')", con);
                
                DataTable dataTable = new DataTable();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                dataAdapter.Fill(dataTable);
                con.Close();
                foreach (DataRow row in dataTable.Rows)
                {
                    string tablename = (string)row[dataTable.Columns[1]];
                    
                    columns.Add(tablename);

                }
                return columns;
            }


        }

        public static Pupil GetPupil(int pid)
        {
            
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                object pup = con.Query<Pupil>("select * from pupils where id = '" + pid + "'", new DynamicParameters());
                con.Close();
                return (Pupil)pup;
            }

        }


        public static void UpdateRecord(ScoreModel sm)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                int v = con.Execute("update '" + sm.Subject + "' set '" + sm.ScoreType + "' = '" + sm.Score + "' where sid = '" + sm.Pid + "'");
                con.Close();
            }
        }
        public static void UpdateRecord(int id, string table, string fee, double amnt)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                int v = con.Execute("update '" + table + "' set '" + fee + "' = '" + amnt + "' where sid = '" + id + "'");
                con.Close();
            }
        }

        public static void InsertRecord(ScoreModel sm)
        {
            if(SidExit(sm.Pid, sm.Subject) == true)
            {
                UpdateRecord(sm);
            }
            else
            {
                using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
                {
                    con.Execute("insert into '" + sm.Subject + "' (sid, '" + sm.ScoreType + "') values (@Pid, @Score)", sm);
                    con.Close();
                }
            }
        }
        public static void InsertRecord(int id, string table, string fee, double amnt)
        {
            if (SidExit(id, table) == true)
            {
                UpdateRecord(id, table, fee, amnt);
            }
            else
            {
                using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
                {
                    con.Execute("insert into '" + table + "' (sid, '" + fee + "') values ('" + id + "', '" + amnt + "')");
                    con.Close();
                }
            }
        }

        private static bool SidExit(int pid, string tablename)
        {
            using (var con = new SQLiteConnection(LoadConnectionString()))
            {
                bool result = false;
                try
                {
                    con.Open();
                    string stm = "select * from '" + tablename + "' where sid = '" + pid + "'";

                    var cmd = new SQLiteCommand(stm, con);
                    string value = cmd.ExecuteScalar().ToString();

                    
                    if (value != null)
                    {
                        result = true;
                    }
                }
                catch(NullReferenceException ex)
                {
                    result = false;
                }
                finally
                {
                    con.Close();                   
                }
                return result;


            }
        }

        public static double GetRecord(int rid, string tablename, string scoreType)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                double  value = con.Execute("select '" + scoreType + "' from '" + tablename + "' where sid = '" + rid + "'", new DynamicParameters());
                con.Close();
                return value;
            }
        }

        public static void DeleteRecord(int rid, string tablename, string scoreType)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                int v = con.Execute("update '" + tablename + "' set '" + scoreType + "' = '" + null + "' where sid = '" + rid + "'");
                con.Close();
            }
        }


        // ReportForm codes

        public static void CalculateScore(string subject)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {

                con.Execute("update '" + subject + "' set score1 = 0  where score1 is NULL");
                con.Execute("update '" + subject + "' set score2 = 0  where score2 is NULL");
                con.Execute("update '" + subject + "' set score3 = 0  where score3 is NULL");
                con.Execute("update '" + subject + "' set score4 = 0  where score4 is NULL");
                con.Execute("update '" + subject + "' set exams = 0  where exams is NULL");
                con.Execute("update '" + subject + "' set scorePercent = (((score1 + score2 + score3 + score4) / 100) * 50)");
                con.Execute("UPDATE '" + subject + "' SET examspercent = ((exams / 100) * 50)");
                con.Execute("UPDATE '" + subject + "' SET total = (scorePercent + examspercent)");
                

                // Calculate the fees total.
                con.Execute("update fees set total = (tuition_fees + pta_fees + exams_fees + studies_fees)");



                con.Close();
            }
        }

        public static List<ScoreRecord> GetScoreRecords(string subject)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    var recors = con.Query<ScoreRecord>("select * from '" + subject + "'", new DynamicParameters());
                    return recors.ToList();
                }
                catch (NullReferenceException es)
                {

                }
                con.Close();
                return null;
            }
        }

        public static List<Finance> GetFinanceRecords(string subject = "fees")
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    var finances = con.Query<Finance>("select * from '" + subject + "'", new DynamicParameters());
                    return finances.ToList();
                }
                catch (NullReferenceException es)
                {

                }
                con.Close();
                return null;
            }
        }


        public static void AddFees(int sid, double tuition, double pta, double exams, double studies)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("insert into fees (sid, pta_fees, tuition_fees, exams_fees, studies_fees) values ('" + sid + "', '" + pta + "', '" + tuition + "', '" + exams + "', '" + studies + "')");
            }
        }
        public static void InitialDBStartUp()
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("CREATE TABLE IF NOT EXISTS fees (id INTEGER NOT NULL, sid INTEGER NOT NULL UNIQUE, pta_fees REAL, tuition_fees REAL, exams_fees REAL, studies_fees REAL, PRIMARY KEY(id AUTOINCREMENT), FOREIGN KEY(sid) REFERENCES pupils(id) ON DELETE CASCADE ON UPDATE NO ACTION)");
                con.Execute("CREATE TABLE IF NOT EXISTS pupils (id INTEGER NOT NULL, sid TEXT UNIQUE,firstname TEXT NOT NULL, lastname TEXT NOT NULL, middlename TEXT, image BLOB, dob TEXT, PRIMARY KEY(id AUTOINCREMENT))");
                con.Close();
            }
        }

        public static void UpdateFees(int sid, double tuition, double pta, double exams, double studies)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                int v = con.Execute("update fees set sid = '" + sid + "', pta_fees = '" + pta + "', tuition_fees = '" + tuition + "', exams_fees = '" + exams + "', studies_fees = '" + studies + "' where id = '" + sid + "'");
                con.Close();

            }
        }

        public static void DeleteFees(int pid)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                int v = con.Execute("delete from fees where sid = '" + pid + "'");
                con.Close();
            }
        }

        public static List<Payment> GetPayments()
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    var allPayments = con.Query<Payment>("select * from fees", new DynamicParameters());
                    return allPayments.ToList();
                }
                catch(NullReferenceException es)
                {

                }
                con.Close();
                return null;
            }
        }

        public static bool PaymentExist(int pid)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                int exist = con.Execute("select * from fees where id = '" + pid + "'");
                if(exist == 1 )
                {
                    return true;
                }

                return false;
            }
        }

        

    }
}
