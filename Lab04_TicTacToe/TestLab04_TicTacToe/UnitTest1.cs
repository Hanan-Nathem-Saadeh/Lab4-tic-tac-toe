using System;
using Xunit;
using Lab04_TicTacToe;
using Lab04_TicTacToe.Classes;

namespace TestLab04_TicTacToe
{
    public class TestLab04_TicTacToe
    {
        //Given a game board, Test for winners
        [Fact]
        public void TestWinner()
        {
            Game newGame = new Game(new Player(), new Player());
            newGame.Board.GameBoard = new string[,]
            {
                {"1", "X", "3" },
                {"4", "X", "6" },
                {"7", "X", "9" },
            };
            Assert.True(newGame.CheckForWinner(newGame.Board));
        }
        //Test that there is a switch in players between turns
        [Fact]
        public void TestSwitchPlayers()
        {
            Player PlayerOne = new Player() { IsTurn = true };
            Player PlayerTwo = new Player();
            Game game = new Game(PlayerOne, PlayerTwo);
            game.SwitchPlayer();
            Assert.False(PlayerOne.IsTurn);
        }

        //Confirm that the position the player inputs correlates to the CORRECT index of the array
        [Fact]

        public void TestCorrectCoordinates()

        {
            Position testPosition = Player.PositionForNumber(2);
            int[] expected = { 0, 1 };
            int[] actual = new int[2];
            actual[0] = testPosition.Row;
            actual[1] = testPosition.Column;
            Assert.Equal(expected, actual);
        }
        //One other “unique” test of your own
        [Fact]
        public void TestNotWinnerBoard()
        {
            Game testGame = new Game(new Player(), new Player());
            testGame.Board.GameBoard = new string[,]
            {
                {"X", "O", "X"},
                {"O", "O", "X"},
                {"X", "X", "O"},
            };
            Assert.False(testGame.CheckForWinner(testGame.Board));

          
        }

    }
}
