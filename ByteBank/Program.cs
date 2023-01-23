using Bytebank.Model;
using Bytebank.View;

namespace Bytebank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> cpfs = new List<string>();
            List<string> titulares = new List<string>();
            List<string> senhas = new List<string>();
            List<double> saldos = new List<double>();

            int option;
            TextoColorido.MudarCorTexto(ConsoleColor.Cyan, "Bem Vindo ao Byte Bank o mais rápido e seguro!");

            do
            {


                MenuView.ShowMenuLogin();
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        TextoColorido.MudarCorTexto(ConsoleColor.Red, "Programa Encerrado!");
                        break;
                    case 1:
                        RegistrarNovoUsuario.Registrar(cpfs, titulares, senhas, saldos);
                        break;
                    case 2:
                        Login.LoginNaConta(cpfs, titulares, senhas, saldos, option);
                        break;
                    case 3:
                        Conta.ListarTodasAsContas(cpfs, titulares, saldos);
                        break;
                }

            } while (option != 0);
        }
    }
}