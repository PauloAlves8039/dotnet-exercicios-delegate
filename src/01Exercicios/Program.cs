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

        #region Exercício 03

        Console.WriteLine("\nExercício 03 - Obtendo idade de pessoa mais velha.");

        Func<Pessoa, int> obterIdade = p => p.Idade;

        var idadeMaxima = listaDePessoas.Max(obterIdade);

        var pessoaMaisVelha = listaDePessoas.Find(p => p.Idade == idadeMaxima);

        Console.WriteLine($"A pessoa mais velha é: {pessoaMaisVelha.Nome} a sua idade é {pessoaMaisVelha.Idade} anos.");

        #endregion

        Console.ReadKey();
    }
}