class Aluno
{
    public string Nome;

    public int Idade;

    public string Curso;
}

class program
{

    static void Main()
    {
        Aluno aluno1 = new Aluno();

        aluno1.Nome = "Carlos";
        aluno1.Idade = 18;
        aluno1.Curso = "Programador Full Stack";

        Console.WriteLine(aluno1.Nome);
        Console.WriteLine(aluno1.Idade);
        Console.WriteLine(aluno1.Curso);
    }
    
    
}

