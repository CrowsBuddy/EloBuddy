using EloBuddy;
using EloBuddy.SDK;


namespace Crows_Ahri
{
    using System.Data.Common;

    using EloBuddy.SDK.Enumerations;

    internal static class Spells
    {

        public static Spell.Skillshot Q;

        public static Spell.Active W;

        public static Spell.Skillshot E;

        public static void InitializeSpells()
        {
            Q = new Spell.Skillshot(SpellSlot.Q, 880, SkillShotType.Linear);
            W = new Spell.Active(SpellSlot.W, 700, SkillShotType.Circular);
            E = new Spell.Skillshot(SpellSlot.E, 975, SkillShotType.Linear);
            R = new Spell.Active(SpellSlot.R, 470, SkillShotType.Circular);
        }
    }
}