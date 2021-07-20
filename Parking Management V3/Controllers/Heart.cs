using System;
using System.Collections.Generic;
using Parking_Management_V3.Controllers.Controllers;
using Parking_Management_V3.Models;
using Parking_Management_V3.Utility;

namespace Parking_Management_V3.Controllers
{
    public class Heart
    {
        public TblAgent LoginAgent(TblAgent agent)
        {
            return new AgentProvider().LoginAgent(agent);
        }

        public bool AddAgent(TblAgent agent)
        {
            return new AgentProvider().AddAgent(agent);
        }

        public bool DeleteAgent(TblAgent agent)
        {
            return new AgentProvider().DeleteAgent(agent);
        }

        public bool EditAgent(TblAgent newAgent, TblAgent oldAgent)
        {
            return new AgentProvider().EditAgent(newAgent, oldAgent);
        }

        public TblCostomerVehicle FetchCostomerAndVehicleByVehicleId(string vehicleId)
        {
            return new CostomerVehicleProvider().FetchCostomerAndVehicleByVehicleId(vehicleId);
        }

        public List<TblCostomerVehicleSearchView> FetchCostomerVehicleSearch(string vehicleIdOrName)
        {
            return new CostomerVehicleProvider().FetchCostomerVehicleSearch(vehicleIdOrName);
        }

        public TblCostomerVehicle FetchCostomerAndVehicleByPosition(int floor, int positionId)
        {
            return new CostomerVehicleProvider().FetchCostomerAndVehicleByPosition(positionId, floor);
        }

        public bool AddCostomerVehicle(TblCostomerVehicle costomerVehicle)
        {
            return new CostomerVehicleProvider().AddCostomerVehicle(costomerVehicle);
        }

        public bool DeleteCostomerVehicle(TblCostomerVehicle costomerVehicle)
        {
            return new CostomerVehicleProvider().DeleteCostomerVehicle(costomerVehicle);
        }

        public bool EditCostomerVehicle(TblCostomerVehicle newCostomerVehicle, TblCostomerVehicle oldCostomerVehicle)
        {
            return new CostomerVehicleProvider().EditCostomerVehicle(newCostomerVehicle, oldCostomerVehicle);
        }

        public bool AddFloor()
        {
            return new FloorAndSpotProvider().AddFloor();
        }

        public bool DeleteFloor()
        {
            return new FloorAndSpotProvider().DeleteFloor();
        }

        public bool AddSpot(int floorNumber)
        {
            return new FloorAndSpotProvider().AddSpot(floorNumber);
        }

        public bool DeleteSpot(int floorNumber)
        {
            return new FloorAndSpotProvider().DeleteSpot(floorNumber);
        }

        public bool ResetTblAgent()
        {
            return new SettingProvider().ResetTblAgent();
        }

        public bool ResetFloorsAndSpots()
        {
            return new SettingProvider().ResetFloorsAndSpots();
        }

        public bool ResetTblCostomerVehicle()
        {
            return new SettingProvider().ResetTblCostomerVehicle();
        }

        public List<TblFloor_i> FetchSpots(int floor)
        {
            return new FloorAndSpotProvider().FetchSpots(floor);
        }

        public int FetchFloorCount()
        {
            return new FloorAndSpotProvider().FetchFloorCount();
        }

        public bool EnterSpot(int floor, int id, string vehicleId)
        {
            return new FloorAndSpotProvider().EnterSpot(id, floor, vehicleId);
        }

        public bool ExitSpot(int floor, int id)
        {
            return new FloorAndSpotProvider().ExitSpot(id, floor);
        }

        public bool EnterVip(int id, int floor, string vehicleId)
        {
            return new FloorAndSpotProvider().EnterVip(id, floor, vehicleId);
        }

        public bool Execute(string cmdTxt)
        {
            return new MainProvider().Execute(cmdTxt);
        }

        public TblVip FetchVipWithVehicleId(TblVip vip)
        {
            return new VipProvider().FetchVipWithVehicleId(vip);
        }

        public TblProgramm FetchProgrammWithName(TblProgramm programm)
        {
            return new ProgrammProvider().FetchProgrammWithName(programm);
        }

        public bool AddVip(TblVip vip)
        {
            return new VipProvider().AddVip(vip);
        }

        public bool AddProgramm(TblProgramm programm)
        {
            return new ProgrammProvider().AddProgramm(programm);
        }

        public bool DeleteVip(TblVip vip)
        {
            return new VipProvider().DeleteVip(vip);
        }

        public bool EditVip(TblVip newVip, TblVip oldVip)
        {
            return new VipProvider().EditVip(newVip, oldVip);
        }

        public bool DeleteProgramm(TblProgramm programm)
        {
            return new ProgrammProvider().DeleteProgramm(programm);
        }

        public List<TblProgramm> FetchAllProgramms()
        {
            return new ProgrammProvider().FetchAllProgramms();
        }

        public TblProgramm FetchProgrammWithId(TblProgramm program)
        {
            return new ProgrammProvider().FetchProgrammWithId(program);
        }

        public List<TblVip> FetchAllVips()
        {
            return new VipProvider().FetchAllVips();
        }

        public List<TblCostomerVehicle> FetchAllCostomerVehicles()
        {
            return new CostomerVehicleProvider().FetchAllCostomerVehicles();
        }
        public List<TblVip> FetchCurrentVips()
        {
            return new VipProvider().FetchCurrentVips();
        }

        public List<TblCostomerVehicle> FetchTimedCostomerVehicles(DateTime fromTime, DateTime toTime)
        {
            return new CostomerVehicleProvider().FetchTimedCostomerVehicles(fromTime, toTime);
        }

        public List<TblVip> FetchTimedVips(DateTime fromTime, DateTime toTime)
        {
            return new VipProvider().FetchTimedVips(fromTime, toTime);
        }

        public string FetchThem()
        {
            return new SourceProvider().FetchThem();
        }

        public string FetchBgImg()
        {
            return new SourceProvider().FetchBgImg();
        }

        public int FetchLevel()
        {
            return new SourceProvider().FetchLevel();
        }

        public bool InsertBaseSource()
        {
            return new SourceProvider().InsertBaseSource();
        }

        public bool UpdateThem(string themSrc)
        {
            return new SourceProvider().UpdateThem(themSrc);
        }

        public bool UpdateBgImg(string bgImgSrc)
        {
            return new SourceProvider().UpdateBgImg(bgImgSrc);
        }

        public bool UpdateLevel(int level)
        {
            return new SourceProvider().UpdateLevel(level);
        }

        public long FetchXpHave()
        {
            return new SourceProvider().FetchXpHave();
        }

        public bool UpdateXpHave(long xpAmount)
        {
            return new SourceProvider().UpdateXpHave(xpAmount);
        }

        public bool ChangePrintStatus(bool isEnable)
        {
            return new SourceProvider().ChangePrintStatus(isEnable);
        }

        public bool FetchPrintStatus()
        {
            return new SourceProvider().FetchPrintStatus();
        }

        public bool UpdateColumnRatio(int ratio)
        {
            return new SourceProvider().UpdateColumnRatio(ratio);
        }

        public int FetchColumnRatio()
        {
            return new SourceProvider().FetchColumnRatio();
        }

        public bool AddPricingPolicy(TblPricingPolicy pricingPolicy)
        {
            return new PricingPolicyProvider().AddPricingPolicy(pricingPolicy);
        }

        public bool UpdatePricingPolicy(TblPricingPolicy pricingPolicy, int logId)
        {
            return new PricingPolicyProvider().UpdatePricingPolicy(pricingPolicy, logId);
        }

        public bool DeletePricingPolicy(int id)
        {
            return new PricingPolicyProvider().DeletePricingPolicy(id);
        }

        public TblPricingPolicy SelectPricingPolicyById(int id)
        {
            return new PricingPolicyProvider().SelectPricingPolicyById(id);
        }

        public List<TblPricingPolicy> SelectAllPricingPolicies()
        {
            return new PricingPolicyProvider().SelectAllPricingPolicies();
        }

        public bool IsFirstTime()
        {
            return new SourceProvider().IsFirstTime();
        }

        public bool ChangeFirstLogStatus(bool status)
        {
            return new SourceProvider().ChangeFirstLogStatus(status);
        }

        public bool VerifyHash(string hash)
        {
            return new SourceProvider().VerifyHash(hash);
        }

        public DateTime SelectActivatedTime()
        {
            return new SourceProvider().SelectActivatedTime();
        }

        public bool UpdateTimeCome(string time)
        {
            return new SourceProvider().UpdateTimeCome(time);
        }

        public string FetchTimeCome()
        {
            return new SourceProvider().FetchTimeCome();
        }

        public bool UpdateIsUpdateReady(bool status)
        {
            return new SourceProvider().UpdateIsUpdateReady(status);
        }

        public bool UpdateUpdateFileLocation(string location)
        {
            return new SourceProvider().UpdateUpdateFileLocation(location);
        }

        public bool UpdateCurrentFileLocation(string location)
        {
            return new SourceProvider().UpdateCurrentFileLocation(location);
        }

        public bool BackupDb(string filePath)
        {
            return new SourceProvider().BackupDb(filePath);
        }

        public bool RestoreDb(string filePath)
        {
            return new SourceProvider().RestoreDb(filePath);
        }
    }
}