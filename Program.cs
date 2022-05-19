using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FormMain.Menu());
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/api/system.configuration.configurationmanager.appsettings?view=dotnet-plat-ext-6.0
        /// </summary>
        /// <param name="key"></param>
        public static string AppSettings(string key)
        {
            return ConfigurationManager.AppSettings[key] ?? "Not Found";
        }

        public static void AppSettings(string key, string value)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;

            if (settings[key] == null) settings.Add(key, value);
            else settings[key].Value = value;

            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }

        public static DialogResult WarningTwice(string text, string caption = "Warning!!!")
        {
            DialogResult result = MessageBox.Show(
                    text,
                    caption + " (1)",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Cancel) return result;

            result = MessageBox.Show(
                    "Are you Sure?",
                    caption + " (2)",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

            return result;
        }




    }
}
