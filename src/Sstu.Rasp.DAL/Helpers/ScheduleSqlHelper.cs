using Sstu.Rasp.Entities;
using Sstu.Rasp.Entities.Enums;
using System.Data.SqlClient;

namespace Sstu.Rasp.DAL.Helpers
{
    public static class ScheduleSqlHelper
    {
        public static LessonSqlEntity ReadLesson(this SqlDataReader reader)
        {
            return new LessonSqlEntity
            {
                Id = reader.GetIntValue("Id"),
                Title = reader["Title"].ToString(),
                TeacherId = reader.GetIntValue("TeacherId"),
                TeacherFirstName = reader["TeacherFirstName"].ToString(),
                TeacherLastName = reader["TeacherLastName"].ToString(),
                TeacherPatronymic = reader["TeacherPatronymic"].ToString(),
                IsEven = reader.GetBoolValue("IsEven"),
                DayWeek = (DaysWeek) reader.GetIntValue("DayWeek"),
                BuildingNumber = reader.GetIntValue("Building"),
                RoomNumber = reader.GetIntValue("Room"),
                SubRoom = reader["SubRoom"].ToString(),
                LessonNumber = reader.GetIntValue("LessonNumber"),
                DateFrom = reader.GetDateValue("DateFrom"),
                DateTo = reader.GetDateValue("DateTo"),
                LessonType = reader["LessonType"].ToString()
            };
        }

        public static Exam ReadExam(this SqlDataReader reader)
        {
            return new Exam
            {
                Id = reader.GetIntValue("Id"),
                Title = reader["Title"].ToString(),
                TeacherId = reader.GetIntValue("TeacherId"),
                TeacherFirstName = reader["TeacherFirstName"].ToString(),
                TeacherLastName = reader["TeacherLastName"].ToString(),
                TeacherPatronymic = reader["TeacherPatronymic"].ToString(),
                ExamDuration = reader.GetIntValue("ExamDuration"),
                ExamType = reader["ExamType"].ToString(),
                BuildingNumber = reader.GetIntValue("Building"),
                RoomNumber = reader.GetIntValue("Room"),
                SubRoom = reader["SubRoom"].ToString(),
                LessonNumber = reader.GetIntValue("LessonNumber"),
                ExamDate = reader.GetDateValue("ExamDate"),
            };
        }
    
        public static Lesson MapToLesson(this LessonSqlEntity entity)
        {
            return new Lesson
            {
                Id = entity.Id,
                BuildingNumber = entity.BuildingNumber,
                DateFrom = entity.DateFrom,
                DateTo = entity.DateTo,
                LessonNumber = entity.LessonNumber,
                LessonType = entity.LessonType,
                RoomNumber = entity.RoomNumber,
                SubRoom = entity.SubRoom,
                TeacherFirstName = entity.TeacherFirstName,
                TeacherLastName = entity.TeacherLastName,
                TeacherPatronymic = entity.TeacherPatronymic,
                TeacherId = entity.TeacherId,
                Title = entity.Title
            };
        }
    }
}
