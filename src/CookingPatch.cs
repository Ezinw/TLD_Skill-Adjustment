using Il2Cpp;
using HarmonyLib;
using System.Text;

namespace SkillAdjustment
{
    [HarmonyPatch(typeof(SkillsManager), nameof(SkillsManager.Awake))]
    internal class CookingAdjustment
    {
        public static void Postfix(SkillsManager __instance)
        {
            var settings = Settings.settings;
            var cooking = __instance.m_Skill_Cooking;

            cooking.m_LevelWhereNoCalorieLossFromSmashing = settings.noCalorieLossLevel;
            cooking.m_LevelWhereNoParasitesOrFoodPoisoning = settings.noPoisonLevel;

            cooking.m_CaloriePercentBonus[0] = settings.calorieBonus1;
            cooking.m_CookingTimeReducePercent[0] = settings.reduceCookingTime1;
            cooking.m_ReadyTimeIncreasePercent[0] = settings.readyTimeIncrease1;

            cooking.m_CaloriePercentBonus[1] = settings.calorieBonus2;
            cooking.m_CookingTimeReducePercent[1] = settings.reduceCookingTime2;
            cooking.m_ReadyTimeIncreasePercent[1] = settings.readyTimeIncrease2;

            cooking.m_CaloriePercentBonus[2] = settings.calorieBonus3;
            cooking.m_CookingTimeReducePercent[2] = settings.reduceCookingTime3;
            cooking.m_ReadyTimeIncreasePercent[2] = settings.readyTimeIncrease3;

            cooking.m_CaloriePercentBonus[3] = settings.calorieBonus4;
            cooking.m_CookingTimeReducePercent[3] = settings.reduceCookingTime4;
            cooking.m_ReadyTimeIncreasePercent[3] = settings.readyTimeIncrease4;

            cooking.m_CaloriePercentBonus[4] = settings.calorieBonus5;
            cooking.m_CookingTimeReducePercent[4] = settings.reduceCookingTime5;
            cooking.m_ReadyTimeIncreasePercent[4] = settings.readyTimeIncrease5;


            Skill Cooking = __instance.GetSkill(SkillType.Cooking);

            if (Cooking != null)
            {
                Cooking.m_TierPoints[1] = settings.cookingTier2;
                Cooking.m_TierPoints[2] = settings.cookingTier3;
                Cooking.m_TierPoints[3] = settings.cookingTier4;
                Cooking.m_TierPoints[4] = settings.cookingTier5;
            }
        }
    }


    [HarmonyPatch(typeof(Skill_Cooking), nameof(Skill_Cooking.GetTierBenefits))]
    public static class CookingBenefits
    {
        static void Postfix(int index, ref string __result, Skill_Cooking __instance)
        {
            if (index < 0 || index > 4)
                return;

            var s = Settings.settings;
            var sb = new StringBuilder();

            if (index == 0 && !string.IsNullOrEmpty(__result))
                sb.Append(__result.TrimEnd());

            int[] bonus = { 
                s.calorieBonus1, s.calorieBonus2, s.calorieBonus3, s.calorieBonus4, s.calorieBonus5 
            };

            int[] reduce = { 
                s.reduceCookingTime1, s.reduceCookingTime2, s.reduceCookingTime3, s.reduceCookingTime4, s.reduceCookingTime5 
            };

            int[] ready = { 
                s.readyTimeIncrease1, s.readyTimeIncrease2, s.readyTimeIncrease3, s.readyTimeIncrease4, s.readyTimeIncrease5 
            };

            Append(sb, bonus[index], "+{0}% calories from cooked food");
            Append(sb, reduce[index], "Cooking times reduced by {0}%");
            Append(sb, ready[index], "Ready times increased by {0}%");

            if (UnlocksCalorieLoss(index, s.noCalorieLossLevel))
                AppendRaw(sb, "No calorie loss when smashing open cans");

            if (UnlocksPoison(index, s.noPoisonLevel))
                AppendRaw(sb, "Never get parasites or food poisoning");

            __result = sb.ToString();
        }

        private static void Append(StringBuilder sb, int value, string fmt)
        {
            if (value <= 0) return;
            if (sb.Length > 0) sb.Append('\n');
            sb.AppendFormat(fmt, value);
        }

        private static void AppendRaw(StringBuilder sb, string text)
        {
            if (sb.Length > 0) sb.Append('\n');
            sb.Append(text);
        }

        private static bool UnlocksCalorieLoss(int tier, int setting)
        {
            return tier + 1 >= setting && setting > 0;
        }

        private static bool UnlocksPoison(int tier, int setting)
        {
            return tier + 1 >= setting && setting > 0;
        }
    }
}