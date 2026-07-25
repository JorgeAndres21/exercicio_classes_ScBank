using Microsoft.VisualBasic;

namespace ScBank
{
    public class Conta
    {
        public Conta(string titular)
        {
            Titular = titular;
            NumeroConta = new Random().Next();
        }

        public string Titular { get; set; }
        public int NumeroConta { get; set; }
        private decimal Saldo;
        private List<Transacao> Transacoes = new List<Transacao>();

        public void Depositar(decimal valor)
        {
            Saldo += valor;
            Transacoes.Add(new Transacao(valor, "Deposito"));
        }
        public void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente.");
            }
            else
            {
                Saldo -= valor;
                Transacoes.Add(new Transacao(valor * -1, "Saque"));
            }
        }
        public decimal ObterSaldo()
        {
            return Saldo;
        }
        public void ImprimirTransacoes()
        {
            Console.WriteLine("Transações:");
            foreach (var tran in Transacoes)
            {
                tran.imprimirTransacao();
            }
        }
        public void ImprimirExtrato()
        {
            Console.WriteLine("==================");
            Console.WriteLine($"Titular da conta: {Titular}");
            Console.WriteLine($"Numero da conta: {NumeroConta}");
            Console.WriteLine($"Saldo: {Saldo}");
            Console.WriteLine("==================");
        }
    }
}