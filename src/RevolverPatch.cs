using HarmonyLib;
using Il2Cpp;

namespace SkillAdjustment
{
    [HarmonyPatch(typeof(SkillsManager), nameof(SkillsManager.Awake))]
    internal class RevolverAdjustment
    {

        public static void Postfix(SkillsManager __instance)
        {
            __instance.m_Skill_Revolver.m_ConditionDegradeOnUseReduction[0] = Settings.settings.revolverDegradeOnUse1;
            __instance.m_Skill_Revolver.m_AimAssistAngleDegrees[0] = Settings.settings.revolverAim1;
            __instance.m_Skill_Revolver.m_RecoilCompensation[0] = Settings.settings.revolverRecoil1;
            __instance.m_Skill_Revolver.m_StruggleBonus[0] = Settings.settings.revolverStruggleBonus1;
            __instance.m_Skill_Revolver.m_ConditionRepairBonus[0] = Settings.settings.revolverRepairBonus1;
            __instance.m_Skill_Revolver.m_DamageIncrease[0] = Settings.settings.revolverDamage1;
            __instance.m_Skill_Revolver.m_CriticalHitChanceIncrease[0] = Settings.settings.revolverCritical1;


            __instance.m_Skill_Revolver.m_ConditionDegradeOnUseReduction[1] = Settings.settings.revolverDegradeOnUse2;
            __instance.m_Skill_Revolver.m_AimAssistAngleDegrees[1] = Settings.settings.revolverAim2;
            __instance.m_Skill_Revolver.m_RecoilCompensation[1] = Settings.settings.revolverRecoil2;
            __instance.m_Skill_Revolver.m_StruggleBonus[1] = Settings.settings.revolverStruggleBonus2;
            __instance.m_Skill_Revolver.m_ConditionRepairBonus[1] = Settings.settings.revolverRepairBonus2;
            __instance.m_Skill_Revolver.m_DamageIncrease[1] = Settings.settings.revolverDamage2;
            __instance.m_Skill_Revolver.m_CriticalHitChanceIncrease[1] = Settings.settings.revolverCritical2;


            __instance.m_Skill_Revolver.m_ConditionDegradeOnUseReduction[2] = Settings.settings.revolverDegradeOnUse3;
            __instance.m_Skill_Revolver.m_AimAssistAngleDegrees[2] = Settings.settings.revolverAim3;
            __instance.m_Skill_Revolver.m_RecoilCompensation[2] = Settings.settings.revolverRecoil3;
            __instance.m_Skill_Revolver.m_StruggleBonus[2] = Settings.settings.revolverStruggleBonus3;
            __instance.m_Skill_Revolver.m_ConditionRepairBonus[2] = Settings.settings.revolverRepairBonus3;
            __instance.m_Skill_Revolver.m_DamageIncrease[2] = Settings.settings.revolverDamage3;
            __instance.m_Skill_Revolver.m_CriticalHitChanceIncrease[2] = Settings.settings.revolverCritical3;


            __instance.m_Skill_Revolver.m_ConditionDegradeOnUseReduction[3] = Settings.settings.revolverDegradeOnUse4;
            __instance.m_Skill_Revolver.m_AimAssistAngleDegrees[3] = Settings.settings.revolverAim4;
            __instance.m_Skill_Revolver.m_RecoilCompensation[3] = Settings.settings.revolverRecoil4;
            __instance.m_Skill_Revolver.m_StruggleBonus[3] = Settings.settings.revolverStruggleBonus4;
            __instance.m_Skill_Revolver.m_ConditionRepairBonus[3] = Settings.settings.revolverRepairBonus4;
            __instance.m_Skill_Revolver.m_DamageIncrease[3] = Settings.settings.revolverDamage4;
            __instance.m_Skill_Revolver.m_CriticalHitChanceIncrease[3] = Settings.settings.revolverCritical4;


            __instance.m_Skill_Revolver.m_ConditionDegradeOnUseReduction[4] = Settings.settings.revolverDegradeOnUse5;
            __instance.m_Skill_Revolver.m_AimAssistAngleDegrees[4] = Settings.settings.revolverAim5;
            __instance.m_Skill_Revolver.m_RecoilCompensation[4] = Settings.settings.revolverRecoil5;
            __instance.m_Skill_Revolver.m_StruggleBonus[4] = Settings.settings.revolverStruggleBonus5;
            __instance.m_Skill_Revolver.m_ConditionRepairBonus[4] = Settings.settings.revolverRepairBonus5;
            __instance.m_Skill_Revolver.m_DamageIncrease[4] = Settings.settings.revolverDamage5;
            __instance.m_Skill_Revolver.m_CriticalHitChanceIncrease[4] = Settings.settings.revolverCritical5;


            Skill revolverSkill = __instance.GetSkill(SkillType.Revolver);

            if (revolverSkill != null)
            {
                revolverSkill.m_TierPoints[1] = Settings.settings.revolverTier2;
                revolverSkill.m_TierPoints[2] = Settings.settings.revolverTier3;
                revolverSkill.m_TierPoints[3] = Settings.settings.revolverTier4;
                revolverSkill.m_TierPoints[4] = Settings.settings.revolverTier5;
            }

        }

    }


    [HarmonyPatch(typeof(Skill_Revolver), nameof(Skill_Revolver.GetTierBenefits))]
    public class RevolverBenefits
    {
        static void Postfix(ref string __result, Skill_Revolver __instance)
        {
            SkillTiers currentTier = (SkillTiers)__instance.GetCurrentTierNumber();

            //lvl 1
            if (currentTier == SkillTiers.Beginner && Settings.settings.revolverDegradeOnUse1 >= 1) { __result += $"\nPer-use condition degradation reduced by {Settings.settings.revolverDegradeOnUse1}%"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.revolverAim1 >= 1 && Settings.settings.revolverAim1 <= 19) { __result += $"\nAim assist: Low"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.revolverAim1 >= 20 && Settings.settings.revolverAim1 <= 34) { __result += $"\nAim assist: Minor"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.revolverAim1 >= 35 && Settings.settings.revolverAim1 <= 65) { __result += $"\nAim assist: Moderate"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.revolverAim1 >= 66 && Settings.settings.revolverAim1 <= 85) { __result += $"\nAim assist: High"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.revolverAim1 >= 86 && Settings.settings.revolverAim1 <= 100) { __result += $"\nAim assist: Very High"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.revolverRecoil1 >= 1) { __result += $"\nRecoil compensation increased by {Settings.settings.revolverRecoil1}%"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.revolverStruggleBonus1 >= 1) { __result += $"\nStruggle effectiveness increased by {Settings.settings.revolverStruggleBonus1}%"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.revolverRepairBonus1 >= 1) { __result += $"\n{Settings.settings.revolverRepairBonus1} Condition per repair action"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.revolverDamage1 >= 1) { __result += $"\nDamage increased by {Settings.settings.revolverDamage1}%"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.revolverCritical1 >= 1) { __result += $"\nCritical hit chance increased by {Settings.settings.revolverCritical1}%"; }

            //lvl 2
            if (currentTier == SkillTiers.Novice && Settings.settings.revolverDegradeOnUse2 >= 1) { __result += $"\nPer-use condition degradation reduced by {Settings.settings.revolverDegradeOnUse2}%"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.revolverAim2 >= 1 && Settings.settings.revolverAim2 <= 19) { __result += $"\nAim assist: Low"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.revolverAim2 >= 20 && Settings.settings.revolverAim2 <= 34) { __result += $"\nAim assist: Minor"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.revolverAim2 >= 35 && Settings.settings.revolverAim2 <= 65) { __result += $"\nAim assist: Moderate"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.revolverAim2 >= 66 && Settings.settings.revolverAim2 <= 85) { __result += $"\nAim assist: High"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.revolverAim2 >= 86 && Settings.settings.revolverAim2 <= 100) { __result += $"\nAim assist: Very High"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.revolverStruggleBonus2 >= 1) { __result += $"\nStruggle effectiveness increased by {Settings.settings.revolverStruggleBonus2}%"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.revolverDamage2 >= 1) { __result += $"\nDamage increased by {Settings.settings.revolverDamage2}%"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.revolverCritical2 >= 1) { __result += $"\nCritical hit chance increased by {Settings.settings.revolverCritical2}%"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.revolverRepairBonus2 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Repair: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.revolverRepairBonus2} Condition per repair action";
                }
            }
            else if (currentTier == SkillTiers.Novice && Settings.settings.revolverRepairBonus2 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Repair")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Novice && Settings.settings.revolverRecoil2 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Recoil: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Recoil compensation increased by: {Settings.settings.revolverRecoil2}%";
                }
            }
            else if (currentTier == SkillTiers.Novice && Settings.settings.revolverRecoil2 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Recoil")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }


            //lvl 3
            if (currentTier == SkillTiers.Skilled && Settings.settings.revolverDegradeOnUse3 >= 1) { __result += $"\nPer-use condition degradation reduced by {Settings.settings.revolverDegradeOnUse3}%"; }
            if (currentTier == SkillTiers.Skilled && Settings.settings.revolverAim3 >= 1 && Settings.settings.revolverAim3 <= 19) { __result += $"\nAim assist: Low"; }
            if (currentTier == SkillTiers.Skilled && Settings.settings.revolverAim3 >= 20 && Settings.settings.revolverAim3 <= 34) { __result += $"\nAim assist: Minor"; }
            if (currentTier == SkillTiers.Skilled && Settings.settings.revolverAim3 >= 35 && Settings.settings.revolverAim3 <= 65) { __result += $"\nAim assist: Moderate"; }
            if (currentTier == SkillTiers.Skilled && Settings.settings.revolverAim3 >= 66 && Settings.settings.revolverAim3 <= 85) { __result += $"\nAim assist: High"; }
            if (currentTier == SkillTiers.Skilled && Settings.settings.revolverAim3 >= 86 && Settings.settings.revolverAim3 <= 100) { __result += $"\nAim assist: Very High"; }
            if (currentTier == SkillTiers.Skilled && Settings.settings.revolverDamage3 >= 1) { __result += $"\nDamage increased by {Settings.settings.revolverDamage3}%"; }
            if (currentTier == SkillTiers.Skilled && Settings.settings.revolverCritical3 >= 1) { __result += $"\nCritical hit chance increased by {Settings.settings.revolverCritical3}%"; }
            if (currentTier == SkillTiers.Skilled && Settings.settings.revolverRepairBonus3 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Repair: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.revolverRepairBonus3} Condition per repair action";
                }
            }
            else if (currentTier == SkillTiers.Skilled && Settings.settings.revolverRepairBonus3 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Repair")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Skilled && Settings.settings.revolverRecoil3 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Recoil: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Recoil compensation increased by: {Settings.settings.revolverRecoil3}%";
                }
            }
            else if (currentTier == SkillTiers.Skilled && Settings.settings.revolverRecoil3 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Recoil")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Skilled && Settings.settings.revolverStruggleBonus3 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Struggle: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Struggle effectiveness increased by: {Settings.settings.revolverStruggleBonus3}%";
                }
            }
            else if (currentTier == SkillTiers.Skilled && Settings.settings.revolverStruggleBonus3 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Struggle")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }


            //lvl 4
            if (currentTier == SkillTiers.Expert && Settings.settings.revolverDegradeOnUse4 >= 1) { __result += $"\nPer-use condition degradation reduced by {Settings.settings.revolverDegradeOnUse4}%"; }
            if (currentTier == SkillTiers.Expert && Settings.settings.revolverDamage4 >= 1) { __result += $"\nDamage increased by {Settings.settings.revolverDamage4}%"; }
            if (currentTier == SkillTiers.Expert && Settings.settings.revolverCritical4 >= 1) { __result += $"\nCritical hit chance increased by {Settings.settings.revolverCritical4}%"; }
            if (currentTier == SkillTiers.Expert && Settings.settings.revolverRepairBonus4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Repair: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.revolverRepairBonus4} Condition per repair action";
                }
            }
            else if (currentTier == SkillTiers.Expert && Settings.settings.revolverRepairBonus4 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Repair")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Expert && Settings.settings.revolverRecoil4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Recoil: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Recoil compensation increased by: {Settings.settings.revolverRecoil4}%";
                }
            }
            else if (currentTier == SkillTiers.Expert && Settings.settings.revolverRecoil4 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Recoil")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Expert && Settings.settings.revolverStruggleBonus4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Struggle: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Struggle effectiveness increased by: {Settings.settings.revolverStruggleBonus4}%";
                }
            }
            else if (currentTier == SkillTiers.Expert && Settings.settings.revolverStruggleBonus4 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Struggle")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if ((currentTier == SkillTiers.Expert && Settings.settings.revolverAim4 >= 1 && Settings.settings.revolverAim4 <= 19))
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Aim")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
                __result += $"\nAim assist: Low";
            }
            if ((currentTier == SkillTiers.Expert && Settings.settings.revolverAim4 >= 20 && Settings.settings.revolverAim4 <= 34))
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Aim")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
                __result += $"\nAim assist: Minor";
            }
            if ((currentTier == SkillTiers.Expert && Settings.settings.revolverAim4 >= 35 && Settings.settings.revolverAim4 <= 65))
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Aim")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
                __result += $"\nAim assist: Moderate";
            }
            if ((currentTier == SkillTiers.Expert && Settings.settings.revolverAim4 >= 66 && Settings.settings.revolverAim4 <= 85))
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Aim")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
                __result += $"\nAim assist: High";
            }
            if ((currentTier == SkillTiers.Expert && Settings.settings.revolverAim4 >= 86 && Settings.settings.revolverAim4 <= 100))
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Aim")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
                __result += $"\nAim assist: Very high";
            }
            else if ((currentTier == SkillTiers.Expert && Settings.settings.revolverAim4 >= 86 && Settings.settings.revolverAim4 == 0))
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Aim")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }


            //lvl 5
            if (currentTier == SkillTiers.Master && Settings.settings.revolverDamage5 >= 1) { __result += $"\nDamage increased by {Settings.settings.revolverDamage5}%"; }
            if (currentTier == SkillTiers.Master && Settings.settings.revolverCritical5 >= 1) { __result += $"\nCritical hit chance increased by {Settings.settings.revolverCritical5}%"; }
            if (currentTier == SkillTiers.Master && Settings.settings.revolverRepairBonus5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Repair: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.revolverRepairBonus5} Condition per repair action";
                }
            }
            else if (currentTier == SkillTiers.Master && Settings.settings.revolverRepairBonus5 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Repair")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Master && Settings.settings.revolverRecoil5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Recoil: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Recoil compensation increased by: {Settings.settings.revolverRecoil5}%";
                }
            }
            else if (currentTier == SkillTiers.Master && Settings.settings.revolverRecoil5 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Recoil")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Master && Settings.settings.revolverStruggleBonus5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Struggle: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Struggle effectiveness increased by: {Settings.settings.revolverStruggleBonus5}%";
                }
            }
            else if (currentTier == SkillTiers.Master && Settings.settings.revolverStruggleBonus5 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Struggle")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Master && Settings.settings.revolverDegradeOnUse5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Degradation: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Per-use condition degradation reduced by: {Settings.settings.revolverDegradeOnUse5}%";
                }
            }
            else if (currentTier == SkillTiers.Expert && Settings.settings.revolverDegradeOnUse5 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Degradation")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if ((currentTier == SkillTiers.Master && Settings.settings.revolverAim5 >= 1 && Settings.settings.revolverAim5 <= 19))
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Aim")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
                __result += $"\nAim assist: Low";
            }
            if ((currentTier == SkillTiers.Master && Settings.settings.revolverAim5 >= 20 && Settings.settings.revolverAim5 <= 34))
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Aim")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
                __result += $"\nAim assist: Minor";
            }
            if ((currentTier == SkillTiers.Master && Settings.settings.revolverAim5 >= 35 && Settings.settings.revolverAim5 <= 65))
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Aim")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
                __result += $"\nAim assist: Moderate";
            }
            if ((currentTier == SkillTiers.Master && Settings.settings.revolverAim5 >= 66 && Settings.settings.revolverAim5 <= 85))
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Aim")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
                __result += $"\nAim assist: High";
            }
            if ((currentTier == SkillTiers.Master && Settings.settings.revolverAim5 >= 86 && Settings.settings.revolverAim5 <= 100))
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Aim")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
                __result += $"\nAim assist: Very high";
            }
            else if ((currentTier == SkillTiers.Master && Settings.settings.revolverAim5 >= 86 && Settings.settings.revolverAim5 == 0))
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Aim")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

        }

    }

}
