
using System;

namespace Parking_Management_V3.Controllers.Interfaces
{
    interface ITblSource
    {
        string FetchThem();
        string FetchBgImg();
        int FetchLevel();
        bool InsertBaseSource();
        bool UpdateThem(string themSrc);
        bool UpdateBgImg(string bgImgSrc);
        bool UpdateLevel(int leve);
        long FetchXpHave();
        bool UpdateXpHave(long xpAmount);
        bool ChangePrintStatus(bool isEnable);
        bool FetchPrintStatus();
        bool UpdateColumnRatio(int ratio);
        int FetchColumnRatio();
        bool IsFirstTime();
        bool ChangeFirstLogStatus(bool status);
        bool VerifyHash(string hash);
        DateTime SelectActivatedTime();
        bool UpdateTimeCome(string time);
        string FetchTimeCome();
        bool UpdateIsUpdateReady(bool status);
        bool UpdateUpdateFileLocation(string location);
        bool UpdateCurrentFileLocation(string location);
        bool BackupDb(string filePath);
        bool RestoreDb(string filePath);

    }
}
