using System;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Menu.Values;
using static Crows_Ahri.Combo;
using static Crows_Ahri.LaneClear;

namespace Crows_Ahri
{
    using System.ComponentModel.Design;

    internal class Program
    
    {
        static void Main(string[] args)
        {
            Loading.OnLoadingComplete += OnLoadingComplete;
        }

        public static void OnLoadingComplete(EventArgs args)
        {
            if (Player.Instance.Hero != Champion.Ahri) return;

            Chat.Print("Crows Ahri Loaded");

            Game.OnTick += OnTick;
            Menus.CreateMenu();
            Spells.InitializeSpells();
            Combo.ComboExecute();
            Drawing.CreateDrawings();   
        }

        private static void OnTick(EventArgs args)
        {
            if (Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.Combo)) ComboExecute();
            if (Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.LaneClear)) LaneExecute();
        }

    }
}
