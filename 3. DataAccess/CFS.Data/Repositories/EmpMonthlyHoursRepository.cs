using CFS.Data.Context;
using CFS.Data.Domains;
using CFS.Data.IRepositories;
using CFS.Model.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CFS.Model.Models;
using CFS.Data.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CFS.Data.Repositories
{
    public class EmpMonthlyHoursRepository : Repository, IEmpMonthlyHoursRepository
    {
        #region Constructor

        public EmpMonthlyHoursRepository(CFSContext applicationDbContext) : base(applicationDbContext)
        {
        }

        #endregion Constructor

        #region Methods
        /// <summary>
        /// Get Sow By Id
        /// </summary>
        /// <param name="SowId"></param>
        /// <returns></returns>
        public async Task<List<EmpMonthlyHoursList>> GetEmployeeMonthlyHours(int EmployeeId)
        {
            var commandText = string.Format(StoreProcedure.GetEmployeeMonthlyHours, EmployeeId);
            return await Context.GetEmployeeMonthlyHours.FromSqlRaw<EmpMonthlyHoursList>(commandText).ToListAsync();
        }

        // <summary>
        /// insert project response
        /// </summary>
        /// <param name="objprojectModel"></param>
        /// <returns></returns>

        public async Task<ReturnResponseModel> InsertEmpMonthlyHours(InsertEmpMonthlyHoursResponseModel objEmpMonthlyHoursModel)
        {
            try
            {
                var commandText = string.Format(StoreProcedure.InsertEmpMonthlyHours,
                    objEmpMonthlyHoursModel.EmployeeId,
                    objEmpMonthlyHoursModel.Month,
                    objEmpMonthlyHoursModel.Year,
                    objEmpMonthlyHoursModel.Hours,
                    objEmpMonthlyHoursModel.TotalWorkingDays,
                    objEmpMonthlyHoursModel.Leaves
                  );
                await Context.Database.ExecuteSqlRawAsync(commandText);
                return new ReturnResponseModel { Status = true };
            }
            catch (Exception)
            {
                return new ReturnResponseModel { Status = false };
            }
        }

        public async Task<ReturnResponseModel> InsertHolidayList(List<InsertHolidayListModel> objHolidayListModel)
        {
            try
            {
                int year = objHolidayListModel.First().year;
                string json = JsonConvert.SerializeObject(objHolidayListModel, new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd" });
                Console.WriteLine(json);

                var status = await Context.Database.ExecuteSqlInterpolatedAsync($"EXEC sp_insHolidays @json = {json}, @Year = {year}");

                if (status >= 0)
                {
                    return new ReturnResponseModel { Status = true };
                }
                else
                {
                    return new ReturnResponseModel { Status = false };
                }
                //this Code Without SP and With Database Table
                //// Remove existing holidays for the given year
                //var existingHolidays = Context.HolidayList.Where(h => h.Year == year);
                //Context.HolidayList.RemoveRange(existingHolidays);

                //// Add holidays for the given year
                //var holidaysToAdd = objHolidayListModel.Select(holiday => new HolidayList
                //{
                //    HolidayDate = holiday.HolidayDate,
                //    Description = holiday.Description,
                //    Year = holiday.Year
                //});

                //Context.HolidayList.AddRange(holidaysToAdd);
                //await Context.SaveChangesAsync();

            }
            catch (Exception)
            {
                return new ReturnResponseModel { Status = false };
            }
        }

        public async Task<ReturnResponseModel> InsertTimesheetExport(List<InsertTimesheetExportModel> insertTimesheetExportObj, int Year, string Month)
        {
            try
            {
                string json = JsonConvert.SerializeObject(insertTimesheetExportObj, new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd" });
                Console.WriteLine(json);

                var status = await Context.Database.ExecuteSqlInterpolatedAsync($"EXEC sp_insExcelData @json = {json}, @Year = {Year}, @Month = {Month}");

                if (status >= 0)
                {
                    return new ReturnResponseModel { Status = true };
                }
                else
                {
                    return new ReturnResponseModel { Status = false };
                }
            }
            catch (Exception)
            {
                return new ReturnResponseModel { Status = false };
            }
        }

        public async Task<List<GetYearsList>> GetYears()
        {
            var commandText = string.Format(StoreProcedure.GetYears);
            return await Context.GetYears.FromSqlRaw<GetYearsList>(commandText).ToListAsync();
        }
        public async Task<List<GetMonthsList>> GetMonths()
        {
            var commandText = string.Format(StoreProcedure.GetMonths);
            return await Context.GetMonths.FromSqlRaw<GetMonthsList>(commandText).ToListAsync();
        }

        #endregion Methods
    }
    }