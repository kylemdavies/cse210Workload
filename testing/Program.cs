class Program
{
    static void Main(string[] args)
    {
        List<MyClass> myList = new List<MyClass>
        {
            new MyClass(1, "Item 1"),
            new MyClass(2, "Item 2"),
            new MyClass(3, "Item 3")
        };

        // Save the list to a file
        ListFileHandler<MyClass>.SaveListToFile("myList.txt", myList);

        // Load the list from the file
        List<MyClass> loadedList = ListFileHandler<MyClass>.LoadListFromFile("myList.txt");

        // Print the loaded list
        foreach (MyClass item in loadedList)
        {
            Console.WriteLine($"ID: {item.ID}, Name: {item.Name}");
        }
    }
}
