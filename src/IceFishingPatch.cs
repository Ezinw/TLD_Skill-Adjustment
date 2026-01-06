using Il2Cpp;
using HarmonyLib;
using System.Text;

namespace SkillAdjustment
{
    [HarmonyPatch(typeof(SkillsManager), nameof(SkillsManager.Awake))]
    internal class IceFishingAdjustment
    {
        public static void Postfix(SkillsManager __instance)
        {
            var settings = Settings.settings;
            var iceFishing = __instance.m_Skill_IceFishing;

            iceFishing.m_IncreaseFishWeightPercent[0] = settings.fishWeight1;
            iceFishing.m_LineBreakOnCatchChance[0] = settings.lineBreak1;
            iceFishing.m_ReduceFishingTimePercent[0] = settings.fishingTime1;

            iceFishing.m_IncreaseFishWeightPercent[1] = settings.fishWeight2;
            iceFishing.m_LineBreakOnCatchChance[1] = settings.lineBreak2;
            iceFishing.m_ReduceFishingTimePercent[1] = settings.fishingTime2;

            iceFishing.m_IncreaseFishWeightPercent[2] = settings.fishWeight3;
            iceFishing.m_LineBreakOnCatchChance[2] = settings.lineBreak3;
            iceFishing.m_ReduceFishingTimePercent[2] = settings.fishingTime3;

            iceFishing.m_IncreaseFishWeightPercent[3] = settings.fishWeight4;
            iceFishing.m_LineBreakOnCatchChance[3] = settings.lineBreak4;
            iceFishing.m_ReduceFishingTimePercent[3] = settings.fishingTime4;

            iceFishing.m_IncreaseFishWeightPercent[4] = settings.fishWeight5;
            iceFishing.m_LineBreakOnCatchChance[4] = settings.lineBreak5;
            iceFishing.m_ReduceFishingTimePercent[4] = settings.fishingTime5;


            Skill IceFishing = __instance.GetSkill(SkillType.IceFishing);

            if (IceFishing != null)
            {
                IceFishing.m_TierPoints[1] = settings.fishTier2;
                IceFishing.m_TierPoints[2] = settings.fishTier3;
                IceFishing.m_TierPoints[3] = settings.fishTier4;
                IceFishing.m_TierPoints[4] = settings.fishTier5;
            }
        }
    }


    [HarmonyPatch(typeof(Skill_IceFishing), nameof(Skill_IceFishing.GetTierBenefits))]
    public static class IceFishingBenefits
    {
        static void Postfix(int index, ref string __result, Skill_IceFishing __instance)
        {
            if (index < 0 || index > 4)
                return;

            var s = Settings.settings;
            var sb = new StringBuilder();

            if (index == 0 && !string.IsNullOrEmpty(__result))
            {
                sb.Append(__result.TrimEnd());
            }

            int[] fishWeight =
            {
                s.fishWeight1, s.fishWeight2, s.fishWeight3, s.fishWeight4, s.fishWeight5
            };

            int[] lineBreak =
            {
                s.lineBreak1, s.lineBreak2, s.lineBreak3, s.lineBreak4, s.lineBreak5
            };

            int[] fishingTime =
            {
                s.fishingTime1, s.fishingTime2, s.fishingTime3, s.fishingTime4, s.fishingTime5
            };

            AppendBenefit(sb, fishWeight[index], "{0}% to average fish weight");
            AppendBenefit(sb, lineBreak[index], "{0}% chance of line break on catch");
            AppendBenefit(sb, fishingTime[index], "Fishing time reduced by {0}%");

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
