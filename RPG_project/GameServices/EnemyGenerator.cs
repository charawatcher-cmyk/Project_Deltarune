using RPG_project.Entities;
using RPG_project.Utils;
using System;
using System.Drawing;

namespace RPG_project.GameServices
{
    public enum SpecialAbilities {
        None,
        StrongPunch,
        Healing
    }

    public class EnemyGenerator
    {
        static string[] specialAbilitiesNames = { "None", "Сильний удар", "Лікування" };
        string[] enemyNames = { "Lancer", "Tenna", "Roaring Knight", "K_K", "Gerson Boom", "Flowery", "Aqua", "Shadow Guy", "Miss Mizle", "Seth", "Leafling", "Jevil", "Yellow", "Cat Mike", "Berdly", "Queen" };
        Image[] enemyImages =
        {
              Properties.Resources.Lancer,Properties.Resources.Tenna,Properties.Resources.Knight_battle_afterimage,Properties.Resources.K_K,
              Properties.Resources.Gerson_Boom,Properties.Resources.Flowery,Properties.Resources.Aqua,Properties.Resources.Shadowguy,
              Properties.Resources.Miss_Mizzle,Properties.Resources.Seth,Properties.Resources.Leafling,
              Properties.Resources.Jevil,Properties.Resources.Yellow,Properties.Resources.Cat_Mike,Properties.Resources.Berdly,
              Properties.Resources.Queen
            };

        public static string GetNameSpecialAbilities(SpecialAbilities specialAbilities)
        {
            return specialAbilitiesNames[(int)specialAbilities];
        }

        public Enemy Create(int playerLevel)
        {
            int randomIndex = CustomRandom.GetRandomNumber(0, enemyNames.Length - 1);

            return new Enemy(
                enemyNames[randomIndex], 
                CustomRandom.GetRandomNumber(playerLevel, playerLevel + 1), 
                enemyImages[randomIndex], 
                (SpecialAbilities)CustomRandom.GetRandomNumber(0, Convert.ToInt32(SpecialAbilities.Healing))
            );
        }
    }
}
