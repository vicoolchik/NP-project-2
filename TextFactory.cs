using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1_
{
    public class TextFactory : IFactory
    {

        public DroneRepesitory GetDroneRepository()
        {
            return new DroneRepesitory();
        }
        public IRepository<Robot> GetRobotRepository()
        {
            return new TextRepository<Robot>();
        }

    }
}

