using Entities.Models;
using Entities.UtilityModels;
using System;
using System.Collections.Generic;

namespace Repositories.Data
{
    public class Employee5EventData
    {
        private List<EmployeeEvent> EmployeeEvents = new List<EmployeeEvent>
       {
            //// COMPANY 1
            //// Employee 5
            /// ============================================== 11/2020 ========================================================
            #region
            new EmployeeEvent { EventID = 617, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 11, 2, 07, 15, 00), End = new DateTime(2020, 11, 2, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 618, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 11, 3, 07, 00, 00), End = new DateTime(2020, 11, 3, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 619, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 11, 4, 07, 15, 00), End = new DateTime(2020, 11, 4, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 620, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 11, 5, 07, 15, 00), End = new DateTime(2020, 11, 5, 15, 15, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 621, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 11, 8, 12, 00, 00), End = new DateTime(2020, 11, 8, 18, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 622, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 11, 10, 08, 20, 00), End = new DateTime(2020, 11, 10, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 623, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 11, 12, 08, 00, 00), End = new DateTime(2020, 11, 12, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 624, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 11, 13, 12, 15, 00), End = new DateTime(2020, 11, 13, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 625, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 11, 14, 12, 00, 00), End = new DateTime(2020, 11, 14, 18, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 626, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 11, 16, 08, 20, 00), End = new DateTime(2020, 11, 16, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 627, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 11, 17, 08, 00, 00), End = new DateTime(2020, 11, 17, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 628, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 11, 18, 12, 15, 00), End = new DateTime(2020, 11, 18, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 629, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 11, 19, 12, 00, 00), End = new DateTime(2020, 11, 19, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 630, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 11, 20, 07, 00, 00), End = new DateTime(2020, 11, 20, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 631, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 11, 21, 12, 15, 00), End = new DateTime(2020, 11, 21, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 632, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 11, 22, 12, 00, 00), End = new DateTime(2020, 11, 22, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 633, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 11, 23, 07, 15, 00), End = new DateTime(2020, 11, 23, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 634, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 11, 24, 07, 00, 00), End = new DateTime(2020, 11, 24, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 635, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 11, 25, 12, 15, 00), End = new DateTime(2020, 11, 25, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 636, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 11, 26, 12, 15, 00), End = new DateTime(2020, 11, 26, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 637, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 11, 28, 07, 15, 00), End = new DateTime(2020, 11, 28, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 638, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 11, 29, 12, 00, 00), End = new DateTime(2020, 11, 29, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},
            #endregion

            /// ============================================== 12/2020 ========================================================
            #region
            new EmployeeEvent { EventID = 639, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 12, 3, 07, 15, 00), End = new DateTime(2020, 12, 3, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 640, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 12, 4, 07, 15, 00), End = new DateTime(2020, 12, 4, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 641, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 12, 5, 07, 15, 00), End = new DateTime(2020, 12, 5, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 642, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 12, 6, 07, 15, 00), End = new DateTime(2020, 12, 6, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 643, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 12, 7, 07, 15, 00), End = new DateTime(2020, 12, 7, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 644, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 12, 9, 07, 15, 00), End = new DateTime(2020, 12, 9, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 645, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 12, 12, 12, 00, 00), End = new DateTime(2020, 12, 12, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 646, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 12, 13, 08, 20, 00), End = new DateTime(2020, 12, 13, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 647, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 12, 14, 08, 00, 00), End = new DateTime(2020, 12, 14, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 648, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 12, 15, 08, 00, 00), End = new DateTime(2020, 12, 15, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 649, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 12, 16, 08, 20, 00), End = new DateTime(2020, 12, 16, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 650, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 12, 18, 08, 00, 00), End = new DateTime(2020, 12, 18, 13, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 651, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 12, 19, 13, 00, 00), End = new DateTime(2020, 12, 19, 21, 30, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 652, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 12, 20, 13, 00, 00), End = new DateTime(2020, 12, 20, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 653, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 12, 21, 13, 00, 00), End = new DateTime(2020, 12, 21, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 654, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 12, 22, 12, 00, 00), End = new DateTime(2020, 12, 22, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 655, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 12, 25, 12, 00, 00), End = new DateTime(2020, 12, 25, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 3, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 656, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 12, 26, 08, 00, 00), End = new DateTime(2020, 12, 26, 13, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 657, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 12, 27, 13, 00, 00), End = new DateTime(2020, 12, 27, 21, 30, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 658, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 12, 28, 13, 00, 00), End = new DateTime(2020, 12, 28, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 659, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 12, 29, 13, 00, 00), End = new DateTime(2020, 12, 29, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 660, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2020, 12, 30, 12, 00, 00), End = new DateTime(2020, 12, 30, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},
            #endregion

            /// ============================================== 01/2021 ========================================================
            #region
            new EmployeeEvent { EventID = 661, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 1, 2, 07, 15, 00), End = new DateTime(2021, 1, 2, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 662, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 1, 3, 07, 15, 00), End = new DateTime(2021, 1, 3, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 663, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 1, 4, 07, 15, 00), End = new DateTime(2021, 1, 4, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 664, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 1, 5, 07, 15, 00), End = new DateTime(2021, 1, 5, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 665, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 1, 7, 07, 15, 00), End = new DateTime(2021, 1, 7, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 666, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 1, 8, 07, 15, 00), End = new DateTime(2021, 1, 8, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 667, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 1, 9, 12, 00, 00), End = new DateTime(2021, 1, 9, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 668, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 1, 10, 08, 00, 00), End = new DateTime(2021, 1, 10, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 669, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 1, 12, 08, 20, 00), End = new DateTime(2021, 1, 12, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 670, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 1, 13, 08, 20, 00), End = new DateTime(2021, 1, 13, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 671, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 1, 14, 08, 00, 00), End = new DateTime(2021, 1, 14, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 672, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 1, 15, 13, 00, 00), End = new DateTime(2021, 1, 15, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 673, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 1, 17, 13, 00, 00), End = new DateTime(2021, 1, 17, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 674, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 1, 18, 13, 00, 00), End = new DateTime(2021, 1, 18, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 675, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 1, 20, 08, 20, 00), End = new DateTime(2021, 1, 20, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 676, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 1, 21, 08, 00, 00), End = new DateTime(2021, 1, 21, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 677, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 1, 22, 13, 00, 00), End = new DateTime(2021, 1, 22, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 678, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 1, 23, 13, 00, 00), End = new DateTime(2021, 1, 23, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 679, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 1, 25, 13, 00, 00), End = new DateTime(2021, 1, 25, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 680, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 1, 26, 07, 15, 00), End = new DateTime(2021, 1, 26, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 681, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 1, 27, 07, 15, 00), End = new DateTime(2021, 1, 27, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 682, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 1, 28, 07, 15, 00), End = new DateTime(2021, 1, 28, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},
            #endregion

            /// ============================================== 02/2021 ========================================================
            #region
            new EmployeeEvent { EventID = 683, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 2, 2, 07, 15, 00), End = new DateTime(2021, 2, 2, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 684, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 2, 3, 07, 15, 00), End = new DateTime(2021, 2, 3, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 685, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 2, 5, 07, 15, 00), End = new DateTime(2021, 2, 5, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 686, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 2, 6, 07, 15, 00), End = new DateTime(2021, 2, 6, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 687, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 2, 7, 07, 15, 00), End = new DateTime(2021, 2, 7, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 688, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 2, 9, 07, 00, 00), End = new DateTime(2021, 2, 9, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 689, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 2, 10, 07, 15, 00), End = new DateTime(2021, 2, 10, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 690, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 2, 11, 07, 15, 00), End = new DateTime(2021, 2, 11, 15, 15, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 691, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 2, 12, 07, 15, 00), End = new DateTime(2021, 2, 12, 15, 15, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 692, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 2, 13, 07, 15, 00), End = new DateTime(2021, 2, 13, 15, 15, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 693, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 2, 15, 12, 00, 00), End = new DateTime(2021, 2, 15, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 694, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 2, 16, 07, 15, 00), End = new DateTime(2021, 2, 16, 15, 15, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 695, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 2, 17, 12, 00, 00), End = new DateTime(2021, 2, 17, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 696, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 2, 18, 12, 00, 00), End = new DateTime(2021, 2, 18, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 3, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 697, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 2, 19, 12, 00, 00), End = new DateTime(2021, 2, 19, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 698, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 2, 20, 12, 00, 00), End = new DateTime(2021, 2, 20, 18, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 699, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 2, 23, 08, 00, 00), End = new DateTime(2021, 2, 23, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 700, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 2, 24, 08, 20, 00), End = new DateTime(2021, 2, 24, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 701, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 2, 25, 08, 00, 00), End = new DateTime(2021, 2, 25, 13, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 702, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 2, 26, 13, 00, 00), End = new DateTime(2021, 2, 26, 21, 30, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 703, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 2, 27, 13, 00, 00), End = new DateTime(2021, 2, 27, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 704, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 2, 28, 13, 00, 00), End = new DateTime(2021, 2, 28, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},
            #endregion

            /// ============================================== 03/2021 ========================================================
            #region
            new EmployeeEvent { EventID = 705, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 3, 01, 08, 20, 00), End = new DateTime(2021, 3, 01, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 706, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 3, 02, 08, 00, 00), End = new DateTime(2021, 3, 02, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 707, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 3, 03, 08, 00, 00), End = new DateTime(2021, 3, 03, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 708, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 3, 04, 08, 20, 00), End = new DateTime(2021, 3, 04, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 709, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 3, 05, 08, 00, 00), End = new DateTime(2021, 3, 05, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 710, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 3, 6, 13, 00, 00), End = new DateTime(2021, 3, 6, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 711, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 3, 7, 13, 00, 00), End = new DateTime(2021, 3, 7, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 712, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 3, 9, 13, 00, 00), End = new DateTime(2021, 3, 9, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 713, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 3, 10, 07, 15, 00), End = new DateTime(2021, 3, 10, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 714, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 3, 11, 07, 15, 00), End = new DateTime(2021, 3, 11, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 715, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 3, 12, 07, 15, 00), End = new DateTime(2021, 3, 12, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 716, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 3, 15, 07, 15, 00), End = new DateTime(2021, 3, 15, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 717, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 3, 16, 07, 00, 00), End = new DateTime(2021, 3, 16, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 718, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 3, 17, 12, 15, 00), End = new DateTime(2021, 3, 17, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 719, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 3, 18, 12, 15, 00), End = new DateTime(2021, 3, 18, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 720, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 3, 20, 12, 15, 00), End = new DateTime(2021, 3, 20, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 721, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 3, 21, 08, 20, 00), End = new DateTime(2021, 3, 21, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 722, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 3, 22, 08, 00, 00), End = new DateTime(2021, 3, 22, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 723, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 3, 24, 08, 00, 00), End = new DateTime(2021, 3, 24, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 724, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 3, 26, 08, 20, 00), End = new DateTime(2021, 3, 26, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 725, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 3, 28, 08, 00, 00), End = new DateTime(2021, 3, 28, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 726, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 3, 29, 13, 00, 00), End = new DateTime(2021, 3, 29, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},
            #endregion

            /// ============================================== 04/2021 ========================================================
            #region
            new EmployeeEvent { EventID = 727, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 4, 2, 07, 15, 00), End = new DateTime(2021, 4, 2, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 728, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 4, 3, 07, 15, 00), End = new DateTime(2021, 4, 3, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 729, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 4, 4, 07, 15, 00), End = new DateTime(2021, 4, 4, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 730, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 4, 5, 07, 15, 00), End = new DateTime(2021, 4, 5, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 731, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 4, 6, 07, 15, 00), End = new DateTime(2021, 4, 6, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 732, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 4, 7, 07, 15, 00), End = new DateTime(2021, 4, 7, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 733, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 4, 10, 07, 00, 00), End = new DateTime(2021, 4, 10, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 734, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 4, 11, 12, 15, 00), End = new DateTime(2021, 4, 11, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 735, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 4, 12, 12, 15, 00), End = new DateTime(2021, 4, 12, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 736, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 4, 13, 12, 15, 00), End = new DateTime(2021, 4, 13, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 737, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 4, 15, 12, 15, 00), End = new DateTime(2021, 4, 15, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 738, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 4, 16, 12, 15, 00), End = new DateTime(2021, 4, 16, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 739, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 4, 17, 12, 00, 00), End = new DateTime(2021, 4, 17, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 740, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 4, 18, 07, 15, 00), End = new DateTime(2021, 4, 18, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 741, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 4, 19, 07, 15, 00), End = new DateTime(2021, 4, 19, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 742, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 4, 20, 07, 00, 00), End = new DateTime(2021, 4, 20, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 743, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 4, 22, 12, 15, 00), End = new DateTime(2021, 4, 22, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 744, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 4, 23, 12, 15, 00), End = new DateTime(2021, 4, 23, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 745, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 4, 24, 12, 15, 00), End = new DateTime(2021, 4, 24, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 746, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 4, 25, 12, 15, 00), End = new DateTime(2021, 4, 25, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 747, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 4, 28, 12, 00, 00), End = new DateTime(2021, 4, 28, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 748, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 4, 30, 12, 00, 00), End = new DateTime(2021, 4, 30, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 3, Status = WorkStatus.Work, Description = "No Description"},
            #endregion

            /// ============================================== 05/2021 ========================================================
            #region

            new EmployeeEvent { EventID = 749, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 5, 1, 13, 00, 00), End = new DateTime(2021, 5, 1, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 750, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 5, 2, 13, 00, 00), End = new DateTime(2021, 5, 2, 21, 30, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 751, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 5, 3, 07, 15, 00), End = new DateTime(2021, 5, 3, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 752, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 5, 4, 07, 15, 00), End = new DateTime(2021, 5, 4, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 753, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 5, 5, 07, 15, 00), End = new DateTime(2021, 5, 5, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 754, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 5, 6, 07, 15, 00), End = new DateTime(2021, 5, 6, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent {EventID = 755, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 5, 8, 07, 15, 00), End = new DateTime(2021, 5, 8, 15, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 756, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 5, 9, 07, 15, 00), End = new DateTime(2021, 5, 9, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 2, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 757, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 5, 11, 07, 00, 00), End = new DateTime(2021, 5, 11, 16, 00, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 758, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 5, 12, 12, 15, 00), End = new DateTime(2021, 5, 12, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 1, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 759, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 5, 13, 12, 15, 00), End = new DateTime(2021, 5, 13, 18, 15, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 760, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 5, 14, 12, 00, 00), End = new DateTime(2021, 5, 14, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 761, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 5, 15, 12, 00, 00), End = new DateTime(2021, 5, 16, 18, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 762, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 5, 17, 08, 20, 00), End = new DateTime(2021, 5, 17, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 763, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 5, 18, 08, 00, 00), End = new DateTime(2021, 5, 18, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 764, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 5, 20, 08, 00, 00), End = new DateTime(2021, 5, 20, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 765, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 5, 21, 08, 20, 00), End = new DateTime(2021, 5, 21, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            new EmployeeEvent { EventID = 766, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 5, 23, 08, 00, 00), End = new DateTime(2021, 5, 23, 13, 40, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 767, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 5, 24, 13, 00, 00), End = new DateTime(2021, 5, 24, 21, 30, 00),
                IsFullDay = false, Color = "#0091d5", Overtime = 0, Status = WorkStatus.Holiday, Description = "No Description"},

            new EmployeeEvent { EventID = 768, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 5, 25, 08, 20, 00), End = new DateTime(2021, 5, 25, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 769, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 5, 26, 08, 00, 00), End = new DateTime(2021, 5, 26, 13, 40, 00),
                IsFullDay = false, Color = "#ea6a47", Overtime = 0, Status = WorkStatus.Absent, Description = "No Description"},

            new EmployeeEvent { EventID = 770, CompanyID = 1, Username = "Beauvoir",
                Start = new DateTime(2021, 5, 27, 08, 00, 00), End = new DateTime(2021, 5, 27, 13, 40, 00),
                IsFullDay = false, Color = "#00d5af", Overtime = 0, Status = WorkStatus.Work, Description = "No Description"},

            #endregion
        };

        internal static List<EmployeeEvent> GetData() => new Employee5EventData().EmployeeEvents;
    }
}
