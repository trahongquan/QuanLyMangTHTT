using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMangTHTT
{
    public partial class Form1 : Form
    {
        private string imagePath;
        private string selectedImagePathForCopy; // Thêm biến để lưu đường dẫn của hình ảnh đã chọn

        public Form1()
        {
            InitializeComponent();
            // Đọc đường dẫn từ cấu hình
            //imagePath = ConfigurationManager.AppSettings["ImagePath"];
        }

        private string path2path(string path)
        {
            // Phân tách đường dẫn thành các phần tử
            string[] pathElements = path.Split('\\');

            // Hợp lại đến n-2 phần tử
            string newPath = string.Join("\\", pathElements, 0, pathElements.Length - 3);
            return newPath;
        }
        private void DisplayImage(string imageName)
        {
            try
            {
                // Lấy đường dẫn thư mục chứa ứng dụng
                string appPath = Path.GetDirectoryName(Application.ExecutablePath);
                string baseProject = path2path($@"{appPath}\");
                // Xây dựng đường dẫn đầy đủ từ đường dẫn tương đối
                string imagePathToFile = Path.Combine(baseProject, "Images", imageName);
                //string x = path2path($@"{appPath}\");
                MessageBox.Show(imagePathToFile);
                if (File.Exists(imagePathToFile))
                {
                    // Hiển thị hình ảnh
                    pictureBox1.ImageLocation = imagePathToFile;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    MessageBox.Show("Hình ảnh không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }


        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            // Gọi hàm hiển thị hình ảnh với tên hình ảnh cụ thể
            DisplayImage("PXL_20230820_025535281.jpg");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Sử dụng OpenFileDialog để chọn tệp tin ảnh
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn tệp tin đã chọn
                    selectedImagePathForCopy = openFileDialog.FileName;

                    // Hiển thị hình ảnh trong PictureBox
                    pictureBox1.ImageLocation = selectedImagePathForCopy;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    MessageBox.Show(selectedImagePathForCopy);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedImagePathForCopy))
            {
                // Lấy tên tệp tin
                string imageName = Path.GetFileName(selectedImagePathForCopy);
                string appPath = Path.GetDirectoryName(Application.ExecutablePath);
                string baseProject = path2path($@"{appPath}\");
                // Xây dựng đường dẫn đến thư mục Images
                string destinationPath = Path.Combine(baseProject, "Images", imageName);
                MessageBox.Show(destinationPath);
                try
                {
                    // Sao chép tệp tin vào thư mục Images
                    File.Copy(selectedImagePathForCopy, destinationPath, true);
                    MessageBox.Show("Hình ảnh đã được sao chép vào thư mục Images.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi sao chép hình ảnh: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hình ảnh trước khi sao chép.");
            }
        }
    }
}

