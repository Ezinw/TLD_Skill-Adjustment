using HarmonyLib;
using Il2Cpp;

namespace SkillAdjustment
{
    [HarmonyPatch(typeof(SkillsManager), nameof(SkillsManager.Awake))]
    internal class FirestartingAdjustment
    {

        public static void Postfix(SkillsManager __instance)
        {
            __instance.m_Skill_Firestarting.m_LevelWhereTinderNotRequired = Settings.settings.tinderLevelRequirement;

            __instance.m_Skill_Firestarting.m_BaseSuccessChance[0] = Settings.settings.fireBaseChance1;
            __instance.m_Skill_Firestarting.m_DurationPercentIncrease[0] = Settings.settings.fireDurationBonus1;
            __instance.m_Skill_Firestarting.m_StartPercentIncrease[0] = Settings.settings.quickerFireStarting1;

            __instance.m_Skill_Firestarting.m_BaseSuccessChance[1] = Settings.settings.fireBaseChance2;
            __instance.m_Skill_Firestarting.m_DurationPercentIncrease[1] = Settings.settings.fireDurationBonus2;
            __instance.m_Skill_Firestarting.m_StartPercentIncrease[1] = Settings.settings.quickerFireStarting2;

            __instance.m_Skill_Firestarting.m_BaseSuccessChance[2] = Settings.settings.fireBaseChance3;
            __instance.m_Skill_Firestarting.m_DurationPercentIncrease[2] = Settings.settings.fireDurationBonus3;
            __instance.m_Skill_Firestarting.m_StartPercentIncrease[2] = Settings.settings.quickerFireStarting3;

            __instance.m_Skill_Firestarting.m_BaseSuccessChance[3] = Settings.settings.fireBaseChance4;
            __instance.m_Skill_Firestarting.m_DurationPercentIncrease[3] = Settings.settings.fireDurationBonus4;
            __instance.m_Skill_Firestarting.m_StartPercentIncrease[3] = Settings.settings.quickerFireStarting4;

            __instance.m_Skill_Firestarting.m_BaseSuccessChance[4] = Settings.settings.fireBaseChance5;
            __instance.m_Skill_Firestarting.m_DurationPercentIncrease[4] = Settings.settings.fireDurationBonus5;
            __instance.m_Skill_Firestarting.m_StartPercentIncrease[4] = Settings.settings.quickerFireStarting5;


            Skill firestarting = __instance.GetSkill(SkillType.Firestarting);

            if (firestarting != null)
            {
                firestarting.m_TierPoints[1] = Settings.settings.fireTier2;
                firestarting.m_TierPoints[2] = Settings.settings.fireTier3;
                firestarting.m_TierPoints[3] = Settings.settings.fireTier4;
                firestarting.m_TierPoints[4] = Settings.settings.fireTier5;
            }

        }

    }



    [HarmonyPatch(typeof(Skill_Firestarting), nameof(Skill_Firestarting.GetTierBenefits))]
    public class FirestartingBenefits
    {

        static void Postfix(ref string __result, Skill_Firestarting __instance)
        {
            SkillTiers currentTier = (SkillTiers)__instance.GetCurrentTierNumber();

            // Tinder requirement
            if (currentTier == SkillTiers.Beginner && Settings.settings.tinderLevelRequirement == 1 ||
                currentTier == SkillTiers.Novice && Settings.settings.tinderLevelRequirement == 2 ||
                currentTier == SkillTiers.Novice && Settings.settings.tinderLevelRequirement == 1)
            {
                __result += "\nCan start fires without tinder";
            }

            if ((currentTier == SkillTiers.Skilled && Settings.settings.tinderLevelRequirement >= 4) ||
                (currentTier == SkillTiers.Expert && Settings.settings.tinderLevelRequirement >= 5) ||
                (currentTier == SkillTiers.Master && Settings.settings.tinderLevelRequirement == 6))
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Tinder")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }



            //lvl 1
            if (currentTier == SkillTiers.Beginner && Settings.settings.fireDurationBonus1 >= 1) { __result += $"\nFires last {Settings.settings.fireDurationBonus1}% longer"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.quickerFireStarting1 >= 1) { __result += $"\nFires start {Settings.settings.quickerFireStarting1}% faster"; }

            if (currentTier == SkillTiers.Beginner && Settings.settings.fireBaseChance1 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Chance: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.fireBaseChance1}% chance to start fires";
                }

            }
            else if (currentTier == SkillTiers.Beginner && Settings.settings.fireBaseChance1 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Chance")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }


            //lvl 2
            if (currentTier == SkillTiers.Novice && Settings.settings.quickerFireStarting2 >= 1) { __result += $"\nFires start {Settings.settings.quickerFireStarting2}% faster"; }

            if (currentTier == SkillTiers.Novice && Settings.settings.fireBaseChance2 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Chance: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.fireBaseChance2}% chance to start fires";
                }

            }
            else if (currentTier == SkillTiers.Novice && Settings.settings.fireBaseChance2 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Chance")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Novice && Settings.settings.fireDurationBonus2 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Last: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Fires last {Settings.settings.fireDurationBonus2}% longer";
                }

            }
            else if (currentTier == SkillTiers.Novice && Settings.settings.fireDurationBonus2 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Last")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }


            //lvl 3
            if (currentTier == SkillTiers.Skilled && Settings.settings.quickerFireStarting3 >= 1) { __result += $"\nFires start {Settings.settings.quickerFireStarting3}% faster"; }

            if (currentTier == SkillTiers.Skilled && Settings.settings.fireBaseChance3 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Chance: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.fireBaseChance3}% chance to start fires";
                }

            }
            else if (currentTier == SkillTiers.Skilled && Settings.settings.fireBaseChance3 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Chance")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Skilled && Settings.settings.fireDurationBonus3 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Last: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Fires last {Settings.settings.fireDurationBonus3}% longer";
                }

            }
            else if (currentTier == SkillTiers.Skilled && Settings.settings.fireDurationBonus3 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Last")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }


            //lvl 4
            if (currentTier == SkillTiers.Expert && Settings.settings.quickerFireStarting4 >= 1) { __result += $"\nFires start {Settings.settings.quickerFireStarting4}% faster"; }

            if (currentTier == SkillTiers.Expert && Settings.settings.fireBaseChance4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Chance: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.fireBaseChance4}% chance to start fires";
                }

            }
            else if (currentTier == SkillTiers.Expert && Settings.settings.fireBaseChance4 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Chance")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Expert && Settings.settings.fireDurationBonus4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Last: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Fires last {Settings.settings.fireDurationBonus4}% longer";
                }

            }
            else if (currentTier == SkillTiers.Expert && Settings.settings.fireDurationBonus4 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Last")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }


            //lvl 5
            if (currentTier == SkillTiers.Master && Settings.settings.fireBaseChance5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Chance: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.fireBaseChance1}% chance to start fires";
                }

            }
            else if (currentTier == SkillTiers.Master && Settings.settings.fireBaseChance5 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Chance")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Master && Settings.settings.fireDurationBonus5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Last: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Fires last {Settings.settings.fireDurationBonus5}% longer";
                }

            }
            else if (currentTier == SkillTiers.Master && Settings.settings.fireDurationBonus5 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Last")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Master && Settings.settings.quickerFireStarting5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Faster: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Fires start {Settings.settings.quickerFireStarting5}% faster";
                }

            }
            else if (currentTier == SkillTiers.Master && Settings.settings.quickerFireStarting5 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Faster")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }
        }

    }

}
