﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Data;

namespace WindowsFormsApp1.Model
{    
    public class DBConnection : FormLogin
    {
        public static string permissaoUsuario;

        SqlConnection con = new SqlConnection();

        public bool DBConnect(string username, string password, out string permissao)
        {
            try
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CineGest.mdf;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "SELECT COUNT(*) FROM Login WHERE Utilizador = @username";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@username", username);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        sql = "SELECT Permissoes FROM Login WHERE Utilizador = @username";
                        cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@username", username);
                        permissao = cmd.ExecuteScalar()?.ToString();
                        permissaoUsuario = permissao;
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred: " + e.Message);
            }

            permissao = null;
            return false;
        }


    }
}


