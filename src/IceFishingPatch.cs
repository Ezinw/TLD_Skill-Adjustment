using HarmonyLib;
using Il2Cpp;

namespace SkillAdjustment
{
    [HarmonyPatch(typeof(SkillsManager), nameof(SkillsManager.Awake))]
    internal class IceFishingAdjustment
    {

        public static void Postfix(SkillsManager __instance)
        {
            __instance.m_Skill_IceFishing.m_IncreaseFishWeightPercent[0] = Settings.settings.fishWeight1;
            __instance.m_Skill_IceFishing.m_LineBreakOnCatchChance[0] = Settings.settings.lineBreak1;
            __instance.m_Skill_IceFishing.m_ReduceFishingTimePercent[0] = Settings.settings.fishingTime1;

            __instance.m_Skill_IceFishing.m_IncreaseFishWeightPercent[1] = Settings.settings.fishWeight2;
            __instance.m_Skill_IceFishing.m_LineBreakOnCatchChance[1] = Settings.settings.lineBreak2;
            __instance.m_Skill_IceFishing.m_ReduceFishingTimePercent[1] = Settings.settings.fishingTime2;

            __instance.m_Skill_IceFishing.m_IncreaseFishWeightPercent[2] = Settings.settings.fishWeight3;
            __instance.m_Skill_IceFishing.m_LineBreakOnCatchChance[2] = Settings.settings.lineBreak3;
            __instance.m_Skill_IceFishing.m_ReduceFishingTimePercent[2] = Settings.settings.fishingTime3;

            __instance.m_Skill_IceFishing.m_IncreaseFishWeightPercent[3] = Settings.settings.fishWeight4;
            __instance.m_Skill_IceFishing.m_LineBreakOnCatchChance[3] = Settings.settings.lineBreak4;
            __instance.m_Skill_IceFishing.m_ReduceFishingTimePercent[3] = Settings.settings.fishingTime4;

            __instance.m_Skill_IceFishing.m_IncreaseFishWeightPercent[4] = Settings.settings.fishWeight5;
            __instance.m_Skill_IceFishing.m_LineBreakOnCatchChance[4] = Settings.settings.lineBreak5;
            __instance.m_Skill_IceFishing.m_ReduceFishingTimePercent[4] = Settings.settings.fishingTime5;


            Skill IceFishing = __instance.GetSkill(SkillType.IceFishing);

            if (IceFishing != null)
            {
                IceFishing.m_TierPoints[1] = Settings.settings.fishTier2;
                IceFishing.m_TierPoints[2] = Settings.settings.fishTier3;
                IceFishing.m_TierPoints[3] = Settings.settings.fishTier4;
                IceFishing.m_TierPoints[4] = Settings.settings.fishTier5;
            }

        }

        [HarmonyPatch(typeof(Skill_IceFishing), nameof(Skill_IceFishing.GetTierBenefits))]
        public class IceFishingBenefits
        {

            static void Postfix(ref string __result, Skill_IceFishing __instance)
            {
                SkillTiers currentTier = (SkillTiers)__instance.GetCurrentTierNumber();

                //lvl 1
                if (currentTier == SkillTiers.Beginner && Settings.settings.fishWeight1 >= 1) { __result += $"\n{Settings.settings.fishWeight1}% to average fish weight"; }
                if (currentTier == SkillTiers.Beginner && Settings.settings.lineBreak1 >= 1) { __result += $"\n{Settings.settings.lineBreak1}% chance of line break on catch"; }
                if (currentTier == SkillTiers.Beginner && Settings.settings.fishingTime1 >= 1) { __result += $"\nFishing time reduced by {Settings.settings.fishingTime1}%"; }


                //lvl 2
                if (currentTier == SkillTiers.Novice && Settings.settings.fishWeight2 >= 1) { __result += $"\n{Settings.settings.fishWeight2}% to average fish weight"; }

                if (currentTier == SkillTiers.Novice && Settings.settings.fishingTime2 >= 1)
                {
                    int existingBenefitIndex = __result.IndexOf("Time: ");
                    if (existingBenefitIndex != -1)
                    {
                        int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                        if (endOfLineIndex != -1)
                        { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                        __result += $"Fishing time reduced by {Settings.settings.fishingTime2}%";
                    }

                }
                else if (currentTier == SkillTiers.Beginner && Settings.settings.fishingTime2 == 0)
                {
                    List<string> resultList = __result.Split('\n').ToList();
                    List<string> newResult = resultList.Where(benefit => !benefit.Contains("Time")).ToList();
                    string newResultString = string.Join("\n", newResult);
                    __result = newResultString;
                }

                if (currentTier == SkillTiers.Novice && Settings.settings.lineBreak2 >= 1)
                {
                    int existingBenefitIndex = __result.IndexOf("Break: ");
                    if (existingBenefitIndex != -1)
                    {
                        int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                        if (endOfLineIndex != -1)
                        { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                        __result += $"{Settings.settings.lineBreak1}% chance of line break on catch";
                    }

                }
                else if (currentTier == SkillTiers.Beginner && Settings.settings.lineBreak2 == 0)
                {
                    List<string> resultList = __result.Split('\n').ToList();
                    List<string> newResult = resultList.Where(benefit => !benefit.Contains("Break")).ToList();
                    string newResultString = string.Join("\n", newResult);
                    __result = newResultString;
                }


                //lvl3
                if (currentTier == SkillTiers.Skilled && Settings.settings.fishWeight3 >= 1) { __result += $"\n{Settings.settings.fishWeight3}% to average fish weight"; }

                if (currentTier == SkillTiers.Skilled && Settings.settings.fishingTime3 >= 1)
                {
                    int existingBenefitIndex = __result.IndexOf("Time: ");
                    if (existingBenefitIndex != -1)
                    {
                        int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                        if (endOfLineIndex != -1)
                        { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                        __result += $"Fishing time reduced by {Settings.settings.fishingTime3}%";
                    }

                }
                else if (currentTier == SkillTiers.Beginner && Settings.settings.fishingTime3 == 0)
                {
                    List<string> resultList = __result.Split('\n').ToList();
                    List<string> newResult = resultList.Where(benefit => !benefit.Contains("Time")).ToList();
                    string newResultString = string.Join("\n", newResult);
                    __result = newResultString;
                }

                if (currentTier == SkillTiers.Skilled && Settings.settings.lineBreak3 >= 1)
                {
                    int existingBenefitIndex = __result.IndexOf("Break: ");
                    if (existingBenefitIndex != -1)
                    {
                        int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                        if (endOfLineIndex != -1)
                        { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                        __result += $"{Settings.settings.lineBreak1}% chance of line break on catch";
                    }

                }
                else if (currentTier == SkillTiers.Beginner && Settings.settings.lineBreak3 == 0)
                {
                    List<string> resultList = __result.Split('\n').ToList();
                    List<string> newResult = resultList.Where(benefit => !benefit.Contains("Break")).ToList();
                    string newResultString = string.Join("\n", newResult);
                    __result = newResultString;
                }


                //lvl 4
                if (currentTier == SkillTiers.Expert && Settings.settings.fishingTime4 >= 1)
                {
                    int existingBenefitIndex = __result.IndexOf("Time: ");
                    if (existingBenefitIndex != -1)
                    {
                        int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                        if (endOfLineIndex != -1)
                        { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                        __result += $"Fishing time reduced by {Settings.settings.fishingTime4}%";
                    }

                }
                else if (currentTier == SkillTiers.Beginner && Settings.settings.fishingTime4 == 0)
                {
                    List<string> resultList = __result.Split('\n').ToList();
                    List<string> newResult = resultList.Where(benefit => !benefit.Contains("Time")).ToList();
                    string newResultString = string.Join("\n", newResult);
                    __result = newResultString;
                }

                if (currentTier == SkillTiers.Expert && Settings.settings.lineBreak4 >= 1)
                {
                    int existingBenefitIndex = __result.IndexOf("Break: ");
                    if (existingBenefitIndex != -1)
                    {
                        int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                        if (endOfLineIndex != -1)
                        { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                        __result += $"{Settings.settings.lineBreak4}% chance of line break on catch";
                    }

                }
                else if (currentTier == SkillTiers.Beginner && Settings.settings.lineBreak4 == 0)
                {
                    List<string> resultList = __result.Split('\n').ToList();
                    List<string> newResult = resultList.Where(benefit => !benefit.Contains("Break")).ToList();
                    string newResultString = string.Join("\n", newResult);
                    __result = newResultString;
                }

                if (currentTier == SkillTiers.Expert && Settings.settings.fishWeight4 >= 1)
                {
                    int existingBenefitIndex = __result.IndexOf("Weight: ");
                    if (existingBenefitIndex != -1)
                    {
                        int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                        if (endOfLineIndex != -1)
                        { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                        __result += $"{Settings.settings.fishWeight4}% to average fish weight";
                    }

                }
                else if (currentTier == SkillTiers.Beginner && Settings.settings.fishWeight4 == 0)
                {
                    List<string> resultList = __result.Split('\n').ToList();
                    List<string> newResult = resultList.Where(benefit => !benefit.Contains("Weight")).ToList();
                    string newResultString = string.Join("\n", newResult);
                    __result = newResultString;
                }


                //lvl 5
                if (currentTier == SkillTiers.Expert && Settings.settings.fishingTime5 >= 1)
                {
                    int existingBenefitIndex = __result.IndexOf("Time: ");
                    if (existingBenefitIndex != -1)
                    {
                        int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                        if (endOfLineIndex != -1)
                        { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                        __result += $"Fishing time reduced by {Settings.settings.fishingTime5}%";
                    }

                }
                else if (currentTier == SkillTiers.Master && Settings.settings.fishingTime5 == 0)
                {
                    List<string> resultList = __result.Split('\n').ToList();
                    List<string> newResult = resultList.Where(benefit => !benefit.Contains("Time")).ToList();
                    string newResultString = string.Join("\n", newResult);
                    __result = newResultString;
                }

                if (currentTier == SkillTiers.Expert && Settings.settings.lineBreak5 >= 1)
                {
                    int existingBenefitIndex = __result.IndexOf("Break: ");
                    if (existingBenefitIndex != -1)
                    {
                        int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                        if (endOfLineIndex != -1)
                        { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                        __result += $"{Settings.settings.lineBreak5}% chance of line break on catch";
                    }

                }
                else if (currentTier == SkillTiers.Master && Settings.settings.lineBreak5 == 0)
                {
                    List<string> resultList = __result.Split('\n').ToList();
                    List<string> newResult = resultList.Where(benefit => !benefit.Contains("Break")).ToList();
                    string newResultString = string.Join("\n", newResult);
                    __result = newResultString;
                }

                if (currentTier == SkillTiers.Master && Settings.settings.fishWeight5 >= 1)
                {
                    int existingBenefitIndex = __result.IndexOf("Weight: ");
                    if (existingBenefitIndex != -1)
                    {
                        int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                        if (endOfLineIndex != -1)
                        { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                        __result += $"{Settings.settings.fishWeight5}% to average fish weight";
                    }

                }
                else if (currentTier == SkillTiers.Master && Settings.settings.fishWeight5 == 0)
                {
                    List<string> resultList = __result.Split('\n').ToList();
                    List<string> newResult = resultList.Where(benefit => !benefit.Contains("Weight")).ToList();
                    string newResultString = string.Join("\n", newResult);
                    __result = newResultString;
                }


            }

        }

    }

}

    


