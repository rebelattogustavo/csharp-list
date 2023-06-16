using System;
using System.Collections.Generic;

namespace csharptutorial
{
    class exercicios
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número do exercício que você deseja (1 - 64): ");
            int exercicio = int.Parse(Console.ReadLine());

            while (exercicio > 64 || exercicio < 1)
            {
                Console.WriteLine("Número inválido, os exercícios vão do 1 ao 64. Digite novamente: ");
                exercicio = int.Parse(Console.ReadLine());
            }
            
            switch (exercicio)
            {
                case 1:
                    exercicio1();
                    break;

                case 2:
                    exercicio2();
                    break;

                case 3:
                    exercicio3();
                    break;

                case 4:
                    exercicio4();
                    break;

                case 5:
                    exercicio5();
                    break;

                case 6:
                    exercicio6();
                    break;

                case 7:
                    exercicio7();
                    break;

                case 8:
                    exercicio8();
                    break;

                case 9:
                    exercicio9();
                    break;

                case 10:
                    exercicio10();
                    break;

                case 11:
                    exercicio11();
                    break;

                case 12:
                    exercicio12();
                    break;

                case 13:
                    exercicio13();
                    break;

                case 14:
                    exercicio14();
                    break;

                case 15:
                    exercicio15();
                    break;

                case 16:
                    exercicio16();
                    break;

                case 17:
                    exercicio17();
                    break;

                case 18:
                    exercicio18();
                    break;

                case 19:
                    exercicio19();
                    break;

                case 20:
                    exercicio20();
                    break;

                case 21:
                    exercicio21();
                    break;

                case 22:
                    exercicio22();
                    break;

                case 23:
                    exercicio23();
                    break;

                case 24:
                    exercicio24();
                    break;

                case 25:
                    exercicio25();
                    break;

                case 26:
                    exercicio26();
                    break;

                case 27:
                    exercicio27();
                    break;

                case 28:
                    exercicio28();
                    break;

                case 29:
                    exercicio29();
                    break;

                case 30:
                    exercicio30();
                    break;

                case 31:
                    exercicio31();
                    break;

                case 32:
                    exercicio32();
                    break;

                case 33:
                    exercicio33();
                    break;

                case 34:
                    exercicio34();
                    break;

                case 35:
                    exercicio35();
                    break;

                case 36:
                    exercicio36();
                    break;

                case 37:
                    exercicio37();
                    break;

                case 38:
                    exercicio38();
                    break;

                case 39:
                    exercicio39();
                    break;

                case 40:
                    exercicio40();
                    break;

                case 41:
                    exercicio41();
                    break;

                case 42:
                    exercicio42();
                    break;

                case 43:
                    exercicio43();
                    break;

                case 44:
                    exercicio44();
                    break;

                case 45:
                    exercicio45();
                    break;

                case 46:
                    exercicio46();
                    break;

                case 47:
                    exercicio47();
                    break;

                case 48:
                    exercicio48();
                    break;

                case 49:
                    exercicio49();
                    break;

                case 50:
                    exercicio50();
                    break;

                case 51:
                    exercicio51();
                    break;

                case 52:
                    exercicio52();
                    break;

                case 53:
                    exercicio53();
                    break;

                case 54:
                    exercicio54();
                    break;

                case 55:
                    exercicio55();
                    break;

                case 56:
                    exercicio56();
                    break;

                case 57:
                    exercicio57();
                    break;

                case 58:
                    exercicio58();
                    break;

                case 59:
                    exercicio59();
                    break;

                case 60:
                    exercicio60();
                    break;

                case 61:
                    exercicio61();
                    break;

                case 62:
                    exercicio62();
                    break;

                case 63:
                    exercicio63();
                    break;

                case 64:
                    exercicio64();
                    break;
            }
        }

        static void exercicio1()
        {
            //Faça um programa para calcular o estoque médio de uma peça, sendo que:
            //ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE_MÁXIMA) / 2.

            Console.WriteLine("Digite a quantidade mínima de peças: ");
            int quantidadeMinima = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade máxima peças: ");
            int quantidadeMaxima = int.Parse(Console.ReadLine());
            int estoqueMedio = (quantidadeMinima + quantidadeMaxima) / 2;
            Console.WriteLine("O estoque médio de peças é: " + estoqueMedio);
        }

        static void exercicio2()
        {
            //Faça um programa que:
            //- Leia a cotação do dólar
            //- Leia um valor em dólares
            //- Converta esse valor para Real
            //- Mostre o resultado
            Console.WriteLine("\nDigite a cotação do dólar: ");
            double cotacaoDolar = double.Parse(System.Console.ReadLine());
            Console.WriteLine("Digite o valor em dólares: ");
            double valorDolar = double.Parse(System.Console.ReadLine());
            double valorReal = cotacaoDolar * valorDolar;
            Console.WriteLine("O valor em reais é: R$" + valorReal);
        }

        static void exercicio3()
        {
            // Faça um programa para pagamento de comissão de vendedores de peças, levando-se em consideração que sua
            // comissão será de 5% do total da venda e que você tem os seguintes dados:
            // - Identificação do vendedor
            // - Código da peça
            // - Preço unitário da peça
            // - Quantidade vendida
            Console.WriteLine("\nDigite o código do vendedor: ");
            int codigoVendedor = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Digite o código da peça: ");
            int codigoPeca = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Digite o preço unitário da peça: ");
            double precoUnitario = double.Parse(System.Console.ReadLine());
            Console.WriteLine("Digite a quantidade vendida: ");
            int quantidadeVendida = int.Parse(System.Console.ReadLine());
            double valorTotal = precoUnitario * quantidadeVendida;
            double comissao = valorTotal * 0.05;
            Console.WriteLine("O valor total da venda é: R$" + valorTotal);
            Console.WriteLine("O valor da comissão é: R$" + comissao);
        }

        static void exercicio4()
        {
            /*Ler quatro valores numéricos inteiros e apresentar o resultado dois a dois da adição e multiplicação entre os valores
                lidos, baseando-se na utilização do conceito de propriedade distributiva. Dica: se forem lidas as variáveis A, B, C e
                D, devem ser somados e multiplicados os valores de A com B, A com C e A com D; depois B com C, B com D e
                por último C com D. Note que para cada operação serão utilizadas seis combinações. Assim sendo, devem ser
                realizadas doze operações de processamento, sendo seis para as adições e seis para as multiplicações.*/


            Console.WriteLine("\nDigite o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro valor: ");
            int valor3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quarto valor: ");
            int valor4 = int.Parse(Console.ReadLine());
            int soma1 = soma(valor1, valor2);
            int soma2 = soma(valor1, valor3);
            int soma3 = soma(valor1, valor4);
            int soma4 = soma(valor2, valor3);
            int soma5 = soma(valor2, valor4);
            int soma6 = soma(valor3, valor4);
            int multiplicacao1 = multiplicacao(valor1, valor2);
            int multiplicacao2 = multiplicacao(valor1, valor3);
            int multiplicacao3 = multiplicacao(valor1, valor4);
            int multiplicacao4 = multiplicacao(valor2, valor3);
            int multiplicacao5 = multiplicacao(valor2, valor4);
            int multiplicacao6 = multiplicacao(valor3, valor4);
            Console.WriteLine("A soma de " + valor1 + " com " + valor2 + " é: " + soma1);
            Console.WriteLine("A soma de " + valor1 + " com " + valor3 + " é: " + soma2);
            Console.WriteLine("A soma de " + valor1 + " com " + valor4 + " é: " + soma3);
            Console.WriteLine("A soma de " + valor2 + " com " + valor3 + " é: " + soma4);
            Console.WriteLine("A soma de " + valor2 + " com " + valor4 + " é: " + soma5);
            Console.WriteLine("A soma de " + valor3 + " com " + valor4 + " é: " + soma6);
            Console.WriteLine("A multiplicação de " + valor1 + " com " + valor2 + " é: " + multiplicacao1);
            Console.WriteLine("A multiplicação de " + valor1 + " com " + valor3 + " é: " + multiplicacao2);
            Console.WriteLine("A multiplicação de " + valor1 + " com " + valor4 + " é: " + multiplicacao3);
            Console.WriteLine("A multiplicação de " + valor2 + " com " + valor3 + " é: " + multiplicacao4);
            Console.WriteLine("A multiplicação de " + valor2 + " com " + valor4 + " é: " + multiplicacao5);
            Console.WriteLine("A multiplicação de " + valor3 + " com " + valor4 + " é: " + multiplicacao6);
        }

        static int soma(int valor1, int valor2)
        {
            int resultado = valor1 + valor2;
            return resultado;
        }

        static int multiplicacao(int valor1, int valor2)
        {
            int resultado = valor1 * valor2;
            return resultado;
        }

        static void exercicio5()
        {
            // Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem, utilizando um automóvel que faz 12
            // Km por litro. Para obter o cálculo, o usuário deve fornecer o tempo gasto na viagem e a velocidade média. Desta
            //     forma, será possível obter a distância percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE. Tendo o
            //     valor da distância, basta calcular a quantidade de litros de combustível utilizada na viagem com a fórmula:
            // LITROS_USADOS = DISTANCIA / 12. O programa deve apresentar os valores da velocidade média, tempo gasto,
            // a distância percorrida e a quantidade de litros utilizada na viagem. Dica: trabalhe com valores reais

            Console.WriteLine("\nDigite o tempo gasto na viagem: ");
            double tempo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a velocidade média: ");
            double velocidade = double.Parse(Console.ReadLine());

            double distancia = tempo * velocidade;
            double litrosUsados = distancia / 12;

            Console.WriteLine("A velocidade média é: " + velocidade + "km/h");
            Console.WriteLine("O tempo gasto na viagem é: " + tempo + "h");
            Console.WriteLine("A distância percorrida é: " + distancia + "km");
            Console.WriteLine("A quantidade de litros utilizada na viagem é: " + litrosUsados + "L");
        }

        static void exercicio6()
        {
            // Ler uma temperatura em graus Celsius e apresentá-Ia convertida em graus Fahrenheit. A fórmula de conversão de
            //     temperatura a ser utilizada é F = (9 * C + 160) / 5, em que a variável F representa é a temperatura em graus
            // Fahrenheit e a variável C representa é a temperatura em graus Celsius.

            Console.WriteLine("\nDigite a temperatura em graus Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (9 * celsius + 160) / 5;

            Console.WriteLine("A temperatura em graus Fahrenheit é: " + fahrenheit + "°F");
        }

        static void exercicio7()
        {
            // Ler uma temperatura em graus Fahrenheit e apresentá-Ia convertida em graus Celsius. A fórmula de conversão de
            //     temperatura a ser utilizada é C = (F - 32) * 5 / 9, em que a variável F é a temperatura em graus Fahrenheit e a
            // variável C é a temperatura em graus Celsius.

            Console.WriteLine("\nDigite a temperatura em graus Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine("A temperatura em graus Celsius é: " + celsius + "°C");
        }

        static void exercicio8()
        {
            // Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula:
            // V = 3.14159 * R * R * A
            // Onde as variáveis: V, R e A representam respectivamente o volume, o raio e a altura.

            Console.WriteLine("\nDigite o raio da lata de óleo: ");
            double raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura da lata de óleo: ");
            double altura = double.Parse(Console.ReadLine());

            double volume = 3.14159 * raio * raio * altura;

            Console.WriteLine("O volume da lata de óleo é: " + volume);
        }

        static void exercicio9()
        {
            // Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a idade dessa
            //     pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias.

            Console.WriteLine("\nDigite a idade em anos: ");
            int anos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a idade em meses: ");
            int meses = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a idade em dias: ");
            int dias = int.Parse(Console.ReadLine());

            int idadeDias = anos * 365 + meses * 30 + dias;

            Console.WriteLine("A idade em dias é: " + idadeDias);
        }

        static void exercicio10()
        {
            // Escrever um programa que leia dois números inteiros e mostre todos os relacionamentos de ordem existentes
            // entre eles. Os relacionamentos possíveis são: Igual, Não igual, Maior, Menor, Maior ou igual, Menor ou igual.

            Console.WriteLine("\nDigite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 == numero2)
            {
                Console.WriteLine("Os números são iguais");
            }
            else if (numero1 != numero2)
            {
                Console.WriteLine("Os números são diferentes");
            }
            else if (numero1 > numero2)
            {
                Console.WriteLine("O primeiro número é maior que o segundo");
            }
            else if (numero1 < numero2)
            {
                Console.WriteLine("O primeiro número é menor que o segundo");
            }
            else if (numero1 >= numero2)
            {
                Console.WriteLine("O primeiro número é maior ou igual ao segundo");
            }
            else if (numero1 <= numero2)
            {
                Console.WriteLine("O primeiro número é menor ou igual ao segundo");
            }
        }

        static void exercicio11()
        {
            // Ler dois valores inteiros para as variáveis A e B, efetuar a troca dos valores de modo que a variável A passe a
            // possuir o valor da variável B, e a variável B passe a possuir o valor da variável A. Apresentar os valores trocados.

            Console.WriteLine("\nDigite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            (numero1, numero2) = (numero2, numero1);

            Console.WriteLine("O primeiro número é: " + numero1);
            Console.WriteLine("O segundo número é: " + numero2);
        }

        static void exercicio12()
        {
            // Escreva um programa que leia um número inteiro e exiba o seu módulo.
            //     O módulo de um número x é:
            // x se x é maior ou igual a zero
            // x * (-1) se x é menor que zero

            Console.WriteLine("\nDigite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                Console.WriteLine("O módulo do número é: " + numero);
            }
            else
            {
                Console.WriteLine("O módulo do número é: " + numero * (-1));
            }
        }

        static void exercicio13()
        {
            // Escreva um programa que leia 3 números inteiros e imprima na tela os valores em ordem decrescente.

            Console.WriteLine("\nDigite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            int numero3 = int.Parse(Console.ReadLine());

            if (numero1 > numero2 && numero1 > numero3)
            {
                if (numero2 > numero3)
                {
                    Console.WriteLine("A ordem decrescente é: " + numero1 + ", " + numero2 + ", " + numero3);
                }
                else
                {
                    Console.WriteLine("A ordem decrescente é: " + numero1 + ", " + numero3 + ", " + numero2);
                }
            }
            else if (numero2 > numero1 && numero2 > numero3)
            {
                if (numero1 > numero3)
                {
                    Console.WriteLine("A ordem decrescente é: " + numero2 + ", " + numero1 + ", " + numero3);
                }
                else
                {
                    Console.WriteLine("A ordem decrescente é: " + numero2 + ", " + numero3 + ", " + numero1);
                }
            }
            else if (numero3 > numero1 && numero3 > numero2)
            {
                if (numero1 > numero2)
                {
                    Console.WriteLine("A ordem decrescente é: " + numero3 + ", " + numero1 + ", " + numero2);
                }
                else
                {
                    Console.WriteLine("A ordem decrescente é: " + numero3 + ", " + numero2 + ", " + numero1);
                }
            }
        }

        static void exercicio14()
        {
            // Escreva um programa que leia dois números e apresente a diferença do maior para o menor.

            Console.WriteLine("\nDigite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("A diferença do maior para o menor é: " + (numero1 - numero2));
            }
            else
            {
                Console.WriteLine("A diferença do maior para o menor é: " + (numero2 - numero1));
            }
        }

        static void exercicio15()
        {
            // Escreva um programa que leia quatro notas escolares de um aluno e apresentar uma mensagem que o aluno foi
            // aprovado se o valor da média escolar for maior ou igual a 7. Se o valor da média for menor que 7, solicitar a nota
            // do recuperação, somar com o valor da média e obter a nova média. Se a nova média for maior ou igual a 7,
            // apresentar uma mensagem informando que o aluno foi aprovado na recuperação. Se o aluno não foi aprovado,
            // apresentar uma mensagem informando esta condição. Apresentar junto com as mensagens o valor da média do aluno.

            Console.WriteLine("\nDigite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota: ");
            double nota4 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 7)
            {
                Console.WriteLine("O aluno foi aprovado com média: " + media);
            }
            else
            {
                Console.WriteLine("Digite a nota da recuperação: ");
                double notaRecuperacao = double.Parse(Console.ReadLine());

                double novaMedia = (media + notaRecuperacao) / 2;

                if (novaMedia >= 7)
                {
                    Console.WriteLine("O aluno foi aprovado na recuperação com média: " + novaMedia);
                }
                else
                {
                    Console.WriteLine("O aluno foi reprovado com média: " + novaMedia);
                }
            }
        }

        static void exercicio16()
        {
            // Escreva um programa que leia dois números e exiba mensagem informando o valor do maior número e o valor do
            // menor número. Se os dois números forem iguais, o programa deve exibir mensagem informando este fato.

            Console.WriteLine("\nDigite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("O maior número é: " + numero1);
                Console.WriteLine("O menor número é: " + numero2);
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine("O maior número é: " + numero2);
                Console.WriteLine("O menor número é: " + numero1);
            }
            else
            {
                Console.WriteLine("Os números são iguais.");
            }
        }

        static void exercicio17()
        {
            // Escreva um programa que leia um número inteiro. Verificar por meio de condição se o valor fornecido está na faixa
            // entre 0 (zero) e 9 (nove). Caso o valor fornecido esteja dentro da faixa, apresentar a mensagem “valor válido”.
            // Caso contrário, apresentar a mensagem “valor inválido”.

            Console.WriteLine("\nDigite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0 && numero <= 9)
            {
                Console.WriteLine("Valor válido.");
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }
        }

        static void exercicio18()
        {
            // Escreva um programa que leia um número inteiro (variável CODIGO). Verificar se o código é igual a 1, igual a 2 ou
            // igual a 3. Caso não seja, apresentar a mensagem “Código inválido”. Ao ser verificado o código e constatado que é
            // um valor válido, o programa deve verificar cada código em separado para determinar seu valor por extenso, ou
            // seja, apresentar a mensagem “um”, ”dois” ou “três”. (Utilizar o comando Switch).

            Console.WriteLine("\nDigite um número inteiro: ");
            int codigo = int.Parse(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    Console.WriteLine("Um");
                    break;
                case 2:
                    Console.WriteLine("Dois");
                    break;
                case 3:
                    Console.WriteLine("Três");
                    break;
                default:
                    Console.WriteLine("Código inválido.");
                    break;
            }
        }

        static void exercicio19()
        {
            // Escreva um programa que leia três valores para os lados de um triângulo (variáveis A, B e C). Verificar se cada
            // lado é menor que a soma dos outros dois lados. Se sim, saber de A==B e se B==C, sendo verdade o triângulo é
            // eqüilátero; Se não, verificar de A==B ou se A==C ou se B==C, sendo verdade o triângulo é isósceles; e caso
            // contrário, o triângulo será escaleno. Caso os lados fornecidos não caracterizarem um triângulo, avisar a ocorrência.

            Console.WriteLine("\nDigite o primeiro lado do triângulo: ");
            int lado1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo lado do triângulo: ");
            int lado2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro lado do triângulo: ");
            int lado3 = int.Parse(Console.ReadLine());

            if (lado1 < lado2 + lado3 && lado2 < lado1 + lado3 && lado3 < lado1 + lado2)
            {
                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("O triângulo é equilátero.");
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    Console.WriteLine("O triângulo é isósceles.");
                }
                else
                {
                    Console.WriteLine("O triângulo é escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Os lados fornecidos não caracterizam um triângulo.");
            }
        }

        static void exercicio20()
        {
            // Escrever um programa declarando três variáveis do tipo inteiro (a, b e c). Ler um valor maior que zero para cada
            // variável (se o valor digitado não é válido, mostrar mensagem e ler novamente). Exibe o menor valor lido
            // multiplicado pelo maior e o maior valor dividido pelo menor.

            Console.WriteLine("\nDigite o primeiro número inteiro: ");
            int a = int.Parse(Console.ReadLine());

            while (a <= 0)
            {
                Console.WriteLine("Número inválido. Digite novamente: ");
                a = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite o segundo número inteiro: ");
            int b = int.Parse(Console.ReadLine());

            while (b <= 0)
            {
                Console.WriteLine("Número inválido. Digite novamente: ");
                b = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite o terceiro número inteiro: ");
            int c = int.Parse(Console.ReadLine());

            while (c <= 0)
            {
                Console.WriteLine("Número inválido. Digite novamente: ");
                c = int.Parse(Console.ReadLine());
            }

            if (a < b && a < c)
            {
                Console.WriteLine("O menor número é: " + a);
                Console.WriteLine("O maior número é: " + Math.Max(b, c));
            }
            else if (b < a && b < c)
            {
                Console.WriteLine("O menor número é: " + b);
                Console.WriteLine("O maior número é: " + Math.Max(a, c));
            }
            else
            {
                Console.WriteLine("O menor número é: " + c);
                Console.WriteLine("O maior número é: " + Math.Max(a, b));
            }
        }

        static void exercicio21()
        {
            // Faça um programa que leia um número inteiro e mostre uma mensagem na tela indicando se este número é 
            // positivo ou negativo. Pare a execução do programa quando o usuário requisitar.

            String resposta = "s";
            while (resposta == "s" || resposta == "S")
            {
                Console.WriteLine("\nDigite um número inteiro: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero >= 0)
                {
                    Console.WriteLine("Número positivo.");
                }
                else
                {
                    Console.WriteLine("Número negativo.");
                }

                Console.WriteLine("Deseja continuar? (s/n)");
                resposta = Console.ReadLine();
            }
        }

        static void exercicio22()
        {
            // Faça um programa que leia um número. Se positivo armazene-o em A, se for negativo, em B. No final mostrar o resultado.

            Console.WriteLine("\nDigite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                Console.WriteLine("Número positivo.");
            }
            else
            {
                Console.WriteLine("Número negativo.");
            }
        }

        static void exercicio23()
        {
            // Escreva um programa que exiba as seguintes opções e realize os que se pede em cada uma delas:
            // 1 – Adição
            // 2 – Subtração
            // 3 – Multiplicação
            // 4 – Divisão

            Console.WriteLine("\nDigite o primeiro número inteiro: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite a opção desejada: ");
            Console.WriteLine("1 – Adição" +
                              "\n2 – Subtração" +
                              "\n3 – Multiplicação" +
                              "\n4 – Divisão");
            int opcao = int.Parse(Console.ReadLine());

            while (opcao > 4 || opcao < 1)
            {
                Console.WriteLine("Opção inválida. Digite novamente:");
                opcao = int.Parse(Console.ReadLine());
            }

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("A soma dos números é: " + (numero1 + numero2));
                    break;
                case 2:
                    Console.WriteLine("A subtração dos números é: " + (numero1 - numero2));
                    break;
                case 3:
                    Console.WriteLine("A multiplicação dos números é: " + (numero1 * numero2));
                    break;
                case 4:
                    Console.WriteLine("A divisão dos números é: " + (numero1 / numero2));
                    break;
            }
        }

        static void exercicio24()
        {
            // Escreva um programa que leia dois números inteiros e apresente as opções para usuário escolher o que deseja
            // realizar:
            // 1 – Verificar se um dos números lidos é ou não múltiplo do outro
            // 2 – Verificar se os dois números lidos são pares
            // 3 – Verificar se a média dos dois números é maior ou igual a 7.
            // 4 – Sair

            Console.WriteLine("\nDigite o primeiro número inteiro: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite a opção desejada: " +
                              "\n1 – Verificar se um dos números lidos é ou não múltiplo do outro"
                              + "\n2 – Verificar se os dois números lidos são pares"
                              + "\n3 – Verificar se a média dos dois números é maior ou igual a 7."
                              + "\n4 – Sair");

            int opcao = int.Parse(Console.ReadLine());

            while (opcao > 4)
            {
                Console.WriteLine("Opção inválida. Digite novamente:");
                opcao = int.Parse(Console.ReadLine());
            }

            switch (opcao)
            {
                case 1:
                    if (a % b == 0 || b % a == 0)
                    {
                        Console.WriteLine("Um dos números é múltiplo do outro.");
                    }
                    else
                    {
                        Console.WriteLine("Nenhum dos números é múltiplo do outro.");
                    }

                    break;
                case 2:
                    if (a % 2 == 0 && b % 2 == 0)
                    {
                        Console.WriteLine("Os dois números são pares.");
                    }
                    else
                    {
                        Console.WriteLine("Os dois números não são pares.");
                    }

                    break;
                case 3:
                    if ((a + b) / 2 >= 7)
                    {
                        Console.WriteLine("A média dos dois números é maior ou igual a 7.");
                    }
                    else
                    {
                        Console.WriteLine("A média dos dois números é menor que 7.");
                    }

                    break;
            }
        }

        static void exercicio25()
        {
            // Tendo como dados de entrada a altura e o sexo de uma pessoa, faça um programa que calcule seu peso ideal,
            //  utilizando as seguintes fórmulas: (h = altura)
            //  - Para homens: (72.7*h) - 58
            //  - Para mulheres: (62.1 *h) - 44.7

            Console.WriteLine("\nDigite a altura da pessoa: ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o sexo da pessoa (M/F): ");
            string sexo = Console.ReadLine();

            while (sexo != "M" || sexo != "m" || sexo != "F" || sexo != "f")
            {
                Console.WriteLine("Sexo inválido. Digite novamente:");
                sexo = Console.ReadLine();
            }

            if (sexo == "M" || sexo == "m")
            {
                Console.WriteLine("O peso ideal é: " + ((72.7 * altura) - 58));
            }
            else
            {
                Console.WriteLine("O peso ideal é: " + ((62.1 * altura) - 44.7));
            }
        }

        static void exercicio26()
        {
            // Escreva um programa que exiba os números de 1 a 100 na tela em ordem decrescente.

            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        static void exercicio27()
        {
            // Escreva um programa que leia:
            // - a quantidade de números que deverá processar;
            // - os números que deverá processar,e calcule e exiba, para cada número a ser processado o seu fatorial.
            //     Lembrete: O fatorial de um número N é dado pela fórmula: N! = 1 * 2 * 3 * 4 * 5 * ... * N

            Console.WriteLine("\nDigite a quantidade de números que deverá processar: ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine("Digite o número que deverá processar: ");
                int numero = int.Parse(Console.ReadLine());

                int fatorial = 1;
                for (int j = 1; j <= numero; j++)
                {
                    fatorial *= j;
                }

                Console.WriteLine("O fatorial do número " + numero + " é: " + fatorial);
            }
        }

        static void exercicio28()
        {
            // Faça um programa que gera e escreve os números ímpares dos números lidos entre 100 e 200.

            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void exercicio29()
        {
            // Faça um programa que exiba os números de 1 até 2000.

            for (int i = 1; i <= 2000; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void exercicio30()
        {
            // Faça um programa para imprimir uma tabuada.

            Console.WriteLine("\nDigite o número que deseja ver a tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            }
        }

        static void exercicio31()
        {
            // Escrever um programa que leia um conjunto de números positivos, e exiba se o número lido é par ou ímpar. Exiba
            //     ao final a soma total dos números pares lidos e também a soma dos números ímpares lidos. Suporemos que o
            //     número de elementos deste conjunto não é conhecido, e que um número negativo será utilizado para sinalizar o
            //     fim dos dados.

            int numero = 0;
            int somaPares = 0;
            int somaImpares = 0;

            while (numero >= 0)
            {
                Console.WriteLine("Digite um número inteiro (digite um negativo para parar): ");
                numero = int.Parse(Console.ReadLine());

                if (numero >= 0)
                {
                    if (numero % 2 == 0)
                    {
                        somaPares += numero;
                    }
                    else
                    {
                        somaImpares += numero;
                    }
                }
            }

            Console.WriteLine("A soma dos números pares é: " + somaPares);
            Console.WriteLine("A soma dos números ímpares é: " + somaImpares);
        }

        static void exercicio32()
        {
            // Escreva um programa que calcule e exiba a soma dos quadrados dos 20 primeiros números inteiros positivos
            // ímpares a partir do número informado pelo usuário menor que 10 e maior que zero.

            Console.WriteLine("\nDigite um número inteiro entre 0 e 10: ");
            int numero = int.Parse(Console.ReadLine());

            while (numero <= 0 || numero >= 10)
            {
                Console.WriteLine("Número inválido. Digite novamente: ");
                numero = int.Parse(Console.ReadLine());
            }

            int soma = 0;
            for (int i = 1; i <= 20; i++)
            {
                soma += (numero * numero);
                numero += 2;
            }

            Console.WriteLine("A soma dos quadrados dos 20 primeiros números ímpares a partir do número digitado é: " +
                              soma);
        }

        static void exercicio33()
        {
            // Escreva um programa que calcule e exiba a média da nota dos alunos de uma turma em uma éprova. O número de
            //     alunos é desconhecido. Os dados de um aluno são: número de matrícula e a sua nota na prova em questão.
            int matricula, cont = 0;
            double nota, media = 0;

            Console.WriteLine("Digite a matricula do aluno: ");
            matricula = int.Parse(Console.ReadLine());

            while (matricula != 0)
            {
                Console.WriteLine("Digite a nota do aluno: ");
                nota = double.Parse(Console.ReadLine());
                media += nota;
                cont++;
                Console.WriteLine("Digite a matricula do aluno: ");
                matricula = int.Parse(Console.ReadLine());
            }

            media = media / cont;
            Console.WriteLine("A media da turma é: " + media);
        }

        static void exercicio34()
        {
            // Escreva um programa que leia um conjunto de números positivos e exiba o menor e o maior. Suporemos que o
            //     número de elementos deste conjunto não é conhecido, e que um número negativo será utilizado para sinalizar o
            //     fim dos dados.

            int numero, menor = 0, maior = 0;

            Console.WriteLine("Digite um numero: ");
            numero = int.Parse(Console.ReadLine());

            while (numero >= 0)
            {
                if (numero < menor)
                {
                    menor = numero;
                }
                else if (numero > maior)
                {
                    maior = numero;
                }

                Console.WriteLine("Digite um numero: ");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("O menor numero é: " + menor);
            Console.WriteLine("O maior numero é: " + maior);
        }

        static void exercicio35()
        {
            // Faça um programa que conte de 1 até 100 e a cada múltiplo de 10 exiba uma mensagem: "Múltiplo de 10".
            for (int i = 1; i <= 100; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine("Múltiplo de 10");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void exercicio36()
        {
            // Faça um programa que leia 10 valores inteiros e positivos e:
            // - Encontre o maior valor
            // - Encontre o menor valor
            // - Calcule a média dos números lidos

            int numero, maior = 0, menor = 0, media = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um numero: ");
                numero = int.Parse(Console.ReadLine());

                if (numero > maior)
                {
                    maior = numero;
                }
                else if (numero < menor)
                {
                    menor = numero;
                }

                media += numero;
            }

            media = media / 10;
            Console.WriteLine("O maior numero é: " + maior);
            Console.WriteLine("O menor numero é: " + menor);
            Console.WriteLine("A media dos numeros é: " + media);
        }

        static void exercicio37()
        {
            // Faça um programa de conversão de base numérica. O programa deverá apresentar uma tela de entrada com as
            //     seguintes opções:
            // 1 – Adição
            // 2 – Subtração
            //
            // 3 – Multiplicação
            // 4 – Divisão
            //     Informe a opção:
            // A partir da opção escolhida, o programa deverá solicitar para que o usuário digite dois números. Em seguida, o
            // programa deve exibir o resultado da opção indicada pelo usuário e perguntar ao usuário se ele deseja voltar ao
            // menu principal. Caso a resposta seja  ́S ́ ou  ́s ́, deverá voltar ao menu, caso contrário deverá encerrar o programa.

            int opcao, numero1, numero2, resultado;
            char resposta;

            do
            {
                Console.WriteLine("1 – Adição");
                Console.WriteLine("2 – Subtração");
                Console.WriteLine("3 – Multiplicação");
                Console.WriteLine("4 – Divisão");
                Console.WriteLine("Informe a opção: ");
                opcao = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o primeiro numero: ");
                numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                numero2 = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        resultado = numero1 + numero2;
                        Console.WriteLine("O resultado da soma é: " + resultado);
                        break;
                    case 2:
                        resultado = numero1 - numero2;
                        Console.WriteLine("O resultado da subtração é: " + resultado);
                        break;
                    case 3:
                        resultado = numero1 * numero2;
                        Console.WriteLine("O resultado da multiplicação é: " + resultado);
                        break;
                    case 4:
                        resultado = numero1 / numero2;
                        Console.WriteLine("O resultado da divisão é: " + resultado);
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Deseja voltar ao menu principal? (S/N)");
                resposta = char.Parse(Console.ReadLine());
            } while (resposta == 'S' || resposta == 's');
        }

        static void exercicio38()
        {
            // Faça um programa que leia as variáveis C e N, respectivamente código e número de horas trabalhadas de um
            // operário. E calcule o salário sabendo-se que ele ganha R$ 10,00 por hora. Quando o número de horas exceder a
            // 50, calcule o excesso de pagamento armazenando-o na variável E, caso contrário zerar tal variável. A hora
            // excedente de trabalho vale R$ 20,00. No final do processamento imprimir o salário total e o salário excedente. O
            //     programa só deve parar de rodar quando o usuário responder "S" na seguinte pergunta, "Deseja encerrar o
            // programa?".

            int codigo, horasTrabalhadas, salario, salarioExcedente;
            char resposta;

            do
            {
                Console.WriteLine("Digite o codigo do operario: ");
                codigo = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o numero de horas trabalhadas: ");
                horasTrabalhadas = int.Parse(Console.ReadLine());

                if (horasTrabalhadas > 50)
                {
                    salario = horasTrabalhadas * 10;
                    salarioExcedente = (horasTrabalhadas - 50) * 20;
                }
                else
                {
                    salario = horasTrabalhadas * 10;
                    salarioExcedente = 0;
                }

                Console.WriteLine("O salario total é: " + salario);
                Console.WriteLine("O salario excedente é: " + salarioExcedente);
                Console.WriteLine("Deseja encerrar o programa? (S/N)");
                resposta = char.Parse(Console.ReadLine());
            } while (resposta == 'N' || resposta == 'n');
        }

        static void exercicio39()
        {
            // Faça um programa que leia um número inteiro e mostre uma mensagem indicando se este número é par ou ímpar,
            // e se é positivo ou negativo. O programa só deve parar de rodar quando o usuário responder "S" na seguinte
            // pergunta, "Deseja encerrar o programa?" .

            int num;
            char resposta;

            do
            {
                Console.WriteLine("Digite um numero: ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("O numero é par");
                }
                else
                {
                    Console.WriteLine("O numero é impar");
                }

                if (num > 0)
                {
                    Console.WriteLine("O numero é positivo");
                }
                else
                {
                    Console.WriteLine("O numero é negativo");
                }

                Console.WriteLine("Deseja encerrar o programa? (S/N)");
                resposta = char.Parse(Console.ReadLine());
            } while (resposta == 'N' || resposta == 'n');
        }

        static void exercicio40()
        {
            // A Secretaria de Meio Ambiente que controla o índice de poluição mantém 03 grupos de indústrias que são
            // altamente poluentes do meio ambiente. O índice de poluição aceitável varia de 0,05 até 0,25. Se o índice sobe
            // para 0,3 as indústrias do 1o grupo são intimadas a suspenderem suas atividades, se o índice crescer para 0,4 as
            // industrias do 1o e 2o grupo são intimadas a suspenderem suas atividades, se o índice atingir 0,5 todos os grupos
            // devem ser notificados a paralisarem suas atividades. Faça um programa que leia o índice de poluição medido e
            // emita a notificação adequada aos diferentes grupos de empresas. O algoritmo só deve parar de rodar quando o
            // usuário responder "S" na seguinte pergunta, "Deseja encerrar o programa?".

            double indice;
            char resposta;

            do
            {
                Console.WriteLine("Digite o indice de poluição: ");
                indice = double.Parse(Console.ReadLine());

                if (indice >= 0.05 && indice <= 0.25)
                {
                    Console.WriteLine("Indice aceitavel");
                }
                else if (indice >= 0.3 && indice < 0.4)
                {
                    Console.WriteLine("Industrias do 1o grupo devem suspender suas atividades");
                }
                else if (indice >= 0.4 && indice < 0.5)
                {
                    Console.WriteLine("Industrias do 1o e 2o grupo devem suspender suas atividades");
                }
                else if (indice >= 0.5)
                {
                    Console.WriteLine("Todos os grupos devem suspender suas atividades");
                }

                Console.WriteLine("Deseja encerrar o programa? (S/N)");
                resposta = char.Parse(Console.ReadLine());
            } while (resposta == 'N' || resposta == 'n');
        }

        static void exercicio41()
        {
            // Faça um programa que dada a idade de um nadador, classifique-o em uma das seguintes categorias:
            // - Infantil A = 5 a 7 anos
            // - Infantil B = 8 a 11 anos
            // - Juvenil A = 12 a 13 anos
            // - Juvenil B = 14 a 17 anos
            // - Adultos = Maiores de 18 anos

            int idade;
            char resposta;

            do
            {
                Console.WriteLine("Digite a idade do nadador: ");
                idade = int.Parse(Console.ReadLine());

                if (idade >= 5 && idade <= 7)
                {
                    Console.WriteLine("Infantil A");
                }
                else if (idade >= 8 && idade <= 11)
                {
                    Console.WriteLine("Infantil B");
                }
                else if (idade >= 12 && idade <= 13)
                {
                    Console.WriteLine("Juvenil A");
                }
                else if (idade >= 14 && idade <= 17)
                {
                    Console.WriteLine("Juvenil B");
                }
                else if (idade >= 18)
                {
                    Console.WriteLine("Adulto");
                }

                Console.WriteLine("Deseja encerrar o programa? (S/N)");
                resposta = char.Parse(Console.ReadLine());
            } while (resposta == 'N' || resposta == 'n');
        }

        static void exercicio42()
        {
            // Faça um programa que determine o maior e o menor entre N números lidos. A condição de parada é a entrada de
            // um valor 0, ou seja, o programa deve ficar executando até que a entrada seja igual a 0 (ZERO).

            int num, maior = 0, menor = 0;
            char resposta;

            do
            {
                Console.WriteLine("Digite um numero: ");
                num = int.Parse(Console.ReadLine());

                if (num > maior)
                {
                    maior = num;
                }
                else if (num < menor)
                {
                    menor = num;
                }

                Console.WriteLine("Deseja encerrar o programa? (S/N)");
                resposta = char.Parse(Console.ReadLine());
            } while (resposta == 'N' || resposta == 'n');

            Console.WriteLine("O maior numero é: " + maior);
            Console.WriteLine("O menor numero é: " + menor);
        }

        static void exercicio43()
        {
            // Uma rainha requisitou os serviços de um monge e disse-lhe que pagaria qualquer preço. O monge, necessitando
            // de alimentos, indagou à rainha sobre o pagamento, se poderia ser feito com grãos de trigo dispostos em um
            // tabuleiro de xadrez, de tal forma que o primeiro quadro deveria conter apenas um grão e os quadros
            // subseqüentes, o dobro do quadro anterior. A rainha achou o trabalho barato e pediu que o serviço fosse
            // executado, sem se dar conta de que seria impossível efetuar o pagamento. Faça um programa para calcular o
            // número de grãos que o monge esperava receber.

            int numeroQuadros = 64; // Número total de quadros no tabuleiro de xadrez
            ulong graos = 1;
            ulong graosTotais = 1;

            for (int quadro = 2; quadro <= numeroQuadros; quadro++)
            {
                graos *= 2;
                graosTotais += graos;
            }

            Console.WriteLine("O monge esperava receber um total de {0} grãos.", graosTotais);
        }

        static void exercicio44()
        {
            // Faça um programa que exiba as opções:
            // 1 – Conversão de Graus Celsius em Graus Fahrenheit
            // 2 – Conversão de Graus Fahrenheit em Graus Celsius
            // 3 – Peso ideal do homem
            // 4 – Peso ideal da mulher
            // O programa só deve encerrar quando o usuário digitar  ́S ́ para a pergunta “Deseja encerrar o programa?”
            // Obs.: Nas opções 3 e 4 informar se o usuário está acima ou abaixo do peso ideal.

            int opcao;
            char resposta;

            do
            {
                Console.WriteLine("Digite a opção desejada: ");
                Console.WriteLine("1 – Conversão de Graus Celsius em Graus Fahrenheit");
                Console.WriteLine("2 – Conversão de Graus Fahrenheit em Graus Celsius");
                Console.WriteLine("3 – Peso ideal do homem");
                Console.WriteLine("4 – Peso ideal da mulher");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite a temperatura em Celsius: ");
                        double celsius = double.Parse(Console.ReadLine());
                        double fahrenheit = (celsius * 9 / 5) + 32;
                        Console.WriteLine("A temperatura em Fahrenheit é: " + fahrenheit);
                        break;
                    case 2:
                        Console.WriteLine("Digite a temperatura em Fahrenheit: ");
                        fahrenheit = double.Parse(Console.ReadLine());
                        celsius = (fahrenheit - 32) * 5 / 9;
                        Console.WriteLine("A temperatura em Celsius é: " + celsius);
                        break;
                    case 3:
                        Console.WriteLine("Digite a altura: ");
                        double altura = double.Parse(Console.ReadLine());
                        double pesoIdeal = (72.7 * altura) - 58;
                        Console.WriteLine("O peso ideal é: " + pesoIdeal);
                        break;
                    case 4:
                        Console.WriteLine("Digite a altura: ");
                        altura = double.Parse(Console.ReadLine());
                        pesoIdeal = (62.1 * altura) - 44.7;
                        Console.WriteLine("O peso ideal é: " + pesoIdeal);
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Deseja encerrar o programa? (S/N)");
                resposta = char.Parse(Console.ReadLine());
            } while (resposta == 'N' || resposta == 'n');
        }

        static void exercicio45()
        {
            // Dada uma seqüência de n números (vetor de inteiros), imprimi-la na ordem inversa que foi realizada a leitura.

            int[] vetor = new int[10];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um numero: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }

        static void exercicio46()
        {
            // Dados dois vetores x e y, ambos com n elementos, determinar o produto escalar desses vetores. Ou seja, realizar a
            // soma de todos dos resultados da multiplicação de x[i] por y[i].

            int[] vetorX = new int[10];
            int[] vetorY = new int[10];
            int produtoEscalar = 0;

            for (int i = 0; i < vetorX.Length; i++)
            {
                Console.WriteLine("Digite um numero para o vetor X: ");
                vetorX[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetorY.Length; i++)
            {
                Console.WriteLine("Digite um numero para o vetor Y: ");
                vetorY[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetorX.Length; i++)
            {
                produtoEscalar += vetorX[i] * vetorY[i];
            }

            Console.WriteLine("O produto escalar é: " + produtoEscalar);
        }

        static void exercicio47()
        {
            // Considere um vetor de 10 números inteiros positivos maiores que zero e um único número inteiro, também positivo
            // e maior que zero. Faça um programa para:
            // a. ler pelo teclado o vetor;
            // b. ler pelo teclado o número X;
            // c. dizer quantos números no vetor são maiores que X, menores que X e iguais a X.

            int[] vetor = new int[10];
            int numeroX, maior = 0, menor = 0, igual = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um numero: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite um numero X: ");
            numeroX = int.Parse(Console.ReadLine());

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] > numeroX)
                {
                    maior++;
                }
                else if (vetor[i] < numeroX)
                {
                    menor++;
                }
                else
                {
                    igual++;
                }
            }

            Console.WriteLine("Quantidade de numeros maiores que X: " + maior);
        }

        static void exercicio48()
        {
            // Uma agência de publicidade pediu à agência de modelos Luz & Beleza para encontrar uma modelo que tenha
            // idade entre 18 e 20 anos para participar de uma campanha publicitária milionária de produtos de beleza. Foram
            // inscritas 20 candidatas e, ao se inscreverem, forneceram nome e idade. Tais informações foram armazenadas em
            // 2 vetores distintos. Faça um programa para imprima o vetor que contém os nomes das candidatas aptas a
            // concorrer a uma vaga para a campanha milionária.

            string[] nome = new string[20];
            int[] idade = new int[20];

            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine("Digite o nome da candidata: ");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Digite a idade da candidata: ");
                idade[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < nome.Length; i++)
            {
                if (idade[i] >= 18 && idade[i] <= 20)
                {
                    Console.WriteLine("Nome: " + nome[i]);
                }
            }
        }

        static void exercicio49()
        {
            // Leia 2 vetores de inteiros V1 e V2 de N componentes cada (no máximo 50). Determine e imprima quantas vezes
            // que V1 e V2 possuem valores idênticos nas mesmas posições.

            int[] vetor1 = new int[50];
            int[] vetor2 = new int[50];
            int contador = 0;

            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine("Digite um numero para o vetor 1: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.WriteLine("Digite um numero para o vetor 2: ");
                vetor2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetor1.Length; i++)
            {
                if (vetor1[i] == vetor2[i])
                {
                    contador++;
                }
            }

            Console.WriteLine("Quantidade de numeros iguais: " + contador);
        }

        static void exercicio50()
        {
            // Fazer um programa que sorteie um número de 0 a 100 e que permita que o usuário (sem conhecer o número
            // sorteado) tente acertar. Caso não acerte, o programa deve imprimir uma mensagem informando se o número
            // sorteado é maior ou menor que a tentativa feita. Ao acertar o número, o programa deve imprimir a quantidade de
            // tentativas feitas.

            Random random = new Random();
            int numeroSorteado = random.Next(0, 100);
            int numeroTentativa, contador = 0;

            do
            {
                Console.WriteLine("Digite um numero: ");
                numeroTentativa = int.Parse(Console.ReadLine());
                contador++;

                if (numeroTentativa > numeroSorteado)
                {
                    Console.WriteLine("O numero sorteado é menor");
                }
                else if (numeroTentativa < numeroSorteado)
                {
                    Console.WriteLine("O numero sorteado é maior");
                }
            } while (numeroTentativa != numeroSorteado);

            Console.WriteLine("Quantidade de tentativas: " + contador);
        }

        static void exercicio51()
        {
            // Fazer um programa para ler uma quantidade N de alunos. Ler a nota de cada um dos N alunos e calcular a média
            // aritmética das notas. Contar quantos alunos estão com a nota acima de 7.0. Obs.: Se nenhum aluno tirou nota
            // acima de 5.0, imprimir mensagem: Não há nenhum aluno com nota acima de 5.

            int alunosQuantidade, contador = 0;
            double nota, media, soma = 0;

            Console.WriteLine("Digite a quantidade de alunos: ");
            alunosQuantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < alunosQuantidade; i++)
            {
                Console.WriteLine("Digite a nota do aluno: ");
                nota = double.Parse(Console.ReadLine());
                soma += nota;

                if (nota > 7)
                {
                    contador++;
                }
            }

            media = soma / alunosQuantidade;

            if (contador == 0)
            {
                Console.WriteLine("Não há nenhum aluno com nota acima de 7.");
            }
            else
            {
                Console.WriteLine("Quantidade de alunos com nota acima de 7: " + contador);
            }

            Console.WriteLine("Media das notas: " + media);
        }

        static void exercicio52()
        {
            // Fazer um programa ler um vetor de inteiros e positivos e imprimir quantas vezes aparece o número 1, 3 e 4, nesta
            // ordem. O vetor terá no máximo 100 posições. Sair do programa quando for digitado -1.

            int[] vetor = new int[100];
            int contador1 = 0, contador3 = 0, contador4 = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um numero: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if (vetor[i] == 1)
                {
                    contador1++;
                }
                else if (vetor[i] == 3)
                {
                    contador3++;
                }
                else if (vetor[i] == 4)
                {
                    contador4++;
                }

                if (vetor[i] == -1)
                {
                    break;
                }
            }

            Console.WriteLine("Quantidade de 1: " + contador1);
            Console.WriteLine("Quantidade de 3: " + contador3);
            Console.WriteLine("Quantidade de 4: " + contador4);
        }

        static void exercicio53()
        {
            // Durante uma corrida de automóveis com N voltas de duração foram anotados para um piloto, na ordem, os tempos
            // registrados em cada volta. Fazer um programa para ler os tempos das N voltas, calcular e imprimir: i. melhor tempo;
            // ii. a volta em que o melhor tempo ocorreu;
            // iii. tempo médio das N voltas;

            int quantidadeVoltas, melhorTempo = 0, voltaMelhorTempo = 0;
            double tempoMedio, soma = 0;

            Console.WriteLine("Digite a quantidade de voltas: ");
            quantidadeVoltas = int.Parse(Console.ReadLine());

            int[] vetor = new int[quantidadeVoltas];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite o tempo da volta: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    melhorTempo = vetor[i];
                    voltaMelhorTempo = i + 1;
                }
                else if (vetor[i] < melhorTempo)
                {
                    melhorTempo = vetor[i];
                    voltaMelhorTempo = i + 1;
                }

                soma += vetor[i];
            }

            tempoMedio = soma / quantidadeVoltas;

            Console.WriteLine("Melhor tempo: " + melhorTempo);
            Console.WriteLine("Volta do melhor tempo: " + voltaMelhorTempo);
            Console.WriteLine("Tempo medio: " + tempoMedio);
        }

        static void exercicio54()
        {
            // Dado dois vetores, A (5 elementos) e B (8 elementos), faça um programa em C que imprima todos os elementos comuns aos dois vetores.

            int[] vetorA = new int[5];
            int[] vetorB = new int[8];

            for (int i = 0; i < vetorA.Length; i++)
            {
                Console.WriteLine("Digite um numero: ");
                vetorA[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetorB.Length; i++)
            {
                Console.WriteLine("Digite um numero: ");
                vetorB[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetorA.Length; i++)
            {
                for (int j = 0; j < vetorB.Length; j++)
                {
                    if (vetorA[i] == vetorB[j])
                    {
                        Console.WriteLine("Numero comum: " + vetorA[i]);
                    }
                }
            }
        }

        static void exercicio55()
        {
            // Fazer um programa que leia uma frase de até 50 caracteres e imprima a frase sem os espaços em branco. Imprimir 
            // também a quantidade de espaços em branco da frase.

            string frase;
            int contador = 0;

            Console.WriteLine("Digite uma frase: ");
            frase = Console.ReadLine();

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == ' ')
                {
                    contador++;
                }
            }

            Console.WriteLine("Frase sem espacos: " + frase.Replace(" ", ""));
            Console.WriteLine("Quantidade de espacos: " + contador);
        }

        static void exercicio56()
        {
            // Fazer um programa para ler um vetor de inteiros positivos de 50 posições. Imprimir a quantidade de números pares e de múltiplos de 5.

            int[] vetor = new int[50];
            int contadorPar = 0, contadorMultiplo5 = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um numero: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if (vetor[i] % 2 == 0)
                {
                    contadorPar++;
                }

                if (vetor[i] % 5 == 0)
                {
                    contadorMultiplo5++;
                }
            }

            Console.WriteLine("Quantidade de numeros pares: " + contadorPar);
            Console.WriteLine("Quantidade de multiplos de 5: " + contadorMultiplo5);
        }

        static void exercicio57()
        {
            // Fazer um programa que leia uma frase e imprima somente as vogais.

            string frase;

            Console.WriteLine("Digite uma frase: ");
            frase = Console.ReadLine();

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == 'a' || frase[i] == 'e' || frase[i] == 'i' || frase[i] == 'o' || frase[i] == 'u')
                {
                    Console.WriteLine("Vogal: " + frase[i]);
                }
            }
        }

        static void exercicio58()
        {
            // Fazer um programa para armazenar em um vetor, vários números inteiros e positivos e calcular a média. Imprimir
            // também o maior. A quantidade de números lidos será definida pelo usuário.

            int quantidadeNumeros, maior = 0, soma = 0;
            double media;

            Console.WriteLine("Digite a quantidade de numeros: ");
            quantidadeNumeros = int.Parse(Console.ReadLine());

            int[] vetor = new int[quantidadeNumeros];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um numero: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    maior = vetor[i];
                }
                else if (vetor[i] > maior)
                {
                    maior = vetor[i];
                }

                soma += vetor[i];
            }

            media = soma / quantidadeNumeros;

            Console.WriteLine("Maior numero: " + maior);
            Console.WriteLine("Media: " + media);
        }

        static void exercicio59()
        {
            // Escreva um programa que solicite dois caracteres de A a Z ao usuário e imprima o número de caracteres existente
            // entre eles. Assuma que o usuário digite os 2 caracteres em ordem alfabética. Caso não o estejam, emitir mensagem de erro.
            // Exemplo: Digite 2 caracteres: j t O numero de caracteres entre eles é: 9

            char letra1, letra2;
            int contador = 0;

            Console.WriteLine("Digite a primeira uma letra: ");
            letra1 = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda outra letra: ");
            letra2 = char.Parse(Console.ReadLine());

            if (letra1 < letra2)
            {
                for (int i = letra1 + 1; i < letra2; i++)
                {
                    contador++;
                }

                Console.WriteLine("Numero de caracteres entre eles: " + contador);
            }
            else
            {
                Console.WriteLine("Erro!");
            }
        }

        static void exercicio60()
        {
            // Escreva um programa que retorne o número do quadrante (1,2,3 ou 4) através de um método chamado
            //     VERIFICA_QUADRANTE, que deve receber um valor para x e um valor para y.
            //     Quadrantes
            //            x |
            //              |
            //      2º | 1º
            //              |
            //
            //     y ------------------------------
            //
            //              |
            //              |
            //     3º | 4º
            //              |

            int x, y;

            Console.WriteLine("Digite o valor de x: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de y: ");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Quadrante: " + verificaQuadrante(x, y));
        }

        static int verificaQuadrante(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            else if (x < 0 && y > 0)
            {
                return 2;
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else if (x > 0 && y < 0)
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }

        static void exercicio61()
        {
            // Escreva um programa que calcule e retorne o salário atualizado através do método REAJUSTE. O método deve
            // receber o valor do salário e o índice de reajuste.

            double salario, indiceReajuste;

            Console.WriteLine("Digite o salario: ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o indice de reajuste: ");
            indiceReajuste = double.Parse(Console.ReadLine());

            Console.WriteLine("Salario reajustado: " + salario + (salario * (indiceReajuste / 100)));
        }

        static void exercicio62()
        {
            // Escreva um programa que calcule e retorne o valor da hipotenusa através do método HIPOTENUSA. O método
            // recebe o valor da base e da altura de um triângulo.

            // Fórmulas: hipotenusa2 = base2 + altura2
            //     base x altura
            //         área = ----------------------

            double baseTriangulo, alturaTriangulo;

            Console.WriteLine("Digite a base do triangulo: ");
            baseTriangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do triangulo: ");
            alturaTriangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Hipotenusa: " + hipotenusa(baseTriangulo, alturaTriangulo));
        }

        static double hipotenusa(double baset, double alturat)
        {
            double hipo;

            hipo = Math.Sqrt(Math.Pow(baset, 2) + Math.Pow(alturat, 2));

            return hipo;
        }

        static void exercicio63()
        {
            // Escreva um programa que verifique se um número é par ou ímpar através de um método chamado VERIFICA. O
            // método deverá receber um número inteiro (n) e deverá retornar a mensagem “PAR” ou “ÍMPAR”.

            int numero;

            Console.WriteLine("Digite um numero: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine(verifica(numero));
        }

        static string verifica(int numero)
        {
            if (numero % 2 == 0)
            {
                return "PAR";
            }
            else
            {
                return "IMPAR";
            }
        }

        static void exercicio64()
        {
            // Escreva um programa que deverá ter as seguintes opções:
            // 1 - Carregar Vetor
            // 2 - Listar Vetor
            // 3 - Exibir apenas os números pares do vetor
            // 4 - Exibir apenas os números ímpares do vetor
            // 5 - Exibir a quantidade de números pares existem nas posições ímpares do vetor
            // 6 - Exibir a quantidade de números ímpares existem nas posições pares do vetor
            // 7 - Sair
            // Deverá ser implementado um método para realizar cada uma das opções de 1 a 6.

            int[] vetor = new int[10];
            int opcao = 0;
            while (opcao != 7)
            {
                Console.WriteLine("\nDigite a opção desejada: ");
                Console.WriteLine("1 - Carregar Vetor");
                Console.WriteLine("2 - Listar Vetor");
                Console.WriteLine("3 - Exibir apenas os números pares do vetor");
                Console.WriteLine("4 - Exibir apenas os números ímpares do vetor");
                Console.WriteLine("5 - Exibir a quantidade de números pares existentes nas posições ímpares do vetor");
                Console.WriteLine("6 - Exibir a quantidade de números ímpares existentes nas posições pares do vetor");
                Console.WriteLine("7 - Sair");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        CarregarVetor(vetor);
                        break;
                    case 2:
                        ListarVetor(vetor);
                        break;
                    case 3:
                        ExibirPares(vetor);
                        break;
                    case 4:
                        ExibirImpares(vetor);
                        break;
                    case 5:
                        ExibirParesImpares(vetor);
                        break;
                    case 6:
                        ExibirImparesPares(vetor);
                        break;
                    case 7:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        public static void CarregarVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite o valor da posição " + i + ": ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void ListarVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Valor da posição " + i + ": " + vetor[i]);
            }
        }

        public static void ExibirPares(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Console.WriteLine("Valor da posição " + i + ": " + vetor[i]);
                }
            }
        }

        public static void ExibirImpares(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 != 0)
                {
                    Console.WriteLine("Valor da posição " + i + ": " + vetor[i]);
                }
            }
        }

        public static void ExibirParesImpares(int[] vetor)
        {
            int quantidadePares = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (i % 2 != 0 && vetor[i] % 2 == 0)
                {
                    quantidadePares++;
                }
            }

            Console.WriteLine("Quantidade de números pares nas posições ímpares: " + quantidadePares);
        }

        public static void ExibirImparesPares(int[] vetor)
        {
            int quantidadeImpares = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (i % 2 == 0 && vetor[i] % 2 != 0)
                {
                    quantidadeImpares++;
                }
            }

            Console.WriteLine("Quantidade de números ímpares nas posições pares: " + quantidadeImpares);
        }
    }
}