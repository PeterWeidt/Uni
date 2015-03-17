
const double kphconv = 0.62137;
double kph = 0.0, MPH = 0.0, calculate = 0.0, result = 0.0;
Console.WriteLine("KPH" + "\t\t" + "MPH");

for (double kph = 1; kph <=11; kph++)
{ 
	result = (kph * 10);
	MPH = ( result * 0.62137 );
	Console.WriteLine(result +"\t\t"+ MPH);
}


