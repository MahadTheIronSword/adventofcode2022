namespace AdventOfCode;

public static class Day2 {
    private static Dictionary<string, string> DecryptionGuide = new Dictionary<string, string>() {
        {"A", "Rock"},
        {"B", "Paper"},
        {"C", "Scissors"},
        {"X", "Rock"},
        {"Y", "Paper"},
        {"Z", "Scissors"}
    };

    private static Dictionary<string, int> ScoreGuide = new Dictionary<string, int>() {
        {"Rock", 1},
        {"Paper", 2},
        {"Scissors", 3}
    };  

    private static readonly int WinGain = 6;
    private static readonly int DrawGain = 3;

    public static void Run() {
        string[] lines = System.IO.File.ReadAllLines("Source/Days/Day2/Input.txt");

        int score = 0;

        foreach (string line in lines) {
            string[] columns = line.Split(" ");

            string otherMove = DecryptionGuide[columns[0]];
            string yourMove = DecryptionGuide[columns[1]];

            score += ScoreGuide[yourMove];

            if (yourMove == "Rock") {
                if (otherMove == "Paper") {
                    continue;
                }

                if (otherMove == "Scissors") {
                    score += WinGain;
                    continue;
                }

                score += DrawGain;
            }

            if (yourMove == "Paper") {
                if (otherMove == "Scissors") {
                    continue;
                }

                if (otherMove == "Rock") {
                    score += WinGain;
                    continue;
                }

                score += DrawGain;
            }

            if (yourMove == "Scissors") {
                if (otherMove == "Rock") {
                    continue;
                }

                if (otherMove == "Paper") {
                    score += WinGain;
                    continue;
                }

                score += DrawGain;
            }

        }

        Console.WriteLine(score);
    }
}