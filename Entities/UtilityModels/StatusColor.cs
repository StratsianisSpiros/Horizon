using System.Collections.Generic;
/// <summary>
/// Utility model for Employee events to set Work Status with display color on calendar and relate them
/// </summary>
namespace Entities.UtilityModels
{   
    /// <summary>
    /// <see cref="WorkStatus"/> must match with <see cref="StatusColor"/>
    /// </summary>
    public enum WorkStatus { Work, Absent, Holiday, Other}

    public class StatusColor
    {
        public string Status { get; private set; }
        public string Color { get; private set; }

        /// <summary>
        /// Method to relate <see cref="WorkStatus"/> with given colors
        /// </summary>
        /// <param name="color"></param>
        /// <returns><see cref="WorkStatus"/></returns>
        public static WorkStatus MapColorToStatus(string color)
        {
            switch (color)
            {
                case "#00d5af": return WorkStatus.Work;
                case "#ea6a47": return WorkStatus.Absent;
                case "#0091d5": return WorkStatus.Holiday;
                case "#7e909a": return WorkStatus.Other;
                default: return WorkStatus.Other;
            }
        }

        /// <summary>
        /// List to set <see cref="Status"/> with <see cref="Color"/> 
        /// </summary>
        /// <returns>A List&lt;<see cref="StatusColor"/>&gt;</returns>
        public static List<StatusColor> GetStatusColors() => new List<StatusColor>()
        {
                new StatusColor {Status="Work", Color="#00d5af"},
                new StatusColor {Status="Absent", Color="#ea6a47"},
                new StatusColor {Status="Holiday", Color="#0091d5"},
                new StatusColor {Status="Other", Color="#7e909a"}
        };
    }
}
