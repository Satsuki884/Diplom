using UnityEngine;
using System.IO;

public static class BinaryFileUtility
{
    // Fixed path to the file
    private static readonly string FilePath = "Assets/Data/test.bin";

    public static void WriteNumberToFile(int number)
    {
        // Создание нового файла для записи, перезаписывая его, если он существует
        using (BinaryWriter writer = new BinaryWriter(File.Open(FilePath, FileMode.Create)))
        {
            Debug.Log(number);
            // Запись числа в файл
            writer.Write(number);
        }
    }

    // Method for reading a number from a binary file
    public static int ReadNumberFromFile()
    {
        int number = 0;
        // Check if the file exists
        if (File.Exists(FilePath))
        {
            // Open the file for reading
            using (BinaryReader reader = new BinaryReader(File.Open(FilePath, FileMode.Open)))
            {
                // Read the number from the file
                number = reader.ReadInt32();
            }
        }
        else
        {
            Debug.LogError("File not found: " + FilePath);
        }
        return number;
    }
}