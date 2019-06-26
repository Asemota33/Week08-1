using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week08_1
{
    public partial class Lab08Form : Form
    {
        public string UserName { get; set; }
        public float UserAge { get; set; }

        /// <summary>
        /// This is the Constructor for Lab08Form
        /// </summary>
        public Lab08Form()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the submit button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitButton_Click(object sender, EventArgs e)
        {
            UserName = nameTextBox.Text;
            UserAge = float.Parse(ageTextBox.Text);

            outputLabel.Text = nameTextBox.Text + " " + ageTextBox.Text;
            ClearForm();
        }

        /// <summary>
        /// This method clears the form
        /// </summary>
        private void ClearForm()
        {
            nameTextBox.Clear();
            ageTextBox.Clear();
            submitButton.Enabled = false;
        }

        /// <summary>
        /// This is the event handler for the age text box for every time the text change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ageTextBox_TextChanged(object sender, EventArgs e)
        {
            //age input validation 
                try
                {
                    float.Parse(ageTextBox.Text);
                    submitButton.Enabled = true;

                }
                catch (Exception)
                {
                    submitButton.Enabled = false;

                }
            
        }
        /// <summary>
        /// Event handler for the initial load of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab08Form_Load(object sender, EventArgs e)
        {
            ClearForm();
        }
        /// <summary>
        /// This is the event handler for the name text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
           
            submitButton.Enabled = (nameTextBox.Text.Length < 2) ? false : true;
           
        }
    }
}
