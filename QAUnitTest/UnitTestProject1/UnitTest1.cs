using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QAUnitTest;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //test that board has nine fields
        [TestMethod]
        public void nineFieldsTest()
        {
            tictactoe foo = new tictactoe();
            int check = 0;
            try
            {
                foo.createBoard();
                for (int i = 0; i < 3; i++)
                {
                    for(int j=0; j < 3; j++)
                    {
                        Assert.AreEqual(foo.board[i, j], '\0');
                    }
                }

            }
            catch(Exception ex)
            {

            }
        }

        //test that current player is x
        [TestMethod]
        public void testX()
        {
            tictactoe foo = new tictactoe();
            Assert.AreEqual('x', foo.currentPlayer());
        }
        
        //test that current palyer is o
        [TestMethod]
        public void testO()
        {
            tictactoe foo = new tictactoe();
            foo.changePlayer();
            Assert.AreEqual('o', foo.currentPlayer());
        }

        //test whether x can place a token on the board
        [TestMethod]
        public void placementTestX()
        {
            tictactoe foo = new tictactoe();
            foo.createBoard();
            foo.makeMove(0, 0, foo.currentPlayer());
            Assert.AreEqual(foo.board[0, 0], 'x');
        }

        //test whether o can place a token on the board
        [TestMethod]
        public void placementTestO()
        {
            tictactoe foo = new tictactoe();
            foo.createBoard();
            foo.changePlayer();
            foo.makeMove(0, 0, foo.currentPlayer());
            Assert.AreEqual(foo.board[0, 0], 'o');
        }

        //assert that the placement on the board is an unoccupied spot
        [TestMethod]
        public void testUnoccupied()
        {
            tictactoe foo = new tictactoe();
            foo.createBoard();
            Assert.AreEqual(foo.board[0,0], '\0');
        }




    }   
}
