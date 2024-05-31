using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailPrinter.Library
{
    public class Global
    {
        /// <summary>
        /// Decrypt Method
        /// </summary>
        /// <param name="input">Input Text To Decrypt</param>
        /// <returns>Decrypted Text</returns>
        public static string Decrypt(string input)
        {
            string encryptedText = input;

            encryptedText = encryptedText.Replace("*1*2*", "+");

            return (Encryption.Decrypt(encryptedText));
        }

        /// <summary>
        /// Encrypt Method
        /// </summary>
        /// <param name="input">Input Text To Encrypt</param>
        /// <returns>Encrypted Text</returns>
        public static string Encrypt(string input)
        {
            string sampleText = string.Empty;

            sampleText = Encryption.Encrypt(input);

            sampleText = sampleText.Replace("+", "*1*2*");

            return (sampleText);
        }

        public static void WriteLog(string str, string filename ="Log.txt")
        {
            File.AppendAllText(filename, DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + " - " + str + Environment.NewLine);
        }

        public static bool SoftwareEndOfLife()
        {
            try
            {
                DateTime dateExp = DateTime.ParseExact("2024-12-25", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                DateTime nowdate = DateTime.UtcNow.Date;
                Int32 dateDiff = Convert.ToInt32((dateExp - nowdate).Days);
                if (dateDiff < 1)
                {
                    Library.Global.WriteLog("---NOT VALID EXIT---");
                    //System.Environment.Exit(0);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Library.Global.WriteLog("VALIDATION FAILED");
            }

            return false;
        }

        public DateTime UTCtoLocalTime(DateTime dt)
        {
            try
            {
                //TimeZoneInfo targetZone = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");
                //DateTime newDT = TimeZoneInfo.ConvertTimeFromUtc(dt, targetZone);

                DateTime newDT = TimeZoneInfo.ConvertTimeFromUtc(dt, TimeZoneInfo.Local);

                return newDT;
            }
            catch (Exception ex)
            {
                WriteLog(ex.Message);
                return DateTime.UtcNow;
            }
        }
    }
}
