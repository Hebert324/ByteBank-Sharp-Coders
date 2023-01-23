using ByteBank1.Model;
using ByteBank1.View;

namespace ByteBank1 {

    public class Program {

        public static void Main(string[] args) {

            List<Conta> contas = new List<Conta>();
            Console.WriteLine("testing");

            int option;

            do
            {
                MenuView.ShowMenu();
                option = int.Parse(Console.ReadLine());
                switch (option) 
                {
                    case 0:
                        Console.WriteLine("Saiu do Programa");
                        break;
                    case 1:
                        Banco.register();
                        break;
                    case 2:
                        Banco.login();
                        break;
                }
            } while (option != 0);

            //MenuView.ShowMenu();
        }

    }

}