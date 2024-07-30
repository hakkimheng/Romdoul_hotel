using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel
{
    class function
    {
        protected NpgsqlConnection GetConnection()
        {
            NpgsqlConnection con = new NpgsqlConnection();
            con.ConnectionString = "Host=localhost;Port=5432;Database=hotel;Username=postgres;Password=Hakkimheng!@#168;";
            return con;
        }

        public DataSet getData(string query)
        {
            NpgsqlConnection conn = GetConnection();
            conn.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            return ds;
        }

        public void setData(string query)
        {
            NpgsqlConnection con = GetConnection();
            con.Open();
            NpgsqlTransaction transaction = con.BeginTransaction(); // Start transaction

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(query, con, transaction);
                cmd.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                // Rollback transaction on error
                transaction.Rollback();
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public bool IsRoomFree(string roomNumber)
        {
            bool isFree = false;
            string query = "SELECT COUNT(*) FROM Room WHERE \"Room\" = @roomNumber AND \"status\" = 'OCCUPIED'";

            using (NpgsqlConnection con = GetConnection())
            {
                try
                {
                    con.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@roomNumber", roomNumber);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        isFree = count > 0;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            return isFree;
        }

        public bool ComparePhoneAndRoom(string compareRoom, string comparePhone)
        {
            bool isEqual = false;
            string query = "SELECT \"Room\", \"Phone\" FROM Room WHERE \"Room\" = @compareRoom AND \"Phone\" = @comparePhone AND \"status\" = 'OCCUPIED'";
            NpgsqlConnection con = GetConnection();
            try
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                cmd.Parameters.AddWithValue("@compareRoom", compareRoom);
                cmd.Parameters.AddWithValue("@comparePhone", comparePhone);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isEqual = true; 
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return isEqual;
        }

        public bool Login(string username, string password)
        {
            bool isValid = false;
            string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";

            using (NpgsqlConnection con = GetConnection())
            {
                try
                {
                    con.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        // Execute the query and get the result
                        int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                        // If userCount is greater than 0, the login is successful
                        isValid = userCount > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            return isValid;
        }

        public void CheckOut(string roomNumber, string phoneNumber)
        {
            string query = "UPDATE Room SET \"status\" = 'AVAILABLE' WHERE \"Room\" = @roomNumber AND \"Phone\" = @phoneNumber ";

            NpgsqlConnection con = GetConnection();
            con.Open();
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                cmd.Parameters.AddWithValue("@roomNumber", roomNumber);
                cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                int rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void ShowDataInLabels(string roomNumber, Label label1, Label label2, Label label3, Label label4, Label label5, Label label6)
        {
            string query = "SELECT * FROM Room WHERE \"Room\" = @roomNumber AND \"status\" = 'OCCUPIED'";

            NpgsqlConnection con = GetConnection();
            try
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@roomNumber", roomNumber);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        label1.Text = reader["First Name"].ToString(); 
                        label2.Text = reader["Last Name"].ToString();
                        label3.Text = reader["Room"].ToString();
                        label4.Text = reader["Phone"].ToString();
                        label5.Text = reader["Check In"].ToString();
                        label6.Text = reader["Check Out"].ToString();
                        
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}