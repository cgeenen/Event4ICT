using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess;
using Oracle.DataAccess.Client;

namespace Event4ICT
{
    public partial class MaterialBerheerForm : Form
    {
        Database database = new Database();
        public MaterialBerheerForm()
            
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "image files (*.jpg)|*.jpg)|All files(*.*)|*.*";
            file.InitialDirectory = "C:\\Users\\Diieuhanh\\Pictures";
            file.Title= "Select Image For Upload";
            if(file.ShowDialog() == DialogResult.OK){
                pbMaterial.ImageLocation=file.FileName;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            database.OpenConnection();


        }
    }
}
