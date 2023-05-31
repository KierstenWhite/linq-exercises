// Find the words in the collection that start with the letter 'L'
List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

IEnumerable<string> LFruits = from fruit in fruits
where fruit.StartsWith("L")
select fruit;

foreach (string f in LFruits)
{
    Console.WriteLine($"{f}");
}