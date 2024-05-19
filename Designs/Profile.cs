using Krypton.Toolkit;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Exam_Management_System.Properties;
using MySql.Data.MySqlClient;
using KryptonTextBox = Krypton.Toolkit.KryptonTextBox;

namespace Exam_Management_System.Designs
{
    public partial class Profile : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        DBAccess objDABAccess = new DBAccess();
        DataTable dtloggedin_User = new DataTable();
        private Dictionary<string, bool> fieldModified = new Dictionary<string, bool>(); // Track modified fields
        private string user_ID;
        private string accounttype;
        private bool hasUnsavedChanges = false;

        public Profile(string userID, UserType userType)
        {
            InitializeComponent();
            //Getting parameters from homepage
            this.user_ID = userID;
            accounttype = userType.ToString();
            PopulateProgramComboBox();
            loadkeypess();
            StoreInitialValues(); // Store initial values after loading data
            SubscribeToModificationEvents(); // Subscribe to events after initial values are stored
        }
        private void Profile_Load(object sender, EventArgs e)
        {
            timer1.Start();
            SetLabels();
            MakePictureBoxCircular(pfpbox);
            GetUserInfo();
            
        }
        private void loadkeypess()
        {
            ID.KeyPress += new KeyPressEventHandler(ID_KeyPress);
            first_name.KeyPress += new KeyPressEventHandler(first_name_KeyPress);
            last_name.KeyPress += new KeyPressEventHandler(last_name_KeyPress);
            email.KeyPress += new KeyPressEventHandler(email_KeyPress);
            Program_Combo_Box.KeyPress += new KeyPressEventHandler(Program_Combo_Box_KeyPress);
            SaveBtn.KeyPress += new KeyPressEventHandler(SaveBtn_KeyPress);
            password_cr.KeyPress += new KeyPressEventHandler(password_cr_KeyPress);
            newpassword.KeyPress += new KeyPressEventHandler(newpassword_KeyPress);
            newpassword2.KeyPress += new KeyPressEventHandler(newpassword2_KeyPress);
            ChangePasswordButton.KeyPress += new KeyPressEventHandler(ChangePasswordButton_KeyPress);
            UploadPfpBtn.KeyPress += new KeyPressEventHandler(UploadPfpBtn_KeyPress);
            RemovePfpBtn.KeyPress += new KeyPressEventHandler(RemovePfpBtn_KeyPress);
        }
        private void SubscribeToModificationEvents()
        {
            first_name.TextChanged += Control_Modified;
            last_name.TextChanged += Control_Modified;
            email.TextChanged += Control_Modified;
            Program_Combo_Box.SelectedIndexChanged += Control_Modified;
            ID.TextChanged += Control_Modified;
            password_cr.TextChanged += Control_Modified;
            newpassword.TextChanged += Control_Modified;
            newpassword2.TextChanged += Control_Modified;
            pfpbox.Click += Control_Modified;
        }

        private void StoreInitialValues()
        {
            first_name.Tag = first_name.Text;
            last_name.Tag = last_name.Text;
            email.Tag = email.Text;
            Program_Combo_Box.Tag = Program_Combo_Box.SelectedIndex;
            ID.Tag = ID.Text;
            password_cr.Tag = password_cr.Text;
            newpassword.Tag = newpassword.Text;
            newpassword2.Tag = newpassword2.Text;
        }
        private void Backbtn_Click(object sender, EventArgs e)
        {
            {
                if (hasUnsavedChanges)
                {
                    HandleUnsavedChanges();
                }
                else
                {
                    this.Close();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
            }
        }

        private void HandleUnsavedChanges()
        {
            if (hasUnsavedChanges)
            {
                var result = MessageBox.Show(
                    "You have unsaved changes on your Profile. Click yes to save?",
                    "Unsaved Changes",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    SaveBtn_Click(null, null);
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
        private void Control_Modified(object sender, EventArgs e)
        {
            Control control = sender as Control;

            if (control is KryptonTextBox)
            {
                if (control.Text != control.Tag.ToString())
                {
                    hasUnsavedChanges = true;
                }
            }
            else if (control is Krypton.Toolkit.KryptonComboBox)
            {
                if ((control as Krypton.Toolkit.KryptonComboBox).SelectedIndex != (int)control.Tag)
                {
                    hasUnsavedChanges = true;
                }
            }
            else if (control is PictureBox)
            {
                if ((control as PictureBox).Image != (Image)control.Tag)
                {
                    hasUnsavedChanges = true;
                }
            }
        }
        
        //100% Working
        private void timer1_Tick(object sender, EventArgs e)
        {
            timelabel.Text = $"{DateTime.Now.ToString("hh:mm tt")} — {DateTime.Now.ToString("ddd, MMM d")}";
        }
        
        //to edit
        //100% Working
        private void SetLabels()
        {
            user_id.Text = "User ID: " + user_ID;
            account_type.Text = "Account Type: " + accounttype;
            StudentIdLabel.Text = accounttype + "_ID";

            switch (accounttype)
            {
                case "Student":
                    ProgramLabel.Text = "Programs";
                    break;
                case "Teacher":
                    ProgramLabel.Text = "Departments";
                    break;
                default:
                    ProgramLabel.Text = "Programs"; // Default to Programs if account type is unrecognized
                    break;
            }
        }
        private void PopulateProgramComboBox()
        {
            Program_Combo_Box.Items.Clear();

            if (accounttype == "Student")
            {
                Program_Combo_Box.Items.AddRange(new object[]
                {
            "--Select Program--",
            "BS PSY - Bachelor of Science in Psychology (CLAS)",
            "BS MATH - Bachelor of Science in Mathematics (CLAS)",
            "BSCS - Bachelor of Science in Computer Science (CLAS)",
            "BSIS - Bachelor of Science in Information Systems (CLAS)",
            "BSIT - Bachelor of Science in Information Technology (CLAS)",
            "BSEMC - Bachelor of Science in Entertainment and Multimedia Computing (CLAS)",
            "BPA - Bachelor of Public Administration (CLAS)",
            "BPA ECGE - Bachelor of Public Administration Evening Class for Govt Employees (CLAS)",
            "BA COMM - Bachelor of Arts in Communication (CLAS)",
            "BA POS - Bachelor of Arts in Political Science (CLAS)",
            "BSOAD - Bachelor of Science in Office Administration (CBA)",
            "BSAIS - Bachelor of Science in Accounting Information Systems (CBA)",
            "BSA - Bachelor of Science in Accountancy (CBA)",
            "BSTM - Bachelor of Science in Tourism Management (CBA)",
            "BSHM - Bachelor of Science in Hospitality Management (CBA)",
            "BSBA FMGT - Bachelor of Science in Business Administration Major in Financial Management (CBA)",
            "BSBA MKTG - Bachelor of Science in Business Administration Major in Marketing Management (CBA)",
            "BS ENTREP - Bachelor of Science in Entrepreneurship (CBA)",
            "BSBA HRM - Bachelor of Science in Business Administration Major in Human Resource Management (CBA)",
            "BEED ECED - Bachelor in Elementary Education Major in Early Childhood Education (COE)",
            "BSE SCI - Bachelor in Secondary Education Major in Science (COE)",
            "BS CRIM - Bachelor of Science in Criminology (COC)"
                });
            }
            else if (accounttype == "Teacher")
            {
                Program_Combo_Box.Items.AddRange(new object[]
                {
            "--Select Department--",
            "UCC Communication Advocates",
            "ASAP-North",
            "UCC Public Administration Society",
            "UCC Psychology Society",
            "Computer Studies Department - North",
            "UCC Mathematics"
                });
            }
        }
        private void GetUserInfo()
        {
            string query = "SELECT * FROM users WHERE ID = '" + user_ID + "'";
            objDABAccess.readDatathroughAdapter(query, dtloggedin_User);

            if (dtloggedin_User.Rows.Count > 0)
            {
                object studentIDObj = dtloggedin_User.Rows[0]["User_TypeID"];
                string dbstudentID = (studentIDObj != DBNull.Value) ? studentIDObj.ToString().Trim() : "";

                ID.Text = string.IsNullOrWhiteSpace(dbstudentID) ? "Your ID" : dbstudentID;

                // Display First Name
                object firstnameObj = dtloggedin_User.Rows[0]["First_Name"];
                string dbFirstname = (firstnameObj != DBNull.Value) ? firstnameObj.ToString() : "";
                first_name.Text = string.IsNullOrWhiteSpace(dbFirstname) ? "First_Name" : dbFirstname;

                // Display Last Name
                object lastnameObj = dtloggedin_User.Rows[0]["Last_Name"];
                string dbLastname = (lastnameObj != DBNull.Value) ? lastnameObj.ToString() : "";
                last_name.Text = string.IsNullOrWhiteSpace(dbLastname) ? "Last_Name" : dbLastname;

                // Display Email
                object emailObj = dtloggedin_User.Rows[0]["Email"];
                string dbEmail = (emailObj != DBNull.Value) ? emailObj.ToString() : "";
                email.Text = string.IsNullOrWhiteSpace(dbEmail) ? "youremail@gmail.com" : dbEmail;

                // Display Program
                object programObj = dtloggedin_User.Rows[0]["Program_Department"];

                if (programObj != DBNull.Value) // Check if the value is not DBNull
                {
                    string dbprogram = programObj.ToString();
                    Program_Combo_Box.Text = dbprogram;
                }
                else
                {
                    Program_Combo_Box.SelectedIndex = 0;
                }
                Program_Combo_Box.SelectedIndexChanged += (sender, e) =>
                {
                    fieldModified["Program_Department"] = true;
                };

                //Display Profile
                LoadImageFromDatabase();

            }
            else
            {
                // Handle case when no data is retrieved for the given userID
                MessageBox.Show("No data found for the given User ID.");
            }
        }
        //100% Working
        private void MakePictureBoxCircular(PictureBox pictureBox)
        {
            // Set the PictureBox size mode to stretch image
            pfpbox.SizeMode = PictureBoxSizeMode.StretchImage;
            // Create a circular region for the PictureBox
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);
            pictureBox.Region = new Region(path);
        }
        //100% Working
        private bool profilePictureAltered = false;
        private void LoadImageFromDatabase()
        {
            // Assuming you have a PictureBox named pictureBox1 on your form
            PictureBox pictureBox = pfpbox;

            string query = "SELECT profile_pic FROM users WHERE ID = '" + user_ID + "'";
            objDABAccess.readDatathroughAdapter(query, dtloggedin_User);

            if (dtloggedin_User.Rows.Count > 0)
            {
                // Retrieve profile pic data from the DataTable
                object profilePicObj = dtloggedin_User.Rows[0]["profile_pic"];

                // Convert byte array to Image
                byte[] imageData = profilePicObj as byte[];
                if (imageData != null && imageData.Length > 0)
                {
                    try
                    {
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            Image image = Image.FromStream(ms);
                            // Assign image to PictureBox
                            pictureBox.Image = image;
                            // Reset the flag since the loaded image is not altered yet
                            profilePictureAltered = false;
                        }
                    }
                    catch (ArgumentException)
                    {
                        // Load default profile icon
                        pictureBox.Image = Properties.Resources.profile_icon;
                    }
                }
                else
                {
                    // If imageData is null or empty, set default profile icon
                    pictureBox.Image = Properties.Resources.profile_icon;
                }
            }
            else
            {
                // Handle case when no data is retrieved for the given userID
                MessageBox.Show("No image found for the given User ID.");
            }
        }
        //100% Working
        private void UploadPfpBtn_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Display the selected image
                        pfpbox.Image = new Bitmap(openFileDialog.FileName);
                        // Set the flag to indicate that the profile picture has been altered
                        profilePictureAltered = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }
            }
        }
        //100% Working
        private bool profilePictureRemoved = false;
        private void RemovePfpBtn_Click(object sender, EventArgs e)
        {
            pfpbox.Image = Properties.Resources.profile_icon;
            profilePictureRemoved = true;
            profilePictureAltered = true;

        }
        //100% Working
        private void updatePfp()
        {
            // Check if the profile picture is removed
            if (profilePictureRemoved)
            {
                // Set Profile_pic to null in the database
                string updateQuery = "UPDATE users SET Profile_pic = NULL WHERE ID = '" + user_ID + "'";
                objDABAccess.readDatathroughAdapter(updateQuery, dtloggedin_User);
            }
            else
            {
                // Check if a profile picture is selected
                if (pfpbox.Image == null || pfpbox.Image == Resources.profile_icon)
                {
                    MessageBox.Show("No profile picture selected.");
                    return;
                }

                // Convert the selected profile picture to byte array
                byte[] imageData;
                using (MemoryStream ms = new MemoryStream())
                {
                    pfpbox.Image.Save(ms, pfpbox.Image.RawFormat);
                    imageData = ms.ToArray();
                }

                // Convert the byte array to hexadecimal string
                string hexImageData = BitConverter.ToString(imageData).Replace("-", "");

                // Execute the update query to update the Profile_pic field
                string updateQuery = "UPDATE users SET Profile_pic = 0x" + hexImageData + " WHERE ID = '" + user_ID + "'";
                objDABAccess.readDatathroughAdapter(updateQuery, dtloggedin_User);
            }
        }
        //100% Working
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            // Check if Program_Combo_Box is modified and the first row is selected
            if (fieldModified.ContainsKey("Program_Department") && fieldModified["Program_Department"] &&
                Program_Combo_Box.SelectedIndex == 0 &&
                string.IsNullOrEmpty(dtloggedin_User.Rows[0]["Program_Department"].ToString()))
            {
                MessageBox.Show("You must select a program.");
                return;
            }

            if (string.IsNullOrWhiteSpace(first_name.Text))
            {
                MessageBox.Show("First name cannot be empty or contain only whitespace characters.");
                isValid = false;
            }
            else if (!IsAlphabetical(first_name.Text))
            {
                MessageBox.Show("First name must contain only alphabetical characters.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(last_name.Text))
            {
                MessageBox.Show("Last name cannot be empty or contain only whitespace characters.");
                isValid = false;
            }
            else if (!IsAlphabetical(last_name.Text))
            {
                MessageBox.Show("Last name must contain only alphabetical characters.");
                isValid = false;
            }

            if (isValid)
            {
                if (first_name.Modified)
                    UpdateFieldIfModified(first_name, "First_Name");

                if (email.Modified)
                    UpdateFieldIfModified(email, "Email");

                if (last_name.Modified)
                    UpdateFieldIfModified(last_name, "Last_Name");

                if (fieldModified.ContainsKey("Program_Department") && fieldModified["Program_Department"])
                {
                    // Get the selected item or null if the first row is selected
                    string selectedProgram = Program_Combo_Box.SelectedIndex == 0 ? null : Program_Combo_Box.SelectedItem.ToString();

                    // If the first row is selected, display a message box and return without updating
                    if (selectedProgram == null)
                    {
                        MessageBox.Show("You must select a program.");
                        return;
                    }

                    // Call the method only if the selected program is different from the original data
                    if (selectedProgram != dtloggedin_User.Rows[0]["Program_Department"].ToString())
                    {
                        UpdateFieldIfModified(Program_Combo_Box, "Program_Department");
                    }
                }
                if (ID.Modified)
                    UpdateFieldIfModified(ID, "User_TypeID");

                // Check if the profile picture is altered
                if (profilePictureAltered)
                {
                    updatePfp(); // Only update if the image is altered
                }
            }
            hasUnsavedChanges = false; // Reset the flag after saving
            MessageBox.Show("Saved Successfully!!");
        }
        // Function to check if a string contains only alphabetical characters
        private bool IsAlphabetical(string str)
        {
            return Regex.IsMatch(str, "^[a-zA-Z ]+$");
        }
        //100% Working
        private void UpdateFieldIfModified(ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox, string fieldName)
        {
            string typedData = textBox.Text;
            string originalData = dtloggedin_User.Rows[0][fieldName].ToString(); // Get the original data from the database

            // Check if the text has been modified by the user
            if (typedData != originalData)
            {
                string query = "UPDATE users SET " + fieldName + " = '" + typedData.Replace("'", "''") + "' WHERE ID = '" + user_ID + "'";
                objDABAccess.readDatathroughAdapter(query, dtloggedin_User);  // Use the appropriate method to execute the update query
            }
        }
        //100% Working
        private void UpdateFieldIfModified(Krypton.Toolkit.KryptonComboBox comboBox, string fieldName)
        {
            string typedData = comboBox.SelectedIndex == 0 ? "" : comboBox.SelectedItem.ToString(); // Get the selected item, or an empty string if the first row is selected
            string originalData = dtloggedin_User.Rows[0][fieldName].ToString(); // Get the original data from the database

            // Check if the selection has been modified by the user
            if (typedData != originalData)
            {
                // If the first row is selected, show a message box
                if (comboBox.SelectedIndex == 0)
                {
                    MessageBox.Show("You must select a program.");
                    return;
                }

                string query = "UPDATE users SET " + fieldName + " = '" + typedData.Replace("'", "''") + "' WHERE ID = '" + user_ID + "'";
                objDABAccess.readDatathroughAdapter(query, dtloggedin_User);  // Use the appropriate method to execute the update query
            }
        }
        //
        //password
        //
        private void ChangePassword(string oldPassword, string newPassword, string confirmPassword)
        {
            // Check if old password is correct
            string query = "SELECT * FROM Users WHERE ID = '" + user_ID + "' AND Password = '" + oldPassword + "'";
            DataTable dtUsers = new DataTable();
            objDABAccess.readDatathroughAdapter(query, dtUsers);

            if (dtUsers.Rows.Count == 0)
            {
                MessageBox.Show("Old password is incorrect.");
                return;
            }
            if (!Regex.IsMatch(newPassword, @"[A-Z]"))
            {
                MessageBox.Show("New password must contain at least one uppercase letter.");
                return;
            }

            if (!Regex.IsMatch(newPassword, @"[a-z]"))
            {
                MessageBox.Show("New password must contain at least one lowercase letter.");
                return;
            }

            if (!Regex.IsMatch(newPassword, @"[0-9]"))
            {
                MessageBox.Show("New password must contain at least one number.");
                return;
            }

            if (!Regex.IsMatch(newPassword, @"[\W_]"))
            {
                MessageBox.Show("New password must contain at least one special character.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match.");
                return;
            }

            // Update the password in the database
            string updateQuery = "UPDATE Users SET Password = @NewPassword WHERE ID = @UserID";
            MySqlCommand command = new MySqlCommand(updateQuery);
            command.Parameters.AddWithValue("@NewPassword", newPassword);
            command.Parameters.AddWithValue("@UserID", user_ID);
            objDABAccess.executeQuery(command);
        }
        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {

            string oldPassword = GetOldPasswordFromDatabase();
            string newPassword = newpassword.Text;
            string confirmPassword = newpassword2.Text;

            if (newPassword != "newpassword" || confirmPassword != "newpassword2")
            {
                ChangePassword(oldPassword, newPassword, confirmPassword);
            }
            else
            {
                MessageBox.Show("New password cannot be the same as the preloaded data.");
            }
        }
        private string GetOldPasswordFromDatabase()
        {
            // Fetch the old password from the database based on the user's ID
            string query = "SELECT Password FROM Users WHERE ID = '" + user_ID + "'";
            DataTable dtPassword = new DataTable();
            objDABAccess.readDatathroughAdapter(query, dtPassword);

            if (dtPassword.Rows.Count > 0)
            {
                return dtPassword.Rows[0]["Password"].ToString();
            }
            else
            {
                MessageBox.Show("Error: Old password not found.");
                return null;
            }
        }
        private void password_cr_TextChanged(object sender, EventArgs e)
        {
            ClearIfPreloadedData(password_cr, "password_cr");
        }
        private void newpassword_TextChanged(object sender, EventArgs e)
        {
            ClearIfPreloadedData(newpassword, "newpassword");
        }
        private void newpassword2_TextChanged(object sender, EventArgs e)
        {
            ClearIfPreloadedData(newpassword2, "newpassword2");
        }
        private void ClearIfPreloadedData(ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox, string preloadedData)
        {
            if (textBox.Text == preloadedData)
            {
                textBox.Clear();
                textBox.UseSystemPasswordChar = true;
                
            }
        }
        private void Program_Combo_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            string userInput = Program_Combo_Box.Text;

            // Filter the items in the combo box based on the user input
            List<string> filteredItems = new List<string>();
            foreach (string item in Program_Combo_Box.Items)
            {
                if (item.StartsWith(userInput, StringComparison.OrdinalIgnoreCase))
                {
                    filteredItems.Add(item);
                }
            }

            // If there is exactly one item that matches the user input, select it
            if (filteredItems.Count == 1)
            {
                Program_Combo_Box.SelectedItem = filteredItems[0];
            }
        }
        private void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrEmpty(ID.Text))
                {
                    MessageBox.Show("Please enter your ID before proceeding.");
                    e.Handled = true;
                }
                else
                {
                    first_name.Focus();
                    e.Handled = true;
                }
            }
        }

        private void first_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                last_name.Focus();
                e.Handled = true;
            }
        }

        private void last_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                email.Focus();
                e.Handled = true;
            }
        }

        private void email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Program_Combo_Box.Focus();
                e.Handled = true;
            }
        }

        private void Program_Combo_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SaveBtn.Focus();
                e.Handled = true;
            }
        }

        private void SaveBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                password_cr.Focus();
                e.Handled = true;
            }
        }

        private void password_cr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                newpassword.Focus();
                e.Handled = true;
            }
        }

        private void newpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                newpassword2.Focus();
                e.Handled = true;
            }
        }

        private void newpassword2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ChangePasswordButton.Focus();
                e.Handled = true;
            }
        }
        private void UploadPfpBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Perform a click action on UploadPfpBtn
                UploadPfpBtn.PerformClick();

                // Prevent the Enter key from being processed further
                e.Handled = true;
            }
        }

        private void RemovePfpBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Perform a click action on RemovePfpBtn
                RemovePfpBtn.PerformClick();

                // Prevent the Enter key from being processed further
                e.Handled = true;
            }
        }
/*
        private void Backbtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Perform a click action on Backbtn
                Backbtn.Focus();
                if (e.KeyChar == (char)Keys.Enter)
                    Backbtn.PerformClick();

                // Prevent the Enter key from being processed further
                e.Handled = true;
            }
        }
*/

        private void ChangePasswordButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Perform a click action on ChangePasswordButton
                ChangePasswordButton.PerformClick();

                // Prevent the Enter key from being processed further
                e.Handled = true;
            }
        }

    }
}
