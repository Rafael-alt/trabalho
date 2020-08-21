using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace Sistema_Vendas_2C
{
    class Cl_banco
    {
        public static OleDbConnection conexão = new OleDbConnection();
        public static String endereço_do_banco = @"Banco.accdb";
        public static String conecta = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + endereço_do_banco;

    }
}
