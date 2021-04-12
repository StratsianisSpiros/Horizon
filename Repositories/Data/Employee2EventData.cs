using Entities.Models;
using Entities.UtilityModels;
using System;
using System.Collections.Generic;

namespace Repositories.Data
{
    public class Employee2EventData
    {
        private List<EmployeeEvent> EmployeeEvents = new List<EmployeeEvent>
       {
            //// COMPANY 1
            //// Employee 2
            /// ============================================== 11/2020 ========================================================
            #region
            new EmployeeEvent { EventID = 155, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 11, 2, 07, 15, 00), End = new DateTime(2020, 11, 2, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 156, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 11, 3, 07, 00, 00), End = new DateTime(2020, 11, 3, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 157, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 11, 4, 07, 15, 00), End = new DateTime(2020, 11, 4, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 158, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 11, 5, 07, 15, 00), End = new DateTime(2020, 11, 5, 15, 15, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 159, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 11, 8, 12, 00, 00), End = new DateTime(2020, 11, 8, 18, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 160, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 11, 10, 08, 20, 00), End = new DateTime(2020, 11, 10, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 161, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 11, 12, 08, 00, 00), End = new DateTime(2020, 11, 12, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 162, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 11, 13, 12, 15, 00), End = new DateTime(2020, 11, 13, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 163, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 11, 14, 12, 00, 00), End = new DateTime(2020, 11, 14, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 164, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 11, 15, 12, 00, 00), End = new DateTime(2020, 11, 15, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 3, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 165, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 11, 16, 12, 00, 00), End = new DateTime(2020, 11, 16, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 166, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 11, 18, 12, 00, 00), End = new DateTime(2020, 11, 18, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 167, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 11, 19, 07, 15, 00), End = new DateTime(2020, 11, 19, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 168, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 11, 20, 07, 00, 00), End = new DateTime(2020, 11, 20, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 169, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 11, 21, 12, 15, 00), End = new DateTime(2020, 11, 21, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 170, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 11, 22, 12, 15, 00), End = new DateTime(2020, 11, 22, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 171, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 11, 23, 12, 15, 00), End = new DateTime(2020, 11, 23, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 172, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 11, 25, 07, 15, 00), End = new DateTime(2020, 11, 25, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 173, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 11, 26, 07, 15, 00), End = new DateTime(2020, 11, 26, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 174, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 11, 27, 07, 15, 00), End = new DateTime(2020, 11, 27, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 175, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 11, 28, 07, 15, 00), End = new DateTime(2020, 11, 28, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 176, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 11, 29, 12, 00, 00), End = new DateTime(2020, 11, 29, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},
            #endregion

            /// ============================================== 12/2020 ========================================================
            #region
            new EmployeeEvent { EventID = 177, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 12, 3, 07, 15, 00), End = new DateTime(2020, 12, 3, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 178, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 12, 4, 07, 15, 00), End = new DateTime(2020, 12, 4, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 179, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 12, 5, 07, 15, 00), End = new DateTime(2020, 12, 5, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 180, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 12, 6, 07, 15, 00), End = new DateTime(2020, 12, 6, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 181, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 12, 7, 07, 15, 00), End = new DateTime(2020, 12, 7, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 182, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 12, 9, 07, 15, 00), End = new DateTime(2020, 12, 9, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 183, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 12, 10, 07, 00, 00), End = new DateTime(2020, 12, 10, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 184, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 12, 11, 12, 15, 00), End = new DateTime(2020, 12, 11, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 185, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 12, 12, 12, 00, 00), End = new DateTime(2020, 12, 12, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 186, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 12, 15, 12, 00, 00), End = new DateTime(2020, 12, 15, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 187, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 12, 16, 08, 20, 00), End = new DateTime(2020, 12, 16, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 188, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 12, 17, 08, 00, 00), End = new DateTime(2020, 12, 17, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 189, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 12, 18, 08, 00, 00), End = new DateTime(2020, 12, 18, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 190, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 12, 19, 08, 20, 00), End = new DateTime(2020, 12, 19, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 191, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 12, 20, 08, 00, 00), End = new DateTime(2020, 12, 20, 13, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 192, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 12, 22, 13, 00, 00), End = new DateTime(2020, 12, 22, 21, 30, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 193, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 12, 24, 13, 00, 00), End = new DateTime(2020, 12, 24, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 194, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 12, 25, 13, 00, 00), End = new DateTime(2020, 12, 25, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 195, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 12, 26, 12, 15, 00), End = new DateTime(2020, 12, 26, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 196, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 12, 27, 12, 00, 00), End = new DateTime(2020, 12, 27, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 197, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 12, 28, 12, 00, 00), End = new DateTime(2020, 12, 28, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 3, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 198, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2020, 12, 29, 12, 00, 00), End = new DateTime(2020, 12, 29, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},
            #endregion

            /// ============================================== 01/2021 ========================================================
            #region
            new EmployeeEvent { EventID = 199, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 1, 2, 07, 15, 00), End = new DateTime(2021, 1, 2, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 200, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 1, 3, 07, 15, 00), End = new DateTime(2021, 1, 3, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 201, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 1, 4, 07, 15, 00), End = new DateTime(2021, 1, 4, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 202, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 1, 5, 07, 15, 00), End = new DateTime(2021, 1, 5, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 203, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 1, 7, 07, 15, 00), End = new DateTime(2021, 1, 7, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 204, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 1, 8, 07, 15, 00), End = new DateTime(2021, 1, 8, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 205, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 1, 10, 12, 00, 00), End = new DateTime(2021, 1, 10, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 206, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 1, 11, 12, 00, 00), End = new DateTime(2021, 1, 11, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 3, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 207, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 1, 12, 12, 00, 00), End = new DateTime(2021, 1, 12, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 208, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 1, 13, 12, 00, 00), End = new DateTime(2021, 1, 13, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 209, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 1, 15, 12, 00, 00), End = new DateTime(2021, 1, 15, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 210, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 1, 16, 08, 00, 00), End = new DateTime(2021, 1, 16, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 211, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 1, 17, 08, 00, 00), End = new DateTime(2021, 1, 17, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 212, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 1, 18, 08, 20, 00), End = new DateTime(2021, 1, 18, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 213, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 1, 20, 08, 20, 00), End = new DateTime(2021, 1, 20, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 214, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 1, 21, 08, 00, 00), End = new DateTime(2021, 1, 21, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 215, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 1, 22, 13, 00, 00), End = new DateTime(2021, 1, 22, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 216, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 1, 24, 13, 00, 00), End = new DateTime(2021, 1, 24, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 217, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 1, 25, 13, 00, 00), End = new DateTime(2021, 1, 25, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 218, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 1, 26, 07, 15, 00), End = new DateTime(2021, 1, 26, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 219, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 1, 27, 07, 15, 00), End = new DateTime(2021, 1, 27, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 220, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 1, 28, 07, 15, 00), End = new DateTime(2021, 1, 28, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},
            #endregion

            /// ============================================== 02/2021 ========================================================
            #region
            new EmployeeEvent { EventID = 221, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 2, 2, 07, 15, 00), End = new DateTime(2021, 2, 2, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 222, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 2, 3, 07, 15, 00), End = new DateTime(2021, 2, 3, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 223, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 2, 4, 07, 15, 00), End = new DateTime(2021, 2, 4, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 224, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 2, 5, 07, 15, 00), End = new DateTime(2021, 2, 5, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 225, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 2, 6, 07, 15, 00), End = new DateTime(2021, 2, 6, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 226, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 2, 9, 07, 15, 00), End = new DateTime(2021, 2, 9, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 227, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 2, 10, 07, 00, 00), End = new DateTime(2021, 2, 10, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 228, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 2, 11, 07, 15, 00), End = new DateTime(2021, 2, 11, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 229, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 2, 12, 07, 15, 00), End = new DateTime(2021, 2, 12, 15, 15, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 230, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 2, 14, 07, 15, 00), End = new DateTime(2021, 2, 14, 15, 15, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 231, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 2, 15, 07, 15, 00), End = new DateTime(2021, 2, 15, 15, 15, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 232, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 2, 17, 12, 00, 00), End = new DateTime(2021, 2, 17, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 233, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 2, 18, 12, 00, 00), End = new DateTime(2021, 2, 18, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 3, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 234, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 2, 19, 12, 00, 00), End = new DateTime(2021, 2, 19, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 235, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 2, 20, 12, 00, 00), End = new DateTime(2021, 2, 20, 18, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 236, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 2, 22, 12, 00, 00), End = new DateTime(2021, 2, 22, 18, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 237, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 2, 23, 08, 00, 00), End = new DateTime(2021, 2, 23, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 238, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 2, 24, 08, 20, 00), End = new DateTime(2021, 2, 24, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 239, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 2, 25, 08, 00, 00), End = new DateTime(2021, 2, 25, 13, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 240, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 2, 26, 13, 00, 00), End = new DateTime(2021, 2, 26, 21, 30, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 241, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 2, 27, 13, 00, 00), End = new DateTime(2021, 2, 27, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 242, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 2, 28, 13, 00, 00), End = new DateTime(2021, 2, 28, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},
            #endregion

            /// ============================================== 03/2021 ========================================================
            #region
            new EmployeeEvent { EventID = 243, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 3, 01, 08, 20, 00), End = new DateTime(2021, 3, 01, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 244, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 3, 02, 08, 00, 00), End = new DateTime(2021, 3, 02, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 245, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 3, 03, 08, 00, 00), End = new DateTime(2021, 3, 03, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 246, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 3, 04, 08, 20, 00), End = new DateTime(2021, 3, 04, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 247, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 3, 05, 08, 00, 00), End = new DateTime(2021, 3, 05, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 248, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 3, 6, 13, 00, 00), End = new DateTime(2021, 3, 6, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 249, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 3, 7, 13, 00, 00), End = new DateTime(2021, 3, 7, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 250, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 3, 11, 13, 00, 00), End = new DateTime(2021, 3, 11, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 251, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 3, 12, 07, 15, 00), End = new DateTime(2021, 3, 12, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 252, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 3, 13, 07, 15, 00), End = new DateTime(2021, 3, 13, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 253, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 3, 14, 07, 15, 00), End = new DateTime(2021, 3, 14, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 254, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 3, 15, 07, 15, 00), End = new DateTime(2021, 3, 15, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 255, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 3, 16, 07, 00, 00), End = new DateTime(2021, 3, 16, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 256, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 3, 18, 12, 15, 00), End = new DateTime(2021, 3, 18, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 257, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 3, 20, 12, 15, 00), End = new DateTime(2021, 3, 20, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 258, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 3, 21, 12, 15, 00), End = new DateTime(2021, 3, 21, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 259, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 3, 22, 08, 20, 00), End = new DateTime(2021, 3, 22, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 260, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 3, 23, 08, 00, 00), End = new DateTime(2021, 3, 23, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 261, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 3, 24, 08, 00, 00), End = new DateTime(2021, 3, 24, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 262, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 3, 26, 08, 20, 00), End = new DateTime(2021, 3, 26, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 263, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 3, 28, 08, 00, 00), End = new DateTime(2021, 3, 28, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 264, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 3, 29, 13, 00, 00), End = new DateTime(2021, 3, 29, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},
            #endregion

            /// ============================================== 04/2021 ========================================================
            #region
            new EmployeeEvent { EventID = 265, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 4, 2, 07, 15, 00), End = new DateTime(2021, 4, 2, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 266, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 4, 3, 07, 15, 00), End = new DateTime(2021, 4, 3, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 267, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 4, 4, 07, 15, 00), End = new DateTime(2021, 4, 4, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 268, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 4, 5, 07, 15, 00), End = new DateTime(2021, 4, 5, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 269, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 4, 6, 07, 15, 00), End = new DateTime(2021, 4, 6, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 270, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 4, 9, 07, 15, 00), End = new DateTime(2021, 4, 9, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 271, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 4, 10, 07, 00, 00), End = new DateTime(2021, 4, 10, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 272, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 4, 12, 12, 15, 00), End = new DateTime(2021, 4, 12, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 273, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 4, 13, 12, 15, 00), End = new DateTime(2021, 4, 13, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 274, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 4, 14, 12, 15, 00), End = new DateTime(2021, 4, 14, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 275, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 4, 17, 12, 15, 00), End = new DateTime(2021, 4, 17, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 276, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 4, 18, 12, 00, 00), End = new DateTime(2021, 4, 18, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 277, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 4, 19, 12, 00, 00), End = new DateTime(2021, 4, 19, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 3, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 278, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 4, 20, 12, 00, 00), End = new DateTime(2021, 4, 20, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 279, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 4, 21, 12, 00, 00), End = new DateTime(2021, 4, 21, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 280, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 4, 23, 12, 00, 00), End = new DateTime(2021, 4, 23, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 281, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 4, 24, 08, 20, 00), End = new DateTime(2021, 4, 24, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 282, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 4, 25, 08, 00, 00), End = new DateTime(2021, 4, 25, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 283, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 4, 26, 08, 00, 00), End = new DateTime(2021, 4, 26, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 284, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 4, 27, 08, 20, 00), End = new DateTime(2021, 4, 27, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 285, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 4, 28, 08, 00, 00), End = new DateTime(2021, 4, 28, 13, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 286, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 4, 29, 13, 00, 00), End = new DateTime(2021, 4, 29, 21, 30, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            #endregion

            /// ============================================== 05/2021 ========================================================
            #region

            new EmployeeEvent { EventID = 287, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 5, 1, 13, 00, 00), End = new DateTime(2021, 5, 1, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 288, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 5, 2, 13, 00, 00), End = new DateTime(2021, 5, 2, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 289, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 5, 3, 07, 15, 00), End = new DateTime(2021, 5, 3, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 290, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 5, 4, 07, 15, 00), End = new DateTime(2021, 5, 4, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 291, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 5, 5, 07, 15, 00), End = new DateTime(2021, 5, 5, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 292, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 5, 7, 07, 15, 00), End = new DateTime(2021, 5, 7, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent {EventID = 293, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 5, 8, 07, 15, 00), End = new DateTime(2021, 5, 8, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 294, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 5, 9, 07, 15, 00), End = new DateTime(2021, 5, 9, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 295, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 5, 11, 07, 00, 00), End = new DateTime(2021, 5, 11, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 296, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 5, 12, 12, 15, 00), End = new DateTime(2021, 5, 12, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 297, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 5, 13, 12, 15, 00), End = new DateTime(2021, 5, 13, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 298, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 5, 14, 12, 15, 00), End = new DateTime(2021, 5, 14, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 299, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 5, 15, 12, 15, 00), End = new DateTime(2021, 5, 15, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 300, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 5, 18, 12, 00, 00), End = new DateTime(2021, 5, 18, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 301, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 5, 19, 12, 00, 00), End = new DateTime(2021, 5, 19, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 3, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 302, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 5, 20, 12, 00, 00), End = new DateTime(2021, 5, 20, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 303, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 5, 21, 12, 00, 00), End = new DateTime(2021, 5, 21, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 304, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 5, 24, 12, 00, 00), End = new DateTime(2021, 5, 24, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 305, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 5, 25, 08, 20, 00), End = new DateTime(2021, 5, 25, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 306, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 5, 26, 08, 00, 00), End = new DateTime(2021, 5, 26, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 307, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 5, 27, 08, 00, 00), End = new DateTime(2021, 5, 27, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 308, CompanyID = 1, Username = "Orwell",
                Start = new DateTime(2021, 5, 28, 08, 20, 00), End = new DateTime(2021, 5, 28, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},
            #endregion
        };

        internal static List<EmployeeEvent> GetData() => new Employee2EventData().EmployeeEvents;
    }
}
