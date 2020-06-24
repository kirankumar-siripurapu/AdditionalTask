using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionTask17122019
{
    class TikTacToe
    {
        string[,] x = new string[3, 3] 
        {{ "1", "2", "3" },
         {"4","5","6"},
         {"7","8","9"} 
        };

        int player1Counter;
        int player2Counter;
        int number;
        string playerValue;
        int player;

        public TikTacToe()
        {
            this.player1Counter = 0;
            this.player2Counter = 0;
            this.number = 0;
            this.player = 1;
            this.playerValue = "X";
            for (int x = 0; x < 3; x++)
            {   
                for (int y = 0; y < 3; y++)
                {
                    Console.Write("|{0}", this.x[x, y]);
                }
                Console.WriteLine("|\n ");

            }
            Console.WriteLine("****************Game Started**************************\n");
        }

        public void NumberRead(int player, int counter, out int number)
        {
            number = 0;
            Console.WriteLine("Player{0} - Please choose the {1}number: ", player, counter);
            try
            {
                this.player = player;
                if (player == 1)
                {
                    this.player1Counter = counter;
                    this.playerValue = "X";                   
                }
                else
                {
                    this.player2Counter = counter;
                    this.playerValue = "O";

                }
                bool numberBool = int.TryParse(Console.ReadLine(), out number);
                if(!numberBool)
                    Console.WriteLine("The format of number is not correct");
            }
            catch (FormatException)
            {
                Console.WriteLine("The format of number is not correct");
            }
            catch (Exception)
            {

            }
            finally
            {

            }
        }

        public void NumberValidation(int number, out bool numberValid, out int row, out int column)
        {
            numberValid = true;
            row = 0;
            column = 0;
            if (number >= 1 && number <= 9)
            {
                int tempCounter = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        tempCounter++;
                        if (number == tempCounter)
                        {
                             if (this.x[i, j] == "O" || this.x[i, j] == "X")
                             {
                                Console.WriteLine("Provided number is no more existing");
                                numberValid = false;
                             }
                            else
                            {
                                row = i;
                                column = j;
                            }
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Please make sure number should be between 1 and 9");
                numberValid = false;
            }
            
        }

        public void NumberUpdate( int row, int column)
        {
            this.x[row, column] = this.playerValue;
        }

        public void PlayerWin(out bool winner)
        {
            winner = false;         
            for(int x=0; x < 3 ; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.Write("|{0} ", this.x[x, y]);                   
                }
                Console.WriteLine("|\n");
            }
            Console.WriteLine("\n");
            int temp5 = 0;
            int temp6 = 0;
            for (int temp1 = 0; temp1 < 3; temp1++)
            {
                int temp3 = 0;
                int temp4 = 0;
                for (int temp2 = 0; temp2 < 3; temp2++)
                {
                    if (x[temp1, temp2] == this.playerValue)
                    {
                        temp3++;
                        if (temp3 == 3)
                        {
                            Console.WriteLine(" Winner is Player{0} \n Game Over :-)", this.player);
                            winner = true;
                            break;
                        }

                    }
                    if (x[temp2, temp1] == this.playerValue)
                    {
                        temp4++;
                        if (temp4 == 3)
                        {
                            Console.WriteLine(" Winner is Player{0} \n Game Over :-)", this.player);
                            winner = true;
                            break;
                        }

                    }

                    if ((x[temp1, temp1] == this.playerValue) && (temp1 == temp2))
                    {
                        temp5++;
                        if (temp5 == 3)
                        {
                            Console.WriteLine(" Winner is Player{0} \n Game Over :-)", this.player);
                            winner = true;
                            break;
                        }

                    }
                    if ((x[temp1, temp2] == this.playerValue) && (temp1 + temp2 == 2))
                    {
                        temp6++;
                        if (temp6 == 3)
                        {
                            Console.WriteLine(" Winner is Player{0} \n Game Over :-)", this.player);
                            winner = true;
                            break;
                        }
                    }
                }
            }
        }

        public void PlayGame(int player, int counter, out bool gameOver)
        {
            gameOver = false;
            for(int i = 1; i <= 3 ; i++)
            {
                NumberRead(player, counter, out int number);
                this.number = number;
                NumberValidation(number, out bool validNumber, out int row, out int column);
                if (validNumber)
                {
                    NumberUpdate(row, column);
                    PlayerWin(out gameOver);
                    break;
                }
                else
                {
                    if (i == 3)
                    {
                        Console.WriteLine("Number of attempts exceed player{0} lost", player);
                        Console.WriteLine("Better Luck next time");
                        gameOver = true;

                    }

                }
                    
            }
            
        }



            
    }

}
