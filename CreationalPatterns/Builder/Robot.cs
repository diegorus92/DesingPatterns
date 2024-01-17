using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Builder
{
    internal class Robot
    {
        public string NormalAI { get; set; } = "None";
        public string CombatAI { get; set; } = "None";
        public bool RepairTools { get; set; }
        public bool MedicSensor { get; set; }
        public bool HeavyShield { get; set; }
        public int RocketLauncher { get; set; }
        public int LaserGun { get; set; }



        public override string ToString()
        {
            return $"Normal AI: {NormalAI}\nCombat AI: {CombatAI}\nUse Repair Tools?: {RepairTools}" +
                $"\nUse Medic Sensor?: {MedicSensor}\nHeavy Shield: {HeavyShield}\nRocket Launcher ammo: {RocketLauncher}" +
                $"\nLaser Gun: {LaserGun}\n";
        }

        public void ColorizedStringOutput(string inputString)
        {
            for(int i=0; i < inputString.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(inputString[i]);
                if (inputString[i] == ':')
                {
                    Console.ResetColor();
                    for(int j = i+1; j < inputString.Length; j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(inputString[j]);
                        if (inputString[j] == '\n')
                        {
                            Console.ResetColor();
                            i = j;
                            break;
                        }
                    }
                    
                }
            }

            Console.ResetColor();
        }
    }
}
