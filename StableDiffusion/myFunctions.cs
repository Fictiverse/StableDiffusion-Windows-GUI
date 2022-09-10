using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public static void RemoveListDuplicate(List<string> listb)
        {
            string[] arr = new string[listb.Count];
            listb.CopyTo(arr, 0);

            var arr2 = arr.Distinct();
            listb.Clear();
            foreach (string s in arr2)
            {
                listb.Add(s);
            }
        }

        public static string CreateResultDirectory(string path)
        {
            //int directoryCount = System.IO.Directory.GetDirectories(path).Length;
            //string prefix = directoryCount.ToString("D3");
            string locationToCreateFolder = path+"\\";
            string date = DateTime.Now.ToString("yyyy.MM.dd");
            string time = DateTime.Now.ToString("HH.mm");
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


        public static void CopyFilesRecursively(string sourcePath, string targetPath)
        {
            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", System.IO.SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
            }

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", System.IO.SearchOption.AllDirectories))
            {
                System.IO.File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
            }

            if (Directory.Exists(sourcePath)) Directory.Delete(sourcePath, true);

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

        public static int ClampTrackbar(TrackBar t,  int value)
        {
            if (value == -1)
                return t.Value;
            else
                return Math.Clamp(value,t.Minimum, t.Maximum);
        }

        public static void ClearMemory()
        {
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }


        public static void populateImageList(System.Windows.Forms.ListView listv, string path)
        {
            listv.Items.Clear();

            var filters = new String[] { "jpg", "jpeg", "png", "tiff", "bmp" };


            string[] paths = GetFilesFrom(path, filters, false);

            ImageList imgs = new ImageList();
            imgs.ColorDepth = ColorDepth.Depth32Bit;
            imgs.ImageSize = new Size(128, 128);

            foreach (string p in paths)
            {
                try
                {
                    //FileStream fs = new FileStream(p, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    //imgs.Images.Add((Bitmap)Image.FromStream(fs).Clone());
                    //fs.Dispose();
                    imgs.Images.Add(GetBitmap(p));
                    //imgs.Images.Add((Bitmap)Image.FromFile(p).Clone());
                }
                catch
                {
                    break;
                    //MessageBox.Show("Access Denided");
                }
            }

            listv.SmallImageList = imgs;

            string[] FileNames = GetFilesFrom(path, filters, false);


            for (int i = 0; i < FileNames.Length; i++)
            {
                listv.Items.Add(FileNames[i], i);
            }
            ClearMemory();

        }

        public static Point ClampPoint(Point p, int brushSize)
        {
            if (p.X - brushSize < 0)
            {
                p.X = brushSize;
            }
            if (p.Y - brushSize < 0)
            {
                p.Y = brushSize;
            }
            if (p.X + brushSize > 511)
            {
                p.X = 511 - brushSize;
            }
            if (p.Y + brushSize > 511)
            {
                p.Y = 511 - brushSize;
            }
            return p;

        }

        public static string[] GetFilesFrom(String searchFolder, String[] filters, bool isRecursive)
        {
            List<String> filesFound = new List<String>();
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                try
                {
                    filesFound.AddRange(Directory.GetFiles(searchFolder, String.Format("*.{0}", filter), searchOption));
                }catch {}
            }
            string[] r = filesFound.ToArray();
            DateTime[] creationTimes = new DateTime[r.Length];
            for (int i = 0; i < r.Length; i++)
                creationTimes[i] = new FileInfo(r[i]).CreationTime;
            Array.Sort(creationTimes, r);

            return r;
        }


        public static Bitmap GetBitmap(string path)
        {
            Bitmap retBitmap = null;
            if (File.Exists(path))
            {
                try
                {
                    retBitmap = new Bitmap(path, true);
                }
                catch { }
            }
            return retBitmap;
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

        public static Size GetJpegImageSize(string filename)
        {
            FileStream stream = null;
            BinaryReader rdr = null;
            try
            {
                stream = File.OpenRead(filename);
                rdr = new BinaryReader(stream);
                // keep reading packets until we find one that contains Size info
                for (; ; )
                {
                    byte code = rdr.ReadByte();
                    if (code != 0xFF) throw new ApplicationException(
                            "Unexpected value in file " + filename);
                    code = rdr.ReadByte();
                    switch (code)
                    {
                        // filler byte
                        case 0xFF:
                            stream.Position--;
                            break;
                        // packets without data
                        case 0xD0:
                        case 0xD1:
                        case 0xD2:
                        case 0xD3:
                        case 0xD4:
                        case 0xD5:
                        case 0xD6:
                        case 0xD7:
                        case 0xD8:
                        case 0xD9:
                            break;
                        // packets with size information
                        case 0xC0:
                        case 0xC1:
                        case 0xC2:
                        case 0xC3:
                        case 0xC4:
                        case 0xC5:
                        case 0xC6:
                        case 0xC7:
                        case 0xC8:
                        case 0xC9:
                        case 0xCA:
                        case 0xCB:
                        case 0xCC:
                        case 0xCD:
                        case 0xCE:
                        case 0xCF:
                            ReadBEUshort(rdr);
                            rdr.ReadByte();
                            ushort h = ReadBEUshort(rdr);
                            ushort w = ReadBEUshort(rdr);
                            return new Size(w, h);
                        // irrelevant variable-length packets
                        default:
                            int len = ReadBEUshort(rdr);
                            stream.Position += len - 2;
                            break;
                    }
                }
            }
            finally
            {
                if (rdr != null) rdr.Close();
                if (stream != null) stream.Close();
            }
        }

        private static ushort ReadBEUshort(BinaryReader rdr)
        {
            ushort hi = rdr.ReadByte();
            hi <<= 8;
            ushort lo = rdr.ReadByte();
            return (ushort)(hi | lo);
        }

        public static Bitmap CropFaceFromImage(Bitmap source, Rectangle section)
        {
            int s = section.Width;
            var bitmap = new Bitmap(s, s);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);
                return bitmap;
            }
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

        public static void FillCircle(Graphics g, Brush brush, float centerX, float centerY, float radius, bool fill = true)
        {
            if (fill)
            {
                g.FillEllipse(brush, centerX - radius, centerY - radius, radius + radius, radius + radius);
            }
            else
            {
                g.FillEllipse(brush, centerX - radius, centerY - radius, radius + radius, radius + radius);
                Rectangle r = new Rectangle((int)(centerX - radius), (int)(centerY - radius), (int)(radius + radius), (int)(radius + radius));
                Pen pen = new Pen(brush);
                //pen.Color = Color.FromArgb(pen.Color.ToArgb() ^ 0xffffff);
                pen.Width = 2;
                pen.Color = Color.FromArgb(128,128,128,128) ;
                g.DrawEllipse(pen, r);
            }
        }

        public static void FillSmoothCircle(Graphics g, Color c, int x, int y, int radius)
        {
            Rectangle bounds = new Rectangle(x - radius / 2, y - radius / 2, radius, radius);
            using (var ellipsePath = new GraphicsPath())
            {
                ellipsePath.AddEllipse(bounds);
                using (var brush = new PathGradientBrush(ellipsePath))
                {
                    brush.CenterPoint = new PointF(x, y);
                    brush.CenterColor = c;
                    brush.SurroundColors = new[] { Color.FromArgb(0, c.R, c.G, c.B) };
                    brush.FocusScales = new PointF(0, 0);

                    g.FillEllipse(brush, x - radius / 2, y - radius / 2, radius, radius);
                }
            }
        }

        public static void DrawSquare(Graphics g, Rectangle r)
        {
            Pen p = new Pen(Color.FromArgb(100,0,0,0));
            p.Width = 3;
            Pen p2 = new Pen(Brushes.White);
            p2.DashStyle = DashStyle.Dash;
            p2.Width = 1;
            g.DrawRectangle(p, r);
            g.DrawRectangle(p2, r);

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


        public static void FloodFill(Bitmap bitmap, int x, int y, Color color)
        {

            x = Math.Clamp(x, 0, bitmap.Width - 1);
            y = Math.Clamp(y, 0, bitmap.Height - 1);
            BitmapData data = bitmap.LockBits(
                new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            int[] bits = new int[data.Stride / 4 * data.Height];
            Marshal.Copy(data.Scan0, bits, 0, bits.Length);

            LinkedList<Point> check = new LinkedList<Point>();
            int floodTo = color.ToArgb();
            int floodFrom = bits[x + y * data.Stride / 4];
            bits[x + y * data.Stride / 4] = floodTo;

            if (floodFrom != floodTo)
            {
                check.AddLast(new Point(x, y));
                while (check.Count > 0)
                {
                    Point cur = check.First.Value;
                    check.RemoveFirst();

                    foreach (Point off in new Point[] {new Point(0, -1), new Point(0, 1),new Point(-1, 0), new Point(1, 0)})
                    {
                        Point next = new Point(cur.X + off.X, cur.Y + off.Y);
                        if (next.X >= 0 && next.Y >= 0 && next.X < data.Width && next.Y < data.Height)
                        {
                            if (bits[next.X + next.Y * data.Stride / 4] == floodFrom)
                            {
                                check.AddLast(next);
                                bits[next.X + next.Y * data.Stride / 4] = floodTo;
                            }
                        }
                    }
                }
            }

            Marshal.Copy(bits, 0, data.Scan0, bits.Length);
            bitmap.UnlockBits(data);
        }






    }
}
