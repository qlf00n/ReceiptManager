using System;
using System.Windows.Forms;

namespace ReceiptManager
{
    public partial class FormMain : Form
    {
        private static DataFileManager dataFileManager = new DataFileManager();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonChooseDataFile_Click(object sender, EventArgs e)
        {
            IDataFileDetails dataFileDetails = ShowOpenFileDialog();
            DataFileManager.ReadDataFile(dataFileDetails);
        }

        private IDataFileDetails ShowOpenFileDialog()
        {
            IDataFileDetails dataFileDetails = null;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Data Files (.bin)|*.bin|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.CheckFileExists = true;
                openFileDialog.CheckPathExists = true;

                DialogResult dialogResult = openFileDialog.ShowDialog();

                switch (dialogResult)
                {
                    case System.Windows.Forms.DialogResult.Cancel:

                        break;
                    case System.Windows.Forms.DialogResult.OK:
                        dataFileDetails = new DataFileDetails(openFileDialog.FileName);
                        break;
                }
            }

            return dataFileDetails;
        }
    }
}
