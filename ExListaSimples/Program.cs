using ExListaSimples;

ListItem list = new();

int count = 0;
Random random = new Random();
Item item;

for(count = 0; count < 20; count++)
{
    Console.Clear();
    item = new((random.Next(100)));
    list.InsertItem(item);
    list.PrintList();
    Console.WriteLine("Pressione Enter para continuar");
    Console.ReadLine();
}