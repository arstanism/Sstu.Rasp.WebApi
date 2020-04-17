using Newtonsoft.Json;
using Sstu.Rasp.Entities.Enums;
using System.Collections.Generic;

namespace Sstu.Rasp.Entities
{
    public class GroupSchedule
    {
        /// <summary>
        /// Расписание по дням для четной недели
        /// </summary>
        [JsonProperty("EvenWeek")]
        public Dictionary<DaysWeek, IEnumerable<Lesson>> EvenWeek { get; set; }
        /// <summary>
        /// Расписание по дням для нечетной недели
        /// </summary>
        [JsonProperty("OstWeek")]
        public Dictionary<DaysWeek, IEnumerable<Lesson>> OstWeek { get; set; }

        /// <summary>
        /// Список экзаменов
        /// </summary>
        [JsonProperty("Exams", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Exam> Exams { get; set; }
    }
}