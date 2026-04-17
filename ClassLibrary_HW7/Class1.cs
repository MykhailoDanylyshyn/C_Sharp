using System;
using System.IO;
using System.Text;

namespace ClassLibrary_HW7
{
    public class Task1
    {
        public static int ReplaceWordsInFile(string filename, string word1, string word2)
        {
            string tempFile = Path.GetTempFileName();
            int count = 0;

            using (StreamReader reader = new StreamReader(filename, Encoding.Default))
            using (StreamWriter writer = new StreamWriter(tempFile, false, Encoding.Default))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    int index = 0;

                    while ((index = line.IndexOf(word1, index)) != -1)
                    {
                        count++;
                        index += word1.Length;
                    }

                    line = line.Replace(word1, word2);
                    writer.WriteLine(line);
                }
            }

            File.Copy(tempFile, filename, true);
            File.Delete(tempFile);

            return count;
        }
    }
    public class Task2
    {
        public static void Moderator(string filename, string mod_filename)
        {
            string[] badWords = File.ReadAllText(mod_filename, Encoding.Default)
                .Split(new char[] { ' ', '\n', '\r', '\t' },
                StringSplitOptions.RemoveEmptyEntries);

            string tempFile = Path.GetTempFileName();

            using (StreamReader reader = new StreamReader(filename, Encoding.Default))
            using (StreamWriter writer = new StreamWriter(tempFile, false, Encoding.Default))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    foreach (string word in badWords)
                    {
                        int index = 0;

                        while ((index = line.IndexOf(word, index, StringComparison.OrdinalIgnoreCase)) != -1)
                        {
                            bool isStartOk = index == 0 || !char.IsLetter(line[index - 1]);
                            bool isEndOk = (index + word.Length >= line.Length) ||
                                           !char.IsLetter(line[index + word.Length]);

                            if (isStartOk && isEndOk)
                            {
                                string stars = new string('*', word.Length);

                                line = line.Remove(index, word.Length)
                                           .Insert(index, stars);

                                index += stars.Length;
                            }
                            else
                            {
                                index += word.Length;
                            }
                        }
                    }

                    writer.WriteLine(line);
                }
            }

            File.Copy(tempFile, filename, true);
            File.Delete(tempFile);
        }
    }
    public class Task3
    {
        public static void Reverse(string filename)
        {
            string outputFile = filename + "_reversed.txt";

            using (StreamReader reader = new StreamReader(filename, Encoding.Default))
            using (StreamWriter writer = new StreamWriter(outputFile, false, Encoding.Default))
            {
                string text = reader.ReadToEnd();

                char[] chars = text.ToCharArray();
                Array.Reverse(chars);

                writer.Write(new string(chars));
            }
        }
    }

    public class Task4
    {
        public static void GenerateFile(string filename, int count = 100000)
        {
            Random rand = new Random();

            using (StreamWriter writer = new StreamWriter(filename, false))
            {
                for (int i = 0; i < count; i++)
                {
                    int num = rand.Next(-50, 50);
                    writer.WriteLine(num);
                }
            }

            Console.WriteLine($"Файл створено: {filename} ({count} чисел)");
        }

        public static void Analyze(string inputFile)
        {
            int positiveCount = 0;
            int negativeCount = 0;
            int twoDigitCount = 0;
            int fiveDigitCount = 0;

            string posFile = "positive.txt";
            string negFile = "negative.txt";
            string twoFile = "two_digit.txt";
            string fiveFile = "five_digit.txt";

            using (StreamReader reader = new StreamReader(inputFile))
            using (StreamWriter pos = new StreamWriter(posFile, false))
            using (StreamWriter neg = new StreamWriter(negFile, false))
            using (StreamWriter two = new StreamWriter(twoFile, false))
            using (StreamWriter five = new StreamWriter(fiveFile, false))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    if (int.TryParse(line, out int num))
                    {
                        if (num > 0)
                        {
                            positiveCount++;
                            pos.WriteLine(num);
                        }
                        else if (num < 0)
                        {
                            negativeCount++;
                            neg.WriteLine(num);
                        }

                        if (Math.Abs(num) >= 10 && Math.Abs(num) <= 99)
                        {
                            twoDigitCount++;
                            two.WriteLine(num);
                        }

                        if (Math.Abs(num) >= 10000 && Math.Abs(num) <= 99999)
                        {
                            fiveDigitCount++;
                            five.WriteLine(num);
                        }
                    }
                }
            }

            Console.WriteLine("\n=== СТАТИСТИКА ===");
            Console.WriteLine($"Додатні: {positiveCount}");
            Console.WriteLine($"Від'ємні: {negativeCount}");
            Console.WriteLine($"Двозначні: {twoDigitCount}");
            Console.WriteLine($"П'ятизначні: {fiveDigitCount}");
        }
    }
}

