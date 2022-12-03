namespace AdventOfCode;

public static class Day3 {
    public static void Run() {
        string[] lines = System.IO.File.ReadAllLines("Source/Days/Day3/Input.txt");

        List<char> intersections = new List<char>();

        foreach (string line in lines) {
            string firstCompartment = line.Substring(0, line.Length / 2);
            string secondCompartment = line.Substring(line.Length / 2, line.Length / 2);

            char intersection = firstCompartment.Intersect(secondCompartment).ToArray()[0];

            intersections.Add(intersection);
        }

        int totalPriority = 0;

        foreach (char intersection in intersections) {
            int priority = 0;

            byte ascii = ((byte)intersection);

            if (Char.IsUpper(intersection)) {
                priority = ascii - 64 + 26;
            } else {
                priority = ascii - 96;
            }

            totalPriority += priority;
        }

        Console.WriteLine(totalPriority);
    }
}
