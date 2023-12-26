using HarmonyLib;
using Il2Cpp;

namespace SkillAdjustment
{
    [HarmonyPatch(typeof(SkillsManager), nameof(SkillsManager.Awake))]
    internal class RifleAdjustment
    {

        public static void Postfix(SkillsManager __instance)
        {
            __instance.m_Skill_Rifle.m_CriticalHitChanceIncrease[0] = Settings.settings.rifleCritical1;
            __instance.m_Skill_Rifle.m_ConditionRepairBonus[0] = Settings.settings.rifleRepairBonus1;
            __instance.m_Skill_Rifle.m_AccuracyRangeIncrease[0] = Settings.settings.rifleAccuracyRange1;
            __instance.m_Skill_Rifle.m_DamageIncrease[0] = Settings.settings.rifleDamage1;
            __instance.m_Skill_Rifle.m_ConditionDegradeOnUseReduction[0] = Settings.settings.rifleLessDegradeOnUse1;
            __instance.m_Skill_Rifle.m_AimAssistAngleDegrees[0] = Settings.settings.rifleAimAssist1;
            __instance.m_Skill_Rifle.m_EffectiveRange[0] = Settings.settings.rifleEffectiveRange1;
            __instance.m_Skill_Rifle.m_StabilityBonus[0] = Settings.settings.rifleStabilityBonus1;


            __instance.m_Skill_Rifle.m_CriticalHitChanceIncrease[1] = Settings.settings.rifleCritical2;
            __instance.m_Skill_Rifle.m_ConditionRepairBonus[1] = Settings.settings.rifleRepairBonus2;
            __instance.m_Skill_Rifle.m_AccuracyRangeIncrease[1] = Settings.settings.rifleAccuracyRange2;
            __instance.m_Skill_Rifle.m_DamageIncrease[1] = Settings.settings.rifleDamage2;
            __instance.m_Skill_Rifle.m_ConditionDegradeOnUseReduction[1] = Settings.settings.rifleLessDegradeOnUse2;
            __instance.m_Skill_Rifle.m_AimAssistAngleDegrees[1] = Settings.settings.rifleAimAssist2;
            __instance.m_Skill_Rifle.m_EffectiveRange[1] = Settings.settings.rifleEffectiveRange2;
            __instance.m_Skill_Rifle.m_StabilityBonus[1] = Settings.settings.rifleStabilityBonus2;


            __instance.m_Skill_Rifle.m_CriticalHitChanceIncrease[2] = Settings.settings.rifleCritical3;
            __instance.m_Skill_Rifle.m_ConditionRepairBonus[2] = Settings.settings.rifleRepairBonus3;
            __instance.m_Skill_Rifle.m_AccuracyRangeIncrease[2] = Settings.settings.rifleAccuracyRange3;
            __instance.m_Skill_Rifle.m_DamageIncrease[2] = Settings.settings.rifleDamage3;
            __instance.m_Skill_Rifle.m_ConditionDegradeOnUseReduction[2] = Settings.settings.rifleLessDegradeOnUse3;
            __instance.m_Skill_Rifle.m_AimAssistAngleDegrees[2] = Settings.settings.rifleAimAssist3;
            __instance.m_Skill_Rifle.m_EffectiveRange[2] = Settings.settings.rifleEffectiveRange3;
            __instance.m_Skill_Rifle.m_StabilityBonus[2] = Settings.settings.rifleStabilityBonus3;


            __instance.m_Skill_Rifle.m_CriticalHitChanceIncrease[3] = Settings.settings.rifleCritical4;
            __instance.m_Skill_Rifle.m_ConditionRepairBonus[3] = Settings.settings.rifleRepairBonus4;
            __instance.m_Skill_Rifle.m_AccuracyRangeIncrease[3] = Settings.settings.rifleAccuracyRange4;
            __instance.m_Skill_Rifle.m_DamageIncrease[3] = Settings.settings.rifleDamage4;
            __instance.m_Skill_Rifle.m_ConditionDegradeOnUseReduction[3] = Settings.settings.rifleLessDegradeOnUse4;
            __instance.m_Skill_Rifle.m_AimAssistAngleDegrees[3] = Settings.settings.rifleAimAssist4;
            __instance.m_Skill_Rifle.m_EffectiveRange[3] = Settings.settings.rifleEffectiveRange4;
            __instance.m_Skill_Rifle.m_StabilityBonus[3] = Settings.settings.rifleStabilityBonus4;


            __instance.m_Skill_Rifle.m_CriticalHitChanceIncrease[4] = Settings.settings.rifleCritical5;
            __instance.m_Skill_Rifle.m_ConditionRepairBonus[4] = Settings.settings.rifleRepairBonus5;
            __instance.m_Skill_Rifle.m_AccuracyRangeIncrease[4] = Settings.settings.rifleAccuracyRange5;
            __instance.m_Skill_Rifle.m_DamageIncrease[4] = Settings.settings.rifleDamage5;
            __instance.m_Skill_Rifle.m_ConditionDegradeOnUseReduction[4] = Settings.settings.rifleLessDegradeOnUse5;
            __instance.m_Skill_Rifle.m_AimAssistAngleDegrees[4] = Settings.settings.rifleAimAssist5;
            __instance.m_Skill_Rifle.m_EffectiveRange[4] = Settings.settings.rifleEffectiveRange5;
            __instance.m_Skill_Rifle.m_StabilityBonus[4] = Settings.settings.rifleStabilityBonus5;


            Skill rifleSkill = __instance.GetSkill(SkillType.Rifle);

            if (rifleSkill != null)
            {
                rifleSkill.m_TierPoints[1] = Settings.settings.rifleTier2;
                rifleSkill.m_TierPoints[2] = Settings.settings.rifleTier3;
                rifleSkill.m_TierPoints[3] = Settings.settings.rifleTier4;
                rifleSkill.m_TierPoints[4] = Settings.settings.rifleTier5;
            }
        }

    }

    [HarmonyPatch(typeof(Skill_Rifle), nameof(Skill_Rifle.GetTierBenefits))]
    public class RifleBenefits
    {
        static void Postfix(ref string __result, Skill_Rifle __instance)
        {
            SkillTiers currentTier = (SkillTiers)__instance.GetCurrentTierNumber();

            //lvl 1
            if (currentTier == SkillTiers.Beginner && Settings.settings.rifleCritical1 >= 1) { __result += $"\nCritical hit chance increased by {Settings.settings.rifleCritical1}%"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.rifleRepairBonus1 >= 1) { __result += $"\n{Settings.settings.rifleRepairBonus1} Condition per repair action"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.rifleAccuracyRange1 >= 1) { __result += $"\nAccuracy range increased by {Settings.settings.rifleAccuracyRange1}%"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.rifleDamage1 >= 1) { __result += $"\nDamage increased by {Settings.settings.rifleDamage1}%"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.rifleLessDegradeOnUse1 >= 1) { __result += $"\nPer-use condition degradation reduced by {Settings.settings.rifleLessDegradeOnUse1}%"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.rifleAimAssist1 >= 0.1) { __result += $"\nIncrease aim assist angle degree: {Settings.settings.rifleAimAssist1:F2}"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.rifleEffectiveRange1 >= 1) { __result += $"\nEffective range increased by {Settings.settings.rifleEffectiveRange1}"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.rifleStabilityBonus1 >= 1) { __result += $"\nStability Bonus increased by {Settings.settings.rifleStabilityBonus1}%"; }


            //lvl 2
            if (currentTier == SkillTiers.Novice && Settings.settings.rifleAccuracyRange2 >= 1) { __result += $"\nAccuracy range increased by {Settings.settings.rifleAccuracyRange2}%"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.rifleDamage2 >= 1) { __result += $"\nDamage increased by {Settings.settings.rifleDamage2}%"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.rifleLessDegradeOnUse2 >= 1) { __result += $"\nPer-use condition degradation reduced by {Settings.settings.rifleLessDegradeOnUse2}%"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.rifleEffectiveRange2 >= 1) { __result += $"\nEffective range increased by {Settings.settings.rifleEffectiveRange2}"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.rifleAimAssist2 >= 0.1) { __result += $"\nIncrease aim assist angle degree: {Settings.settings.rifleAimAssist2:F2}"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.rifleStabilityBonus2 >= 1) { __result += $"\nStability Bonus increased by {Settings.settings.rifleStabilityBonus2}%"; }

            if (currentTier == SkillTiers.Novice && Settings.settings.rifleCritical2 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Critical: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Critical hit chance increased by {Settings.settings.rifleCritical2}%";
                }
            }
            else if (currentTier == SkillTiers.Novice && Settings.settings.rifleCritical2 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Critical")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Novice && Settings.settings.rifleRepairBonus2 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Repair: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.rifleRepairBonus2} Condition per repair action";
                }
            }
            else if (currentTier == SkillTiers.Novice && Settings.settings.rifleRepairBonus2 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Repair")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }


            //lvl 3
            if (currentTier == SkillTiers.Skilled && Settings.settings.rifleDamage3 >= 1) { __result += $"\nDamage increased by {Settings.settings.rifleDamage3}%"; }
            if (currentTier == SkillTiers.Skilled && Settings.settings.rifleLessDegradeOnUse3 >= 1) { __result += $"\nPer-use condition degradation reduced by {Settings.settings.rifleLessDegradeOnUse3}%"; }
            if (currentTier == SkillTiers.Skilled && Settings.settings.rifleEffectiveRange3 >= 1) { __result += $"\nEffective range increased by {Settings.settings.rifleEffectiveRange3}"; }
            if (currentTier == SkillTiers.Skilled && Settings.settings.rifleAimAssist3 >= 0.1) { __result += $"\nIncrease aim assist angle degree: {Settings.settings.rifleAimAssist3:F2}"; }
            if (currentTier == SkillTiers.Skilled && Settings.settings.rifleStabilityBonus3 >= 1) { __result += $"\nStability Bonus increased by {Settings.settings.rifleStabilityBonus3}%"; }


            if (currentTier == SkillTiers.Skilled && Settings.settings.rifleCritical3 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Critical: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Critical hit chance increased by {Settings.settings.rifleCritical3}%";
                }
            }
            else if (currentTier == SkillTiers.Skilled && Settings.settings.rifleCritical3 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Critical")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Skilled && Settings.settings.rifleRepairBonus3 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Repair: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.rifleRepairBonus3} Condition per repair action";
                }
            }
            else if (currentTier == SkillTiers.Skilled && Settings.settings.rifleRepairBonus3 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Repair")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Skilled && Settings.settings.rifleAccuracyRange3 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Accuracy: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Accuracy range increased by {Settings.settings.rifleAccuracyRange3}%";
                }
            }
            else if (currentTier == SkillTiers.Skilled && Settings.settings.rifleAccuracyRange3 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Accuracy")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }


            //lvl 4
            if (currentTier == SkillTiers.Expert && Settings.settings.rifleLessDegradeOnUse4 >= 1) { __result += $"\nPer-use condition degradation reduced by {Settings.settings.rifleLessDegradeOnUse4}%"; }
            if (currentTier == SkillTiers.Expert && Settings.settings.rifleEffectiveRange4 >= 1) { __result += $"\nEffective range increased by {Settings.settings.rifleEffectiveRange4}"; }
            if (currentTier == SkillTiers.Expert && Settings.settings.rifleAimAssist4 >= 0.1) { __result += $"\nIncrease aim assist angle degree: {Settings.settings.rifleAimAssist4:F2}"; }
            if (currentTier == SkillTiers.Expert && Settings.settings.rifleStabilityBonus4 >= 1) { __result += $"\nStability Bonus increased by {Settings.settings.rifleStabilityBonus4}%"; }


            if (currentTier == SkillTiers.Expert && Settings.settings.rifleCritical4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Critical: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Critical hit chance increased by {Settings.settings.rifleCritical4}%";
                }
            }
            else if (currentTier == SkillTiers.Expert && Settings.settings.rifleCritical4 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Critical")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Expert && Settings.settings.rifleRepairBonus4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Repair: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.rifleRepairBonus4} Condition per repair action";
                }
            }
            else if (currentTier == SkillTiers.Expert && Settings.settings.rifleRepairBonus4 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Repair")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Expert && Settings.settings.rifleAccuracyRange4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Accuracy: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Accuracy range increased by {Settings.settings.rifleAccuracyRange4}%";
                }
            }
            else if (currentTier == SkillTiers.Expert && Settings.settings.rifleAccuracyRange4 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Accuracy")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Expert && Settings.settings.rifleDamage4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Damage: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Damage increased by {Settings.settings.rifleDamage4}%";
                }
            }
            else if (currentTier == SkillTiers.Expert && Settings.settings.rifleDamage4 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Damage")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }


            //lvl 5
            if (currentTier == SkillTiers.Master && Settings.settings.rifleEffectiveRange5 >= 1) { __result += $"\nEffective range increased by {Settings.settings.rifleEffectiveRange5}"; }
            if (currentTier == SkillTiers.Master && Settings.settings.rifleAimAssist5 >= 0.1) { __result += $"\nIncrease aim assist angle degree: {Settings.settings.rifleAimAssist5:F2}"; }
            if (currentTier == SkillTiers.Master && Settings.settings.rifleStabilityBonus5 >= 1) { __result += $"\nStability Bonus increased by {Settings.settings.rifleStabilityBonus5}%"; }

            if (currentTier == SkillTiers.Master && Settings.settings.rifleCritical5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Critical: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Critical hit chance increased by {Settings.settings.rifleCritical5}%";
                }
            }
            else if (currentTier == SkillTiers.Master && Settings.settings.rifleCritical5 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Critical")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Master && Settings.settings.rifleRepairBonus5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Repair: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.rifleRepairBonus5} Condition per repair action";
                }
            }
            else if (currentTier == SkillTiers.Master && Settings.settings.rifleRepairBonus5 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Repair")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Master && Settings.settings.rifleAccuracyRange5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Accuracy: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Accuracy range increased by {Settings.settings.rifleAccuracyRange5}%";
                }
            }
            else if (currentTier == SkillTiers.Master && Settings.settings.rifleAccuracyRange5 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Accuracy")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Master && Settings.settings.rifleDamage5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Damage: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Damage increased by {Settings.settings.rifleDamage5}%";
                }
            }
            else if (currentTier == SkillTiers.Master && Settings.settings.rifleDamage5 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Damage")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Master && Settings.settings.rifleLessDegradeOnUse5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Degradation: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Per-use condition degradation reduced by {Settings.settings.rifleLessDegradeOnUse5}%";
                }
            }
            else if (currentTier == SkillTiers.Master && Settings.settings.rifleLessDegradeOnUse5 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Degradation")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

        }
    }

}

