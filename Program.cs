using ScBank;

Cliente cliente1 = new Cliente();
cliente1.imprimir();

Funcionario func1 = new Funcionario();
func1.imprimir();

Conta ContaDoJorge = new Conta(cliente1);
ContaDoJorge.Depositar(1000);
ContaDoJorge.Sacar(100);
ContaDoJorge.ImprimirExtrato();

ContaDoJorge.ImprimirTransacoes();