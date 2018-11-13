using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class TheTakeDownOfJakePaul : CarnivalGame

    {

        Boolean j = false;
        int k = 1;

        public TheTakeDownOfJakePaul() : base()
        {

        }

        public override string getName()
        {
            return "When The Haters Dab Back!?!?";
        }

        public override void play()
        {
            showTitle("Welcome Tic Dab Toe");

            writeOut("DAB ON THEM HATERS!!!!!");
            writeOut("Player 1 will be Haters, Player 2 will be Dab.");
            writeOut("Haters will start.");


            String[,] board = new String[3, 3];
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = "_ ";
                    if (j == 2)
                    {
                        write(board[i, j] + "\n");
                    }
                    else
                    {
                        write(board[i, j]);
                    }
                }
            }



            while (j == false)
            {
                placement(board, k);
                k++;
                clear();
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        if (j == 2)
                        {
                            write(board[i, j] + "\n");
                        }
                        else
                        {
                            write(board[i, j]);
                        }
                    }
                }


            }






        }

        public void placement(String[,] board, int k)
        {
            int r, c;
            writeOut("Where will you place your letter? Ex. (row,column)");
            String[] place = Console.ReadLine().Split(',');

            r = Convert.ToInt32(place[0]);
            c = Convert.ToInt32(place[1]);

            if(r < 0 || r >2 || c < 0 || c > 2)
            {
                clear();
                writeOut("Invalid move! Mmmmm Try Again!");
                placement(board, k);
            }
            else if( board[r, c] == "_ ")
            {
                if (k % 2 == 1)
                {
                    board[r, c] = "H ";
                }
                else
                {
                    board[r, c] = "D ";
                }
            }
            else
            {
                clear();
                writeOut("Invalid move! Mmmmm Try Again!");
                placement(board, k);
            }

           for (int t = 0; t < board.GetLength(0); t++)
            {
                for (int g = 0; g < board.GetLength(0); g++)
                {
                    if(board[t, g] != "_ ")
                    {
                        writeOut("Game over!!! Somebody Won!!!");
                    }
                }
            }

        }
    }
}
