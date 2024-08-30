namespace CodeKata24.ProblemOne;

/// <summary>
/// http://codekata.com/kata/kata02-karate-chop/
/// </summary>
public class ProblemOne
{

    public void DayOne()
    {
        var target = GetRandomInt();
        System.Console.WriteLine($"Target: {target}");
        var numbers = GenerateRandomSortedIntArray(target);
        Chop(target, numbers);
    }

    private int GetRandomInt()
    {
        var random = new Random();
        return random.Next(10000);
    }

    private void Chop(int target, List<int> numbers)
    {
        var length = numbers.Count;
        var index = length / 2;
        var x = numbers[index];
        System.Console.WriteLine($"X: {x}");

        if (x == target) return;
        
        if (x > target)
        {
            var thing = numbers[index..];
            Chop(target, thing);
        }
        else
        {
            var thing = numbers[0..index];
            Chop(target, thing);
        }
    }


    // This has zero optimisation as it's not the point of the exercise
    private List<int> GenerateRandomSortedIntArray(int target)
    {
        var random = new Random();
        var length = random.Next(1000);
        var numbers = new List<int>(length);
        for (int i = 0; i < length; i++)
        {
            numbers.Add(random.Next(10000));
        }
        numbers.Add(target);
        numbers.Sort();
        return numbers;
    }
}