using Il2Cpp;
using HarmonyLib;
using System.Text;

namespace SkillAdjustment
{
    [HarmonyPatch(typeof(SkillsManager), nameof(SkillsManager.Awake))]
    internal class HarvestAdjustment
    {
        public static void Postfix(SkillsManager __instance)
        {
            var settings = Settings.settings;
            var fireStarting = __instance.m_Skill_CarcassHarvesting;

            fireStarting.m_NumHoursHarvestPerSkillPoint = settings.harvestHoursForSkillPoint;
            //fireStarting.m_NumHoursToConvertToSkillPoints = settings.convertHours;

            fireStarting.m_FrozenThresholdPercent[0] = settings.harvestFrozen1;
            fireStarting.m_HideGutTimePercentDecrease[0] = settings.hideGutHarvestTime1;
            fireStarting.m_MeatTimePercentDecrease[0] = settings.meatHarvestTime1;

            fireStarting.m_FrozenThresholdPercent[1] = settings.harvestFrozen2;
            fireStarting.m_HideGutTimePercentDecrease[1] = settings.hideGutHarvestTime2;
            fireStarting.m_MeatTimePercentDecrease[1] = settings.meatHarvestTime2;

            fireStarting.m_FrozenThresholdPercent[2] = settings.harvestFrozen3;
            fireStarting.m_HideGutTimePercentDecrease[2] = settings.hideGutHarvestTime3;
            fireStarting.m_MeatTimePercentDecrease[2] = settings.meatHarvestTime3;

            fireStarting.m_FrozenThresholdPercent[3] = settings.harvestFrozen4;
            fireStarting.m_HideGutTimePercentDecrease[3] = settings.hideGutHarvestTime4;
            fireStarting.m_MeatTimePercentDecrease[3] = settings.meatHarvestTime4;

            fireStarting.m_FrozenThresholdPercent[4] = settings.harvestFrozen5;
            fireStarting.m_HideGutTimePercentDecrease[4] = settings.hideGutHarvestTime5;
            fireStarting.m_MeatTimePercentDecrease[4] = settings.meatHarvestTime5;
            
            
            Skill carcassharvesting = __instance.GetSkill(SkillType.CarcassHarvesting);

            if (carcassharvesting != null)
            {
                carcassharvesting.m_TierPoints[1] = settings.harvestTier2;
                carcassharvesting.m_TierPoints[2] = settings.harvestTier3;
                carcassharvesting.m_TierPoints[3] = settings.harvestTier4;
                carcassharvesting.m_TierPoints[4] = settings.harvestTier5;
            }

        }
    }


    [HarmonyPatch(typeof(Skill_CarcassHarvesting), nameof(Skill_CarcassHarvesting.GetTierBenefits))]
    public static class HarvestingBenefits
    {
        static void Postfix(int index, ref string __result, Skill_CarcassHarvesting __instance)
        {
            if (index < 0 || index > 4)
                return;

            var s = Settings.settings;
            var sb = new StringBuilder();

            if (index == 0 && !string.IsNullOrEmpty(__result))
            {
                sb.Append(__result.TrimEnd());
            }

            int[] frozen =
            {
                s.harvestFrozen1, s.harvestFrozen2, s.harvestFrozen3, s.harvestFrozen4, s.harvestFrozen5
            };

            int[] hideGutTime =
            {
                s.hideGutHarvestTime1, s.hideGutHarvestTime2, s.hideGutHarvestTime3, s.hideGutHarvestTime4, s.hideGutHarvestTime5
            };

            int[] meatTime =
            {
                s.meatHarvestTime1, s.meatHarvestTime2, s.meatHarvestTime3, s.meatHarvestTime4, s.meatHarvestTime5
            };

            AppendBenefit(sb, frozen[index], "Can harvest {0}% frozen carcasses by hand");
            AppendBenefit(sb, hideGutTime[index], "{0}% reduction in hide or gut harvesting times");
            AppendBenefit(sb, meatTime[index], "{0}% reduction in meat harvesting times");

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
