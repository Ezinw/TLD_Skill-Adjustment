using HarmonyLib;
using Il2Cpp;

namespace SkillAdjustment
{
    [HarmonyPatch(typeof(Skill_Gunsmithing), nameof(Skill_Gunsmithing.GetCurrentTier))]
    internal class GunsmithingAdjustment
    {
        public static void Postfix(ref Skill_Gunsmithing.SkillTier __result, Skill_Gunsmithing __instance)
        {
            int currentTier = __instance.GetCurrentTierNumber();

            if (currentTier == 0)
            {
                __result.m_CraftedAmmoCondition = Settings.settings.ammoCraft1;
                __result.m_HarvestAmmoSuccessChance = Settings.settings.ammoHarvest1;
                __result.m_MillingRepairSuccessChance = Settings.settings.repairChance1;
                __result.m_MillingRepairCondition = Settings.settings.repairCon1;
            }

            if (currentTier == 1)
            {
                __result.m_CraftedAmmoCondition = Settings.settings.ammoCraft2;
                __result.m_HarvestAmmoSuccessChance = Settings.settings.ammoHarvest2;
                __result.m_MillingRepairSuccessChance = Settings.settings.repairChance2;
                __result.m_MillingRepairCondition = Settings.settings.repairCon2;
            }

            if (currentTier == 2)
            {
                __result.m_CraftedAmmoCondition = Settings.settings.ammoCraft3;
                __result.m_HarvestAmmoSuccessChance = Settings.settings.ammoHarvest3;
                __result.m_MillingRepairSuccessChance = Settings.settings.repairChance3;
                __result.m_MillingRepairCondition = Settings.settings.repairCon3;
            }

            if (currentTier == 3)
            {
                __result.m_CraftedAmmoCondition = Settings.settings.ammoCraft4;
                __result.m_HarvestAmmoSuccessChance = Settings.settings.ammoHarvest4;
                __result.m_MillingRepairSuccessChance = Settings.settings.repairChance4;
                __result.m_MillingRepairCondition = Settings.settings.repairCon4;
            }

            if (currentTier == 4)
            {
                __result.m_CraftedAmmoCondition = Settings.settings.ammoCraft5;
                __result.m_HarvestAmmoSuccessChance = Settings.settings.ammoHarvest5;
                __result.m_MillingRepairSuccessChance = Settings.settings.repairChance5;
                __result.m_MillingRepairCondition = Settings.settings.repairCon5;
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
    public class GunsmithingBenefits
    {

        static void Postfix(ref string __result, Skill_Gunsmithing __instance)
        {
            SkillTiers currentTier = (SkillTiers)__instance.GetCurrentTierNumber();

            //lvl 1
            if (currentTier == SkillTiers.Beginner && Settings.settings.repairCon1 >= 1) { __result += $"\n{Settings.settings.repairCon1}% bonus to milling repair success"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.repairChance1 >= 1) { __result += $"\n{Settings.settings.repairChance1}% bonus milling repair condition"; }

            if (currentTier == SkillTiers.Beginner && Settings.settings.ammoCraft1 >= 1)
            {
                {
                    List<string> resultList = __result.Split('\n').ToList();

                    resultList.RemoveAll(benefit => benefit.Contains("Crafted"));

                    resultList.Add($"Crafted ammunition condition is {Settings.settings.ammoCraft1}%");

                    string newResultString = string.Join("\n", resultList);
                    __result = newResultString;
                }

            }
            else if (currentTier == SkillTiers.Beginner && Settings.settings.ammoCraft1 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Crafted")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Beginner && Settings.settings.ammoHarvest1 >= 1)
            {
                {
                    List<string> resultList = __result.Split('\n').ToList();

                    resultList.RemoveAll(benefit => benefit.Contains("Chance"));

                    resultList.Add($"{Settings.settings.ammoHarvest1}% chance of ammunition component harvesting%");

                    string newResultString = string.Join("\n", resultList);
                    __result = newResultString;
                }

            }
            else if (currentTier == SkillTiers.Beginner && Settings.settings.ammoHarvest1 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Chance")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }


            //lvl 2
            if (currentTier == SkillTiers.Novice && Settings.settings.repairCon2 >= 1) { __result += $"\n{Settings.settings.repairCon2}% bonus to milling repair success"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.repairChance2 >= 1) { __result += $"\n{Settings.settings.repairChance2}% bonus to milling repair condition"; }

            if (currentTier == SkillTiers.Novice && Settings.settings.ammoCraft2 >= 1)
            {
                {
                    List<string> resultList = __result.Split('\n').ToList();

                    resultList.RemoveAll(benefit => benefit.Contains("Crafted"));

                    resultList.Add($"Crafted ammunition condition is {Settings.settings.ammoCraft2}%");

                    string newResultString = string.Join("\n", resultList);
                    __result = newResultString;
                }

            }
            else if (currentTier == SkillTiers.Novice && Settings.settings.ammoCraft2 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Crafted")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Novice && Settings.settings.ammoHarvest2 >= 1)
            {
                {
                    List<string> resultList = __result.Split('\n').ToList();

                    resultList.RemoveAll(benefit => benefit.Contains("Chance"));

                    resultList.Add($"{Settings.settings.ammoHarvest2}% chance of ammunition component harvesting%");

                    string newResultString = string.Join("\n", resultList);
                    __result = newResultString;
                }

            }
            else if (currentTier == SkillTiers.Novice && Settings.settings.ammoHarvest2 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Chance")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }


            //lvl 3
            if (currentTier == SkillTiers.Skilled && Settings.settings.repairCon3 >= 1) { __result += $"\n{Settings.settings.repairCon3}% bonus to milling repair success"; }
            if (currentTier == SkillTiers.Skilled && Settings.settings.repairChance3 >= 1) { __result += $"\n{Settings.settings.repairChance3}% bonus milling repair condition"; }

            if (currentTier == SkillTiers.Skilled && Settings.settings.ammoCraft3 >= 1)
            {
                {
                    List<string> resultList = __result.Split('\n').ToList();

                    resultList.RemoveAll(benefit => benefit.Contains("Crafted"));

                    resultList.Add($"Crafted ammunition condition is {Settings.settings.ammoCraft3}%");

                    string newResultString = string.Join("\n", resultList);
                    __result = newResultString;
                }

            }
            else if (currentTier == SkillTiers.Skilled && Settings.settings.ammoCraft3 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Crafted")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Skilled && Settings.settings.ammoHarvest3 >= 1)
            {
                {
                    List<string> resultList = __result.Split('\n').ToList();

                    resultList.RemoveAll(benefit => benefit.Contains("Chance"));

                    resultList.Add($"{Settings.settings.ammoHarvest3}% chance of ammunition component harvesting%");

                    string newResultString = string.Join("\n", resultList);
                    __result = newResultString;
                }

            }
            else if (currentTier == SkillTiers.Skilled && Settings.settings.ammoHarvest3 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Chance")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }


            //lvl 4
            if (currentTier == SkillTiers.Expert && Settings.settings.repairCon4 >= 1) { __result += $"\n{Settings.settings.repairCon4}% bonus to milling repair success"; }
            if (currentTier == SkillTiers.Expert && Settings.settings.repairChance4 >= 1) { __result += $"\n{Settings.settings.repairChance4}% bonus milling repair condition"; }

            if (currentTier == SkillTiers.Expert && Settings.settings.ammoCraft4 >= 1)
            {
                {
                    List<string> resultList = __result.Split('\n').ToList();

                    resultList.RemoveAll(benefit => benefit.Contains("Crafted"));

                    resultList.Add($"Crafted ammunition condition is {Settings.settings.ammoCraft4}%");

                    string newResultString = string.Join("\n", resultList);
                    __result = newResultString;
                }

            }
            else if (currentTier == SkillTiers.Expert && Settings.settings.ammoCraft4 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Crafted")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Expert && Settings.settings.ammoHarvest4 >= 1)
            {
                {
                    List<string> resultList = __result.Split('\n').ToList();

                    resultList.RemoveAll(benefit => benefit.Contains("Chance"));

                    resultList.Add($"{Settings.settings.ammoHarvest4}% chance of ammunition component harvesting%");

                    string newResultString = string.Join("\n", resultList);
                    __result = newResultString;
                }

            }
            else if (currentTier == SkillTiers.Expert && Settings.settings.ammoHarvest4 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Chance")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }


            //lvl 5
            if (currentTier == SkillTiers.Master && Settings.settings.repairCon5 >= 1) { __result += $"\n{Settings.settings.repairCon5}% bonus to milling repair success"; }
            if (currentTier == SkillTiers.Master && Settings.settings.repairChance5 >= 1) { __result += $"\n{Settings.settings.repairChance5}% bonus milling repair condition"; }

            if (currentTier == SkillTiers.Master && Settings.settings.ammoCraft5 >= 1)
            {
                {
                    List<string> resultList = __result.Split('\n').ToList();

                    resultList.RemoveAll(benefit => benefit.Contains("Crafted"));

                    resultList.Add($"Crafted ammunition condition is {Settings.settings.ammoCraft5}%");

                    string newResultString = string.Join("\n", resultList);
                    __result = newResultString;
                }

            }
            else if (currentTier == SkillTiers.Master && Settings.settings.ammoCraft5 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Crafted")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }

            if (currentTier == SkillTiers.Master && Settings.settings.ammoHarvest5 >= 1)
            {
                {
                    List<string> resultList = __result.Split('\n').ToList();

                    resultList.RemoveAll(benefit => benefit.Contains("Chance"));

                    resultList.Add($"{Settings.settings.ammoHarvest5}% chance of ammunition component harvesting%");

                    string newResultString = string.Join("\n", resultList);
                    __result = newResultString;
                }

            }
            else if (currentTier == SkillTiers.Master && Settings.settings.ammoHarvest5 == 0)
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Chance")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }



        }

    }


}




