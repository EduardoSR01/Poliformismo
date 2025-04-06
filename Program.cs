using ClassesHerança;
internal class Program
{
    private List<Pessoa> pessoas; // Criando uma variável de instância acessível pela Main

    public Program() // Construtor
    {
        pessoas = new List<Pessoa>(); // Inicializa a lista
        
        Curso auxCurso1 = new Curso {Nome = "Sistemas de Informação", Descricao = "Um curso, várias possibilidades", CargaHoraria = 1000};
        Curso auxCurso2 = new Curso("Educação Física", "Esportes e Anatomia", 2145);
        
        Aluno auxAluno1 = new Aluno("Eduardo da Silva Ramos", "54724689900", "4564564", new Endereco("Rua Johanesburgo", 37, "South Africa", "Lages", "Santa Catarina", "74162-209"), 123711, auxCurso1);
        Aluno auxAluno2 = new Aluno("João Bananeira", "45137890428", "1016561", new Endereco("Rua das Laranjas", 43, "Limoeiro", "Cajuzeiro", "Paraná", "12345-678"), 456041, auxCurso1);
        Aluno auxAluno3 = new Aluno("Neymar Junior", "47154267300", "7488740", new Endereco("Rua Barcelona", 11, "Madrillena", "Santos", "São Paulo", "12345-859"), 451931, auxCurso2);
        
        Endereco auxEnd = new Endereco("Rua da Calculadora", 314, "Pitágoras", "Derivadas", "Bhaskara", "31431-431");

        Professor auxProfessor1 = new Professor("Eduardo da Silva Ramos", "989989898900", "45655511", auxEnd, 3000, "101010" , "Mestre", "Tecnologia e Computação"); 
        Professor auxProfessor2 = new Professor("Cristiano Ronaldo", "77777777700", "10133345", new Endereco("Rua Aveiros", 777, "Madeira", "Lisboa", "Sporting", "77777-777"), 7000, "771177" , "Doutor", "Matemática");
        
        Coordenador auxCoor = new Coordenador("Eduardo da Silva Ramos", "88816168899", "7778889", new Endereco("Rua Talleres", 16, "Hincha del Norte", "Corinthians", "Colossal", "31313-313"), 16000, "161616", "AbcBolinhas");
        
        TecAdm auxTecAdm1 = new TecAdm("Eduardo da Silva Ramos", "94949494900", "1010101", new Endereco("Rua Amsterdam", 94, "Rotterdam", "Haia", "Holanda do Sul", "94949-123"), 94000, "949494", "Desenvolvedor");
        TecAdm auxTecAdm2 = new TecAdm("Yuri Alberto", "99999999977", "9997779", new Endereco("Rua Corinthians", 9, "Itaquera", "Gigantossauro", "Colossal", "99999-977"), 99000, "997799", "Proganista");
        
        // Adicionando à lista
        pessoas.Add(auxAluno1);
        pessoas.Add(auxAluno2);
        pessoas.Add(auxAluno3);
        pessoas.Add(auxProfessor1);
        pessoas.Add(auxProfessor2);
        pessoas.Add(auxCoor);
        pessoas.Add(auxTecAdm1);
        pessoas.Add(auxTecAdm2);
    }

    public static void Main(string[] args)
    {
        Program aplicacao = new Program(); // Instancia Program para acessar a lista
        bool faz = true;

        while (faz)
        {
            Console.Clear();
            Console.WriteLine("S. Sair\n1. Listar Pessoas");
            char n = char.Parse(Console.ReadLine()!.ToUpper());

            switch (n)
            {
                case 'S': 
                    faz = false; 
                    break;
                case '1': 
                    ListarPessoas(aplicacao.pessoas); // Passa a lista correta
                    break;
                default: 
                    Console.WriteLine("Opção inválida. Pressione Enter para continuar...");
                    Console.ReadLine(); 
                    break;
            } Console.ReadLine();
        }
    }


    private static void ListarPessoas(List<Pessoa> pessoas)
    {

        foreach (var item in pessoas)
        {
            Console.Write($"{item.GetType().Name} => ");
            foreach( var (campo, valor) in item.RetornarDados() ){
                Console.Write($"{campo}: {valor} \n");
            }
            Console.WriteLine("");
        }
    }

}


//Eduardo da Silva Ramos