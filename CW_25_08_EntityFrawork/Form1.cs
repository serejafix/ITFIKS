using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace CW_25_08_EntityFrawork
{
    public partial class Form1 : Form
    {
        private MusicCollectionEntities musicCollectionEntities;

        public Form1()
        {
            musicCollectionEntities = new MusicCollectionEntities();
            dgv_Artsist.DataSource = musicCollectionEntities.Artists.ToList();

            InitializeComponent();

        }

    }
}
