using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Builder
{
    internal interface IRobotBuilder
    {
        public Robot Start();//Start construction
        public Robot Produce();//Fabricate and return result
        //---------Normal elements
        public Robot InstallNormalAI(string version);
        public Robot InstallRepairTools(bool haveRepairtools);
        public Robot InstallMedicSensor(bool haveMedicSensor);

        //-------------------------Combat elements
        public Robot InstallCombatAI(string version);
        public Robot InstallHeavyShield(bool haveHeavyShild);
        public Robot InstallRocketLauncher(int ammoQty);
        public Robot InstallLaserGun(int powerLvl);
    }
}
