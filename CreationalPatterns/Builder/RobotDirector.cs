using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Builder
{
    internal class RobotDirector
    {
        private IRobotBuilder _robotBuilder;

        public RobotDirector(IRobotBuilder robotBuilder)
        {
            _robotBuilder = robotBuilder;
        }

        public Robot CreateAssitantRobot()
        {
            _robotBuilder.Start();

            _robotBuilder.InstallNormalAI("NORM_AI_v23.03");
            _robotBuilder.InstallMedicSensor(true);
            _robotBuilder.InstallRepairTools(true);

            return _robotBuilder.Produce();
        }

        public Robot CreateCombatRobot()
        {
            _robotBuilder.Start();

            _robotBuilder.InstallCombatAI("COMB_AI_v12.54.01");
            _robotBuilder.InstallRocketLauncher(15);
            _robotBuilder.InstallLaserGun(100);
            _robotBuilder.InstallHeavyShield(true);

            return _robotBuilder.Produce();
        }
    }
}
