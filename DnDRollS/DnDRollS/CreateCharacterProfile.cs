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
    public partial class uxCreateCharacterProfile : Form
    {
        public string Filename { get; private set; }

        private string[] _txtFile = new string[50];

        private string[] _dictionaryKeys = new string[50];

        private string[] _extraKeys = new string[6];

        private Dictionary<string, int> _dictionary = new Dictionary<string, int>();

        private Dictionary<string, string> _extraItems = new Dictionary<string, string>();

        private Dictionary<string, string> _STPRof = new Dictionary<string, string>();

        private Dictionary<string, string> _CProf = new Dictionary<string, string>();   

        
        public uxCreateCharacterProfile()
        {
            InitializeComponent();
        }

        private void CreateDictionaries()
        {
            int j = 0;
            foreach(GroupBox gb in this.Controls)
            {
                
                foreach(NumericUpDown n in gb.Controls)
                {
                    _dictionary.Add(n.Tag.ToString(), Convert.ToInt32(n.Value));
                    _dictionaryKeys[j] = n.Tag.ToString();
                    j++;
                }
            }
            _extraItems.Add(uxCharacterName.Tag.ToString(), uxCharacterName.Text);
            _extraKeys[0] = uxCharacterName.Tag.ToString();
            for(int i = 0; i < uxSavingThrowsChecklist.Items.Count;i++)
            {
                if(uxSavingThrowsChecklist.GetItemChecked(i))
                {
                    _extraItems.Add(uxSavingThrowsChecklist.Items[i].ToString(), "");
                    _extraKeys[i+1] = uxSavingThrowsChecklist.Items[i].ToString();
                }
            }
            for(int i = 0; i < uxProficiencyChecklist.Items.Count; i++)
            {
                if(uxProficiencyChecklist.GetItemChecked(i))
                {
                    _CProf.Add(uxProficiencyChecklist.Items[i].ToString(), "");
                }
            }


        }

        

        private void uxCreateButton_Click(object sender, EventArgs e)
        { 
            using (StreamWriter sw = new StreamWriter(Filename))
            {
                for(int a = 0; a < _txtFile.Length; a++)
                {
                    sw.WriteLine(e);
                }
            }
            
        }
        

        private void CreateTextForFile()
        {
            for(int i = 0; i < _dictionary.Count;i++)
            {
                foreach(string s in _dictionary.Keys)
                {
                    _txtFile[i] = s + _dictionary[_dictionaryKeys[i]].ToString();
                }
            }
            for(int i = _dictionary.Count; i< _extraItems.Count+_dictionary.Count;i++)
            {
                if(i == _dictionary.Count)
                {
                    _txtFile[i] = _extraKeys[0];
                }
                else
                {
                    _txtFile[i] = _extraItems[_extraKeys[i]];
                }
            }
            int j = _dictionary.Count + _extraItems.Count;
            foreach(String key in _CProf.Keys)
            {
                _txtFile[j] = key;
                j++;
            }
        }

        private void CreateCharacterFile()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text Files (*.txt)|*.txt";
            save.ShowDialog();
            Filename = save.FileName;

        
        }
    }//end class
}//end namespace
