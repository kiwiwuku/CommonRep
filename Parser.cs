using System;
using System.IO;

public class Parser
{
    public string[] Parsing(string str)
    {
        string[] lines = str.Split('\n');
        string[,] result = new string[4, lines.Length - 1]; //здесь будет результат
        for (int i = 1; i < lines.Length; i++)
        {
            string[] lineParts = lines[i].Split(' ');
            for (int j = 0; j < 4; j++)
                result[i - 1, j] = lineParts[j];
        }
        return result;
    }
}