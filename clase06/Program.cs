/* 
suma de num
mayor
menor
promedio
mostrar lista
mostrar cálculos
*/

int[]lista = new int[10];

Console.WriteLine("Ingrese 10 números");
for (int i = 0; i < 10; i++)
{
        lista[i] = int.Parse(Console.ReadLine());
}

// Cálculos
int suma = lista.Sum();
int mayor = lista.Max();
int menor = lista.Min();
double promedio = lista.Average();

// Muestro resultados
Console.WriteLine("Lista de números ingresados: ");
foreach (var item in lista)
{
    Console.Write(item.ToString()+" ");
}
Console.Write("\nSumatoria: " + suma+
              "\nMayor: "+ mayor+
              "\nMenor: "+ menor+
              "\nPromedio: "+promedio);

