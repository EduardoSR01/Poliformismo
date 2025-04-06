namespace ClassesHerança;
public class Curso : Object // herança, Object é a classe base de todas as classes
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int CargaHoraria { get; set; }
    
    // construtor com parâmetros opcionais
    public Curso(string nome = "", string descricao = "", int cargaHoraria = 0)
    {
        Nome = nome;
        Descricao = descricao;
        CargaHoraria = cargaHoraria;
    }
    
    // aplicando polimorfismo, sobrescrevendo o método ToString() de Object
    public override string ToString()
    {
        return $" {Nome}, {CargaHoraria}";
    }
}

//Eduardo da Silva Ramos