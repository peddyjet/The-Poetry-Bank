using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Poetry_Bank
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();

            foreach (Poem poem in Caches.Poems)
            {
                ListOfPoems.Items.Add(poem);
            }
            
        }

        private void ListOfPoems_Click(object sender, object e)
        {
            if (ListOfPoems.SelectedItem == null) { return; }

            PoemInfo.Text = ((Poem)ListOfPoems.SelectedItem).description;

        }

        private void ReadPoem_Click(object sender, EventArgs e)
        {
            if (ListOfPoems.SelectedItem == null) { MessageBox.Show("Please select a poem", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                var i = new PoemViewer
                {
                    poem = (Poem)ListOfPoems.SelectedItem
                };

                i.UpdateMe();
                i.ShowDialog();
        }

        private void RatePoem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.x1.games/contact/");
        }

        private void DownloadPoem_Click(object sender, EventArgs e)
        {
            if (ListOfPoems.SelectedItem == null) { MessageBox.Show("Please select a poem", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = $"{((Poem)ListOfPoems.SelectedItem).name}.txt";
                saveFileDialog.DefaultExt = @".txt";

                var i = saveFileDialog.ShowDialog();
                if (i == DialogResult.OK)
                {
                    string path;
                    path = saveFileDialog.FileName;
                    using (FileStream fileStream = new FileStream(path,FileMode.Create))
                    {
                        fileStream.Write(Encoding.UTF8.GetBytes(((Poem)ListOfPoems.SelectedItem).fullPoem),0, Encoding.UTF8.GetBytes(((Poem)ListOfPoems.SelectedItem).fullPoem).Length);
                        MessageBox.Show("File saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
            }

           
            
        }
    }
}
