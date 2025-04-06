namespace ClassesHerança;
public abstract class Funcionario : Pessoa
{
    public decimal Salario { get; set; }
    public string Matricula { get; set; }
    
    // Construtor com parâmetros opcionais, chamando o construtor da classe base
    public Funcionario(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null, decimal salario = 0, string matricula = "")
        : base(nome, cpf, rg, logradouro)
    {
        Salario = salario;
        Matricula = matricula;
    }
}

//Eduardo da Silva Ramos