using Entities.Models;
using Entities.UtilityModels;
using System;
using System.Collections.Generic;

namespace Repositories.Data
{
    public class Employee3EventData
    {
        private List<EmployeeEvent> EmployeeEvents = new List<EmployeeEvent>
       {
            //// COMPANY 1
            //// Employee 3
            /// ============================================== 11/2020 ========================================================
            #region
            new EmployeeEvent { EventID = 309, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 11, 2, 07, 15, 00), End = new DateTime(2020, 11, 2, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 310, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 11, 3, 07, 00, 00), End = new DateTime(2020, 11, 3, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 311, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 11, 4, 07, 15, 00), End = new DateTime(2020, 11, 4, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 312, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 11, 5, 07, 15, 00), End = new DateTime(2020, 11, 5, 15, 15, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 313, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 11, 8, 12, 00, 00), End = new DateTime(2020, 11, 8, 18, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 314, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 11, 10, 08, 20, 00), End = new DateTime(2020, 11, 10, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 315, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 11, 12, 08, 00, 00), End = new DateTime(2020, 11, 12, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 316, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 11, 13, 12, 15, 00), End = new DateTime(2020, 11, 13, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 317, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 11, 14, 12, 00, 00), End = new DateTime(2020, 11, 14, 18, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 318, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 11, 16, 08, 20, 00), End = new DateTime(2020, 11, 16, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 319, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 11, 17, 08, 00, 00), End = new DateTime(2020, 11, 17, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 320, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 11, 18, 12, 15, 00), End = new DateTime(2020, 11, 18, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 321, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 11, 19, 12, 00, 00), End = new DateTime(2020, 11, 19, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 322, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 11, 20, 07, 00, 00), End = new DateTime(2020, 11, 20, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 323, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 11, 21, 12, 15, 00), End = new DateTime(2020, 11, 21, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 324, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 11, 22, 12, 00, 00), End = new DateTime(2020, 11, 22, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 325, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 11, 23, 07, 15, 00), End = new DateTime(2020, 11, 23, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 326, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 11, 24, 07, 00, 00), End = new DateTime(2020, 11, 24, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 327, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 11, 25, 12, 15, 00), End = new DateTime(2020, 11, 25, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 328, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 11, 26, 12, 15, 00), End = new DateTime(2020, 11, 26, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 329, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 11, 28, 07, 15, 00), End = new DateTime(2020, 11, 28, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 330, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 11, 29, 12, 00, 00), End = new DateTime(2020, 11, 29, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},
            #endregion

            /// ============================================== 12/2020 ========================================================
            #region
            new EmployeeEvent { EventID = 331, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 12, 3, 07, 15, 00), End = new DateTime(2020, 12, 3, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 332, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 12, 4, 07, 15, 00), End = new DateTime(2020, 12, 4, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 333, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 12, 5, 07, 15, 00), End = new DateTime(2020, 12, 5, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 334, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 12, 6, 07, 15, 00), End = new DateTime(2020, 12, 6, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 335, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 12, 7, 07, 15, 00), End = new DateTime(2020, 12, 7, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 336, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 12, 9, 07, 15, 00), End = new DateTime(2020, 12, 9, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 337, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 12, 10, 07, 00, 00), End = new DateTime(2020, 12, 10, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 338, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 12, 11, 12, 15, 00), End = new DateTime(2020, 12, 11, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 339, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 12, 12, 12, 00, 00), End = new DateTime(2020, 12, 12, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 340, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 12, 14, 12, 15, 00), End = new DateTime(2020, 12, 14, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 341, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 12, 15, 12, 00, 00), End = new DateTime(2020, 12, 15, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 342, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 12, 16, 12, 00, 00), End = new DateTime(2020, 12, 16, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 343, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 12, 17, 08, 20, 00), End = new DateTime(2020, 12, 17, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 344, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 12, 18, 08, 00, 00), End = new DateTime(2020, 12, 18, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 345, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 12, 19, 08, 00, 00), End = new DateTime(2020, 12, 19, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 346, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 12, 20, 08, 20, 00), End = new DateTime(2020, 12, 20, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 347, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 12, 22, 08, 00, 00), End = new DateTime(2020, 12, 22, 13, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 348, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 12, 23, 13, 00, 00), End = new DateTime(2020, 12, 23, 21, 30, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 349, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 12, 24, 13, 00, 00), End = new DateTime(2020, 12, 24, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 350, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 12, 25, 13, 00, 00), End = new DateTime(2020, 12, 25, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 351, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 12, 27, 12, 00, 00), End = new DateTime(2020, 12, 27, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 352, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2020, 12, 28, 12, 00, 00), End = new DateTime(2020, 12, 28, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 3, Status = WorkStatus.Work, Description = "No Description"},
            #endregion

            /// ============================================== 01/2021 ========================================================
            #region
            new EmployeeEvent { EventID = 353, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 1, 2, 07, 15, 00), End = new DateTime(2021, 1, 2, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 354, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 1, 3, 07, 15, 00), End = new DateTime(2021, 1, 3, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 355, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 1, 4, 07, 15, 00), End = new DateTime(2021, 1, 4, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 356, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 1, 5, 07, 15, 00), End = new DateTime(2021, 1, 5, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 357, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 1, 7, 07, 15, 00), End = new DateTime(2021, 1, 7, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 358, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 1, 8, 07, 15, 00), End = new DateTime(2021, 1, 8, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 359, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 1, 9, 12, 00, 00), End = new DateTime(2021, 1, 9, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 360, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 1, 10, 08, 00, 00), End = new DateTime(2021, 1, 10, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 361, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 1, 12, 08, 20, 00), End = new DateTime(2021, 1, 12, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 362, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 1, 13, 08, 20, 00), End = new DateTime(2021, 1, 13, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 363, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 1, 14, 08, 00, 00), End = new DateTime(2021, 1, 14, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 364, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 1, 15, 13, 00, 00), End = new DateTime(2021, 1, 15, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 365, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 1, 17, 13, 00, 00), End = new DateTime(2021, 1, 17, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 366, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 1, 18, 13, 00, 00), End = new DateTime(2021, 1, 18, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 367, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 1, 20, 08, 20, 00), End = new DateTime(2021, 1, 20, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 368, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 1, 21, 08, 00, 00), End = new DateTime(2021, 1, 21, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 369, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 1, 22, 13, 00, 00), End = new DateTime(2021, 1, 22, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 370, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 1, 23, 13, 00, 00), End = new DateTime(2021, 1, 23, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 371, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 1, 25, 13, 00, 00), End = new DateTime(2021, 1, 25, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 372, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 1, 26, 07, 15, 00), End = new DateTime(2021, 1, 26, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 373, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 1, 27, 07, 15, 00), End = new DateTime(2021, 1, 27, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 374, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 1, 28, 07, 15, 00), End = new DateTime(2021, 1, 28, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},
            #endregion

            /// ============================================== 02/2021 ========================================================
            #region
            new EmployeeEvent { EventID = 375, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 2, 1, 07, 15, 00), End = new DateTime(2021, 2, 1, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 376, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 2, 2, 07, 15, 00), End = new DateTime(2021, 2, 2, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 377, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 2, 3, 07, 15, 00), End = new DateTime(2021, 2, 3, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 378, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 2, 4, 07, 15, 00), End = new DateTime(2021, 2, 4, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 379, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 2, 6, 07, 15, 00), End = new DateTime(2021, 2, 6, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 380, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 2, 7, 07, 15, 00), End = new DateTime(2021, 2, 7, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 381, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 2, 10, 07, 15, 00), End = new DateTime(2021, 2, 10, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 382, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 2, 11, 07, 00, 00), End = new DateTime(2021, 2, 11, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 383, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 2, 12, 07, 15, 00), End = new DateTime(2021, 2, 12, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 384, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 2, 13, 07, 15, 00), End = new DateTime(2021, 2, 13, 15, 15, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 385, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 2, 14, 07, 15, 00), End = new DateTime(2021, 2, 14, 15, 15, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 386, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 2, 15, 07, 15, 00), End = new DateTime(2021, 2, 15, 15, 15, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 387, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 2, 17, 12, 00, 00), End = new DateTime(2021, 2, 17, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 388, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 2, 18, 12, 00, 00), End = new DateTime(2021, 2, 18, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 3, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 389, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 2, 19, 12, 00, 00), End = new DateTime(2021, 2, 19, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 390, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 2, 20, 12, 00, 00), End = new DateTime(2021, 2, 20, 18, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 391, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 2, 23, 08, 00, 00), End = new DateTime(2021, 2, 23, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 392, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 2, 24, 08, 20, 00), End = new DateTime(2021, 2, 24, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 393, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 2, 25, 08, 00, 00), End = new DateTime(2021, 2, 25, 13, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 394, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 2, 26, 13, 00, 00), End = new DateTime(2021, 2, 26, 21, 30, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 395, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 2, 27, 13, 00, 00), End = new DateTime(2021, 2, 27, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 396, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 2, 28, 13, 00, 00), End = new DateTime(2021, 2, 28, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},
            #endregion

            /// ============================================== 03/2021 ========================================================
            #region
            new EmployeeEvent { EventID = 397, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 3, 01, 08, 20, 00), End = new DateTime(2021, 3, 01, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 398, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 3, 02, 08, 00, 00), End = new DateTime(2021, 3, 02, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 399, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 3, 03, 08, 00, 00), End = new DateTime(2021, 3, 03, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 400, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 3, 04, 08, 20, 00), End = new DateTime(2021, 3, 04, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 401, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 3, 05, 08, 00, 00), End = new DateTime(2021, 3, 05, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 402, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 3, 6, 13, 00, 00), End = new DateTime(2021, 3, 6, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 403, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 3, 7, 13, 00, 00), End = new DateTime(2021, 3, 7, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 404, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 3, 9, 13, 00, 00), End = new DateTime(2021, 3, 9, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 405, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 3, 10, 07, 15, 00), End = new DateTime(2021, 3, 10, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 406, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 3, 11, 07, 15, 00), End = new DateTime(2021, 3, 11, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 407, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 3, 12, 07, 15, 00), End = new DateTime(2021, 3, 12, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 408, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 3, 15, 07, 15, 00), End = new DateTime(2021, 3, 15, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 409, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 3, 16, 07, 00, 00), End = new DateTime(2021, 3, 16, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 410, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 3, 17, 12, 15, 00), End = new DateTime(2021, 3, 17, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 411, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 3, 18, 12, 15, 00), End = new DateTime(2021, 3, 18, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 412, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 3, 20, 12, 15, 00), End = new DateTime(2021, 3, 20, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 413, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 3, 21, 08, 20, 00), End = new DateTime(2021, 3, 21, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 414, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 3, 22, 08, 00, 00), End = new DateTime(2021, 3, 22, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 415, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 3, 24, 08, 00, 00), End = new DateTime(2021, 3, 24, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 416, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 3, 26, 08, 20, 00), End = new DateTime(2021, 3, 26, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 417, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 3, 28, 08, 00, 00), End = new DateTime(2021, 3, 28, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 418, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 3, 29, 13, 00, 00), End = new DateTime(2021, 3, 29, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},
            #endregion

            /// ============================================== 04/2021 ========================================================
            #region
            new EmployeeEvent { EventID = 419, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 4, 2, 07, 15, 00), End = new DateTime(2021, 4, 2, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 420, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 4, 3, 07, 15, 00), End = new DateTime(2021, 4, 3, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 421, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 4, 4, 07, 15, 00), End = new DateTime(2021, 4, 4, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 422, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 4, 5, 07, 15, 00), End = new DateTime(2021, 4, 5, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 423, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 4, 6, 07, 15, 00), End = new DateTime(2021, 4, 6, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 424, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 4, 7, 07, 15, 00), End = new DateTime(2021, 4, 7, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 425, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 4, 10, 07, 00, 00), End = new DateTime(2021, 4, 10, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 426, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 4, 11, 12, 15, 00), End = new DateTime(2021, 4, 11, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 427, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 4, 12, 12, 15, 00), End = new DateTime(2021, 4, 12, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 428, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 4, 13, 12, 15, 00), End = new DateTime(2021, 4, 13, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 429, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 4, 16, 12, 15, 00), End = new DateTime(2021, 4, 16, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 430, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 4, 17, 12, 00, 00), End = new DateTime(2021, 4, 17, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 431, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 4, 18, 07, 15, 00), End = new DateTime(2021, 4, 18, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 432, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 4, 19, 07, 15, 00), End = new DateTime(2021, 4, 19, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 433, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 4, 20, 07, 00, 00), End = new DateTime(2021, 4, 20, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 434, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 4, 22, 12, 15, 00), End = new DateTime(2021, 4, 22, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 435, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 4, 23, 12, 15, 00), End = new DateTime(2021, 4, 23, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 436, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 4, 24, 12, 15, 00), End = new DateTime(2021, 4, 24, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 437, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 4, 25, 12, 15, 00), End = new DateTime(2021, 4, 25, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 438, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 4, 28, 12, 00, 00), End = new DateTime(2021, 4, 28, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 439, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 4, 29, 12, 00, 00), End = new DateTime(2021, 4, 29, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 3, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 440, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 4, 30, 12, 00, 00), End = new DateTime(2021, 4, 30, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 3, Status = WorkStatus.Work, Description = "No Description"},
            #endregion

            /// ============================================== 05/2021 ========================================================
            #region

            new EmployeeEvent { EventID = 441, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 5, 1, 13, 00, 00), End = new DateTime(2021, 5, 1, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 442, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 5, 2, 13, 00, 00), End = new DateTime(2021, 5, 2, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 443, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 5, 3, 07, 15, 00), End = new DateTime(2021, 5, 3, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 444, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 5, 4, 07, 15, 00), End = new DateTime(2021, 5, 4, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 445, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 5, 5, 07, 15, 00), End = new DateTime(2021, 5, 5, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 446, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 5, 6, 07, 15, 00), End = new DateTime(2021, 5, 6, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent {EventID = 447, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 5, 8, 07, 15, 00), End = new DateTime(2021, 5, 8, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 448, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 5, 9, 07, 15, 00), End = new DateTime(2021, 5, 9, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 449, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 5, 11, 07, 00, 00), End = new DateTime(2021, 5, 11, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 450, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 5, 12, 12, 15, 00), End = new DateTime(2021, 5, 12, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 451, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 5, 13, 12, 15, 00), End = new DateTime(2021, 5, 13, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 452, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 5, 14, 12, 00, 00), End = new DateTime(2021, 5, 14, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 453, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 5, 15, 12, 00, 00), End = new DateTime(2021, 5, 16, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 454, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 5, 17, 08, 20, 00), End = new DateTime(2021, 5, 17, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 455, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 5, 18, 08, 00, 00), End = new DateTime(2021, 5, 18, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 456, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 5, 20, 08, 00, 00), End = new DateTime(2021, 5, 20, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 457, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 5, 21, 08, 20, 00), End = new DateTime(2021, 5, 21, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 458, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 5, 23, 08, 00, 00), End = new DateTime(2021, 5, 23, 13, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 459, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 5, 24, 13, 00, 00), End = new DateTime(2021, 5, 24, 21, 30, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 460, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 5, 25, 08, 20, 00), End = new DateTime(2021, 5, 25, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 461, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 5, 26, 08, 00, 00), End = new DateTime(2021, 5, 26, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 462, CompanyID = 1, Username = "Hemingway",
                Start = new DateTime(2021, 5, 27, 08, 00, 00), End = new DateTime(2021, 5, 27, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            #endregion
        };

        internal static List<EmployeeEvent> GetData() => new Employee3EventData().EmployeeEvents;
    }
}
