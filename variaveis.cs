using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kibelezaTi16Joyce
{
    public static class variaveis
    {
        //Geral
        public static string funcao;
        public static int linhaSelecionada;

        //Login
        public static string usuario, senha, nivel;

        //Empresa
        public static int codEmpresa;
        public static string nomeEmpresa, cnpjCpfEmpresa, razaoSocialEmpresa, emailEmpresa, statusEmpresa;
        public static DateTime dataCadEmpresa, horarioAtendEmpresa;

        //Fone empresa
        public static int codFoneEmpresa;
        public static string numeroFoneEmpresa, operadoraEmpresa, descricaoEmpresa;

        //Cliente
        public static int codCliente;
        public static string nomeCliente, emailCliente, senhaCliente, statusCliente, fotoCliente, atFotoCliente, caminhoFotoCliente;
        public static DateTime dataCadCliente;

        //FONE CLIENTE
        public static int codFoneCliente;
        public static string numeroFoneCliente, operadoraCliente, descricaoCliente;

        //FOTOS FTP
        public static string enderecoServidorFtp = "ftp://127.0.0.1/admin/";
        public static string usuarioFto = "ti16";
        public static string senhaFtp = "1234";
    }
}
