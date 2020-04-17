using Sstu.Rasp.Entities.Bases;
using System;

namespace Sstu.Rasp.Entities
{
    /// <summary>
    /// Занятие, содержит полную информацию о проводимом занятии
    /// </summary>
    public class Lesson : BaseDiscipline
    {
        /// <summary>
        /// Дата старта текущего занятия в семесте
        /// </summary>
        public DateTime DateFrom { get; set; }

        /// <summary>
        /// Дата окончания текущиго занятия в семесте
        /// </summary>
        public DateTime DateTo { get; set; }

        /// <summary>
        /// Тип занятия
        /// </summary>
        public string LessonType { get; set; }
    }
}