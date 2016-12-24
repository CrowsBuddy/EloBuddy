using System;
using EloBuddy;
using EloBuddy.SDK.Rendering;
using static Crows_Ahri.Menus;
using static Crows_Ahri.Spells;
using EloBuddy.SDK.Menu.Values;

namespace Crows_Ahri
{
    internal class Drawing
    {

        public static void CreateDrawings()
        {
            Drawing.OnDraw += Drawing_OnDraw;
        }


        private static void Drawing_OnDraw(EventArgs args)
        {

            if (DrawingsMenu["Q"].Cast < CheckBox>().CurrentValue && Q.IsReady())
            {
                Circle.Draw(SharpDX.Color.Pink, Q.Range, Player.Instance);
            }

            if (DrawingsMenu["W"].Cast<CheckBox>().CurrentValue && W.IsReady())
            {
                Circle.Draw(SharpDX.Color.White,W.Range, Player.Instance);
            }


            if (DrawingsMenu["E"].Cast<CheckBox>().CurrentValue && E.IsReady())
            {
                Circle.Draw(SharpDX.Color.White, E.Range, Player.Instance);
            }

            if (DrawingsMenu["R"].Cast<CheckBox>().CurrentValue && E.IsReady())
            {
                Circle.Draw(SharpDX.Color.Aqua,R.Range, Player.Instance);
            }


        }

    }
    }
    }

        
    }
}