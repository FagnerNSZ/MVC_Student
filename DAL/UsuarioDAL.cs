using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DAL
{
    public class UsuarioDAL
    {
        public UsuarioDAL() { }


        public int UserId { get; set; }
        public String UserName { get; set; }
        public String UserPass { get; set; }


        public static void InsertUser(String UserName, String UserPass)
        {

            try
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = Banco.abrir();

                ///insert into usuario(nm_usuario, pass_usuario ) values('kali','123456')
                //comm.CommandText = "insert into usuario values ('" + txtNome.Text + "'," + txtCarga.Text + ")";
                //comm.CommandText = "select @@identity";
                comm.CommandText = @"insert into usuario(nm_usuario, pass_usuario ) values('kali','123456')";
                comm.ExecuteNonQuery();//grava registros na tabela
                                       //comm.CommandText = "select @@identity";
                                       //txtID.Text = comm.ExecuteScalar().ToString();
                comm.Connection.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
