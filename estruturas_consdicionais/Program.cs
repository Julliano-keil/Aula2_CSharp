class Program
{
    static void Main(string[] args)
    {


        //List<int> list = new List<int> { 1,2,3,4,5 };

        // for (int i = 0; i < list.Count; i++)
        // {
        //     Console.WriteLine(list[i]);
        // }

        //string[] nomes = { "leo", "juliano", "emyly", "caua", "rodrigo" };

        //foreach (var item in nomes)
        //{
        //    Console.WriteLine(item);
        //}

        Console.WriteLine("digite um numero");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero < 5)
        {
            Console.WriteLine("numero menor que 5");
        }
        else if (numero < 10)
        {
            Console.WriteLine("numero menor que 10");
        }
        else if (numero < 20)
        {
            Console.WriteLine("numero menor que 20");
        }
        else
        {
            Console.WriteLine("numero maior que 20");
        }

        //switch (numero)
        //{
        //    case < 5 : Console.WriteLine("numero menor que 5");
        //        break;
        //    case < 10:
        //        Console.WriteLine("numero menor que 10");
        //        break;
        //    case < 20:
        //        Console.WriteLine("numero menor que 20");
        //        break;

        //}


    }
}
