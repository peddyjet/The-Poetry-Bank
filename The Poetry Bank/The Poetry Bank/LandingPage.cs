using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

      
    }
}
