using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace ThaoDoanAssignment1
{
    public partial class Form1 : Form
    {
        static Random r = new Random();
        static Button[,] buttons = new Button[8, 8];
        static private int[,] board;
        static Location currLoc;
        static int moveNumber, trialCount;
        static private string fileName, methodName;

        public Form1()
        {
            board = new int[8, 8];
            trialCount = 0;
            moveNumber = 0;
            currLoc = new Location();

            InitializeComponent();
            CreateBoard();
        }


        public void CreateBoard() {

            for (int i = 0; i < 8; i++){
                for (int j = 0; j < 8; j++){
                    board[i, j] = 0;

                    buttons[i, j] = new Button();
                    buttons[i, j].Margin = new Padding(0, 0, 0, 0);
                    buttons[i, j].Size = new Size(50, 50);
                    buttons[i, j].Tag = i + "," + j;
                    buttons[i, j].Click += Button_Click;

                    if ((i + j) % 2 == 0)
                        buttons[i, j].BackColor = Color.DimGray;
                    else
                        buttons[i, j].BackColor = Color.White;

                    tableLayoutPanel1.Controls.Add(buttons[i, j], j, i);
                }
            }
        }


        private void Button_Click(object sender, EventArgs e)
        {
            //get the y and x cordinates (button(y,x))
            var button = (Button)sender;
            string[] indexes = button.Tag.ToString().Split(',');

            //After the first move, user can not click any more buttons
            foreach (Button b in buttons)
                b.Enabled = false;
         
            moveKnight(Convert.ToInt32(indexes[0]), Convert.ToInt32(indexes[1]));
            trialCount++;

            //execute nonintelligent or Heuristics method based on user's selection
            if (methodName == "NonIntelligent")
                 NonIntelligentMethod();
            else
                HeuristicsMethod();
        }

        static void moveKnight(int newY, int newX)
        {
            moveNumber++;
           
            currLoc.Y = newY;
            currLoc.X = newX;
            
            //update the board array
            board[currLoc.Y, currLoc.X] = moveNumber;
            buttons[currLoc.Y, currLoc.X].Text = "" + moveNumber;
            buttons[currLoc.Y, currLoc.X].BackColor = Color.Brown;
            buttons[currLoc.Y, currLoc.X].Update();
            buttons[currLoc.Y, currLoc.X].Refresh();

            //wait for 2 seconds
            System.Threading.Thread.Sleep(200);
        }


        static List<Location> FindAvailableMoves(Location l)
        {
            List<Location> availabilities = new List<Location>();

            if (l.Y + 2 < 8 && l.X + 1 < 8 && l.Y + 2 >= 0 && l.X + 1 >= 0 && board[l.Y + 2, l.X + 1] == 0)
                availabilities.Add(new Location(l.Y + 2, l.X + 1));

            if (l.Y + 2 < 8 && l.X - 1 < 8 && l.Y + 2 >= 0 && l.X - 1 >= 0 && board[l.Y + 2, l.X - 1] == 0)
                availabilities.Add(new Location(l.Y + 2, l.X - 1));

            if (l.Y - 2 >= 0 && l.X + 1 >= 0 && l.Y - 2 < 8 && l.X + 1 < 8 && board[l.Y - 2, l.X + 1] == 0)
                availabilities.Add(new Location(l.Y - 2, l.X + 1));

            if (l.Y - 2 >= 0 && l.X - 1 >= 0 && l.Y - 2 < 8 && l.X - 1 < 8 && board[l.Y - 2, l.X - 1] == 0)
                availabilities.Add(new Location(l.Y - 2, l.X - 1));

            if (l.Y + 1 >= 0 && l.X + 2 >= 0 && l.Y + 1 < 8 && l.X + 2 < 8 && board[l.Y + 1, l.X + 2] == 0)
                availabilities.Add(new Location(l.Y + 1, l.X + 2));

            if (l.Y + 1 >= 0 && l.X - 2 >= 0 && l.Y + 1 < 8 && l.X - 2 < 8 && board[l.Y + 1, l.X - 2] == 0)
                availabilities.Add(new Location(l.Y + 1, l.X - 2));

            if (l.Y - 1 >= 0 && l.X + 2 >= 0 && l.Y - 1 < 8 && l.X + 2 < 8 && board[l.Y - 1, l.X + 2] == 0)
                availabilities.Add(new Location(l.Y - 1, l.X + 2));

            if (l.Y - 1 >= 0 && l.X - 2 >= 0 && l.Y - 1 < 8 && l.X - 2 < 8 && board[l.Y - 1, l.X - 2] == 0)
                availabilities.Add(new Location(l.Y - 1, l.X - 2));

            return availabilities;
        }

        public void switchForms()
        {
            if (panel1.Visible == true) {
                panel1.Visible = false;
                panel2.Visible = true;
            } else {
                panel2.Visible = false;
                panel1.Visible = true;
            }
        }


        private void HeuristicsBtn_Click(object sender, EventArgs e)
        {
            methodName = "Heuristics";
            MethodLabel.Text = "Heuristics method";
            fileName = "C:\\Users\\Tuan\\Documents\\Sheridan\\semester4\\Web Services Using .NET & C#\\Assignments\\ThaoDoanAssignment1\\ThaoDoanAssignment1\\ThaoDoanHeuristicsMethod.txt";
            switchForms();
        }

        private void NonIntelligentBtn_Click(object sender, EventArgs e)
        {
            methodName = "NonIntelligent";
            MethodLabel.Text = "Non Intelligent method";
            fileName = "C:\\Users\\Tuan\\Documents\\Sheridan\\semester4\\Web Services Using .NET & C#\\Assignments\\ThaoDoanAssignment1\\ThaoDoanAssignment1\\ThaoDoanNonIntelligentMethod.txt";
            switchForms();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void RestartBtn_Click(object sender, EventArgs e)
        {
            restartGame();
        }

        private void MainMenuBtn_Click_1(object sender, EventArgs e)
        {
            trialCount = 0;
           
            switchForms();
            restartGame();          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe",fileName);
        }

        public void NonIntelligentMethod()
        {
            while (moveNumber < 64)
            {
                //display availabilities
                List<Location> moveOptions = FindAvailableMoves(currLoc);

                //Check if there any possible moves => perform actions
                if (moveOptions.Count == 0)
                {
                    Score.Text = "YOUR SCORE: " + moveNumber;
                    WriteToFile();
                    break;
                }
                else
                {
                    //choose a random option from availabilities
                    int random = r.Next(moveOptions.Count);
                    int randomX = moveOptions[random].X;
                    int randomY = moveOptions[random].Y;

                    moveKnight(randomY, randomX);
                }
            }
        }

        public void HeuristicsMethod()
        {

            int[,] board2 = new int[8, 8] { {2,3,4,4,4,4,3,2 },
                                            {3,4,6,6,6,6,4,3 },
                                            {4,6,8,8,8,8,6,4 },
                                            {4,6,8,8,8,8,6,4 },
                                            {4,6,8,8,8,8,6,4 },
                                            {4,6,8,8,8,8,6,4 },
                                            {3,4,6,6,6,6,4,3 },
                                            {2,3,4,4,4,4,3,2 },};

            while (moveNumber < 64)
            {
                //display availabilities
                List<Location> moveOptions = FindAvailableMoves(currLoc);

                //Check if there any possible moves => perform actions
                if (moveOptions.Count == 0)
                {
                    Score.Text = "YOUR SCORE: " + moveNumber;
                    WriteToFile();
                    break;
                }
                else
                {
                    //filter the move options and only select good moves
                    // good moves can have many 
                    List<Location> goodMoves = new List<Location>();
               
                    //find the smallest value
                    int x1 =  moveOptions[0].X;
                    int y1 = moveOptions[0].Y;

                    foreach(Location l in moveOptions){
                        if(board2[l.Y, l.X] < board2[y1, x1])
                        {
                            x1 = l.X;
                            y1 = l.Y;
                        }
                    }

                    foreach (Location l in moveOptions)
                    {
                        if (board2[l.Y, l.X] == board2[y1, x1])
                        {
                            goodMoves.Add(new Location(l.Y, l.X));
                        }
                    }

                    //Select random good moves from the list
                    int random = r.Next(goodMoves.Count);  

                    int randomX = goodMoves[random].X;
                    int randomY = goodMoves[random].Y;

                    moveKnight(randomY, randomX);
                }
            }
        }

        public void restartGame()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    //reset color
                    if ((i + j) % 2 == 0)
                        buttons[i, j].BackColor = Color.DimGray;
                    else
                        buttons[i, j].BackColor = Color.White;

                    board[i, j] = 0;
                    buttons[i, j].Text = "";
                    Score.Text = "";
                    buttons[i, j].Enabled = true;
                    moveNumber = 0;
                }
            }
        }


        public static void WriteToFile()
        {
            if (File.Exists(fileName))
            {               
                if (trialCount == 1)
                {
                    using (StreamWriter fileWriter = new StreamWriter(fileName))
                    {
                        fileWriter.Write("");
                    }
                }  
                using (StreamWriter fileWriter = File.AppendText(fileName))
                {
                    fileWriter.WriteLine("Trial {0}: The Knight was successully touch {1} squares ", trialCount, moveNumber);
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                            fileWriter.Write("{0,4}", board[i, j]);
                       
                        fileWriter.WriteLine();
                    }
                    fileWriter.WriteLine();
                }
            }
        }
    }  
}
