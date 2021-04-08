using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LumenWorks.Framework.IO.Csv;
using System.Windows.Forms;
using System.IO;

using System.Text.RegularExpressions;
// Marcus Herwig, Austin Williams, Lauren Parsons, Martin Spinelli
// Program to read from a csv file and then save to a new text file, and allow the user to enter more data if needed.
// NOTE: this program is meant to be used to read department schedule files written in csv format.
// March 27, 2021

namespace Proof_of_Concept
{
   

    public partial class Form1 : Form

    {
        string contents = " ";
        string[] lines;
        int count = 0;
        OpenFileDialog file = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        public void WriteButton_Click(object sender, EventArgs e)
        {
            //OpenFileDialog file = new OpenFileDialog(); // opens the file explorer so the user can choose what file to read from
            file.ShowDialog(); // shows the file dialog ...
            lines = System.IO.File.ReadAllLines(file.FileName); // creates a string array of all the classes in the schedule so each class is an index in an array
            lines = lines.Skip(1).ToArray(); // skips the first line of schedule because it is not needed for this
            for (int i = 0; i < lines.Length; i++) // sets up a loop that will put the contents of the string array into one string so we can display it
            {
                contents = contents + lines[i]; //adds each index of the string array that contains the data from the file 
                contents = contents + "\n\n"; // adds a blank space between each index so it is easier to read
                count = count + 1;
            }
            // displays the data that was written from the file
            string CleanedString = Regex.Replace(contents, ",", " ");

            dataDisplay.Text = CleanedString;




        }
        
        public void SaveButton_Click(object sender, EventArgs e)
        {
            
               
            OpenFileDialog file = new OpenFileDialog(); // creates file dialog for user to pick a file to save to
            file.ShowDialog(); // shows the file dialog
            StreamWriter sw = new StreamWriter(file.FileName); // makes a streamwriter that will write to the new file
            string contents = dataDisplay.Text; // retrieves the data that will be written into the file
            sw.WriteLine(contents); // writes the data into the file
            sw.Close();  
        }

        private void addDataButton_Click(object sender, EventArgs e)
        {
            string temp = dataInput.Text; // retrieves the user input that was entered in the input field so it can be added to file
            contents = contents + temp + "\n\n"; // add the input data to the file data 
            dataInput.Text = " "; // sets the input box to blank. Thought this would improve UX
            dataDisplay.Text = contents; // puts the old data and new data into the data text box
        }
        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                int Start, End;
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }

            return "";
        }
        struct classBlock
        {
            string className;
            string profName;
            string days;
            int startTime;
            int endTime;
            public classBlock(int startTime, int endTime, string prof, string classname, string day)
            {
                this.startTime = startTime;
                this.endTime = endTime;
                this.days = day;
                this.profName = prof;
                this.className = classname;
            }
            public string getProf()
            {
                return this.profName;
            }
            public string getClassName()
            {
                return this.className;
            }
            public string getDays()
            {
                return this.days;
            }
            public int getStartTime()
            {
                return this.startTime;
            }
            public int getEndTime()
            {
                return this.endTime;
            }


        }
        classBlock[] Class1 = new classBlock[200];
        
        private void processButton_Click(object sender, EventArgs e)
        {
            int a = 0;
            int y = 0;
            while(a < count)
            {
               string cleaned =  Regex.Replace(lines[a], ",", " ");
                lines[a] = cleaned;
                a = a + 1;
            }

            while(y < count)
            {

                string classNum = getBetween(lines[y], "CSC ", " ");
                classNum = "CSC" + classNum;
                string classProf = getBetween(lines[y], "\"", "\"");
                string startTime = getBetween(lines[y], "[", " ");
                string endTime = getBetween(lines[y], " ", "]");
                int timeStart = Convert.ToInt32(startTime);
                int timeEnd = Convert.ToInt32(endTime);
                

                Class1[y] = new classBlock(timeStart, timeEnd, classProf, classNum, "y");
                y = y + 1;
            }
            //MessageBox.Show(lines[lines.Length -1]);
            //MessageBox.Show(file.FileName);

            




            string output = Class1[4].getClassName() + " " + Class1[4].getProf() + " " + Class1[4].getStartTime() + " " + Class1[4].getEndTime();
            
            MessageBox.Show(output);
            
        }
    }
}
