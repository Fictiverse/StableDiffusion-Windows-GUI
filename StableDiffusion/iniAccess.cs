using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StableDiffusion
{
    class iniAccess
    {

        public static void SaveAnacondaPath(string value)
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            SettingFile.Write("AnacondaPath", value, "Settings");
        }
        public static string LoadAnacondaPath()
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            return SettingFile.Read("AnacondaPath", "Settings");
        }

        public static void SaveEnvName(string value)
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            SettingFile.Write("EnvName", value, "Settings");
        }
        public static string LoadEnvName()
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            return SettingFile.Read("EnvName", "Settings");
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
            return Convert.ToInt16(Convert.ToInt16(SettingFile.Read("Iteration", "Settings")) / 25);
        }



        public static void SaveN_iter(decimal value)
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            SettingFile.Write("N_iter", value.ToString(), "Settings");
        }

        public static Int16 LoadN_iter()
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            return Convert.ToInt16(SettingFile.Read("N_iter", "Settings"));
        }



        public static void SaveN_samples(decimal value)
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            SettingFile.Write("N_samples", value.ToString(), "Settings");
        }

        public static Int16 LoadN_samples()
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            return Convert.ToInt16(SettingFile.Read("N_samples", "Settings"));
        }



        public static void SaveStrength(decimal value)
        {

            IniFile SettingFile = new IniFile("Settings.ini");
            SettingFile.Write("Strength", ((float)value / 20).ToString().ToString(), "Settings");
        }

        public static Int16 LoadStrength()
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            return Convert.ToInt16(Convert.ToDouble(SettingFile.Read("Strength", "Settings")) * 20);
        }



        public static string[] LoadStyles()
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            return SettingFile.Read("StyleList", "Settings").Split(',');
        }


        public static string[] LoadSubStyles(string style)
        {

            style = style.Replace(" ", "_");
            IniFile SettingFile = new IniFile("Settings.ini");
            return SettingFile.Read(style, "Styles").Split(',');
        }



        public static void SaveSelected(string Style, string value)
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            SettingFile.Write(Style, value, "Selection");
        }

        public static void SaveFX(ListBox list)
        {
            IniFile SettingFile = new IniFile("Settings.ini");


            string Styles = list.Items[0].ToString();

            for (int i = 1; i < list.Items.Count; i++)
            {
                Styles = Styles + "," + list.Items[i];
            }


            SettingFile.Write("Styles", Styles, "Settings");
        }

        public static void SaveSelectedFX(ListBox list)
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            string Selection = "";

            if (list.SelectedIndices.Count > 0)
            {

                Selection = list.SelectedIndices[0].ToString();

                for (int i = 1; i < list.SelectedIndices.Count; i++)
                {
                    Selection = Selection + "," + list.SelectedIndices[i];
                }

            }


            SettingFile.Write("SelectedStyles", Selection, "Settings");


        }


        public static void SaveAnimationMode(int index)
        {
            IniFile SettingFile = new IniFile("Settings.ini");
            SettingFile.Write("AnimationMode", index.ToString(), "Settings");
        }




    }
}
