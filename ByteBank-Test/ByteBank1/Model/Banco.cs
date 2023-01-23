namespace ByteBank1.Model {
    public class Banco {

        // atributo
        private static List<Conta> _contas;
        private static Conta? _contaLogada;
        public readonly string Agencia;

        public Banco(string agencia) {
            _contas = new List<Conta>();
            _contaLogada = null;
            Agencia = agencia;
        }

        // métodos
        public static void register() {
            // TODO apresentar menu de registro
            Console.WriteLine("Digite o CPF");
            string cpf = Console.ReadLine();

            Console.WriteLine("Digite o Senha");
            string senha = Console.ReadLine();

            long id = _contas.Count + 1;
            _contas.Add(new Conta(id, cpf, senha));
        }

        public static void login() {
            Console.WriteLine("Digite o CPF");
            string cpf = Console.ReadLine();
            int index = _contas.FindIndex(d => d.Cpf == cpf);
            Console.WriteLine(_contas[index]);
        }

        public static void logout() {

        }

    }
}
