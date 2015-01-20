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
            Config = new Menu(Player.ChampionName + " Flayer", Player.ChampionName, true);
     
            Config.AddToMainMenu();
        }

        private static void Game_OnGameUpdate(EventArgs args)
        {

        }

        private static void Drawing_OnDraw(EventArgs args)
        {

        }
    }
}