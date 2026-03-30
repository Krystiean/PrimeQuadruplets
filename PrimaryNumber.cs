
public class PrimaryNumber()
{
    public void Calculate(int maxInterval)
    {
        List<int> quadrupleNumbers = new List<int>();

    int i = 2;
    quadrupleNumbers.Add(i);


    for (i = 3; i <= maxInterval; i++)
    {
        bool firstNumber = true;

        for (int j = 2; j < i; j++)
        {
            if (i % j == 0)
            {
                firstNumber = false;
                break;
            }
        }

        if (firstNumber)
        {
            quadrupleNumbers.Add(i);
        }
    }

    foreach (int element in quadrupleNumbers)
    {
            Console.WriteLine(element);
    }
    }
}
