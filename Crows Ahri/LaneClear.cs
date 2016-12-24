using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Menu.Values;
using static Crows_Ahri.Menus;

namespace Crows_Ahri
{
    internal class LaneClear
    {

        public static void LaneExecute()
        {

            var Qlanemonster = EntityManager.MinionsAndMonsters.GetLaneMinions(EntityManager.UnitTeam.Enemy, Player.Instance.ServerPosition, Spells.Q.Range);
            var Elanemonster = EntityManager.MinionsAndMonsters.GetLaneMinions(EntityManager.UnitTeam.Enemy, Player.Instance.ServerPosition, Spells.E.Range);

            if (LaneClearMenu["Q"].Cast<CheckBox>().CurrentValue && Spells.Q.IsReady())
            {
                if (Player.Instance.ManaPercent >= LaneClearMenu["MinManaQ"].Cast<Slider>().CurrentValue)
                {
                    foreach (var minion in Qlanemonster)
                    {
                        if (minion.IsValidTarget())
                        {
                            Spells.Q.Cast(minion);
                        }
                    }
                }
            }

            if (LaneClearMenu["W"].Cast<CheckBox>().CurrentValue && Spells.W.IsReady())
            {
                
            
            
            if (Player.Instance.ManaPercent >= LaneClearMenu["MinManaW"].Cast<Slider>().CurrentValue)
                {
                foreach (var minion in Elanemonster)
                {
                    if (minion.IsValidTarget())
                    {
                        Spells.W.Cast(minion);
                    }
                }
            }
          }


    }

}
}