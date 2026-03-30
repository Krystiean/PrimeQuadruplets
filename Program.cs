using System.Globalization;

PrimaryNumber primaryNumber = new PrimaryNumber();

Console.WriteLine("Podaj maksymalny zakres: ");
string checkMaxIntervalNumber = Console.ReadLine();
int maxInterval = 0;

if (Int32.TryParse(checkMaxIntervalNumber, out maxInterval))
{
    primaryNumber.Calculate(maxInterval); 
}
else
{
    Console.WriteLine("Incorrect number, try again");
}







