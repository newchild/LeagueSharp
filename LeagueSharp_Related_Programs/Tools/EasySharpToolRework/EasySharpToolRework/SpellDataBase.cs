using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro;

namespace EasySharpToolRework
{

    class SpellDataBase
    {
        //MainArray
        private String[, ,] SpellsInfo;

        //Various variables
        private String[] Type;
        private String Null;


        public void Init()
        {
            SpellsInfo = new String[123, 5, 22]; //That's 16368 Slots of data, Mein Neger, Deal with it

            Type = new String[3];
            Type[0] = "null";
            Type[1] = "SkillShotLine";
            Type[2] = "SkillShotCone";
            Type[3] = "SkillShotCircle";

            Null = "null";

            /*
             * SpellsInfo[A,B,C]
             * 
             * A = Champion: 124 possibilities, 0 = Example
             * B = SpellSlot: 1 = passive, 2 = Q, 3 = W, 4 = E, 5 = R  (Do Not Use 0, it is added for convience)
             * C = InfoLabel: 0 = Champion, 1 = Name, 2 = Type, 3 = Delay, 4 = Range, 5 = Radius, 6 = Missile Speed, 7 = Fixed Range, 8 = Danger Value(From #Evade), 9 = Multiple Number, 10 = Multiple Angle
             * C = InfoLabel: 11 = Can Be Removed, 12 = Collision Objects, 13 = Cost, 14 = Cooldown, 15 = Duration, 16 = Physical Damage, 17 = Magic Damage, 18 = True Damage, 19 = Health Restored, 20 = AD Scaling, 21 = AP Scaling
             * 
             * SpellsInfo[A,B,C]
             */
            
            /*
             * Template
             */
            #region Template

            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";

            #endregion

            /*
            * Example Reference
            */
            #region
            //SpellsInfo[0, 0, 0] = "ChampionName";         //ChampionName For DropDownBox
            
            //SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];    //ChampionName for Passive slot
            //SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];    //ChampionName for Q slot
            //SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];    //ChampionName for W slot
            //SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];    //ChampionName for E slot
            //SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];    //ChampionName for R slot
            
            //SpellsInfo[0, 1, 1] = "Passive Skill Name";   //Passive Ability Name
            //SpellsInfo[0, 2, 1] = "Q Skill Name";         //Q Ability Name
            //SpellsInfo[0, 3, 1] = "W Skill Name";         //W Ability Name
            //SpellsInfo[0, 4, 1] = "E Skill Name";         //E Ability Name
            //SpellsInfo[0, 5, 1] = "R Skill Name";         //R Ability Name
            
            //SpellsInfo[0, 1, 2] = "Passive Type";         //Passive Ability Type (Non-SkillShot, SkillShotLine, SkillShotCone, SkillShotCircle)
            //SpellsInfo[0, 2, 2] = "Q Type";               //Q Ability Type (Non-SkillShot, SkillShotLine, SkillShotCone, SkillShotCircle)
            //SpellsInfo[0, 3, 2] = "W Type";               //W Ability Type (Non-SkillShot, SkillShotLine, SkillShotCone, SkillShotCircle)
            //SpellsInfo[0, 4, 2] = "E Type";               //E Ability Type (Non-SkillShot, SkillShotLine, SkillShotCone, SkillShotCircle)
            //SpellsInfo[0, 5, 2] = "R Type";               //R Ability Type (Non-SkillShot, SkillShotLine, SkillShotCone, SkillShotCircle)
            
            //SpellsInfo[0, 1, 3] = "Passive Delay";        //Passive Delay
            //SpellsInfo[0, 2, 3] = "Q Delay";              //Q Delay
            //SpellsInfo[0, 3, 3] = "W Delay";              //W Delay
            //SpellsInfo[0, 4, 3] = "E Delay";              //E Delay
            //SpellsInfo[0, 5, 3] = "R Delay";              //R Delay
            
            //SpellsInfo[0, 1, 4] = "Passive Range";        //Passive Range
            //SpellsInfo[0, 2, 4] = "Q Range";              //Q Range
            //SpellsInfo[0, 3, 4] = "W Range";              //W Range
            //SpellsInfo[0, 4, 4] = "E Range";              //E Range
            //SpellsInfo[0, 5, 4] = "R Range";              //R Range
            
            //SpellsInfo[0, 1, 5] = "Passive Radius";       //Passive Radius
            //SpellsInfo[0, 2, 5] = "Q Radius";             //Q Radius
            //SpellsInfo[0, 3, 5] = "W Radius";             //W Radius
            //SpellsInfo[0, 4, 5] = "E Radius";             //E Radius
            //SpellsInfo[0, 5, 5] = "R Radius";             //R Radius
            
            //SpellsInfo[0, 1, 6] = "Passive Missile Speed";//Passive Missile Speed
            //SpellsInfo[0, 2, 6] = "Q Missile Speed";      //Q Missile Speed
            //SpellsInfo[0, 3, 6] = "W Missile Speed";      //W Missile Speed
            //SpellsInfo[0, 4, 6] = "E Missile Speed";      //E Missile Speed
            //SpellsInfo[0, 5, 6] = "R Missile Speed";      //R Missile Speed
            
            //SpellsInfo[0, 1, 7] = "Passive Fixed Range";  //Passive Fixed Range (True or false)
            //SpellsInfo[0, 2, 7] = "Q Fixed Range";        //Q Fixed Range (True or false)
            //SpellsInfo[0, 3, 7] = "W Fixed Range";        //W Fixed Range (True or false)
            //SpellsInfo[0, 4, 7] = "E Fixed Range";        //E Fixed Range (True or false)
            //SpellsInfo[0, 5, 7] = "R Fixed Range";        //R Fixed Range (True or false)
            
            //SpellsInfo[0, 1, 8] = "Passive Danger Value"; //Passive Danger Value (1 - 5) (#Evade)
            //SpellsInfo[0, 2, 8] = "Q Danger Value";       //Q Danger Value (1 - 5) (#Evade)
            //SpellsInfo[0, 3, 8] = "W Danger Value";       //E Danger Value (1 - 5) (#Evade)
            //SpellsInfo[0, 4, 8] = "E Danger Value";       //E Danger Value (1 - 5) (#Evade)
            //SpellsInfo[0, 5, 8] = "R Danger Value";       //R Danger Value (1 - 5) (#Evade)
            
            //SpellsInfo[0, 1, 9] = "Passive Multiple Number";//Passive Multiple Number
            //SpellsInfo[0, 2, 9] = "Q Multiple Number";    //Q Multiple Number
            //SpellsInfo[0, 3, 9] = "W Multiple Number";    //W Multiple Number
            //SpellsInfo[0, 4, 9] = "E Multiple Number";    //E Multiple Number
            //SpellsInfo[0, 5, 9] = "R Multiple Number";    //R Multiple Number
            
            //SpellsInfo[0, 1, 10] = "Passive Multiple Angle";//Passive Multiple Angle
            //SpellsInfo[0, 2, 10] = "Q Multiple Angle";    //Q Multiple Angle
            //SpellsInfo[0, 3, 10] = "W Multiple Angle";    //W Multiple Angle
            //SpellsInfo[0, 4, 10] = "E Multiple Angle";    //E Multiple Angle
            //SpellsInfo[0, 5, 10] = "R Multiple Angle";    //R Multiple Angle

            //SpellsInfo[0, 1, 11] = "Passive Can Be Removed";//Passive Can Be Removed  (#Evade)
            //SpellsInfo[0, 2, 11] = "Q Can Be Removed";    //Q Can Be Removed  (#Evade)
            //SpellsInfo[0, 3, 11] = "W Can Be Removed";    //W Can Be Removed  (#Evade)
            //SpellsInfo[0, 4, 11] = "E Can Be Removed";    //E Can Be Removed  (#Evade)
            //SpellsInfo[0, 5, 11] = "R Can Be Removed";    //R Can Be Removed  (#Evade)
            
            //SpellsInfo[0, 1, 12] = "Passive Collision Objects";//Passive Collision Objects (Champion, Minion, YasuoWW) (Minions include annieTibber etc)
            //SpellsInfo[0, 2, 12] = "Q Collision Objects";  //Q Collision Objects (Champion, Minion, YasuoWW) (Minions include annieTibber etc)
            //SpellsInfo[0, 3, 12] = "W Collision Objects";  //W Collision Objects (Champion, Minion, YasuoWW) (Minions include annieTibber etc)
            //SpellsInfo[0, 4, 12] = "E Collision Objects";  //E Collision Objects (Champion, Minion, YasuoWW) (Minions include annieTibber etc)
            //SpellsInfo[0, 5, 12] = "R Collision Objects";  //R Collision Objects (Champion, Minion, YasuoWW) (Minions include annieTibber etc)
            
            //SpellsInfo[0, 1, 13] = "Passive Cost";         //Passive Cost (Mana, HP, Fury or w/e it be)
            //SpellsInfo[0, 2, 13] = "Q Cost";               //Q Cost (Mana, HP, Fury or w/e it be)
            //SpellsInfo[0, 3, 13] = "W Cost";               //W Cost (Mana, HP, Fury or w/e it be)
            //SpellsInfo[0, 4, 13] = "E Cost";               //E Cost (Mana, HP, Fury or w/e it be)
            //SpellsInfo[0, 5, 13] = "R Cost";               //R Cost (Mana, HP, Fury or w/e it be)
            
            //SpellsInfo[0, 1, 14] = "Passive Cooldown";     //Passive Cooldown in seconds
            //SpellsInfo[0, 2, 14] = "Q Cooldown";           //Q Cooldown in seconds
            //SpellsInfo[0, 3, 14] = "W Cooldown";           //W Cooldown in seconds
            //SpellsInfo[0, 4, 14] = "E Cooldown";           //E Cooldown in seconds
            //SpellsInfo[0, 5, 14] = "R Cooldown";           //R Cooldown in seconds
            
            //SpellsInfo[0, 1, 15] = "Passive Duration";     //Passive Duration in seconds
            //SpellsInfo[0, 2, 15] = "Q Duration";           //Q Duration in seconds
            //SpellsInfo[0, 3, 15] = "W Duration";           //W Duration in seconds
            //SpellsInfo[0, 4, 15] = "E Duration";           //E Duration in seconds
            //SpellsInfo[0, 5, 15] = "R Duration";           //R Duration in seconds
            
            //SpellsInfo[0, 1, 16] = "Passive Physical Damage";//Passive Physical Damage
            //SpellsInfo[0, 2, 16] = "Q Physical Damage";    //Q Physical Damage
            //SpellsInfo[0, 3, 16] = "W Physical Damage";    //W Physical Damage
            //SpellsInfo[0, 4, 16] = "E Physical Damage";    //E Physical Damage
            //SpellsInfo[0, 5, 16] = "R Physical Damage";    //R Physical Damage
            
            //SpellsInfo[0, 1, 17] = "Passive Magical Damage";//Passive Magical Damage
            //SpellsInfo[0, 2, 17] = "Q Magical Damage";     //Q Magical Damage
            //SpellsInfo[0, 3, 17] = "W Magical Damage";     //W Magical Damage
            //SpellsInfo[0, 4, 17] = "E Magical Damage";     //E Magical Damage
            //SpellsInfo[0, 5, 17] = "R Magical Damage";     //R Magical Damage
            
            //SpellsInfo[0, 1, 18] = "Passive True Damage";  //Passive True Damage
            //SpellsInfo[0, 2, 18] = "Q True Damage";        //Q True Damage
            //SpellsInfo[0, 3, 18] = "W True Damage";        //W True Damage
            //SpellsInfo[0, 4, 18] = "E True Damage";        //E True Damage
            //SpellsInfo[0, 5, 18] = "R True Damage";        //R True Damage

            //SpellsInfo[0, 1, 19] = "Passive Health Restored";//Passive Health Restored (FlatHP or %HP -restored)
            //SpellsInfo[0, 2, 19] = "Q Health Restored";    //Q Health Restored (FlatHP or %HP -restored)
            //SpellsInfo[0, 3, 19] = "W Health Restored";    //W Health Restored (FlatHP or %HP -restored)
            //SpellsInfo[0, 4, 19] = "E Health Restored";    //E Health Restored (FlatHP or %HP -restored)
            //SpellsInfo[0, 5, 19] = "R Health Restored";    //R Health Restored (FlatHP or %HP -restored)
            
            //SpellsInfo[0, 1, 20] = "Passive AD Scaling";   //Passive AD Scaling (in %)
            //SpellsInfo[0, 2, 20] = "Q AD Scaling";         //Q AD Scaling (in %)
            //SpellsInfo[0, 3, 20] = "W AD Scaling";         //W AD Scaling (in %)
            //SpellsInfo[0, 4, 20] = "E AD Scaling";         //E AD Scaling (in %)
            //SpellsInfo[0, 5, 20] = "R AD Scaling";         //R AD Scaling (in %)

            //SpellsInfo[0, 1, 21] = "Passive AP Scaling";   //Passive AP Scaling (in %)
            //SpellsInfo[0, 2, 21] = "Q AP Scaling";         //Q AP Scaling (in %)
            //SpellsInfo[0, 3, 21] = "W AP Scaling";         //W AP Scaling (in %)
            //SpellsInfo[0, 4, 21] = "E AP Scaling";         //E AP Scaling (in %)
            //SpellsInfo[0, 5, 21] = "R AP Scaling";         //R AP Scaling (in %)
            
            #endregion

            #region A
            //Aatrox 1
            #region Aatrox
            SpellsInfo[1, 0, 0] = "Aatrox";

            SpellsInfo[1, 1, 0] = SpellsInfo[1, 0, 0];
            SpellsInfo[1, 2, 0] = SpellsInfo[1, 0, 0];
            SpellsInfo[1, 3, 0] = SpellsInfo[1, 0, 0];
            SpellsInfo[1, 4, 0] = SpellsInfo[1, 0, 0];
            SpellsInfo[1, 5, 0] = SpellsInfo[1, 0, 0];

            SpellsInfo[1, 1, 1] = "blood Well";
            SpellsInfo[1, 2, 1] = "Dark Flight";
            SpellsInfo[1, 3, 1] = "Blood Thrist/Blood Prince";
            SpellsInfo[1, 4, 1] = "Blades of Torment";
            SpellsInfo[1, 5, 1] = "Massacre";

            SpellsInfo[1, 1, 2] = Type[0];
            SpellsInfo[1, 2, 2] = Type[3];
            SpellsInfo[1, 3, 2] = Type[0];
            SpellsInfo[1, 4, 2] = Type[1];
            SpellsInfo[1, 5, 2] = Type[0];

            SpellsInfo[1, 1, 3] = Null;
            SpellsInfo[1, 2, 3] = "600";
            SpellsInfo[1, 3, 3] = Null;
            SpellsInfo[1, 4, 3] = "250";
            SpellsInfo[1, 5, 3] = Null;

            SpellsInfo[1, 1, 4] = Null;
            SpellsInfo[1, 2, 4] = "650";
            SpellsInfo[1, 3, 4] = Null;
            SpellsInfo[1, 4, 4] = "1075";

            SpellsInfo[1, 5, 4] = Null;
            SpellsInfo[1, 1, 5] = Null;
            SpellsInfo[1, 2, 5] = "250";
            SpellsInfo[1, 3, 5] = Null;
            SpellsInfo[1, 4, 5] = "35";
            SpellsInfo[1, 5, 5] = Null;

            SpellsInfo[1, 1, 6] = Null;
            SpellsInfo[1, 2, 6] = "2000";
            SpellsInfo[1, 3, 6] = Null;
            SpellsInfo[1, 4, 6] = "1025";
            SpellsInfo[1, 5, 6] = Null;

            SpellsInfo[1, 1, 7] = Null;
            if (SpellsInfo[1, 1, 4] == Null) { SpellsInfo[1, 1, 7] = Null; }
            SpellsInfo[1, 2, 7] = "False";
            if (SpellsInfo[1, 2, 4] == Null) { SpellsInfo[1, 2, 7] = Null; }
            SpellsInfo[1, 3, 7] = Null;
            if (SpellsInfo[1, 3, 4] == Null) { SpellsInfo[1, 3, 7] = Null; }
            SpellsInfo[1, 4, 7] = "True";
            if (SpellsInfo[1, 4, 4] == Null) { SpellsInfo[1, 4, 7] = Null; }
            SpellsInfo[1, 5, 7] = Null;
            if (SpellsInfo[1, 5, 4] == Null) { SpellsInfo[1, 5, 7] = Null; }


            SpellsInfo[1, 1, 8] = Null;
            SpellsInfo[1, 2, 8] = "3";
            SpellsInfo[1, 3, 8] = Null;
            SpellsInfo[1, 4, 8] = "3";
            SpellsInfo[1, 5, 8] = Null;

            SpellsInfo[1, 1, 9] = Null;
            SpellsInfo[1, 2, 9] = Null;
            SpellsInfo[1, 3, 9] = Null;
            SpellsInfo[1, 4, 9] = Null;
            SpellsInfo[1, 5, 9] = Null;

            SpellsInfo[1, 1, 10] = Null;
            SpellsInfo[1, 2, 10] = Null;
            SpellsInfo[1, 3, 10] = Null;
            SpellsInfo[1, 4, 10] = Null;
            SpellsInfo[1, 5, 10] = Null;

            SpellsInfo[1, 1, 11] = "False";
            SpellsInfo[1, 2, 11] = "False";
            SpellsInfo[1, 3, 11] = "False";
            SpellsInfo[1, 4, 11] = "E Can Be Removed";
            SpellsInfo[1, 5, 11] = "R Can Be Removed";

            SpellsInfo[1, 1, 12] = "Passive Collision Objects";
            SpellsInfo[1, 2, 12] = "Q Collision Objects";
            SpellsInfo[1, 3, 12] = "W Collision Objects";
            SpellsInfo[1, 4, 12] = "E Collision Objects";
            SpellsInfo[1, 5, 12] = "R Collision Objects";

            SpellsInfo[1, 1, 13] = "Passive Cost";
            SpellsInfo[1, 2, 13] = "Q Cost";
            SpellsInfo[1, 3, 13] = "W Cost";
            SpellsInfo[1, 4, 13] = "E Cost";
            SpellsInfo[1, 5, 13] = "R Cost";

            SpellsInfo[1, 1, 14] = "Passive Cooldown";
            SpellsInfo[1, 2, 14] = "Q Cooldown";
            SpellsInfo[1, 3, 14] = "W Cooldown";
            SpellsInfo[1, 4, 14] = "E Cooldown";
            SpellsInfo[1, 5, 14] = "R Cooldown";

            SpellsInfo[1, 1, 15] = "Passive Duration";
            SpellsInfo[1, 2, 15] = "Q Duration";
            SpellsInfo[1, 3, 15] = "W Duration";
            SpellsInfo[1, 4, 15] = "E Duration";
            SpellsInfo[1, 5, 15] = "R Duration";

            SpellsInfo[1, 1, 16] = "Passive Physical Damage";
            SpellsInfo[1, 2, 16] = "Q Physical Damage";
            SpellsInfo[1, 3, 16] = "W Physical Damage";
            SpellsInfo[1, 4, 16] = "E Physical Damage";
            SpellsInfo[1, 5, 16] = "R Physical Damage";

            SpellsInfo[1, 1, 17] = "Passive Magical Damage";
            SpellsInfo[1, 2, 17] = "Q Magical Damage";
            SpellsInfo[1, 3, 17] = "W Magical Damage";
            SpellsInfo[1, 4, 17] = "E Magical Damage";
            SpellsInfo[1, 5, 17] = "R Magical Damage";

            SpellsInfo[1, 1, 18] = "Passive True Damage";
            SpellsInfo[1, 2, 18] = "Q True Damage";
            SpellsInfo[1, 3, 18] = "W True Damage";
            SpellsInfo[1, 4, 18] = "E True Damage";
            SpellsInfo[1, 5, 18] = "R True Damage";

            SpellsInfo[1, 1, 19] = "Passive Health Restored";
            SpellsInfo[1, 2, 19] = "Q Health Restored";
            SpellsInfo[1, 3, 19] = "W Health Restored";
            SpellsInfo[1, 4, 19] = "E Health Restored";
            SpellsInfo[1, 5, 19] = "R Health Restored";

            SpellsInfo[1, 1, 20] = "Passive AD Scaling";
            SpellsInfo[1, 2, 20] = "Q AD Scaling";
            SpellsInfo[1, 3, 20] = "W AD Scaling";
            SpellsInfo[1, 4, 20] = "E AD Scaling";
            SpellsInfo[1, 5, 20] = "R AD Scaling";

            SpellsInfo[1, 1, 21] = "Passive AP Scaling";
            SpellsInfo[1, 2, 21] = "Q AP Scaling";
            SpellsInfo[1, 3, 21] = "W AP Scaling";
            SpellsInfo[1, 4, 21] = "E AP Scaling";
            SpellsInfo[1, 5, 21] = "R AP Scaling";

            #endregion Aatrox

            //Ahri 2
            #region Ahri
            SpellsInfo[2, 0, 0] = "ChampionName";

            SpellsInfo[2, 1, 0] = SpellsInfo[2, 0, 0];
            SpellsInfo[2, 2, 0] = SpellsInfo[2, 0, 0];
            SpellsInfo[2, 3, 0] = SpellsInfo[2, 0, 0];
            SpellsInfo[2, 4, 0] = SpellsInfo[2, 0, 0];
            SpellsInfo[2, 5, 0] = SpellsInfo[2, 0, 0];

            SpellsInfo[2, 1, 1] = "Passive Skill Name";
            SpellsInfo[2, 2, 1] = "Q Skill Name";
            SpellsInfo[2, 3, 1] = "W Skill Name";
            SpellsInfo[2, 4, 1] = "E Skill Name";
            SpellsInfo[2, 5, 1] = "R Skill Name";

            SpellsInfo[2, 1, 2] = "Passive Type";
            SpellsInfo[2, 2, 2] = "Q Type";
            SpellsInfo[2, 3, 2] = "W Type";
            SpellsInfo[2, 4, 2] = "E Type";
            SpellsInfo[2, 5, 2] = "R Type";

            SpellsInfo[2, 1, 3] = "Passive Delay";
            SpellsInfo[2, 2, 3] = "Q Delay";
            SpellsInfo[2, 3, 3] = "W Delay";
            SpellsInfo[2, 4, 3] = "E Delay";
            SpellsInfo[2, 5, 3] = "R Delay";

            SpellsInfo[2, 1, 4] = "Passive Range";
            SpellsInfo[2, 2, 4] = "Q Range";
            SpellsInfo[2, 3, 4] = "W Range";
            SpellsInfo[2, 4, 4] = "E Range";
            SpellsInfo[2, 5, 4] = "R Range";

            SpellsInfo[2, 1, 5] = "Passive Radius";
            SpellsInfo[2, 2, 5] = "Q Radius";
            SpellsInfo[2, 3, 5] = "W Radius";
            SpellsInfo[2, 4, 5] = "E Radius";
            SpellsInfo[2, 5, 5] = "R Radius";

            SpellsInfo[2, 1, 6] = "Passive Missile Speed";
            SpellsInfo[2, 2, 6] = "Q Missile Speed";
            SpellsInfo[2, 3, 6] = "W Missile Speed";
            SpellsInfo[2, 4, 6] = "E Missile Speed";
            SpellsInfo[2, 5, 6] = "R Missile Speed";

            SpellsInfo[2, 1, 7] = "Passive Fixed Range";
            SpellsInfo[2, 2, 7] = "Q Fixed Range";
            SpellsInfo[2, 3, 7] = "W Fixed Range";
            SpellsInfo[2, 4, 7] = "E Fixed Range";
            SpellsInfo[2, 5, 7] = "R Fixed Range";

            SpellsInfo[2, 1, 8] = "Passive Danger Value";
            SpellsInfo[2, 2, 8] = "Q Danger Value";
            SpellsInfo[2, 3, 8] = "W Danger Value";
            SpellsInfo[2, 4, 8] = "E Danger Value";
            SpellsInfo[2, 5, 8] = "R Danger Value";

            SpellsInfo[2, 1, 9] = "Passive Multiple Number";
            SpellsInfo[2, 2, 9] = "Q Multiple Number";
            SpellsInfo[2, 3, 9] = "W Multiple Number";
            SpellsInfo[2, 4, 9] = "E Multiple Number";
            SpellsInfo[2, 5, 9] = "R Multiple Number";

            SpellsInfo[2, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[2, 2, 10] = "Q Multiple Angle";
            SpellsInfo[2, 3, 10] = "W Multiple Angle";
            SpellsInfo[2, 4, 10] = "E Multiple Angle";
            SpellsInfo[2, 5, 10] = "R Multiple Angle";

            SpellsInfo[2, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[2, 2, 11] = "Q Can Be Removed";
            SpellsInfo[2, 3, 11] = "W Can Be Removed";
            SpellsInfo[2, 4, 11] = "E Can Be Removed";
            SpellsInfo[2, 5, 11] = "R Can Be Removed";

            SpellsInfo[2, 1, 12] = "Passive Collision Objects";
            SpellsInfo[2, 2, 12] = "Q Collision Objects";
            SpellsInfo[2, 3, 12] = "W Collision Objects";
            SpellsInfo[2, 4, 12] = "E Collision Objects";
            SpellsInfo[2, 5, 12] = "R Collision Objects";

            SpellsInfo[2, 1, 13] = "Passive Cost";
            SpellsInfo[2, 2, 13] = "Q Cost";
            SpellsInfo[2, 3, 13] = "W Cost";
            SpellsInfo[2, 4, 13] = "E Cost";
            SpellsInfo[2, 5, 13] = "R Cost";

            SpellsInfo[2, 1, 14] = "Passive Cooldown";
            SpellsInfo[2, 2, 14] = "Q Cooldown";
            SpellsInfo[2, 3, 14] = "W Cooldown";
            SpellsInfo[2, 4, 14] = "E Cooldown";
            SpellsInfo[2, 5, 14] = "R Cooldown";

            SpellsInfo[2, 1, 15] = "Passive Duration";
            SpellsInfo[2, 2, 15] = "Q Duration";
            SpellsInfo[2, 3, 15] = "W Duration";
            SpellsInfo[2, 4, 15] = "E Duration";
            SpellsInfo[2, 5, 15] = "R Duration";

            SpellsInfo[2, 1, 16] = "Passive Physical Damage";
            SpellsInfo[2, 2, 16] = "Q Physical Damage";
            SpellsInfo[2, 3, 16] = "W Physical Damage";
            SpellsInfo[2, 4, 16] = "E Physical Damage";
            SpellsInfo[2, 5, 16] = "R Physical Damage";

            SpellsInfo[2, 1, 17] = "Passive Magical Damage";
            SpellsInfo[2, 2, 17] = "Q Magical Damage";
            SpellsInfo[2, 3, 17] = "W Magical Damage";
            SpellsInfo[2, 4, 17] = "E Magical Damage";
            SpellsInfo[2, 5, 17] = "R Magical Damage";

            SpellsInfo[2, 1, 18] = "Passive True Damage";
            SpellsInfo[2, 2, 18] = "Q True Damage";
            SpellsInfo[2, 3, 18] = "W True Damage";
            SpellsInfo[2, 4, 18] = "E True Damage";
            SpellsInfo[2, 5, 18] = "R True Damage";

            SpellsInfo[2, 1, 19] = "Passive Health Restored";
            SpellsInfo[2, 2, 19] = "Q Health Restored";
            SpellsInfo[2, 3, 19] = "W Health Restored";
            SpellsInfo[2, 4, 19] = "E Health Restored";
            SpellsInfo[2, 5, 19] = "R Health Restored";

            SpellsInfo[2, 1, 20] = "Passive AD Scaling";
            SpellsInfo[2, 2, 20] = "Q AD Scaling";
            SpellsInfo[2, 3, 20] = "W AD Scaling";
            SpellsInfo[2, 4, 20] = "E AD Scaling";
            SpellsInfo[2, 5, 20] = "R AD Scaling";

            SpellsInfo[2, 1, 21] = "Passive AP Scaling";
            SpellsInfo[2, 2, 21] = "Q AP Scaling";
            SpellsInfo[2, 3, 21] = "W AP Scaling";
            SpellsInfo[2, 4, 21] = "E AP Scaling";
            SpellsInfo[2, 5, 21] = "R AP Scaling";
            #endregion Ahri

            //Akali 3
            #region Akali
            SpellsInfo[3, 0, 0] = "ChampionName";

            SpellsInfo[3, 1, 0] = SpellsInfo[3, 0, 0];
            SpellsInfo[3, 2, 0] = SpellsInfo[3, 0, 0];
            SpellsInfo[3, 3, 0] = SpellsInfo[3, 0, 0];
            SpellsInfo[3, 4, 0] = SpellsInfo[3, 0, 0];
            SpellsInfo[3, 5, 0] = SpellsInfo[3, 0, 0];

            SpellsInfo[3, 1, 1] = "Passive Skill Name";
            SpellsInfo[3, 2, 1] = "Q Skill Name";
            SpellsInfo[3, 3, 1] = "W Skill Name";
            SpellsInfo[3, 4, 1] = "E Skill Name";
            SpellsInfo[3, 5, 1] = "R Skill Name";

            SpellsInfo[3, 1, 2] = "Passive Type";
            SpellsInfo[3, 2, 2] = "Q Type";
            SpellsInfo[3, 3, 2] = "W Type";
            SpellsInfo[3, 4, 2] = "E Type";
            SpellsInfo[3, 5, 2] = "R Type";

            SpellsInfo[3, 1, 3] = "Passive Delay";
            SpellsInfo[3, 2, 3] = "Q Delay";
            SpellsInfo[3, 3, 3] = "W Delay";
            SpellsInfo[3, 4, 3] = "E Delay";
            SpellsInfo[3, 5, 3] = "R Delay";

            SpellsInfo[3, 1, 4] = "Passive Range";
            SpellsInfo[3, 2, 4] = "Q Range";
            SpellsInfo[3, 3, 4] = "W Range";
            SpellsInfo[3, 4, 4] = "E Range";
            SpellsInfo[3, 5, 4] = "R Range";

            SpellsInfo[3, 1, 5] = "Passive Radius";
            SpellsInfo[3, 2, 5] = "Q Radius";
            SpellsInfo[3, 3, 5] = "W Radius";
            SpellsInfo[3, 4, 5] = "E Radius";
            SpellsInfo[3, 5, 5] = "R Radius";

            SpellsInfo[3, 1, 6] = "Passive Missile Speed";
            SpellsInfo[3, 2, 6] = "Q Missile Speed";
            SpellsInfo[3, 3, 6] = "W Missile Speed";
            SpellsInfo[3, 4, 6] = "E Missile Speed";
            SpellsInfo[3, 5, 6] = "R Missile Speed";

            SpellsInfo[3, 1, 7] = "Passive Fixed Range";
            SpellsInfo[3, 2, 7] = "Q Fixed Range";
            SpellsInfo[3, 3, 7] = "W Fixed Range";
            SpellsInfo[3, 4, 7] = "E Fixed Range";
            SpellsInfo[3, 5, 7] = "R Fixed Range";

            SpellsInfo[3, 1, 8] = "Passive Danger Value";
            SpellsInfo[3, 2, 8] = "Q Danger Value";
            SpellsInfo[3, 3, 8] = "W Danger Value";
            SpellsInfo[3, 4, 8] = "E Danger Value";
            SpellsInfo[3, 5, 8] = "R Danger Value";

            SpellsInfo[3, 1, 9] = "Passive Multiple Number";
            SpellsInfo[3, 2, 9] = "Q Multiple Number";
            SpellsInfo[3, 3, 9] = "W Multiple Number";
            SpellsInfo[3, 4, 9] = "E Multiple Number";
            SpellsInfo[3, 5, 9] = "R Multiple Number";

            SpellsInfo[3, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[3, 2, 10] = "Q Multiple Angle";
            SpellsInfo[3, 3, 10] = "W Multiple Angle";
            SpellsInfo[3, 4, 10] = "E Multiple Angle";
            SpellsInfo[3, 5, 10] = "R Multiple Angle";

            SpellsInfo[3, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[3, 2, 11] = "Q Can Be Removed";
            SpellsInfo[3, 3, 11] = "W Can Be Removed";
            SpellsInfo[3, 4, 11] = "E Can Be Removed";
            SpellsInfo[3, 5, 11] = "R Can Be Removed";

            SpellsInfo[3, 1, 12] = "Passive Collision Objects";
            SpellsInfo[3, 2, 12] = "Q Collision Objects";
            SpellsInfo[3, 3, 12] = "W Collision Objects";
            SpellsInfo[3, 4, 12] = "E Collision Objects";
            SpellsInfo[3, 5, 12] = "R Collision Objects";

            SpellsInfo[3, 1, 13] = "Passive Cost";
            SpellsInfo[3, 2, 13] = "Q Cost";
            SpellsInfo[3, 3, 13] = "W Cost";
            SpellsInfo[3, 4, 13] = "E Cost";
            SpellsInfo[3, 5, 13] = "R Cost";

            SpellsInfo[3, 1, 14] = "Passive Cooldown";
            SpellsInfo[3, 2, 14] = "Q Cooldown";
            SpellsInfo[3, 3, 14] = "W Cooldown";
            SpellsInfo[3, 4, 14] = "E Cooldown";
            SpellsInfo[3, 5, 14] = "R Cooldown";

            SpellsInfo[3, 1, 15] = "Passive Duration";
            SpellsInfo[3, 2, 15] = "Q Duration";
            SpellsInfo[3, 3, 15] = "W Duration";
            SpellsInfo[3, 4, 15] = "E Duration";
            SpellsInfo[3, 5, 15] = "R Duration";

            SpellsInfo[3, 1, 16] = "Passive Physical Damage";
            SpellsInfo[3, 2, 16] = "Q Physical Damage";
            SpellsInfo[3, 3, 16] = "W Physical Damage";
            SpellsInfo[3, 4, 16] = "E Physical Damage";
            SpellsInfo[3, 5, 16] = "R Physical Damage";

            SpellsInfo[3, 1, 17] = "Passive Magical Damage";
            SpellsInfo[3, 2, 17] = "Q Magical Damage";
            SpellsInfo[3, 3, 17] = "W Magical Damage";
            SpellsInfo[3, 4, 17] = "E Magical Damage";
            SpellsInfo[3, 5, 17] = "R Magical Damage";

            SpellsInfo[3, 1, 18] = "Passive True Damage";
            SpellsInfo[3, 2, 18] = "Q True Damage";
            SpellsInfo[3, 3, 18] = "W True Damage";
            SpellsInfo[3, 4, 18] = "E True Damage";
            SpellsInfo[3, 5, 18] = "R True Damage";

            SpellsInfo[3, 1, 19] = "Passive Health Restored";
            SpellsInfo[3, 2, 19] = "Q Health Restored";
            SpellsInfo[3, 3, 19] = "W Health Restored";
            SpellsInfo[3, 4, 19] = "E Health Restored";
            SpellsInfo[3, 5, 19] = "R Health Restored";

            SpellsInfo[3, 1, 20] = "Passive AD Scaling";
            SpellsInfo[3, 2, 20] = "Q AD Scaling";
            SpellsInfo[3, 3, 20] = "W AD Scaling";
            SpellsInfo[3, 4, 20] = "E AD Scaling";
            SpellsInfo[3, 5, 20] = "R AD Scaling";

            SpellsInfo[3, 1, 21] = "Passive AP Scaling";
            SpellsInfo[3, 2, 21] = "Q AP Scaling";
            SpellsInfo[3, 3, 21] = "W AP Scaling";
            SpellsInfo[3, 4, 21] = "E AP Scaling";
            SpellsInfo[3, 5, 21] = "R AP Scaling";
            #endregion Akali

            //Allistar 4
            #region Allistar
            SpellsInfo[4, 0, 0] = "ChampionName";

            SpellsInfo[4, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[4, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[4, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[4, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[4, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[4, 1, 1] = "Passive Skill Name";
            SpellsInfo[4, 2, 1] = "Q Skill Name";
            SpellsInfo[4, 3, 1] = "W Skill Name";
            SpellsInfo[4, 4, 1] = "E Skill Name";
            SpellsInfo[4, 5, 1] = "R Skill Name";

            SpellsInfo[4, 1, 2] = "Passive Type";
            SpellsInfo[4, 2, 2] = "Q Type";
            SpellsInfo[4, 3, 2] = "W Type";
            SpellsInfo[4, 4, 2] = "E Type";
            SpellsInfo[4, 5, 2] = "R Type";

            SpellsInfo[4, 1, 3] = "Passive Delay";
            SpellsInfo[4, 2, 3] = "Q Delay";
            SpellsInfo[4, 3, 3] = "W Delay";
            SpellsInfo[4, 4, 3] = "E Delay";
            SpellsInfo[4, 5, 3] = "R Delay";

            SpellsInfo[4, 1, 4] = "Passive Range";
            SpellsInfo[4, 2, 4] = "Q Range";
            SpellsInfo[4, 3, 4] = "W Range";
            SpellsInfo[4, 4, 4] = "E Range";
            SpellsInfo[4, 5, 4] = "R Range";

            SpellsInfo[4, 1, 5] = "Passive Radius";
            SpellsInfo[4, 2, 5] = "Q Radius";
            SpellsInfo[4, 3, 5] = "W Radius";
            SpellsInfo[4, 4, 5] = "E Radius";
            SpellsInfo[4, 5, 5] = "R Radius";

            SpellsInfo[4, 1, 6] = "Passive Missile Speed";
            SpellsInfo[4, 2, 6] = "Q Missile Speed";
            SpellsInfo[4, 3, 6] = "W Missile Speed";
            SpellsInfo[4, 4, 6] = "E Missile Speed";
            SpellsInfo[4, 5, 6] = "R Missile Speed";

            SpellsInfo[4, 1, 7] = "Passive Fixed Range";
            SpellsInfo[4, 2, 7] = "Q Fixed Range";
            SpellsInfo[4, 3, 7] = "W Fixed Range";
            SpellsInfo[4, 4, 7] = "E Fixed Range";
            SpellsInfo[4, 5, 7] = "R Fixed Range";

            SpellsInfo[4, 1, 8] = "Passive Danger Value";
            SpellsInfo[4, 2, 8] = "Q Danger Value";
            SpellsInfo[4, 3, 8] = "W Danger Value";
            SpellsInfo[4, 4, 8] = "E Danger Value";
            SpellsInfo[4, 5, 8] = "R Danger Value";

            SpellsInfo[4, 1, 9] = "Passive Multiple Number";
            SpellsInfo[4, 2, 9] = "Q Multiple Number";
            SpellsInfo[4, 3, 9] = "W Multiple Number";
            SpellsInfo[4, 4, 9] = "E Multiple Number";
            SpellsInfo[4, 5, 9] = "R Multiple Number";

            SpellsInfo[4, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[4, 2, 10] = "Q Multiple Angle";
            SpellsInfo[4, 3, 10] = "W Multiple Angle";
            SpellsInfo[4, 4, 10] = "E Multiple Angle";
            SpellsInfo[4, 5, 10] = "R Multiple Angle";

            SpellsInfo[4, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[4, 2, 11] = "Q Can Be Removed";
            SpellsInfo[4, 3, 11] = "W Can Be Removed";
            SpellsInfo[4, 4, 11] = "E Can Be Removed";
            SpellsInfo[4, 5, 11] = "R Can Be Removed";

            SpellsInfo[4, 1, 12] = "Passive Collision Objects";
            SpellsInfo[4, 2, 12] = "Q Collision Objects";
            SpellsInfo[4, 3, 12] = "W Collision Objects";
            SpellsInfo[4, 4, 12] = "E Collision Objects";
            SpellsInfo[4, 5, 12] = "R Collision Objects";

            SpellsInfo[4, 1, 13] = "Passive Cost";
            SpellsInfo[4, 2, 13] = "Q Cost";
            SpellsInfo[4, 3, 13] = "W Cost";
            SpellsInfo[4, 4, 13] = "E Cost";
            SpellsInfo[4, 5, 13] = "R Cost";

            SpellsInfo[4, 1, 14] = "Passive Cooldown";
            SpellsInfo[4, 2, 14] = "Q Cooldown";
            SpellsInfo[4, 3, 14] = "W Cooldown";
            SpellsInfo[4, 4, 14] = "E Cooldown";
            SpellsInfo[4, 5, 14] = "R Cooldown";

            SpellsInfo[4, 1, 15] = "Passive Duration";
            SpellsInfo[4, 2, 15] = "Q Duration";
            SpellsInfo[4, 3, 15] = "W Duration";
            SpellsInfo[4, 4, 15] = "E Duration";
            SpellsInfo[4, 5, 15] = "R Duration";

            SpellsInfo[4, 1, 16] = "Passive Physical Damage";
            SpellsInfo[4, 2, 16] = "Q Physical Damage";
            SpellsInfo[4, 3, 16] = "W Physical Damage";
            SpellsInfo[4, 4, 16] = "E Physical Damage";
            SpellsInfo[4, 5, 16] = "R Physical Damage";

            SpellsInfo[4, 1, 17] = "Passive Magical Damage";
            SpellsInfo[4, 2, 17] = "Q Magical Damage";
            SpellsInfo[4, 3, 17] = "W Magical Damage";
            SpellsInfo[4, 4, 17] = "E Magical Damage";
            SpellsInfo[4, 5, 17] = "R Magical Damage";

            SpellsInfo[4, 1, 18] = "Passive True Damage";
            SpellsInfo[4, 2, 18] = "Q True Damage";
            SpellsInfo[4, 3, 18] = "W True Damage";
            SpellsInfo[4, 4, 18] = "E True Damage";
            SpellsInfo[4, 5, 18] = "R True Damage";

            SpellsInfo[4, 1, 19] = "Passive Health Restored";
            SpellsInfo[4, 2, 19] = "Q Health Restored";
            SpellsInfo[4, 3, 19] = "W Health Restored";
            SpellsInfo[4, 4, 19] = "E Health Restored";
            SpellsInfo[4, 5, 19] = "R Health Restored";

            SpellsInfo[4, 1, 20] = "Passive AD Scaling";
            SpellsInfo[4, 2, 20] = "Q AD Scaling";
            SpellsInfo[4, 3, 20] = "W AD Scaling";
            SpellsInfo[4, 4, 20] = "E AD Scaling";
            SpellsInfo[4, 5, 20] = "R AD Scaling";

            SpellsInfo[4, 1, 21] = "Passive AP Scaling";
            SpellsInfo[4, 2, 21] = "Q AP Scaling";
            SpellsInfo[4, 3, 21] = "W AP Scaling";
            SpellsInfo[4, 4, 21] = "E AP Scaling";
            SpellsInfo[4, 5, 21] = "R AP Scaling";
            #endregion Allistar
            
            //Amumu 5
            #region Amumu
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Amumu
            
            //Anivia 6
            #region Anivia
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Anivia

            //Annie 7
            #region Annie
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Annie

            //Ashe 8
            #region Ashe
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Ashe

            //Azir 9
            #region Azir
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Azir
            #endregion A
            #region B
            //Blitzcrank 10
            #region Blitzcrank
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Blitzcrank

            //Brand 11
            #region Brand
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Brand

            //Braum
            #region Braum
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Braum
            #endregion B
            #region C
            //Caitlyn
            #region Caitlyn
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Caitlyn

            //Cassiopeia
            #region Cassiopiea
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Cassiopiea

            //Cho'Gath
            #region Cho'Gath
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Cho'gath

            //Corki
            #region Corki
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Corki
            #endregion C
            #region D

            //Darius
            #region Darius
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Darius

            //Diana
            #region Dianna
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Diana

            //Dr. Mundo
            #region Dr.Mundo
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Dr.Mundo

            //Draven
            #region Draven
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Draven
            #endregion D
            #region E

            //Elise
            #region Elise
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Elise

            //Evelynn
            #region Evelynn
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Evelynn

            //ezreal
            #region Ezreal
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Ezreal
            #endregion E
            #region F

            //Fiddlesticks
            #region Fiddle
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Fiddle

            //Fiora
            #region Fiora
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Fiora

            //Fizz
            #region Fizz
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Fizz
            #endregion F
            #region G

            //Galio
            #region Galio
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Galio

            //Gangplank
            #region GP
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion GP

            //Garen
            #region Garen
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Garen

            //Gnar
            #region Gnar
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Gnar

            //Gragas
            #region Gragas
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Gragas

            //Graves
            #region Graves
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Graves
            #endregion G
            #region H

            //Hecarim
            #region Hecarim
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Hecarim

            //Heimerdinger
            #region Donger
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Donger
            #endregion H
            #region I
            //Irelia
            #region Irelia
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Irelia
            #endregion I
            #region J

            //Janna
            #region Janna
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Janna

            //Jarvan 4
            #region J4
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion J4

            //Jax
            #region Jax
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Jax

            //Jinx
            #region JInx
            SpellsInfo[0, 0, 0] = "ChampionName";

            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];

            SpellsInfo[0, 1, 1] = "Passive Skill Name";
            SpellsInfo[0, 2, 1] = "Q Skill Name";
            SpellsInfo[0, 3, 1] = "W Skill Name";
            SpellsInfo[0, 4, 1] = "E Skill Name";
            SpellsInfo[0, 5, 1] = "R Skill Name";

            SpellsInfo[0, 1, 2] = "Passive Type";
            SpellsInfo[0, 2, 2] = "Q Type";
            SpellsInfo[0, 3, 2] = "W Type";
            SpellsInfo[0, 4, 2] = "E Type";
            SpellsInfo[0, 5, 2] = "R Type";

            SpellsInfo[0, 1, 3] = "Passive Delay";
            SpellsInfo[0, 2, 3] = "Q Delay";
            SpellsInfo[0, 3, 3] = "W Delay";
            SpellsInfo[0, 4, 3] = "E Delay";
            SpellsInfo[0, 5, 3] = "R Delay";

            SpellsInfo[0, 1, 4] = "Passive Range";
            SpellsInfo[0, 2, 4] = "Q Range";
            SpellsInfo[0, 3, 4] = "W Range";
            SpellsInfo[0, 4, 4] = "E Range";
            SpellsInfo[0, 5, 4] = "R Range";

            SpellsInfo[0, 1, 5] = "Passive Radius";
            SpellsInfo[0, 2, 5] = "Q Radius";
            SpellsInfo[0, 3, 5] = "W Radius";
            SpellsInfo[0, 4, 5] = "E Radius";
            SpellsInfo[0, 5, 5] = "R Radius";

            SpellsInfo[0, 1, 6] = "Passive Missile Speed";
            SpellsInfo[0, 2, 6] = "Q Missile Speed";
            SpellsInfo[0, 3, 6] = "W Missile Speed";
            SpellsInfo[0, 4, 6] = "E Missile Speed";
            SpellsInfo[0, 5, 6] = "R Missile Speed";

            SpellsInfo[0, 1, 7] = "Passive Fixed Range";
            SpellsInfo[0, 2, 7] = "Q Fixed Range";
            SpellsInfo[0, 3, 7] = "W Fixed Range";
            SpellsInfo[0, 4, 7] = "E Fixed Range";
            SpellsInfo[0, 5, 7] = "R Fixed Range";

            SpellsInfo[0, 1, 8] = "Passive Danger Value";
            SpellsInfo[0, 2, 8] = "Q Danger Value";
            SpellsInfo[0, 3, 8] = "W Danger Value";
            SpellsInfo[0, 4, 8] = "E Danger Value";
            SpellsInfo[0, 5, 8] = "R Danger Value";

            SpellsInfo[0, 1, 9] = "Passive Multiple Number";
            SpellsInfo[0, 2, 9] = "Q Multiple Number";
            SpellsInfo[0, 3, 9] = "W Multiple Number";
            SpellsInfo[0, 4, 9] = "E Multiple Number";
            SpellsInfo[0, 5, 9] = "R Multiple Number";

            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";
            SpellsInfo[0, 2, 10] = "Q Multiple Angle";
            SpellsInfo[0, 3, 10] = "W Multiple Angle";
            SpellsInfo[0, 4, 10] = "E Multiple Angle";
            SpellsInfo[0, 5, 10] = "R Multiple Angle";

            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";
            SpellsInfo[0, 2, 11] = "Q Can Be Removed";
            SpellsInfo[0, 3, 11] = "W Can Be Removed";
            SpellsInfo[0, 4, 11] = "E Can Be Removed";
            SpellsInfo[0, 5, 11] = "R Can Be Removed";

            SpellsInfo[0, 1, 12] = "Passive Collision Objects";
            SpellsInfo[0, 2, 12] = "Q Collision Objects";
            SpellsInfo[0, 3, 12] = "W Collision Objects";
            SpellsInfo[0, 4, 12] = "E Collision Objects";
            SpellsInfo[0, 5, 12] = "R Collision Objects";

            SpellsInfo[0, 1, 13] = "Passive Cost";
            SpellsInfo[0, 2, 13] = "Q Cost";
            SpellsInfo[0, 3, 13] = "W Cost";
            SpellsInfo[0, 4, 13] = "E Cost";
            SpellsInfo[0, 5, 13] = "R Cost";

            SpellsInfo[0, 1, 14] = "Passive Cooldown";
            SpellsInfo[0, 2, 14] = "Q Cooldown";
            SpellsInfo[0, 3, 14] = "W Cooldown";
            SpellsInfo[0, 4, 14] = "E Cooldown";
            SpellsInfo[0, 5, 14] = "R Cooldown";

            SpellsInfo[0, 1, 15] = "Passive Duration";
            SpellsInfo[0, 2, 15] = "Q Duration";
            SpellsInfo[0, 3, 15] = "W Duration";
            SpellsInfo[0, 4, 15] = "E Duration";
            SpellsInfo[0, 5, 15] = "R Duration";

            SpellsInfo[0, 1, 16] = "Passive Physical Damage";
            SpellsInfo[0, 2, 16] = "Q Physical Damage";
            SpellsInfo[0, 3, 16] = "W Physical Damage";
            SpellsInfo[0, 4, 16] = "E Physical Damage";
            SpellsInfo[0, 5, 16] = "R Physical Damage";

            SpellsInfo[0, 1, 17] = "Passive Magical Damage";
            SpellsInfo[0, 2, 17] = "Q Magical Damage";
            SpellsInfo[0, 3, 17] = "W Magical Damage";
            SpellsInfo[0, 4, 17] = "E Magical Damage";
            SpellsInfo[0, 5, 17] = "R Magical Damage";

            SpellsInfo[0, 1, 18] = "Passive True Damage";
            SpellsInfo[0, 2, 18] = "Q True Damage";
            SpellsInfo[0, 3, 18] = "W True Damage";
            SpellsInfo[0, 4, 18] = "E True Damage";
            SpellsInfo[0, 5, 18] = "R True Damage";

            SpellsInfo[0, 1, 19] = "Passive Health Restored";
            SpellsInfo[0, 2, 19] = "Q Health Restored";
            SpellsInfo[0, 3, 19] = "W Health Restored";
            SpellsInfo[0, 4, 19] = "E Health Restored";
            SpellsInfo[0, 5, 19] = "R Health Restored";

            SpellsInfo[0, 1, 20] = "Passive AD Scaling";
            SpellsInfo[0, 2, 20] = "Q AD Scaling";
            SpellsInfo[0, 3, 20] = "W AD Scaling";
            SpellsInfo[0, 4, 20] = "E AD Scaling";
            SpellsInfo[0, 5, 20] = "R AD Scaling";

            SpellsInfo[0, 1, 21] = "Passive AP Scaling";
            SpellsInfo[0, 2, 21] = "Q AP Scaling";
            SpellsInfo[0, 3, 21] = "W AP Scaling";
            SpellsInfo[0, 4, 21] = "E AP Scaling";
            SpellsInfo[0, 5, 21] = "R AP Scaling";
            #endregion Jinx
            #endregion J


        }
    }
}