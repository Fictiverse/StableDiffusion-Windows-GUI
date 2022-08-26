using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StableDiffusion
{
    internal class myFunctions
    {

        public static void OpenWithDefaultProgram(string path)
        {
            using Process fileopener = new Process();

            fileopener.StartInfo.FileName = "explorer";
            fileopener.StartInfo.Arguments = "\"" + path + "\"";
            fileopener.Start();
        }



        public static void RemoveDuplicate(ListBox listb)
        {
            string[] arr = new string[listb.Items.Count];
            listb.Items.CopyTo(arr, 0);

            var arr2 = arr.Distinct();
            listb.Items.Clear();
            foreach (string s in arr2)
            {
                listb.Items.Add(s);
            }
        }

        public static string CreateResultDirectory(string path)
        {
            //int directoryCount = System.IO.Directory.GetDirectories(path).Length;
            //string prefix = directoryCount.ToString("D3");
            string locationToCreateFolder = path+"\\";
            string date = DateTime.Now.ToString("MM.dd.yyyy");
            string time = DateTime.Now.ToString("HH.mm tt");
            string format = "{0}_{1}";
            string folderName = string.Format(format, date, time);
            Directory.CreateDirectory(locationToCreateFolder + folderName);
            return locationToCreateFolder + folderName;

        }


        public static bool IsDigitsOnly(string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }


        public static Bitmap OpenImage(string path)
        {
            FileStream bmp = new FileStream(path, FileMode.Open, FileAccess.Read);
            Bitmap img = new Bitmap(bmp);
            bmp.Close();
            return img;
        }

        public static void clearFolder(string FolderName)
        {
            DirectoryInfo dir = new DirectoryInfo(FolderName);

            foreach (FileInfo fi in dir.GetFiles())
            {
                fi.Delete();
            }

            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                clearFolder(di.FullName);
                di.Delete();
            }
        }


        public static void KillProcessAndChildrens(int pid)
        {
            ManagementObjectSearcher processSearcher = new ManagementObjectSearcher
              ("Select * From Win32_Process Where ParentProcessID=" + pid);
            ManagementObjectCollection processCollection = processSearcher.Get();

            try
            {
                Process proc = Process.GetProcessById(pid);
                if (!proc.HasExited) proc.Kill();
            }
            catch (ArgumentException)
            {
                // Process already exited.
            }

            if (processCollection != null)
            {
                foreach (ManagementObject mo in processCollection)
                {
                    KillProcessAndChildrens(Convert.ToInt32(mo["ProcessID"])); //kill child processes(also kills childrens of childrens etc.)
                }
            }
        }

        public static void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        public static float ConvertStringToInt(string txt)
        {
            float f;

            if (float.TryParse(txt, out f))
                return f;
            else
               return (float)-1.0;

        }

        public static int ClampTrackbar(int value, int min, int max, int def)
        {
            if (value == -1)
                return def;
            else
                return Math.Clamp(value,min,max);
        }

        public static void ClearMemory()
        {
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }


        public static void populateInitImages(System.Windows.Forms.ListView listv, string folderName)
        {

            // listViewInitImages.Columns.Clear();

            listv.Items.Clear();


            string Path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\InitImages\\" + folderName;
            var filters = new String[] { "jpg", "jpeg", "png", "tiff", "bmp" };
            string[] paths = GetFilesFrom(Path, filters, false);


            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(100, 100);

            try
            {
                foreach (string path in paths)
                {
                    imgs.Images.Add(Image.FromFile(path));
                }
            }
            catch { }

            listv.SmallImageList = imgs;


            String[] FileNames = GetFilesFrom(Path, filters, false);


            for (int i = 0; i < FileNames.Length; i++)
            {
                //string new_string = FileNames[i].Remove(FileNames[i].LastIndexOf('.'));
                //new_string = new_string.Split('\\').Last();

                listv.Items.Add(FileNames[i], i);

            }

        }


        public static String[] GetFilesFrom(String searchFolder, String[] filters, bool isRecursive)
        {
            List<String> filesFound = new List<String>();
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(searchFolder, String.Format("*.{0}", filter), searchOption));
            }
            return filesFound.ToArray();
        }






        public static Bitmap LoadBitmap(string path)
        {
            //Open file in read only mode
            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            //Get a binary reader for the file stream
            using (BinaryReader reader = new BinaryReader(stream))
            {
                //copy the content of the file into a memory stream
                var memoryStream = new MemoryStream(reader.ReadBytes((int)stream.Length));
                //make a new Bitmap object the owner of the MemoryStream
                return new Bitmap(memoryStream);
            }
        }




        public static Image ResizeImage(Image image, Size size, bool preserveAspectRatio = true)
        {
            int newWidth;
            int newHeight;

            if (preserveAspectRatio)
            {
                var originalWidth = image.Width;
                var originalHeight = image.Height;
                var percentWidth = size.Width / (float)originalWidth;
                var percentHeight = size.Height / (float)originalHeight;
                var percent = percentHeight < percentWidth ? percentHeight : percentWidth;
                newWidth = (int)(originalWidth * percent);
                newHeight = (int)(originalHeight * percent);
            }
            else
            {
                newWidth = size.Width;
                newHeight = size.Height;
            }

            
            Image newImage = new Bitmap(newWidth, newHeight);

            using (var graphicsHandle = Graphics.FromImage(newImage))
            {
                graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphicsHandle.SmoothingMode = SmoothingMode.HighQuality;
                graphicsHandle.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return newImage;
        }



        public static Image FixedSize(Image imgPhoto, int Width, int Height)
        {
            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            int sourceX = 0;
            int sourceY = 0;
            int destX = 0;
            int destY = 0;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)Width / (float)sourceWidth);
            nPercentH = ((float)Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
            {
                nPercent = nPercentH;
                destX = System.Convert.ToInt16((Width -
                              (sourceWidth * nPercent)) / 2);
            }
            else
            {
                nPercent = nPercentW;
                destY = System.Convert.ToInt16((Height -
                              (sourceHeight * nPercent)) / 2);
            }

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap bmPhoto = new Bitmap(Width, Height,
                              PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
                             imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(Color.Transparent);
            grPhoto.InterpolationMode =
                    InterpolationMode.HighQualityBicubic;

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            return bmPhoto;
        }

        public static void FillCircle(Graphics g, Brush brush, float centerX, float centerY, float radius)
        {
            g.FillEllipse(brush, centerX - radius, centerY - radius, radius + radius, radius + radius);
        }



        public static Bitmap ChangeToColor(Bitmap bmp)
        {
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            int width = bmp2.Width;
            int height = bmp2.Height;

            // Processing one pixel at a time is slow, but easy to understand
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int R = bmp.GetPixel(x, y).R;
                    int G = bmp.GetPixel(x, y).G;
                    int B = bmp.GetPixel(x, y).B;

                    if (R < 10 && G > 245 && B < 10)
                    {
                        bmp2.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                    else
                        bmp2.SetPixel(x, y, Color.FromArgb(0, 0, 0));

                }
            }
            return bmp2;
        }



        public static Color LerpColor(Color s, Color t, float k)
        {
            var bk = (1 - k);
            var a = s.A * bk + t.A * k;
            var r = s.R * bk + t.R * k;
            var g = s.G * bk + t.G * k;
            var b = s.B * bk + t.B * k;
            return Color.FromArgb(cClamp((int)a), cClamp((int)r), cClamp((int)g), cClamp((int)b));
        }

        public static int cClamp(int value)
        {
            return Math.Clamp(value, 0, 255);
        }


        public static Color InterpolateColor(Color[] colors, double x)
        {
            double r = 0.0, g = 0.0, b = 0.0;
            double total = 0.0;
            double step = 1.0 / (double)(colors.Length - 1);
            double mu = 0.0;
            double sigma_2 = 0.035;

            foreach (Color color in colors)
            {
                total += Math.Exp(-(x - mu) * (x - mu) / (2.0 * sigma_2)) / Math.Sqrt(2.0 * Math.PI * sigma_2);
                mu += step;
            }

            mu = 0.0;
            foreach (Color color in colors)
            {
                double percent = Math.Exp(-(x - mu) * (x - mu) / (2.0 * sigma_2)) / Math.Sqrt(2.0 * Math.PI * sigma_2);
                mu += step;

                r += color.R * percent / total;
                g += color.G * percent / total;
                b += color.B * percent / total;
            }

            return Color.FromArgb(255, (int)r, (int)g, (int)b);
        }


    }
}
