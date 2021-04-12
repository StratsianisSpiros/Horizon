using Entities.Models;
using Entities.UtilityModels;
using System;
using System.Collections.Generic;

namespace Repositories.Data
{
    public class Employee1EventData
    {
        private List<EmployeeEvent> EmployeeEvents = new List<EmployeeEvent>
       {
            //// COMPANY 1
            //// Employee 1
            /// ============================================== 11/2020 ========================================================
            #region
            new EmployeeEvent { EventID = 1, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 11, 5, 07, 15, 00), End = new DateTime(2020, 11, 5, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 2, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 11, 6, 07, 00, 00), End = new DateTime(2020, 11, 6, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 3, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 11, 7, 07, 15, 00), End = new DateTime(2020, 11, 7, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 4, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 11, 8, 07, 15, 00), End = new DateTime(2020, 11, 8, 15, 15, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 5, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 11, 9, 12, 00, 00), End = new DateTime(2020, 11, 9, 18, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 6, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 11, 10, 08, 20, 00), End = new DateTime(2020, 11, 10, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 7, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 11, 12, 08, 00, 00), End = new DateTime(2020, 11, 12, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 8, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 11, 13, 12, 15, 00), End = new DateTime(2020, 11, 13, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 9, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 11, 14, 12, 00, 00), End = new DateTime(2020, 11, 14, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 10, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 11, 15, 12, 00, 00), End = new DateTime(2020, 11, 15, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 3, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 11, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 11, 16, 12, 00, 00), End = new DateTime(2020, 11, 16, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 12, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 11, 17, 12, 00, 00), End = new DateTime(2020, 11, 17, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 13, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 11, 19, 07, 15, 00), End = new DateTime(2020, 11, 19, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 14, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 11, 20, 07, 00, 00), End = new DateTime(2020, 11, 20, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 15, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 11, 21, 12, 15, 00), End = new DateTime(2020, 11, 21, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 16, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 11, 22, 12, 15, 00), End = new DateTime(2020, 11, 22, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 17, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 11, 23, 12, 15, 00), End = new DateTime(2020, 11, 23, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 18, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 11, 25, 07, 15, 00), End = new DateTime(2020, 11, 25, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 19, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 11, 26, 07, 15, 00), End = new DateTime(2020, 11, 26, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 20, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 11, 27, 07, 15, 00), End = new DateTime(2020, 11, 27, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 21, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 11, 28, 07, 15, 00), End = new DateTime(2020, 11, 28, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 22, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 11, 29, 12, 00, 00), End = new DateTime(2020, 11, 29, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},
            #endregion

            /// ============================================== 12/2020 ========================================================
            #region
            new EmployeeEvent { EventID = 23, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 12, 2, 07, 15, 00), End = new DateTime(2020, 12, 2, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 24, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 12, 3, 07, 15, 00), End = new DateTime(2020, 12, 3, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 25, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 12, 4, 07, 15, 00), End = new DateTime(2020, 12, 4, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 26, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 12, 5, 07, 15, 00), End = new DateTime(2020, 12, 5, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 27, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 12, 6, 07, 15, 00), End = new DateTime(2020, 12, 6, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 28, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 12, 9, 07, 15, 00), End = new DateTime(2020, 12, 9, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 29, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 12, 10, 07, 00, 00), End = new DateTime(2020, 12, 10, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 30, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 12, 11, 12, 15, 00), End = new DateTime(2020, 12, 11, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 31, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 12, 12, 12, 00, 00), End = new DateTime(2020, 12, 12, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 32, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 12, 13, 12, 00, 00), End = new DateTime(2020, 12, 13, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 33, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 12, 16, 08, 20, 00), End = new DateTime(2020, 12, 16, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 34, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 12, 17, 08, 00, 00), End = new DateTime(2020, 12, 17, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 35, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 12, 18, 08, 00, 00), End = new DateTime(2020, 12, 18, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 36, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 12, 19, 08, 20, 00), End = new DateTime(2020, 12, 19, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 37, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 12, 20, 08, 00, 00), End = new DateTime(2020, 12, 20, 13, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 38, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 12, 21, 13, 00, 00), End = new DateTime(2020, 12, 21, 21, 30, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 39, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 12, 24, 13, 00, 00), End = new DateTime(2020, 12, 24, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 40, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 12, 25, 13, 00, 00), End = new DateTime(2020, 12, 25, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 41, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 12, 26, 12, 15, 00), End = new DateTime(2020, 12, 26, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 42, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 12, 27, 12, 00, 00), End = new DateTime(2020, 12, 27, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 43, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 12, 28, 12, 00, 00), End = new DateTime(2020, 12, 28, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 3, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 44, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2020, 12, 29, 12, 00, 00), End = new DateTime(2020, 12, 29, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},
            #endregion

            /// ============================================== 01/2021 ========================================================
            #region
            new EmployeeEvent { EventID = 45, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 1, 2, 07, 15, 00), End = new DateTime(2021, 1, 2, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 46, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 1, 3, 07, 15, 00), End = new DateTime(2021, 1, 3, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 47, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 1, 4, 07, 15, 00), End = new DateTime(2021, 1, 4, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 48, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 1, 5, 07, 15, 00), End = new DateTime(2021, 1, 5, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 49, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 1, 6, 07, 15, 00), End = new DateTime(2021, 1, 6, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 50, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 1, 9, 07, 15, 00), End = new DateTime(2021, 1, 9, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 51, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 1, 10, 12, 00, 00), End = new DateTime(2021, 1, 10, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 52, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 1, 11, 12, 00, 00), End = new DateTime(2021, 1, 11, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 3, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 53, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 1, 12, 12, 00, 00), End = new DateTime(2021, 1, 12, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 54, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 1, 13, 12, 00, 00), End = new DateTime(2021, 1, 13, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 55, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 1, 14, 12, 00, 00), End = new DateTime(2021, 1, 14, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 56, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 1, 16, 08, 00, 00), End = new DateTime(2021, 1, 16, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 57, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 1, 17, 08, 00, 00), End = new DateTime(2021, 1, 17, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 58, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 1, 18, 08, 20, 00), End = new DateTime(2021, 1, 18, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 59, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 1, 19, 08, 20, 00), End = new DateTime(2021, 1, 19, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 60, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 1, 21, 08, 00, 00), End = new DateTime(2021, 1, 21, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 61, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 1, 22, 13, 00, 00), End = new DateTime(2021, 1, 22, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 62, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 1, 24, 13, 00, 00), End = new DateTime(2021, 1, 24, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 63, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 1, 25, 13, 00, 00), End = new DateTime(2021, 1, 25, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 64, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 1, 26, 07, 15, 00), End = new DateTime(2021, 1, 26, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 65, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 1, 27, 07, 15, 00), End = new DateTime(2021, 1, 27, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 66, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 1, 28, 07, 15, 00), End = new DateTime(2021, 1, 28, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},
            #endregion

            /// ============================================== 02/2021 ========================================================
            #region
            new EmployeeEvent { EventID = 67, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 2, 2, 07, 15, 00), End = new DateTime(2021, 2, 2, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 68, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 2, 3, 07, 15, 00), End = new DateTime(2021, 2, 3, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 69, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 2, 4, 07, 15, 00), End = new DateTime(2021, 2, 4, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 70, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 2, 5, 07, 15, 00), End = new DateTime(2021, 2, 5, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 71, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 2, 6, 07, 15, 00), End = new DateTime(2021, 2, 6, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 72, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 2, 10, 07, 15, 00), End = new DateTime(2021, 2, 10, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 73, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 2, 11, 07, 00, 00), End = new DateTime(2021, 2, 11, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 74, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 2, 12, 07, 15, 00), End = new DateTime(2021, 2, 12, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 75, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 2, 13, 07, 15, 00), End = new DateTime(2021, 2, 13, 15, 15, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 76, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 2, 14, 07, 15, 00), End = new DateTime(2021, 2, 14, 15, 15, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 77, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 2, 15, 07, 15, 00), End = new DateTime(2021, 2, 15, 15, 15, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 78, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 2, 17, 12, 00, 00), End = new DateTime(2021, 2, 17, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 79, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 2, 18, 12, 00, 00), End = new DateTime(2021, 2, 18, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 3, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 80, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 2, 19, 12, 00, 00), End = new DateTime(2021, 2, 19, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 81, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 2, 20, 12, 00, 00), End = new DateTime(2021, 2, 20, 18, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 82, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 2, 21, 12, 00, 00), End = new DateTime(2021, 2, 21, 18, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 83, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 2, 23, 08, 00, 00), End = new DateTime(2021, 2, 23, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 84, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 2, 24, 08, 20, 00), End = new DateTime(2021, 2, 24, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 85, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 2, 25, 08, 00, 00), End = new DateTime(2021, 2, 25, 13, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 86, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 2, 26, 13, 00, 00), End = new DateTime(2021, 2, 26, 21, 30, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 87, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 2, 27, 13, 00, 00), End = new DateTime(2021, 2, 27, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 88, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 2, 28, 13, 00, 00), End = new DateTime(2021, 2, 28, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},
            #endregion

            /// ============================================== 03/2021 ========================================================
            #region
            new EmployeeEvent { EventID = 89, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 3, 01, 08, 20, 00), End = new DateTime(2021, 3, 01, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 90, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 3, 02, 08, 00, 00), End = new DateTime(2021, 3, 02, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 91, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 3, 03, 08, 00, 00), End = new DateTime(2021, 3, 03, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 92, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 3, 04, 08, 20, 00), End = new DateTime(2021, 3, 04, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 93, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 3, 05, 08, 00, 00), End = new DateTime(2021, 3, 05, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 94, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 3, 09, 13, 00, 00), End = new DateTime(2021, 3, 09, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 95, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 3, 10, 13, 00, 00), End = new DateTime(2021, 3, 10, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 96, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 3, 11, 13, 00, 00), End = new DateTime(2021, 3, 11, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 97, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 3, 12, 07, 15, 00), End = new DateTime(2021, 3, 12, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 98, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 3, 13, 07, 15, 00), End = new DateTime(2021, 3, 13, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 99, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 3, 14, 07, 15, 00), End = new DateTime(2021, 3, 14, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 100, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 3, 15, 07, 15, 00), End = new DateTime(2021, 3, 15, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 101, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 3, 16, 07, 00, 00), End = new DateTime(2021, 3, 16, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 102, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 3, 17, 12, 15, 00), End = new DateTime(2021, 2, 17, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 103, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 3, 20, 12, 15, 00), End = new DateTime(2021, 3, 20, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 104, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 3, 21, 12, 15, 00), End = new DateTime(2021, 3, 21, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 105, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 3, 22, 08, 20, 00), End = new DateTime(2021, 3, 22, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 106, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 3, 23, 08, 00, 00), End = new DateTime(2021, 3, 23, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 107, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 3, 24, 08, 00, 00), End = new DateTime(2021, 3, 24, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 108, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 3, 25, 08, 20, 00), End = new DateTime(2021, 3, 25, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 109, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 3, 28, 08, 00, 00), End = new DateTime(2021, 3, 28, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 110, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 3, 29, 13, 00, 00), End = new DateTime(2021, 3, 29, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},
            #endregion

            /// ============================================== 04/2021 ========================================================
            #region
            new EmployeeEvent { EventID = 111, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 4, 2, 07, 15, 00), End = new DateTime(2021, 4, 2, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 112, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 4, 3, 07, 15, 00), End = new DateTime(2021, 4, 3, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 113, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 4, 4, 07, 15, 00), End = new DateTime(2021, 4, 4, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 114, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 4, 5, 07, 15, 00), End = new DateTime(2021, 4, 5, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 115, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 4, 6, 07, 15, 00), End = new DateTime(2021, 4, 6, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 116, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 4, 10, 07, 15, 00), End = new DateTime(2021, 4, 10, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 117, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 4, 11, 07, 00, 00), End = new DateTime(2021, 4, 11, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 118, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 4, 12, 12, 15, 00), End = new DateTime(2021, 4, 12, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 119, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 4, 13, 12, 15, 00), End = new DateTime(2021, 4, 13, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 120, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 4, 14, 12, 15, 00), End = new DateTime(2021, 4, 14, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 121, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 4, 15, 12, 15, 00), End = new DateTime(2021, 4, 15, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 122, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 4, 18, 12, 00, 00), End = new DateTime(2021, 4, 18, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 123, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 4, 19, 12, 00, 00), End = new DateTime(2021, 4, 19, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 3, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 124, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 4, 20, 12, 00, 00), End = new DateTime(2021, 4, 20, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 125, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 4, 21, 12, 00, 00), End = new DateTime(2021, 4, 21, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 126, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 4, 23, 12, 00, 00), End = new DateTime(2021, 4, 23, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 127, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 4, 24, 08, 20, 00), End = new DateTime(2021, 4, 24, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 128, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 4, 25, 08, 00, 00), End = new DateTime(2021, 4, 25, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 129, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 4, 26, 08, 00, 00), End = new DateTime(2021, 4, 26, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 130, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 4, 27, 08, 20, 00), End = new DateTime(2021, 4, 27, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 131, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 4, 28, 08, 00, 00), End = new DateTime(2021, 4, 28, 13, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 132, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 4, 29, 13, 00, 00), End = new DateTime(2021, 4, 29, 21, 30, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            #endregion

            /// ============================================== 05/2021 ========================================================
            #region

            new EmployeeEvent { EventID = 133, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 5, 1, 13, 00, 00), End = new DateTime(2021, 5, 1, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 134, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 5, 2, 13, 00, 00), End = new DateTime(2021, 5, 2, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 135, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 5, 3, 07, 15, 00), End = new DateTime(2021, 5, 3, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 136, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 5, 4, 07, 15, 00), End = new DateTime(2021, 5, 4, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 137, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 5, 5, 07, 15, 00), End = new DateTime(2021, 5, 5, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 138, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 5, 8, 07, 15, 00), End = new DateTime(2021, 5, 8, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent {EventID = 139, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 5, 9, 07, 15, 00), End = new DateTime(2021, 5, 9, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 140, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 5, 10, 07, 15, 00), End = new DateTime(2021, 5, 10, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 141, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 5, 11, 07, 00, 00), End = new DateTime(2021, 5, 11, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 142, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 5, 12, 12, 15, 00), End = new DateTime(2021, 5, 12, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 143, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 5, 13, 12, 15, 00), End = new DateTime(2021, 5, 13, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 144, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 5, 14, 12, 15, 00), End = new DateTime(2021, 5, 14, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 145, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 5, 15, 12, 15, 00), End = new DateTime(2021, 5, 15, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 146, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 5, 18, 12, 00, 00), End = new DateTime(2021, 5, 18, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 147, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 5, 19, 12, 00, 00), End = new DateTime(2021, 5, 19, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 3, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 148, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 5, 20, 12, 00, 00), End = new DateTime(2021, 5, 20, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},
            
            new EmployeeEvent { EventID = 149, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 5, 21, 12, 00, 00), End = new DateTime(2021, 5, 21, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 150, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 5, 24, 12, 00, 00), End = new DateTime(2021, 5, 24, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 151, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 5, 25, 08, 20, 00), End = new DateTime(2021, 5, 25, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 152, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 5, 26, 08, 00, 00), End = new DateTime(2021, 5, 26, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 153, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 5, 27, 08, 00, 00), End = new DateTime(2021, 5, 27, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 154, CompanyID = 1, Username = "Steinbeck",
                Start = new DateTime(2021, 5, 28, 08, 20, 00), End = new DateTime(2021, 5, 28, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},
            #endregion
       };

        internal static List<EmployeeEvent> GetData() => new Employee1EventData().EmployeeEvents;
    }
}