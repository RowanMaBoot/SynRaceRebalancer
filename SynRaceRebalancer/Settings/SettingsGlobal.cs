using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mutagen.Bethesda.Synthesis.Settings;

namespace SynRaceRebalancer.Settings
{
    public class SettingsGlobal
    {
        [SynthesisOrder]
        [SynthesisSettingName("Enable Module - Doesn't Impact Playable Races")]
        public bool EnableModule = true;

        [SynthesisOrder]
        public float GlobalHPMultiplier = 1.0f;

        [SynthesisOrder]
        [SynthesisSettingName("Minimum Hitpoint Anchor")]
        [SynthesisTooltip("Hitpoints cannot be lower than this value. Useful if adding a negative global shift, or globally multiplying health by less than 1.0f.")]
        public int MinimumHPAnchor = 10;

        [SynthesisOrder]
        [SynthesisSettingName("Global Hitpoint Shift")]
        [SynthesisTooltip("Shifts all hitpoints by a fixed value in a positive or negative, limited by the minimum HP setting above.")]
        public int GlobalHPShift = 0;

        [SynthesisOrder]
        public GMST GameSetting = new();
    }

    public class GMST
    {
        [SynthesisOrder]
        [SynthesisSettingName("Enable or Disable GameSetting Changes")]
        [SynthesisTooltip("Enable or disable changes to gamesettings.")]
        public bool GMSTChanges = true;

        [SynthesisOrder]
        [SynthesisSettingName("Enable or Disable General Changes")]
        [SynthesisTooltip("Enable or disable the below changes.")]
        public bool GMSTGeneralChanges = false;
        [SynthesisOrder]
        [SynthesisSettingName("Skill Starting Level")]
        [SynthesisTooltip("Adjusts the base starting skills (before per-race bonuses).")]
        public int iAVDSkillStart = 15;
        [SynthesisOrder]
        [SynthesisSettingName("Health, Magicka and Stamina bonus from level up")]
        [SynthesisTooltip("Adjusts the Health, Magicka and Stamina bonus from levelling up")]
        public int iAVDhmsLevelUp = 10;
        [SynthesisOrder]
        [SynthesisSettingName("NPC Skill Bonus per level")]
        [SynthesisTooltip("Adjusts the skill bonus NPC characters get per level.")]
        public int iAVDSkillsLevelUp = 8;
        [SynthesisOrder]
        [SynthesisSettingName("NPC Health Bonus per level")]
        [SynthesisTooltip("Adjusts the health bonus NPC characters get per level.")]
        public float fNPCHealthLevelBonus = 5;

        [SynthesisOrder]
        [SynthesisSettingName("Enable or Disable Regen Changes")]
        [SynthesisTooltip("Enable or disable the below changes.")]
        public bool GMSTRegenChanges = false;
        [SynthesisOrder]
        [SynthesisSettingName("Combat Health Regen Multiplier")]
        public float fCombatHealthRegenRateMult = 0.1f;
        [SynthesisOrder]
        [SynthesisSettingName("Combat Magicka Regen Multiplier")]
        public float fCombatMagickaRegenRateMult = 0.1f;
        [SynthesisOrder]
        [SynthesisSettingName("Combat Stamina Regen Multiplier")]
        public float fCombatStaminaRegenRateMult = 0.1f;

        [SynthesisOrder]
        [SynthesisSettingName("Enable or Disable fHealthData Changes")]
        [SynthesisTooltip("Enable or disable the below changes.")]
        public bool GMSTfHealthDataValue = false;
        [SynthesisOrder]
        [SynthesisSettingName("fHealthDataValue1")]
        public float fHealthDataValue1 = 1.1f;
        [SynthesisOrder]
        [SynthesisSettingName("fHealthDataValue2")]
        public float fHealthDataValue2 = 1.2f;
        [SynthesisOrder]
        [SynthesisSettingName("fHealthDataValue3")]
        public float fHealthDataValue3 = 1.3f;
        [SynthesisOrder]
        [SynthesisSettingName("fHealthDataValue4")]
        public float fHealthDataValue4 = 1.4f;
        [SynthesisOrder]
        [SynthesisSettingName("fHealthDataValue5")]
        public float fHealthDataValue5 = 1.5f;
        [SynthesisOrder]
        [SynthesisSettingName("fHealthDataValue6")]
        public float fHealthDataValue6 = 1.6f;

        [SynthesisOrder]
        [SynthesisSettingName("Enable or Disable Difficulty Changes")]
        [SynthesisTooltip("Enable or disable the below changes.")]
        public bool GMSTDiffChanges = false;
        [SynthesisOrder]
        [SynthesisSettingName("Novice - Damage to Player Character Multiplier")]
        public float fDiffMultHPToPCVE = 0.5f;

        [SynthesisOrder]
        [SynthesisSettingName("Novice - Damage to Non-player Character Mulitplier")]
        public float fDiffMultHPByPCVE = 2.0f;

        [SynthesisOrder]
        [SynthesisSettingName("Apprentice - Damage to Player Character Multiplier")]
        public float fDiffMultHPToPCE = 0.75f;

        [SynthesisOrder]
        [SynthesisSettingName("Apprentice - Damage to Non-player Character Mulitplier")]
        public float fDiffMultHPByPCE = 1.5f;

        [SynthesisOrder]
        [SynthesisSettingName("Adept - Damage to Player Character Multiplier")]
        public float fDiffMultHPToPCN = 1.0f;

        [SynthesisOrder]
        [SynthesisSettingName("Adept - Damage to Non-player Character Mulitplier")]
        public float fDiffMultHPByPCN = 1.0f;

        [SynthesisOrder]
        [SynthesisSettingName("Expert - Damage to Player Character Multiplier")]
        public float fDiffMultHPToPCH = 1.5f;

        [SynthesisOrder]
        [SynthesisSettingName("Expert - Damage to Non-player Character Mulitplier")]
        public float fDiffMultHPByPCH = 0.75f;

        [SynthesisOrder]
        [SynthesisSettingName("Master - Damage to Player Character Multiplier")]
        public float fDiffMultHPToPCVH = 2.0f;

        [SynthesisOrder]
        [SynthesisSettingName("Master - Damage to Non-player Character Mulitplier")]
        public float fDiffMultHPByPCVH = 0.5f;

        [SynthesisOrder]
        [SynthesisSettingName("Legendary - Damage to Player Character Multiplier")]
        public float fDiffMultHPToPCL = 3.0f;

        [SynthesisOrder]
        [SynthesisSettingName("Legendary - Damage to Non-player Character Mulitplier")]
        public float fDiffMultHPByPCL = 0.25f;
    }
}