using System;
//5 7 11
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");

        float Bimestre1 = 0;
        float Bimestre2 = 0;
        float Bimestre3 = 0;
        float Bimestre4 = 0;

        float Resultado = 0;

        Console.WriteLine("coloque a nota da materia  1");
        Bimestre1 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("coloque a nota da materia 2 ");
        Bimestre2 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("coloque a nota da materia 3");
        Bimestre3 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("coloque a nota da materia 4 ");
        Bimestre4 = Convert.ToSingle(Console.ReadLine());

        Resultado = Bimestre1 + Bimestre2 + Bimestre3 + Bimestre4 / 4;

        Console.WriteLine("sua nota foi" + Resultado);

        if (Resultado <= 10)
        {
            Console.WriteLine("VC REPROVOU DIRETO !!!!");
        }
        else if (Resultado <= 15)
        {
            Console.WriteLine("VC ESTA DE EXAME !!!!");
        }
        else if (Resultado =< 20)
        {
            Console.WriteLine("VC PASSOU PARABENS!!!!");
        }
        else
        {
            Console.WriteLine("SOMENTE NUMERO RAPAZ!!");
        }
    }
}