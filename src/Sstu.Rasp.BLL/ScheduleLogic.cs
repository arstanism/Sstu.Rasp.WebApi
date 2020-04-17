using Sstu.Rasp.BLL.Contracts;
using Sstu.Rasp.DAL.Contracts;
using Sstu.Rasp.Entities;
using System;

namespace Sstu.Rasp.BLL
{
    public class ScheduleLogic : IScheduleLogic
    {
        private readonly IScheduleDao _dao;

        public ScheduleLogic(IScheduleDao dao)
        {
            _dao = dao;
        }

        public GroupSchedule GetByGroupId(int id)
        {
            if (id < 1)
            {
                throw new ArgumentException(nameof(id));
            }

            return _dao.GetByGroupId(id);
        }

        public object GetByRoomId(int id)
        {
            throw new NotImplementedException();
        }

        public object GetByTeacherId(int id)
        {
            throw new NotImplementedException();
        }
    }
}