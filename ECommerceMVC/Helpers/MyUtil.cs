using System.Text;

namespace ECommerceMVC.Helpers
{
    public class MyUtil
    {
        public static string UploadHinh(IFormFile Hinh, string folder)
        {
            try
            {
                var fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Hinh", folder, Hinh.FileName);
                using (var myfile = new FileStream(fullPath, FileMode.CreateNew))
                {
                    Hinh.CopyTo(myfile);
                }
                return Hinh.FileName;
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }
        public static string GennerateRandomKey(int length = 5)
        {
            var pattern = @"qưertyuioplkjhgfdsazxcvbnmQƯERTYUIOPLKJHGFDSAZXCVBNM!";
            var sb = new StringBuilder();
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                sb.Append(pattern[rand.Next(0, pattern.Length)]);
            }
            return sb.ToString();
        }
    }
}
