using Il2Cpp;
using HarmonyLib;
using System.Text;

namespace SkillAdjustment
{
    [HarmonyPatch(typeof(SkillsManager), nameof(SkillsManager.Awake))]
    internal class MendingAdjustment
    {
        public static void Postfix(SkillsManager __instance)
        {
            var settings = Settings.settings;
            var mending = __instance.m_Skill_ClothingRepair;

            mending.m_BaseSuccessChance[0] = settings.mendingSuccessChance1;
            mending.m_ItemConditionPercentIncrease[0] = settings.mendingConditionBonus1;
            mending.m_RepairTimePercentDecrease[0] = settings.mendingRepairTimeReduced1;
            mending.m_SewingToolDegradeDecrease[0] = settings.SewingKitDegradeDecrease1;

            mending.m_BaseSuccessChance[1] = settings.mendingSuccessChance2;
            mending.m_ItemConditionPercentIncrease[1] = settings.mendingConditionBonus2;
            mending.m_RepairTimePercentDecrease[1] = settings.mendingRepairTimeReduced2;
            mending.m_SewingToolDegradeDecrease[1] = settings.SewingKitDegradeDecrease2;

            mending.m_BaseSuccessChance[2] = settings.mendingSuccessChance3;
            mending.m_ItemConditionPercentIncrease[2] = settings.mendingConditionBonus3;
            mending.m_RepairTimePercentDecrease[2] = settings.mendingRepairTimeReduced3;
            mending.m_SewingToolDegradeDecrease[2] = settings.SewingKitDegradeDecrease3;

            mending.m_BaseSuccessChance[3] = settings.mendingSuccessChance4;
            mending.m_ItemConditionPercentIncrease[3] = settings.mendingConditionBonus4;
            mending.m_RepairTimePercentDecrease[3] = settings.mendingRepairTimeReduced4;
            mending.m_SewingToolDegradeDecrease[3] = settings.SewingKitDegradeDecrease4;

            mending.m_BaseSuccessChance[4] = settings.mendingSuccessChance5;
            mending.m_ItemConditionPercentIncrease[4] = settings.mendingConditionBonus5;
            mending.m_RepairTimePercentDecrease[4] = settings.mendingRepairTimeReduced5;
            mending.m_SewingToolDegradeDecrease[4] = settings.SewingKitDegradeDecrease5;


            Skill ClothingRepair = __instance.GetSkill(SkillType.ClothingRepair);

            if (ClothingRepair != null)
            {
                ClothingRepair.m_TierPoints[1] = settings.mendTier2;
                ClothingRepair.m_TierPoints[2] = settings.mendTier3;
                ClothingRepair.m_TierPoints[3] = settings.mendTier4;
                ClothingRepair.m_TierPoints[4] = settings.mendTier5;
            }
        }
    }


    [HarmonyPatch(typeof(Skill_ClothingRepair), nameof(Skill_ClothingRepair.GetTierBenefits))]
    public static class ClothingRepairBenefits
    {
        static void Postfix(int index, ref string __result, Skill_ClothingRepair __instance)
        {
            if (index < 0 || index > 4)
                return;

            var s = Settings.settings;
            var sb = new StringBuilder();

            int[] successChance =
            {
                s.mendingSuccessChance1, s.mendingSuccessChance2, s.mendingSuccessChance3, s.mendingSuccessChance4, s.mendingSuccessChance5
            };

            int[] conditionBonus =
            {
                s.mendingConditionBonus1, s.mendingConditionBonus2, s.mendingConditionBonus3, s.mendingConditionBonus4, s.mendingConditionBonus5
            };

            int[] repairTimeDecrease =
            {
                s.mendingRepairTimeReduced1, s.mendingRepairTimeReduced2, s.mendingRepairTimeReduced3, s.mendingRepairTimeReduced4, s.mendingRepairTimeReduced5
            };

            int[] sewingDegradeDecrease =
            {
                s.SewingKitDegradeDecrease1, s.SewingKitDegradeDecrease2, s.SewingKitDegradeDecrease3, s.SewingKitDegradeDecrease4, s.SewingKitDegradeDecrease5
            };

            AppendBenefit(sb, successChance[index], "{0}% chance of successful repair");
            AppendBenefit(sb, conditionBonus[index], "{0}% greater item condition increase");
            AppendBenefit(sb, repairTimeDecrease[index], "Repair time decreased by {0}%");
            AppendBenefit(sb, sewingDegradeDecrease[index], "{0}% reduction of sewing kit wear");

            __result = sb.ToString();
        }

        private static void AppendBenefit(StringBuilder sb, int value, string format)
        {
            if (value <= 0)
                return;

            if (sb.Length > 0)
                sb.Append('\n');

            sb.AppendFormat(format, value);
        }
    }
}
