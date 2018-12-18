using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDRollS
{
    public partial class uxLoadCharacterScreen : Form
    {
        public uxLoadCharacterScreen()
        {
            InitializeComponent();

        }

        private void uxCreateNewCharacter_Click(object sender, EventArgs e)
        {
            uxCreateCharacterProfile createForm = new uxCreateCharacterProfile();
            createForm.ShowDialog();
        }
    }
}
