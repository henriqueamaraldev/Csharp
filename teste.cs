using System;
namespace teste
{
    public static class Teste
    {
        public static void firstQuestion()
        {
            Console.WriteLine("Questão 1: Ler dois números do teclado e informar o maior");
            Console.WriteLine("Insira o primeiro numero: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O maior numero é: " + Math.Max(firstNumber, secondNumber));
        }

        public static void secondQuestion()
        {
            Console.WriteLine("Questão 2: Ler um número real e informar se ele é positivo negativo ou nulo");
            Console.WriteLine("Insira um numero: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("O numero é positivo");
            }
            else if (number < 0)
            {
                Console.WriteLine("O numero é negativo");
            }
            else
            {
                Console.WriteLine("O numero é nulo");
            }
        }
        public static void thirdQuestion()
        {
            Console.WriteLine("Questão 3: Ler um número inteiro e dizer se ele é par ou impar (dica: use o operador resto da divisão )");
            Console.WriteLine("Insira um numero: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("O numero é par");
            }
            else
            {
                Console.WriteLine("O numero é impar");
            }
        }
        public static void fourthQuestion()
        {
            Console.WriteLine("Questão 4: Ler um número e informar seu valor absoluto ( Exemplo: ABS(10) = 10 / ABS(-10) = 10 )");
            Console.WriteLine("Insira um numero: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Abs(number));
        }
        public static void fifthQuestion()
        {
            Console.WriteLine("Questão 5: Ler um número e informar se ele é divisível por 2 e por 7 ao mesmo tempo.");
            Console.WriteLine("Insira um numero: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0 && number % 7 == 0)
            {
                Console.WriteLine("O numero é divisivel por 2 e 7");
            }
            else
            {
                Console.WriteLine("O numero não é divisivel por 2 e 7");
            }
        }
        public static void sixthQuestion()
        {
            Console.WriteLine("Questão 6: Ler três números quaisquer e informar o maior e o menor");
            Console.WriteLine("Insira um numero: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine("O maior numero é: " + number1);
            }
            else if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine("O maior numero é: " + number2);
            }
            else
            {
                Console.WriteLine("O maior numero é: " + number3);
            }
            if (number1 < number2 && number1 < number3)
            {
                Console.WriteLine("O menor numero é: " + number1);
            }
            else if (number2 < number1 && number2 < number3)
            {
                Console.WriteLine("O menor numero é: " + number2);
            }
            else
            {
                Console.WriteLine("O menor numero é: " + number3);
            }
        }
        public static void seventhQuestion()
        {
            Console.WriteLine("Questão 7: Ler três números e informar a soma dos dois maiores.");
            Console.WriteLine("Insira um numero: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            if (number1 < number2 && number1 < number3)
            {
                Console.WriteLine("A soma dos dois maiores numeros é: " + (number2 + number3));
            }
            else if (number2 < number1 && number2 < number3)
            {
                Console.WriteLine("A soma dos dois maiores numeros é: " + (number1 + number3));
            }
            else
            {
                Console.WriteLine("A soma dos dois maiores numeros é: " + (number1 + number2));
            }
        }
        public static void eighthQuestion()
        {
            Console.WriteLine("Questão 8: Ler quatro notas (de 0 a 100) de um aluno; calcular a média aritmética das notas; verificar se o aluno foi aprovado ou não. (média deve ser maior ou igual a 60)");
            Console.WriteLine("Insira um numero: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            int number4 = Convert.ToInt32(Console.ReadLine());
            if (number1 <= 100 && number1 >= 0 && number2 <= 100 && number2 >= 0 && number3 <= 100 && number3 >= 0 && number4 <= 100 && number4 >= 0)
            {
                int media = ((number1 + number2 + number3 + number4) / 4);
                if (media >= 60)
                {
                    Console.WriteLine("A média é: " + media + " e aprovado");
                }
                else
                {
                    Console.WriteLine("A média é: " + media + " e reprovado");
                }
            }
            else
            {
                Console.WriteLine("Um dos numeros é maior que 100 ou é menor que 0");
            }
        }

        public static void ninthQuestion()
        {
            Console.WriteLine("Questão 9: Escreva um programa para o cálculo do salário líquido de um funcionário, levando-se em conta: \n" +
"a. Salário Bruto = horas trabalhadas * salário hora \n" + "b. Desconto = 0% do salário bruto, se este for menor que R$350,00 \n" + "c. Desconto = 10% do salário bruto, se este for maior que R$350,00 e menor que R$1000,00 \n" + "d. Desconto = 20% do salário bruto, se este for maior que R$1000,00. \n" + "Os valores de horas trabalhadas e salário hora deverão ser recebidos através do dispositivo de entrada. \n" + "Sabe-se ainda que o salário líquido é igual ao salário bruto subtraído do desconto.");
            Console.WriteLine("Insira a quantidade de horas trabalhadas no mes: ");
            int workedTimeAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor do salario por hora em reais: ");
            int salaryPerHour = Convert.ToInt32(Console.ReadLine());
            int salary = workedTimeAmount * salaryPerHour;
            if (salary < 350)
            {
                Console.WriteLine("O salario é: " + salary + " e o empregado está isento de imposto");
            }
            else if (salary >= 350 && salary < 1000)
            {
                Console.WriteLine("O salario é: " + salary * 0.9);
            }
            else if (salary >= 1000)
            {
                Console.WriteLine("O salario é: " + salary * 0.8);
            }
            Console.WriteLine("Insira o valor do salario por hora em reais: ");
        }
    }
}
