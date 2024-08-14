using System.Text;

Console.OutputEncoding = Encoding.Unicode;

int[] array = new int[10000000];
Random random = new Random();
for (int i = 0; i < array.Length; i++) {
    array[i] = random.Next();
}
var odds = array.AsParallel().Where( x => x % 2 == 1 );

Console.WriteLine("Перші 10 непарних:");

var counter = 0;

foreach(var odd in odds) {

    Console.WriteLine(odd);

    counter++;

    if (counter ==10)
        break;
    
}