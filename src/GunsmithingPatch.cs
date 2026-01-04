using Il2Cpp;
using HarmonyLib;
using System.Text;

namespace SkillAdjustment
{
    [HarmonyPatch(typeof(Skill_Gunsmithing), nameof(Skill_Gunsmithing.GetCurrentTier))]
    internal class GunsmithingAdjustment
    {
        public static void Postfix(ref Skill_Gunsmithing.SkillTier __result, Skill_Gunsmithing __instance)
        {
            int currentTier = __instance.GetCurrentTierNumber();
            var settings = Settings.settings;

            if (currentTier == 0)
            {
                __result.m_CraftedAmmoCondition = settings.ammoCraft1;
                __result.m_HarvestAmmoSuccessChance = settings.ammoHarvest1;
                __result.m_MillingRepairSuccessChance = settings.repairChance1;
                __result.m_MillingRepairCondition = settings.repairCon1;
            }

            if (currentTier == 1)
            {
                __result.m_CraftedAmmoCondition = settings.ammoCraft2;
                __result.m_HarvestAmmoSuccessChance = settings.ammoHarvest2;
                __result.m_MillingRepairSuccessChance = settings.repairChance2;
                __result.m_MillingRepairCondition = settings.repairCon2;
            }

            if (currentTier == 2)
            {
                __result.m_CraftedAmmoCondition = settings.ammoCraft3;
                __result.m_HarvestAmmoSuccessChance = settings.ammoHarvest3;
                __result.m_MillingRepairSuccessChance = settings.repairChance3;
                __result.m_MillingRepairCondition = settings.repairCon3;
            }

            if (currentTier == 3)
            {
                __result.m_CraftedAmmoCondition = settings.ammoCraft4;
                __result.m_HarvestAmmoSuccessChance = settings.ammoHarvest4;
                __result.m_MillingRepairSuccessChance = settings.repairChance4;
                __result.m_MillingRepairCondition = settings.repairCon4;
            }

            if (currentTier == 4)
            {
                __result.m_CraftedAmmoCondition = settings.ammoCraft5;
                __result.m_HarvestAmmoSuccessChance = settings.ammoHarvest5;
                __result.m_MillingRepairSuccessChance = settings.repairChance5;
                __result.m_MillingRepairCondition = settings.repairCon5;
            }
        }
    }


    [HarmonyPatch(typeof(SkillsManager), nameof(SkillsManager.Awake))]
    internal class GunsmithingTierAdjustment
    {
        public static void Postfix(SkillsManager __instance)
        {
            Skill Gunsmithing = __instance.GetSkill(SkillType.Gunsmithing);

            if (Gunsmithing != null)
            {
                Gunsmithing.m_TierPoints[1] = Settings.settings.smithTier2;
                Gunsmithing.m_TierPoints[2] = Settings.settings.smithTier3;
                Gunsmithing.m_TierPoints[3] = Settings.settings.smithTier4;
                Gunsmithing.m_TierPoints[4] = Settings.settings.smithTier5;
            }
        }
    }


    [HarmonyPatch(typeof(Skill_Gunsmithing), nameof(Skill_Gunsmithing.GetTierBenefits))]
    public static class GunsmithingBenefits
    {
        static void Postfix(int index, ref string __result, Skill_Gunsmithing __instance)
        {
            if (index < 0 || index > 4)
                return;

            var s = Settings.settings;
            var sb = new StringBuilder();

            int[] repairSuccessText =
            {
                s.repairCon1 ,s.repairCon2, s.repairCon3, s.repairCon4, s.repairCon5
            };

            int[] repairConditionText =
            {
                s.repairChance1, s.repairChance2, s.repairChance3, s.repairChance4, s.repairChance5
            };

            int[] ammoCraftText =
            {
                s.ammoCraft1, s.ammoCraft2, s.ammoCraft3, s.ammoCraft4, s.ammoCraft5
            };

            int[] ammoHarvestText =
            {
                s.ammoHarvest1, s.ammoHarvest2, s.ammoHarvest3, s.ammoHarvest4, s.ammoHarvest5
            };

            AppendBenefit(sb, repairSuccessText[index], "{0}% bonus to milling repair success");
            AppendBenefit(sb, repairConditionText[index], "{0}% bonus milling repair condition");
            AppendBenefit(sb, ammoCraftText[index], "Crafted ammunition condition is {0}%");
            AppendBenefit(sb, ammoHarvestText[index], "{0}% chance of ammunition component harvesting");

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
