using System.Collections.Generic;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Controllers.Interfaces
{
    interface ITblProgramm
    {
        TblProgramm FetchProgrammWithName(TblProgramm programm);
        bool AddProgramm(TblProgramm programm);
        bool DeleteProgramm(TblProgramm programm);
        List<TblProgramm> FetchAllProgramms();
        TblProgramm FetchProgrammWithId(TblProgramm programm);

    }
}
