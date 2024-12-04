namespace AdventOfCode2024.Day2;

public class Day2(string pathToInputFile) : Day(pathToInputFile)
{
    public int Solve()
    {
        return File.ReadAllLines(PathToInputFile).Count(IsItSafe);
    }

    private bool IsItSafe(string line)
    {
        var levels = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        
        var isAscending = levels[0] < levels[1];
        for (var i = 1; i < levels.Length; i++)
        {
            if((isAscending && levels[i-1]>levels[i])||(!isAscending && levels[i-1]<levels[i]))
                return false;
            var difference = Math.Abs(levels[i-1] - levels[i]);
            if ( difference > 3 || difference < 1 )
                return false;
        }
        
        return true;
    }
}