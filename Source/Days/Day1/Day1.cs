namespace AdventOfCode;

struct Elf {
    public List<int> FoodItems { get; set; }

    public int Total { get; set; }

    public Elf(List<int> foodItems) {
        FoodItems = foodItems;

        Total = foodItems.Aggregate(0, (acc, n) => acc + n);
    }
}

public static class Day1 {
    public static void Run() {
        string[] lines = System.IO.File.ReadAllLines("Source/Days/Day1/Input.txt");

        List<int> currentFoodData = new List<int>();

        int[] highestCalorieCounts = new int[3];
        Array.Fill(highestCalorieCounts, 0);

        foreach (string line in lines) {
            if (line == String.Empty) {
                Elf elf = new Elf(currentFoodData);

                for (int i = 0; i < highestCalorieCounts.Length; i++) {
                    int highestCalorieCount = highestCalorieCounts[i];
                    if (elf.Total > highestCalorieCount) {

                        if (i == 0) {
                            // shift all numbers down
                            highestCalorieCounts[2] = highestCalorieCounts[1];
                            highestCalorieCounts[1] = highestCalorieCounts[0];
                        }

                        highestCalorieCounts[i] = elf.Total;

                        break;
                    }
                }

                currentFoodData.Clear();
            } else {
                int calories = Int32.Parse(line);
                currentFoodData.Add(calories);
            }
        }

        int totalCalories = highestCalorieCounts.Aggregate(0, (acc, n) => acc + n);
        Console.WriteLine(totalCalories);
    }
}
