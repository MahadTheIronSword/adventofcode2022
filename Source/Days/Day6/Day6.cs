namespace AdventOfCode;

public static class Day6 {
    public static void Run() {
        string input = System.IO.File.ReadAllText("Source/Days/Day6/Input.txt");

        List<char> foundCharacters = new List<char>();

        int index = 0;

        foreach (char c in input.ToCharArray()) {
            index++;

            foundCharacters.Add(c);

            if (foundCharacters.Count >= 4) {
                List<char> lastFour = foundCharacters.GetRange(foundCharacters.Count - 4, 4);

                if (lastFour.Count == lastFour.Distinct().Count()) {
                    break;
                }
            }
        }

        Console.WriteLine(index);
    }
}