using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared;
using System.Numerics;
using System.IO;

namespace LamaczHaselGUI
{
    public partial class SerwerForm : Form
    {
        private Package package;
        private HostConnectionHandler hostConnectionHandler;
        private StreamReader file;
        List<char> checkedChars = new List<char>();
        private string dictionaryFileName = "D:\\LamaczHasel\\plik.txt";
        private List<Package> testPackages = new List<Package>();
        private bool testMode = false;


        ConvertPasswordCode convert = new ConvertPasswordCode();

        public SerwerForm()
        {
            InitializeComponent();
            for (int i = 0; i < checkedMale.Items.Count; i++)
            {
                checkedMale.SetItemChecked(i, true);
            }
        }

        private void btMale_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedMale.Items.Count; i++)
            {
                checkedMale.SetItemChecked(i, true);
            }
        }

        private void btWielkie_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedWielkie.Items.Count; i++)
            {
                checkedWielkie.SetItemChecked(i, true);
            }
        }

        private void btCyfry_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedCyfry.Items.Count; i++)
            {
                checkedCyfry.SetItemChecked(i, true);
            }
        }

        private void btSpecjalne_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedSpecjalne.Items.Count; i++)
            {
                checkedSpecjalne.SetItemChecked(i, true);
            }
        }

        private void btWszystko_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedMale.Items.Count; i++)
            {
                checkedMale.SetItemChecked(i, true);
            }
            for (int i = 0; i < checkedWielkie.Items.Count; i++)
            {
                checkedWielkie.SetItemChecked(i, true);
            }
            for (int i = 0; i < checkedCyfry.Items.Count; i++)
            {
                checkedCyfry.SetItemChecked(i, true);
            }
            for (int i = 0; i < checkedSpecjalne.Items.Count; i++)
            {
                checkedSpecjalne.SetItemChecked(i, true);
            }
        }

        private void btWyczysc_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedMale.Items.Count; i++)
            {
                checkedMale.SetItemChecked(i, false);
            }
            for (int i = 0; i < checkedWielkie.Items.Count; i++)
            {
                checkedWielkie.SetItemChecked(i, false);
            }
            for (int i = 0; i < checkedCyfry.Items.Count; i++)
            {
                checkedCyfry.SetItemChecked(i, false);
            }
            for (int i = 0; i < checkedSpecjalne.Items.Count; i++)
            {
                checkedSpecjalne.SetItemChecked(i, false);
            }

        }

        private void btPolacz_Click(object sender, EventArgs e)
        {
            lbStan.Text = "Łączenie";
            lbStan.ForeColor = System.Drawing.Color.Blue;

            btPolacz.Enabled = false;
            hostConnectionHandler = new HostConnectionHandler();
            hostConnectionHandler.open();
            lbStan.Text = "Połączono";
            lbStan.ForeColor = System.Drawing.Color.Green;
            btStart.Enabled = true;
            btTest.Enabled = true;
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            this.package = new Package();
            btStart.Enabled = false;

            package.clearAlphabet();
            package.getPasswordsToCrack().Clear();
            package.setDictionaryFileCheckSum(dictionaryFileName);
            package.setSizePackage(Convert.ToInt32(textPaczka.Text));
            package.setFirstIndex(BigInteger.Parse(textIndex.Text));

            if (rdBruteForce.Checked == true)
            {
                package.setMethod(0);

                package.setAlphabet(getCheckedItems());
            }
            if (rdSlownik.Checked == true)
            {
                package.setMethod(1);

                foreach (string item in checkedTransformation.CheckedItems)
                {
                    Transformations trn = (Transformations)Enum.Parse(typeof(Transformations), item);
                    package.setTransformationFlags(package.getTransformationFlags() | (int)trn);
                }
            }

            foreach (string item in listMD5Hash.Items)
            {
                package.addPasswordsToCrack(item);
            }


            if (package.getAlphabet() == null)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Warning", "Nie ma znaków", buttons);
            }

            hostConnectionHandler.setPackage(package);
            btStop.Enabled = true;
            lbProces.ForeColor = System.Drawing.Color.Green;
            lbProces.Text = "Przetwarzanie";
        }

        private void btPlik_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "TXT File|*.txt";
            open.Title = "Open File";
            if (open.ShowDialog() == DialogResult.OK)
                dictionaryFileName = textFilePath.Text = open.FileName;
        }

        private List<char> getCheckedItems()
        {
            List<char> checkedChars = new List<char>();

            foreach (string item in checkedMale.CheckedItems)
            {
                checkedChars.Add(item[0]);
            }
            foreach (string item in checkedWielkie.CheckedItems)
            {
                checkedChars.Add(item[0]);
            }
            foreach (string item in checkedCyfry.CheckedItems)
            {
                checkedChars.Add(item[0]);
            }
            foreach (string item in checkedSpecjalne.CheckedItems)
            {
                checkedChars.Add(item[0]);
            }
            return checkedChars;
        }

        private void btOblicz_Click(object sender, EventArgs e)
        {
            checkedChars = getCheckedItems();


            if (!string.IsNullOrWhiteSpace(textPassToCode.Text))
            {
                textCodeFromPass.Text = convert.baseToDec(textPassToCode.Text, checkedChars.ToArray()).ToString();
            }

            if (!string.IsNullOrWhiteSpace(textCodeToPass.Text))
            {
                BigInteger code = BigInteger.Parse(textCodeToPass.Text);
                textPassFromCode.Text = convert.decToBaseString(code, checkedChars.ToArray());
            }

        }

        private void textCodeToPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btMD_Click(object sender, EventArgs e)
        {
            if (!listMD5Hash.Items.Contains(textMD5Hash.Text))
                listMD5Hash.Items.Add(textMD5Hash.Text);
        }

        private void btDeleteHash_Click(object sender, EventArgs e)
        {
            listMD5Hash.Items.Remove(listMD5Hash.SelectedItem);
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            hostConnectionHandler.stopCracked();
            btStart.Enabled = true;
            btStop.Enabled = false;
            btTest.Enabled = true;
            testMode = false;
            lbProces.ForeColor = System.Drawing.Color.Red;
            lbProces.Text = "Anulowano";
        }

        private void btMD5Generate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textMD5Pass.Text))
            {
                MD5Hash md5hash = new MD5Hash();
                textMD5Hash.Text = md5hash.getMd5Hash(textMD5Pass.Text);

                //textCodeFromPass.Text = convert.baseToDec(textMD5Pass.Text, checkedChars.ToArray()).ToString();
            }

        }

        private void btClearOdp_Click(object sender, EventArgs e)
        {
            textOdp.Clear();
        }

        private void btHashTXTRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "TXT File|*.txt";
            open.Title = "Open File";
            if (open.ShowDialog() == DialogResult.OK)
            {
                file = new StreamReader(open.FileName);

                foreach (var item in File.ReadLines(open.FileName))
                {
                    if (!listMD5Hash.Items.Contains(item))
                        listMD5Hash.Items.Add(item);
                }

            }
        }

        private void btClearHashList_Click(object sender, EventArgs e)
        {
            listMD5Hash.Items.Clear();
        }

        private void btSavePassToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TXT File|*.txt";
            saveFileDialog.Title = "Save File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                File.WriteAllText(saveFileDialog.FileName, textOdp.Text);
        }

        private void btTest_Click(object sender, EventArgs e)
        {
            testPackages.Clear();
            btTest.Enabled = false;
            btStart.Enabled = false;
            btStop.Enabled = true;
            testMode = true;
            int[] testIndex = { 1000, 2000, 5000, 10000, 20000, 50000, 100000, 200000, 
                                  500000, 1000000, 1500000, 2000000, 3000000, 5000000 };
            List<string> testPassToCrack = new List<string>();
            foreach (string item in listMD5Hash.Items)
                testPassToCrack.Add(item);
            for (int i = 0; i < testIndex.Length; i++)
            {
                package = new Package(getCheckedItems(), BigInteger.Parse(textIndex.Text), testIndex[i], testPassToCrack);
                testPackages.Add(package);
            }
            nextTest();
        }

        public void nextTest()
        {
            if (testMode)
            {
                Program.getMainWindow().btStart.Enabled = false;
                Program.getMainWindow().btStop.Enabled = true;
                if (testPackages.Count > 0)
                {
                    hostConnectionHandler.setPackage(testPackages[0]);
                    testPackages.RemoveAt(0);
                }
                else
                {
                    testMode = false;
                    btStart.Enabled = true;
                    btTest.Enabled = true;
                    btStop.Enabled = false;
                }
            }
        }

    }
}
