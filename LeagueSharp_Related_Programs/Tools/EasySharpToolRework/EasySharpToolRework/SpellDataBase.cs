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
        public String[, ,] SpellsInfo;
        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            SpellsInfo = new String[124, 6, 23]; //That's 16368 Slots of data, Mein Neger, Deal with it

            /*
             * SpellsInfo[A,B,C]
             * 
             * A = Champion: 124 possibilities, 0 = Example
             * B = SpellSlot: 1 = passive, 2 = Q, 3 = W, 4 = E, 5 = R  (Do Not Use 0, it is added for convience)
             * C = InfoLabel: 0 = Champion, 1 = Name, 2 = Type, 3 = Delay, 4 = Range, 5 = Radius, 6 = Missile Speed, 7 = Fixed Range, 8 = Danger Value(From #Evade), 9 = Multiple Number, 10 = Multiple Angle
             * C = InfoLabel: 11 = Can Be Removed, 12 = Collision Objects, 13 = Cost, 14 = Cooldown, 15 = Duration, 16 = Physical Damage, 17 = Magic Damage, 18 = True Damage, 19 = Health Restored, 20 = AD Scaling, 21 = AP Scaling
             * 
             * SpellsInfo[A,B,C]
             * /

            /*
             * Example Reference
             */
            SpellsInfo[0, 0, 0] = "ChampionName";         //ChampionName For DropDownBox
            
            SpellsInfo[0, 1, 0] = SpellsInfo[0, 0, 0];    //ChampionName for Passive slot, Champion Slot
            SpellsInfo[0, 2, 0] = SpellsInfo[0, 0, 0];    //ChampionName for Q slot, Champion Slot
            SpellsInfo[0, 3, 0] = SpellsInfo[0, 0, 0];    //ChampionName for W slot, Champion Slot
            SpellsInfo[0, 4, 0] = SpellsInfo[0, 0, 0];    //ChampionName for E slot, Champion Slot
            SpellsInfo[0, 5, 0] = SpellsInfo[0, 0, 0];    //ChampionName for R slot, Champion Slot
            
            SpellsInfo[0, 1, 1] = "Passive Skill Name";   //Passive Ability Name
            SpellsInfo[0, 2, 1] = "Q Skill Name";         //Q Ability Name
            SpellsInfo[0, 3, 1] = "W Skill Name";         //W Ability Name
            SpellsInfo[0, 4, 1] = "E Skill Name";         //E Ability Name
            SpellsInfo[0, 5, 1] = "R Skill Name";         //R Ability Name
            
            SpellsInfo[0, 1, 2] = "Passive Type";         //Passive Ability Type (Non-SkillShot, SkillShotLine, SkillShotCone, SkillShotCircle)
            SpellsInfo[0, 2, 2] = "Q Type";               //Q Ability Type (Non-SkillShot, SkillShotLine, SkillShotCone, SkillShotCircle)
            SpellsInfo[0, 3, 2] = "W Type";               //W Ability Type (Non-SkillShot, SkillShotLine, SkillShotCone, SkillShotCircle)
            SpellsInfo[0, 4, 2] = "E Type";               //E Ability Type (Non-SkillShot, SkillShotLine, SkillShotCone, SkillShotCircle)
            SpellsInfo[0, 5, 2] = "R Type";               //R Ability Type (Non-SkillShot, SkillShotLine, SkillShotCone, SkillShotCircle)
            
            SpellsInfo[0, 1, 3] = "Passive Delay";        //Passive Delay
            SpellsInfo[0, 2, 3] = "Q Delay";              //Q Delay
            SpellsInfo[0, 3, 3] = "W Delay";              //W Delay
            SpellsInfo[0, 4, 3] = "E Delay";              //E Delay
            SpellsInfo[0, 5, 3] = "R Delay";              //R Delay
            
            SpellsInfo[0, 1, 4] = "Passive Range";        //Passive Range
            SpellsInfo[0, 2, 4] = "Q Range";              //Q Range
            SpellsInfo[0, 3, 4] = "W Range";              //W Range
            SpellsInfo[0, 4, 4] = "E Range";              //E Range
            SpellsInfo[0, 5, 4] = "R Range";              //R Range
            
            SpellsInfo[0, 1, 5] = "Passive Radius";       //Passive Radius
            SpellsInfo[0, 2, 5] = "Q Radius";             //Q Radius
            SpellsInfo[0, 3, 5] = "W Radius";             //W Radius
            SpellsInfo[0, 4, 5] = "E Radius";             //E Radius
            SpellsInfo[0, 5, 5] = "R Radius";             //R Radius
            
            SpellsInfo[0, 1, 6] = "Passive Missile Speed";//Passive Missile Speed
            SpellsInfo[0, 2, 6] = "Q Missile Speed";      //Q Missile Speed
            SpellsInfo[0, 3, 6] = "W Missile Speed";      //W Missile Speed
            SpellsInfo[0, 4, 6] = "E Missile Speed";      //E Missile Speed
            SpellsInfo[0, 5, 6] = "R Missile Speed";      //R Missile Speed
            
            SpellsInfo[0, 1, 7] = "Passive Fixed Range";           //
            SpellsInfo[0, 2, 7] = "Passive Fixed Range";           //
            SpellsInfo[0, 3, 7] = "Passive Fixed Range";           //
            SpellsInfo[0, 4, 7] = "Passive Fixed Range";           //
            SpellsInfo[0, 5, 7] = "Passive Fixed Range";           //
            
            SpellsInfo[0, 1, 8] = "Passive Danger Value";           //
            SpellsInfo[0, 2, 8] = "Passive Danger Value";           //
            SpellsInfo[0, 3, 8] = "Passive Danger Value";           //
            SpellsInfo[0, 4, 8] = "Passive Danger Value";           //
            SpellsInfo[0, 5, 8] = "Passive Danger Value";           //
            
            SpellsInfo[0, 1, 9] = "Passive Multiple Number";           //
            SpellsInfo[0, 2, 9] = "";           //
            SpellsInfo[0, 3, 9] = "";           //
            SpellsInfo[0, 4, 9] = "";           //
            SpellsInfo[0, 5, 9] = "";           //
            
            SpellsInfo[0, 1, 10] = "Passive Multiple Angle";          //
            SpellsInfo[0, 2, 10] = "";          //
            SpellsInfo[0, 3, 10] = "";          //
            SpellsInfo[0, 4, 10] = "";          //
            SpellsInfo[0, 5, 10] = "";          //
            
            SpellsInfo[0, 1, 11] = "Passive Can Be Removed";          //
            SpellsInfo[0, 2, 11] = "";          //
            SpellsInfo[0, 3, 11] = "";          //
            SpellsInfo[0, 4, 11] = "";          //
            SpellsInfo[0, 5, 11] = "";          //
            
            SpellsInfo[0, 1, 12] = "Passive Collision Objects";          //
            SpellsInfo[0, 2, 12] = "";          //
            SpellsInfo[0, 3, 12] = "";          //
            SpellsInfo[0, 4, 12] = "";          //
            SpellsInfo[0, 5, 12] = "";          //
            
            SpellsInfo[0, 1, 13] = "Passive Cost";          //
            SpellsInfo[0, 2, 13] = "";          //
            SpellsInfo[0, 3, 13] = "";          //
            SpellsInfo[0, 4, 13] = "";          //
            SpellsInfo[0, 5, 13] = "";          //
            
            SpellsInfo[0, 1, 14] = "Passive Cooldown";          //
            SpellsInfo[0, 2, 14] = "";          //
            SpellsInfo[0, 3, 14] = "";          //
            SpellsInfo[0, 4, 14] = "";          //
            SpellsInfo[0, 5, 14] = "";          //
            
            SpellsInfo[0, 1, 15] = "Passive Duration";          //
            SpellsInfo[0, 2, 15] = "";          //
            SpellsInfo[0, 3, 15] = "";          //
            SpellsInfo[0, 4, 15] = "";          //
            SpellsInfo[0, 5, 15] = "";          //
            
            SpellsInfo[0, 1, 16] = "Passive Physical Damage";          //
            SpellsInfo[0, 2, 16] = "";          //
            SpellsInfo[0, 3, 16] = "";          //
            SpellsInfo[0, 4, 16] = "";          //
            SpellsInfo[0, 5, 16] = "";          //
            
            SpellsInfo[0, 1, 17] = "Passive Magical Damage";          //
            SpellsInfo[0, 2, 17] = "";          //
            SpellsInfo[0, 3, 17] = "";          //
            SpellsInfo[0, 4, 17] = "";          //
            SpellsInfo[0, 5, 17] = "";          //
            
            SpellsInfo[0, 1, 18] = "Passive True Damage";          //
            SpellsInfo[0, 2, 18] = "";          //
            SpellsInfo[0, 3, 18] = "";          //
            SpellsInfo[0, 4, 18] = "";          //
            SpellsInfo[0, 5, 18] = "";          //
            
            SpellsInfo[0, 1, 19] = "Passive Health Restored";          //
            SpellsInfo[0, 2, 19] = "";          //
            SpellsInfo[0, 3, 19] = "";          //
            SpellsInfo[0, 4, 19] = "";          //
            SpellsInfo[0, 5, 19] = "";          //
            
            SpellsInfo[0, 1, 20] = "Passive AD Scaling";          //
            SpellsInfo[0, 2, 20] = "";          //
            SpellsInfo[0, 3, 20] = "";          //
            SpellsInfo[0, 4, 20] = "";          //
            SpellsInfo[0, 5, 20] = "";          //
            
            SpellsInfo[0, 1, 21] = "Passive AP Scaling";          //
            SpellsInfo[0, 2, 21] = "";          //
            SpellsInfo[0, 3, 21] = "";          //
            SpellsInfo[0, 4, 21] = "";          //
            SpellsInfo[0, 5, 21] = "";          //


            /*
             * Aatrox
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */

            /*
             * 
             */


        }
    }
}
