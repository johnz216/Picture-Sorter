using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExifLib;

namespace Picture_sorter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var eo = new System.IO.EnumerationOptions();
            eo.RecurseSubdirectories = true;

            foreach  (var dir in System.IO.Directory.GetDirectories(txtFrom.Text, "*", eo))
            {
                foreach (var file in System.IO.Directory.GetFiles(dir))
                {
                    SetWorking(file);
                    var ispic = isPic(file);
                    var dateTaken = new DateTime();
                    if (ispic)
                    {
                        dateTaken = getFileCreationDate(file);
                        saveCopy(file, dateTaken);
                    }
                    else
                    {
                        saveCopyNonPic(file);
                    }                     
                }
            }

            MessageBox.Show("DONE!");
        }

        private bool isPic(string file)
        {
            if (file.ToUpper().EndsWith("JPG"))
            {
                return true;
            }
            return false;
        }

        private void saveCopyNonPic(string file)
        {
            var rnd = new Random();

            var fileName = file.Substring(file.LastIndexOf(@"\") + 1);
            var destionationFolder = (txtTo.Text.EndsWith(@"\")) ? txtTo.Text + @"NotPictures\" : txtTo.Text + @"\NotPictures\";

            if (!System.IO.Directory.Exists(destionationFolder))
                System.IO.Directory.CreateDirectory(destionationFolder);

            var newFileName = String.Concat(destionationFolder, fileName);

            //if (System.IO.File.Exists(newFileName))
            //    newFileName = string.Concat(newFileName.Substring(0, newFileName.LastIndexOf(".") - 1), "_", rnd.Next(10, 9999), newFileName.Substring(newFileName.LastIndexOf(".")));
            //System.IO.File.Copy(file, newFileName);

            if (System.IO.File.Exists(newFileName))
            {
                var newFileCreationTime = System.IO.File.GetCreationTimeUtc(newFileName);
                var oldFileCreationTime = System.IO.File.GetCreationTimeUtc(file);

                if (newFileCreationTime > oldFileCreationTime)
                {
                    System.IO.File.Copy(file, newFileName, true);
                }
            }
            else
            {
                System.IO.File.Copy(file, newFileName);
            }
        }

        private void saveCopy(string file, DateTime dateTaken)
        {
            var rnd = new Random();
            var fileExt = file.Substring(file.LastIndexOf("."));
            
            var toFolder = (txtTo.Text.EndsWith(@"\")) ? txtTo.Text : txtTo.Text + @"\";
            var destionationFolder = toFolder + dateTaken.Year + @"\" + dateTaken.Month + @"\";
            
            if (!System.IO.Directory.Exists(destionationFolder))
                System.IO.Directory.CreateDirectory(destionationFolder);

            var newFileName = destionationFolder + String.Concat(dateTaken.ToString("yyyyMMddHHmmss"), "_", rnd.Next(10, 9999), fileExt);

            if (System.IO.File.Exists(newFileName))
            {
                var newPicCreationTime = System.IO.File.GetCreationTimeUtc(newFileName);
                var oldPicCreationTime = System.IO.File.GetCreationTimeUtc(file);

                if (newPicCreationTime > oldPicCreationTime)
                {
                    System.IO.File.Copy(file, newFileName, true);
                }
            }
            else
            {
                System.IO.File.Copy(file, newFileName);
            }
        }

        private void SetWorking(string working)
        {
            lblWork.Text = working;
            lblWork.Invalidate();
            lblWork.Update();
            lblWork.Refresh();
            Application.DoEvents();
        }

        private DateTime getFileCreationDate (string file)
        {
            DateTime datePictureTaken;
            try
            {
                using (ExifReader reader = new ExifReader(file))
                {
                    // Extract the tag data using the ExifTags enumeration                
                    if (reader.GetTagValue<DateTime>(ExifTags.DateTimeDigitized, out datePictureTaken))
                    {
                        return datePictureTaken;
                    }
                }
            }
            catch
            {
                datePictureTaken = new DateTime(1900, 01, 01, 1, 0, 0);
            }
            
            
            return datePictureTaken;
        }
    }
}
