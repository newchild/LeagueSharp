using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeagueSharp;
using LeagueSharp.SDK.Core;
using LeagueSharp.SDK.Core.Enumerations;
using LeagueSharp.SDK.Core.Events;
using LeagueSharp.SDK.Core.Extensions;
using LeagueSharp.SDK.Core.UI;
using LeagueSharp.SDK.Core.UI.IMenu.Values;
using LeagueSharp.SDK.Core.Utils;
using LeagueSharp.SDK.Core.UI.IMenu;
using LeagueSharp.SDK.Core.Wrappers;
using System.Threading.Tasks;
using LeagueSharp.SDK.Core.Wrappers;
using System.Timers;

namespace RoachIsAFag
{
	class Program
	{
		private static Menu Settings;
		private static Dictionary<string, Spell> Spells = new Dictionary<string,Spell>
		{
														 {"MasterYi", new Spell(SpellSlot.Q, 620)}
													 };
		private static Dictionary<string, Action> Logic = new Dictionary<string,Action>
		{
													   {"MasterYi", new Action(MasterYiDodge)}
												   };
		private static Dictionary<string, float> EvadeableSpellsExtraBuffer = new Dictionary<string, float>
		{
														 {"KarthusFallenOne", 2400f}
													 };
		
		private static string Hero;
		private static System.Timers.Timer LogicTimer = new System.Timers.Timer();
		static void Main(string[] args)
		{
			Hero = ObjectManager.Player.ChampionName;
			Obj_AI_Hero.OnProcessSpellCast += Obj_AI_Hero_OnProcessSpellCast;
			Game.OnStart += Game_OnStart;
		}

		static void Game_OnStart(EventArgs args)
		{
			Settings = new Menu("Root", "SpellEvade Settings", true);
			Settings.Add(new MenuSlider("Root.Delay", "Dodge Delay", 3, -3));
			Settings.Add(new MenuSeparator("Root.DelayDescription1", "Lower this if you dodge too late, higher it if you dodge to early"));
			Settings.Add(new MenuSeparator("Root.DelayDescription2", "Be aware that little changes might already have high influence, also negative numbers are not recommended"));
		}

		static void Obj_AI_Hero_OnProcessSpellCast(Obj_AI_Base sender, GameObjectProcessSpellCastEventArgs args)
		{
			if (EvadeableSpellsExtraBuffer.ContainsKey(args.SData.Name))
			{
				LogicTimer.Elapsed += new ElapsedEventHandler(GenericLogic);
				LogicTimer.Interval = (args.SData.SpellCastTime * -1000) + Settings["Root.Delay"].GetValue<MenuSlider>().Value * 100 + EvadeableSpellsExtraBuffer[args.SData.Name]; //0.3 second buffer + add the specific timer
				LogicTimer.Enabled = true;
				return;

			}
			if (sender.IsMinion)
				return;
			if (!args.Target.IsMe || args.SData.ConsideredAsAutoAttack || !sender.IsEnemy)
				return;
			LogicTimer.Elapsed += new ElapsedEventHandler(GenericLogic);
			LogicTimer.Interval = (args.SData.SpellTotalTime * -1000) + 0.3 * 1000; //0.3 second buffer
			LogicTimer.Enabled = true;
		}

		private static void GenericLogic(object sender, ElapsedEventArgs e)
		{
			Logic[Hero]();
		}

		private static void MasterYiDodge()
		{

			//We will prefer Champions over Minions and Minions over nothing :C Also we ignore the damage we will be dealing
			var PreferedChampion = TargetSelector.GetTarget(Spells[Hero].Range, DamageType.True);
			if (PreferedChampion.IsValidTarget())
			{
				Spells[Hero].Cast(PreferedChampion);
				LogicTimer.Enabled = false; 
				return; 
				 
			}
			foreach (var minion in ObjectManager.Get<Obj_AI_Minion>()) 
 			{
				if (ObjectManager.Player.Distance(minion) <= Spells[Hero].Range && minion.IsValidTarget()) 
					{
						Spells[Hero].Cast(minion);
						LogicTimer.Enabled = false; 
						return; 
 					} 
			}

			LogicTimer.Enabled = false;

		}
	}
}
