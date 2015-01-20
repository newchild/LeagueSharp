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
        private const string Champion = "Thresh";
        private static Obj_AI_Hero Player { get { return ObjectManager.Player; } }
        private static Orbwalking.Orbwalker Orbwalker;
        private static Spell Q;
        private static Spell W;
        private static Spell E;
        private static List<Spell> SpellList = new List<Spell>();
        private static Menu Config;

        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }

        private static void Game_OnGameLoad(EventArgs args)
        {
            Game.OnGameUpdate += Game_OnGameUpdate;
            Drawing.OnDraw += Drawing_OnDraw;

            //checking if champion is thresh
            if (ObjectManager.Player.BaseSkinName != Champion)
            {
                return;
            }

            #region SpellsRegion
            // setting up spells
            //ranges
            Q = new Spell(SpellSlot.Q, 1100);
            W = new Spell(SpellSlot.W, 950);
            E = new Spell(SpellSlot.E, 400);

            //skillshot predictions
            Q.SetSkillshot(5f, 0.7f, 19f, true, SkillshotType.SkillshotLine);
            E.SetSkillshot(1.25f, 1.1f, 20f, false, SkillshotType.SkillshotLine);

            //add it to SpellList
            SpellList.Add(Q);
            SpellList.Add(W);
            SpellList.Add(E);
            #endregion SpellsRegion
            #region Menus
            //setting up menus
            Config = new Menu("Thresh_Flayer", "Thresh_Flayer", true);

            //targetSelector submenu
            var targetSelectorMenu = new Menu("Target Selector", "Target Selector");
            TargetSelector.AddToMenu(targetSelectorMenu);
            Config.AddSubMenu(targetSelectorMenu);

            //orwalking submenu
            Config.AddSubMenu(new Menu("Orbwalking", "Orbwalking"));
            Orbwalker = new Orbwalking.Orbwalker(Config.SubMenu("Orbwalking"));

            //combo submenu
            Config.AddSubMenu(new Menu("Combo", "Combo"));
            Config.SubMenu("Combo").AddItem(new MenuItem("UseQCombo", "Use Q")).SetValue(true);
            Config.SubMenu("Combo").AddItem(new MenuItem("UseECombo", "Use E")).SetValue(true);
            Config.SubMenu("Combo").AddItem(new MenuItem("ActiveCombo", "Combo!").SetValue(new KeyBind(32, KeyBindType.Press)));

            //drawing submenu
            Config.AddSubMenu(new Menu("Drawings", "Drawings"));
            Config.SubMenu("Drawings").AddItem(new MenuItem("DrawEnable", "Enable Drawing"));
            Config.SubMenu("Drawings").AddItem(new MenuItem("DrawQ", "Draw Q")).SetValue(true);
            Config.SubMenu("Drawings").AddItem(new MenuItem("DrawW", "Draw W")).SetValue(true);
            Config.SubMenu("Drawings").AddItem(new MenuItem("DrawE", "Draw E")).SetValue(true);
            Config.SubMenu("Drawings").AddItem(new MenuItem("CircleLag", "Lag Free Circles").SetValue(true));
            Config.SubMenu("Drawings").AddItem(new MenuItem("CircleQuality", "Circles Quality").SetValue(new Slider(10, 100, 10)));
            Config.SubMenu("Drawings").AddItem(new MenuItem("CircleThickness", "Circles Thickness").SetValue(new Slider(1, 10, 1)));

            // add it to mainMenu duuuh
            Config.AddToMainMenu();
            #endregion Menus
        }

        private static void Game_OnGameUpdate(EventArgs args)
        {
            if (Config.Item("ActiveCombo").GetValue<KeyBind>().Active)
            {
                Combo();
            }
        }

        private static void Drawing_OnDraw(EventArgs args)
        {

        }

        private static void Combo()
        {
            var target = TargetSelector.GetTarget(E.Range, TargetSelector.DamageType.Magical);
            if (target == null)
            {
                return;
            }

            if (E.IsReady() && (Config.Item("UseECombo").GetValue<bool>()))
            {
                if (Q.IsReady() && (Config.Item("UseQCombo").GetValue<bool>()))
                {
                    //cast E then Q
                }
                else
                {
                    //just cast E
                }
            }
            else
            {
                if (Q.IsReady() && (Config.Item("UseQCombo").GetValue<bool>()))
                {
                    //Just cast Q
                }
                else
                {
                    return;
                }
            }

            if (E.IsReady() && (Config.Item("UseECombo").GetValue<bool>()))
            {
                
            }
        }

    }
}