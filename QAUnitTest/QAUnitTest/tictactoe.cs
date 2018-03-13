using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAUnitTest
{
    public class tictactoe
    {
        public char[,] board;
        char marker;

        //constructor
        public tictactoe()
        {
            marker = 'x';

        }

        //sets up board object
        public char[,] createBoard()
        {
            board = new char[3, 3];
            return board;
        }

        //returns current player
        public char currentPlayer()
        {
            return marker;
        }

        //change current player
        public void changePlayer()
        {
            if (marker == 'x')
            {
                marker = 'o';
            }
            else
            {
                marker = 'x';
            }
        }

        //makes current player move by placing a player token on the board
        public void makeMove(int x, int y, char marker)
        {
            if (board[x, y] != 'x' || board[x, y] != 'y')
            {
                board[x, y] = marker;
            }
            else
            {
                
            }
        }

        //determines if a space is in use. Returns true if in use, false otehrwise
        public Boolean spaceInUse(int x, int y)
        {
            if (board[x, y] == 'x' || board[x, y] == 'y')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
