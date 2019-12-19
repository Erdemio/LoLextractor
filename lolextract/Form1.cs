using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.IO;

namespace lolextract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string characterName;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            foreach (string paths in openFileDialog1.FileNames)
            {
                listBox1.Items.Add(paths);
            }

        }

        private void btnExtract_Click_1(object sender, EventArgs e)
        {
            foreach (string paths in listBox1.Items)
            {
               Process cmd = Process.Start("cmd.exe", string.Format("/c python -m cdragontoolbox wad-extract \"{0}", paths));
            }
            listBox1.Items.Clear();

            MessageBox.Show("All done.", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count>0)
                if(listBox1.SelectedIndex > -1)
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void btnBinSelect_Click(object sender, EventArgs e) {
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e) {

            foreach (string paths in openFileDialog2.FileNames) {
                listBox2.Items.Add(paths);
            }

        }

        private void btnBnkSelect_Click(object sender, EventArgs e) {
            openFileDialog3.ShowDialog();
        }

        private void openFileDialog3_FileOk(object sender, CancelEventArgs e) {

            foreach (string paths in openFileDialog3.FileNames) {
                listBox3.Items.Add(paths);

                string test = System.IO.Path.GetFileNameWithoutExtension(paths);
                string pattern = @"^(.*)_";
                string audioWpk = "";

                Match m = Regex.Match(test, pattern);

                if (m.Success) {
                    audioWpk = m.Value + "audio.wpk";
                    characterName = m.Value;
                }
                
                String[] strlist = paths.Split('\\');
                String fullPathWithoutWpk = "";

                for (int i = 0; i < strlist.Count() - 1; i++) 
                    fullPathWithoutWpk += strlist[i] + '\\';

                string fullPath = fullPathWithoutWpk + audioWpk;

                if (File.Exists(fullPath)) 
                    listBox4.Items.Add(fullPathWithoutWpk + audioWpk);
                
            }

        }

        private void btnWpkSelect_Click(object sender, EventArgs e) {
            openFileDialog4.ShowDialog();
        }

        private void openFileDialog4_FileOk(object sender, CancelEventArgs e) {

            foreach (string paths in openFileDialog4.FileNames) {
                listBox4.Items.Add(paths);
            }

        }

        private void btnVoiceExtract_Click(object sender, EventArgs e) {
            string binAdress = listBox2.Items[0].ToString(); 
            string bnkAdress = listBox3.Items[0].ToString();
            string wpkAdress = listBox4.Items[0].ToString();
            
            Process cmd = Process.Start("cmd.exe", "/c bnk-extract.exe \"" + binAdress + "\" \"" + bnkAdress + "\" \"" + wpkAdress + "\" -o " + characterName + " --delete-wems");
            cmd.WaitForExit();

            MessageBox.Show("All done.", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void btnRemove2_Click(object sender, EventArgs e) {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("https://youtube.com/PBETR");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("https://erdem.in/");
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e) {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var file in files) {
                var ext = System.IO.Path.GetExtension(file);
                if (ext.Equals(".client", StringComparison.CurrentCultureIgnoreCase) ||
                    ext.Equals(".wad", StringComparison.CurrentCultureIgnoreCase)) {
                    e.Effect = DragDropEffects.Copy;
                    return;
                }
            }
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e) {
            string[] filePath = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            foreach (string paths in filePath) {
                listBox1.Items.Add(paths);
            }
        }

        private void listBox2_DragEnter(object sender, DragEventArgs e) {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var file in files) {
                var ext = System.IO.Path.GetExtension(file);
                if (ext.Equals(".bin", StringComparison.CurrentCultureIgnoreCase)) {
                    e.Effect = DragDropEffects.Copy;
                    return;
                }
            }
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e) {
            string[] filePath = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            listBox2.Items.Add(filePath[0]);
        }

        private void listBox3_DragEnter(object sender, DragEventArgs e) {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var file in files) {
                var ext = System.IO.Path.GetExtension(file);
                if (ext.Equals(".bnk", StringComparison.CurrentCultureIgnoreCase)) {
                    e.Effect = DragDropEffects.Copy;
                    return;
                }
            }
        }

        private void listBox3_DragDrop(object sender, DragEventArgs e) {
            string[] filePath = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            listBox3.Items.Add(filePath[0]);

            string test = System.IO.Path.GetFileNameWithoutExtension(filePath[0]);
            string pattern = @"^(.*)_";
            string audioWpk = "";

            Match m = Regex.Match(test, pattern);

            if (m.Success) {
                audioWpk = m.Value + "audio.wpk";
                characterName = m.Value;
            }

            String[] strlist = filePath[0].Split('\\');
            String fullPathWithoutWpk = "";

            for (int i = 0; i < strlist.Count() - 1; i++)
                fullPathWithoutWpk += strlist[i] + '\\';

            string fullPath = fullPathWithoutWpk + audioWpk;

            if (File.Exists(fullPath))
                listBox4.Items.Add(fullPathWithoutWpk + audioWpk);
        }

        private void listBox4_DragEnter(object sender, DragEventArgs e) {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var file in files) {
                var ext = System.IO.Path.GetExtension(file);
                if (ext.Equals(".wpk", StringComparison.CurrentCultureIgnoreCase)) {
                    e.Effect = DragDropEffects.Copy;
                    return;
                }
            }
        }

        private void listBox4_DragDrop(object sender, DragEventArgs e) {
            string[] filePath = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            listBox4.Items.Add(filePath[0]);
        }
    }
}