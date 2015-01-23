using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
using Color = System.Drawing.Color;
#region SpeechSynth
using System.IO;
using System.Reflection;
using System.Speech.Synthesis;
using System.Timers;
#endregion SpeechSynth

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
        private static System.Speech.Synthesis.SpeechSynthesizer SpeechSynthesizer;

        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }

        #region OnGameLoad
        private static void Game_OnGameLoad(EventArgs args)
        {
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
            Q.SetSkillshot(5f, 0.7f, 1900, true, SkillshotType.SkillshotLine);
            E.SetSkillshot(1.25f, 1.1f, 2000, false, SkillshotType.SkillshotLine);

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
            Config.SubMenu("Combo").AddItem(new MenuItem("UsePacketCast", "Use Packets")).SetValue(true);

            //drawing submenu
            Config.AddSubMenu(new Menu("Drawings", "Drawings"));
            Config.SubMenu("Drawings").AddItem(new MenuItem("DrawEnable", "Enable Drawing")).SetValue(true);
            Config.SubMenu("Drawings").AddItem(new MenuItem("DrawQ", "Draw Q")).SetValue(true);
            Config.SubMenu("Drawings").AddItem(new MenuItem("DrawW", "Draw W")).SetValue(true);
            Config.SubMenu("Drawings").AddItem(new MenuItem("DrawE", "Draw E")).SetValue(true);

            // add it to mainMenu duuuh
            Config.AddToMainMenu();

            //subcribe to various events
            Game.OnGameUpdate += Game_OnGameUpdate;
            Drawing.OnDraw += Drawing_OnDraw;
            //Speech welcome message
            SpeechSynthesizer = new System.Speech.Synthesis.SpeechSynthesizer();
            SpeechSynthesizer.Volume = 100;
            SpeechSynthesizer.GetInstalledVoices();
            SpeechSynthesizer.SelectVoice("Microsoft Zira Desktop");
            SpeechSynthesizer.SetOutputToDefaultAudioDevice();
            SpeechSynthesizer.Speak("Thresh Flayer, Rek em Son"); // :^), to be edited
   

            #endregion Menus
        }
        #endregion OnGameLoad

        private static void Game_OnGameUpdate(EventArgs args)
        {
            if (Config.Item("ActiveCombo").GetValue<KeyBind>().Active)
            {   
                Combo();
            }
        }

        private static void Combo()
        {
            var target = TargetSelector.GetTarget(E.Range, TargetSelector.DamageType.Magical);
            if (target == null)
            {
                return;
            }
            var usePacketCast = Config.Item("UsePacketCast").GetValue<bool>();
            if (E.IsReady() && (Config.Item("UseECombo").GetValue<bool>()))
            {
                var predictionE = E.GetPrediction(target);
                var predictionQ = Q.GetPrediction(target);
                if (Q.IsReady() && (Config.Item("UseQCombo").GetValue<bool>()))
                {
                    E.Cast(predictionE.CastPosition.SetZ(predictionE.CastPosition.X * -1), usePacketCast);
                    Q.CastIfHitchanceEquals(target, HitChance.High, usePacketCast);
                }
                else
                {
                    E.Cast(predictionE.CastPosition.SetZ(predictionE.CastPosition.X * -1), usePacketCast);
                }
            }
            else
            {
                if (Q.IsReady() && (Config.Item("UseQCombo").GetValue<bool>()))
                {
                    Q.CastIfHitchanceEquals(target, HitChance.High, usePacketCast);
                }
                else
                {
                    return;
                }
            }
        }

        private static void Drawing_OnDraw(EventArgs args)
        {
            //don't do stuff while player is dead
            if (Player.IsDead)
            {
                return;
            }

            if (Config.Item("DrawEnable").GetValue<bool>() == false)
            {
                return;
            }
            else
            {
                if (Config.SubMenu("Drawings").Item("DrawQ").GetValue<bool>())
                {
                    if (Q.Level >= 1)
                    {
                        if (Q.IsReady() == true)
                        {
                            Render.Circle.DrawCircle(Player.Position, 1100, Color.Green);
                        }
                        else
                        {
                            Render.Circle.DrawCircle(Player.Position, 1100, Color.DarkRed);
                        }
                    }
                }
                if (Config.SubMenu("Drawings").Item("DrawW").GetValue<bool>())
                {
                    if (W.Level >= 1)
                    {
                        if (W.IsReady() == true)
                        {
                            Render.Circle.DrawCircle(Player.Position, 950, Color.Green);
                        }
                        else
                        {
                            Render.Circle.DrawCircle(Player.Position, 950, Color.DarkRed);
                        }
                    }
                }

                if (Config.SubMenu("Drawings").Item("DrawE").GetValue<bool>())
                {
                    if (E.Level >= 1)
                    {
                        if (E.IsReady() == true)
                        {
                            Render.Circle.DrawCircle(Player.Position, 400, Color.Green);
                        }
                        else
                        {
                            Render.Circle.DrawCircle(Player.Position, 400, Color.DarkRed);
                        }
                    }
                }
            }
        }
    }
}