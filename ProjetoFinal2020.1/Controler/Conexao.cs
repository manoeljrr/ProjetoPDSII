using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace ProjetoFinal2020._1.Model
{
    public class Conexao
    {
        NpgsqlConnection conexao = new NpgsqlConnection();
        public Conexao()
        {
            conexao.ConnectionString = "Username=obd_2018210129 ;Password = banco159;Host=labsql.fapce.edu.br;Port = 3024;Database = fap_2020_1";
        }
        public NpgsqlConnection conectar()
        {
            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }
            return conexao;
        }
        public void desconectar()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
