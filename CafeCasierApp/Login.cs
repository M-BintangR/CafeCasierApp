using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace CafeCasierApp
{
    internal class Login
    {
        private string email;
        private string password;
        private readonly Koneksi koneksi;

        public Login(string email, string password)
        {
            this.email = email;
            this.password = password;
            this.koneksi = new Koneksi();
        }

        public bool VerifyLogin()
        {
            try
            {
                koneksi.openConnection();

                string query = "SELECT * FROM users WHERE email = @Email AND password = @Password";

                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string role = reader["role"].ToString() ?? "";

                            MessageBox.Show("Login Berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // ✅ Menampilkan form berdasarkan role
                            if (role == "admin")
                            {
                                new AdminPanelForm().Show();
                            }
                            else if (role == "kasir")
                            {
                                new KasirPanelForm().Show();
                            }

                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Email atau password salah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Terjadi kesalahan saat login: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error: {err.Message}");
                return false;
            }
            finally
            {
                koneksi.CloseConnection();
            }
        }
    }
}
