namespace projeto_conta;
class Conta
{
    public double Saldo {get;set;}    
    public double Limite {get;set;}
    public int Numero {get;set;}

    //get significa que vai acessar os valores deste atributo
    //set significa que vai setar algum valor neste atributo

    //Métodos são as ações dentro da classe

    //Método Deposita - recebe um valor e acrescenta 
    public void Deposita(double valor){
        //agora vamos pegar o valor que está vindo como um parâmetro do método e atribuí-lo ao atributo Saldo
        //o this, consegue acessar todos os atributos da classe e manipulá-los
       this.Saldo += valor; //incrementa o saldo em + valor
    }

    //Método ConsultaSaldo - retorna um saldo disponível
    public double ConsultaSaldo(){
        return this.Saldo + this.Limite;
    }

    




}
