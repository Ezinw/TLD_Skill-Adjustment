using HarmonyLib;
using Il2Cpp;

namespace SkillAdjustment
{
    [HarmonyPatch(typeof(SkillsManager), nameof(SkillsManager.Awake))]
    internal class ArcheryAdjustment
    {

        public static void Postfix(SkillsManager __instance)
        {
            __instance.m_Skill_Archery.m_LevelWhereCanFireFromCrouch = Settings.settings.CrouchLevel;

            __instance.m_Skill_Archery.m_SwayReduction[0] = Settings.settings.bowSway1;
            __instance.m_Skill_Archery.m_DamageIncrease[0] = Settings.settings.bowDamage1;
            __instance.m_Skill_Archery.m_CriticalHitChanceIncrease[0] = Settings.settings.bowCritical1;
            __instance.m_Skill_Archery.m_BleedOutTimeReduction[0] = Settings.settings.bowBleedOut1;
            __instance.m_Skill_Archery.m_ConditionDegradeOnUseReduction[0] = Settings.settings.bowPerUseConditionLoss1;

            __instance.m_Skill_Archery.m_SwayReduction[1] = Settings.settings.bowSway2;
            __instance.m_Skill_Archery.m_DamageIncrease[1] = Settings.settings.bowDamage2;
            __instance.m_Skill_Archery.m_CriticalHitChanceIncrease[1] = Settings.settings.bowCritical2;
            __instance.m_Skill_Archery.m_BleedOutTimeReduction[1] = Settings.settings.bowBleedOut2;
            __instance.m_Skill_Archery.m_ConditionDegradeOnUseReduction[1] = Settings.settings.bowPerUseConditionLoss2;

            __instance.m_Skill_Archery.m_SwayReduction[2] = Settings.settings.bowSway3;
            __instance.m_Skill_Archery.m_DamageIncrease[2] = Settings.settings.bowDamage3;
            __instance.m_Skill_Archery.m_CriticalHitChanceIncrease[2] = Settings.settings.bowCritical3;
            __instance.m_Skill_Archery.m_BleedOutTimeReduction[2] = Settings.settings.bowBleedOut3;
            __instance.m_Skill_Archery.m_ConditionDegradeOnUseReduction[2] = Settings.settings.bowPerUseConditionLoss3;

            __instance.m_Skill_Archery.m_SwayReduction[3] = Settings.settings.bowSway4;
            __instance.m_Skill_Archery.m_DamageIncrease[3] = Settings.settings.bowDamage4;
            __instance.m_Skill_Archery.m_CriticalHitChanceIncrease[3] = Settings.settings.bowCritical4;
            __instance.m_Skill_Archery.m_BleedOutTimeReduction[3] = Settings.settings.bowBleedOut4;
            __instance.m_Skill_Archery.m_ConditionDegradeOnUseReduction[3] = Settings.settings.bowPerUseConditionLoss4;

            __instance.m_Skill_Archery.m_SwayReduction[4] = Settings.settings.bowSway5;
            __instance.m_Skill_Archery.m_DamageIncrease[4] = Settings.settings.bowDamage5;
            __instance.m_Skill_Archery.m_CriticalHitChanceIncrease[4] = Settings.settings.bowCritical5;
            __instance.m_Skill_Archery.m_BleedOutTimeReduction[4] = Settings.settings.bowBleedOut5;
            __instance.m_Skill_Archery.m_ConditionDegradeOnUseReduction[4] = Settings.settings.bowPerUseConditionLoss5;


            Skill archerySkill = __instance.GetSkill(SkillType.Archery);

            if (archerySkill != null)
            {
                archerySkill.m_TierPoints[1] = Settings.settings.archeryTier2;
                archerySkill.m_TierPoints[2] = Settings.settings.archeryTier3;
                archerySkill.m_TierPoints[3] = Settings.settings.archeryTier4;
                archerySkill.m_TierPoints[4] = Settings.settings.archeryTier5;
            }
        }

    }


    [HarmonyPatch(typeof(Skill_Archery), nameof(Skill_Archery.GetTierBenefits))]
    public class ArcheryBenefits
    {
        static void Postfix(ref string __result, Skill_Archery __instance)
        {
            SkillTiers currentTier = (SkillTiers)__instance.GetCurrentTierNumber();

            //crouch
            if (currentTier == SkillTiers.Beginner && Settings.settings.CrouchLevel == 1 ||
                currentTier == SkillTiers.Novice && Settings.settings.CrouchLevel == 2 ||
                currentTier == SkillTiers.Novice && Settings.settings.CrouchLevel == 1 ||
                currentTier == SkillTiers.Skilled && Settings.settings.CrouchLevel == 3 ||
                currentTier == SkillTiers.Skilled && Settings.settings.CrouchLevel == 2 ||
                currentTier == SkillTiers.Skilled && Settings.settings.CrouchLevel == 1 ||
                currentTier == SkillTiers.Expert && Settings.settings.CrouchLevel == 4 ||
                currentTier == SkillTiers.Expert && Settings.settings.CrouchLevel == 3 ||
                currentTier == SkillTiers.Expert && Settings.settings.CrouchLevel == 2 ||
                currentTier == SkillTiers.Expert && Settings.settings.CrouchLevel == 1)
            { __result += "\nCan fire bow when crouched"; }

            //lvl 1
            if (currentTier == SkillTiers.Beginner && Settings.settings.bowSway1 >= 1) { __result += $"\nBow sway reduced by {Settings.settings.bowSway1}%"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.bowDamage1 >= 1) { __result += $"\nArrow damage increased by {Settings.settings.bowDamage1}%"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.bowCritical1 >= 1) { __result += $"\nCritical hit chance increased by {Settings.settings.bowCritical1}%"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.bowBleedOut1 >= 1) { __result += $"\nBleed out time reduced by {Settings.settings.bowBleedOut1}%"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.bowPerUseConditionLoss1 >= 1) { __result += $"\nPer-use bow condition loss reduced by {Settings.settings.bowPerUseConditionLoss1}%"; }

            //lvl 2
            if (currentTier == SkillTiers.Novice && Settings.settings.bowCritical2 >= 1) { __result += $"\nCritical hit chance increased by {Settings.settings.bowCritical2}%"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.bowBleedOut2 >= 1) { __result += $"\nBleed out time reduced by {Settings.settings.bowBleedOut2}%"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.bowPerUseConditionLoss2 >= 1) { __result += $"\nPer-use bow condition loss reduced by {Settings.settings.bowPerUseConditionLoss2}%"; }

            if (currentTier == SkillTiers.Novice && Settings.settings.bowSway2 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Sway: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Bow sway reduced by: {Settings.settings.bowSway2}%";
                }

            }
            else if (currentTier == SkillTiers.Novice && Settings.settings.bowSway2 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Sway")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Novice && Settings.settings.bowDamage2 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Arrow: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Arrow damage increased by: {Settings.settings.bowDamage2}%";
                }

            }
            else if (currentTier == SkillTiers.Novice && Settings.settings.bowDamage2 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Arrow")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }


            //lvl 3
            if (currentTier == SkillTiers.Skilled && Settings.settings.bowBleedOut3 >= 1) { __result += $"\nBleed out time reduced by {Settings.settings.bowBleedOut3}%"; }
            if (currentTier == SkillTiers.Skilled && Settings.settings.bowPerUseConditionLoss3 >= 1) { __result += $"\nPer-use bow condition loss reduced by {Settings.settings.bowPerUseConditionLoss3}%"; }
            if (currentTier == SkillTiers.Skilled && Settings.settings.bowSway3 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Sway: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Bow sway reduced by: {Settings.settings.bowSway3}%";
                }

            }
            else if (currentTier == SkillTiers.Skilled && Settings.settings.bowSway3 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Sway")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Skilled && Settings.settings.bowDamage3 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Arrow: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Arrow damage increased by: {Settings.settings.bowDamage3}%";
                }

            }
            else if (currentTier == SkillTiers.Skilled && Settings.settings.bowDamage3 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Arrow")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Skilled && Settings.settings.bowCritical3 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Critical: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Critical hit chance increased by: {Settings.settings.bowCritical3}%";
                }

            }
            else if (currentTier == SkillTiers.Skilled && Settings.settings.bowCritical3 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Critical")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }


            //lvl 4
            if (currentTier == SkillTiers.Expert && Settings.settings.bowSway4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Sway: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Bow sway reduced by: {Settings.settings.bowSway4}%";
                }

            }
            else if (currentTier == SkillTiers.Expert && Settings.settings.bowSway4 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Sway")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Expert && Settings.settings.bowDamage4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Arrow: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Arrow damage increased by: {Settings.settings.bowDamage4}%";
                }

            }
            else if (currentTier == SkillTiers.Expert && Settings.settings.bowDamage4 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Arrow")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Expert && Settings.settings.bowCritical4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Critical: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Critical hit chance increased by: {Settings.settings.bowCritical4}%";
                }

            }
            else if (currentTier == SkillTiers.Expert && Settings.settings.bowCritical4 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Critical")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Expert && Settings.settings.bowBleedOut4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Bleed: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Bleed out time reduced by: {Settings.settings.bowBleedOut4}%";
                }

            }
            else if (currentTier == SkillTiers.Expert && Settings.settings.bowBleedOut4 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Bleed")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Expert && Settings.settings.bowPerUseConditionLoss4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Condition: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Per-use bow condition loss reduced by: {Settings.settings.bowPerUseConditionLoss4}%";
                }

            }
            else if (currentTier == SkillTiers.Expert && Settings.settings.bowPerUseConditionLoss4 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Condition")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }


            //lvl 5
            if (currentTier == SkillTiers.Master && Settings.settings.bowSway5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Sway: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Bow sway reduced by: {Settings.settings.bowSway5}%";
                }

            }
            else if (currentTier == SkillTiers.Master && Settings.settings.bowSway5 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Sway")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Master && Settings.settings.bowDamage5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Arrow: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Arrow damage increased by: {Settings.settings.bowDamage5}%";
                }

            }
            else if (currentTier == SkillTiers.Master && Settings.settings.bowDamage5 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Arrow")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Master && Settings.settings.bowCritical5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Crit: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Critical hit chance increased by: {Settings.settings.bowCritical5}%";
                }

            }
            else if (currentTier == SkillTiers.Master && Settings.settings.bowCritical5 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Critical")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Master && Settings.settings.bowBleedOut5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Bleed: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Bleed out time reduced by: {Settings.settings.bowBleedOut5}%";
                }

            }
            else if (currentTier == SkillTiers.Master && Settings.settings.bowBleedOut5 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Bleed")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Master && Settings.settings.bowPerUseConditionLoss5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Condition: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Per-use bow condition loss reduced by: {Settings.settings.bowPerUseConditionLoss5}%";
                }

            }
            else if (currentTier == SkillTiers.Master && Settings.settings.bowPerUseConditionLoss5 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Condition")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

        }

    }

}

