int[] array1; 
array1 = new int[] {0,1,2,3,4,5,6,7,8,9};

List<string> names = new List<string>();

names.Add("Tim");
names.Add("Martin");
names.Add("Nikki");
names.Add("Sara"); 

bool[] array3;
array3 = new bool[10];

for(int i = 0; i < array3.Length; i++)
{
    array3[i] = i % 2  == 0;
}


List<string> flavors = new List<string>();

flavors.Add("Chocolate");
flavors.Add("Vanilla");
flavors.Add("cookie dough");
flavors.Add("strawberry"); 
flavors.Add("banana");

Console.WriteLine("Amount of Flavours avaliable -" + flavors.Count);
Console.WriteLine(flavors[2]);
// flavors.Remove(flavors[2]);
flavors.RemoveAt(2);
Console.WriteLine("Amount of Flavours avaliable -" + flavors.Count);


Dictionary<string,string> profile = new Dictionary<string,string>();
Random rand = new Random();

for( int i = 0; i< names.Count; i++)
{
    int randomIndex = rand.Next(flavors.Count);
    string randomFlavor = flavors[randomIndex];
    profile[names[i]] = randomFlavor;
}

foreach (var pair in profile)
{
    Console.WriteLine(pair.Key + " gets " + pair.Value + " flavoured Icecream!");
}