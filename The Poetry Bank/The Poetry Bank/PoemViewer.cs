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
    public partial class PoemViewer : Form
    {
        public Poem poem;
         

        public PoemViewer()
        {
            InitializeComponent();

          Title.Text = poem.name;
          poem2.Text = poem.fullPoem;
        }

        public void UpdateMe()
        {
            Title.Text = poem.name;
            poem2.Text = poem.fullPoem;
        }
    }
}
