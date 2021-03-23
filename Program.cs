using System;

namespace Métodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Métodos, también conocidos como "funciones"
            //Los métodos son bloques de código que solo se ejecutan cuando son llamados
            //En los métodos si se quiere se puede pasar datos, conocidos como parámetros
            //¿Por qué utilizar métodos? Para reutilizar código
            //Se declara una vez, y se podrá utilizar cuantas veces se quiera


            //Estas son las formas en las cuales se puede declarar un método

            //1er ejemplo   //Sin parámetros

            //int sumaNumeros()
            //{
            //    int num1 = 7;
            //    int num2 = 9;
            //    int resultado = num1 + num2;
            //    return resultado;
            //}


            //2do ejemplo //Con parámetros

            //int sumaNumeros(int num1, int num2)
            //{
            //    int resultado = num1 + num2;
            //    return resultado;
            //}
            //Console.WriteLine(sumaNumeros(6,6));


            //3er ejemplo

            //void sumaNumeros()
            //{
            //    int num1 = 7;
            //    int num2 = 9;
            //    int resultado = num1 + num2;
            //    Console.WriteLine(resultado);
            //}      


            //4to ejemplo

            //void sumaNumeros(int num1, int num2)
            //{
            //    Console.WriteLine($"La suma de los números es: {num1 + num2}");
            //}
            //sumaNumeros(6,6);


            //5to ejemplo

            //Este ejemplo nos muestra una forma más simplificada de declarar un método
            //(OJO) solo funciona cuando el método contiene una línea de código

            //int sumaNumeros(int num1, int num2) => num1 + num2;



            ////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Sobrecarga de métodos
            //Es cuando hay dos o más métodos en un mismo ámbito/clase con el mismo nombre

            //Ejemplo

            //Console.WriteLine(NumS(6, 6, 6, 6));


            //static int NumS(int num1, int num2)
            //{
            //    return num1 + num2;
            //}

            //static double NumS(int numero1, double numero2)
            //{
            //    return numero1 * numero2;
            //}

            //static int NumS(int valor1, int valor2, int valor3, int valor4)
            //{
            //    return (valor1 + valor2) - (valor3 * valor4);
            //}



            //Parámetros opcionales
            //Ejemplo


            //int valor1 = 7;
            //double valor2 = 5.2;
            //double valor3 = 8.3;

            //Console.WriteLine(Suma(valor1, valor2));

            //static double Suma(int valor1, double valor2, double valor3 = 0) => valor1 + valor2 + valor3;
        }
    }
}   
