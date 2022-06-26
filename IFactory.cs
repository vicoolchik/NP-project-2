using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1_
{
    public interface IFactory
    {
        DroneRepesitory GetDroneRepository();
        IRepository<Robot> GetRobotRepository();
    }
}
