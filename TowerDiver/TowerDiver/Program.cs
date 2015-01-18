using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;
using Color = System.Drawing.Color;

namespace TowerDiver
{
    class Program
    {
        //private static Menu Menu;
        private static Obj_AI_Hero Player { get { return ObjectManager.Player; } }
        private static int turretAttackRange = 775;
        private static int turretSightRange = 1095;
     
        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }

        private static void Game_OnGameLoad(EventArgs args)
        {
            Game.OnGameUpdate += Game_OnGameUpdate;
            Drawing.OnDraw += Drawing_OnDraw;
            Utility.HpBarDamageIndicator.Enabled = true;
            Utility.HpBarDamageIndicator.DamageToUnit += DamageToUnit;
        }

        private static void Game_OnGameUpdate(EventArgs args)
        {
            if (Player.IsDead)
                return;
        }

        private static void Drawing_OnDraw(EventArgs args)
        {
            if (ObjectManager.Get<Obj_AI_Turret>().Any(turret => turret.IsValidTarget(turretSightRange, true, ObjectManager.Player.Position)))
            {
                Utility.HpBarDamageIndicator.DamageToUnit(Player);
            }
        }
    }
}
