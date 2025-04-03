/*
Data de resolução: 02/04/2025.
Código do problema: 1004

Leia dois valores inteiros. A seguir, calcule o produto entre estes dois valores e atribua esta operação à variável PROD. A seguir mostre a variável PROD com mensagem correspondente.   

Entrada
O arquivo de entrada contém 2 valores inteiros.

Saída
Imprima a mensagem "PROD" e a variável PROD conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade. Não esqueça de imprimir o fim de linha após o produto, caso contrário seu programa apresentará a mensagem: “Presentation Error”.

*/

using System;

class URI{
    public static int multiplicaInteiros(int A, int B){
        return A * B;
    }
    public static void Main(string[] args){
        int A = Convert.ToInt32(Console.ReadLine());
        int B = Convert.ToInt32(Console.ReadLine());

        int PROD = multiplicaInteiros(A, B);

        Console.WriteLine($"PROD = {PROD}");

    }
}