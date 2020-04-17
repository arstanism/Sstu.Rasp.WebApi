using Sstu.Rasp.Entities;
using System;

namespace Sstu.Rasp.DAL.Contracts
{
    public interface IScheduleDao
    {
        GroupSchedule GetByGroupId(int id);



    }
}
