using AForge.Video.DirectShow;      //camera
using System;
using System.Drawing;   //bitmap
using System.Threading.Tasks; //luồng
using System.Windows.Forms;
using Tesseract;    //ocr

namespace OCR_Vietnamese
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection cameras;   //liệt kê các thiết bị video
        private VideoCaptureDevice cam; //nguồn video của cam, ghi lại dữ liệu video từ camera

        public Form1()
        {
            InitializeComponent();

            //liệt kê các camera mà máy sử dụng r hiển thị ra combobox cho ng dùng chọn
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo info in cameras)
            {
                comboBox1.Items.Add(info.Name);
            }
            comboBox1.SelectedIndex = 0;
        }

        //mở file, sử dụng openFileDialog
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.LoadAsync(openFileDialog.FileName);
            }        
        }

        //khởi động webcam
        private void btn_start_Click(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
            cam = new VideoCaptureDevice(cameras[comboBox1.SelectedIndex].MonikerString);
            cam.NewFrame += Cam_NewFrame;
            cam.Start();
        }

        private void Cam_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bitmap;
        }

        //chụp ảnh
        private void btn_takephoto_Click(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
        }

        //lưu ảnh
        private void btn_save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "F:\\Thực tập cs cn\\Images";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }

        //chuyển ảnh qua text
        private void button2_Click(object sender, EventArgs e)
        {
            string result = "";
            Task.Factory.StartNew(() => {
                picloading.BeginInvoke(new Action(() =>
                {
                    picloading.Visible = true;
                }));

                //thực hiện convert
                result = OCR((Bitmap)pictureBox1.Image);
                richTextBox1.BeginInvoke(new Action(() => {

                    richTextBox1.Text = result;

                }));
                picloading.BeginInvoke(new Action(() =>
                {
                    picloading.Visible = false;
                }));

            });
        }

        //convert
        private string OCR(Bitmap b)
        {
            string res = "";
            using (var engine = new TesseractEngine(@"tessdata", "vie", EngineMode.Default))
            {
                using (var page = engine.Process(b, PageSegMode.AutoOnly))
                    res = page.GetText();
            }
            return res;
        }

        private void picloading_Click(object sender, EventArgs e)
        {

        }
    }
}
