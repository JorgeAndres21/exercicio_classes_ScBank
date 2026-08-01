namespace ScBank
{
    public class Funcionario : Pessoa
    {
        public string Funcao { get; set; }
        public int NumeroMatricula { get; set; }

        public Funcionario()
        {
            Preencher();
            NumeroMatricula = new Random().Next();
        }

        public override void Preencher()
        {
            base.Preencher();
            Console.Write("Digite a função: ");
            Funcao = Console.ReadLine();
        }
        public override void imprimir()
        {
            base.imprimir();
            Console.WriteLine("Função: " + Funcao);
            Console.WriteLine("Matricula: " + NumeroMatricula);
            Console.WriteLine("----------------\n");
        }
    }
}