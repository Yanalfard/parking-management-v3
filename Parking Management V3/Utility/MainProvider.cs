using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Parking_Management_V3.Controllers;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Utility
{
    public class MainProvider
    {
        private SqlConnection _connection;
        private SqlCommand _command;
        private const string Connectionstring = "Data Source=.;Initial Catalog=ParkingManagementV3;Integrated Security=True";
        private string _commandText;
        private SqlDataReader _reader;
        private SqlDataAdapter _adapter;

        public MainProvider()
        {
            _connection = new SqlConnection(Connectionstring);
            _connection.Open();
        }

        public TblAgent Login(TblAgent agent)
        {
            try
            {
                _command = new SqlCommand("Login", _connection);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.Add("@Username", SqlDbType.NVarChar);
                _command.Parameters.Add("@Password", SqlDbType.NVarChar);
                _command.Parameters[0].Value = agent.Username;
                _command.Parameters[1].Value = agent.Password;
                DsTables tables = new DsTables();
                _adapter = new SqlDataAdapter(_command);
                _adapter.Fill(tables.Tables["TblAgents"]);
                _adapter.Dispose();
                _command.Dispose();
                return new TblAgent(Convert.ToInt32(tables.Tables["TblAgents"].Rows[0]["id"]), long.Parse(tables.Tables["TblAgents"].Rows[0]["Identification"].ToString()), tables.Tables["TblAgents"].Rows[0]["FirstName"].ToString(), tables.Tables["TblAgents"].Rows[0]["LastName"].ToString(), tables.Tables["TblAgents"].Rows[0]["Username"].ToString(), tables.Tables["TblAgents"].Rows[0]["Password"].ToString(), tables.Tables["TblAgents"].Rows[0]["ImageSrc"].ToString());
            }
            catch
            {
                return new TblAgent(-1);
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool Insert(object table, int status)
        {
            try
            {
                switch (status)
                {
                    case 0:
                        TblAgent agent = (TblAgent)table;
                        _commandText = $"InsertAgent";
                        _command = new SqlCommand(_commandText, _connection);
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.Add("@Identification", SqlDbType.BigInt);
                        _command.Parameters.Add("@FirstName", SqlDbType.NVarChar);
                        _command.Parameters.Add("@LastName", SqlDbType.NVarChar);
                        _command.Parameters.Add("@Username", SqlDbType.NVarChar);
                        _command.Parameters.Add("@Password", SqlDbType.NVarChar);
                        _command.Parameters.Add("@ImageSrc", SqlDbType.NVarChar);
                        _command.Parameters[0].Value = agent.Identification;
                        _command.Parameters[1].Value = agent.FirstName;
                        _command.Parameters[2].Value = agent.LastName;
                        _command.Parameters[3].Value = agent.Username;
                        _command.Parameters[4].Value = agent.Password;
                        _command.Parameters[5].Value = agent.ImageSrc;
                        break;
                    case 1:
                        TblCostomerVehicle costomerVehicle = (TblCostomerVehicle)table;
                        SqlCommand getLastId = new SqlCommand("getLastId", _connection);
                        SqlDataReader reader = getLastId.ExecuteReader();
                        reader.Read();
                        int lastId = int.Parse(reader[0].ToString());
                        reader.Close();
                        reader.Dispose();
                        getLastId.Dispose();
                        string k;
                        k = MethodRepo.C12To24(costomerVehicle.TimeArrived);
                        string k2;
                        if (costomerVehicle.TimeGone == DateTime.Parse("1/1/0001 12:00:00 AM"))
                        {
                            k2 = "2001-1-1 3:00";
                            costomerVehicle.TimeStayed = "";
                            costomerVehicle.Price = 0;
                        }
                        else
                        {
                            k2 = MethodRepo.C12To24(costomerVehicle.TimeGone);
                            costomerVehicle.TimeStayed = "";
                            costomerVehicle.Price = 0;
                        }
                        _commandText = $"InsertCostomerVehicle";
                        _command = new SqlCommand(_commandText, _connection);
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.Add("@id", SqlDbType.Int);
                        _command.Parameters.Add("@Name", SqlDbType.NVarChar);
                        _command.Parameters.Add("@TimeArrived", SqlDbType.DateTime);
                        _command.Parameters.Add("@TimeGone", SqlDbType.DateTime);
                        _command.Parameters.Add("@TimeStayed", SqlDbType.NVarChar);
                        _command.Parameters.Add("@Price", SqlDbType.BigInt);
                        _command.Parameters.Add("@Floor", SqlDbType.Int);
                        _command.Parameters.Add("@Column", SqlDbType.Int);
                        _command.Parameters.Add("@Row", SqlDbType.Int);
                        _command.Parameters.Add("@PositionId", SqlDbType.NVarChar);
                        _command.Parameters.Add("@VehicleId", SqlDbType.NVarChar);
                        _command.Parameters[0].Value = lastId + 1;
                        _command.Parameters[1].Value = costomerVehicle.Name;
                        _command.Parameters[2].Value = k;
                        _command.Parameters[3].Value = k2;
                        _command.Parameters[4].Value = costomerVehicle.TimeStayed;
                        _command.Parameters[5].Value = costomerVehicle.Price;
                        _command.Parameters[6].Value = costomerVehicle.Floor;
                        _command.Parameters[7].Value = costomerVehicle.Column;
                        _command.Parameters[8].Value = costomerVehicle.Row;
                        _command.Parameters[9].Value = costomerVehicle.PositionId;
                        _command.Parameters[10].Value = costomerVehicle.VehicleId;

                        break;
                    case 2:
                        TblVip vip = (TblVip)table;
                        _commandText = $"InsertVip";
                        _command = new SqlCommand(_commandText, _connection);
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.Add("@FirstName", SqlDbType.NVarChar);
                        _command.Parameters.Add("@LastName", SqlDbType.NVarChar);
                        _command.Parameters.Add("@TimeHoldFrom", SqlDbType.DateTime);
                        _command.Parameters.Add("@TimeHoldTo", SqlDbType.DateTime);
                        _command.Parameters.Add("@Floor", SqlDbType.Int);
                        _command.Parameters.Add("@Column", SqlDbType.Int);
                        _command.Parameters.Add("@Row", SqlDbType.Int);
                        _command.Parameters.Add("@PositionId", SqlDbType.NVarChar);
                        _command.Parameters.Add("@VehicleId", SqlDbType.NVarChar);
                        _command.Parameters.Add("@ProgrammId", SqlDbType.Int);
                        _command.Parameters[0].Value = vip.FirstName;
                        _command.Parameters[1].Value = vip.LastName;
                        _command.Parameters[2].Value = MethodRepo.C12To24(vip.TimeHoldFrom);
                        _command.Parameters[3].Value = MethodRepo.C12To24(vip.TimeHoldTo);
                        _command.Parameters[4].Value = vip.Floor;
                        _command.Parameters[5].Value = vip.Column;
                        _command.Parameters[6].Value = vip.Row;
                        _command.Parameters[7].Value = vip.PositionId;
                        _command.Parameters[8].Value = vip.VehicleId;
                        _command.Parameters[9].Value = vip.ProgrammId;

                        break;
                    case 3:
                        TblProgramm programm = (TblProgramm)table;
                        _commandText = $"InsertProgramm";
                        _command = new SqlCommand(_commandText, _connection);
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.Add("@Name", SqlDbType.NVarChar);
                        _command.Parameters.Add("@TimeHold", SqlDbType.Int);
                        _command.Parameters.Add("@Price", SqlDbType.BigInt);
                        _command.Parameters.Add("@Discription", SqlDbType.NVarChar);
                        _command.Parameters[0].Value = programm.Name;
                        _command.Parameters[1].Value = programm.TimeHold;
                        _command.Parameters[2].Value = programm.Price;
                        _command.Parameters[3].Value = programm.Discription;
                        break;
                    default:
                        return false;
                }
                _command.ExecuteNonQuery();
                _command.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool Delete(int status, string vehicleIdOrIdentification)
        {
            try
            {
                switch (status)
                {
                    case 0:
                        _commandText = $"DeleteAgent";
                        _command = new SqlCommand(_commandText, _connection);
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.Add("@Identification", SqlDbType.BigInt);
                        _command.Parameters[0].Value = long.Parse(vehicleIdOrIdentification);
                        break;
                    case 1:
                        _commandText = $"DeleteCostomerVehicle";
                        _command = new SqlCommand(_commandText, _connection);
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.Add("@VehicleId", SqlDbType.NVarChar);
                        _command.Parameters[0].Value = vehicleIdOrIdentification;
                        break;
                    case 2:
                        _commandText = $"DeleteVip";
                        _command = new SqlCommand(_commandText, _connection);
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.Add("@VehicleId", SqlDbType.NVarChar);
                        _command.Parameters[0].Value = vehicleIdOrIdentification;
                        break;
                    case 3:
                        _commandText = $"DeleteProgramm";
                        _command = new SqlCommand(_commandText, _connection);
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.Add("@id", SqlDbType.Int);
                        _command.Parameters[0].Value = Convert.ToInt32(vehicleIdOrIdentification);
                        break;
                    default:
                        return false;
                }
                _command.ExecuteNonQuery();
                _command.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool Update(object table, int status, string logId)
        {
            try
            {
                switch (status)
                {
                    case 0:
                        TblAgent agent = (TblAgent)table;
                        _commandText = $"UpdateAgent";
                        _command = new SqlCommand(_commandText, _connection);
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.Add("@Identification", SqlDbType.BigInt);
                        _command.Parameters.Add("@FirstName", SqlDbType.NVarChar);
                        _command.Parameters.Add("@LastName", SqlDbType.NVarChar);
                        _command.Parameters.Add("@Username", SqlDbType.NVarChar);
                        _command.Parameters.Add("@Password", SqlDbType.NVarChar);
                        _command.Parameters.Add("@ImageSrc", SqlDbType.NVarChar);
                        _command.Parameters.Add("@LogId", SqlDbType.BigInt);
                        _command.Parameters[0].Value = agent.Identification;
                        _command.Parameters[1].Value = agent.FirstName;
                        _command.Parameters[2].Value = agent.LastName;
                        _command.Parameters[3].Value = agent.Username;
                        _command.Parameters[4].Value = agent.Password;
                        _command.Parameters[5].Value = agent.ImageSrc;
                        _command.Parameters[6].Value = long.Parse(logId);

                        break;
                    case 1:
                        TblCostomerVehicle costomerVehicle = (TblCostomerVehicle)table; string k;
                        k = MethodRepo.C12To24(costomerVehicle.TimeArrived);
                        string k2;
                        k2 = costomerVehicle.TimeGone == DateTime.Parse("1/1/0001 12:00:00 AM") ? "" : MethodRepo.C12To24(costomerVehicle.TimeGone);
                        _commandText = $"UpdateCostomerVehicle";
                        _command = new SqlCommand(_commandText, _connection);
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.Add("@Name", SqlDbType.NVarChar);
                        _command.Parameters.Add("@TimeArrived", SqlDbType.DateTime);
                        _command.Parameters.Add("@TimeGone", SqlDbType.DateTime);
                        _command.Parameters.Add("@TimeStayed", SqlDbType.NVarChar);
                        _command.Parameters.Add("@Price", SqlDbType.BigInt);
                        _command.Parameters.Add("@Floor", SqlDbType.Int);
                        _command.Parameters.Add("@Column", SqlDbType.Int);
                        _command.Parameters.Add("@Row", SqlDbType.Int);
                        _command.Parameters.Add("@PositionId", SqlDbType.NVarChar);
                        _command.Parameters.Add("@VehicleId", SqlDbType.NVarChar);
                        _command.Parameters.Add("@LogId", SqlDbType.NVarChar);
                        _command.Parameters[0].Value = costomerVehicle.Name;
                        _command.Parameters[1].Value = k;
                        _command.Parameters[2].Value = k2;
                        _command.Parameters[3].Value = costomerVehicle.TimeStayed;
                        _command.Parameters[4].Value = costomerVehicle.Price;
                        _command.Parameters[5].Value = costomerVehicle.Floor;
                        _command.Parameters[6].Value = costomerVehicle.Column;
                        _command.Parameters[7].Value = costomerVehicle.Row;
                        _command.Parameters[8].Value = costomerVehicle.PositionId;
                        _command.Parameters[9].Value = costomerVehicle.VehicleId;
                        _command.Parameters[10].Value = logId;
                        break;
                    case 2:
                        TblVip vip = (TblVip)table;
                        _commandText = $"UpdateVip";
                        _command = new SqlCommand(_commandText, _connection);
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.Add("@FirstName", SqlDbType.NVarChar);
                        _command.Parameters.Add("@LastName", SqlDbType.NVarChar);
                        _command.Parameters.Add("@TimeHoldFrom", SqlDbType.DateTime);
                        _command.Parameters.Add("@TimeHoldTo", SqlDbType.DateTime);
                        _command.Parameters.Add("@Floor", SqlDbType.Int);
                        _command.Parameters.Add("@Column", SqlDbType.Int);
                        _command.Parameters.Add("@Row", SqlDbType.Int);
                        _command.Parameters.Add("@PositionId", SqlDbType.NVarChar);
                        _command.Parameters.Add("@VehicleId", SqlDbType.NVarChar);
                        _command.Parameters.Add("@ProgrammId", SqlDbType.Int);
                        _command.Parameters.Add("@LogId", SqlDbType.NVarChar);
                        _command.Parameters[0].Value = vip.FirstName;
                        _command.Parameters[1].Value = vip.LastName;
                        _command.Parameters[2].Value = MethodRepo.C12To24(vip.TimeHoldFrom);
                        _command.Parameters[3].Value = MethodRepo.C12To24(vip.TimeHoldTo);
                        _command.Parameters[4].Value = vip.Floor;
                        _command.Parameters[5].Value = vip.Column;
                        _command.Parameters[6].Value = vip.Row;
                        _command.Parameters[7].Value = vip.PositionId;
                        _command.Parameters[8].Value = vip.VehicleId;
                        _command.Parameters[9].Value = vip.ProgrammId;
                        _command.Parameters[10].Value = logId;
                        break;
                    case 3:
                        TblProgramm programm = (TblProgramm)table;
                        _commandText = $"UpdateProgramm";
                        _command = new SqlCommand(_commandText, _connection);
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.Add("@Name", SqlDbType.NVarChar);
                        _command.Parameters.Add("@TimeHold", SqlDbType.Int);
                        _command.Parameters.Add("@Price", SqlDbType.BigInt);
                        _command.Parameters.Add("@Discription", SqlDbType.NVarChar);
                        _command.Parameters.Add("@LogId", SqlDbType.Int);
                        _command.Parameters[0].Value = programm.Name;
                        _command.Parameters[1].Value = programm.TimeHold;
                        _command.Parameters[2].Value = programm.Price;
                        _command.Parameters[3].Value = programm.Discription;
                        _command.Parameters[4].Value = Convert.ToInt32(logId);
                        break;
                    default:
                        return false;
                }
                _command.ExecuteNonQuery();
                _command.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public TblCostomerVehicle FetchTblCostomerVehicle(string vehicleId)
        {
            try
            {
                _command = new SqlCommand("FetchTblCostomerVehicle", _connection);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.Add("@VehicleId", SqlDbType.NVarChar);
                _command.Parameters[0].Value = vehicleId;
                _reader = _command.ExecuteReader();
                _reader.Read();
                _command.Dispose();
                return new TblCostomerVehicle(Convert.ToInt32(_reader["id"]), _reader["Name"].ToString(), _reader["VehicleId"].ToString(), DateTime.Parse(_reader["TimeArrived"].ToString()), DateTime.Parse(_reader["TimeGone"].ToString()), _reader["TimeStayed"].ToString(), long.Parse(_reader["Price"].ToString()), Convert.ToInt32(_reader["Floor"]), Convert.ToInt32(_reader["Column"]), Convert.ToInt32(_reader["Row"]), _reader["PositionId"].ToString());
            }
            catch
            {
                return new TblCostomerVehicle(-1);
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool AddDeleteFloor(int status)
        {
            try
            {
                if (status == 0)//add
                {
                    int floorCount = FetchFloorCount();
                    _command = new SqlCommand($"create table TblFloor_{floorCount} (id int,[SpotStatus] int,VehicleId nvarchar(6))", _connection);
                    _command.ExecuteNonQuery();
                    _command.Dispose();
                    _command = new SqlCommand($"insert into TblFloor_{floorCount} (id,SpotStatus) values ('0','0')", _connection);
                    _command.ExecuteNonQuery();
                    _command.Dispose();
                    return true;
                }
                else if (status == 1)//delete
                {
                    int floorCount = FetchFloorCount() - 1;
                    _command = new SqlCommand($"drop table TblFloor_{floorCount}", _connection);
                    _command.ExecuteNonQuery();
                    _command.Dispose();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool AddDeleteSpot(int status, int floor)
        {
            try
            {
                if (status == 0)//add
                {
                    _command = new SqlCommand($"select top (1) id from TblFloor_{floor} order by id desc", _connection);
                    SqlDataReader reader = _command.ExecuteReader();
                    reader.Read();
                    int topId = Convert.ToInt32(reader[0]);
                    reader.Close();
                    reader.Dispose();
                    _command.Dispose();
                    _command = new SqlCommand($"insert into TblFloor_{floor} (id,SpotStatus) values({topId + 1},0)", _connection);
                    _command.ExecuteNonQuery();
                    _command.Dispose();
                    return true;
                }
                else if (status == 1)//delete
                {
                    _command = new SqlCommand($"select top (1) id from TblFloor_{floor} order by id desc", _connection);
                    SqlDataReader reader = _command.ExecuteReader();
                    reader.Read();
                    int topId = Convert.ToInt32(reader[0]);
                    reader.Close();
                    reader.Dispose();
                    _command.Dispose();
                    _command = new SqlCommand($"delete from TblFloor_{floor} where id = N'{topId}'", _connection);
                    _command.ExecuteNonQuery();
                    _command.Dispose();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool DeleteAllDataInTblAgent()
        {
            try
            {
                _command = new SqlCommand($"DeleteAllDataInTblAgent", _connection);
                _command.ExecuteNonQuery();
                _command.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool DeleteAllDataInTblCostomerVehicle()
        {
            try
            {
                int floorCount = FetchFloorCount();
                for (int i = 0; i < floorCount; i++)
                {
                    _command = new SqlCommand($"update TblFloor_{i} set SpotStatus = 0 , VehicleId = NULL", _connection);
                    _command.ExecuteNonQuery();
                    _command.Dispose();
                }
                _command = new SqlCommand($"DeleteAllDataInTblCostomerVehicle", _connection);
                _command.ExecuteNonQuery();
                _command.Dispose();
                _command = new SqlCommand($"DeleteAllTblVip", _connection);
                _command.ExecuteNonQuery();
                _command.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool ReseteAllFloorsAndSpots()
        {
            try
            {
                int floorCount = FetchFloorCount();
                for (int i = 1; i < floorCount; i++)
                {
                    _command = new SqlCommand($"drop table TblFloor_{i}", _connection);
                    _command.ExecuteNonQuery();
                    _command.Dispose();
                }
                SqlCommand cvCommand = new SqlCommand($"DeleteAllSpotsInFloor_0", _connection);
                cvCommand.ExecuteNonQuery();
                cvCommand.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public List<TblFloor_i> FetchSpots(int floor)
        {
            try
            {
                List<TblFloor_i> spots = new List<TblFloor_i>();
                _command = new SqlCommand($"select * from TblFloor_{floor}", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                    spots.Add(new TblFloor_i(Convert.ToInt32(reader["id"]), Convert.ToInt32(reader["SpotStatus"]), reader["VehicleId"].ToString()));
                reader.Close();
                reader.Dispose();
                _command.Dispose();
                return spots;
            }
            catch
            {
                return new List<TblFloor_i>(0);
            }
            finally
            {
                _connection.Close();
            }
        }

        public int FetchFloorCount()
        {
            try
            {
                _command = new SqlCommand("FetchFloorCount", _connection);
                _command.CommandType = CommandType.StoredProcedure;
                _reader = _command.ExecuteReader();
                _reader.Read();
                int last = Convert.ToInt32(_reader[0]);
                _reader.Close();
                _reader.Dispose();
                _command.Dispose();
                return Convert.ToInt32(last);
            }
            catch
            {
                return -1;
            }
        }

        public TblCostomerVehicle FetchCostomerVehicleByPosition(int position, int floor)
        {
            try
            {
                List<TblCostomerVehicle> costomerVehicles = new List<TblCostomerVehicle>();
                _command = new SqlCommand($"select * from TblCostomerVehicle where VehicleId in(select VehicleId from TblFloor_{floor} where id = N'{position}')", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                    costomerVehicles.Add(new TblCostomerVehicle(int.Parse(reader["id"].ToString()), reader["Name"].ToString(), reader["VehicleId"].ToString(), MethodRepo.C24To12(reader["TimeArrived"].ToString()), DateTime.Parse(reader["TimeGone"].ToString()), reader["TimeStayed"].ToString(), long.Parse(reader["Price"].ToString()), int.Parse(reader["Floor"].ToString()), int.Parse(reader["Column"].ToString()), int.Parse(reader["Row"].ToString()), reader["PositionId"].ToString()));
                int[] ids = new int[costomerVehicles.Count];
                for (int i = 0; i < ids.Length; i++)
                    ids[i] = costomerVehicles[i].Id;
                int max = ids.Max();
                foreach (TblCostomerVehicle costomerVehicle in costomerVehicles)
                    if (costomerVehicle.Id == max)
                        return costomerVehicle;
                return null;
            }
            catch
            {
                return new TblCostomerVehicle(-1);
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool EnterSpot(int id, int floor, string vehicleId)
        {
            try
            {
                _command = new SqlCommand($"update TblFloor_{floor} set SpotStatus = '1', VehicleId = N'{vehicleId}' where id = N'{id}'", _connection);
                _command.ExecuteNonQuery();
                _command.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool ExitSpot(int id, int floor)
        {
            try
            {
                _command = new SqlCommand($"update TblFloor_{floor} set SpotStatus = '0', VehicleId = NULL where id = N'{id}'", _connection);
                _command.ExecuteNonQuery();
                _command.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool EnterVip(int id, int floor, string vehicleId)
        {
            try
            {
                _command = new SqlCommand($"update TblFloor_{floor} set SpotStatus = '2', VehicleId = N'{vehicleId}' where id = N'{id}'", _connection);
                _command.ExecuteNonQuery();
                _command.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool Execute(string cmdTxt)
        {
            try
            {
                _command = new SqlCommand(cmdTxt, _connection);
                _command.ExecuteNonQuery();
                _command.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public TblVip FetchVipWithVehicleId(string name)
        {
            try
            {
                _command = new SqlCommand($"FetchVipWithVehicleId", _connection);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.Add("@vehicleId", SqlDbType.NVarChar);
                _command.Parameters[0].Value = name;
                DsTables tables = new DsTables();
                _adapter = new SqlDataAdapter(_command);
                _adapter.Fill(tables.Tables["TblVip"]);
                _adapter.Dispose();
                _command.Dispose();
                return new TblVip(Convert.ToInt32(tables.Tables["TblVip"].Rows[0]["id"]), tables.Tables["TblVip"].Rows[0]["FirstName"].ToString(), tables.Tables["TblVip"].Rows[0]["LastName"].ToString(), tables.Tables["TblVip"].Rows[0]["VehicleId"].ToString(), DateTime.Parse(tables.Tables["TblVip"].Rows[0]["TimeHoldFrom"].ToString()), DateTime.Parse(tables.Tables["TblVip"].Rows[0]["TimeHoldTo"].ToString()), Convert.ToInt32(tables.Tables["TblVip"].Rows[0]["Floor"]), Convert.ToInt32(tables.Tables["TblVip"].Rows[0]["Column"]), Convert.ToInt32(tables.Tables["TblVip"].Rows[0]["Row"]), tables.Tables["TblVip"].Rows[0]["PositionId"].ToString(), Convert.ToInt32(tables.Tables["TblVip"].Rows[0]["ProgrammId"]));
            }
            catch
            {
                return new TblVip(-1);
            }
            finally
            {
                _connection.Close();
            }
        }

        public List<TblCostomerVehicleSearchView> FetchCostomerVehicleSearch(string vehicleIdOrName)
        {
            try
            {
                List<TblCostomerVehicle> costomerVehicles = new List<TblCostomerVehicle>();
                int floorCount = FetchFloorCount();
                for (int i = 0; i < floorCount; i++)
                {
                    _command = new SqlCommand($"select SpotStatus , VehicleId from TblFloor_{i} where VehicleId = N'{vehicleIdOrName}'", _connection);
                    _reader = _command.ExecuteReader();
                    _command.Dispose();
                    SqlConnection connection2 = new SqlConnection(Connectionstring);
                    connection2.Open();
                    while (_reader.Read())
                        if (_reader[0].ToString() == "1")
                        {
                            SqlCommand command2 = new SqlCommand($"select * from TblCostomerVehicle where VehicleId = N'{_reader[1]}' order by id desc", connection2);
                            SqlDataReader reader2 = command2.ExecuteReader();
                            reader2.Read();
                            costomerVehicles.Add(new TblCostomerVehicle(int.Parse(reader2["id"].ToString()), reader2["Name"].ToString(), reader2["VehicleId"].ToString(), DateTime.Parse(reader2["TimeArrived"].ToString()), DateTime.Parse(reader2["TimeGone"].ToString()), reader2["TimeStayed"].ToString(), long.Parse(reader2["Price"].ToString()), int.Parse(reader2["Floor"].ToString()), int.Parse(reader2["Column"].ToString()), int.Parse(reader2["Row"].ToString()), reader2["PositionId"].ToString()));
                            reader2.Close();
                            reader2.Dispose();
                        }
                    int[] costomersIds = new int[costomerVehicles.Count];
                    for (int j = 0; j < costomerVehicles.Count; j++)
                        costomersIds[j] = costomerVehicles[j].Id;
                    Array.Sort(costomersIds);
                    foreach (TblCostomerVehicle costomerVehicle in costomerVehicles)
                        if (costomerVehicle.Id == costomersIds[costomersIds.Length - 1])
                        {
                            List<TblCostomerVehicleSearchView> aa = new List<TblCostomerVehicleSearchView>();
                            aa.Add(new TblCostomerVehicleSearchView(costomerVehicle.Name, costomerVehicle.VehicleId, costomerVehicle.Floor, costomerVehicle.PositionId));
                            return aa;
                        }
                    _reader.Close();
                    _reader.Dispose();
                    connection2.Close();
                    connection2.Dispose();
                }
                return null;
            }
            catch
            {
                return new List<TblCostomerVehicleSearchView>();
            }
            finally
            {
                _connection.Close();
            }
        }

        public List<TblVip> FetchAllVips()
        {
            try
            {
                List<TblVip> vips = new List<TblVip>();
                _command = new SqlCommand($"FetchAllVips", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                {
                    vips.Add(new TblVip(int.Parse(reader["id"].ToString()), reader["FirstName"].ToString(), reader["LastName"].ToString(), reader["VehicleId"].ToString(), DateTime.Parse(reader["TimeHoldFrom"].ToString()), DateTime.Parse(reader["TimeHoldTo"].ToString()), int.Parse(reader["Floor"].ToString()), int.Parse(reader["Column"].ToString()), int.Parse(reader["Row"].ToString()), reader["PositionId"].ToString(), Convert.ToInt32(reader["ProgrammId"])));
                }
                reader.Close();
                reader.Dispose();
                _command.Dispose();
                return vips;
            }
            catch
            {
                return new List<TblVip>();
            }
            finally
            {
                _connection.Close();
            }
        }

        public TblProgramm FetchProgrammWithName(string name)
        {
            try
            {
                _command = new SqlCommand($"FetchProgrammWithName", _connection);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.Add("@programmName", SqlDbType.NVarChar);
                _command.Parameters[0].Value = name;
                DsTables tables = new DsTables();
                _adapter = new SqlDataAdapter(_command);
                _adapter.Fill(tables.Tables["TblProgramm"]);
                _adapter.Dispose();
                _command.Dispose();
                return new TblProgramm(Convert.ToInt32(tables.Tables["TblProgramm"].Rows[0]["id"]), tables.Tables["TblProgramm"].Rows[0]["Name"].ToString(), Convert.ToInt32(tables.Tables["TblProgramm"].Rows[0]["TimeHold"]), long.Parse(tables.Tables["TblProgramm"].Rows[0]["Price"].ToString()), tables.Tables["TblProgramm"].Rows[0]["Discription"].ToString());
            }
            catch
            {
                return new TblProgramm(-1);
            }
            finally
            {
                _connection.Close();
            }
        }

        public List<TblProgramm> FetchAllProgramms()
        {
            try
            {
                List<TblProgramm> programms = new List<TblProgramm>();
                _command = new SqlCommand($"FetchAllProgramms", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                {
                    programms.Add(new TblProgramm(int.Parse(reader["id"].ToString()), reader["Name"].ToString(), Convert.ToInt32(reader["TimeHold"]), long.Parse(reader["Price"].ToString()), reader["Discription"].ToString()));
                }
                reader.Close();
                reader.Dispose();
                _command.Dispose();
                return programms;
            }
            catch
            {
                return new List<TblProgramm>();
            }
            finally
            {
                _connection.Close();
            }
        }

        public TblProgramm FetchProgrammWithId(int id)
        {
            try
            {
                _command = new SqlCommand($"FetchProgrammWithId", _connection);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.Add("@id", SqlDbType.NVarChar);
                _command.Parameters[0].Value = id;
                DsTables tables = new DsTables();
                _adapter = new SqlDataAdapter(_command);
                _adapter.Fill(tables.Tables["TblProgramm"]);
                _adapter.Dispose();
                _command.Dispose();
                return new TblProgramm(Convert.ToInt32(tables.Tables["TblProgramm"].Rows[0]["id"]), tables.Tables["TblProgramm"].Rows[0]["Name"].ToString(), Convert.ToInt32(tables.Tables["TblProgramm"].Rows[0]["TimeHold"]), long.Parse(tables.Tables["TblProgramm"].Rows[0]["Price"].ToString()), tables.Tables["TblProgramm"].Rows[0]["Discription"].ToString());
            }
            catch
            {
                return new TblProgramm(-1);
            }
            finally
            {
                _connection.Close();
            }
        }

        public List<TblCostomerVehicle> FetchAllCostomerVehicles()
        {
            try
            {
                List<TblCostomerVehicle> costomerVehicles = new List<TblCostomerVehicle>();
                _command = new SqlCommand($"FetchAllCostomerVehicles", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                {
                    costomerVehicles.Add(new TblCostomerVehicle(int.Parse(reader["id"].ToString()), reader["Name"].ToString(), reader["VehicleId"].ToString(), DateTime.Parse(reader["TimeArrived"].ToString()), DateTime.Parse(reader["TimeGone"].ToString()), reader["TimeStayed"].ToString(), long.Parse(reader["Price"].ToString()), int.Parse(reader["Floor"].ToString()), int.Parse(reader["Column"].ToString()), int.Parse(reader["Row"].ToString()), reader["PositionId"].ToString()));
                }
                reader.Close();
                reader.Dispose();
                _command.Dispose();
                return costomerVehicles;
            }
            catch
            {
                return new List<TblCostomerVehicle>();
            }
            finally
            {
                _connection.Close();
            }
        }

        public List<TblCostomerVehicle> FetchTimedCostomerVehicles(DateTime fromTime, DateTime toTime)
        {
            try
            {
                List<TblCostomerVehicle> costomerVehicles = new List<TblCostomerVehicle>();
                _command = new SqlCommand($"select * from TblCostomerVehicle where TimeGone > '{MethodRepo.C12To24(fromTime)}' and TimeGone < '{MethodRepo.C12To24(toTime)}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                {
                    costomerVehicles.Add(new TblCostomerVehicle(int.Parse(reader["id"].ToString()), reader["Name"].ToString(), reader["VehicleId"].ToString(), DateTime.Parse(reader["TimeArrived"].ToString()), DateTime.Parse(reader["TimeGone"].ToString()), reader["TimeStayed"].ToString(), long.Parse(reader["Price"].ToString()), int.Parse(reader["Floor"].ToString()), int.Parse(reader["Column"].ToString()), int.Parse(reader["Row"].ToString()), reader["PositionId"].ToString()));
                }
                reader.Close();
                reader.Dispose();
                _command.Dispose();
                return costomerVehicles;
            }
            catch
            {
                return new List<TblCostomerVehicle>();
            }
            finally
            {
                _connection.Close();
            }
        }

        public List<TblVip> FetchTimedVips(DateTime fromTime, DateTime toTime)
        {
            try
            {
                List<TblVip> vips = new List<TblVip>();
                _command = new SqlCommand($"select * from TblVip where TimeHoldFrom > '{fromTime}'  and TimeHoldTo < '{toTime}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                {
                    vips.Add(new TblVip(int.Parse(reader["id"].ToString()), reader["FirstName"].ToString(), reader["LastName"].ToString(), reader["VehicleId"].ToString(), DateTime.Parse(reader["TimeHoldFrom"].ToString()), DateTime.Parse(reader["TimeHoldTo"].ToString()), int.Parse(reader["Floor"].ToString()), int.Parse(reader["Column"].ToString()), int.Parse(reader["Row"].ToString()), reader["PositionId"].ToString(), Convert.ToInt32(reader["ProgrammId"])));
                }
                reader.Close();
                reader.Dispose();
                _command.Dispose();
                return vips;
            }
            catch
            {
                return new List<TblVip>();
            }
            finally
            {
                _connection.Close();
            }
        }

        public List<TblVip> FetchCurrentVips()
        {
            try
            {
                int floorCount = FetchFloorCount();
                List<TblVip> vips = new List<TblVip>();
                for (int i = 0; i < floorCount; i++)
                {
                    _command = new SqlCommand($"select * from TblVip where VehicleId in (select VehicleId from TblFloor_{i} where SpotStatus = 2)", _connection);
                    SqlDataReader reader = _command.ExecuteReader();
                    while (reader.Read())
                    {
                        vips.Add(new TblVip(int.Parse(reader["id"].ToString()), reader["FirstName"].ToString(), reader["LastName"].ToString(), reader["VehicleId"].ToString(), DateTime.Parse(reader["TimeHoldFrom"].ToString()), DateTime.Parse(reader["TimeHoldTo"].ToString()), int.Parse(reader["Floor"].ToString()), int.Parse(reader["Column"].ToString()), int.Parse(reader["Row"].ToString()), reader["PositionId"].ToString(), Convert.ToInt32(reader["ProgrammId"])));
                    }
                    reader.Close();
                    reader.Dispose();
                    _command.Dispose();
                }
                return vips;
            }
            catch
            {
                return new List<TblVip>();
            }
            finally
            {
                _connection.Close();
            }
        }

        public string FetchThem()
        {
            try
            {
                _command = new SqlCommand($"FetchThem", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                string last = reader[0].ToString();
                reader.Close();
                reader.Dispose();
                _command.Dispose();
                return last;
            }
            catch
            {
                return "";
            }
            finally
            {
                _connection.Close();
            }
        }

        public string FetchBgImg()
        {
            try
            {
                _command = new SqlCommand($"FetchBgImg", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                string last = reader[0].ToString();
                reader.Close();
                reader.Dispose();
                _command.Dispose();
                return last;
            }
            catch
            {
                return "";
            }
            finally
            {
                _connection.Close();
            }
        }

        public int FetchLevel()
        {
            try
            {
                _command = new SqlCommand($"FetchLevel", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                int last = Convert.ToInt32(reader[0].ToString());
                reader.Close();
                reader.Dispose();
                _command.Dispose();
                return last;
            }
            catch
            {
                return 0;
            }
            finally
            {
                _connection.Close();
            }
        }

        public long FetchXpHave()
        {
            try
            {
                _command = new SqlCommand($"FetchXP", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                int last = Convert.ToInt32(reader[0].ToString());
                reader.Close();
                reader.Dispose();
                _command.Dispose();
                return last;
            }
            catch
            {
                return 0;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool InsertBaseSource()
        {
            try
            {
                _command = new SqlCommand($"InsertBaseData", _connection);
                _command.ExecuteNonQuery();
                _command.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool UpdateThem(string themSrc)
        {
            try
            {
                _command = new SqlCommand($"UpdateThemSrc", _connection);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.Add("@ThemSrc", SqlDbType.NVarChar);
                _command.Parameters[0].Value = themSrc;
                _command.ExecuteNonQuery();
                _command.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool UpdateBgImg(string bgImgSrc)
        {
            try
            {
                _command = new SqlCommand($"UpdateBgImgSrc", _connection);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.Add("@BgImgSrc", SqlDbType.NVarChar);
                _command.Parameters[0].Value = bgImgSrc;
                _command.ExecuteNonQuery();
                _command.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool UpdateLevel(int leve)
        {
            try
            {
                _command = new SqlCommand($"UpdateLevel", _connection);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.Add("@Leve", SqlDbType.Int);
                _command.Parameters[0].Value = leve;
                _command.ExecuteNonQuery();
                _command.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool UpdateXpHave(long xpAmount)
        {
            try
            {
                _command = new SqlCommand($"UpdateXPHave", _connection);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.Add("@XPAmount", SqlDbType.BigInt);
                _command.Parameters[0].Value = xpAmount;
                _command.ExecuteNonQuery();
                _command.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool ChangePrintStatus(bool isEnable)
        {
            try
            {
                _command = new SqlCommand($"ChangePrintStatus", _connection);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.Add("@IsEnabled", SqlDbType.Bit);
                _command.Parameters[0].Value = isEnable;
                _command.ExecuteNonQuery();
                _command.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool FetchPrintStatus()
        {
            try
            {
                _command = new SqlCommand($"SelectprintStatus", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                bool last = Convert.ToBoolean(reader[0].ToString());
                reader.Close();
                reader.Dispose();
                _command.Dispose();
                return last;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool UpdateColumnRatio(int ratio)
        {
            try
            {
                _command = new SqlCommand($"UpdateColumnRatio", _connection);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.Add("@Ratio", SqlDbType.Int);
                _command.Parameters[0].Value = ratio;
                _command.ExecuteNonQuery();
                _command.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public int FetchColumnRatio()
        {
            try
            {
                _command = new SqlCommand($"FetchColumnRatio", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                int last = Convert.ToInt32(reader[0].ToString());
                reader.Close();
                reader.Dispose();
                _command.Dispose();
                return last;
            }
            catch
            {
                return 100;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool AddPricingPolicy(TblPricingPolicy pricingPolicy)
        {
            try
            {
                _command = new SqlCommand($"InsertPricingPolicy", _connection);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.Add("@PlanName", SqlDbType.NVarChar);
                _command.Parameters.Add("@EntrancPrice", SqlDbType.BigInt);
                _command.Parameters.Add("@Hour", SqlDbType.BigInt);
                _command.Parameters.Add("@Description", SqlDbType.NVarChar);
                _command.Parameters[0].Value = pricingPolicy.PlanName;
                _command.Parameters[1].Value = pricingPolicy.EntrancPrice;
                _command.Parameters[2].Value = pricingPolicy.Hour;
                if (pricingPolicy.Description == "")
                    _command.Parameters[3].Value = " ";
                else
                    _command.Parameters[3].Value = pricingPolicy.Description;
                _command.ExecuteNonQuery();
                _command.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool UpdatePricingPolicy(TblPricingPolicy pricingPolicy, int logId)
        {
            try
            {
                _command = new SqlCommand($"UpdatePricingPolicy", _connection);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.Add("@PlanName", SqlDbType.NVarChar);
                _command.Parameters.Add("@EntrancPrice", SqlDbType.BigInt);
                _command.Parameters.Add("@Hour", SqlDbType.BigInt);
                _command.Parameters.Add("@Description", SqlDbType.NVarChar);
                _command.Parameters.Add("@LogId", SqlDbType.Int);
                _command.Parameters[0].Value = pricingPolicy.PlanName;
                _command.Parameters[1].Value = pricingPolicy.EntrancPrice;
                _command.Parameters[2].Value = pricingPolicy.Hour;
                if (pricingPolicy.Description == "")
                    _command.Parameters[3].Value = " ";
                else
                    _command.Parameters[3].Value = pricingPolicy.Description;
                _command.Parameters[4].Value = logId;
                _command.ExecuteNonQuery();
                _command.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool DeletePricingPolicy(int id)
        {
            try
            {
                _command = new SqlCommand($"DeletePricingPolicy", _connection);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.Add("@id", SqlDbType.Int);
                _command.Parameters[0].Value = id;
                _command.ExecuteNonQuery();
                _command.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public TblPricingPolicy SelectPricingPolicyById(int id)
        {
            try
            {
                _command = new SqlCommand($"SelectPricingPolicyById", _connection);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.Add("@id", SqlDbType.Int);
                _command.Parameters[0].Value = id;
                _reader = _command.ExecuteReader();
                _reader.Read();
                _command.Dispose();
                TblPricingPolicy pricingPolicy = new TblPricingPolicy(Convert.ToInt32(_reader["id"]), _reader["PlanName"].ToString(), long.Parse(_reader["EntrancPrice"].ToString()), long.Parse(_reader["Hour"].ToString()), _reader["Description"].ToString());
                _reader.Close();
                _reader.Dispose();
                return pricingPolicy;
            }
            catch
            {
                return new TblPricingPolicy(-1);
            }
            finally
            {
                _connection.Close();
            }
        }

        public List<TblPricingPolicy> SelectAllPricingPolicies()
        {
            try
            {
                List<TblPricingPolicy> listOfPolicies = new List<TblPricingPolicy>();
                _command = new SqlCommand($"FetchAllPricingPolicies", _connection);
                _command.CommandType = CommandType.StoredProcedure;
                _reader = _command.ExecuteReader();
                while (_reader.Read())
                {
                    listOfPolicies.Add(new TblPricingPolicy(Convert.ToInt32(_reader["id"]), _reader["PlanName"].ToString(), long.Parse(_reader["EntrancPrice"].ToString()), long.Parse(_reader["Hour"].ToString()), _reader["Description"].ToString()));
                }
                _command.Dispose();
                _reader.Close();
                _reader.Dispose();
                return listOfPolicies;
            }
            catch
            {
                return new List<TblPricingPolicy>();
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool IsFirstTime()
        {
            try
            {
                _command = new SqlCommand($"IsFirstTime", _connection);
                _command.CommandType = CommandType.StoredProcedure;
                _reader = _command.ExecuteReader();
                _reader.Read();
                _command.Dispose();
                bool status = Convert.ToBoolean(_reader[0]);
                _reader.Close();
                _reader.Dispose();
                return status;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool ChangeFirstLogStatus(bool status)
        {
            try
            {
                _command = new SqlCommand($"ChangeFirstLogStatus", _connection);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.Add("@Status", SqlDbType.Bit);
                _command.Parameters[0].Value = status;
                _command.ExecuteNonQuery();
                _command.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool VerifyHash(string hash)
        {
            try
            {
                _command = new SqlCommand($"FetchHash", _connection);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.Add("@Hash", SqlDbType.NVarChar);
                _command.Parameters[0].Value = hash;
                _command.ExecuteNonQuery();
                _command.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public DateTime SelectActivatedTime()
        {
            try
            {
                SqlCommand command = new SqlCommand($"SELECT Hash FROM dbo.TblSource", _connection);
                SqlDataReader reader1 = command.ExecuteReader();
                reader1.Read();
                string hash = reader1[0].ToString();
                reader1.Close();
                _connection.Close();
                SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ParkingManagementOnline"].ConnectionString);
                connection.Open();
                _command = new SqlCommand($"SelectDateExpire", connection);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.Add("@Hash", SqlDbType.NVarChar);
                _command.Parameters[0].Value = hash;
                _reader = _command.ExecuteReader();
                _reader.Read();
                _command.Dispose();
                DateTime date = DateTime.Parse(_reader[0].ToString());
                _reader.Close();
                _reader.Dispose();
                return date;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool UpdateTimeCome(string time)
        {
            try
            {
                SqlCommand command = new SqlCommand("UpdateTimeCome", _connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@time", SqlDbType.NVarChar);
                command.Parameters[0].Value = time;
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public string FetchTimeCome()
        {
            try
            {
                SqlCommand command = new SqlCommand("FetchTimeCome", _connection);
                command.CommandType = CommandType.StoredProcedure;
                _reader = command.ExecuteReader();
                _reader.Read();

                return _reader[0].ToString();
            }
            catch
            {
                return null;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool UpdateIsUpdateReady(bool status)
        {
            try
            {
                SqlCommand command = new SqlCommand("EditIsUpdateReady", _connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Flag", SqlDbType.Bit);
                command.Parameters[0].Value = status;
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool UpdateUpdateFileLocation(string location)
        {
            try
            {
                SqlCommand command = new SqlCommand("EditUpdateFileLocation", _connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Location", SqlDbType.NVarChar);
                command.Parameters[0].Value = location;
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool UpdateCurrentFileLocation(string location)
        {
            try
            {
                SqlCommand command = new SqlCommand("EditCurrentFileLocation", _connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Location", SqlDbType.NVarChar);
                command.Parameters[0].Value = location;
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool BackupDb(string filePath)
        {
            try
            {
                SqlCommand command = new SqlCommand("BackupDb", _connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@filePath", SqlDbType.NVarChar);
                command.Parameters[0].Value = filePath;
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool RestoreDb(string filePath)
        {
            try
            {
                SqlCommand command = new SqlCommand("RestoreDb", _connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@filePath", SqlDbType.NVarChar);
                command.Parameters[0].Value = filePath;
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }
    }
}

//public enum status : byte
//{
//    TblAgents,
//    TblCostomerVehicle,
//    idle
//}

//public class c
//{
//    public void foo(status s)
//    {

//        
//(s == status.TblAgents)
//        {

//        }
//        else if (s == status.TblCostomerVehicle)
//        {

//        }
//        else // if (s == status.idle)
//        {

//        }

//    }
//}
//}