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
    }
}
