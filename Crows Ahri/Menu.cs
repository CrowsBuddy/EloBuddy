using EloBuddy;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;

namespace Crows_Ahri
{
    internal class Menu
    {

        public static Menu FirstMenu;

        public static Menu ComboMenu;

        public static Menu DrawingsMenu;

        public static Menu LaneClearMenu;

        


        public static void CreateMenu()
        {
            FirstMenu = MainMenu.AddMenu(Player.Instance.ChampionName, Player.Instance.ChampionName.ToLower() + "Crows Ahri");

            ComboMenu = FirstMenu.AddSubMenu("Combo");

            DrawingsMenu = FirstMenu.AddSubMenu("Drawings");

            LaneClearMenu = FirstMenu.AddSubMenu("LaneClear");
        
            JungleClearMenu = FirstMenu.AddSubMenu("JungleClear");

            //ComboMenu 
            ComboMenu.AddGroupLabel("Combo");
            ComboMenu.Add("Q", new CheckBox("Use Q"));
            ComboMenu.Add("W", new CheckBox("Use W"));
            ComboMenu.Add("E", new CheckBox("Use E"));
            ComboMenu.Add("R", new CheckBox("Use R"));


            //DrawingsMenu
            DrawingsMenu.AddGroupLabel("Drawings");
            DrawingsMenu.Add("Q", new CheckBox("Draw Q"));
            DrawingsMenu.Add("W", new CheckBox("Draw W"));
            DrawingsMenu.Add("E", new CheckBox("Draw E"));
            DrawingsMenu.Add("R", new CheckBox(("Draw R")));


            //LaneClearMenu
            LaneClearMenu.AddGroupLabel("LaneClear");
            LaneClearMenu.Add("Q", new CheckBox("Use Q"));
            LaneClearMenu.Add("W", new CheckBox("Use W"));
            LaneClearMenu.Add("MinManaQ", new Slider("Min Mana to cast Q", 30. 1, 99));
            LaneClearMenu.Add("MinManaW", new Slider("Min Mana to cast W", 30. 1, 99));





         


        }


    }
}