// Date, Time, Miles
Running run = new Running("11/03/22", 30, 3.0f);
run.DisplaySummaryMPH();
run.DisplaySummaryKPH();
Console.WriteLine("--------------------------------------------");
// Date, Time, Miles
Cycling bike = new Cycling("11/03/22", 30, 3.0f);
bike.DisplaySummaryMPH();
bike.DisplaySummaryKPH();
Console.WriteLine("--------------------------------------------");
// Date, Time, Laps
Swimming swim = new Swimming("11/03/22", 30, 10.0f);
swim.DisplaySummaryMPH();
swim.DisplaySummaryKPH();