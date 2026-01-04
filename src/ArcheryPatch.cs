using Il2Cpp;
using HarmonyLib;
using System.Text;

namespace SkillAdjustment
{
    [HarmonyPatch(typeof(SkillsManager), nameof(SkillsManager.Awake))]
    internal class ArcheryAdjustment
    {
        public static void Postfix(SkillsManager __instance)
        {
            var settings = Settings.settings;
            var archery = __instance.m_Skill_Archery;
            
            // Adjust the skill level required to fire a bow while crouched
            archery.m_LevelWhereCanFireFromCrouch = settings.CrouchLevel;

            // Adjust the tier skill benefits for each tier
            // Tier 1
            archery.m_SwayReduction[0] = settings.bowSway1;
            archery.m_DamageIncrease[0] = settings.bowDamage1;
            archery.m_CriticalHitChanceIncrease[0] = settings.bowCritical1;
            archery.m_BleedOutTimeReduction[0] = settings.bowBleedOut1;
            archery.m_ConditionDegradeOnUseReduction[0] = settings.bowPerUseConditionLoss1;

            // Tier 2
            archery.m_SwayReduction[1] = settings.bowSway2;
            archery.m_DamageIncrease[1] = settings.bowDamage2;
            archery.m_CriticalHitChanceIncrease[1] = settings.bowCritical2;
            archery.m_BleedOutTimeReduction[1] = settings.bowBleedOut2;
            archery.m_ConditionDegradeOnUseReduction[1] = settings.bowPerUseConditionLoss2;

            // Tier 3
            archery.m_SwayReduction[2] = settings.bowSway3;
            archery.m_DamageIncrease[2] = settings.bowDamage3;
            archery.m_CriticalHitChanceIncrease[2] = settings.bowCritical3;
            archery.m_BleedOutTimeReduction[2] = settings.bowBleedOut3;
            archery.m_ConditionDegradeOnUseReduction[2] = settings.bowPerUseConditionLoss3;

            // Tier 4
            archery.m_SwayReduction[3] = settings.bowSway4;
            archery.m_DamageIncrease[3] = settings.bowDamage4;
            archery.m_CriticalHitChanceIncrease[3] = settings.bowCritical4;
            archery.m_BleedOutTimeReduction[3] = settings.bowBleedOut4;
            archery.m_ConditionDegradeOnUseReduction[3] = settings.bowPerUseConditionLoss4;
            
            //Tier 5
            archery.m_SwayReduction[4] = settings.bowSway5;
            archery.m_DamageIncrease[4] = settings.bowDamage5;
            archery.m_CriticalHitChanceIncrease[4] = settings.bowCritical5;
            archery.m_BleedOutTimeReduction[4] = settings.bowBleedOut5;
            archery.m_ConditionDegradeOnUseReduction[4] = settings.bowPerUseConditionLoss5;

            // XP for leveling skills
            Skill archerySkill = __instance.GetSkill(SkillType.Archery);

            if (archerySkill != null)
            {
                // Adjust the skill points required to level up to next tier
                archerySkill.m_TierPoints[1] = settings.archeryTier2;
                archerySkill.m_TierPoints[2] = settings.archeryTier3;
                archerySkill.m_TierPoints[3] = settings.archeryTier4;
                archerySkill.m_TierPoints[4] = settings.archeryTier5;
            }
        }
    }


    // Patch the Archery tier benefits text so the UI reflects custom values
    [HarmonyPatch(typeof(Skill_Archery), nameof(Skill_Archery.GetTierBenefits))]
    public static class ArcheryBenefits
    {
        // Postfix for GetTierBenefits(int index)
        // index is the tier index (0–4), __result is the vanilla description string
        static void Postfix(int index, ref string __result)
        {
            // Only handle valid tier indices
            if (index < 0 || index >= 5)
                return;

            var s = Settings.settings;

            // Arrays to index settings by 'index'
            int[] sway =
            {
                s.bowSway1, s.bowSway2, s.bowSway3, s.bowSway4, s.bowSway5
            };

            int[] damage =
            {
                s.bowDamage1, s.bowDamage2, s.bowDamage3, s.bowDamage4, s.bowDamage5
            };

            int[] crit =
            {
                s.bowCritical1, s.bowCritical2, s.bowCritical3, s.bowCritical4, s.bowCritical5
            };

            int[] bleed =
            {
                s.bowBleedOut1, s.bowBleedOut2, s.bowBleedOut3, s.bowBleedOut4, s.bowBleedOut5
            };

            int[] condition =
            {
                s.bowPerUseConditionLoss1, s.bowPerUseConditionLoss2, s.bowPerUseConditionLoss3, s.bowPerUseConditionLoss4, s.bowPerUseConditionLoss5
            };

            // Rebuild the benefits text using a StringBuilder
            var sb = new StringBuilder();

            if (index == 0 && !string.IsNullOrEmpty(__result))
            {
                // Avoid duplicated blank lines
                sb.Append(__result.TrimEnd());
            }

            // Append the dynamic benefit lines only if the value for that tier is > 0
            AppendBenefit(sb, sway[index], "Bow sway reduced by {0}%");
            AppendBenefit(sb, damage[index], "Arrow damage increased by {0}%");
            AppendBenefit(sb, crit[index], "Critical hit chance increased by {0}%");
            AppendBenefit(sb, bleed[index], "Bleed out time reduced by {0}%");
            AppendBenefit(sb, condition[index], "Per-use bow condition loss reduced by {0}%");

            // Conditionally show the crouch firing benefit, based on configured CrouchLevel and current tier
            if (ShouldShowCrouch(index, s.CrouchLevel))
            {
                AppendRawLine(sb, "Can fire bow when crouched");
            }

            // Replace the original result string with rebuilt version
            __result = sb.ToString();
        }

        // Append a formatted benefit line if the value is positive
        private static void AppendBenefit(StringBuilder sb, int value, string format)
        {
            // Zero or negative values are treated as "no benefit"
            if (value <= 0)
                return;

            // If there's already text, add a newline before appending the next benefit
            if (sb.Length > 0)
                sb.Append('\n');

            // Insert the value into the provided format string
            sb.AppendFormat(format, value);
        }

        // Appends a raw line of text with newline handling
        private static void AppendRawLine(StringBuilder sb, string text)
        {
            if (sb.Length > 0)
                sb.Append('\n');

            sb.Append(text);
        }

        // Determines whether the "Can fire bow when crouched" line should show at a given tier
        private static bool ShouldShowCrouch(int tierIndex, int crouchLevel)
        {
            // Ignore invalid crouch levels (0 or out of range)
            if (crouchLevel <= 0 || crouchLevel > 4)
                return false;

            // Do not show on tier 5 as it will already be displayed
            if (tierIndex > 3)
                return false;

            // Show the line starting at the configured crouch level:
            // e.g. crouchLevel = 3 ? show at index >= 2 (tier 3 and up)
            return tierIndex >= (crouchLevel - 1);
        }
    }
}
