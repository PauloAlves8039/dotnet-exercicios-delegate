using _01Exercicios;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Exercícios Delegate **********");

        #region Exercício 01

        var listaDePessoas = Pessoa.ObterListaDePessoas();

        Console.WriteLine("\nExercício 01 - Imprimindo o Nome e Idade de cada pessoa.");

        Action<Pessoa> imprimirListaDePessoas = p => Console.WriteLine($"{p.Nome} - {p.Idade}");
        listaDePessoas.ForEach(imprimirListaDePessoas);

        #endregion

        #region Exercício 02

        Console.WriteLine("\nExercício 02 - Filtrar pessoas maiores de 18 anos.");

        Predicate<Pessoa> filtrarIdadeMaiorQueDezoito = p => p.Idade > 18;
        var pessoasMaioresDeDozeoitoAnos = listaDePessoas.FindAll(filtrarIdadeMaiorQueDezoito);

        pessoasMaioresDeDozeoitoAnos.ForEach(imprimirListaDePessoas);

        #endregion

        Console.ReadKey();
    }
}