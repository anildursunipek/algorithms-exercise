namespace homework;
class WordPuzzle
{
    public static void Main(string[] args)
    {
        CreateGame();
    }

    public static void CreateGame()
    {
        int[] shape = new int[] { 15, 22 }; // index 0 -> row || index 1 -> column
        char[,] gameTable = new char[shape[0], shape[1]];
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        string[] words = new string[] { "fastfood", "snape", "chriger", "obiwan", "form", "cinema", "credi", "television", "talent", "program", "media" };
        int[,] wordIndices = new int[11,3];
        Random rnd = new Random();
        int counter = 0;
        string answer;
        int trueAnswer = 0;

        foreach (string word in words)
        {
            int position = rnd.Next(2); // 0 -> vertical || 1 -> horizontal
            int[] randomPoint = checkPoints(rnd, shape, gameTable, word, position);
            wordIndices[counter,0] = randomPoint[0];
            wordIndices[counter,1] = randomPoint[1];
            wordIndices[counter,2] = position;
            counter +=1;
            for (int i = 0; i < word.Length; i++)
            {
                gameTable[randomPoint[0], randomPoint[1]] = word[i];
                randomPoint[position] +=1;
            }
        }

        // fill null points
        for (int i = 0; i < shape[0]; i++)
        {
            for (int x = 0; x < shape[1]; x++)
            {
                if (gameTable[i, x].Equals('\0')) // Null check
                {
                    gameTable[i, x] = alphabet[rnd.Next(26)];
                }
            }
        }

        printGame(shape[0], shape[1], gameTable, words);
        
       // make a guess
        while (true)
        {
            Console.SetCursorPosition(45, 22);
            Console.CursorVisible = true;
            answer = Console.ReadLine();
            if (checkAnswer(answer, words))
            {
                drawAnswer(words, wordIndices, answer);
                trueAnswer += 1;
            }
            Console.SetCursorPosition(45, 22);
            if(trueAnswer == 11)
            {
                Console.Write("---All words found---");
                break;
            }
            Console.Write("                        ");
        }
    }
    public static void printGame(int row, int column, char[,] gameTable, string[] words)
    {
        // print Table
        int currentRow = 1;
        for (int i = 0; i < row; i++)
        {
            Console.SetCursorPosition(35, currentRow);
            for (int x = 0; x < column; x++)
            {
                Console.Write(gameTable[i, x] + " ");
            }
            currentRow++;
        }
        Console.Write("\n");

        // Print Options
        Console.SetCursorPosition(7, currentRow +2);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.BackgroundColor = ConsoleColor.Red;

        foreach (string word in words)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(word);
            Console.ResetColor();
            Console.Write("   ");
        }
        Console.SetCursorPosition(43, 20);
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("---Please enter the word---");
        Console.ResetColor();   
    }
    public static int[] checkPoints(Random rnd, int[] shape, char[,] gameTable, string word, int position)
    {
        while (true)
        {
            bool flag = true;
            int[] randomPoint = new int[] { rnd.Next(shape[0]), rnd.Next(shape[1]) };
            int[] temp = new int[] { randomPoint[0], randomPoint[1] };
            if((temp[position] + word.Length - 1) < shape[position]) {
                for (int i = 0; i < word.Length; i++)
                {
                    if(gameTable[temp[0], temp[1]].Equals('\0'))
                    {
                        temp[position] += 1;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }
            }
            else
            {
                flag = false;
            }
            if (flag)
            {
                return randomPoint;
            }
        }
    }

    public static bool checkAnswer(string answer, string[] words)
    {
        if (Array.IndexOf(words, answer) > -1)
        {
            return true;
        }
        return false;
    }
    public static void drawAnswer(string[] words,int[,] wordIndices, string word) {
        int index = Array.IndexOf(words, word);
        int position = wordIndices[index, 2];
        foreach (char letter in word)
        {
            Console.SetCursorPosition(wordIndices[index, 1]*2 + 35, wordIndices[index, 0] + 1);
            Console.BackgroundColor = ConsoleColor.Red;
            if(position == 1)
            {
                Console.Write(letter + " ");
            }
            else
            {
                Console.Write(letter);
            }
            wordIndices[index, position] +=1;
        }

        // Display Option
        int calculateSpace = 7;
        for(int i=0; i< index; i++)
        {
            calculateSpace += words[i].Length + 3;
        }
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.SetCursorPosition(calculateSpace, 18);
        Console.Write(word);
        Console.ResetColor();
    }
}