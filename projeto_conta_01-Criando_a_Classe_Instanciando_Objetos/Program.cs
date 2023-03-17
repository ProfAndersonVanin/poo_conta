namespace projeto_conta;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto Conta Bancária");

        //Aqui vamos instanciar um objeto chamado conta1 a partir da Classe Conta
        Conta conta1 = new Conta();

        //Aqui vamos através do objeto conta1, acessar os atributos da classe Conta e setar alguns valores iniciais para os atributos (usamos o set)
        conta1.Saldo = 1500;
        conta1.Limite = 500;
        conta1.Numero = 123;

        //Aqui buscamos a informação que está armazenada nos atributos (usamos o get)
        Console.WriteLine("Olá, fulano, seu saldo é de: " + conta1.Saldo);
        Console.WriteLine("Seu Limite de saque é de: " + conta1.Limite);
        Console.WriteLine("O número de sua conta é: " + conta1.Numero);

        //Agora faça você: Instancie um outro objeto chamado conta2, atribua um saldo, limite e número da conta. Mostre todas as informações da conta2 também.

    }
}
