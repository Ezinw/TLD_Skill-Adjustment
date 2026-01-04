using Il2Cpp;
using HarmonyLib;
using System.Text;

namespace SkillAdjustment
{
    [HarmonyPatch(typeof(SkillsManager), nameof(SkillsManager.Awake))]
    internal class RevolverAdjustment
    {
        public static void Postfix(SkillsManager __instance)
        {
            var settings = Settings.settings;
            var revolver = __instance.m_Skill_Revolver;

            revolver.m_ConditionDegradeOnUseReduction[0] = settings.revolverDegradeOnUse1;
            revolver.m_AimAssistAngleDegrees[0] = settings.revolverAim1;
            revolver.m_RecoilCompensation[0] = settings.revolverRecoil1;
            revolver.m_StruggleBonus[0] = settings.revolverStruggleBonus1;
            revolver.m_ConditionRepairBonus[0] = settings.revolverRepairBonus1;
            revolver.m_DamageIncrease[0] = settings.revolverDamage1;
            revolver.m_CriticalHitChanceIncrease[0] = settings.revolverCritical1;


            revolver.m_ConditionDegradeOnUseReduction[1] = settings.revolverDegradeOnUse2;
            revolver.m_AimAssistAngleDegrees[1] = settings.revolverAim2;
            revolver.m_RecoilCompensation[1] = settings.revolverRecoil2;
            revolver.m_StruggleBonus[1] = settings.revolverStruggleBonus2;
            revolver.m_ConditionRepairBonus[1] = settings.revolverRepairBonus2;
            revolver.m_DamageIncrease[1] = settings.revolverDamage2;
            revolver.m_CriticalHitChanceIncrease[1] = settings.revolverCritical2;


            revolver.m_ConditionDegradeOnUseReduction[2] = settings.revolverDegradeOnUse3;
            revolver.m_AimAssistAngleDegrees[2] = settings.revolverAim3;
            revolver.m_RecoilCompensation[2] = settings.revolverRecoil3;
            revolver.m_StruggleBonus[2] = settings.revolverStruggleBonus3;
            revolver.m_ConditionRepairBonus[2] = settings.revolverRepairBonus3;
            revolver.m_DamageIncrease[2] = settings.revolverDamage3;
            revolver.m_CriticalHitChanceIncrease[2] = settings.revolverCritical3;


            revolver.m_ConditionDegradeOnUseReduction[3] = settings.revolverDegradeOnUse4;
            revolver.m_AimAssistAngleDegrees[3] = settings.revolverAim4;
            revolver.m_RecoilCompensation[3] = settings.revolverRecoil4;
            revolver.m_StruggleBonus[3] = settings.revolverStruggleBonus4;
            revolver.m_ConditionRepairBonus[3] = settings.revolverRepairBonus4;
            revolver.m_DamageIncrease[3] = settings.revolverDamage4;
            revolver.m_CriticalHitChanceIncrease[3] = settings.revolverCritical4;


            revolver.m_ConditionDegradeOnUseReduction[4] = settings.revolverDegradeOnUse5;
            revolver.m_AimAssistAngleDegrees[4] = settings.revolverAim5;
            revolver.m_RecoilCompensation[4] = settings.revolverRecoil5;
            revolver.m_StruggleBonus[4] = settings.revolverStruggleBonus5;
            revolver.m_ConditionRepairBonus[4] = settings.revolverRepairBonus5;
            revolver.m_DamageIncrease[4] = settings.revolverDamage5;
            revolver.m_CriticalHitChanceIncrease[4] = settings.revolverCritical5;


            Skill revolverSkill = __instance.GetSkill(SkillType.Revolver);

            if (revolverSkill != null)
            {
                revolverSkill.m_TierPoints[1] = settings.revolverTier2;
                revolverSkill.m_TierPoints[2] = settings.revolverTier3;
                revolverSkill.m_TierPoints[3] = settings.revolverTier4;
                revolverSkill.m_TierPoints[4] = settings.revolverTier5;
            }
        }
    }


    [HarmonyPatch(typeof(Skill_Revolver), nameof(Skill_Revolver.GetTierBenefits))]
    public static class RevolverBenefits
    {
        static void Postfix(int index, ref string __result, Skill_Revolver __instance)
        {
            if (index < 0 || index > 4)
                return;

            var s = Settings.settings;
            var sb = new StringBuilder();

            if (index == 0 && !string.IsNullOrEmpty(__result))
            {
                sb.Append(__result.TrimEnd());
            }

            int[] degradeOnUse =
            {
                s.revolverDegradeOnUse1, s.revolverDegradeOnUse2, s.revolverDegradeOnUse3, s.revolverDegradeOnUse4, s.revolverDegradeOnUse5
            };

            int[] repairBonus =
            {
                s.revolverRepairBonus1, s.revolverRepairBonus2, s.revolverRepairBonus3, s.revolverRepairBonus4, s.revolverRepairBonus5
            };

            int[] damage =
            {
                s.revolverDamage1, s.revolverDamage2, s.revolverDamage3, s.revolverDamage4, s.revolverDamage5
            };

            int[] crit =
            {
                s.revolverCritical1, s.revolverCritical2, s.revolverCritical3, s.revolverCritical4, s.revolverCritical5
            };

            int[] aimAngle =
            {
                s.revolverAim1, s.revolverAim2, s.revolverAim3, s.revolverAim4, s.revolverAim5
            };

            int[] recoil =
            {
                s.revolverRecoil1, s.revolverRecoil2, s.revolverRecoil3, s.revolverRecoil4, s.revolverRecoil5
            };

            int[] struggle =
            {
                s.revolverStruggleBonus1, s.revolverStruggleBonus2, s.revolverStruggleBonus3, s.revolverStruggleBonus4, s.revolverStruggleBonus5
            };

            AppendBenefit(sb, degradeOnUse[index], "Per-use condition degradation reduced by {0}%");
            AppendBenefit(sb, damage[index], "Damage increased by {0}%");
            AppendBenefit(sb, crit[index], "Critical hit chance increased by {0}%");
            AppendBenefit(sb, recoil[index], "Recoil compensation increased by {0}%");
            AppendBenefit(sb, struggle[index], "Struggle effectiveness increased by {0}%");

            if (repairBonus[index] > 0)
                AppendLine(sb, $"{repairBonus[index]} Condition per repair action");

            var aimLabel = GetAimAssistLabel(aimAngle[index]);
            if (!string.IsNullOrEmpty(aimLabel))
                AppendLine(sb, aimLabel);

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
            if (sb.Length > 0)
                sb.Append('\n');

            sb.Append(line);
        }

        private static string? GetAimAssistLabel(int angle)
        {
            if (angle <= 0)
                return null;

            if (angle <= 19) return "Aim assist: Low";
            if (angle <= 34) return "Aim assist: Minor";
            if (angle <= 65) return "Aim assist: Moderate";
            if (angle <= 85) return "Aim assist: High";
            // 86–100+
            return "Aim assist: Very High";
        }
    }
}
