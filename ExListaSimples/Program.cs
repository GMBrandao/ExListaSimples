using ExListaSimples;

ListItem list = new();

int x, count = 0;
Random random = new Random();
Item item;

for(count = 0; count < 20; count++)
{
    list.InsertItem(new((random.Next(100))));
    list.PrintList();
    Console.ReadLine();
}