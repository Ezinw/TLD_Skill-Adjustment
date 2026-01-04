using Il2Cpp;
using HarmonyLib;
using System.Text;

namespace SkillAdjustment
{
    [HarmonyPatch(typeof(SkillsManager), nameof(SkillsManager.Awake))]
    internal class FirestartingAdjustment
    {
        public static void Postfix(SkillsManager __instance)
        {
            var settings = Settings.settings;
            var fireStarting = __instance.m_Skill_Firestarting;

            fireStarting.m_LevelWhereTinderNotRequired = settings.tinderLevelRequirement;

            fireStarting.m_BaseSuccessChance[0] = settings.fireBaseChance1;
            fireStarting.m_DurationPercentIncrease[0] = settings.fireDurationBonus1;
            fireStarting.m_StartPercentIncrease[0] = settings.quickerFireStarting1;

            fireStarting.m_BaseSuccessChance[1] = settings.fireBaseChance2;
            fireStarting.m_DurationPercentIncrease[1] = settings.fireDurationBonus2;
            fireStarting.m_StartPercentIncrease[1] = settings.quickerFireStarting2;

            fireStarting.m_BaseSuccessChance[2] = settings.fireBaseChance3;
            fireStarting.m_DurationPercentIncrease[2] = settings.fireDurationBonus3;
            fireStarting.m_StartPercentIncrease[2] = settings.quickerFireStarting3;

            fireStarting.m_BaseSuccessChance[3] = settings.fireBaseChance4;
            fireStarting.m_DurationPercentIncrease[3] = settings.fireDurationBonus4;
            fireStarting.m_StartPercentIncrease[3] = settings.quickerFireStarting4;

            fireStarting.m_BaseSuccessChance[4] = settings.fireBaseChance5;
            fireStarting.m_DurationPercentIncrease[4] = settings.fireDurationBonus5;
            fireStarting.m_StartPercentIncrease[4] = settings.quickerFireStarting5;


            Skill firestarting = __instance.GetSkill(SkillType.Firestarting);

            if (firestarting != null)
            {
                firestarting.m_TierPoints[1] = settings.fireTier2;
                firestarting.m_TierPoints[2] = settings.fireTier3;
                firestarting.m_TierPoints[3] = settings.fireTier4;
                firestarting.m_TierPoints[4] = settings.fireTier5;
            }
        }
    }

    [HarmonyPatch(typeof(Skill_Firestarting), nameof(Skill_Firestarting.GetTierBenefits))]
    public static class FirestartingBenefits
    {
        static void Postfix(int index, ref string __result, Skill_Firestarting __instance)
        {
            if (index < 0 || index > 4)
                return;

            var s = Settings.settings;
            var sb = new StringBuilder();

            int[] baseChance =
            {
                s.fireBaseChance1, s.fireBaseChance2, s.fireBaseChance3, s.fireBaseChance4 ,s.fireBaseChance5
            };

            int[] durationBonus =
            {
                s.fireDurationBonus1, s.fireDurationBonus2, s.fireDurationBonus3, s.fireDurationBonus4, s.fireDurationBonus5
            };

            int[] fasterStart =
            {
                s.quickerFireStarting1, s.quickerFireStarting2, s.quickerFireStarting3, s.quickerFireStarting4, s.quickerFireStarting5
            };

            AppendBenefit(sb, baseChance[index], "{0}% chance to start fires");
            AppendBenefit(sb, durationBonus[index], "Fires last {0}% longer");
            AppendBenefit(sb, fasterStart[index], "Fires start {0}% faster");

            if (UnlocksTinder(index, s.tinderLevelRequirement))
            {
                AppendRaw(sb, "Can start fires without tinder");
            }

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

        private static void AppendRaw(StringBuilder sb, string text)
        {
            if (sb.Length > 0)
                sb.Append('\n');

            sb.Append(text);
        }

        private static bool UnlocksTinder(int tierIndex, int tinderLevelRequirement)
        {
            if (tinderLevelRequirement <= 0 || tinderLevelRequirement > 5)
                return false;

            int tierNumber = tierIndex + 1;
            return tierNumber >= tinderLevelRequirement;
        }
    }
}
