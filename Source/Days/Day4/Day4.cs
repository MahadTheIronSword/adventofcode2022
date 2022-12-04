namespace AdventOfCode;

public static class Day4 {
    public static void Run() {
        string[] lines = System.IO.File.ReadAllLines("Source/Days/Day4/Input.txt");

        int total = 0;

        foreach (string line in lines) {
            string[] pairs = line.Split(",");

            string[] firstPair = pairs[0].Split("-");
            string[] secondPair = pairs[1].Split("-");

            int min0 = Int32.Parse(firstPair[0]);
            int max0 = Int32.Parse(firstPair[1]);
            int min1 = Int32.Parse(secondPair[0]);
            int max1 = Int32.Parse(secondPair[1]);

            if ((min0 <= min1 && max0 >= max1) || (min1 <= min0 && max1 >= max0)) {
                total++;
            }
        }

        Console.WriteLine(total);
    }
}