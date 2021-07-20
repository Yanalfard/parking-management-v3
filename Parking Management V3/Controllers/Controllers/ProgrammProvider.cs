using System.Collections.Generic;
using Parking_Management_V3.Controllers.Interfaces;
using Parking_Management_V3.Models;
using Parking_Management_V3.Utility;

namespace Parking_Management_V3.Controllers.Controllers
{
    public class ProgrammProvider : ITblProgramm
    {
        public TblProgramm FetchProgrammWithName(TblProgramm programm)
        {
            return new MainProvider().FetchProgrammWithName(programm.Name);
        }
        public bool AddProgramm(TblProgramm programm)
        {
            MainProvider main = new MainProvider();
            return main.Insert(programm, 3);
        }

        public bool DeleteProgramm(TblProgramm programm)
        {
            MainProvider main = new MainProvider();
            return main.Delete(3, programm.Id.ToString());
        }

        public List<TblProgramm> FetchAllProgramms()
        {
            MainProvider main = new MainProvider();
            return main.FetchAllProgramms();
        }

        public TblProgramm FetchProgrammWithId(TblProgramm programm)
        {
            MainProvider main = new MainProvider();
            return main.FetchProgrammWithId(programm.Id);
        }
    }
}