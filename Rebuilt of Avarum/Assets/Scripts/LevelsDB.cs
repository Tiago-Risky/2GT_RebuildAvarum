using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsDB : MonoBehaviour {

    public Dictionary<int, List<LevelNumber>> generatedLevels;

    private Dictionary<int, List<LevelNumber>> levelNumbers = new Dictionary<int, List<LevelNumber>>();
    private int[] levelAmmounts = { 3, 4, 3, 2 };

    void Start()
    {
        levelNumbers.Add(1, new List<LevelNumber>{
            new LevelNumber(9, 5, 4),
            new LevelNumber(9, 7, 2),
            new LevelNumber(7, 4, 3),
            new LevelNumber(6, 4, 2),
            new LevelNumber(9, 3, 6),
            new LevelNumber(8, 3, 5),
            new LevelNumber(7, 5, 2),
            new LevelNumber(5, 2, 3),
            new LevelNumber(4, 2, 2)
        });
        levelNumbers.Add(2, new List<LevelNumber> {
            new LevelNumber(14, 5, 9),
            new LevelNumber(21, 7, 14),
            new LevelNumber(31, 21, 10),
            new LevelNumber(45, 32, 13),
            new LevelNumber(57, 32, 25),
            new LevelNumber(64, 37, 27),
            new LevelNumber(79, 56, 23),
            new LevelNumber(81, 47, 34)
        });
        levelNumbers.Add(3, new List<LevelNumber> {
            new LevelNumber(17, 9, 8),
            new LevelNumber(27, 14, 13),
            new LevelNumber(96, 54, 42),
            new LevelNumber(84, 37, 47),
            new LevelNumber(37, 29, 8),
            new LevelNumber(55, 32, 23),
            new LevelNumber(76, 26, 50)
        });
        levelNumbers.Add(4, new List<LevelNumber> {
            new LevelNumber(179, 95, 84),
            new LevelNumber(277, 145, 132),
            new LevelNumber(963, 541, 422),
            new LevelNumber(497, 268, 229)
        });

        generateLevels();
    }

    public bool correctChoice(LevelNumber levelNumber, int leftAnswer, int rightAnswer) {
        if (leftAnswer+rightAnswer == levelNumber.Sum) {
            return true;
        }
        return false;
    }

    public void generateLevels() {
        generatedLevels = new Dictionary<int, List<LevelNumber>>();
        for (int level = 1; level < 5; level++)
        {
            List<LevelNumber> numbersToAdd = new List<LevelNumber>();
            List<int> safe = new List<int>();
            for (int x = 0; x < levelAmmounts[level - 1]; x++) {
                int pos = Random.Range(0, levelNumbers[level].Count - 1);
                if (!safe.Contains(pos))
                {
                    safe.Add(pos);
                    numbersToAdd.Add(levelNumbers[level][pos]);
                }
                else
                {
                    x--;
                }
            }
            generatedLevels.Add(level,numbersToAdd);
            string debug = "";
            foreach (KeyValuePair<int, List<LevelNumber>> kvp in generatedLevels)
            {
                debug += kvp.Key + " level, ";
                foreach(LevelNumber lvlnumber in kvp.Value)
                {
                    debug += lvlnumber.Sum + "Sum " + lvlnumber.LeftValue + "Left " + lvlnumber.RightValue + "Right  // ";
                }
                debug += "\n";
            }
                Debug.Log(debug);
        }
    }

}
/*levelNumbers[level].Count-(5*level), levelNumbers[level].Count+(5*level)*/
public class LevelNumber
{
    public int Sum;
    public int LeftValue;
    public int RightValue;

    public LevelNumber(int sum, int leftValue, int rightValue)
    {
        Sum = sum;
        LeftValue = leftValue;
        RightValue = rightValue;
    }
}