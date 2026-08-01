namespace ScBank
{
    public class Cliente : Pessoa
    {
        public string End { get; set; }

        public Cliente()
        {
            Preencher();
        }

        public override void Preencher()
        {
            base.Preencher();
            Console.Write("Digite seu Endereço: ");
            End = Console.ReadLine();
        }

        public void imprimir()
        {
            Console.WriteLine("\n----------------");
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Telefone: " + Tel);
            Console.WriteLine("Endereço: " + End);
            Console.WriteLine("CPF: " + Cpf);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("----------------\n");
        }
    }
}