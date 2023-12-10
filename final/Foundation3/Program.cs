Lectures Ted = new Lectures("Tedx", "Ted will talk about what he has learned in his studies.", "12/11/23", "9:30AM", "123 Sesame St. Imagination, NO 01969", "Ted", 540);
Ted.StandardDisplay();
Ted.FullDisplay();
Ted.ShortDisplay();
Console.WriteLine("------------------------------------------------------------------------------");
OGathering Party = new OGathering("Party", "Come hang out with a bunch of friends!", "12/11/23", "6PM", "4058 Jacobs Ave. Somewhere, IDK 12345", "Sunny");
Party.StandardDisplay();
Party.FullDisplay();
Party.ShortDisplay();
Console.WriteLine("------------------------------------------------------------------------------");
Receptions Wedding = new Receptions("JacobxHannah Wedding", "Jacob & Hannah are getting hitched!", "12/11/23", "10AM", "2399 Clip St. Bluetooth, JBL 98765", "JxH4eva@gmail.com");
Wedding.StandardDisplay();
Wedding.FullDisplay();
Wedding.ShortDisplay();
Console.WriteLine("------------------------------------------------------------------------------");
// If I were to do an application like this myself I would have used polymorphism for the Full and Short Displays