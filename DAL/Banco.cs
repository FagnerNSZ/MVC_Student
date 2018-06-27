using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Banco
    {
        public static SqlConnection abrir()
        {
            
            /*<add name="Connection_Developer" connectionString="Data Source=SUZY_T\SQLEXPRESS;Initial Catalog=cartel_teste;Integrated Security=True" providerName="System.Data.SqlClient"/>*/
             
            string strcon = @"Data Source=SUZY_T\SQLEXPRESS;Initial Catalog=cartel_teste;Integrated Security=True";
            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();
            return cn;
        }
        //this test ok
        public static void Inserir()
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

    }
}
