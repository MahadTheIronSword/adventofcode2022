namespace AdventOfCode;

public static class Day2 {
    private static readonly int WinGain = 6;
    private static readonly int DrawGain = 3;

    private static Dictionary<string, string> DecryptionGuide = new Dictionary<string, string>() {
        {"A", "Rock"},
        {"B", "Paper"},
        {"C", "Scissors"}
    };

    private static Dictionary<string, int> EndScoreGuide = new Dictionary<string, int>() {
        {"X", 0},
        {"Y", DrawGain},
        {"Z", WinGain}
    };

    private static Dictionary<string, int> ScoreGuide = new Dictionary<string, int>() {
        {"Rock", 1},
        {"Paper", 2},
        {"Scissors", 3}
    }; 

    private static Dictionary<string, string> WinGuide = new Dictionary<string, string>() {
        {"Rock", "Paper"},
        {"Paper", "Scissors"},
        {"Scissors", "Rock"}
    };

    public static void Run() {
        string[] lines = System.IO.File.ReadAllLines("Source/Days/Day2/Input.txt");

        int score = 0;

        foreach (string line in lines) {
            string[] columns = line.Split(" ");

            string otherMove = DecryptionGuide[columns[0]];
            int endResult = EndScoreGuide[columns[1]];

            if (endResult == WinGain) {
                score += WinGain + ScoreGuide[WinGuide[otherMove]];
                continue;
            }

            if (endResult == DrawGain) {
                score += DrawGain + ScoreGuide[otherMove];
                continue;
            }

            if (endResult == 0) {
                score += ScoreGuide[WinGuide.FirstOrDefault(x => x.Value == otherMove).Key];
            }   
        }

        Console.WriteLine(score);
    }
}