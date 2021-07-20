using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace Parking_Management_V3.Controllers
{
    static class MethodRepo
    {
        public static long PriceCalculator(string timeStayed, long entrancePrice, long pricePerHour)
        {
            string s;
            int c = 0;
            foreach (char i in timeStayed)
                if (i == '.')
                    c++;
            if (c == 0)
                s = timeStayed;
            else if (c == 1)
                s = timeStayed.Split('.')[0];
            else if (c == 2)
                s = timeStayed.Split('.')[1];
            else
                return 0;
            int hour = Convert.ToInt32(s.Split(':')[0]);
            if (hour > 0)
                return entrancePrice + hour * pricePerHour;
            return entrancePrice;
        }

        public static string DateTimeToPersian(DateTime date)
        {
            PersianCalendar calendar = new PersianCalendar();
            return calendar.GetYear(date).ToString() + '/' + calendar.GetMonth(date) + '/' + calendar.GetDayOfMonth(date);
        }

        public static string DayOfweek(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Saturday:
                    return "شنبه";
                case DayOfWeek.Sunday:
                    return "یکشنبه";
                case DayOfWeek.Monday:
                    return "دوشنبه";
                case DayOfWeek.Tuesday:
                    return "سه شنبه";
                case DayOfWeek.Wednesday:
                    return "چهارشنبه";
                case DayOfWeek.Thursday:
                    return "پنجشنبه";
                case DayOfWeek.Friday:
                    return "جمعه";
                default:
                    return null;
            }
        }

        public static string Regression(out double a, out double b, long[] x, double[] y)
        {
            if (x.Length != y.Length)
            {
                a = 0;
                b = 0;
                return null;
            }
            double[] xp2 = new double[x.Length];
            double[] yp2 = new double[y.Length];
            double[] xy = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                xp2[i] = Math.Pow(x[i], 2);
                yp2[i] = Math.Pow(y[i], 2);
                xy[i] = x[i] * y[i];
            }
            a = (x.Sum() * y.Sum() - x.Length * xy.Sum()) / (Math.Pow(x.Sum(), 2) - x.Length * xp2.Sum());
            b = (x.Sum() * xy.Sum() - y.Sum() * xp2.Sum()) / (Math.Pow(x.Sum(), 2) - x.Length * xp2.Sum());
            return (a + " x + " + b + " = y");
        }

        public static void LinearRegression(out double b, out double a, long[] xVals, double[] yVals)
        {
            if (xVals.Length != yVals.Length) { }
            double sumOfX = 0;
            double sumOfY = 0;
            double sumOfXSq = 0;
            double sumCodeviates = 0;
            for (var i = 0; i < xVals.Length; i++)
            {
                var x = xVals[i];
                var y = yVals[i];
                sumCodeviates += x * y;
                sumOfX += x;
                sumOfY += y;
                sumOfXSq += x * x;
            }
            var count = xVals.Length;
            var ssX = sumOfXSq - sumOfX * sumOfX / count;
            var sCo = sumCodeviates - sumOfX * sumOfY / count;
            var meanX = sumOfX / count;
            var meanY = sumOfY / count;
            b = meanY - sCo / ssX * meanX;
            a = sCo / ssX;
        }

        public static long LevelXp(int level)
        {
            if (level <= 3)
                return (long)(Math.Pow(2, level) + level + 1) * 1000;
            double total = 0;
            for (int i = 1; i < level; i++)
                total += Math.Floor(i + 300 * Math.Pow(2, i / 7.0));
            return (long)Math.Floor(total / 4) * 1000;
        }

        public static DateTime C24To12(string t24)
        {
            string[] datetime = t24.Split(' ');
            string time = datetime[1];
            string[] timelaps = time.Split(':');
            int hour = Convert.ToInt32(timelaps[0]);
            int min = Convert.ToInt32(timelaps[1]);
            int sec = Convert.ToInt32(timelaps[2]);
            if (hour > 12)
            {
                hour -= 12;
                return DateTime.Parse(datetime[0] + " " + hour + ":" + min + ":" + sec + " PM");
            }
            if (hour == 12 && (min > 0 || sec > 0))
                return DateTime.Parse(datetime[0] + " " + hour + ":" + min + ":" + sec + " PM");
            if (datetime[2] == "PM")
                return DateTime.Parse(t24);
            if (hour == 0 && min == 0 && sec == 0)
                return DateTime.Parse(t24.Split('.')[0] + " AM");
            return DateTime.Parse(datetime[0] + " " + datetime[1] + " AM");
        }

        public static string C12To24(DateTime t12)
        {
            string[] datetime = t12.ToString().Split(' ');
            string[] cDate = datetime[0].Split('/');
            string date = cDate[2] + '-' + cDate[0] + '-' + cDate[1];
            string[] time = datetime[1].Split(':');
            int hour = Convert.ToInt32(time[0]);
            int min = Convert.ToInt32(time[1]);
            int sec = Convert.ToInt32(time[2]);
            if (datetime[2] == "PM")
                hour += 12;
            if (hour == 24)
                hour = 0;
            return date + " " + hour + ":" + min + ":" + sec;
        }

        public static DateTime GetNistTime()
        {
            try
            {
                if (CheckForInternetConnection())
                {
                    var myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.microsoft.com");
                    var response = myHttpWebRequest.GetResponse();
                    string todaysDates = response.Headers["date"];
                    return DateTime.ParseExact(todaysDates,
                        "ddd, dd MMM yyyy HH:mm:ss 'GMT'",
                        CultureInfo.InvariantCulture.DateTimeFormat,
                        DateTimeStyles.AssumeUniversal);
                }
                throw new WebException();
            }
            catch (WebException exception)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw exception;
            }
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static string EncodeServerName(string serverName)
        {
            for (int i = 0; i < 10; i++)
            {
                serverName = Convert.ToBase64String(Encoding.UTF8.GetBytes(serverName));
            }
            return serverName;
        }

        public static string DecodeServerName(string encodedServername)
        {
            for (int i = 0; i < 10; i++)
            {
                encodedServername = Encoding.UTF8.GetString(Convert.FromBase64String(encodedServername));
            }
            return encodedServername;
        }

        public static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool AddLicenseToDb(string name, string identificationNo, string license, DateTime dateExpire)
        {
            try
            {
                SqlConnection con =
                        new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ParkingManagementOnline"].ConnectionString);
                con.Open();
                SqlCommand command = new SqlCommand("AddValidatin", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Name", SqlDbType.NVarChar);
                command.Parameters.Add("@IdentificationNo", SqlDbType.NVarChar);
                command.Parameters.Add("@Hash", SqlDbType.NVarChar);
                command.Parameters.Add("@DateExpire", SqlDbType.NVarChar);
                command.Parameters[0].Value = name;
                command.Parameters[1].Value = identificationNo;
                command.Parameters[2].Value = license;
                command.Parameters[3].Value = dateExpire.AddYears(1).ToString().Split(' ')[0];
                command.ExecuteNonQuery();
                command.Dispose();
                con.Close();
                SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=ParkingManagementV3;Integrated Security=True");
                connection.Open();
                SqlCommand command2 = new SqlCommand($"UPDATE dbo.TblSource SET Hash = '{license}'", connection);
                command2.ExecuteNonQuery();
                command2.Dispose();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsLicenseValid(string license)
        {
            try
            {
                string sha = ComputeSha256Hash(license);
                if (sha[sha.Length - 1].ToString() == "1" && sha[sha.Length - 2].ToString() == "1" &&
                    sha[sha.Length - 3].ToString() == "1" && sha[sha.Length - 4].ToString() == "1")
                {
                    SqlConnection con =
                        new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ParkingManagementOnline"].ConnectionString);
                    con.Open();
                    SqlCommand command = new SqlCommand("IsLicenseValid", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@License", SqlDbType.NVarChar);
                    command.Parameters[0].Value = license;
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    if (!reader.HasRows)
                    {
                        con.Close();
                        return true;
                    }
                    con.Close();
                    return false;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public static void CopyDirectory(string sourceDirectory, string targetDirectory)
        {
            DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
            DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);

            CopyAll(diSource, diTarget);
        }

        private static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }

    }
}
