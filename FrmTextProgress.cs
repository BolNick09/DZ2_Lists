namespace DZ2_Lists
{
    public partial class FrmTextProgress : Form
    {
        private string path;
        public FrmTextProgress()
        {
            InitializeComponent();
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            tbDirectory.Clear();
            using (var dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.FileName;
                    tbDirectory.Text = path;
                }
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string fileContent = string.Empty;
            using (var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1];
                int bytesRead;
                int totalBytesRead = 0;
                int fileSize = (int)fileStream.Length;
                while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fileContent += buffer[0];
                    totalBytesRead += bytesRead;                    
                    pbReadProgress.Value = (int)((double)totalBytesRead / fileSize * pbReadProgress.Maximum);
                    Thread.Sleep(100);
                }
            }
        }
    }
}

