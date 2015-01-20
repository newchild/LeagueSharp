using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
using Color = System.Drawing.Color;

namespace ThreshFlay
{
    class Program
    {
        private static Obj_AI_Hero Player { get { return ObjectManager.Player; } }
        private static Orbwalking.Orbwalker Orbwalker;
        private static Spell E;
        private static Menu Config;
        private static String Smileys = "(/^_^)/ Thresh Flayer";
        private static HitChance hitchance = HitChance.Medium;

        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }

        private static void Game_OnGameLoad(EventArgs args)
        {
            Game.OnGameUpdate += Game_OnGameUpdate;
            Drawing.OnDraw += Drawing_OnDraw;

            if (Player.ChampionName != "Thresh")
                return;

            E = new Spell(SpellSlot.E, 400);
            Config = new Menu(Player.ChampionName + " Flay", Player.ChampionName, true);
            Menu orbwalkerMenu = Config.AddSubMenu(new Menu("Orbwalker", "Orbwalker"));
            Orbwalker = new Orbwalking.Orbwalker(orbwalkerMenu);
            Menu ts = Config.AddSubMenu(new Menu("Target Selector", "Target Selector")); ;
            TargetSelector.AddToMenu(ts);
            Menu spellMenu = Config.AddSubMenu(new Menu("Spells", "Spells"));
            spellMenu.AddItem(new MenuItem("FlayBackwards", "Flay Backwards").SetValue(new KeyBind(32, KeyBindType.Press)));
            spellMenu.AddItem(new MenuItem("FlayForwards", "Flay forwards").SetValue(new KeyBind(0x43, KeyBindType.Press)));
            spellMenu.AddItem(new MenuItem("ConstantFlay Forwards", "Toggle").SetValue(new KeyBind(0x54, KeyBindType.Toggle)));

            Config.AddToMainMenu();

            Game.PrintChat(Smileys);
            Game.PrintChat("Provided by KappaStack");
        }

        private static void Game_OnGameUpdate(EventArgs args)
        {

        }

        private static void Drawing_OnDraw(EventArgs args)
        {

        }

        private void flayForwards()
        {

        }

        private void flayBackwards()
        {

        }
    }
}