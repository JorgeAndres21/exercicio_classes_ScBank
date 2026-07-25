namespace ScBank
{
    public class Transacao
    {
        public decimal Valor { get; set; }
        public string Tipo { get; set; }
        public DateTime Data { get; set; }

        public Transacao(decimal valor, string tipo)
        {
            Valor = valor;
            Tipo = tipo;
            Data = DateTime.Now;
        }

        public void imprimirTransacao()
        {
            Console.WriteLine($"Valor: {Valor} | Tipo: {Tipo} | Data: {Data}");
        }
    }
}