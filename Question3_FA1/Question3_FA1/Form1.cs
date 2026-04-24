//Wian Sandenbergh
//Question 3
/*
- Allow the user to add a programming language to the list
- Prevent empty input from being added
- Prevent duplicate languages from being addded
- Allow the user to remove a selected language
- Display the date and time when a language
*/
namespace Question3_FA1
{
    public partial class frmFPL : Form
    {
        public frmFPL()
        {
            //Setting up the Forms default values
            InitializeComponent();
            btnAdd.BackColor = Color.Blue;
            btnRemove.BackColor = Color.Red;
            lblTitel.Font = new Font(lblTitel.Font, FontStyle.Bold);
            lblFeedback.Font = new Font(lblFeedback.Font, FontStyle.Italic);
            lblFeedback.ForeColor = Color.Gray;
        }
        //Creating the class for the add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string language = txtInput.Text.Trim();
            //Checking if the input is null and giving user feedback
            if (string.IsNullOrEmpty(language))
            {
                MessageBox.Show("Please enter a programming language.");
                return;
            }
            //Looping through the list to make sure you are not adding one that is already there
            foreach (var item in lstLanguages.Items)
            {
                //The checking for doubles
                if (item.ToString().ToLower() == language.ToLower())
                {
                    //Giving the user feedback
                    MessageBox.Show("Language already exists.");
                    return;
                }
            }
            //Clearing the input box after adding the input to the listbox
            lstLanguages.Items.Add(language);
            txtInput.Clear();
            //Adding what is added and the current time and date to the output label
            lblFeedback.Text = $"Added '{language}' at {DateTime.Now:dd MMM yyyy HH:mm:ss}";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Checking if the input is null then giving feedback
            if (lstLanguages.SelectedItem == null)
            {
                MessageBox.Show("Please select a language to remove.");
                return;
            }
            //Saving selected item to use later
            string removed = lstLanguages.SelectedItem.ToString();
            //Remove the item
            lstLanguages.Items.Remove(lstLanguages.SelectedItem);
            //Generating the output label text
            lblFeedback.Text = $"Removed '{removed}' at {DateTime.Now:dd MMM yyyy HH:mm:ss}";
        }
        private void lstLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }
        private void grpMain_Enter(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
