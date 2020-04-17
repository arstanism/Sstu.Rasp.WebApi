using Sstu.Rasp.Entities.Enums;
using System;

namespace Sstu.Rasp.Entities
{
    /// <summary>
    /// Вспомогательная сущность для маппинга из БД в UI
    /// </summary>
    public class LessonSqlEntity : Lesson
    {
        public bool IsEven { get; set; }

        public DaysWeek DayWeek { get; set; }
    }
}
