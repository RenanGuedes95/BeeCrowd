/*
Data de resolução: 02/04/2025.
Código do problema: 1003
Leia dois valores inteiros, no caso para variáveis A e B. A seguir, calcule a soma entre elas e atribua à variável SOMA. A seguir escrever o valor desta variável.

Entrada
O arquivo de entrada contém 2 valores inteiros.

Saída
Imprima a mensagem "SOMA" com todas as letras maiúsculas, com um espaço em branco antes e depois da igualdade seguido pelo valor correspondente à soma de A e B. Como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".


*/

using System;

class URI{

    public static int somaDoisNumeros(int A, int B){
        return A + B;
    }
    public static void Main(string[] args){
        int A = Convert.ToInt32(Console.ReadLine());
        int B = Convert.ToInt32(Console.ReadLine());

        int SOMA = somaDoisNumeros(A, B);    

        Console.WriteLine($"SOMA = {SOMA}");
    }
}