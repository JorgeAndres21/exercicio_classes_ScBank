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

        public override void imprimir()
        {
            base.imprimir();
            Console.WriteLine("Endereço: " + End);
            Console.WriteLine("----------------\n");
        }
    }
}