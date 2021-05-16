using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mutagen.Bethesda.Synthesis.Settings;
using SynRaceRebalancer.Utils;

namespace SynRaceRebalancer
{
    public class SettingsPlayableRaces
    {
        [SynthesisOrder]
        public bool EnableModule = true;

        [SynthesisOrder]
        public General General = new();
        [SynthesisOrder]
        public GlobalRaceSettings GlobalRaceSettings = new();

        //Races
        [SynthesisOrder]
        public Altmer Altmer = new();
        [SynthesisOrder]
        public Argonian Argonian = new();
        [SynthesisOrder]
        public Bosmer Bosmer = new();
        [SynthesisOrder]
        public Breton Breton = new();
        [SynthesisOrder]
        public Cyrodiil Cyrodiil = new();
        [SynthesisOrder]
        public Dunmer Dunmer = new();
        [SynthesisOrder]
        public Khajiit Khajiit = new();
        [SynthesisOrder]
        public Nord Nord = new();
        [SynthesisOrder]
        public Orsimer Orsimer = new();
        [SynthesisOrder]
        public Redguard Redguard = new();
        [SynthesisOrder]
        public Elder Elder = new();
        [SynthesisOrder]
        public SnowElf SnowElf = new();
        [SynthesisOrder]
        public Dremora Dremora = new();
        [SynthesisOrder]
        public VampireLord VampireLord = new();
        [SynthesisOrder]
        public Werewolf Werewolf = new();
        [SynthesisOrder]
        public Werebear Werebear = new();
    }

    public class General
    {
        [SynthesisOrder]
        [SynthesisSettingName("Enable or Disable Stat Modifiers for Child and Vampire sub-races")]
        [SynthesisTooltip("Each race has special modifiers (that can be adjusted) for vamprie and child subraces. This turns the function on or off globally.")]
        public bool PlayableRaceVampireOrChildMod = true;
        [SynthesisOrder]
        [SynthesisSettingName("Enable or Disable Name Changes")]
        public bool PlayableRaceNameChanges = true;
        [SynthesisOrder]
        [SynthesisSettingName("Enable or Disable Stat Changes")]
        public bool PlayableRaceStatChanges = true;
        [SynthesisOrder]
        [SynthesisSettingName("Enable or Disable Skill Changes")]
        public bool PlayableRaceSkillChanges = true;
    }

    public class GlobalRaceSettings
    {
        [SynthesisOrder]
        public float VampirePercentHealth = 0.9f;
        [SynthesisOrder]
        public float VampirePercentStamina = 1.1f;
        [SynthesisOrder]
        public float VampirePercentMagicka = 1.0f;

        [SynthesisOrder]
        public float VampirePercentHealthRegen = 1.2f;
        [SynthesisOrder]
        public float VampirePercentStaminaRegen = 1.1f;
        [SynthesisOrder]
        public float VampirePercentMagickaRegen = 1.0f;

        [SynthesisOrder]
        public float VampirePercentCarryWeight = 1.1f;

        [SynthesisOrder]
        public float ChildPercentHealth = 0.6f;
        [SynthesisOrder]
        public float ChildPercentStamina = 1.2f;
        [SynthesisOrder]
        public float ChildPercentMagicka = 0.8f;

        [SynthesisOrder]
        public float ChildPercentHealthRegen = 1.3f;
        [SynthesisOrder]
        public float ChildPercentStaminaRegen = 1.5f;
        [SynthesisOrder]
        public float ChildPercentMagickaRegen = 1.2f;

        [SynthesisOrder]
        public float ChildPercentCarryWeight = 0.4f;
    }

    public class Altmer
    {
        public string editorID = "HighElfRace";
        public string? newName = "Altmer";
        public string? aliases = "Altmer";
        public string? targetKeywords = "ActorTypeNPC";

        public float attributeHealth = 50;
        public float attributeMagicka = 50;
        public float attributeStamina = 50;

        public float baseCarryWeight = 300;

        public float baseMass = 1.0f;

        public float accelerationRate = 1.0f;
        public float decelerationRate = 1.0f;

        public float attributeHealthRegen = 0.7f;
        public float attributeMagickaRegen = 3.0f;
        public float attributeStaminaRegen = 5.0f;

        public float unarmedDamage = 4.0f;
        public float unarmedReach = 96.0f;

        public bool canSwim = true;
        public bool regenCombatHP = false;

        public string? flagsToAdd = "";
        public string? flagsToRemove = "";

        public AltmerSkills Skills = new();
    }
    public class AltmerSkills
    {
        [SynthesisOrder]
        public SkillList.Skills Skill0 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill0Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill1 { get; set; } = (SkillList.Skills)18;
        [SynthesisOrder]
        public sbyte Skill1Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill2 { get; set; } = (SkillList.Skills)19;
        [SynthesisOrder]
        public sbyte Skill2Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill3 { get; set; } = (SkillList.Skills)20;
        [SynthesisOrder]
        public sbyte Skill3Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill4 { get; set; } = (SkillList.Skills)21;
        [SynthesisOrder]
        public sbyte Skill4Boost = 15;
        [SynthesisOrder]
        public SkillList.Skills Skill5 { get; set; } = (SkillList.Skills)22;
        [SynthesisOrder]
        public sbyte Skill5Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill6 { get; set; } = (SkillList.Skills)23;
        [SynthesisOrder]
        public sbyte Skill6Boost = 5;
    }

    public class Argonian
    {
        public string editorID = "ArgonianRace";
        public string? newName = "";
        public string? aliases = "";
        public string? targetKeywords = "ActorTypeNPC";

        public float attributeHealth = 50;
        public float attributeMagicka = 50;
        public float attributeStamina = 50;

        public float baseCarryWeight = 300;

        public float baseMass = 1.0f;

        public float accelerationRate = 1.0f;
        public float decelerationRate = 1.0f;

        public float attributeHealthRegen = 0.7f;
        public float attributeMagickaRegen = 3.0f;
        public float attributeStaminaRegen = 5.0f;

        public float unarmedDamage = 4.0f;
        public float unarmedReach = 96.0f;

        public bool canSwim = true;
        public bool regenCombatHP = false;

        public string? flagsToAdd = "";
        public string? flagsToRemove = "";

        public ArgonianSkills Skills = new();
    }
    public class ArgonianSkills
    {
        [SynthesisOrder]
        public SkillList.Skills Skill0 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill0Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill1 { get; set; } = (SkillList.Skills)12;
        [SynthesisOrder]
        public sbyte Skill1Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill2 { get; set; } = (SkillList.Skills)13;
        [SynthesisOrder]
        public sbyte Skill2Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill3 { get; set; } = (SkillList.Skills)14;
        [SynthesisOrder]
        public sbyte Skill3Boost = 15;
        [SynthesisOrder]
        public SkillList.Skills Skill4 { get; set; } = (SkillList.Skills)15;
        [SynthesisOrder]
        public sbyte Skill4Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill5 { get; set; } = (SkillList.Skills)18;
        [SynthesisOrder]
        public sbyte Skill5Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill6 { get; set; } = (SkillList.Skills)22;
        [SynthesisOrder]
        public sbyte Skill6Boost = 5;
    }

    public class Bosmer
    {
        public string editorID = "WoodElfRace";
        public string? newName = "Bosmer";
        public string? aliases = "Bosmer,WoodElf";
        public string? targetKeywords = "ActorTypeNPC";

        public float attributeHealth = 50;
        public float attributeMagicka = 50;
        public float attributeStamina = 50;

        public float baseCarryWeight = 300;

        public float baseMass = 1.0f;

        public float accelerationRate = 1.0f;
        public float decelerationRate = 1.0f;

        public float attributeHealthRegen = 0.7f;
        public float attributeMagickaRegen = 3.0f;
        public float attributeStaminaRegen = 5.0f;

        public float unarmedDamage = 4.0f;
        public float unarmedReach = 96.0f;

        public bool canSwim = true;
        public bool regenCombatHP = false;

        public string? flagsToAdd = "";
        public string? flagsToRemove = "";

        public BosmerSkills Skills = new();
    }
    public class BosmerSkills
    {
        [SynthesisOrder]
        public SkillList.Skills Skill0 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill0Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill1 { get; set; } = (SkillList.Skills)8;
        [SynthesisOrder]
        public sbyte Skill1Boost = 15;
        [SynthesisOrder]
        public SkillList.Skills Skill2 { get; set; } = (SkillList.Skills)12;
        [SynthesisOrder]
        public sbyte Skill2Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill3 { get; set; } = (SkillList.Skills)13;
        [SynthesisOrder]
        public sbyte Skill3Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill4 { get; set; } = (SkillList.Skills)14;
        [SynthesisOrder]
        public sbyte Skill4Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill5 { get; set; } = (SkillList.Skills)15;
        [SynthesisOrder]
        public sbyte Skill5Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill6 { get; set; } = (SkillList.Skills)16;
        [SynthesisOrder]
        public sbyte Skill6Boost = 5;
    }
    public class Breton
    {
        public string editorID = "BretonRace";
        public string? newName = "";
        public string? aliases = "Manmer,Breton,DA13AfflictedRace";
        public string? targetKeywords = "ActorTypeNPC";

        public float attributeHealth = 50;
        public float attributeMagicka = 50;
        public float attributeStamina = 50;

        public float baseCarryWeight = 300;

        public float baseMass = 1.0f;

        public float accelerationRate = 1.0f;
        public float decelerationRate = 1.0f;

        public float attributeHealthRegen = 0.7f;
        public float attributeMagickaRegen = 3.0f;
        public float attributeStaminaRegen = 5.0f;

        public float unarmedDamage = 4.0f;
        public float unarmedReach = 96.0f;

        public bool canSwim = true;
        public bool regenCombatHP = false;

        public string? flagsToAdd = "";
        public string? flagsToRemove = "";

        public BretonSkills Skills = new();
    }
    public class BretonSkills
    {
        [SynthesisOrder]
        public SkillList.Skills Skill0 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill0Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill1 { get; set; } = (SkillList.Skills)16;
        [SynthesisOrder]
        public sbyte Skill1Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill2 { get; set; } = (SkillList.Skills)17;
        [SynthesisOrder]
        public sbyte Skill2Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill3 { get; set; } = (SkillList.Skills)18;
        [SynthesisOrder]
        public sbyte Skill3Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill4 { get; set; } = (SkillList.Skills)19;
        [SynthesisOrder]
        public sbyte Skill4Boost = 15;
        [SynthesisOrder]
        public SkillList.Skills Skill5 { get; set; } = (SkillList.Skills)21;
        [SynthesisOrder]
        public sbyte Skill5Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill6 { get; set; } = (SkillList.Skills)22;
        [SynthesisOrder]
        public sbyte Skill6Boost = 5;
    }
    public class Cyrodiil
    {
        public string editorID = "ImperialRace";
        public string? newName = "Cyrodiil";
        public string? aliases = "Imperial,Cyrodiil";
        public string? targetKeywords = "ActorTypeNPC";

        public float attributeHealth = 50;
        public float attributeMagicka = 50;
        public float attributeStamina = 50;

        public float baseCarryWeight = 300;

        public float baseMass = 1.0f;

        public float accelerationRate = 1.0f;
        public float decelerationRate = 1.0f;

        public float attributeHealthRegen = 0.7f;
        public float attributeMagickaRegen = 3.0f;
        public float attributeStaminaRegen = 5.0f;

        public float unarmedDamage = 4.0f;
        public float unarmedReach = 96.0f;

        public bool canSwim = true;
        public bool regenCombatHP = false;

        public string? flagsToAdd = "";
        public string? flagsToRemove = "";

        public CyrodillSkills Skills = new();
    }
    public class CyrodillSkills
    {
        [SynthesisOrder]
        public SkillList.Skills Skill0 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill0Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill1 { get; set; } = (SkillList.Skills)6;
        [SynthesisOrder]
        public sbyte Skill1Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill2 { get; set; } = (SkillList.Skills)9;
        [SynthesisOrder]
        public sbyte Skill2Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill3 { get; set; } = (SkillList.Skills)11;
        [SynthesisOrder]
        public sbyte Skill3Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill4 { get; set; } = (SkillList.Skills)20;
        [SynthesisOrder]
        public sbyte Skill4Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill5 { get; set; } = (SkillList.Skills)22;
        [SynthesisOrder]
        public sbyte Skill5Boost = 15;
        [SynthesisOrder]
        public SkillList.Skills Skill6 { get; set; } = (SkillList.Skills)23;
        [SynthesisOrder]
        public sbyte Skill6Boost = 5;
    }
    public class Dunmer
    {
        public string editorID = "DarkElfRace";
        public string? newName = "Dunmer";
        public string? aliases = "Dunmer";
        public string? targetKeywords = "ActorTypeNPC";

        public float attributeHealth = 50;
        public float attributeMagicka = 50;
        public float attributeStamina = 50;

        public float baseCarryWeight = 300;

        public float baseMass = 1.0f;

        public float accelerationRate = 1.0f;
        public float decelerationRate = 1.0f;

        public float attributeHealthRegen = 0.7f;
        public float attributeMagickaRegen = 3.0f;
        public float attributeStaminaRegen = 5.0f;

        public float unarmedDamage = 4.0f;
        public float unarmedReach = 96.0f;

        public bool canSwim = true;
        public bool regenCombatHP = false;

        public string? flagsToAdd = "";
        public string? flagsToRemove = "";

        public DunmerSkills Skills = new();
    }
    public class DunmerSkills
    {
        [SynthesisOrder]
        public SkillList.Skills Skill0 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill0Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill1 { get; set; } = (SkillList.Skills)12;
        [SynthesisOrder]
        public sbyte Skill1Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill2 { get; set; } = (SkillList.Skills)15;
        [SynthesisOrder]
        public sbyte Skill2Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill3 { get; set; } = (SkillList.Skills)16;
        [SynthesisOrder]
        public sbyte Skill3Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill4 { get; set; } = (SkillList.Skills)18;
        [SynthesisOrder]
        public sbyte Skill4Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill5 { get; set; } = (SkillList.Skills)20;
        [SynthesisOrder]
        public sbyte Skill5Boost = 15;
        [SynthesisOrder]
        public SkillList.Skills Skill6 { get; set; } = (SkillList.Skills)21;
        [SynthesisOrder]
        public sbyte Skill6Boost = 5;
    }
    public class Khajiit
    {
        public string editorID = "KhajiitRace";
        public string? newName = "";
        public string? aliases = "Khajiit";
        public string? targetKeywords = "ActorTypeNPC";

        public float attributeHealth = 50;
        public float attributeMagicka = 50;
        public float attributeStamina = 50;

        public float baseCarryWeight = 300;

        public float baseMass = 1.0f;

        public float accelerationRate = 1.0f;
        public float decelerationRate = 1.0f;

        public float attributeHealthRegen = 0.7f;
        public float attributeMagickaRegen = 3.0f;
        public float attributeStaminaRegen = 5.0f;

        public float unarmedDamage = 4.0f;
        public float unarmedReach = 96.0f;

        public bool canSwim = true;
        public bool regenCombatHP = false;

        public string? flagsToAdd = "";
        public string? flagsToRemove = "";

        public KhajiitSkills Skills = new();
    }
    public class KhajiitSkills
    {
        [SynthesisOrder]
        public SkillList.Skills Skill0 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill0Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill1 { get; set; } = (SkillList.Skills)6;
        [SynthesisOrder]
        public sbyte Skill1Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill2 { get; set; } = (SkillList.Skills)8;
        [SynthesisOrder]
        public sbyte Skill2Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill3 { get; set; } = (SkillList.Skills)13;
        [SynthesisOrder]
        public sbyte Skill3Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill4 { get; set; } = (SkillList.Skills)14;
        [SynthesisOrder]
        public sbyte Skill4Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill5 { get; set; } = (SkillList.Skills)15;
        [SynthesisOrder]
        public sbyte Skill5Boost = 15;
        [SynthesisOrder]
        public SkillList.Skills Skill6 { get; set; } = (SkillList.Skills)16;
        [SynthesisOrder]
        public sbyte Skill6Boost = 5;
    }
    public class Nord
    {
        public string editorID = "NordRace";
        public string? newName = "";
        public string? aliases = "Nord,ManakinRace,DLC2MiraakRace";
        public string? targetKeywords = "ActorTypeNPC";

        public float attributeHealth = 50;
        public float attributeMagicka = 50;
        public float attributeStamina = 50;

        public float baseCarryWeight = 300;

        public float baseMass = 1.0f;

        public float accelerationRate = 1.0f;
        public float decelerationRate = 1.0f;

        public float attributeHealthRegen = 0.7f;
        public float attributeMagickaRegen = 3.0f;
        public float attributeStaminaRegen = 5.0f;

        public float unarmedDamage = 4.0f;
        public float unarmedReach = 96.0f;

        public bool canSwim = true;
        public bool regenCombatHP = false;

        public string? flagsToAdd = "";
        public string? flagsToRemove = "";

        public NordSkills Skills = new();
    }
    public class NordSkills
    {
        [SynthesisOrder]
        public SkillList.Skills Skill0 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill0Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill1 { get; set; } = (SkillList.Skills)6;
        [SynthesisOrder]
        public sbyte Skill1Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill2 { get; set; } = (SkillList.Skills)7;
        [SynthesisOrder]
        public sbyte Skill2Boost = 15;
        [SynthesisOrder]
        public SkillList.Skills Skill3 { get; set; } = (SkillList.Skills)9;
        [SynthesisOrder]
        public sbyte Skill3Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill4 { get; set; } = (SkillList.Skills)10;
        [SynthesisOrder]
        public sbyte Skill4Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill5 { get; set; } = (SkillList.Skills)12;
        [SynthesisOrder]
        public sbyte Skill5Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill6 { get; set; } = (SkillList.Skills)11;
        [SynthesisOrder]
        public sbyte Skill6Boost = 5;
    }
    public class Orsimer
    {
        public string editorID = "OrcRace";
        public string? newName = "Orsimer";
        public string? aliases = "";
        public string? targetKeywords = "ActorTypeNPC";

        public float attributeHealth = 50;
        public float attributeMagicka = 50;
        public float attributeStamina = 50;

        public float baseCarryWeight = 300;

        public float baseMass = 1.0f;

        public float accelerationRate = 1.0f;
        public float decelerationRate = 1.0f;

        public float attributeHealthRegen = 0.7f;
        public float attributeMagickaRegen = 3.0f;
        public float attributeStaminaRegen = 5.0f;

        public float unarmedDamage = 4.0f;
        public float unarmedReach = 96.0f;

        public bool canSwim = true;
        public bool regenCombatHP = false;

        public string? flagsToAdd = "";
        public string? flagsToRemove = "";

        public OrsimerSkills Skills = new();
    }
    public class OrsimerSkills
    {
        [SynthesisOrder]
        public SkillList.Skills Skill0 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill0Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill1 { get; set; } = (SkillList.Skills)6;
        [SynthesisOrder]
        public sbyte Skill1Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill2 { get; set; } = (SkillList.Skills)7;
        [SynthesisOrder]
        public sbyte Skill2Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill3 { get; set; } = (SkillList.Skills)9;
        [SynthesisOrder]
        public sbyte Skill3Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill4 { get; set; } = (SkillList.Skills)10;
        [SynthesisOrder]
        public sbyte Skill4Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill5 { get; set; } = (SkillList.Skills)11;
        [SynthesisOrder]
        public sbyte Skill5Boost = 15;
        [SynthesisOrder]
        public SkillList.Skills Skill6 { get; set; } = (SkillList.Skills)23;
        [SynthesisOrder]
        public sbyte Skill6Boost = 5;
    }
    public class Redguard
    {
        public string editorID = "RedguardRace";
        public string? newName = "";
        public string? aliases = "";
        public string? targetKeywords = "ActorTypeNPC";

        public float attributeHealth = 50;
        public float attributeMagicka = 50;
        public float attributeStamina = 50;

        public float baseCarryWeight = 300;

        public float baseMass = 1.0f;

        public float accelerationRate = 1.0f;
        public float decelerationRate = 1.0f;

        public float attributeHealthRegen = 0.7f;
        public float attributeMagickaRegen = 3.0f;
        public float attributeStaminaRegen = 5.0f;

        public float unarmedDamage = 4.0f;
        public float unarmedReach = 96.0f;

        public bool canSwim = true;
        public bool regenCombatHP = false;

        public string? flagsToAdd = "";
        public string? flagsToRemove = "";

        public RedguardSkills Skills = new();
    }
    public class RedguardSkills
    {
        [SynthesisOrder]
        public SkillList.Skills Skill0 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill0Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill1 { get; set; } = (SkillList.Skills)6;
        [SynthesisOrder]
        public sbyte Skill1Boost = 15;
        [SynthesisOrder]
        public SkillList.Skills Skill2 { get; set; } = (SkillList.Skills)8;
        [SynthesisOrder]
        public sbyte Skill2Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill3 { get; set; } = (SkillList.Skills)9;
        [SynthesisOrder]
        public sbyte Skill3Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill4 { get; set; } = (SkillList.Skills)10;
        [SynthesisOrder]
        public sbyte Skill4Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill5 { get; set; } = (SkillList.Skills)18;
        [SynthesisOrder]
        public sbyte Skill5Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill6 { get; set; } = (SkillList.Skills)20;
        [SynthesisOrder]
        public sbyte Skill6Boost = 5;
    }
    public class Elder
    {
        public string editorID = "ElderRace";
        public string? newName = "Old People";
        public string? aliases = "";
        public string? targetKeywords = "ActorTypeNPC";

        public float attributeHealth = 50;
        public float attributeMagicka = 50;
        public float attributeStamina = 50;

        public float baseCarryWeight = 300;

        public float baseMass = 1.0f;

        public float accelerationRate = 1.0f;
        public float decelerationRate = 1.0f;

        public float attributeHealthRegen = 0.7f;
        public float attributeMagickaRegen = 3.0f;
        public float attributeStaminaRegen = 5.0f;

        public float unarmedDamage = 4.0f;
        public float unarmedReach = 96.0f;

        public bool canSwim = true;
        public bool regenCombatHP = false;

        public string? flagsToAdd = "";
        public string? flagsToRemove = "";

        public ElderRace Skills = new();
    }
    public class ElderRace
    {
        [SynthesisOrder]
        public SkillList.Skills Skill0 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill0Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill1 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill1Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill2 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill2Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill3 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill3Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill4 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill4Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill5 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill5Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill6 { get; set; } = (SkillList.Skills)(16);
        [SynthesisOrder]
        public sbyte Skill6Boost = 0;
    }
    public class SnowElf
    {
        public string editorID = "SnowElfRace";
        public string? newName = "Snow Elf";
        public string? aliases = "";
        public string? targetKeywords = "ActorTypeNPC";

        public float attributeHealth = 50;
        public float attributeMagicka = 50;
        public float attributeStamina = 50;

        public float baseCarryWeight = 300;

        public float baseMass = 1.0f;

        public float accelerationRate = 1.0f;
        public float decelerationRate = 1.0f;

        public float attributeHealthRegen = 0.7f;
        public float attributeMagickaRegen = 3.0f;
        public float attributeStaminaRegen = 5.0f;

        public float unarmedDamage = 4.0f;
        public float unarmedReach = 96.0f;

        public bool canSwim = true;
        public bool regenCombatHP = false;

        public string? flagsToAdd = "";
        public string? flagsToRemove = "";

        public SnowElfSkills Skills = new();
    }
    public class SnowElfSkills
    {
        [SynthesisOrder]
        public SkillList.Skills Skill0 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill0Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill1 { get; set; } = (SkillList.Skills)18;
        [SynthesisOrder]
        public sbyte Skill1Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill2 { get; set; } = (SkillList.Skills)19;
        [SynthesisOrder]
        public sbyte Skill2Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill3 { get; set; } = (SkillList.Skills)20;
        [SynthesisOrder]
        public sbyte Skill3Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill4 { get; set; } = (SkillList.Skills)21;
        [SynthesisOrder]
        public sbyte Skill4Boost = 15;
        [SynthesisOrder]
        public SkillList.Skills Skill5 { get; set; } = (SkillList.Skills)22;
        [SynthesisOrder]
        public sbyte Skill5Boost = 5;
        [SynthesisOrder]
        public SkillList.Skills Skill6 { get; set; } = (SkillList.Skills)23;
        [SynthesisOrder]
        public sbyte Skill6Boost = 5;
    }
    public class Dremora
    {
        public string editorID = "DremoraRace";
        public string? newName = "";
        public string? aliases = "DLC2DremoraRace";
        public string? targetKeywords = "ActorTypeNPC,ActorTypeDaedra";

        public float attributeHealth = 50;
        public float attributeMagicka = 50;
        public float attributeStamina = 50;

        public float baseCarryWeight = 300;

        public float baseMass = 1.0f;

        public float accelerationRate = 1.0f;
        public float decelerationRate = 1.0f;

        public float attributeHealthRegen = 0.7f;
        public float attributeMagickaRegen = 3.0f;
        public float attributeStaminaRegen = 5.0f;

        public float unarmedDamage = 4.0f;
        public float unarmedReach = 96.0f;

        public bool canSwim = true;
        public bool regenCombatHP = false;

        public string? flagsToAdd = "";
        public string? flagsToRemove = "";

        public DremoraSkills Skills = new();
    }
    public class DremoraSkills
    {
        [SynthesisOrder]
        public SkillList.Skills Skill0 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill0Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill1 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill1Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill2 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill2Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill3 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill3Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill4 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill4Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill5 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill5Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill6 { get; set; } = (SkillList.Skills)(16);
        [SynthesisOrder]
        public sbyte Skill6Boost = 0;
    }
    public class VampireLord
    {
        public string editorID = "DLC1VampireBeastRace";
        public string? newName = "";
        public string? aliases = "";
        public string? targetKeywords = "";

        public float attributeHealth = 50;
        public float attributeMagicka = 50;
        public float attributeStamina = 50;

        public float baseCarryWeight = 300;

        public float baseMass = 1.0f;

        public float accelerationRate = 1.0f;
        public float decelerationRate = 1.0f;

        public float attributeHealthRegen = 0.7f;
        public float attributeMagickaRegen = 3.0f;
        public float attributeStaminaRegen = 5.0f;

        public float unarmedDamage = 4.0f;
        public float unarmedReach = 96.0f;

        public bool canSwim = true;
        public bool regenCombatHP = false;

        public string? flagsToAdd = "";
        public string? flagsToRemove = "";

        public VampireLordSkills Skills = new();
    }
    public class VampireLordSkills
    {
        [SynthesisOrder]
        public SkillList.Skills Skill0 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill0Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill1 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill1Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill2 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill2Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill3 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill3Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill4 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill4Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill5 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill5Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill6 { get; set; } = (SkillList.Skills)(16);
        [SynthesisOrder]
        public sbyte Skill6Boost = 0;
    }
    public class Werewolf
    {
        public string editorID = "WerewolfBeastRace";
        public string? newName = "";
        public string? aliases = "Werewolf";
        public string? targetKeywords = "";

        public float attributeHealth = 50;
        public float attributeMagicka = 50;
        public float attributeStamina = 50;

        public float baseCarryWeight = 300;

        public float baseMass = 1.0f;

        public float accelerationRate = 1.0f;
        public float decelerationRate = 1.0f;

        public float attributeHealthRegen = 0.7f;
        public float attributeMagickaRegen = 3.0f;
        public float attributeStaminaRegen = 5.0f;

        public float unarmedDamage = 4.0f;
        public float unarmedReach = 96.0f;

        public bool canSwim = true;
        public bool regenCombatHP = false;

        public string? flagsToAdd = "";
        public string? flagsToRemove = "";

        public WerewolfSkills Skills = new();
    }
    public class WerewolfSkills
    {
        [SynthesisOrder]
        public SkillList.Skills Skill0 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill0Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill1 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill1Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill2 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill2Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill3 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill3Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill4 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill4Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill5 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill5Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill6 { get; set; } = (SkillList.Skills)(16);
        public sbyte Skill6Boost = 0;
    }
    public class Werebear
    {
        public string editorID = "DLC2WerebearBeastRace";
        public string? newName = "";
        public string? aliases = "Werebear";
        public string? targetKeywords = "";

        public float attributeHealth = 50;
        public float attributeMagicka = 50;
        public float attributeStamina = 50;

        public float baseCarryWeight = 300;

        public float baseMass = 1.0f;

        public float accelerationRate = 1.0f;
        public float decelerationRate = 1.0f;

        public float attributeHealthRegen = 0.7f;
        public float attributeMagickaRegen = 3.0f;
        public float attributeStaminaRegen = 5.0f;

        public float unarmedDamage = 4.0f;
        public float unarmedReach = 96.0f;

        public bool canSwim = true;
        public bool regenCombatHP = false;

        public string? flagsToAdd = "";
        public string? flagsToRemove = "";

        public WerebearSkills Skills = new();
    }
    public class WerebearSkills
    {
        [SynthesisOrder]
        public SkillList.Skills Skill0 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill0Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill1 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill1Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill2 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill2Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill3 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill3Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill4 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill4Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill5 { get; set; } = (SkillList.Skills)(-1);
        [SynthesisOrder]
        public sbyte Skill5Boost = 0;
        [SynthesisOrder]
        public SkillList.Skills Skill6 { get; set; } = (SkillList.Skills)(16);
        [SynthesisOrder]
        public sbyte Skill6Boost = 0;
    }
}
