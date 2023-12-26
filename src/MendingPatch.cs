using HarmonyLib;
using Il2Cpp;

namespace SkillAdjustment
{
    [HarmonyPatch(typeof(SkillsManager), nameof(SkillsManager.Awake))]
    internal class MendingAdjustment
    {

        public static void Postfix(SkillsManager __instance)
        {
            __instance.m_Skill_ClothingRepair.m_BaseSuccessChance[0] = Settings.settings.mendingSuccessChance1;
            __instance.m_Skill_ClothingRepair.m_ItemConditionPercentIncrease[0] = Settings.settings.mendingConditionBonus1;
            __instance.m_Skill_ClothingRepair.m_RepairTimePercentDecrease[0] = Settings.settings.mendingRepairTimeReduced1;
            __instance.m_Skill_ClothingRepair.m_SewingToolDegradeDecrease[0] = Settings.settings.SewingKitDegradeDecrease1;

            __instance.m_Skill_ClothingRepair.m_BaseSuccessChance[1] = Settings.settings.mendingSuccessChance2;
            __instance.m_Skill_ClothingRepair.m_ItemConditionPercentIncrease[1] = Settings.settings.mendingConditionBonus2;
            __instance.m_Skill_ClothingRepair.m_RepairTimePercentDecrease[1] = Settings.settings.mendingRepairTimeReduced2;
            __instance.m_Skill_ClothingRepair.m_SewingToolDegradeDecrease[1] = Settings.settings.SewingKitDegradeDecrease2;

            __instance.m_Skill_ClothingRepair.m_BaseSuccessChance[2] = Settings.settings.mendingSuccessChance3;
            __instance.m_Skill_ClothingRepair.m_ItemConditionPercentIncrease[2] = Settings.settings.mendingConditionBonus3;
            __instance.m_Skill_ClothingRepair.m_RepairTimePercentDecrease[2] = Settings.settings.mendingRepairTimeReduced3;
            __instance.m_Skill_ClothingRepair.m_SewingToolDegradeDecrease[2] = Settings.settings.SewingKitDegradeDecrease3;

            __instance.m_Skill_ClothingRepair.m_BaseSuccessChance[3] = Settings.settings.mendingSuccessChance4;
            __instance.m_Skill_ClothingRepair.m_ItemConditionPercentIncrease[3] = Settings.settings.mendingConditionBonus4;
            __instance.m_Skill_ClothingRepair.m_RepairTimePercentDecrease[3] = Settings.settings.mendingRepairTimeReduced4;
            __instance.m_Skill_ClothingRepair.m_SewingToolDegradeDecrease[3] = Settings.settings.SewingKitDegradeDecrease4;

            __instance.m_Skill_ClothingRepair.m_BaseSuccessChance[4] = Settings.settings.mendingSuccessChance5;
            __instance.m_Skill_ClothingRepair.m_ItemConditionPercentIncrease[4] = Settings.settings.mendingConditionBonus5;
            __instance.m_Skill_ClothingRepair.m_RepairTimePercentDecrease[4] = Settings.settings.mendingRepairTimeReduced5;
            __instance.m_Skill_ClothingRepair.m_SewingToolDegradeDecrease[4] = Settings.settings.SewingKitDegradeDecrease5;


            Skill ClothingRepair = __instance.GetSkill(SkillType.ClothingRepair);

            if (ClothingRepair != null)
            {
                ClothingRepair.m_TierPoints[1] = Settings.settings.mendTier2;
                ClothingRepair.m_TierPoints[2] = Settings.settings.mendTier3;
                ClothingRepair.m_TierPoints[3] = Settings.settings.mendTier4;
                ClothingRepair.m_TierPoints[4] = Settings.settings.mendTier5;
            }

        }

    }

    

    [HarmonyPatch(typeof(Skill_ClothingRepair), nameof(Skill_ClothingRepair.GetTierBenefits))]
    public class ClothingRepairBenefits
    {

        static void Postfix(ref string __result, Skill_ClothingRepair __instance)
        {
            SkillTiers currentTier = (SkillTiers)__instance.GetCurrentTierNumber();

            //lvl 1
            if (currentTier == SkillTiers.Beginner && Settings.settings.mendingConditionBonus1 >= 1) { __result += $"\n{Settings.settings.mendingConditionBonus1}% greater item condition increase"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.mendingRepairTimeReduced1 >= 1) { __result += $"\nRepair time decreased by {Settings.settings.mendingRepairTimeReduced1}%"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.SewingKitDegradeDecrease1 >= 1) { __result += $"\n{Settings.settings.SewingKitDegradeDecrease1}% reduction of sewing kit wear"; }


            if (currentTier == SkillTiers.Beginner && Settings.settings.mendingSuccessChance1 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Successful: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.mendingSuccessChance1}% of successful repair";
                }
            
            }
            else if (currentTier == SkillTiers.Beginner && Settings.settings.mendingSuccessChance1 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Successful")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }


            //lvl 2
            if (currentTier == SkillTiers.Novice && Settings.settings.mendingConditionBonus2 >= 1) { __result += $"\n{Settings.settings.mendingConditionBonus2}% greater item condition increase"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.SewingKitDegradeDecrease2 >= 1) { __result += $"\n{Settings.settings.SewingKitDegradeDecrease2}% reduction of sewing kit wear"; }

            if (currentTier == SkillTiers.Novice && Settings.settings.mendingSuccessChance2 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Successful: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.mendingSuccessChance2}% of successful repair";
                }

            }
            else if (currentTier == SkillTiers.Novice && Settings.settings.mendingSuccessChance2 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Successful")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Novice && Settings.settings.mendingRepairTimeReduced2 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Time: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Repair time decreased by {Settings.settings.mendingRepairTimeReduced2}%";
                }

            }
            else if (currentTier == SkillTiers.Novice && Settings.settings.mendingRepairTimeReduced2 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Time")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }


            //lvl 3
            if (currentTier == SkillTiers.Skilled && Settings.settings.SewingKitDegradeDecrease3 >= 1) { __result += $"\n{Settings.settings.SewingKitDegradeDecrease3}% reduction of sewing kit wear"; }

            if (currentTier == SkillTiers.Skilled && Settings.settings.mendingSuccessChance3 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Successful: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.mendingSuccessChance3}% of successful repair";
                }

            }
            else if (currentTier == SkillTiers.Skilled && Settings.settings.mendingSuccessChance3 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Successful")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Skilled && Settings.settings.mendingRepairTimeReduced3 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Time: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Repair time decreased by {Settings.settings.mendingRepairTimeReduced3}%";
                }

            }
            else if (currentTier == SkillTiers.Skilled && Settings.settings.mendingRepairTimeReduced3 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Time")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Skilled && Settings.settings.mendingConditionBonus3 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Condition: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.mendingConditionBonus3}% greater item condition increase";
                }

            }
            else if (currentTier == SkillTiers.Skilled && Settings.settings.mendingConditionBonus3 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Condition")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }


            //lvl 4
            if (currentTier == SkillTiers.Expert && Settings.settings.mendingSuccessChance4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Successful: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.mendingSuccessChance4}% of successful repair";
                }

            }
            else if (currentTier == SkillTiers.Expert && Settings.settings.mendingSuccessChance4 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Successful")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Expert && Settings.settings.mendingRepairTimeReduced4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Time: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Repair time decreased by {Settings.settings.mendingRepairTimeReduced4}%";
                }

            }
            else if (currentTier == SkillTiers.Expert && Settings.settings.mendingRepairTimeReduced4 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Time")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Expert && Settings.settings.mendingConditionBonus4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Condition: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.mendingConditionBonus4}% greater item condition increase";
                }

            }
            else if (currentTier == SkillTiers.Expert && Settings.settings.mendingConditionBonus4 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Condition")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Expert && Settings.settings.SewingKitDegradeDecrease4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Sewing: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.SewingKitDegradeDecrease4}% reduction of sewing kit wear";
                }

            }
            else if (currentTier == SkillTiers.Expert && Settings.settings.SewingKitDegradeDecrease4 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Sewing")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }


            //lvl 5
            if (currentTier == SkillTiers.Master && Settings.settings.mendingSuccessChance5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Successful: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.mendingSuccessChance5}% of successful repair";
                }

            }
            else if (currentTier == SkillTiers.Master && Settings.settings.mendingSuccessChance5 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Successful")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Master && Settings.settings.mendingRepairTimeReduced5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Time: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Repair time decreased by {Settings.settings.mendingRepairTimeReduced5}%";
                }

            }
            else if (currentTier == SkillTiers.Master && Settings.settings.mendingRepairTimeReduced5 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Time")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Master && Settings.settings.mendingConditionBonus5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Condition: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.mendingConditionBonus5}% greater item condition increase";
                }

            }
            else if (currentTier == SkillTiers.Master && Settings.settings.mendingConditionBonus5 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Condition")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Master && Settings.settings.SewingKitDegradeDecrease5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Sewing: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.SewingKitDegradeDecrease5}% reduction of sewing kit wear";
                }

            }
            else if (currentTier == SkillTiers.Master && Settings.settings.SewingKitDegradeDecrease5 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Sewing")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }



        }

    }

}
