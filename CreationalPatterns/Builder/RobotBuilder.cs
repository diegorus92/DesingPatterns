using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Builder
{
    internal class RobotBuilder : IRobotBuilder
    {
        private Robot? robot;


        public Robot Start()//Start creation. Reset Robot object to a new build
        {
            robot = new Robot();
            return robot;
        }

        public Robot Produce()//Finish creation
        {
            return robot;
        }

       

        public Robot InstallCombatAI(string version)
        {
            robot.CombatAI = version;
            return robot;
        }

        public Robot InstallHeavyShield(bool haveHeavyShield)
        {
            robot.HeavyShield = haveHeavyShield;
            return robot;
        }

        public Robot InstallLaserGun(int powerLvl)
        {
            robot.LaserGun = powerLvl;
            return robot;
        }

        public Robot InstallMedicSensor(bool haveMedicSensor)
        {
            robot.MedicSensor = haveMedicSensor;
            return robot;
        }

        public Robot InstallNormalAI(string version)
        {
            robot.NormalAI = version;
            return robot;
        }

        public Robot InstallRepairTools(bool haveRepairtools)
        {
            robot.RepairTools = haveRepairtools;
            return robot;
        }

        public Robot InstallRocketLauncher(int ammoQty)
        {
            robot.RocketLauncher = ammoQty;
            return robot;
        }
    }
}
