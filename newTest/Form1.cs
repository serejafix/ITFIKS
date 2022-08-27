using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MusicCollectionEntities musicCollection = new MusicCollectionEntities();
            dataGridView1.DataSource = musicCollection.Artists.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
