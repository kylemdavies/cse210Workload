Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
a1.GetSummary();
Console.WriteLine("----------------------------");
MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
a2.GetSummary();
a2.GetHomeworkList();
Console.WriteLine("----------------------------");
WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
a3.GetSummary();
a3.GetWritingInformation();