using System;
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
    public partial class uxCreateCharacterProfile : Form
    {
        public uxCreateCharacterProfile()
        {
            InitializeComponent();
        }

        private void CreateDictionary()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach(GroupBox gb in this.Controls)
            {
                foreach(NumericUpDown n in gb.Controls)
                {

                }
            }
        }

        private void uxCreateButton_Click(object sender, EventArgs e)
        {
            string[] txtFile = new string[30];
            for(int i = 0; i < 18;i++)
            {
                txtFile[i] = "";
            }
        }


        private void CreateCharacterFile()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text Files (*.txt)|*.txt";
            save.ShowDialog();
        }


    }//end class
}//end namespace
