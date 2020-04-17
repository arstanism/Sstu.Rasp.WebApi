using Sstu.Rasp.DAL.Contracts;
using Sstu.Rasp.DAL.Helpers;
using Sstu.Rasp.Entities;
using Sstu.Rasp.Entities.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace Sstu.Rasp.DAL.Dao
{
    public class ScheduleDao : IScheduleDao
    {
        private readonly string _connectionString;

        public ScheduleDao(string connectionString)
        {
            _connectionString = connectionString;
        }

        public GroupSchedule GetByGroupId(int id)
        {
            var result = new GroupSchedule()
            {
                EvenWeek = new Dictionary<DaysWeek, IEnumerable<Lesson>>(),
                OstWeek = new Dictionary<DaysWeek, IEnumerable<Lesson>>()
            };

            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand("[dbo].[GetScheduleByGroupId]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.AddIdParameter("@Id", id);
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        // Считывание расписание занятий
                        var lessons = new List<LessonSqlEntity>();
                        while (reader.Read())
                        {
                            lessons.Add(reader.ReadLesson());
                        }

                        if (lessons.Count > 0)
                        {
                            result.EvenWeek = lessons.Where(l => l.IsEven).GroupBy(l => l.DayWeek).ToDictionary(g => g.Key, l => l.Select(l => l.MapToLesson()));
                            result.OstWeek = lessons.Where(l => !l.IsEven).GroupBy(l => l.DayWeek).ToDictionary(g => g.Key, l => l.Select(l => l.MapToLesson()));
                        }

                        if (reader.NextResult())
                        {
                            // Считывание расписания сессии, если оно заполнено 
                            var exams = new List<Exam>();
                            while (reader.Read())
                            {
                                exams.Add(reader.ReadExam());
                            }

                            result.Exams = exams;
                        }
                    }
                }
            }

            return result;
        }
    }
}
