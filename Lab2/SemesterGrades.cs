// Author: Adonai Ford-Williams
// Date: February 7th, 2021
// Lab 2
// NETD 2202
// Description:
// This form calculates the average of seven user inputted grades. 
// It will assign the appropriate letter grade for the user inputted grade


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class SemesterGrades : Form
    {
        public SemesterGrades()
        {
            InitializeComponent();
        }

        #region "Declarations"
        /// <summary>
        /// Variables and Arrays being declared/initialized
        /// </summary>
        
        TextBox[] inputTextBoxArray;
        Label[] outputLabelArray;

        double totalGrade = 0;
        #endregion


        #region "Event Handlers"
        /// <summary>
        /// Inputting values for the arrays and setting the form to default values on launch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SemesterGrades_Load(object sender, EventArgs e)
        {
            inputTextBoxArray = new TextBox[] { textBoxCourse1, textBoxCourse2, textBoxCourse3, textBoxCourse4, textBoxCourse5, textBoxCourse6, textBoxCourse7 };
            outputLabelArray = new Label[] { labelgrade1, labelgrade2, labelgrade3, labelgrade4, labelgrade5, labelgrade6, labelgrade7 };
            SetDefaults();
        }

        // Exit button
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Reset button
        private void buttonReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        // Calculate button
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // Local variable to store the average
            double semesterAverage = 0;
            
            // Validation of the input array
            if (ValidateGradeTextbox(inputTextBoxArray))
            {
                textBoxOutput.Clear();
                // Perform calculation
                semesterAverage = Math.Round(totalGrade / inputTextBoxArray.Length, 2);
                // Print display to appropriate labels and textboxes
                textBoxSemester.Text = semesterAverage.ToString();
                textBoxOutput.Text = "Your semesters GPA is: " + FindLetterGrade(semesterAverage);
                labelgradeSemester.Text = FindLetterGrade(semesterAverage);

                // Disable inputs
                buttonCalculate.Enabled = false;
                SetControlsEnabled(inputTextBoxArray, false);
                buttonReset.Focus();
            }

        }

        // Assigning the Letter grade after grade has been inputted
        private void LeaveTextbox(object sender, EventArgs e)
        {
            double gradeEarned;

            for(int inputIndex = 0; inputIndex < inputTextBoxArray.Length; inputIndex++)
            {
                if (double.TryParse(inputTextBoxArray[inputIndex].Text, out gradeEarned))
                {
                    outputLabelArray[inputIndex].Text = FindLetterGrade(gradeEarned);
                }
            }
        }

        #endregion

        #region // Functions

        private void ClearControls(Control[] controlArray)
        {
            foreach (Control controlToClear in controlArray)
            {
                controlToClear.Text = String.Empty;
            }
        }

        /// <summary>
        /// This enables or disables all controls in an array of controls that is passed in
        /// </summary>
        /// <param name="controlArray">An array of controls to enable or disable</param>
        /// <param name="enabledStatus">true to enable, false to disable</param>
        private void SetControlsEnabled(Control[] controlArray, bool enabledStatus)
        {
            foreach (Control controlToSet in controlArray)
            {
                controlToSet.Enabled = enabledStatus;
            }
        }

        /// <summary>
        /// Sets everything to the initial default values to reset everything
        /// </summary>
        private void SetDefaults()
        {
            ClearControls(inputTextBoxArray);
            ClearControls(outputLabelArray);
            textBoxOutput.Clear();
            textBoxSemester.Clear();
            labelgradeSemester.Text = "";
            totalGrade = 0;

            // Re-enable all buttons and inputs
            SetControlsEnabled(inputTextBoxArray, true);
            buttonCalculate.Enabled = true;

            // Focus on first input text box
            textBoxCourse1.Focus();
        }

        /// <summary>
        /// Validate the inputs
        /// </summary>
        /// <param name="textBoxInput"></param>
        /// <returns></returns>
        private bool ValidateGrade(TextBox textBoxInput)
        {
            // Range constants for highest and lowest allowed grade
            const int MaximumRange = 100;
            const int MinimumRange = 0;
            double grade;

            // If it passes
            if(double.TryParse(textBoxInput.Text, out grade) && (grade >= MinimumRange & grade <= MaximumRange ))
            {
                // Add grade to total grade
                totalGrade += grade;
                // return true
                return true;
            }
            else
            {
                // Display error message
                textBoxOutput.Text += "The value " + grade + " is not valid. Please enter a numeric value between " + MinimumRange + " and " + MaximumRange + "\r\n";
                textBoxInput.SelectAll();
                // Focus on wrong boxes
                textBoxInput.Focus();
                return false;
            }
        }

        /// <summary>
        /// Checking if textbox has a valid number in valid range
        /// </summary>
        /// <param name="textValidation"></param>
        /// <returns>Returns true if textbox is valid</returns>
        private bool ValidateGradeTextbox(TextBox[] textValidation)
        {
            bool isValid = true;

            foreach (TextBox textBoxToCheck in textValidation)
            {
                isValid &= ValidateGrade(textBoxToCheck);
            }
            return isValid;
        }

        /// <summary>
        /// Determines the letter grade based on numeric grade 
        /// </summary>
        /// <param name="numericgrade"></param>
        /// <returns></returns>
        private string FindLetterGrade(double numericgrade)
        {
            double[] numericGradeArray = { 0, 50, 55, 60, 65, 70, 75, 80, 85, 90 };
            string[] letterGradeArray = { "F", "D", "D+", "C", "B-", "B", "B+", "A-", "A", "A+" };
            string letterGradeOutput = "";

            // Iterating over the array's to match the appropriate letter grades with numeric
            for (int counter = 0; counter < numericGradeArray.Length; counter++)
            {
                if (numericgrade >= numericGradeArray[counter])
                {
                    letterGradeOutput = letterGradeArray[counter];
                }
            }
            // Return the appropriate letter grade
            return letterGradeOutput;
        }
        #endregion
    }
}