using Entities.Models;
using Entities.UtilityModels;
using System;
using System.Collections.Generic;

namespace Repositories.Data
{
    public class Employee4EventData
    {
        private List<EmployeeEvent> EmployeeEvents = new List<EmployeeEvent>
       {
            //// COMPANY 1
            //// Employee 4
            /// ============================================== 11/2020 ========================================================
            #region
            new EmployeeEvent { EventID = 463, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 11, 2, 07, 15, 00), End = new DateTime(2020, 11, 2, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 464, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 11, 3, 07, 00, 00), End = new DateTime(2020, 11, 3, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 465, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 11, 4, 07, 15, 00), End = new DateTime(2020, 11, 4, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 466, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 11, 5, 07, 15, 00), End = new DateTime(2020, 11, 5, 15, 15, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 467, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 11, 7, 12, 00, 00), End = new DateTime(2020, 11, 7, 18, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 468, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 11, 9, 08, 20, 00), End = new DateTime(2020, 11, 9, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 469, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 11, 10, 08, 00, 00), End = new DateTime(2020, 11, 10, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 470, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 11, 11, 12, 15, 00), End = new DateTime(2020, 11, 11, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 471, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 11, 12, 12, 00, 00), End = new DateTime(2020, 11, 12, 18, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 472, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 11, 16, 08, 20, 00), End = new DateTime(2020, 11, 16, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 473, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 11, 17, 08, 00, 00), End = new DateTime(2020, 11, 17, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 474, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 11, 18, 12, 15, 00), End = new DateTime(2020, 11, 18, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 475, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 11, 19, 12, 00, 00), End = new DateTime(2020, 11, 19, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 476, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 11, 21, 12, 00, 00), End = new DateTime(2020, 11, 21, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 3, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 477, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 11, 22, 12, 00, 00), End = new DateTime(2020, 11, 22, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 478, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 11, 23, 12, 00, 00), End = new DateTime(2020, 11, 23, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 479, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 11, 24, 07, 15, 00), End = new DateTime(2020, 11, 24, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 480, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 11, 25, 07, 00, 00), End = new DateTime(2020, 11, 25, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 481, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 11, 27, 12, 15, 00), End = new DateTime(2020, 11, 27, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 482, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 11, 28, 12, 15, 00), End = new DateTime(2020, 11, 28, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 483, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 11, 29, 07, 15, 00), End = new DateTime(2020, 11, 29, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 484, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 11, 30, 12, 00, 00), End = new DateTime(2020, 11, 30, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},
            #endregion

            /// ============================================== 12/2020 ========================================================
            #region
            new EmployeeEvent { EventID = 485, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 12, 3, 07, 15, 00), End = new DateTime(2020, 12, 3, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 486, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 12, 4, 07, 15, 00), End = new DateTime(2020, 12, 4, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 487, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 12, 5, 07, 15, 00), End = new DateTime(2020, 12, 5, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 488, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 12, 6, 07, 15, 00), End = new DateTime(2020, 12, 6, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 489, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 12, 7, 07, 15, 00), End = new DateTime(2020, 12, 7, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 490, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 12, 9, 07, 15, 00), End = new DateTime(2020, 12, 9, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 491, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 12, 10, 07, 00, 00), End = new DateTime(2020, 12, 10, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 492, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 12, 11, 12, 15, 00), End = new DateTime(2020, 12, 11, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 493, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 12, 12, 12, 00, 00), End = new DateTime(2020, 12, 12, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 494, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 12, 14, 12, 15, 00), End = new DateTime(2020, 12, 14, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 495, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 12, 15, 12, 00, 00), End = new DateTime(2020, 12, 15, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 496, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 12, 16, 12, 00, 00), End = new DateTime(2020, 12, 16, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 497, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 12, 17, 08, 20, 00), End = new DateTime(2020, 12, 17, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 498, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 12, 18, 08, 00, 00), End = new DateTime(2020, 12, 18, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 499, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 12, 19, 08, 00, 00), End = new DateTime(2020, 12, 19, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 500, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 12, 20, 08, 20, 00), End = new DateTime(2020, 12, 20, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 501, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 12, 22, 08, 00, 00), End = new DateTime(2020, 12, 22, 13, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 502, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 12, 23, 13, 00, 00), End = new DateTime(2020, 12, 23, 21, 30, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 503, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 12, 24, 13, 00, 00), End = new DateTime(2020, 12, 24, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 504, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 12, 25, 13, 00, 00), End = new DateTime(2020, 12, 25, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 505, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 12, 27, 12, 00, 00), End = new DateTime(2020, 12, 27, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 506, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2020, 12, 28, 12, 00, 00), End = new DateTime(2020, 12, 28, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 3, Status = WorkStatus.Work, Description = "No Description"},
            #endregion

            /// ============================================== 01/2021 ========================================================
            #region
            new EmployeeEvent { EventID = 507, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 1, 2, 07, 15, 00), End = new DateTime(2021, 1, 2, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 508, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 1, 3, 07, 15, 00), End = new DateTime(2021, 1, 3, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 509, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 1, 4, 07, 15, 00), End = new DateTime(2021, 1, 4, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 510, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 1, 5, 07, 15, 00), End = new DateTime(2021, 1, 5, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 511, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 1, 7, 07, 15, 00), End = new DateTime(2021, 1, 7, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 512, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 1, 8, 07, 15, 00), End = new DateTime(2021, 1, 8, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 513, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 1, 9, 12, 00, 00), End = new DateTime(2021, 1, 9, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 514, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 1, 10, 08, 00, 00), End = new DateTime(2021, 1, 10, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 515, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 1, 12, 08, 20, 00), End = new DateTime(2021, 1, 12, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 516, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 1, 13, 08, 20, 00), End = new DateTime(2021, 1, 13, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 517, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 1, 14, 12, 00, 00), End = new DateTime(2021, 1, 14, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 3, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 518, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 1, 15, 12, 00, 00), End = new DateTime(2021, 1, 15, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 519, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 1, 17, 12, 00, 00), End = new DateTime(2021, 1, 17, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 520, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 1, 18, 12, 00, 00), End = new DateTime(2021, 1, 18, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 521, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 1, 19, 08, 00, 00), End = new DateTime(2021, 1, 19, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 522, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 1, 20, 08, 00, 00), End = new DateTime(2021, 1, 20, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 523, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 1, 21, 08, 20, 00), End = new DateTime(2021, 1, 21, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 524, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 1, 22, 08, 20, 00), End = new DateTime(2021, 1, 22, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 525, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 1, 23, 08, 00, 00), End = new DateTime(2021, 1, 23, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 526, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 1, 25, 13, 00, 00), End = new DateTime(2021, 1, 25, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 527, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 1, 27, 07, 15, 00), End = new DateTime(2021, 1, 27, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 528, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 1, 28, 07, 15, 00), End = new DateTime(2021, 1, 28, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},
            #endregion

            /// ============================================== 02/2021 ========================================================
            #region
            new EmployeeEvent { EventID = 529, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 2, 1, 07, 15, 00), End = new DateTime(2021, 2, 1, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 530, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 2, 2, 07, 15, 00), End = new DateTime(2021, 2, 2, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 531, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 2, 3, 07, 15, 00), End = new DateTime(2021, 2, 3, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 532, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 2, 4, 07, 15, 00), End = new DateTime(2021, 2, 4, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 533, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 2, 6, 07, 15, 00), End = new DateTime(2021, 2, 6, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 534, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 2, 7, 07, 15, 00), End = new DateTime(2021, 2, 7, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 535, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 2, 10, 07, 15, 00), End = new DateTime(2021, 2, 10, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 536, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 2, 11, 07, 00, 00), End = new DateTime(2021, 2, 11, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 537, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 2, 12, 07, 15, 00), End = new DateTime(2021, 2, 12, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 538, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 2, 13, 07, 15, 00), End = new DateTime(2021, 2, 13, 15, 15, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 539, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 2, 14, 07, 15, 00), End = new DateTime(2021, 2, 14, 15, 15, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 540, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 2, 15, 07, 15, 00), End = new DateTime(2021, 2, 15, 15, 15, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 541, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 2, 17, 12, 00, 00), End = new DateTime(2021, 2, 17, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 542, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 2, 18, 12, 00, 00), End = new DateTime(2021, 2, 18, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 3, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 543, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 2, 19, 12, 00, 00), End = new DateTime(2021, 2, 19, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 544, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 2, 20, 12, 00, 00), End = new DateTime(2021, 2, 20, 18, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 545, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 2, 23, 08, 00, 00), End = new DateTime(2021, 2, 23, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 546, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 2, 24, 08, 20, 00), End = new DateTime(2021, 2, 24, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 547, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 2, 25, 08, 00, 00), End = new DateTime(2021, 2, 25, 13, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 548, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 2, 26, 13, 00, 00), End = new DateTime(2021, 2, 26, 21, 30, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 549, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 2, 27, 13, 00, 00), End = new DateTime(2021, 2, 27, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 550, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 2, 28, 13, 00, 00), End = new DateTime(2021, 2, 28, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},
            #endregion

            /// ============================================== 03/2021 ========================================================
            #region
            new EmployeeEvent { EventID = 551, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 3, 01, 08, 20, 00), End = new DateTime(2021, 3, 01, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 552, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 3, 02, 08, 00, 00), End = new DateTime(2021, 3, 02, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 553, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 3, 03, 08, 00, 00), End = new DateTime(2021, 3, 03, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 554, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 3, 04, 08, 20, 00), End = new DateTime(2021, 3, 04, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 555, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 3, 05, 08, 00, 00), End = new DateTime(2021, 3, 05, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 556, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 3, 6, 13, 00, 00), End = new DateTime(2021, 3, 6, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 557, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 3, 7, 13, 00, 00), End = new DateTime(2021, 3, 7, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 558, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 3, 9, 13, 00, 00), End = new DateTime(2021, 3, 9, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 559, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 3, 10, 07, 15, 00), End = new DateTime(2021, 3, 10, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 560, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 3, 12, 07, 00, 00), End = new DateTime(2021, 3, 12, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 561, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 3, 13, 12, 15, 00), End = new DateTime(2021, 3, 13, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 562, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 3, 14, 12, 15, 00), End = new DateTime(2021, 3, 14, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 563, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 3, 15, 12, 15, 00), End = new DateTime(2021, 3, 15, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 564, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 3, 16, 08, 20, 00), End = new DateTime(2021, 3, 16, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 565, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 3, 19, 08, 00, 00), End = new DateTime(2021, 3, 19, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 566, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 3, 20, 08, 00, 00), End = new DateTime(2021, 3, 20, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 567, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 3, 21, 08, 20, 00), End = new DateTime(2021, 3, 21, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 568, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 3, 22, 08, 00, 00), End = new DateTime(2021, 3, 22, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 569, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 3, 24, 13, 00, 00), End = new DateTime(2021, 3, 24, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 570, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 3, 26, 08, 20, 00), End = new DateTime(2021, 3, 26, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 571, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 3, 28, 08, 00, 00), End = new DateTime(2021, 3, 28, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 572, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 3, 29, 13, 00, 00), End = new DateTime(2021, 3, 29, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},
            #endregion

            /// ============================================== 04/2021 ========================================================
            #region
            new EmployeeEvent { EventID = 573, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 4, 2, 07, 15, 00), End = new DateTime(2021, 4, 2, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 574, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 4, 3, 07, 15, 00), End = new DateTime(2021, 4, 3, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 575, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 4, 4, 07, 15, 00), End = new DateTime(2021, 4, 4, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 576, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 4, 5, 07, 15, 00), End = new DateTime(2021, 4, 5, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 577, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 4, 6, 07, 15, 00), End = new DateTime(2021, 4, 6, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 578, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 4, 7, 07, 15, 00), End = new DateTime(2021, 4, 7, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 579, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 4, 10, 07, 00, 00), End = new DateTime(2021, 4, 10, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 580, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 4, 11, 12, 15, 00), End = new DateTime(2021, 4, 11, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 581, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 4, 12, 12, 15, 00), End = new DateTime(2021, 4, 12, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 582, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 4, 13, 12, 15, 00), End = new DateTime(2021, 4, 13, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 583, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 4, 16, 12, 15, 00), End = new DateTime(2021, 4, 16, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 584, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 4, 17, 12, 00, 00), End = new DateTime(2021, 4, 17, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 585, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 4, 18, 07, 15, 00), End = new DateTime(2021, 4, 18, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 586, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 4, 19, 07, 15, 00), End = new DateTime(2021, 4, 19, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 587, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 4, 20, 07, 00, 00), End = new DateTime(2021, 4, 20, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 588, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 4, 22, 12, 15, 00), End = new DateTime(2021, 4, 22, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 589, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 4, 23, 12, 15, 00), End = new DateTime(2021, 4, 23, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 590, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 4, 24, 12, 15, 00), End = new DateTime(2021, 4, 24, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 591, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 4, 25, 12, 15, 00), End = new DateTime(2021, 4, 25, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 592, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 4, 28, 12, 00, 00), End = new DateTime(2021, 4, 28, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 593, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 4, 29, 12, 00, 00), End = new DateTime(2021, 4, 29, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 3, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 594, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 4, 30, 12, 00, 00), End = new DateTime(2021, 4, 30, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 3, Status = WorkStatus.Work, Description = "No Description"},
            #endregion

            /// ============================================== 05/2021 ========================================================
            #region

            new EmployeeEvent { EventID = 595, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 5, 1, 13, 00, 00), End = new DateTime(2021, 5, 1, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 596, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 5, 2, 13, 00, 00), End = new DateTime(2021, 5, 2, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 597, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 5, 3, 07, 15, 00), End = new DateTime(2021, 5, 3, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 598, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 5, 4, 07, 15, 00), End = new DateTime(2021, 5, 4, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 599, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 5, 5, 07, 15, 00), End = new DateTime(2021, 5, 5, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 600, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 5, 6, 07, 15, 00), End = new DateTime(2021, 5, 6, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent {EventID = 601, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 5, 8, 07, 15, 00), End = new DateTime(2021, 5, 8, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 602, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 5, 9, 07, 15, 00), End = new DateTime(2021, 5, 9, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 603, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 5, 11, 07, 00, 00), End = new DateTime(2021, 5, 11, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 604, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 5, 12, 12, 15, 00), End = new DateTime(2021, 5, 12, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 605, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 5, 13, 12, 15, 00), End = new DateTime(2021, 5, 13, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 606, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 5, 14, 07, 15, 00), End = new DateTime(2021, 5, 14, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent {EventID = 607, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 5, 15, 07, 15, 00), End = new DateTime(2021, 5, 15, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 608, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 5, 18, 07, 15, 00), End = new DateTime(2021, 5, 18, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 609, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 5, 19, 07, 00, 00), End = new DateTime(2021, 5, 19, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 610, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 5, 20, 12, 15, 00), End = new DateTime(2021, 5, 20, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 611, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 5, 21, 12, 15, 00), End = new DateTime(2021, 5, 21, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 612, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 5, 22, 12, 00, 00), End = new DateTime(2021, 5, 22, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 613, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 5, 24, 12, 00, 00), End = new DateTime(2021, 5, 24, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 614, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 5, 25, 08, 20, 00), End = new DateTime(2021, 5, 25, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 615, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 5, 26, 08, 00, 00), End = new DateTime(2021, 5, 26, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},
            
            new EmployeeEvent { EventID = 616, CompanyID = 1, Username = "SPlath",
                Start = new DateTime(2021, 5, 27, 08, 00, 00), End = new DateTime(2021, 5, 27, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            #endregion
        };

        internal static List<EmployeeEvent> GetData() => new Employee4EventData().EmployeeEvents;
    }
}
