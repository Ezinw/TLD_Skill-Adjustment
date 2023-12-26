using HarmonyLib;
using Il2Cpp;

namespace SkillAdjustment
{
    [HarmonyPatch(typeof(SkillsManager), nameof(SkillsManager.Awake))]
    internal class HarvestAdjustment
    {

        public static void Postfix(SkillsManager __instance)
        {

            __instance.m_Skill_CarcassHarvesting.m_NumHoursHarvestPerSkillPoint = Settings.settings.harvestHoursForSkillPoint;
            //__instance.m_Skill_CarcassHarvesting.m_NumHoursToConvertToSkillPoints = Settings.settings.convertHours;

            __instance.m_Skill_CarcassHarvesting.m_FrozenThresholdPercent[0] = Settings.settings.harvestFrozen1;
            __instance.m_Skill_CarcassHarvesting.m_HideGutTimePercentDecrease[0] = Settings.settings.hideGutHarvestTime1;
            __instance.m_Skill_CarcassHarvesting.m_MeatTimePercentDecrease[0] = Settings.settings.meatHarvestTime1;

            __instance.m_Skill_CarcassHarvesting.m_FrozenThresholdPercent[1] = Settings.settings.harvestFrozen2;
            __instance.m_Skill_CarcassHarvesting.m_HideGutTimePercentDecrease[1] = Settings.settings.hideGutHarvestTime2;
            __instance.m_Skill_CarcassHarvesting.m_MeatTimePercentDecrease[1] = Settings.settings.meatHarvestTime2;

            __instance.m_Skill_CarcassHarvesting.m_FrozenThresholdPercent[2] = Settings.settings.harvestFrozen3;
            __instance.m_Skill_CarcassHarvesting.m_HideGutTimePercentDecrease[2] = Settings.settings.hideGutHarvestTime3;
            __instance.m_Skill_CarcassHarvesting.m_MeatTimePercentDecrease[2] = Settings.settings.meatHarvestTime3;

            __instance.m_Skill_CarcassHarvesting.m_FrozenThresholdPercent[3] = Settings.settings.harvestFrozen4;
            __instance.m_Skill_CarcassHarvesting.m_HideGutTimePercentDecrease[3] = Settings.settings.hideGutHarvestTime4;
            __instance.m_Skill_CarcassHarvesting.m_MeatTimePercentDecrease[3] = Settings.settings.meatHarvestTime4;

            __instance.m_Skill_CarcassHarvesting.m_FrozenThresholdPercent[4] = Settings.settings.harvestFrozen5;
            __instance.m_Skill_CarcassHarvesting.m_HideGutTimePercentDecrease[4] = Settings.settings.hideGutHarvestTime5;
            __instance.m_Skill_CarcassHarvesting.m_MeatTimePercentDecrease[4] = Settings.settings.meatHarvestTime5;






            Skill carcassharvesting = __instance.GetSkill(SkillType.CarcassHarvesting);

            if (carcassharvesting != null)
            {
                carcassharvesting.m_TierPoints[1] = Settings.settings.harvestTier2;
                carcassharvesting.m_TierPoints[2] = Settings.settings.harvestTier3;
                carcassharvesting.m_TierPoints[3] = Settings.settings.harvestTier4;
                carcassharvesting.m_TierPoints[4] = Settings.settings.harvestTier5;
            }

        }

    }



    [HarmonyPatch(typeof(Skill_CarcassHarvesting), nameof(Skill_CarcassHarvesting.GetTierBenefits))]
    public class HarvestingBenefits
    {

        static void Postfix(ref string __result, Skill_CarcassHarvesting __instance)
        {
            SkillTiers currentTier = (SkillTiers)__instance.GetCurrentTierNumber();

            //lvl 1
            if (currentTier == SkillTiers.Beginner && Settings.settings.harvestFrozen1 >= 1) { __result += $"\nCan Harvest {Settings.settings.harvestFrozen1}% frozen carcasses by hand"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.hideGutHarvestTime1 >= 1) { __result += $"\n{Settings.settings.hideGutHarvestTime1}% reduction in hide or gut harvesting times"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.meatHarvestTime1 >= 1) { __result += $"\n{Settings.settings.meatHarvestTime1}% reduction in meat harvesting times"; }

            //lvl 2
            if (currentTier == SkillTiers.Novice && Settings.settings.harvestFrozen1 >= 2) { __result += $"\nCan Harvest {Settings.settings.harvestFrozen2}% frozen carcasses by hand"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.hideGutHarvestTime2 >= 1) { __result += $"\n{Settings.settings.hideGutHarvestTime2}% reduction in hide or gut harvesting times"; }

            if (currentTier == SkillTiers.Novice && Settings.settings.meatHarvestTime2 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Meat: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"\n{Settings.settings.meatHarvestTime2}% reduction in meat harvesting times";
                }

            }
            else if (currentTier == SkillTiers.Beginner && Settings.settings.meatHarvestTime2 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Meat")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }


            //lvl 3
            if (currentTier == SkillTiers.Skilled && Settings.settings.meatHarvestTime3 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Meat: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"\n{Settings.settings.meatHarvestTime3}% reduction in meat harvesting times";
                }

            }
            else if (currentTier == SkillTiers.Beginner && Settings.settings.meatHarvestTime3 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Meat")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Skilled && Settings.settings.hideGutHarvestTime3 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("hide: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"\n{Settings.settings.hideGutHarvestTime3}% reduction in hide or gut harvesting times";
                }

            }
            else if (currentTier == SkillTiers.Beginner && Settings.settings.hideGutHarvestTime3 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Hide")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Skilled && Settings.settings.harvestFrozen3 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Frozen: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"\nCan Harvest {Settings.settings.harvestFrozen3}% frozen carcasses by hand";
                }

            }
            else if (currentTier == SkillTiers.Beginner && Settings.settings.harvestFrozen3 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Frozen")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }


            //lvl 4
            if (currentTier == SkillTiers.Expert && Settings.settings.meatHarvestTime4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Meat: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"\n{Settings.settings.meatHarvestTime4}% reduction in meat harvesting times";
                }

            }
            else if (currentTier == SkillTiers.Beginner && Settings.settings.meatHarvestTime4 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Meat")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Expert && Settings.settings.hideGutHarvestTime4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("hide: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"\n{Settings.settings.hideGutHarvestTime4}% reduction in hide or gut harvesting times";
                }

            }
            else if (currentTier == SkillTiers.Beginner && Settings.settings.hideGutHarvestTime4 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Hide")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Expert && Settings.settings.harvestFrozen4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Frozen: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"\nCan Harvest {Settings.settings.harvestFrozen4}% frozen carcasses by hand";
                }

            }
            else if (currentTier == SkillTiers.Beginner && Settings.settings.harvestFrozen4 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Frozen")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }


            //lvl 5
            if (currentTier == SkillTiers.Master && Settings.settings.meatHarvestTime5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Meat: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"\n{Settings.settings.meatHarvestTime5}% reduction in meat harvesting times";
                }

            }
            else if (currentTier == SkillTiers.Beginner && Settings.settings.meatHarvestTime5 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Meat")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Master && Settings.settings.hideGutHarvestTime5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Hide: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"\n{Settings.settings.hideGutHarvestTime5}% reduction in hide or gut harvesting times";
                }

            }
            else if (currentTier == SkillTiers.Beginner && Settings.settings.hideGutHarvestTime5 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Hide")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Master && Settings.settings.harvestFrozen5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Frozen: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"\nCan Harvest {Settings.settings.harvestFrozen5}% frozen carcasses by hand";
                }

            }
            else if (currentTier == SkillTiers.Beginner && Settings.settings.harvestFrozen5 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Frozen")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }



        }

    }

}
