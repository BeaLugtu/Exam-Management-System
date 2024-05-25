using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
namespace Exam_Management_System.Designs
{
    public partial class ContextualImageCard : UserControl
    {
        private byte[] imageBytes;
        public ContextualImageCard()
        {
            InitializeComponent();
        }
        public byte[] ImageBytes
        {
            get => imageBytes;
            set
            {
                imageBytes = value;
                UpdateImage();
            }
        }

        private void UpdateImage()
        {
            if (imageBytes != null && imageBytes.Length > 0)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        Image image = Image.FromStream(ms);
                        // Assign image to PictureBox
                        imagecard.Image = image;
                    }
                }
                catch (ArgumentException)
                {
                    // Load default profile icon
                    imagecard.Image = Properties.Resources.profile_icon;
                }
            }
            else
            {
                // If imageBytes is null or empty, set default profile icon
                imagecard.Image = Properties.Resources.profile_icon;
            }
        }
    }
}

