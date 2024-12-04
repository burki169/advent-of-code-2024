namespace AdventOfCode2024.Day1;

public class Day1(string pathToInputFile) : Day(pathToInputFile)
{
    public int Solve()
    {
        List<int> firstGroupLocations = new();
        List<int> secondGroupLocations = new();
        
        var lines = File.ReadAllLines(PathToInputFile);
        foreach (var line in lines)
        {
            var values = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            firstGroupLocations.Add(int.Parse(values[0]));
            secondGroupLocations.Add(int.Parse(values[1]));
        }
        firstGroupLocations.Sort();
        secondGroupLocations.Sort();
        
        var part1= firstGroupLocations.Select( (value, index) => Math.Abs(value - secondGroupLocations[index])).Sum();
        var part2 =  firstGroupLocations.Select((value, index) => value*secondGroupLocations.Count(v => v == value)).Sum();
        return part2;
    }
}