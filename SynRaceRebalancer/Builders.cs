using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SynRaceRebalancer.Settings;
using SynRaceRebalancer.Utils;

namespace SynRaceRebalancer.Builders
{

    

    public struct RaceObject
    {
        public string editorID;
        public string? newName;
        public string? aliases;
        public string? targetKeywords;

        public float attributeHealth;
        public float attributeMagicka;
        public float attributeStamina;

        public float baseCarryWeight;

        public float baseMass;

        public float accelerationRate;
        public float decelerationRate;

        public float attributeHealthRegen;
        public float attributeMagickaRegen;
        public float attributeStaminaRegen;

        public float unarmedDamage;
        public float unarmedReach;

        public bool canSwim;
        public bool regenCombatHP;

        public string? flagsToAdd;
        public string? flagsToRemove;

        public SkillList.Skills Skill0;
        public sbyte Skill0Boost;
        public SkillList.Skills Skill1;
        public sbyte Skill1Boost;
        public SkillList.Skills Skill2;
        public sbyte Skill2Boost;
        public SkillList.Skills Skill3;
        public sbyte Skill3Boost;
        public SkillList.Skills Skill4;
        public sbyte Skill4Boost;
        public SkillList.Skills Skill5;
        public sbyte Skill5Boost;
        public SkillList.Skills Skill6;
        public sbyte Skill6Boost;

        public RaceObject(string editorID,

                string? newName, string? aliases, string? targetKeywords,

                float attributeHealth, float attributeMagicka, float attributeStamina,

                float baseCarryWeight, float baseMass,

                float accelerationRate, float decelerationRate,

                float attributeHealthRegen, float attributeMagickaRegen, float attributeStaminaRegen,

                float unarmedDamage, float unarmedReach,

                bool canSwim, bool regenCombatHP,

                string? flagsToAdd, string? flagsToRemove,

                SkillList.Skills Skill0, sbyte Skill0Boost,
                SkillList.Skills Skill1, sbyte Skill1Boost,
                SkillList.Skills Skill2, sbyte Skill2Boost,
                SkillList.Skills Skill3, sbyte Skill3Boost,
                SkillList.Skills Skill4, sbyte Skill4Boost,
                SkillList.Skills Skill5, sbyte Skill5Boost,
                SkillList.Skills Skill6, sbyte Skill6Boost)
        {
            this.editorID = editorID;
            this.newName = newName;
            this.aliases = aliases;
            this.targetKeywords = targetKeywords;

            this.attributeHealth = attributeHealth;
            this.attributeMagicka = attributeMagicka;
            this.attributeStamina = attributeStamina;

            this.baseCarryWeight = baseCarryWeight;
            this.baseMass = baseMass;

            this.accelerationRate = accelerationRate;
            this.decelerationRate = decelerationRate;
            
            this.attributeHealthRegen = attributeHealthRegen;
            this.attributeMagickaRegen = attributeMagickaRegen;
            this.attributeStaminaRegen = attributeStaminaRegen;

            this.unarmedDamage = unarmedDamage;
            this.unarmedReach = unarmedReach;

            this.canSwim = canSwim;
            this.regenCombatHP = regenCombatHP;
            
            this.flagsToAdd = flagsToAdd;
            this.flagsToRemove = flagsToRemove;

            this.Skill0 = Skill0;
            this.Skill0Boost = Skill0Boost;
            this.Skill1 = Skill1;
            this.Skill1Boost = Skill1Boost;
            this.Skill2 = Skill2;
            this.Skill2Boost = Skill2Boost;
            this.Skill3 = Skill3;
            this.Skill3Boost = Skill3Boost;
            this.Skill4 = Skill4;
            this.Skill4Boost = Skill4Boost;
            this.Skill5 = Skill5;
            this.Skill5Boost = Skill5Boost;
            this.Skill6 = Skill6;
            this.Skill6Boost = Skill6Boost;
        }
    }
}
