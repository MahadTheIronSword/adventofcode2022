namespace AdventOfCode;

public static class Day3 {
    public static void Run() {
        string[] lines = System.IO.File.ReadAllLines("Source/Days/Day3/Input.txt");

        List<char> intersections = new List<char>();

        int i = 0;
        List<string> rugsacks = new List<string>();

        foreach (string line in lines) {
            rugsacks.Add(line);
            i++;

            if (i >= 3) {
                // find intersection
                string currentIntersection = rugsacks[0];
                
                foreach (string rugsack in rugsacks) {
                    string intersection = String.Join("", currentIntersection.Intersect(rugsack));
                    currentIntersection = intersection;
                }

                char charIntersect = currentIntersection[0];
                intersections.Add(charIntersect);

                i = 0;
                rugsacks.Clear();
            }
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
