
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("--- Etanol ou Gasolina ---");
    Console.ResetColor();

    Console.WriteLine("Digite o preço do etanol (R$).......: ");
    decimal etanol = Convert.ToDecimal(Console.ReadLine()!);

    Console.WriteLine("Digite o preço da gasolina (R$).....: ");
    decimal gasolina = Convert.ToDecimal(Console.ReadLine()!);

   string recomendacao;

    if (AbastecerComGasolina(etanol, gasolina))
    {
        recomendacao = "Gasolina";
    }
    else
    {
        recomendacao = "Etanol";
    }

    double razao = RazaoEtanolGasolina(etanol, gasolina) * 100;

    Console.WriteLine($"\nO preço do etanol corresponde a {razao:N1}% do preço da gasolina.");
    Console.WriteLine($"\nRecomendação: Abasteça com {recomendacao.ToUpper()}.");

    double RazaoEtanolGasolina(decimal precoEtanol, decimal precoGasolina)
    {
        return Convert.ToDouble(precoEtanol / precoGasolina);
    }

    bool AbastecerComGasolina(decimal precoEtanol, decimal precoGasolina)
    {
        const double MinRazaoUsoGasolina = 0.73;
        return RazaoEtanolGasolina(precoEtanol, precoGasolina) >= MinRazaoUsoGasolina;
    }