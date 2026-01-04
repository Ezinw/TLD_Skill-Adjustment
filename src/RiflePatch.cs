using Il2Cpp;
using HarmonyLib;
using System.Text;

namespace SkillAdjustment
{
    [HarmonyPatch(typeof(SkillsManager), nameof(SkillsManager.Awake))]
    internal class RifleAdjustment
    {
        public static void Postfix(SkillsManager __instance)
        {
            var settings = Settings.settings;
            var rifle = __instance.m_Skill_Rifle;

            rifle.m_CriticalHitChanceIncrease[0] = settings.rifleCritical1;
            rifle.m_ConditionRepairBonus[0] = settings.rifleRepairBonus1;
            rifle.m_AccuracyRangeIncrease[0] = settings.rifleAccuracyRange1;
            rifle.m_DamageIncrease[0] = settings.rifleDamage1;
            rifle.m_ConditionDegradeOnUseReduction[0] = settings.rifleLessDegradeOnUse1;
            rifle.m_AimAssistAngleDegrees[0] = settings.rifleAimAssist1;
            rifle.m_EffectiveRange[0] = settings.rifleEffectiveRange1;
            rifle.m_StabilityBonus[0] = settings.rifleStabilityBonus1;


            rifle.m_CriticalHitChanceIncrease[1] = settings.rifleCritical2;
            rifle.m_ConditionRepairBonus[1] = settings.rifleRepairBonus2;
            rifle.m_AccuracyRangeIncrease[1] = settings.rifleAccuracyRange2;
            rifle.m_DamageIncrease[1] = settings.rifleDamage2;
            rifle.m_ConditionDegradeOnUseReduction[1] = settings.rifleLessDegradeOnUse2;
            rifle.m_AimAssistAngleDegrees[1] = settings.rifleAimAssist2;
            rifle.m_EffectiveRange[1] = settings.rifleEffectiveRange2;
            rifle.m_StabilityBonus[1] = settings.rifleStabilityBonus2;


            rifle.m_CriticalHitChanceIncrease[2] = settings.rifleCritical3;
            rifle.m_ConditionRepairBonus[2] = settings.rifleRepairBonus3;
            rifle.m_AccuracyRangeIncrease[2] = settings.rifleAccuracyRange3;
            rifle.m_DamageIncrease[2] = settings.rifleDamage3;
            rifle.m_ConditionDegradeOnUseReduction[2] = settings.rifleLessDegradeOnUse3;
            rifle.m_AimAssistAngleDegrees[2] = settings.rifleAimAssist3;
            rifle.m_EffectiveRange[2] = settings.rifleEffectiveRange3;
            rifle.m_StabilityBonus[2] = settings.rifleStabilityBonus3;


            rifle.m_CriticalHitChanceIncrease[3] = settings.rifleCritical4;
            rifle.m_ConditionRepairBonus[3] = settings.rifleRepairBonus4;
            rifle.m_AccuracyRangeIncrease[3] = settings.rifleAccuracyRange4;
            rifle.m_DamageIncrease[3] = settings.rifleDamage4;
            rifle.m_ConditionDegradeOnUseReduction[3] = settings.rifleLessDegradeOnUse4;
            rifle.m_AimAssistAngleDegrees[3] = settings.rifleAimAssist4;
            rifle.m_EffectiveRange[3] = settings.rifleEffectiveRange4;
            rifle.m_StabilityBonus[3] = settings.rifleStabilityBonus4;


            rifle.m_CriticalHitChanceIncrease[4] = settings.rifleCritical5;
            rifle.m_ConditionRepairBonus[4] = settings.rifleRepairBonus5;
            rifle.m_AccuracyRangeIncrease[4] = settings.rifleAccuracyRange5;
            rifle.m_DamageIncrease[4] = settings.rifleDamage5;
            rifle.m_ConditionDegradeOnUseReduction[4] = settings.rifleLessDegradeOnUse5;
            rifle.m_AimAssistAngleDegrees[4] = settings.rifleAimAssist5;
            rifle.m_EffectiveRange[4] = settings.rifleEffectiveRange5;
            rifle.m_StabilityBonus[4] = settings.rifleStabilityBonus5;


            Skill rifleSkill = __instance.GetSkill(SkillType.Rifle);

            if (rifleSkill != null)
            {
                rifleSkill.m_TierPoints[1] = settings.rifleTier2;
                rifleSkill.m_TierPoints[2] = settings.rifleTier3;
                rifleSkill.m_TierPoints[3] = settings.rifleTier4;
                rifleSkill.m_TierPoints[4] = settings.rifleTier5;
            }
        }
    }


    [HarmonyPatch(typeof(Skill_Rifle), nameof(Skill_Rifle.GetTierBenefits))]
    public static class RifleBenefits
    {
        static void Postfix(int index, ref string __result, Skill_Rifle __instance)
        {
            if (index < 0 || index > 4)
                return;

            var s = Settings.settings;
            var sb = new StringBuilder();

            if (index == 0 && !string.IsNullOrEmpty(__result))
            {
                sb.Append(__result.TrimEnd());
            }

            int[] crit =
            {
                s.rifleCritical1, s.rifleCritical2, s.rifleCritical3, s.rifleCritical4, s.rifleCritical5
            };

            int[] repairBonus =
            {
                s.rifleRepairBonus1, s.rifleRepairBonus2, s.rifleRepairBonus3, s.rifleRepairBonus4, s.rifleRepairBonus5
            };

            int[] accuracyRange =
            {
                s.rifleAccuracyRange1, s.rifleAccuracyRange2, s.rifleAccuracyRange3, s.rifleAccuracyRange4, s.rifleAccuracyRange5
            };

            int[] damage =
            {
                s.rifleDamage1, s.rifleDamage2, s.rifleDamage3, s.rifleDamage4, s.rifleDamage5
            };

            int[] degradeOnUse =
            {
                s.rifleLessDegradeOnUse1, s.rifleLessDegradeOnUse2, s.rifleLessDegradeOnUse3, s.rifleLessDegradeOnUse4, s.rifleLessDegradeOnUse5
            };

            int[] effectiveRange =
            {
                s.rifleEffectiveRange1, s.rifleEffectiveRange2, s.rifleEffectiveRange3, s.rifleEffectiveRange4, s.rifleEffectiveRange5
            };

            int[] stabilityBonus =
            {
                s.rifleStabilityBonus1, s.rifleStabilityBonus2, s.rifleStabilityBonus3, s.rifleStabilityBonus4, s.rifleStabilityBonus5
            };

            float[] aimAssist =
            {
                s.rifleAimAssist1, s.rifleAimAssist2, s.rifleAimAssist3, s.rifleAimAssist4, s.rifleAimAssist5
            };

            int tierCrit = crit[index];
            int tierRepairBonus = repairBonus[index];
            int tierAccuracyRange = accuracyRange[index];
            int tierDamage = damage[index];
            int tierDegrade = degradeOnUse[index];
            int tierEffective = effectiveRange[index];
            int tierStability = stabilityBonus[index];
            float tierAim = aimAssist[index];

            AppendBenefit(sb, tierCrit, "Critical hit chance increased by {0}%");
            AppendBenefit(sb, tierRepairBonus, "{0} Condition per repair action");
            AppendBenefit(sb, tierAccuracyRange, "Accuracy range increased by {0}%");
            AppendBenefit(sb, tierDamage, "Damage increased by {0}%");
            AppendBenefit(sb, tierDegrade, "Per-use condition degradation reduced by {0}%");
            AppendBenefit(sb, tierEffective, "Effective range increased by {0}");
            AppendBenefit(sb, tierStability, "Stability Bonus increased by {0}%");

            if (tierAim >= 0.1f)
            {
                AppendLine(sb, $"Increase aim assist angle degree: {tierAim:F2}");
            }

            __result = sb.ToString();
        }

        private static void AppendBenefit(StringBuilder sb, int value, string format)
        {
            if (value <= 0)
                return;

            AppendLine(sb, string.Format(format, value));
        }

        private static void AppendLine(StringBuilder sb, string line)
        {
            if (string.IsNullOrEmpty(line))
                return;

            if (sb.Length > 0)
                sb.Append('\n');

            sb.Append(line);
        }
    }
}
