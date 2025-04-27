using System.Reflection.Metadata;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;

namespace PrzetwarzanieObrazow
{
    public partial class Form1 : Form
    {

        private Bitmap? image;
        Filters filters;
        public Form1()
        {
            InitializeComponent();
            this.filters = new Filters();
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.ShowDialog();

            var file = openFileDialog.FileName;

            if (file != null)
            {
                image = new Bitmap(file);
                original.Image = image;
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            if (image == null)
                return;

            
            int filtersCount = 4;
            Thread[] threads = new Thread[filtersCount];

            Bitmap[] results = new Bitmap[filtersCount];

            threads[0] = new Thread(Filters.Negative);
            threads[1] = new Thread(Filters.Greyscale);
            threads[2] = new Thread(Filters.mirror);
            threads[3] = new Thread(Filters.Threshhold);

            for (int i = 0; i < filtersCount; i++)
            {
               lock(image) 
                   results[i] = new Bitmap(image);
               threads[i].Start(results[i]);
            }

            for (int i = 0; i < filtersCount; i++)
            {
               threads[i].Join();
            }
            negative.Image = results[0];
            mirror.Image = results[1];
            threshold.Image = results[2];
            greyscale.Image = results[3];

        }
    }
}
