using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PixEdit;

namespace PixEditAuto
{
    public partial class PixEditAuto : Form
    {
        public PixEditAuto()
        {
            InitializeComponent();
        }

        PixEdit.Application pixApp;

        private void PixEditAuto_Load(object sender, EventArgs e)
        {
            pixApp = new PixEdit.Application();
            pixApp.Visible = true;
        }

        PixEdit.Document pixDoc = null;

        private void btnOpenDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgFileOpen = new OpenFileDialog();

            if (dlgFileOpen.ShowDialog() == DialogResult.OK)
            {
                if (pixDoc != null)
                {
                    pixDoc.FileClose();
                }

                pixDoc = pixApp.FileOpen(dlgFileOpen.FileName);
            }
        }

        private void PixEditAuto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pixDoc != null)
            {
                pixDoc.FileClose();
            }
        }

        private void btnInsertText_Click(object sender, EventArgs e)
        {
            if (pixDoc != null)
            {
                for (int i = 1; i <= pixDoc.GetPageCount(); i++)
                {
                    pixDoc.ShowPage(SHOWPAGETYPE.GotoPage, i);
                    pixDoc.Text("L1", 10.0, 10.0, tbText.Text);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (pixDoc != null)
            {
                pixDoc.FileSave();
            }
        }
    }
}
