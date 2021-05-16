using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynRaceRebalancer.Utils
{
    public static class Logger
    {
        public static void Log(string inputString)
        {

            string indent = "--> ";
            string final = indent + inputString;
            Console.WriteLine(final);
        }
        public static void LogHR()
        {
            string horizontal_rule = "##########################################################################";
            Console.WriteLine(horizontal_rule);
        }
        public static void LogError(Exception e)
        {
            Console.WriteLine(e);
            throw e;
        }
    }
    public class SkillList
    {
        public enum Skills
        {
            None = -1,
            OneHanded = 6,
            TwoHanded = 7,
            Archery = 8,
            Block = 9,
            Smithing = 10,
            HeavyArmor = 11,
            LightArmor = 12,
            Pickpocket = 13,
            Lockpicking = 14,
            Sneak = 15,
            Alchemy = 16,
            Speech = 17,
            Alteration = 18,
            Conjuration = 19,
            Destruction = 20,
            Illusion = 21,
            Restoration = 22,
            Enchanting = 23
        }
    }
}
