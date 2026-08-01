using ScBank;

Cliente Elias = new Cliente();
Elias.imprimir();

Conta ContaDoJorge = new Conta("Jorge");
ContaDoJorge.Depositar(1000);
ContaDoJorge.Sacar(100);
ContaDoJorge.ImprimirExtrato();

ContaDoJorge.ImprimirTransacoes();