// Крестики-нолики

 int boardSize = 3;
        int[] board = {1, 2, 3, 4, 5, 6, 7, 8, 9};
void BoardOutput() 
    {
        Console.WriteLine(new string('_' , 4 * boardSize) + '_');
        for (int i =0; i <boardSize; i++) 
        {
            Console.WriteLine('|' + new string(' ' , 3) + '|' + new string(' ' , 3) + '|' + new string(' ' ,3) + '|');
            Console.WriteLine("|" + ' ' + board[0 + i * 3] + " | "   + board[1 + i * 3] + " | "+ board[2 + i * 3] + " |");
            Console.WriteLine('|' + new string('_' , 3) + '|' + new string('_' , 3) + '|' + new string('_' , 3) + '|');
        }
    }
BoardOutput();


//string[,] array = new string[3, 3] { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };

//void PrintArray(string[,] array)
//{
 //   for(int i = 0; i < array.GetLength(0); i++)
  //  {
  //      for(int j = 0; j < array.GetLength(1); j++)
 //       {
 //       Console.Write(string.Format("{0, 4}", array[i, j] + " |" ));
 //       }
 //       Console.WriteLine();
  //  }
//}

//PrintArray(array);
//Console.Write("Введите имя игрока №1 ");
//string username1 = Console.ReadLine();

//Console.Write("Введите имя игрока №2 ");
//string username2 = Console.ReadLine();

//Console.Write("Игрок ");
//Console.WriteLine(username1);
//Console.Write(" выберете число, чтобы поставть Х: ");
//int move = Convert.ToInt32(Console.ReadLine());

//if (move > 0 && move <= 9)
  //  if (move == 1)
  //  array [0, 0] = "x";
  //  if (move == 2)
  //  array [0, 1] = "x";
   // if (move == 3)
    //array [0, 2] = "x";
    //if (move == 4)
    //array [1, 0] = "x";
    //if (move == 5)
   // array [1, 1] = "x";
   // if (move == 6)
   // array [1, 2] = "x";
   // if (move == 7)
   // array [2, 0] = "x";
   // if (move == 8)
    //array [2, 1] = "x";
    //if (move == 9)
   // array [2, 2] = "x";
//else Console.WriteLine("введено не верное число для хода");


//PrintArray(array);

//Console.Write("ход игрока ");
//Console.WriteLine(username2);
//Console.Write(" выберете число, чтобы поставть Х: ");
//int move2 = Convert.ToInt32(Console.ReadLine());
//if (move2 > 0 && move <= 9)
  //  if (move2 == 1)
  //  array [0, 0] = "O";
  //  if (move2 == 2)
  //  array [0, 1] = "O";
  //  if (move2 == 3)
  //  array [0, 2] = "O";
  //  if (move2 == 4)
  //  array [1, 0] = "O";
  //  if (move2 == 5)
  //  array [1, 1] = "O";
  //  if (move2 == 6)
  //  array [1, 2] = "O";
  //  if (move2 == 7)
   // array [2, 0] = "O";
  //  if (move2 == 8)
  //  array [2, 1] = "O";
  //  if (move2 == 9)
  //  array [2, 2] = "O";
//else Console.WriteLine("введено не верное число для хода");
//PrintArray(array);

