namespace Quiz1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string firstName, lastName, sex;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(sex))
            {
                ListViewItem liv = new ListViewItem();
                liv.Text = firstName + " " + lastName + " - " + sex;
                string str = selectRaceEthnicity(liv.Text);
                str = selectCharacteristics(str);
                listView1.Items.Add(str);
            }
            else
            {
                MessageBox.Show("Complete all the fields");
            }

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            firstName = txtFirstName.Text;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            lastName = txtLastName.Text;
        }

        private void dpSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            sex = dpSex.SelectedItem.ToString();
        }

        private string selectRaceEthnicity(string str)
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    str += $" - {radioButton.Text}";
                    break;
                }
            }
            return str;
        }

        private string selectCharacteristics(string str)
        {
            bool isChecked = false;
            foreach (Control control in groupBox2.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    isChecked = true;
                    break;
                }
            }

            if (!isChecked)
            {
                return str;
            }


            string characters = "";
            foreach (Control control in groupBox2.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    characters += checkBox.Text + ", ";

                }

            }

            if (characters.Length > 0)
            {
                characters = characters.Remove(characters.Length - 2);
            }


            return $"{str} ( {characters} )";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if ( listView1.Items.Count == 0)
            {
                MessageBox.Show("Nothing to erase");
            }

            else if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                listView1.Items[listView1.Items.Count - 1].Remove();

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            dpSex.Text = string.Empty;
            rbWhite.Checked = true;

            listView1.Clear();
            
            
            foreach (Control control in groupBox2.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    checkBox.Checked = false;
                }
            }
        }
    }
}
