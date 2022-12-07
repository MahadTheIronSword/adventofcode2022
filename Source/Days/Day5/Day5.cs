namespace AdventOfCode;

public static class Day5 {
    public static void Run() {
        string[] lines = System.IO.File.ReadAllLines("Source/Days/Day5/Input.txt");

        List<List<char>> data = new List<List<char>>();
        for (int i = 0; i < 9; i++) { data.Add(new List<char>()); }

        foreach (string line in lines) {
            if (line.StartsWith("move")) {
                string[] split = line.Split(" ");

                int amount = Int32.Parse(split[1]);
                int start = Int32.Parse(split[3]);
                int end = Int32.Parse(split[5]);

                List<char> startRow = data[start - 1];
                List<char> endRow = data[end - 1];

                List<char> toMove = new List<char>();

                for (int i = 0; i < amount; i++) {
                    char top = startRow[0];
                    startRow.RemoveAt(0);

                    toMove.Add(top);
                }

                toMove.Reverse();
                foreach (char c in toMove) {
                    endRow.Insert(0, c);
                }
            } else {
                int index = 0;

                foreach (char c in line.ToCharArray()) {
                    if (Char.IsLetter(c)) {
                        int rowIndex = (index - 1) / 4;

                        List<char> row = data[rowIndex];
                        row.Add(c);
                    }

                    index++;
                }
            }
        }

        string answer = "";

        foreach (List<char> row in data) {
            if (row.Count > 0) {
                answer += row[0];
            }
        }

        Console.WriteLine(answer);
    }
}
