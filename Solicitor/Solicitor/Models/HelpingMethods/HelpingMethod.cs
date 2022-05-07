using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Web;

namespace Solicitor.Models.HelpingMethods
{
    public abstract class HelpingMethod
    {
        public static int PageSize
        {
            get
            {
                return 3;
            }
        }

        public static int IsValidNumber(string number)
        {
            int.TryParse(number, out int result);
            return result;
        }

        public static int IsValidNumber(string firstNumber, string secondNumber)
        {
            int.TryParse(firstNumber, out int resultFirst);
            int.TryParse(secondNumber, out int resultSecond);

            return ((resultFirst == 0 || resultSecond == 0) ? 0 : -1);
        }

        public static int IsValidPageNumber(string number)
        {
            int.TryParse(number, out int result);
            return (result == 0 ? 1 : result);
        }

        public static string TruncateCharacters(int number, string value)
        {
            return value.Substring(0, Math.Min(value.Length, number));
        }

        public static bool ValidateImageFile(HttpPostedFileBase image)
        {
            if (image == null || image.ContentLength > 1 * 1024 * 1024)
            {
                return false;
            }

            try
            {
                using (var img = Image.FromStream(image.InputStream))
                {
                    return img.RawFormat.Equals(ImageFormat.Png) || img.RawFormat.Equals(ImageFormat.Jpeg);
                }
            }
            catch { }
            return false;
        }

        public static string GetFileName(string fileName)
        {
            string fileExtension = Path.GetExtension(fileName);
            Random rnd = new Random();
            long number = rnd.Next(500000);
            fileName = number.ToString() + fileExtension;
            return fileName;
        }

        public static string GetDay(DateTime date)
        {
            DateTime _date = date;
            return _date.Day.ToString();
        }

        public static string GetMonth(DateTime date)
        {
            DateTime _date = date;
            return _date.ToString("MMM");
        }

        public static string GetYear(DateTime date)
        {
            DateTime _date = date;
            return _date.ToString("yyyy");
        }

        public static string OpenElement(int counter)
        {
            if (counter == 1)
                return "<div class='column-1'>";
            else if (counter == 4)
                return "<div class='column-2'>";
            else if (counter == 7)
                return "<div class='column-3'>";
            else if (counter == 10)
                return "<div class='column-4'>";
            else if (counter == 13)
                return "<div class='column-5'>";
            return string.Empty;
        }

        public static string CloseElement(int counter)
        {
            if (counter == 3)
                return "</div>";
            else if (counter == 6)
                return "</div>";
            else if (counter == 9)
                return "</div>";
            else if (counter == 12)
                return "</div>";
            else if (counter == 15)
                return "</div>";
            return string.Empty;
        }
    }
}