try
{
    Console.WriteLine("Digite um valor: ");
    int valor = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(valor / 0);
}
catch (DivideByZeroException dbz)
{
    Console.WriteLine($"Erro ao tentar dividir por zero.");
}
catch (IndexOutOfRangeException ire)
{
    Console.WriteLine($"{ire}");
}
catch (Exception ex)
{
    Console.WriteLine("Valor inválido!  " + ex.Message);
}