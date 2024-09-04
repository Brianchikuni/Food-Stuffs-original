using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPFP;
using DPFP.Capture;
using DPFP.Processing;
using MySql.Data.MySqlClient;

namespace Food_Stuffs
{
    public partial class Capture : Form, DPFP.Capture.EventHandler
    {
        private DPFP.Capture.Capture Capturer;
        private DPFP.Processing.Enrollment Enroller;
        private string connString = "server=localhost;user=root;database=food;port=3306;password=";
        Bitmap pc1;
        Bitmap pc2;
        Bitmap pc3;
        Bitmap pc4;


        public Capture()
        {
            InitializeComponent();
            Init();
            StartCapture();
        }

        private void Capture_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("enrollments"))
            {
                Directory.CreateDirectory("enrollments");
            }
        }

        private void Init()
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();
                Capturer.EventHandler = this;
                Enroller = new DPFP.Processing.Enrollment();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void StartCapture()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot start capture. Error: " + ex.Message);
                }
            }
        }

        protected void StopCapture()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StopCapture();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot stop capture. Error: " + ex.Message);
                }
            }
        }

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            Process(Sample);
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber) { }
        public void OnFingerTouch(object Capture, string ReaderSerialNumber) { }
        public void OnReaderConnect(object Capture, string ReaderSerialNumber) { }
        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber) { }
        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback) { }

        protected void Process(DPFP.Sample Sample)
        {
            DrawPicture(ConvertSampleToBitmap(Sample), Picture);

            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);

            if (features != null)
            {
                try
                {
                    Enroller.AddFeatures(features);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                switch (Enroller.TemplateStatus)
                {
                    case DPFP.Processing.Enrollment.Status.Ready:
                        string filename = SaveTemplate(Enroller.Template);
                        SaveToDatabase(filename);
                        Enroller.Clear();
                        StartCapture();  // Ready for next enrollment
                        MessageBox.Show("Fingerprint enrollment is successful!");
                        break;

                    case DPFP.Processing.Enrollment.Status.Failed:
                        Enroller.Clear();
                        StopCapture();
                        StartCapture();
                        break;
                }
            }
        }

        protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion convertor = new DPFP.Capture.SampleConversion();
            Bitmap bitmap = null;
            convertor.ConvertToPicture(Sample, ref bitmap);

            if (pc1 == null)
                pc1 = bitmap;

            else if (pc2 == null)
                pc2 = bitmap;

            else if(pc3 == null)
                pc3 = bitmap;

            else if(pc4 == null)
                pc4 = bitmap;

            return bitmap;
        }

        private string SaveTemplate(DPFP.Template template)
        {
            string filename = "enrollments/" + Guid.NewGuid().ToString() + ".dat";
            using (FileStream fs = File.Open(filename, FileMode.Create, FileAccess.Write))
            {
                template.Serialize(fs);
            }
            return filename;
        }

        private void SaveToDatabase(string filename)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "INSERT INTO students (fullname, studentclass, template_filename) VALUES (@fullname, @studentclass, @template_filename)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@fullname", txtFullName.Text);
                        cmd.Parameters.AddWithValue("@studentclass", txtStudentClass.Text);
                        cmd.Parameters.AddWithValue("@template_filename", Path.GetFileNameWithoutExtension(filename));
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void DrawPicture(Bitmap bitmap, PictureBox pic)
        {
            this.Invoke(new Function(delegate ()
            {


                if (pc1 != null)
                {
                    pc1 = bitmap;
                    Picture.Image = new Bitmap(bitmap, Picture.Size);
                }
                 if (pc2 != null)
                {
                    pc2 = bitmap;
                    pic2.Image = new Bitmap(bitmap, pic2.Size);
                }
                if (pc3 != null)
                {
                    pc3 = bitmap;
                    pic3.Image = new Bitmap(bitmap, pic3.Size);
                }
                if (pc4 != null)
                {
                    pc4 = bitmap;
                    pic4.Image = new Bitmap(bitmap, pic4.Size);
                }

            }));
        }

        private delegate void Function();
        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction extractor = new DPFP.Processing.FeatureExtraction();
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }

        private void Capture_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCapture();
        }
    }
}
