using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StableDiffusion.myFunctions;

namespace StableDiffusion
{
    class iniAccess
    {

        public static void SaveEnvPath(string value)
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            SettingFile.Write("EnvPath", value, "Settings");
        }
        public static string LoadEnvPath()
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            return SettingFile.Read("EnvPath", "Settings");
        }


        public static void SaveTxt2imgPath(string value)
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            SettingFile.Write("txt2imgPath", value, "Settings");
        }
        public static string LoadTxt2imgPath()
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            return SettingFile.Read("txt2imgPath", "Settings");
        }


        public static void SaveImg2imgPath(string value)
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            SettingFile.Write("img2imgPath", value, "Settings");
        }
        public static string LoadImg2imgPath()
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            return SettingFile.Read("img2imgPath", "Settings");
        }


        public static void SaveInpaintPath(string value)
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            SettingFile.Write("inpaintPath", value, "Settings");
        }
        public static string LoadInpaintPath()
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            return SettingFile.Read("inpaintPath", "Settings");
        }




        public static void SavePrompt(string value)
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            SettingFile.Write("Prompt", value, "Settings");
        }
        public static string LoadPrompt()
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            return SettingFile.Read("Prompt", "Settings");
        }







        public static void SaveSeed(string value)
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            SettingFile.Write("Seed", value, "Settings");
        }
        public static string LoadSeed()
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            return SettingFile.Read("Seed", "Settings");
        }



        public static void SaveIteration(decimal value)
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            SettingFile.Write("Iteration", (value * 25).ToString(), "Settings");
        }

        public static Int16 LoadIteration()
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            return Convert.ToInt16(Convert.ToDouble(ConvertStringToInt(SettingFile.Read("Iteration", "Settings"))) / 25);
        }




            public static void SaveN_iter(decimal value)
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            SettingFile.Write("N_iter", value.ToString(), "Settings");
        }

        public static Int16 LoadN_iter()
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            return Convert.ToInt16(ConvertStringToInt(SettingFile.Read("N_iter", "Settings")));
        }



        public static void SaveN_samples(decimal value)
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            SettingFile.Write("N_samples", value.ToString(), "Settings");
        }

        public static Int16 LoadN_samples()
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            return Convert.ToInt16(ConvertStringToInt(SettingFile.Read("N_samples", "Settings")));

        }



        public static void SaveGuidance(decimal value)
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            SettingFile.Write("Guidance", ((float)value / 2).ToString(), "Settings");
        }

        public static Int16 LoadGuidance()
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            return Convert.ToInt16(Convert.ToDouble(SettingFile.Read("Guidance", "Settings")) * 2);
        }


        public static void SaveChannels(decimal value)
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            SettingFile.Write("Channels", ((float)value * 4).ToString(), "Settings");
        }

        public static Int16 LoadChannels()
        {
            IniFile SettingFile = new IniFile("Settings.ini");

            return Convert.ToInt16(Convert.ToDouble(ConvertStringToInt(SettingFile.Read("Channels", "Settings"))) / 4);
        }

        public static void SaveStrength(decimal value)
        {

            IniFile SettingFile = new IniFile("Settings.ini");
            SettingFile.Write("Strength", ((float)value / 20).ToString(), "Settings");
        }

        public static Int16 LoadStrength()
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            return Convert.ToInt16(ConvertStringToInt(SettingFile.Read("Strength", "Settings")) * 20);
        }



        public static List<string> LoadPresets()
        {
            IniFile SettingFile = new IniFile("Settings.ini");

            string[] list = SettingFile.Read("Presets", "Settings").Split(',');
            List<string> listclean = new List<string>();
            foreach (string str in list)
            {
                foreach (char ch in str)
                {
                    if (!char.IsLetterOrDigit(ch))
                        str.Trim(ch);
                }
                if (!string.IsNullOrEmpty(str))
                    listclean.Add(str);
            }
            return listclean;
        }
        public static string LoadSelectedPreset()
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            return SettingFile.Read("SelectedPreset", "Settings");
        }


        public static void SavePreset(ListBox list)
        {
            IniFile SettingFile = new IniFile("Settings.ini");

            string selection = "";

            if (list.Items.Count > 0)
            {

                selection = list.Items[0].ToString();

                for (int i = 1; i < list.Items.Count; i++)
                {
                    selection = selection + "," + list.Items[i];
                }

            }

            SettingFile.Write("Presets", selection, "Settings");

            if(list.SelectedItem != null)
                SettingFile.Write("SelectedPreset", list.SelectedItem.ToString(), "Settings");

        }


        public static List<string> LoadSubStyles(string style)
        {

            style = style.Replace(" ", "_");
            IniFile SettingFile = new IniFile("Settings.ini");

            string[] list = Array.ConvertAll(SettingFile.Read(style, "Styles").Split(','), p => p.Trim());

            List<string> listclean = new List<string>();
            foreach (string str in list)
            {
                foreach (char ch in str)
                {
                    if (!char.IsLetterOrDigit(ch))
                        str.Trim(ch);
                }
                if (!string.IsNullOrEmpty(str))
                    listclean.Add(str);
            }
            return listclean;
        }


        public static void SaveSubStyles(ListBox list, string preset)
        {
            preset = preset.Replace(" ", "_");
            IniFile SettingFile = new IniFile("Settings.ini");

            string styles = "";

            if (list.Items.Count > 0)
            {

                styles = list.Items[0].ToString();

                for (int i = 1; i < list.Items.Count; i++)
                {
                    styles = styles + "," + list.Items[i];
                }

            }

            SettingFile.Write(preset, styles, "Styles");
        }



        public static List<string> LoadGenericStyles()
        {
            IniFile SettingFile = new IniFile("Settings.ini");

            string[] list = Array.ConvertAll(SettingFile.Read("GenericStyles", "Settings").Split(','), p => p.Trim());
            List<string> listclean = new List<string>();
            foreach (string str in list)
            {
                foreach (char ch in str)
                {
                    if (!char.IsLetterOrDigit(ch))
                        str.Trim(ch);
                }
                if (!string.IsNullOrEmpty(str))
                    listclean.Add(str);
            }
            return listclean;
        }




        public static List<string> LoadSelectedStyles()
        {

            IniFile SettingFile = new IniFile("Settings.ini");

            string[] list = Array.ConvertAll(SettingFile.Read("SelectedStyles", "Settings").Split(','), p => p.Trim());
            List<string> listclean = new List<string>();
            foreach (string str in list)
            {
                foreach (char ch in str)
                {
                    if (!char.IsLetterOrDigit(ch))
                        str.Trim(ch);
                }
                if (!string.IsNullOrEmpty(str))
                    listclean.Add(str);
            }
            return listclean;
        }




        private void RemovePreset(string preset)
        {
            IniFile SettingFile = new IniFile("Settings.ini");

            SettingFile.DeleteKey(preset.Replace(" ", "_"), "Styles");

        }



        public static void SaveSelectedStyles(ListBox list)
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            string Selection = "";

            if (list.Items.Count > 0)
            {

                Selection = list.Items[0].ToString();

                for (int i = 1; i < list.Items.Count; i++)
                {
                    Selection = Selection + "," + list.Items[i];
                }

            }

            SettingFile.Write("SelectedStyles", Selection, "Settings");

        }


        public static void SaveGenericStyles(ListBox list)
        {
            IniFile SettingFile = new IniFile("Settings.ini");

            string selection = "";

            if (list.Items.Count > 0)
            {

                selection = list.Items[0].ToString();

                for (int i = 1; i < list.Items.Count; i++)
                {
                    selection = selection + "," + list.Items[i];
                }

            }

            SettingFile.Write("GenericStyles", selection, "Settings");
        }


        public static void SaveAnimationMode(int index)
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            SettingFile.Write("AnimationMode", index.ToString(), "Settings");
        }















        public static void SaveSelectedFolder(string selectedfolder)
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            SettingFile.Write("SelectedFolder", selectedfolder, "Settings");

        }


        public static string LoadSelectedFolder()
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            return SettingFile.Read("SelectedFolder", "Settings");
        }










        public static void SavePromptInTxtFile(string path, string prompt, string styles ="", string settings = "", Bitmap initimage = null)
        {

            IniFile SettingFile = new IniFile(path + "\\prompt.ini");
            SettingFile.Write("text", prompt, "Prompt");
            SettingFile.Write("styles", styles, "Prompt");
            SettingFile.Write("settings", settings, "Prompt");
            if (initimage != null)
            {
                initimage.Save(path + "\\initimage.jpg");
            }
        }

        public static List<string> LoadPromptInTxtFile(string path)
        {
            List<string> list = new List<string>();

            IniFile SettingFile = new IniFile(path + "\\prompt.ini");

            list.Add(SettingFile.Read("text","Prompt"));
            list.Add(SettingFile.Read("styles", "Prompt"));
            list.Add(SettingFile.Read("settings", "Prompt"));
            list.Add(SettingFile.Read("prompt", "Prompt"));
            return list;
        }
    }
}
