using System;
using Parking_Management_V3.Controllers.Interfaces;
using Parking_Management_V3.Utility;

namespace Parking_Management_V3.Controllers.Controllers
{
    class SourceProvider : ITblSource
    {
        public string FetchThem()
        {
            MainProvider main = new MainProvider();
            return main.FetchThem();
        }

        public string FetchBgImg()
        {
            MainProvider main = new MainProvider();
            return main.FetchBgImg();
        }

        public int FetchLevel()
        {
            MainProvider main = new MainProvider();
            return main.FetchLevel();
        }

        public bool InsertBaseSource()
        {
            MainProvider main = new MainProvider();
            return main.InsertBaseSource();
        }

        public bool UpdateThem(string themSrc)
        {
            MainProvider main = new MainProvider();
            return main.UpdateThem(themSrc);
        }

        public bool UpdateBgImg(string bgImgSrc)
        {
            MainProvider main = new MainProvider();
            return main.UpdateBgImg(bgImgSrc);
        }

        public bool UpdateLevel(int level)
        {
            MainProvider main = new MainProvider();
            return main.UpdateLevel(level);
        }

        public long FetchXpHave()
        {
            MainProvider main = new MainProvider();
            return main.FetchXpHave();
        }

        public bool UpdateXpHave(long xpAmount)
        {
            MainProvider main = new MainProvider();
            return main.UpdateXpHave(xpAmount);
        }

        public bool ChangePrintStatus(bool isEnable)
        {
            MainProvider main = new MainProvider();
            return main.ChangePrintStatus(isEnable);
        }

        public bool FetchPrintStatus()
        {
            MainProvider main = new MainProvider();
            return main.FetchPrintStatus();
        }

        public bool UpdateColumnRatio(int ratio)
        {
            MainProvider main = new MainProvider();
            return main.UpdateColumnRatio(ratio);
        }

        public int FetchColumnRatio()
        {
            MainProvider main = new MainProvider();
            return main.FetchColumnRatio();
        }

        public bool IsFirstTime()
        {
            MainProvider main = new MainProvider();
            return main.IsFirstTime();
        }

        public bool ChangeFirstLogStatus(bool status)
        {
            MainProvider main = new MainProvider();
            return main.ChangeFirstLogStatus(status);
        }

        public bool VerifyHash(string hash)
        {
            MainProvider main = new MainProvider();
            return main.VerifyHash(hash);
        }

        public DateTime SelectActivatedTime()
        {
            MainProvider main = new MainProvider();
            return main.SelectActivatedTime();
        }

        public bool UpdateTimeCome(string time)
        {
            MainProvider main = new MainProvider();
            return main.UpdateTimeCome(time);
        }

        public string FetchTimeCome()
        {
            MainProvider main = new MainProvider();
            return main.FetchTimeCome();
        }

        public bool UpdateIsUpdateReady(bool status)
        {
            MainProvider main = new MainProvider();
            return main.UpdateIsUpdateReady(status);
        }

        public bool UpdateUpdateFileLocation(string location)
        {
            MainProvider main = new MainProvider();
            return main.UpdateUpdateFileLocation(location);
        }

        public bool UpdateCurrentFileLocation(string location)
        {
            MainProvider main = new MainProvider();
            return main.UpdateCurrentFileLocation(location);
        }

        public bool BackupDb(string filePath)
        {
            MainProvider main = new MainProvider();
            return main.BackupDb(filePath);
        }

        public bool RestoreDb(string filePath)
        {
            MainProvider main = new MainProvider();
            return main.RestoreDb(filePath);
        }
    }
}
