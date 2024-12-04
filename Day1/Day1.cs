namespace AdventOfCode2024.Day1;

public class Day1
{
    private readonly string _pathToInputFile;

    public Day1(string pathToInputFile)
    {
        _pathToInputFile = pathToInputFile;
    }
    
    public int Solve()
    {
        List<int> firstGroupLocations = new();
        List<int> secondGroupLocations = new();
        
        var lines = File.ReadAllLines(_pathToInputFile);
        foreach (var line in lines)
        {
            var values = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            firstGroupLocations.Add(int.Parse(values[0]));
            secondGroupLocations.Add(int.Parse(values[1]));
        }
        firstGroupLocations.Sort();
        secondGroupLocations.Sort();
        
        return firstGroupLocations.Select( (value, index) => Math.Abs(value - secondGroupLocations[index])).Sum();
    }
}