using System;
using System.Collections.Generic;
using System.Text;

namespace Sstu.Rasp.Entities
{
    public class BaseDiscipline : BaseEntityWithTitle
    {
        /// <summary>
        /// Идентификатор преподавателя
        /// </summary>
        public int TeacherId { get; set; }

        /// <summary>
        /// Имя преподавателя
        /// </summary>
        public string TeacherFirstName { get; set; }

        /// <summary>
        /// Фамилия преподавателя
        /// </summary>
        public string TeacherLastName { get; set; }

        /// <summary>
        /// Отчество преподавателя
        /// </summary>
        public string TeacherPatronymic { get; set; }
        
        /// <summary>
        /// Номер корпуса, где будет проходить занятие
        /// </summary>
        public int BuildingNumber { get; set; }

        /// <summary>
        /// Номер аудитории
        /// </summary>
        public int RoomNumber { get; set; }

        /// <summary>
        /// Буква(-ы) аудитории
        /// </summary>
        public string SubRoom { get; set; }

        /// <summary>
        /// Номер пары по порядку
        /// </summary>
        public int LessonNumber { get; set; }
    }
}
