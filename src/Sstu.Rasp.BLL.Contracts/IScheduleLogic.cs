using Sstu.Rasp.Entities;
using System;

namespace Sstu.Rasp.BLL.Contracts
{
    public interface IScheduleLogic
    {
        GroupSchedule GetByGroupId(int id);

        object GetByTeacherId(int id);

        object GetByRoomId(int id);
    }
}