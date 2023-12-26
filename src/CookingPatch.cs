using HarmonyLib;
using Il2Cpp;

namespace SkillAdjustment
{
    [HarmonyPatch(typeof(SkillsManager), nameof(SkillsManager.Awake))]
    internal class CookingAdjustment
    {

        public static void Postfix(SkillsManager __instance)
        {
            __instance.m_Skill_Cooking.m_LevelWhereNoCalorieLossFromSmashing = Settings.settings.noCalorieLossLevel;
            __instance.m_Skill_Cooking.m_LevelWhereNoParasitesOrFoodPoisoning = Settings.settings.noPoisonLevel;

            __instance.m_Skill_Cooking.m_CaloriePercentBonus[0] = Settings.settings.calorieBonus1;
            __instance.m_Skill_Cooking.m_CookingTimeReducePercent[0] = Settings.settings.reduceCookingTime1;
            __instance.m_Skill_Cooking.m_ReadyTimeIncreasePercent[0] = Settings.settings.readyTimeIncrease1;

            __instance.m_Skill_Cooking.m_CaloriePercentBonus[1] = Settings.settings.calorieBonus2;
            __instance.m_Skill_Cooking.m_CookingTimeReducePercent[1] = Settings.settings.reduceCookingTime2;
            __instance.m_Skill_Cooking.m_ReadyTimeIncreasePercent[1] = Settings.settings.readyTimeIncrease2;

            __instance.m_Skill_Cooking.m_CaloriePercentBonus[2] = Settings.settings.calorieBonus3;
            __instance.m_Skill_Cooking.m_CookingTimeReducePercent[2] = Settings.settings.reduceCookingTime3;
            __instance.m_Skill_Cooking.m_ReadyTimeIncreasePercent[2] = Settings.settings.readyTimeIncrease3;

            __instance.m_Skill_Cooking.m_CaloriePercentBonus[3] = Settings.settings.calorieBonus4;
            __instance.m_Skill_Cooking.m_CookingTimeReducePercent[3] = Settings.settings.reduceCookingTime4;
            __instance.m_Skill_Cooking.m_ReadyTimeIncreasePercent[3] = Settings.settings.readyTimeIncrease4;

            __instance.m_Skill_Cooking.m_CaloriePercentBonus[4] = Settings.settings.calorieBonus5;
            __instance.m_Skill_Cooking.m_CookingTimeReducePercent[4] = Settings.settings.reduceCookingTime5;
            __instance.m_Skill_Cooking.m_ReadyTimeIncreasePercent[4] = Settings.settings.readyTimeIncrease5;


            Skill Cooking = __instance.GetSkill(SkillType.Cooking);

            if (Cooking != null)
            {
                Cooking.m_TierPoints[1] = Settings.settings.cookingTier2;
                Cooking.m_TierPoints[2] = Settings.settings.cookingTier3;
                Cooking.m_TierPoints[3] = Settings.settings.cookingTier4;
                Cooking.m_TierPoints[4] = Settings.settings.cookingTier5;
            }

        }

    }



    [HarmonyPatch(typeof(Skill_Cooking), nameof(Skill_Cooking.GetTierBenefits))]
    public class CookingBenefits
    {

        static void Postfix(ref string __result, Skill_Cooking __instance)
        {
            SkillTiers currentTier = (SkillTiers)__instance.GetCurrentTierNumber();

            // Can smashing
            if (currentTier == SkillTiers.Beginner && Settings.settings.noCalorieLossLevel == 1 ||
                currentTier == SkillTiers.Novice && Settings.settings.noCalorieLossLevel <= 2)
            {
                __result += "\nNo calorie loss when smashing open cans";
            }

            if ((currentTier == SkillTiers.Skilled && Settings.settings.noCalorieLossLevel >= 4) ||
                (currentTier == SkillTiers.Expert && Settings.settings.noCalorieLossLevel >= 5) ||
                (currentTier == SkillTiers.Master && Settings.settings.noCalorieLossLevel == 6))
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("No")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            // Parasites&Poison
            if (currentTier == SkillTiers.Beginner && Settings.settings.noPoisonLevel == 1 ||
                currentTier == SkillTiers.Novice && Settings.settings.noPoisonLevel <= 2 ||
                currentTier == SkillTiers.Skilled && Settings.settings.noPoisonLevel <= 3 ||
                currentTier == SkillTiers.Expert && Settings.settings.noPoisonLevel <= 4)

            {
                __result += "\nNever get parasites or food poisoning";
            }

            if ((currentTier == SkillTiers.Master && Settings.settings.noPoisonLevel == 6))
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Parasites")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }



            //lvl 1
            if (currentTier == SkillTiers.Beginner && Settings.settings.calorieBonus1 >= 1) { __result += $"\n+{Settings.settings.calorieBonus1}% calories from any cooked food item"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.reduceCookingTime1 >= 1) { __result += $"\nCooking times reduced by {Settings.settings.reduceCookingTime1}%"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.readyTimeIncrease1 >= 1) { __result += $"\nReady times increased by {Settings.settings.readyTimeIncrease1}%"; }



            //lvl 2
            if (currentTier == SkillTiers.Novice && Settings.settings.reduceCookingTime2 >= 1) { __result += $"\nCooking times reduced by {Settings.settings.reduceCookingTime2}%"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.readyTimeIncrease2 >= 1) { __result += $"\nReady times increased by {Settings.settings.readyTimeIncrease2}%"; }

            if (currentTier == SkillTiers.Novice && Settings.settings.calorieBonus2 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("+: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"+{Settings.settings.calorieBonus2}% calories from any cooked food item";
                }

            }
            else if (currentTier == SkillTiers.Novice && Settings.settings.calorieBonus2 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("+")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }



            //lvl 3
            if (currentTier == SkillTiers.Skilled && Settings.settings.readyTimeIncrease3 >= 1) { __result += $"\nReady times increased by {Settings.settings.readyTimeIncrease3}%"; }

            if (currentTier == SkillTiers.Skilled && Settings.settings.calorieBonus3 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("+: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"+{Settings.settings.calorieBonus3}% calories from any cooked food item";
                }

            }
            else if (currentTier == SkillTiers.Skilled && Settings.settings.calorieBonus3 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("+")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Skilled && Settings.settings.reduceCookingTime3 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Reduced: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Cooking times reduced by {Settings.settings.reduceCookingTime3}%";
                }

            }
            else if (currentTier == SkillTiers.Skilled && Settings.settings.reduceCookingTime3 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Reduced")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }



            //lvl 4
            if (currentTier == SkillTiers.Expert && Settings.settings.calorieBonus4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("+: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"+{Settings.settings.calorieBonus4}% calories from any cooked food item";
                }

            }
            else if (currentTier == SkillTiers.Expert && Settings.settings.calorieBonus4 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("+")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Expert && Settings.settings.readyTimeIncrease4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Ready: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Ready times increased by {Settings.settings.readyTimeIncrease4}%";
                }

            }
            else if (currentTier == SkillTiers.Expert && Settings.settings.readyTimeIncrease4 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Ready")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Expert && Settings.settings.reduceCookingTime4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Reduced: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Cooking times reduced by {Settings.settings.reduceCookingTime4}%";
                }

            }
            else if (currentTier == SkillTiers.Expert && Settings.settings.reduceCookingTime4 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Ready")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }



            //lvl 5
            if (currentTier == SkillTiers.Master && Settings.settings.calorieBonus5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("+: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"+{Settings.settings.calorieBonus5}% calories from any cooked food item";
                }

            }
            else if (currentTier == SkillTiers.Master && Settings.settings.calorieBonus5 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("+")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Master && Settings.settings.readyTimeIncrease5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Ready: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Ready times increased by {Settings.settings.readyTimeIncrease5}%";
                }

            }
            else if (currentTier == SkillTiers.Master && Settings.settings.readyTimeIncrease5 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Ready")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Master && Settings.settings.reduceCookingTime4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Reduced: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Cooking times reduced by {Settings.settings.reduceCookingTime4}%";
                }

            }
            else if (currentTier == SkillTiers.Master && Settings.settings.reduceCookingTime4 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Reduced")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }


        }

    }


}