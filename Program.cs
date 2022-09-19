
Console.Write("Введите номер: ");
int numberA = int.Parse(Console.ReadLine());

int[] massiv = new int[numberA];

for(int i = 0; i< massiv.Length; i++)
{
	massiv[i] = new Random().Next(1, 100);
	Console.Write(massiv[i] + ", ");
}


PrintNeChet(massiv);

void PrintNeChet(int[] array)
{
	int result = 0;
	for(int index = 1; index < array.Length; index = index + 2)
	{
		result = result + array[index];
	}
	Console.WriteLine("Сумма всех нечетных позиций будет ровна: " + result);
}


