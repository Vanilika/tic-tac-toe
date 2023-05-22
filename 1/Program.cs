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

int WinningCombination()
{
    int winning = 0;
    int[][] winning_combination = new int[][] 
    {
        new int[] {0,1,2}, new int[] {3,4,5}, new int[] {6,7,8}, // горизонтальные линии
        new int[] {0,3,6}, new int[] {1,4,7}, new int[] {2,5,8}, // вертикальные линии
        new int[] {0,4,8}, new int[] {2,4,6} // наискосяк
    };
    foreach (int[] pos in winning_combination)
    {
        if (board[pos[0]] == board[pos[1]] && board[pos[1]] == board[pos[2]] && (board[pos[1]] == 'X' || board[pos[1]] == 'O'))
        {
            winning = board[pos[0]];
        }
    }
    return winning;
}

bool move(int index, char c)
{
    if (index > 10 ||index < 1 || board[index-1] == 'X' || board[index-1] == 'O')
    {
        return false;
    }
    board[index-1] = c;
    return true;
}

void start_game()
{
    int step = 0;
    int win = 0;
    char[] players = {'X', 'O'};
    while (step < 9 && win == 0)
    {
        BoardOutput();
        Console.WriteLine("Игрок " + players[step % 2] + " ход:");
        int index = Convert.ToInt32(Console.ReadLine());
        if (move(index, players[step % 2]))
        {
            win = WinningCombination();
            step++;
        }
        else
        {
            Console.WriteLine("Неверный ход, повторите попытку.");
        }
    }
    BoardOutput();
    if (win != 0)
    {
        Console.WriteLine("Игрок " + win + " выиграл!");
    }
    else
    {
        Console.WriteLine("Ничья!");
    }
}

start_game();
