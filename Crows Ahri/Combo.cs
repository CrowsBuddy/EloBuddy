using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Menu.Values;
using static Crows_Ahri.Program;
using static Crows_Ahri.Menus;


namespace Crows_Ahri
{
    using System.Runtime.InteropServices;

    internal class Combo
    {

        public static void ComboExecute()
        {
            var CTarget = TargetSelector.GetTarget(Spell.Q.Range, DamageType.Magical, true);
            if (!R.IsReady())

            if ((CTarget == null) || CTarget.IsInvulnerable) return;
            if (ComboMenu["Q"].Cast<CheckBox>().CurrentValue)
            {
                if (CTarget.IsValidTarget(Spells.Q.Range) && Spells.Q.IsReady())
                {
                    var qhitchance = Spells.Q.GetPrediction(CTarget);
                    if (qhitchance.HitChancePercent >= 80)
                    {
                        Spells.Q.Cast(qhitchance.CastPosition);
                        
                    }
                }
            }

         



            var CTarget = TargetSelector.GetTarget(Spell.W.Range, DamageType.Magical);
            if ((CTarget == null) || CTarget.IsInvulnerable) return;
            if (ComboMenu["W"].Cast<CheckBox>().CurrentValue)
            {
                if (CTarget.IsValidTarget(Spells.W.Range) && Spells.W.IsReady())
                {
                    var whitchance = Spells.W.GetPrediction(CTarget);
                    if (whitchance.HitChancePercent >= 80)
                    {
                        Spells.W.Cast(whitchance.CastPosition);

                    }
                }
            }


            var CTarget = TargetSelector.GetTarget(Spell.E.Range, DamageType.Magical);
            if ((CTarget == null) || CTarget.IsInvulnerable) return;
            if (ComboMenu["E"].Cast<CheckBox>().CurrentValue)
            {
                if (CTarget.IsValidTarget(Spells.E.Range) && Spells.E.IsReady())
                {
                    var ehitchance = Spells.E.GetPrediction(CTarget);
                    if (ehitchance.HitChancePercent >= 80)
                    {
                        Spells.E.Cast(ehitchance.CastPosition);

                    }
                }
            }

            if (ComboMenu["R"].Cast < CheckBox>().CurrentValue)
            {
                var rhitchance = Spells.R.GetPrediction(CTarget);
                if (enemy.IsValidTarget(Spells.R.Range) && Spells.R.IsReady())
                    if (GetComboDamage(CTarget) >= CTarget.Health)
                        if (rhitchance.HitChancePercent >= 80)
                        {
                            R.Cast(rhitchance.CursorPos, true);
                        }
                        

            }



        }
    }
}