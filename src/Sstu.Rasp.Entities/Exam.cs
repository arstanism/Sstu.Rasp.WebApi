using System;

namespace Sstu.Rasp.Entities
{
    public class Exam : BaseDiscipline
    {
        /// <summary>
        /// Дата экзамена
        /// </summary>
        public DateTime ExamDate { get; set; }

        /// <summary>
        /// Тип экзамена (экз/зач)
        /// </summary>
        public string ExamType { get; set; }

        /// <summary>
        /// Продолжительность экзамена/зачета в парах
        /// </summary>
        public int ExamDuration { get; set; }
    }
}
