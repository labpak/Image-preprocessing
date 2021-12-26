using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;
using AForge.Imaging;
using AForge.Imaging.Filters;
using System.Runtime.InteropServices;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;


namespace VKR
{
    public partial class Form1 : Form
    {

        public float ThresholdValue = 0.3f;

        public Form1()
        {
            InitializeComponent();
            if (OriginalImage.Image == null)
                OriginalImage.Image = ConvertHelp.LoadBitmap("..\\Debug\\jk23.jpg");
        }

        private void ImagePreparation()
        {
            Invert InvertFilter;
            InvertFilter = new AForge.Imaging.Filters.Invert();
            
            Bitmap OrigImage = (Bitmap)OriginalImage.Image;

            //ФИЛЬТР МЕДИАННЫЙ
            Bitmap mfiltrImage = MedianFilter.MFilter(OrigImage);
            Bitmap binImage = ConvertHelp.Binarization(mfiltrImage);


            if (ZhangCheckBox.Checked)
            {
                //СКЕЛЕТ Зонг-Сунь
                bool[][] zst = SkeletBuild.ZhangSuenThinning(ConvertHelp.Image2Bool(binImage));
                Bitmap thinImage = (Bitmap)ConvertHelp.Bool2Image(zst);
                binImage = ConvertHelp.Binarization(thinImage);
            }

            if (AforgeCheckBox.Checked)
            {
                //AFORGE СКЕЛЕТ
                InvertFilter.ApplyInPlace(binImage);
                SimpleSkeletonization tfilter = new SimpleSkeletonization();
                // apply the filter
                tfilter.ApplyInPlace(binImage);
                InvertFilter.ApplyInPlace(binImage);
                binImage = ConvertHelp.Binarization(binImage);
            }
            else
            {
                //СКЕЛЕТ EMGUCV           
                Bitmap skImage = SkeletBuild.SkelatanizeEmgu(binImage);
                binImage = ConvertHelp.Binarization(skImage);
                InvertFilter.ApplyInPlace(binImage);
            }

            //УДАЛЕНИЕ ШУМОВ
            Bitmap rn = RemoveArtifact.RemoveNoiseAforge(binImage, 20, 10);
            binImage = ConvertHelp.Binarization(rn);

            Bitmap ni = ConvertHelp.CreateNonIndexedImage(binImage);
            Bitmap withoutlines = HoughTransform.Hough(ni, 5);//0 to 500
            binImage = ConvertHelp.Binarization(withoutlines);

            //УДАЛЕНИЕ ШУМОВ
            rn = RemoveArtifact.RemoveNoiseAforge(binImage, 3, 3);
            binImage = ConvertHelp.Binarization(rn);

            /*Bitmap sS = Segment.SegmentString(ni);
            binImage = Binarization(sS);
            Bitmap sW = Segment.SegmentWords(binImage);*/

            ResImage.Image = binImage;

        }

        private void OpenImage_Click(object sender, EventArgs e)
        {
            Bitmap image; //Bitmap для открываемого изображения

            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    OriginalImage.Image = image;
                    OriginalImage.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PreparationButton_Click(object sender, EventArgs e)
        {
            ImagePreparation();
        }

        private void ZhangCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ZhangCheckBox.Checked)
            { 
                AforgeCheckBox.Checked = false;
                EmguCheckBox.Checked = false;
            }
        }

        private void AforgeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AforgeCheckBox.Checked)
            {
                ZhangCheckBox.Checked = false;
                EmguCheckBox.Checked = false;
            }
        }

        private void EmguCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EmguCheckBox.Checked)
            {
                ZhangCheckBox.Checked = false;
                AforgeCheckBox.Checked = false;
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (OriginalImage.Image != null)
            {
                OriginalImage.Image.Dispose();
                OriginalImage.Image = null;
            }
            if (ResImage.Image != null)
            {
                ResImage.Image.Dispose();
                ResImage.Image = null;
            }
            ZhangCheckBox.Checked = false;
            AforgeCheckBox.Checked = false;
            EmguCheckBox.Checked = false;
        }
    }
}

