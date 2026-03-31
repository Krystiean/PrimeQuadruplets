
public class PrimaryNumber()
{
    public void Calculate(int maxInterval)
    {
        List<int> quadrupleNumbers = new List<int>();

        bool[] isPrime = new bool[maxInterval + 1];

        for (int number = 2; number <= maxInterval; number++)
        {
            isPrime[number] = true;
        }

        for (int number = 2; number <= maxInterval; number++)
        {
            if (isPrime[number])
            {
                for (int numberMultiples = number * number; numberMultiples <= maxInterval; numberMultiples += number)
                {
                    isPrime[numberMultiples] = false;
                }

                quadrupleNumbers.Add(number);
            }
        }

        foreach (int element in quadrupleNumbers)
        {
                Console.WriteLine(element);
        }
    }
}
