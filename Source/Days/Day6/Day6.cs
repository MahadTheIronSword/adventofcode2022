namespace AdventOfCode;

public static class Day6 {
    // 4 for part 1 14 for part 2
    public static readonly int StartMarker = 14;

    public static void Run() {
        string input = System.IO.File.ReadAllText("Source/Days/Day6/Input.txt");

        List<char> foundCharacters = new List<char>();

        int index = 0;

        foreach (char c in input.ToCharArray()) {
            index++;

            foundCharacters.Add(c);

            if (foundCharacters.Count >= StartMarker) {
                List<char> lastFour = foundCharacters.GetRange(foundCharacters.Count - StartMarker, StartMarker);

                if (lastFour.Count == lastFour.Distinct().Count()) {
                    break;
                }
            }
        }

        Console.WriteLine(index);
    }
}