namespace ATV5_CJ302217X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 1 para Exercicio 1");
            Console.WriteLine("Digite 2 para Exercicio 2");
            Console.WriteLine("Digite 3 para Exercicio 3");
            Console.WriteLine("Digite 4 para Exercicio 4");
            Console.WriteLine("Digite 5 para Exercicio 5");
            Console.WriteLine("Digite 6 para Exercicio 6");
            Console.WriteLine("Digite 7 para Exercicio 7");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:

                    Console.WriteLine("Digite um numero");
                    int numero = int.Parse(Console.ReadLine());

                    Console.WriteLine("Números de 1 até o número digitado:");

                    for (int a = 1; a <= numero; a++)
                    {
                        Console.WriteLine(a);

                    }
                    break;

                case 2:

                    Console.WriteLine("Digite um número inteiro:");
                    int n = int.Parse(Console.ReadLine());

                    Console.WriteLine("Números pares de 1 até o número digitado:");

                    for (int b = 2; b <= n; b += 2)
                    {
                        Console.WriteLine(b);
                    }
                    break;

                case 3:

                    int nu;


                    Console.WriteLine("Digite um número inteiro menor que 1000:");
                    nu = int.Parse(Console.ReadLine());

                    Console.WriteLine("Números pares de 1000 até");

                    for (int c = 1000; c <= nu; c++)
                    {
                        if (c % 2 == 0)
                        {
                            Console.WriteLine(c);
                        }
                    }
                    break;

                case 4:

                    int somaPositivos = 0;

                    Console.WriteLine("Digite uma sequência de números inteiros (digite um número negativo para parar):");


                    {
                        Console.Write("Digite um número inteiro: ");
                        int num = int.Parse(Console.ReadLine());

                        if (num < 0)
                        {
                            break;
                        }

                        if (num > 0)
                        {
                            somaPositivos += num;
                            Console.WriteLine("Número positivo adicionado. Soma atual dos positivos: {somaPositivos}");
                        }
                    }

                    Console.WriteLine("A soma dos números positivos é {0}.", somaPositivos);
                    break;

                case 5:

                    Console.Write("Digite um número inteiro: ");
                    int n1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Os divisores do número {n1} são:");

                    for (int d = 1; d <= n1; d++)
                    {
                        if (n1 % d == 0)
                        {
                            Console.WriteLine(d);

                        }
                    }
                    break;

                case 6:

                    int quantidadeNumeros = 10;
                    int[] numeros =new int [quantidadeNumeros];
                    int maior = int.MinValue;
                    int menor = int.MaxValue;

                    Console.WriteLine("Digite 10 números:");

                    for (int i = 0; i < quantidadeNumeros; i++)
                    {
                        Console.Write("Número {i + 1}: ");
                        numeros[i] = int.Parse(Console.ReadLine());

                        if (numeros[i] > maior )
                        {
                            maior = numeros[i];
                        }

                        if (numeros[i] < menor )
                        {
                            menor = numeros[i];
                        }
                    }

                    Console.WriteLine("O maior número digitado foi: {0}", maior);
                    Console.WriteLine("O menor número digitado foi: {0}",menor);
                    break;

                case 7:

                    int somaPares = 0;
                    int somaImpares = 0;

                    Console.WriteLine("Digite uma sequência de números. Digite 0 para encerrar.");

                    {
                        Console.Write("Digite um número: ");
                        int n2 =int.Parse(Console.ReadLine());

                        if (n2 == 0)
                        {
                            break;
                        }

                        if (n2 % 2 == 0)
                        {
                            somaPares += n2;
                        }
                        else
                        {
                            somaImpares += n2;
                        }
                    }

                    Console.WriteLine("A soma dos números pares é: {0}", somaPares);
                    Console.WriteLine("A soma dos números ímpares é: {0}", somaImpares);
                    break;

            }
        }
    }
}