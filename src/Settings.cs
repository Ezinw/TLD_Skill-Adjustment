using ModSettings;
using System.Reflection;

namespace SkillAdjustment
{
    internal class Settings : JsonModSettings
    {
        [Section("Archery")]

        [Name("Archery Skills")]
        [Description("Show or hide Archery Skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool archery = false;

        [Name("Fire Bow While Crouched")]
        [Description("Skill level required to fire bow while crouched. (Game default = 5) - Requires game reload to take effect")]
        [Slider(1, 5)]
        public int CrouchLevel = 5;

        [Name("Archery Level 1 ------------------------------")]
        [Description("Show or hide level 1 skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool archery1 = false;

        [Name("         - Bow Sway Reduction")]
        [Description("Reduce bow sway. (Game default = 0%)")]
        [Slider(0, 100)]
        public int bowSway1 = 0;

        [Name("         - Damage Increase")]
        [Description("Increase Damage. (Game default = 0%)")]
        [Slider(0, 200)]
        public int bowDamage1 = 0;

        [Name("         - Critical Hit Chance")]
        [Description("Increase critical hit chance. (Game default = 0%)")]
        [Slider(0, 100)]
        public int bowCritical1 = 0;

        [Name("         - Bleed Out Time Reduction")]
        [Description("Reduce the time for animals to bleed out. (Game default = 0%)")]
        [Slider(0, 100)]
        public int bowBleedOut1 = 0;

        [Name("         - Condition loss")]
        [Description("Reduce the amount of condition loss each use. (Game default = 0%)")]
        [Slider(0, 100)]
        public int bowPerUseConditionLoss1 = 0;

        [Name("Archery Level 2 ------------------------------")]
        [Description("Show or hide level 2 skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool archery2 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 15)")]
        [Slider(15, 500)]
        public int archeryTier2 = 15;

        [Name("         - Bow Sway Reduction")]
        [Description("Reduce bow sway. (Game default = 25%)")]
        [Slider(0, 100)]
        public int bowSway2 = 25;

        [Name("         - Damage Increase")]
        [Description("Increase Damage. (Game default = 10%)")]
        [Slider(0, 200)]
        public int bowDamage2 = 10;

        [Name("         - Critical Hit Chance")]
        [Description("Increase critical hit chance. (Game default = 0%)")]
        [Slider(0, 100)]
        public int bowCritical2 = 0;

        [Name("         - Bleed Out Time Reduction")]
        [Description("Reduce the time for animals to bleed out. (Game default = 0%)")]
        [Slider(0, 100)]
        public int bowBleedOut2 = 0;

        [Name("         - Condition loss")]
        [Description("Reduce the amount of condition loss each use. (Game default = 0%)")]
        [Slider(0, 100)]
        public int bowPerUseConditionLoss2 = 0;

        [Name("Archery Level 3 ------------------------------")]
        [Description("Show or hide level 3 skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool archery3 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 40)")]
        [Slider(40, 500)]
        public int archeryTier3 = 40;

        [Name("         - Bow Sway Reduction")]
        [Description("Reduce bow sway. (Game default = 50%)")]
        [Slider(0, 100)]
        public int bowSway3 = 50;

        [Name("         - Damage Increase")]
        [Description("Increase Damage. (Game default = 10%)")]
        [Slider(0, 200)]
        public int bowDamage3 = 10;

        [Name("         - Critical Hit Chance")]
        [Description("Increase critical hit chance. (Game default = 15%)")]
        [Slider(0, 100)]
        public int bowCritical3 = 15;

        [Name("         - Bleed Out Time Reduction")]
        [Description("Reduce the time for animals to bleed out. (Game default = 0%)")]
        [Slider(0, 100)]
        public int bowBleedOut3 = 0;

        [Name("         - Condition loss")]
        [Description("Reduce the amount of condition loss each use. (Game default = 0%)")]
        [Slider(0, 100)]
        public int bowPerUseConditionLoss3 = 0;

        [Name("Archery Level 4 ------------------------------")]
        [Description("Show or hide level 4 skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool archery4 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 75)")]
        [Slider(75, 500)]
        public int archeryTier4 = 75;

        [Name("         - Bow Sway Reduction")]
        [Description("Reduce bow sway. (Game default = 75%)")]
        [Slider(0, 100)]
        public int bowSway4 = 75;

        [Name("         - Damage Increase")]
        [Description("Increase Damage. (Game Default = 10%)")]
        [Slider(0, 200)]
        public int bowDamage4 = 10;

        [Name("         - Critical Hit Chance")]
        [Description("Increase critical hit chance. (Game default = 25%)")]
        [Slider(0, 100)]
        public int bowCritical4 = 25;

        [Name("         - Bleed Out Time Reduction")]
        [Description("Reduce the time for animals to bleed out. (Game default = 25%)")]
        [Slider(0, 100)]
        public int bowBleedOut4 = 25;

        [Name("         - Condition loss")]
        [Description("Reduce the amount of condition loss each use. (Game default = 50%)")]
        [Slider(0, 100)]
        public int bowPerUseConditionLoss4 = 50;

        [Name("Archery Level 5 ------------------------------")]
        [Description("Show or hide level 5 skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool archery5 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 125)")]
        [Slider(125, 625)]
        public int archeryTier5 = 125;

        [Name("         - Bow Sway Reduction")]
        [Description("Reduce bow sway. (Game default = 75%)")]
        [Slider(0, 100)]
        public int bowSway5 = 75;

        [Name("         - Damage Increase")]
        [Description("Increase Damage. (Game default = 25%)")]
        [Slider(0, 200)]
        public int bowDamage5 = 25;

        [Name("         - Critical Hit Chance")]
        [Description("=Increase critical hit chance. (Game default = 50%)")]
        [Slider(0, 100)]
        public int bowCritical5 = 50;

        [Name("         - Bleed Out Time Reduction")]
        [Description("Reduce the time for animals to bleed out. (Game default = 50%)")]
        [Slider(0, 100)]
        public int bowBleedOut5 = 50;

        [Name("         - Condition loss")]
        [Description("Reduce the amount of condition loss each use. (Game default = 50%)")]
        [Slider(0, 100)]
        public int bowPerUseConditionLoss5 = 50;


        // |----------------------------------------- Revolver ------------------------------------------------|

        [Section("Revolver")]

        [Name("Revolver Skills")]
        [Description("Show or hide Revolver Skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool revolver = false;


        //lvl 1
        [Name("Revolver Level 1 ------------------------------")]
        [Description("Show or hide level 1 skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool revolver1 = false;

        [Name("         - Condition loss on use")]
        [Description("Reduce condition loss after use.(Game default = 0%)")]
        [Slider(0, 100)]
        public int revolverDegradeOnUse1 = 0;

        [Name("         - Aim Assist")]
        [Description("Set aim assist angle degrees.(Game default = 0)")]
        [Slider(0, 100)]
        public int revolverAim1 = 0;

        [Name("         - Recoil Compensation")]
        [Description("Increase recoil compensation.(Game default = 0%)")]
        [Slider(0, 100)]
        public int revolverRecoil1 = 0;

        [Name("         - Struggle bonus")]
        [Description("Increase struggle effectiveness.(Game default = 0%)")]
        [Slider(0, 200)]
        public int revolverStruggleBonus1 = 0;

        [Name("         - Condition repair bonus")]
        [Description("Increase amount of condition recieved from repair.(Game default = 0)")]
        [Slider(0, 100)]
        public int revolverRepairBonus1 = 0;

        [Name("         - Damage bonus")]
        [Description("Increase Damage.(Game default = 0%)")]
        [Slider(0, 200)]
        public int revolverDamage1 = 0;

        [Name("         - Critcal hit bonus")]
        [Description("Increase critical hits.(Game default = 0%)")]
        [Slider(0, 100)]
        public int revolverCritical1 = 0;


        //lvl 2
        [Name("Revolver Level 2 ------------------------------")]
        [Description("Show or hide level 2 skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool revolver2 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 10)")]
        [Slider(10, 500)]
        public int revolverTier2 = 10;

        [Name("         - Condition loss on use")]
        [Description("Reduce condition loss after use.(Game default = 0%)")]
        [Slider(0, 100)]
        public int revolverDegradeOnUse2 = 0;

        [Name("         - Aim Assist")]
        [Description("Set aim assist angle degrees.(Game default = 0)")]
        [Slider(0, 100)]
        public int revolverAim2 = 0;

        [Name("         - Recoil Compensation")]
        [Description("Increase recoil compensation.(Game default = 25%)")]
        [Slider(0, 100)]
        public int revolverRecoil2 = 25;

        [Name("         - Struggle bonus")]
        [Description("Increase struggle effectiveness.(Game default = 0%)")]
        [Slider(0, 200)]
        public int revolverStruggleBonus2 = 0;

        [Name("         - Condition repair bonus")]
        [Description("Increase amount of condition recieved from repair.(Game default = +2)")]
        [Slider(0, 100)]
        public int revolverRepairBonus2 = 2;

        [Name("         - Damage bonus")]
        [Description("Increase Damage.(Game default = 0%)")]
        [Slider(0, 200)]
        public int revolverDamage2 = 0;

        [Name("         - Critcal hit bonus")]
        [Description("Increase critical hits.(Game default = 0%)")]
        [Slider(0, 100)]
        public int revolverCritical2 = 0;


        //lvl 3
        [Name("Revolver Level 3 ------------------------------")]
        [Description("Show or hide level 3 skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool revolver3 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 25)")]
        [Slider(25, 500)]
        public int revolverTier3 = 25;

        [Name("         - Condition loss on use")]
        [Description("Reduce condition loss after use.(Game default = 0%)")]
        [Slider(0, 100)]
        public int revolverDegradeOnUse3 = 0;

        [Name("         - Aim Assist")]
        [Description("Set aim assist angle degrees.(Game default = 0)")]
        [Slider(0, 100)]
        public int revolverAim3 = 0;

        [Name("         - Recoil Compensation")]
        [Description("Increase recoil compensation.(Game default = 35%)")]
        [Slider(0, 100)]
        public int revolverRecoil3 = 35;

        [Name("         - Struggle bonus")]
        [Description("Increase struggle effectiveness.(Game default = 10%)")]
        [Slider(0, 200)]
        public int revolverStruggleBonus3 = 10;

        [Name("         - Condition repair bonus")]
        [Description("Increase amount of condition recieved from repair.(Game default = +3)")]
        [Slider(0, 100)]
        public int revolverRepairBonus3 = 3;

        [Name("         - Damage bonus")]
        [Description("Increase Damage.(Game default = 0%)")]
        [Slider(0, 200)]
        public int revolverDamage3 = 0;

        [Name("         - Critcal hit bonus")]
        [Description("Increase critical hits.(Game default = 0%)")]
        [Slider(0, 100)]
        public int revolverCritical3 = 0;


        //lvl 4
        [Name("Revolver Level 4 ------------------------------")]
        [Description("Show or hide level 4 skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool revolver4 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 50)")]
        [Slider(50, 500)]
        public int revolverTier4 = 50;

        [Name("         - Condition loss on use")]
        [Description("Reduce condition loss after use.(Game default = 0%)")]
        [Slider(0, 100)]
        public int revolverDegradeOnUse4 = 0;

        [Name("         - Aim Assist")]
        [Description("Set aim assist angle degrees.(Game default = 25)")]
        [Slider(0, 100)]
        public int revolverAim4 = 25;

        [Name("         - Recoil Compensation")]
        [Description("Increase recoil compensation.(Game default = 50%)")]
        [Slider(0, 100)]
        public int revolverRecoil4 = 50;

        [Name("         - Struggle bonus")]
        [Description("Increase struggle effectiveness.(Game default = 20%)")]
        [Slider(0, 200)]
        public int revolverStruggleBonus4 = 20;

        [Name("         - Condition repair bonus")]
        [Description("Increase amount of condition recieved from repair.(Game default = +4)")]
        [Slider(0, 100)]
        public int revolverRepairBonus4 = 4;

        [Name("         - Damage bonus")]
        [Description("Increase Damage.(Game default = 0%)")]
        [Slider(0, 200)]
        public int revolverDamage4 = 0;

        [Name("         - Critcal hit bonus")]
        [Description("Increase critical hits.(Game default = 0%)")]
        [Slider(0, 100)]
        public int revolverCritical4 = 0;


        //lvl 5
        [Name("Revolver Level 5 ------------------------------")]
        [Description("Show or hide level 5 skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool revolver5 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 100)")]
        [Slider(100, 500)]
        public int revolverTier5 = 100;

        [Name("         - Condition loss on use")]
        [Description("Reduce condition loss after use.(Game default = 50%)")]
        [Slider(0, 100)]
        public int revolverDegradeOnUse5 = 50;

        [Name("         - Aim Assist")]
        [Description("Set aim assist angle degrees.(Game default = 50)")]
        [Slider(0, 100)]
        public int revolverAim5 = 50;

        [Name("         - Recoil Compensation")]
        [Description("Increase recoil compensation.(Game default = 70%)")]
        [Slider(0, 100)]
        public int revolverRecoil5 = 70;

        [Name("         - Struggle bonus")]
        [Description("Increase struggle effectiveness.(Game default = 30%)")]
        [Slider(0, 200)]
        public int revolverStruggleBonus5 = 30;

        [Name("         - Condition repair bonus")]
        [Description("Increase amount of condition recieved from repair.(Game default = +5)")]
        [Slider(0, 100)]
        public int revolverRepairBonus5 = 5;

        [Name("         - Damage bonus")]
        [Description("Increase Damage.(Game default = 0%)")]
        [Slider(0, 200)]
        public int revolverDamage5 = 0;

        [Name("         - Critcal hit bonus")]
        [Description("Increase critical hits.(Game default = 0%)")]
        [Slider(0, 100)]
        public int revolverCritical5 = 0;


        // |----------------------------------------- Rifle ------------------------------------------------|

        [Section("Rifle")]

        [Name("Rifle Skills")]
        [Description("Show or hide Rifle Skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool rifle = false;

        //lvl 1
        [Name("Rifle Level 1 ------------------------------")]
        [Description("Show or hide level 1 skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool rifle1 = false;

        [Name("         - Critical Hit Bonus")]
        [Description("Critical Hit chance.(Game default = 0%)")]
        [Slider(0, 100)]
        public int rifleCritical1 = 0;

        [Name("         - Repair Bonus")]
        [Description("Increase amount of condition recieved from repair.(Game default = 0%)")]
        [Slider(0, 100)]
        public int rifleRepairBonus1 = 0;

        [Name("         - Accuracy")]
        [Description("Bonus to Accuracy .(Game default = 0%)")]
        [Slider(0, 100)]
        public int rifleAccuracyRange1 = 0;

        [Name("         - Damage Bonus")]
        [Description("Increase damage.(Game default = 0%)")]
        [Slider(0, 200)]
        public int rifleDamage1 = 0;

        [Name("         - Condition Loss")]
        [Description("Rifle condition decays slower per use..(Game default = 0%)")]
        [Slider(0, 100)]
        public int rifleLessDegradeOnUse1 = 0;

        [Name("         - Aim assist")]
        [Description("Increase aim assist.(Game default = 0.0)")]
        [Slider(0.00f, 1.00f, NumberFormat = "{0:#.00}")]
        public float rifleAimAssist1 = 0.00f;

        [Name("         - Effective range")]
        [Description("Increase effective range.(Game default = 75)")]
        [Slider(75, 350)]
        public int rifleEffectiveRange1 = 75;

        [Name("         - Stability bonus")]
        [Description("Increase stability.(Game default = 0)")]
        [Slider(0, 100)]
        public int rifleStabilityBonus1 = 0;


        //lvl 2
        [Name("Rifle Level 2 ------------------------------")]
        [Description("Show or hide level 2 skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool rifle2 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 10)")]
        [Slider(10, 500)]
        public int rifleTier2 = 10;

        [Name("         - Critical Hit Bonus")]
        [Description("Critical Hit chance.(Game default = 10%)")]
        [Slider(0, 100)]
        public int rifleCritical2 = 10;

        [Name("         - Repair Bonus")]
        [Description("Increase amount of condition recieved from repair.(Game default = 2%)")]
        [Slider(0, 100)]
        public int rifleRepairBonus2 = 2;

        [Name("         - Accuracy")]
        [Description("Bonus to Accuracy .(Game default = 0%)")]
        [Slider(0, 100)]
        public int rifleAccuracyRange2 = 0;

        [Name("         - Damage Bonus")]
        [Description("Increase damage.(Game default = 0%)")]
        [Slider(0, 200)]
        public int rifleDamage2 = 0;

        [Name("         - Condition Loss")]
        [Description("Rifle condition decays slower per use..(Game default = 0%)")]
        [Slider(0, 100)]
        public int rifleLessDegradeOnUse2 = 0;

        [Name("         - Aim assist")]
        [Description("Increase aim assist.(Game default = 0.2)")]
        [Slider(0.00f, 1.00f, NumberFormat = "{0:#.00}")]
        public float rifleAimAssist2 = 0.20f;

        [Name("         - Effective range")]
        [Description("Increase effective range.(Game default = 90)")]
        [Slider(0, 350)]
        public int rifleEffectiveRange2 = 90;

        [Name("         - Stability bonus")]
        [Description("Increase stability.(Game default = 10)")]
        [Slider(0, 100)]
        public int rifleStabilityBonus2 = 10;


        //lvl 3
        [Name("Rifle Level 3 ------------------------------")]
        [Description("Show or hide level 3 skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool rifle3 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 25)")]
        [Slider(25, 500)]
        public int rifleTier3 = 25;

        [Name("         - Critical Hit Bonus")]
        [Description("Critical Hit chance.(Game default = 15%)")]
        [Slider(0, 100)]
        public int rifleCritical3 = 15;

        [Name("         - Repair Bonus")]
        [Description("Increase amount of condition recieved from repair.(Game default = 2%)")]
        [Slider(0, 100)]
        public int rifleRepairBonus3 = 2;

        [Name("         - Accuracy")]
        [Description("Bonus to Accuracy .(Game default = 20%)")]
        [Slider(0, 100)]
        public int rifleAccuracyRange3 = 20;

        [Name("         - Damage Bonus")]
        [Description("Increase damage.(Game default = 0%)")]
        [Slider(0, 200)]
        public int rifleDamage3 = 0;

        [Name("         - Condition Loss")]
        [Description("Rifle condition decays slower per use..(Game default = 0%)")]
        [Slider(0, 100)]
        public int rifleLessDegradeOnUse3 = 0;

        [Name("         - Aim assist")]
        [Description("Increase aim assist.(Game default = 0.35)")]
        [Slider(0.00f, 1.00f, NumberFormat = "{0:#.00}")]
        public float rifleAimAssist3 = 0.35f;

        [Name("         - Effective range")]
        [Description("Increase effective range.(Game default = 110)")]
        [Slider(0, 350)]
        public int rifleEffectiveRange3 = 110;

        [Name("         - Stability bonus")]
        [Description("Increase stability.(Game default = 20)")]
        [Slider(0, 100)]
        public int rifleStabilityBonus3 = 20;


        //lvl 4
        [Name("Rifle Level 4 ------------------------------")]
        [Description("Show or hide level 4 skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool rifle4 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 50)")]
        [Slider(50, 500)]
        public int rifleTier4 = 50;

        [Name("         - Critical Hit Bonus")]
        [Description("Critical Hit chance.(Game default = 20%)")]
        [Slider(0, 100)]
        public int rifleCritical4 = 20;

        [Name("         - Repair Bonus")]
        [Description("Increase amount of condition recieved from repair.(Game default = 2%)")]
        [Slider(0, 100)]
        public int rifleRepairBonus4 = 2;

        [Name("         - Accuracy")]
        [Description("Bonus to Accuracy .(Game default = 30%)")]
        [Slider(0, 100)]
        public int rifleAccuracyRange4 = 30;

        [Name("         - Damage Bonus")]
        [Description("Increase damage.(Game default = 10%)")]
        [Slider(0, 200)]
        public int rifleDamage4 = 10;

        [Name("         - Condition Loss")]
        [Description("Rifle condition decays slower per use..(Game default = 0%)")]
        [Slider(0, 100)]
        public int rifleLessDegradeOnUse4 = 0;

        [Name("         - Aim assist")]
        [Description("Increase aim assist.(Game default = 0.5)")]
        [Slider(0.00f, 1.00f, NumberFormat = "{0:#.00}")]
        public float rifleAimAssist4 = 0.50f;

        [Name("         - Effective range")]
        [Description("Increase effective range.(Game default = 150)")]
        [Slider(0, 350)]
        public int rifleEffectiveRange4 = 150;

        [Name("         - Stability bonus")]
        [Description("Increase stability.(Game default = 30)")]
        [Slider(0, 100)]
        public int rifleStabilityBonus4 = 30;


        //lvl 5
        [Name("Rifle Level 5 ------------------------------")]
        [Description("Show or hide level 5 skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool rifle5 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 100)")]
        [Slider(100, 500)]
        public int rifleTier5 = 100;

        [Name("         - Critical Hit Bonus")]
        [Description("Critical Hit chance.(Game default = 30%)")]
        [Slider(0, 100)]
        public int rifleCritical5 = 30;

        [Name("         - Repair Bonus")]
        [Description("Increase amount of condition recieved from repair.(Game default = 5%)")]
        [Slider(0, 100)]
        public int rifleRepairBonus5 = 5;

        [Name("         - Accuracy")]
        [Description("Bonus to Accuracy .(Game default = 30%)")]
        [Slider(0, 100)]
        public int rifleAccuracyRange5 = 30;

        [Name("         - Damage Bonus")]
        [Description("Increase damage.(Game default = 20%)")]
        [Slider(0, 200)]
        public int rifleDamage5 = 20;

        [Name("         - Condition Loss")]
        [Description("Rifle condition decays slower per use..(Game default = 50%)")]
        [Slider(0, 100)]
        public int rifleLessDegradeOnUse5 = 50;

        [Name("         - Aim assist")]
        [Description("Increase aim assist.(Game default = 0.6)")]
        [Slider(0.00f, 1.00f, NumberFormat = "{0:#.00}")]
        public float rifleAimAssist5 = 0.60f;

        [Name("         - Effective range")]
        [Description("Increase effective range.(Game default = 250)")]
        [Slider(0, 350)]
        public int rifleEffectiveRange5 = 250;

        [Name("         - Stability bonus")]
        [Description("Increase stability.(Game default = 50)")]
        [Slider(0, 100)]
        public int rifleStabilityBonus5 = 50;


        // |----------------------------------------- Firestarting ------------------------------------------------|

        [Section("Firestarting")]

        [Name("Firestarting Skills")]
        [Description("Show or hide Rifle Skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool fireStarting = false;

        //Tinder Requirement
        [Name("No Tinder Required")]
        [Description("Level when tinder is no longer required.(Game default = 3) (6 = Tinder is always required) - Requires game reload to take effect")]
        [Slider(1, 6)]
        public int tinderLevelRequirement = 3;

        //lvl1
        [Name("Fire Starting Level 1 ------------------------------")]
        [Description("Show or hide level 1 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool fireStarting1 = false;

        [Name("         - Bonus Fire Starting")]
        [Description("Increase % chance to start a fire.(Game default = 40%)")]
        [Slider(0, 100)]
        public int fireBaseChance1 = 40;

        [Name("         - Longer Lasting Fires")]
        [Description("Increase the % duration of fires.(Game default = 0%)")]
        [Slider(0, 200)]
        public int fireDurationBonus1 = 0;

        [Name("         - Quicker Fire Starting")]
        [Description("Quicker fire starting.(Game default = 0%)")]
        [Slider(0, 100)]
        public int quickerFireStarting1 = 0;

        //lvl2
        [Name("Fire Starting Level 2 ------------------------------")]
        [Description("Show or hide level 2 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool fireStarting2 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 20)")]
        [Slider(20, 500)]
        public int fireTier2 = 20;

        [Name("         - Bonus Fire Starting")]
        [Description("Increase % chance to start a fire.(Game default = 55%)")]
        [Slider(0, 100)]
        public int fireBaseChance2 = 55;

        [Name("         - Longer Lasting Fires")]
        [Description("Increase the % duration of fires.(Game default = 10%)")]
        [Slider(0, 200)]
        public int fireDurationBonus2 = 10;

        [Name("         - Quicker Fire Starting")]
        [Description("Quicker fire starting.(Game default = 0%)")]
        [Slider(0, 100)]
        public int quickerFireStarting2 = 0;

        //lvl3
        [Name("Fire Starting Level 3 ------------------------------")]
        [Description("Show or hide level 3 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool fireStarting3 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 50)")]
        [Slider(50, 500)]
        public int fireTier3 = 50;

        [Name("         - Bonus Fire Starting")]
        [Description("Increase % chance to start a fire.(Game default = 65%)")]
        [Slider(0, 100)]
        public int fireBaseChance3 = 65;

        [Name("         - Longer Lasting Fires")]
        [Description("Increase the % duration of fires.(Game default = 10%)")]
        [Slider(0, 200)]
        public int fireDurationBonus3 = 10;

        [Name("         - Quicker Fire Starting")]
        [Description("Quicker fire starting.(Game default = 0%)")]
        [Slider(0, 100)]
        public int quickerFireStarting3 = 0;

        //lvl4
        [Name("Fire Starting Level 4 ------------------------------")]
        [Description("Show or hide level 4 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool fireStarting4 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 100)")]
        [Slider(100, 1000)]
        public int fireTier4 = 100;

        [Name("         - Bonus Fire Starting")]
        [Description("Increase % chance to start a fire.(Game default = 75%)")]
        [Slider(0, 100)]
        public int fireBaseChance4 = 75;

        [Name("         - Longer Lasting Fires")]
        [Description("Increase the % duration of fires.(Game default = 25%)")]
        [Slider(0, 200)]
        public int fireDurationBonus4 = 25;

        [Name("         - Quicker Fire Starting")]
        [Description("Quicker fire starting.(Game default = 0%)")]
        [Slider(0, 100)]
        public int quickerFireStarting4 = 0;

        //lvl5
        [Name("Fire Starting Level 5 ------------------------------")]
        [Description("Show or hide level 5 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool fireStarting5 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 200)")]
        [Slider(200, 1000)]
        public int fireTier5 = 200;

        [Name("         - Bonus Fire Starting")]
        [Description("Increase % chance to start a fire.(Game default = 90%)")]
        [Slider(0, 100)]
        public int fireBaseChance5 = 90;

        [Name("         - Longer Lasting Fires")]
        [Description("Increase the % duration of fires.(Game default = 50%)")]
        [Slider(0, 200)]
        public int fireDurationBonus5 = 50;

        [Name("         - Quicker Fire Starting")]
        [Description("Quicker fire starting.(Game default = 50%)")]
        [Slider(0, 100)]
        public int quickerFireStarting5 = 50;


        // |----------------------------------------- Gunsmithing ------------------------------------------------|

        [Section("Gunsmithing")]

        [Name("Gunsmithing Skills")]
        [Description("Show or hide Gunsmithing Skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool gunSmith = false;

        //lvl1
        [Name("Gunsmithing Level 1 ------------------------------")]
        [Description("Show or hide level 1 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool gunSmith1 = false;

        [Name("          Ammunition crafting")]
        [Description("Set the condition of crafted ammunition.(Game default = 20%)")]
        [Slider(0, 100)]
        public int ammoCraft1 = 20;

        [Name("          Ammunition harvesting")]
        [Description("Chance to harvest ammunition components.(Game default = 50%)")]
        [Slider(0, 100)]
        public int ammoHarvest1 = 50;

        [Name("          Repair Condition")]
        [Description("Set the amount of condition gained at milling machines.(Game default = 40%)")]
        [Slider(0, 100)]
        public int repairCon1 = 40;

        [Name("          Repair success chance")]
        [Description("Set the chance of milling repair success.(Game default = 50%)")]
        [Slider(0, 100)]
        public int repairChance1 = 50;
        

        //lvl2
        [Name("Gunsmithing Level 2 ------------------------------")]
        [Description("Show or hide level 2 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool gunSmith2 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 15)")]
        [Slider(15, 1250)]
        public int smithTier2 = 15;

        [Name("          Ammunition crafting")]
        [Description("Set the condition of crafted ammunition.(Game default = 40%)")]
        [Slider(0, 100)]
        public int ammoCraft2 = 40;

        [Name("          Ammunition harvesting")]
        [Description("Chance to harvest ammunition components.(Game default = 60%)")]
        [Slider(0, 100)]
        public int ammoHarvest2 = 60;

        [Name("          Repair Condition")]
        [Description("Set the amount of condition gained at milling machines.(Game default = 60%)")]
        [Slider(0, 100)]
        public int repairCon2 = 60;

        [Name("          Repair success chance")]
        [Description("Set the chance of milling repair success.(Game default = 60%)")]
        [Slider(0, 100)]
        public int repairChance2 = 60;

        //lvl3
        [Name("Gunsmithing Level 3 ------------------------------")]
        [Description("Show or hide level 3 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool gunSmith3 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 30)")]
        [Slider(30, 1250)]
        public int smithTier3 = 30;

        [Name("          Ammunition crafting")]
        [Description("Set the condition of crafted ammunition.(Game default = 60%)")]
        [Slider(0, 100)]
        public int ammoCraft3 = 60;

        [Name("          Ammunition harvesting")]
        [Description("Chance to harvest ammunition components.(Game default = 70%)")]
        [Slider(0, 100)]
        public int ammoHarvest3 = 70;

        [Name("          Repair Condition")]
        [Description("Set the amount of condition gained at milling machines.(Game default = 80%)")]
        [Slider(0, 100)]
        public int repairCon3 = 80;

        [Name("          Repair success chance")]
        [Description("Set the chance of milling repair success.(Game default = 75%)")]
        [Slider(0, 100)]
        public int repairChance3 = 75;

        //lvl4
        [Name("Gunsmithing Level 4 ------------------------------")]
        [Description("Show or hide level 4 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool gunSmith4 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 50)")]
        [Slider(50, 1250)]
        public int smithTier4 = 50;
        
        [Name("          Ammunition crafting")]
        [Description("Set the condition of crafted ammunition.(Game default = 80%)")]
        [Slider(0, 100)]
        public int ammoCraft4 = 80;

        [Name("          Ammunition harvesting")]
        [Description("Chance to harvest ammunition components.(Game default = 80%)")]
        [Slider(0, 100)]
        public int ammoHarvest4 = 80;

        [Name("          Repair Condition")]
        [Description("Set the amount of condition gained at milling machines.(Game default = 90%)")]
        [Slider(0, 100)]
        public int repairCon4 = 90;

        [Name("          Repair success chance")]
        [Description("Set the chance of milling repair success.(Game default = 90%)")]
        [Slider(0, 100)]
        public int repairChance4 = 90;

        //lvl5
        [Name("Gunsmithing Level 5 ------------------------------")]
        [Description("Show or hide level 5 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool gunSmith5 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 100)")]
        [Slider(100, 1250)]
        public int smithTier5 = 100;

        [Name("          Ammunition crafting")]
        [Description("Set the condition of crafted ammunition.(Game default = 100%)")]
        [Slider(0, 100)]
        public int ammoCraft5 = 100;

        [Name("          Ammunition harvesting")]
        [Description("Chance to harvest ammunition components.(Game default = 100%)")]
        [Slider(0, 100)]
        public int ammoHarvest5 = 100;

        [Name("          Repair Condition")]
        [Description("Set the amount of condition gained at milling machines.(Game default = 100%)")]
        [Slider(0, 100)]
        public int repairCon5 = 100;

        [Name("          Repair success chance")]
        [Description("Set the chance of milling repair success.(Game default = 100%)")]
        [Slider(0, 100)]
        public int repairChance5 = 100;


        // |----------------------------------------- Mending ------------------------------------------------|

        [Section("Mending")]

        [Name("Mending Skills")]
        [Description("Show or hide Mending Skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool mending = false;

        //lvl1
        [Name("Mending Level 1 ------------------------------")]
        [Description("Show or hide level 1 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool mending1 = false;

        [Name("         - Success chance")]
        [Description("Set the base success chance for repairing clothing.(Game default = 50%)")]
        [Slider(0, 100)]
        public int mendingSuccessChance1 = 50;

        [Name("         - Bonus Condition")]
        [Description("Set the bonus percent increase from repairs.(Game default = 0%)")]
        [Slider(0, 200)]
        public int mendingConditionBonus1 = 0;

        [Name("         - Reduce repair time")]
        [Description("Decrease repair time.(Game default = 0%)")]
        [Slider(0, 99)]
        public int mendingRepairTimeReduced1 = 0;

        [Name("         - Sewing kit use")]
        [Description("Decrease the amount the sewing kit degrades per use.(Game default = 0%)")]
        [Slider(0, 100)]
        public int SewingKitDegradeDecrease1 = 0;

        //lvl2
        [Name("Mending Level 2 ------------------------------")]
        [Description("Show or hide level 2 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool mending2 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 25)")]
        [Slider(15, 1750)]
        public int mendTier2 = 25;

        [Name("         - Success chance")]
        [Description("Set the base success chance for repairing clothing.(Game default = 65%)")]
        [Slider(0, 100)]
        public int mendingSuccessChance2 = 65;

        [Name("         - Bonus Condition")]
        [Description("Set the bonus percent increase from repairs.(Game default = 0%)")]
        [Slider(0, 200)]
        public int mendingConditionBonus2 = 0;

        [Name("         - Reduce repair time")]
        [Description("Decrease repair time.(Game default = 10%)")]
        [Slider(0, 99)]
        public int mendingRepairTimeReduced2 = 10;

        [Name("         - Sewing kit use")]
        [Description("Decrease the amount the sewing kit degrades per use.(Game default = 0%)")]
        [Slider(0, 100)]
        public int SewingKitDegradeDecrease2 = 0;

        //lvl3
        [Name("Mending Level 3 ------------------------------")]
        [Description("Show or hide level 3 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool mending3 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 75)")]
        [Slider(15, 1750)]
        public int mendTier3 = 75;

        [Name("         - Success chance")]
        [Description("Set the base success chance for repairing clothing.(Game default = 75%)")]
        [Slider(0, 100)]
        public int mendingSuccessChance3 = 75;

        [Name("         - Bonus Condition")]
        [Description("Set the bonus percent increase from repairs.(Game default = 10%)")]
        [Slider(0, 200)]
        public int mendingConditionBonus3 = 10;

        [Name("         - Reduce repair time")]
        [Description("Decrease repair time.(Game default = 15%)")]
        [Slider(0, 99)]
        public int mendingRepairTimeReduced3 = 15;

        [Name("         - Sewing kit use")]
        [Description("Decrease the amount the sewing kit degrades per use.(Game default = 10%)")]
        [Slider(0, 100)]
        public int SewingKitDegradeDecrease3 = 10;

        //lvl4
        [Name("Mending Level 4 ------------------------------")]
        [Description("Show or hide level 4 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool mending4 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 150)")]
        [Slider(150, 1750)]
        public int mendTier4 = 150;

        [Name("         - Success chance")]
        [Description("Set the base success chance for repairing clothing.(Game default = 85%)")]
        [Slider(0, 100)]
        public int mendingSuccessChance4 = 85;

        [Name("         - Bonus Condition")]
        [Description("Set the bonus percent increase from repairs.(Game default = 15%)")]
        [Slider(0, 200)]
        public int mendingConditionBonus4 = 15;

        [Name("         - Reduce repair time")]
        [Description("Decrease repair time.(Game default = 25%)")]
        [Slider(0, 99)]
        public int mendingRepairTimeReduced4 = 25;

        [Name("         - Sewing kit use")]
        [Description("Decrease the amount the sewing kit degrades per use.(Game default = 25%)")]
        [Slider(0, 100)]
        public int SewingKitDegradeDecrease4 = 25;

        //lvl5
        [Name("Mending Level 5 ------------------------------")]
        [Description("Show or hide level 5 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool mending5 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 350)")]
        [Slider(350, 1750)]
        public int mendTier5 = 350;

        [Name("         - Success chance")]
        [Description("Set the base success chance for repairing clothing.(Game default = 100%)")]
        [Slider(0, 100)]
        public int mendingSuccessChance5 = 100;

        [Name("         - Bonus Condition")]
        [Description("Set the bonus percent increase from repairs.(Game default = 25%)")]
        [Slider(0, 200)]
        public int mendingConditionBonus5 = 25;

        [Name("         - Reduce repair time")]
        [Description("Decrease repair time.(Game default = 40%)")]
        [Slider(0, 99)]
        public int mendingRepairTimeReduced5 = 40;

        [Name("         - Sewing kit use")]
        [Description("Decrease the amount the sewing kit degrades per use.(Game default = 35%)")]
        [Slider(0, 100)]
        public int SewingKitDegradeDecrease5 = 35;


        // |----------------------------------------- Carcass Harvesting ------------------------------------------------|

        [Section("Carcass Harvesting")]

        [Name("Harvesting Skills")]
        [Description("Show or hide harvesting Skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool harvest = false;

        [Name("         - Harvest hours")]
        [Description("Set the hours spent harvesting needed to gain a skill point.(Game default = 1 hour)")]
        [Slider(0.25f, 12.00f, NumberFormat = "{0:#.00}")]
        public float harvestHoursForSkillPoint = 1.0f;

        /*[Name("         - Convert hours")]
        [Description("---.(Game default = 1 hour)")]
        [Slider(0.50f, 24.00f, NumberFormat = "{0:#.00}")]
        public float convertHours = 1.0f;*/

        //lvl1
        [Name("Carcass harvesting Level 1 ------------------------------")]
        [Description("Show or hide level 1 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool harvest1 = false;

        [Name("         - Frozen carcass harvesting")]
        [Description("How frozen a carcass can be to harvest with bare hands.(Game default = 50%)")]
        [Slider(0, 100)]
        public int harvestFrozen1 = 50;

        [Name("         - Meat harvesting")]
        [Description("Meat harvesting times reduced.(Game default = 0%)")]
        [Slider(0, 99)]
        public int meatHarvestTime1 = 0;

        [Name("         - Hide & gut harvesting")]
        [Description("Hide & gut harvesting time reduced.(Game default = 0%)")]
        [Slider(0, 99)]
        public int hideGutHarvestTime1 = 0;

        //lvl2
        [Name("Carcass harvesting Level 2 ------------------------------")]
        [Description("Show or hide level 2 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool harvest2 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 15)")]
        [Slider(15, 1250)]
        public int harvestTier2 = 15;

        [Name("         - Frozen carcass harvesting")]
        [Description("How frozen a carcass can be to harvest with bare hands.(Game default = 50%)")]
        [Slider(0, 100)]
        public int harvestFrozen2 = 50;

        [Name("         - Meat harvesting")]
        [Description("Meat harvesting times reduced.(Game default = 10%)")]
        [Slider(0, 99)]
        public int meatHarvestTime2 = 10;

        [Name("         - Hide & gut harvesting")]
        [Description("Hide & gut harvesting time reduced.(Game default = 0%)")]
        [Slider(0, 99)]
        public int hideGutHarvestTime2 = 0;

        //lvl3
        [Name("Carcass harvesting Level 3 ------------------------------")]
        [Description("Show or hide level 3 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool harvest3 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 30)")]
        [Slider(30, 1250)]
        public int harvestTier3 = 30;

        [Name("         - Frozen carcass harvesting")]
        [Description("How frozen a carcass can be to harvest with bare hands.(Game default = 50%)")]
        [Slider(0, 100)]
        public int harvestFrozen3 = 50;

        [Name("         - Meat harvesting")]
        [Description("Meat harvesting times reduced.(Game default = 25%)")]
        [Slider(0, 99)]
        public int meatHarvestTime3 = 25;

        [Name("         - Hide & gut harvesting")]
        [Description("Hide & gut harvesting time reduced.(Game default = 10%)")]
        [Slider(0, 99)]
        public int hideGutHarvestTime3 = 10;

        //lvl4
        [Name("Carcass harvesting Level 4 ------------------------------")]
        [Description("Show or hide level 4 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool harvest4 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 50)")]
        [Slider(50, 1250)]
        public int harvestTier4 = 50;

        [Name("         - Frozen carcass harvesting")]
        [Description("How frozen a carcass can be to harvest with bare hands.(Game default = 75%)")]
        [Slider(0, 100)]
        public int harvestFrozen4 = 75;

        [Name("         - Meat harvesting")]
        [Description("Meat harvesting times reduced.(Game default = 30%)")]
        [Slider(0, 99)]
        public int meatHarvestTime4 = 30;

        [Name("         - Hide & gut harvesting")]
        [Description("Hide & gut harvesting time reduced.(Game default = 20%)")]
        [Slider(0, 99)]
        public int hideGutHarvestTime4 = 20;

        //lvl5
        [Name("Carcass harvesting Level 5 ------------------------------")]
        [Description("Show or hide level 5 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool harvest5 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 100)")]
        [Slider(100, 1250)]
        public int harvestTier5 = 100;

        [Name("         - Frozen carcass harvesting")]
        [Description("How frozen a carcass can be to harvest with bare hands.(Game default = 100%)")]
        [Slider(0, 100)]
        public int harvestFrozen5 = 100;

        [Name("         - Meat harvesting")]
        [Description("Meat harvesting times reduced.(Game default = 50%)")]
        [Slider(0, 99)]
        public int meatHarvestTime5 = 50;

        [Name("         - Hide & gut harvesting")]
        [Description("Hide & gut harvesting time reduced.(Game default = 30%)")]
        [Slider(0, 99)]
        public int hideGutHarvestTime5 = 30;


        // |----------------------------------------- Ice Fishing ------------------------------------------------|

        [Section("Ice Fishing")]

        [Name("Ice Fishing Skills")]
        [Description("Show or hide Ice Fishing Skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool iceFishing = false;

        //lvl1
        [Name("Ice Fishing Level 1 ------------------------------")]
        [Description("Show or hide level 1 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool iceFishing1 = false;

        [Name("          Bonus fish weight")]
        [Description("Increase the weight of fish you catch.(Game default = 0%)")]
        [Slider(0, 200)]
        public int fishWeight1 = 0;

        [Name("          Fishing time")]
        [Description("Reduce the amount of time needed to fish.(Game default = 0%)")]
        [Slider(0, 99)]
        public int fishingTime1 = 0;

        [Name("          Chance of line breaking")]
        [Description("Adjust the chance of your line breaking.(Game default = 12%)")]
        [Slider(0, 100)]
        public int lineBreak1 = 12;

        //lvl2
        [Name("Ice Fishing Level 2 ------------------------------")]
        [Description("Show or hide level 2 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool iceFishing2 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 10)")]
        [Slider(10, 500)]
        public int fishTier2 = 10;

        [Name("          Bonus fish weight")]
        [Description("Increase the weight of fish you catch.(Game default = 0%)")]
        [Slider(0, 200)]
        public int fishWeight2 = 0;

        [Name("          Fishing time")]
        [Description("Reduce the amount of time needed to fish.(Game default = 5%)")]
        [Slider(0, 50)]
        public int fishingTime2 = 5;

        [Name("          Chance of line breaking")]
        [Description("Adjust the chance of your line breaking.(Game default = 8%)")]
        [Slider(0, 100)]
        public int lineBreak2 = 8;

        //lvl3
        [Name("Ice Fishing Level 3 ------------------------------")]
        [Description("Show or hide level 3 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool iceFishing3 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 50)")]
        [Slider(50, 500)]
        public int fishTier3 = 50;

        [Name("          Bonus fish weight")]
        [Description("Increase the weight of fish you catch.(Game default = 0%)")]
        [Slider(0, 200)]
        public int fishWeight3 = 0;

        [Name("          Fishing time")]
        [Description("Reduce the amount of time needed to fish.(Game default = 10%)")]
        [Slider(0, 50)]
        public int fishingTime3 = 10;

        [Name("          Chance of line breaking")]
        [Description("Adjust the chance of your line breaking.(Game default = 5%)")]
        [Slider(0, 100)]
        public int lineBreak3 = 5;

        //lvl4
        [Name("Ice Fishing Level 4 ------------------------------")]
        [Description("Show or hide level 4 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool iceFishing4 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 150)")]
        [Slider(150, 750)]
        public int fishTier4 = 150;

        [Name("          Bonus fish weight")]
        [Description("Increase the weight of fish you catch.(Game default = 10%)")]
        [Slider(0, 200)]
        public int fishWeight4 = 10;

        [Name("          Fishing time")]
        [Description("Reduce the amount of time needed to fish.(Game default = 20%)")]
        [Slider(0, 50)]
        public int fishingTime4 = 20;

        [Name("          Chance of line breaking")]
        [Description("Adjust the chance of your line breaking.(Game default = 3%)")]
        [Slider(0, 100)]
        public int lineBreak4 = 3;

        //lvl5
        [Name("Ice Fishing Level 5 ------------------------------")]
        [Description("Show or hide level 5 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool iceFishing5 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 250)")]
        [Slider(250, 1250)]
        public int fishTier5 = 250;

        [Name("          Bonus fish weight")]
        [Description("Increase the weight of fish you catch.(Game default = 25%)")]
        [Slider(0, 200)]
        public int fishWeight5 = 25;

        [Name("          Fishing time")]
        [Description("Reduce the amount of time needed to fish.(Game default = 30%)")]
        [Slider(0, 50)]
        public int fishingTime5 = 30;

        [Name("          Chance of line breaking")]
        [Description("Adjust the chance of your line breaking.(Game default = 1%)")]
        [Slider(0, 100)]
        public int lineBreak5 = 1;


        // |----------------------------------------- Cooking ------------------------------------------------|

        [Section("Cooking")]

        [Name("Cooking Skills")]
        [Description("Show or hide cooking Skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool cooking = false;

        //
        [Name("Smashing open cans")]
        [Description("Level when no calories are lost when smashing open cans.(Game default = 3) (6 = Calories are always lost) - Requires game reload to take effect")]
        [Slider(1, 6)]
        public int noCalorieLossLevel = 3;

        [Name("Parasites & Posion")]
        [Description("Level when parasites and poison are disabled.(Game default = 5) (6 = Always a chance for parasites and poison) - Requires game reload to take effect")]
        [Slider(1, 6)]
        public int noPoisonLevel = 5;

        //lvl1
        [Name("Cooking Level 1 ------------------------------")]
        [Description("Show or hide level 1 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool cooking1 = false;

        [Name("         - Calorie bonus")]
        [Description("Add calorie bonus to cooked food.(Game default = 0%)")]
        [Slider(0, 100)]
        public int calorieBonus1 = 0;

        [Name("         - Cooking time")]
        [Description("Reduce cooking time.(Game default = 0%)")]
        [Slider(0, 99)]
        public int reduceCookingTime1 = 0;

        [Name("         - Ready time")]
        [Description("Ready time increase .(Game default = 0%)")]
        [Slider(0, 99)]
        public int readyTimeIncrease1 = 0;


        //lvl2
        [Name("Cooking Level 2 ------------------------------")]
        [Description("Show or hide level 2 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool cooking2 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 25)")]
        [Slider(25, 1750)]
        public int cookingTier2 = 25;

        [Name("         - Calorie bonus")]
        [Description("Add calorie bonus to cooked food.(Game default = 10%)")]
        [Slider(0, 100)]
        public int calorieBonus2 = 10;

        [Name("         - Cooking time")]
        [Description("Reduce cooking time.(Game default = 0%)")]
        [Slider(0, 99)]
        public int reduceCookingTime2 = 0;

        [Name("         - Ready time")]
        [Description("Ready time increase .(Game default = 0%)")]
        [Slider(0, 99)]
        public int readyTimeIncrease2 = 0;


        //lvl3
        [Name("Cooking Level 3 ------------------------------")]
        [Description("Show or hide level 3 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool cooking3 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 75)")]
        [Slider(75, 1750)]
        public int cookingTier3 = 75;

        [Name("         - Calorie bonus")]
        [Description("Add calorie bonus to cooked food.(Game default = 15%)")]
        [Slider(0, 100)]
        public int calorieBonus3 = 15;

        [Name("         - Cooking time")]
        [Description("Reduce cooking time.(Game default = 10%)")]
        [Slider(0, 99)]
        public int reduceCookingTime3 = 10;

        [Name("         - Ready time")]
        [Description("Ready time increase .(Game default = 0%)")]
        [Slider(0, 99)]
        public int readyTimeIncrease3 = 0;


        //lvl4
        [Name("Cooking Level 4 ------------------------------")]
        [Description("Show or hide level 4 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool cooking4 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 150)")]
        [Slider(150, 1750)]
        public int cookingTier4 = 150;

        [Name("         - Calorie bonus")]
        [Description("Add calorie bonus to cooked food.(Game default = 20%)")]
        [Slider(0, 100)]
        public int calorieBonus4 = 20;

        [Name("         - Cooking time")]
        [Description("Reduce cooking time.(Game default = 20%)")]
        [Slider(0, 99)]
        public int reduceCookingTime4 = 20;

        [Name("         - Ready time")]
        [Description("Ready time increase .(Game default = 20%)")]
        [Slider(0, 99)]
        public int readyTimeIncrease4 = 20;


        //lvl5
        [Name("Cooking Level 5 ------------------------------")]
        [Description("Show or hide level 5 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool cooking5 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 350)")]
        [Slider(350, 1750)]
        public int cookingTier5 = 350;

        [Name("         - Calorie bonus")]
        [Description("Add calorie bonus to cooked food.(Game default = 25%)")]
        [Slider(0, 100)]
        public int calorieBonus5 = 25;

        [Name("         - Cooking time")]
        [Description("Reduce cooking time.(Game default = 30%)")]
        [Slider(0, 99)]
        public int reduceCookingTime5 = 30;

        [Name("         - Ready time")]
        [Description("Ready time increase .(Game default = 20%)")]
        [Slider(0, 99)]
        public int readyTimeIncrease5 = 20;

        
        
        // hidden 
        [Section("")]

        [Name("")]
        [Description("")]
        [Choice("+", "-")]
        private bool smithTierX = false;

        [Name("         - ")]
        [Description("Not adjustable!")]
        [Slider(-1, 0)]
        public readonly int smithTier1 = 0;



        protected override void OnChange(FieldInfo field, object oldValue, object newValue)
        {
            if (field.Name == nameof(archery)   ||
                field.Name == nameof(archery1)  ||
                field.Name == nameof(archery2)  ||
                field.Name == nameof(archery3)  ||
                field.Name == nameof(archery4)  ||
                field.Name == nameof(archery5)  ||
                field.Name == nameof(revolver)  ||
                field.Name == nameof(revolver1) ||
                field.Name == nameof(revolver2) ||
                field.Name == nameof(revolver3) ||
                field.Name == nameof(revolver4) ||
                field.Name == nameof(revolver5) ||
                field.Name == nameof(rifle)     ||
                field.Name == nameof(rifle1)    ||
                field.Name == nameof(rifle2)    ||
                field.Name == nameof(rifle3)    ||
                field.Name == nameof(rifle4)    ||
                field.Name == nameof(rifle5)    ||
                field.Name == nameof(fireStarting)  ||
                field.Name == nameof(fireStarting1) ||
                field.Name == nameof(fireStarting2) ||
                field.Name == nameof(fireStarting3) ||
                field.Name == nameof(fireStarting4) ||
                field.Name == nameof(fireStarting5) ||
                field.Name == nameof(gunSmith)  ||
                field.Name == nameof(gunSmith1) ||
                field.Name == nameof(gunSmith2) ||
                field.Name == nameof(gunSmith3) ||
                field.Name == nameof(gunSmith4) ||
                field.Name == nameof(gunSmith5) ||
                field.Name == nameof(mending)  ||
                field.Name == nameof(mending1) ||
                field.Name == nameof(mending2) ||
                field.Name == nameof(mending3) ||
                field.Name == nameof(mending4) ||
                field.Name == nameof(mending5) ||
                field.Name == nameof(harvest)  ||
                field.Name == nameof(harvest1) ||
                field.Name == nameof(harvest2) ||
                field.Name == nameof(harvest3) ||
                field.Name == nameof(harvest4) ||
                field.Name == nameof(harvest5) ||
                field.Name == nameof(iceFishing) ||
                field.Name == nameof(iceFishing1) ||
                field.Name == nameof(iceFishing2) ||
                field.Name == nameof(iceFishing3) ||
                field.Name == nameof(iceFishing4) ||
                field.Name == nameof(iceFishing5) ||
                field.Name == nameof(cooking) ||
                field.Name == nameof(cooking1) ||
                field.Name == nameof(cooking2) ||
                field.Name == nameof(cooking3) ||
                field.Name == nameof(cooking4) ||
                field.Name == nameof(cooking5))



            {
                RefreshFields();
            }
        }

        internal void RefreshFields()
        {
            //ARCHERY
            SetFieldVisible(nameof(CrouchLevel), archery);

            SetFieldVisible(nameof(archery1), archery);
            SetFieldVisible(nameof(bowSway1), (archery1) && archery);
            SetFieldVisible(nameof(bowDamage1), (archery1) && archery);
            SetFieldVisible(nameof(bowCritical1), (archery1) && archery);
            SetFieldVisible(nameof(bowBleedOut1), (archery1) && archery);
            SetFieldVisible(nameof(bowPerUseConditionLoss1), (archery1) && archery);

            SetFieldVisible(nameof(archery2), archery);
            SetFieldVisible(nameof(bowSway2), (archery2) && archery);
            SetFieldVisible(nameof(bowDamage2), (archery2) && archery);
            SetFieldVisible(nameof(bowCritical2), (archery2) && archery);
            SetFieldVisible(nameof(bowBleedOut2), (archery2) && archery);
            SetFieldVisible(nameof(bowPerUseConditionLoss2), (archery2) && archery);
            SetFieldVisible(nameof(archeryTier2), (archery2) && archery);

            SetFieldVisible(nameof(archery3), archery);
            SetFieldVisible(nameof(bowSway3), (archery3) && archery);
            SetFieldVisible(nameof(bowDamage3), (archery3) && archery);
            SetFieldVisible(nameof(bowCritical3), (archery3) && archery);
            SetFieldVisible(nameof(bowBleedOut3), (archery3) && archery);
            SetFieldVisible(nameof(bowPerUseConditionLoss3), (archery3) && archery);
            SetFieldVisible(nameof(archeryTier3), (archery3) && archery);

            SetFieldVisible(nameof(archery4), archery);
            SetFieldVisible(nameof(bowSway4), (archery4) && archery);
            SetFieldVisible(nameof(bowDamage4), (archery4) && archery);
            SetFieldVisible(nameof(bowCritical4), (archery4) && archery);
            SetFieldVisible(nameof(bowBleedOut4), (archery4) && archery);
            SetFieldVisible(nameof(bowPerUseConditionLoss4), (archery4) && archery);
            SetFieldVisible(nameof(archeryTier4), (archery4) && archery);

            SetFieldVisible(nameof(archery5), archery);
            SetFieldVisible(nameof(bowSway5), (archery5) && archery);
            SetFieldVisible(nameof(bowDamage5), (archery5) && archery);
            SetFieldVisible(nameof(bowCritical5), (archery5) && archery);
            SetFieldVisible(nameof(bowBleedOut5), (archery5) && archery);
            SetFieldVisible(nameof(bowPerUseConditionLoss5), (archery5) && archery);
            SetFieldVisible(nameof(archeryTier5), (archery5) && archery);

            //REVOLVER

            SetFieldVisible(nameof(revolver1), revolver);
            SetFieldVisible(nameof(revolverDegradeOnUse1), revolver1 && revolver);
            SetFieldVisible(nameof(revolverAim1), revolver1 && revolver);
            SetFieldVisible(nameof(revolverRecoil1), revolver1 && revolver);
            SetFieldVisible(nameof(revolverStruggleBonus1), revolver1 && revolver);
            SetFieldVisible(nameof(revolverRepairBonus1), revolver1 && revolver);
            SetFieldVisible(nameof(revolverDamage1), revolver1 && revolver);
            SetFieldVisible(nameof(revolverCritical1), revolver1 && revolver);

            SetFieldVisible(nameof(revolver2), revolver);
            SetFieldVisible(nameof(revolverDegradeOnUse2), revolver2 && revolver);
            SetFieldVisible(nameof(revolverAim2), revolver2 && revolver);
            SetFieldVisible(nameof(revolverRecoil2), revolver2 && revolver);
            SetFieldVisible(nameof(revolverStruggleBonus2), revolver2 && revolver);
            SetFieldVisible(nameof(revolverRepairBonus2), revolver2 && revolver);
            SetFieldVisible(nameof(revolverDamage2), revolver2 && revolver);
            SetFieldVisible(nameof(revolverCritical2), revolver2 && revolver);
            SetFieldVisible(nameof(revolverTier2), revolver2 && revolver);


            SetFieldVisible(nameof(revolver3), revolver);
            SetFieldVisible(nameof(revolverDegradeOnUse3), revolver3 && revolver);
            SetFieldVisible(nameof(revolverAim3), revolver3 && revolver);
            SetFieldVisible(nameof(revolverRecoil3), revolver3 && revolver);
            SetFieldVisible(nameof(revolverStruggleBonus3), revolver3 && revolver);
            SetFieldVisible(nameof(revolverRepairBonus3), revolver3 && revolver);
            SetFieldVisible(nameof(revolverDamage3), revolver3 && revolver);
            SetFieldVisible(nameof(revolverCritical3), revolver3 && revolver);
            SetFieldVisible(nameof(revolverTier3), revolver3 && revolver);

            SetFieldVisible(nameof(revolver4), revolver);
            SetFieldVisible(nameof(revolverDegradeOnUse4), revolver4 && revolver);
            SetFieldVisible(nameof(revolverAim4), revolver4 && revolver);
            SetFieldVisible(nameof(revolverRecoil4), revolver4 && revolver);
            SetFieldVisible(nameof(revolverStruggleBonus4), revolver4 && revolver);
            SetFieldVisible(nameof(revolverRepairBonus4), revolver4 && revolver);
            SetFieldVisible(nameof(revolverDamage4), revolver4 && revolver);
            SetFieldVisible(nameof(revolverCritical4), revolver4 && revolver);
            SetFieldVisible(nameof(revolverTier4), revolver4 && revolver);

            SetFieldVisible(nameof(revolver5), revolver);
            SetFieldVisible(nameof(revolverDegradeOnUse5), revolver5 && revolver);
            SetFieldVisible(nameof(revolverAim5), revolver5 && revolver);
            SetFieldVisible(nameof(revolverRecoil5), revolver5 && revolver);
            SetFieldVisible(nameof(revolverStruggleBonus5), revolver5 && revolver);
            SetFieldVisible(nameof(revolverRepairBonus5), revolver5 && revolver);
            SetFieldVisible(nameof(revolverDamage5), revolver5 && revolver);
            SetFieldVisible(nameof(revolverCritical5), revolver5 && revolver);
            SetFieldVisible(nameof(revolverTier5), revolver5 && revolver);

            //RIFLE
            SetFieldVisible(nameof(rifle1), rifle);
            SetFieldVisible(nameof(rifleCritical1), rifle1 && rifle);
            SetFieldVisible(nameof(rifleRepairBonus1), rifle1 && rifle);
            SetFieldVisible(nameof(rifleAccuracyRange1), rifle1 && rifle);
            SetFieldVisible(nameof(rifleDamage1), rifle1 && rifle);
            SetFieldVisible(nameof(rifleLessDegradeOnUse1), rifle1 && rifle);
            SetFieldVisible(nameof(rifleLessDegradeOnUse1), rifle1 && rifle);
            SetFieldVisible(nameof(rifleLessDegradeOnUse1), rifle1 && rifle);
            SetFieldVisible(nameof(rifleAimAssist1), rifle1 && rifle);
            SetFieldVisible(nameof(rifleEffectiveRange1), rifle1 && rifle);
            SetFieldVisible(nameof(rifleStabilityBonus1), rifle1 && rifle);

            SetFieldVisible(nameof(rifle2), rifle);
            SetFieldVisible(nameof(rifleCritical2), rifle2 && rifle);
            SetFieldVisible(nameof(rifleRepairBonus2), rifle2 && rifle);
            SetFieldVisible(nameof(rifleAccuracyRange2), rifle2 && rifle);
            SetFieldVisible(nameof(rifleDamage2), rifle2 && rifle);
            SetFieldVisible(nameof(rifleLessDegradeOnUse2), rifle2 && rifle);
            SetFieldVisible(nameof(rifleAimAssist2), rifle2 && rifle);
            SetFieldVisible(nameof(rifleEffectiveRange2), rifle2 && rifle);
            SetFieldVisible(nameof(rifleStabilityBonus2), rifle2 && rifle);
            SetFieldVisible(nameof(rifleTier2), rifle2 && rifle);

            SetFieldVisible(nameof(rifle3), rifle);
            SetFieldVisible(nameof(rifleCritical3), rifle3 && rifle);
            SetFieldVisible(nameof(rifleRepairBonus3), rifle3 && rifle);
            SetFieldVisible(nameof(rifleAccuracyRange3), rifle3 && rifle);
            SetFieldVisible(nameof(rifleDamage3), rifle3 && rifle);
            SetFieldVisible(nameof(rifleLessDegradeOnUse3), rifle3 && rifle);
            SetFieldVisible(nameof(rifleAimAssist3), rifle3 && rifle);
            SetFieldVisible(nameof(rifleEffectiveRange3), rifle3 && rifle);
            SetFieldVisible(nameof(rifleStabilityBonus3), rifle3 && rifle);
            SetFieldVisible(nameof(rifleTier3), rifle3 && rifle);

            SetFieldVisible(nameof(rifle4), rifle);
            SetFieldVisible(nameof(rifleCritical4), rifle4 && rifle);
            SetFieldVisible(nameof(rifleRepairBonus4), rifle4 && rifle);
            SetFieldVisible(nameof(rifleAccuracyRange4), rifle4 && rifle);
            SetFieldVisible(nameof(rifleDamage4), rifle4 && rifle);
            SetFieldVisible(nameof(rifleLessDegradeOnUse4), rifle4 && rifle);
            SetFieldVisible(nameof(rifleAimAssist4), rifle4 && rifle);
            SetFieldVisible(nameof(rifleEffectiveRange4), rifle4 && rifle);
            SetFieldVisible(nameof(rifleStabilityBonus4), rifle4 && rifle);
            SetFieldVisible(nameof(rifleTier4), rifle4 && rifle);

            SetFieldVisible(nameof(rifle5), rifle);
            SetFieldVisible(nameof(rifleCritical5), rifle5 && rifle);
            SetFieldVisible(nameof(rifleRepairBonus5), rifle5 && rifle);
            SetFieldVisible(nameof(rifleAccuracyRange5), rifle5 && rifle);
            SetFieldVisible(nameof(rifleDamage5), rifle5 && rifle);
            SetFieldVisible(nameof(rifleLessDegradeOnUse5), rifle5 && rifle);
            SetFieldVisible(nameof(rifleAimAssist5), rifle5 && rifle);
            SetFieldVisible(nameof(rifleEffectiveRange5), rifle5 && rifle);
            SetFieldVisible(nameof(rifleStabilityBonus5), rifle5 && rifle);
            SetFieldVisible(nameof(rifleTier5), rifle5 && rifle);

            //Firestarting
            SetFieldVisible(nameof(tinderLevelRequirement), fireStarting);

            SetFieldVisible(nameof(fireStarting1), fireStarting);
            SetFieldVisible(nameof(fireBaseChance1), fireStarting1 && fireStarting);
            SetFieldVisible(nameof(fireDurationBonus1), fireStarting1 && fireStarting);
            SetFieldVisible(nameof(quickerFireStarting1), fireStarting1 && fireStarting);

            SetFieldVisible(nameof(fireStarting2), fireStarting);
            SetFieldVisible(nameof(fireBaseChance2), fireStarting2 && fireStarting);
            SetFieldVisible(nameof(fireDurationBonus2), fireStarting2 && fireStarting);
            SetFieldVisible(nameof(quickerFireStarting2), fireStarting2 && fireStarting);
            SetFieldVisible(nameof(fireTier2), fireStarting2 && fireStarting);

            SetFieldVisible(nameof(fireStarting3), fireStarting);
            SetFieldVisible(nameof(fireBaseChance3), fireStarting3 && fireStarting);
            SetFieldVisible(nameof(fireDurationBonus3), fireStarting3 && fireStarting);
            SetFieldVisible(nameof(quickerFireStarting3), fireStarting3 && fireStarting);
            SetFieldVisible(nameof(fireTier3), fireStarting3 && fireStarting);

            SetFieldVisible(nameof(fireStarting4), fireStarting);
            SetFieldVisible(nameof(fireBaseChance4), fireStarting4 && fireStarting);
            SetFieldVisible(nameof(fireDurationBonus4), fireStarting4 && fireStarting);
            SetFieldVisible(nameof(quickerFireStarting4), fireStarting4 && fireStarting);
            SetFieldVisible(nameof(fireTier4), fireStarting4 && fireStarting);

            SetFieldVisible(nameof(fireStarting5), fireStarting);
            SetFieldVisible(nameof(fireBaseChance5), fireStarting5 && fireStarting);
            SetFieldVisible(nameof(fireDurationBonus5), fireStarting5 && fireStarting);
            SetFieldVisible(nameof(quickerFireStarting5), fireStarting5 && fireStarting);
            SetFieldVisible(nameof(fireTier5), fireStarting5 && fireStarting);

            //Gunsmithing
            SetFieldVisible(nameof(gunSmith1), gunSmith);
            SetFieldVisible(nameof(ammoCraft1), gunSmith1 && gunSmith);
            SetFieldVisible(nameof(ammoHarvest1), gunSmith1 && gunSmith);
            SetFieldVisible(nameof(repairCon1), gunSmith1 && gunSmith);
            SetFieldVisible(nameof(repairChance1), gunSmith1 && gunSmith);
            SetFieldVisible(nameof(smithTier1), smithTierX);

            SetFieldVisible(nameof(gunSmith2), gunSmith);
            SetFieldVisible(nameof(ammoCraft2), gunSmith2 && gunSmith);
            SetFieldVisible(nameof(ammoHarvest2), gunSmith2 && gunSmith);
            SetFieldVisible(nameof(repairCon2), gunSmith2 && gunSmith);
            SetFieldVisible(nameof(repairChance2), gunSmith2 && gunSmith);
            SetFieldVisible(nameof(smithTier2), gunSmith2 && gunSmith);

            SetFieldVisible(nameof(gunSmith3), gunSmith);
            SetFieldVisible(nameof(ammoCraft3), gunSmith3 && gunSmith);
            SetFieldVisible(nameof(ammoHarvest3), gunSmith3 && gunSmith);
            SetFieldVisible(nameof(repairCon3), gunSmith3 && gunSmith);
            SetFieldVisible(nameof(repairChance3), gunSmith3 && gunSmith);
            SetFieldVisible(nameof(smithTier3), gunSmith3 && gunSmith);

            SetFieldVisible(nameof(gunSmith4), gunSmith);
            SetFieldVisible(nameof(ammoCraft4), gunSmith4 && gunSmith);
            SetFieldVisible(nameof(ammoHarvest4), gunSmith4 && gunSmith);
            SetFieldVisible(nameof(repairCon4), gunSmith4 && gunSmith);
            SetFieldVisible(nameof(repairChance4), gunSmith4 && gunSmith);
            SetFieldVisible(nameof(smithTier4), gunSmith4 && gunSmith);

            SetFieldVisible(nameof(gunSmith5), gunSmith);
            SetFieldVisible(nameof(ammoCraft5), gunSmith5 && gunSmith);
            SetFieldVisible(nameof(ammoHarvest5), gunSmith5 && gunSmith);
            SetFieldVisible(nameof(repairCon5), gunSmith5 && gunSmith);
            SetFieldVisible(nameof(repairChance5), gunSmith5 && gunSmith);
            SetFieldVisible(nameof(smithTier5), gunSmith5 && gunSmith);

            //Mending
            SetFieldVisible(nameof(mending1), mending);
            SetFieldVisible(nameof(mendingSuccessChance1), mending1 && mending);
            SetFieldVisible(nameof(mendingConditionBonus1), mending1 && mending);
            SetFieldVisible(nameof(mendingRepairTimeReduced1), mending1 && mending);
            SetFieldVisible(nameof(SewingKitDegradeDecrease1), mending1 && mending);

            SetFieldVisible(nameof(mending2), mending);
            SetFieldVisible(nameof(mendingSuccessChance2), mending2 && mending);
            SetFieldVisible(nameof(mendingConditionBonus2), mending2 && mending);
            SetFieldVisible(nameof(mendingRepairTimeReduced2), mending2 && mending);
            SetFieldVisible(nameof(SewingKitDegradeDecrease2), mending2 && mending);
            SetFieldVisible(nameof(mendTier2), mending2 && mending);

            SetFieldVisible(nameof(mending3), mending);
            SetFieldVisible(nameof(mendingSuccessChance3), mending3 && mending);
            SetFieldVisible(nameof(mendingConditionBonus3), mending3 && mending);
            SetFieldVisible(nameof(mendingRepairTimeReduced3), mending3 && mending);
            SetFieldVisible(nameof(SewingKitDegradeDecrease3), mending3 && mending);
            SetFieldVisible(nameof(mendTier3), mending3 && mending);

            SetFieldVisible(nameof(mending4), mending);
            SetFieldVisible(nameof(mendingSuccessChance4), mending4 && mending);
            SetFieldVisible(nameof(mendingConditionBonus4), mending4 && mending);
            SetFieldVisible(nameof(mendingRepairTimeReduced4), mending4 && mending);
            SetFieldVisible(nameof(SewingKitDegradeDecrease4), mending4 && mending);
            SetFieldVisible(nameof(mendTier4), mending4 && mending);

            SetFieldVisible(nameof(mending5), mending);
            SetFieldVisible(nameof(mendingSuccessChance5), mending5 && mending);
            SetFieldVisible(nameof(mendingConditionBonus5), mending5 && mending);
            SetFieldVisible(nameof(mendingRepairTimeReduced5), mending5 && mending);
            SetFieldVisible(nameof(SewingKitDegradeDecrease5), mending5 && mending);
            SetFieldVisible(nameof(mendTier5), mending5 && mending);

            //Carcass Harvesting
            SetFieldVisible(nameof(harvestHoursForSkillPoint), harvest);

            SetFieldVisible(nameof(harvest1), harvest);
            SetFieldVisible(nameof(harvestFrozen1), harvest1 && harvest);
            SetFieldVisible(nameof(meatHarvestTime1), harvest1 && harvest);
            SetFieldVisible(nameof(hideGutHarvestTime1), harvest1 && harvest);

            SetFieldVisible(nameof(harvest2), harvest);
            SetFieldVisible(nameof(harvestFrozen2), harvest2 && harvest);
            SetFieldVisible(nameof(meatHarvestTime2), harvest2 && harvest);
            SetFieldVisible(nameof(hideGutHarvestTime2), harvest2 && harvest);
            SetFieldVisible(nameof(harvestTier2), harvest2 && harvest);

            SetFieldVisible(nameof(harvest3), harvest);
            SetFieldVisible(nameof(harvestFrozen3), harvest3 && harvest);
            SetFieldVisible(nameof(meatHarvestTime3), harvest3 && harvest);
            SetFieldVisible(nameof(hideGutHarvestTime3), harvest3 && harvest);
            SetFieldVisible(nameof(harvestTier3), harvest3 && harvest);

            SetFieldVisible(nameof(harvest4), harvest);
            SetFieldVisible(nameof(harvestFrozen4), harvest4 && harvest);
            SetFieldVisible(nameof(meatHarvestTime4), harvest4 && harvest);
            SetFieldVisible(nameof(hideGutHarvestTime4), harvest4 && harvest);
            SetFieldVisible(nameof(harvestTier4), harvest4 && harvest);

            SetFieldVisible(nameof(harvest5), harvest);
            SetFieldVisible(nameof(harvestFrozen5), harvest5 && harvest);
            SetFieldVisible(nameof(meatHarvestTime5), harvest5 && harvest);
            SetFieldVisible(nameof(hideGutHarvestTime5), harvest5 && harvest);
            SetFieldVisible(nameof(harvestTier5), harvest5 && harvest);

            //Ice Fishing
            SetFieldVisible(nameof(iceFishing1), iceFishing);
            SetFieldVisible(nameof(fishWeight1), iceFishing1 && iceFishing);
            SetFieldVisible(nameof(fishingTime1), iceFishing1 && iceFishing);
            SetFieldVisible(nameof(lineBreak1), iceFishing1 && iceFishing);

            SetFieldVisible(nameof(iceFishing2), iceFishing);
            SetFieldVisible(nameof(fishWeight2), iceFishing2 && iceFishing);
            SetFieldVisible(nameof(fishingTime2), iceFishing2 && iceFishing);
            SetFieldVisible(nameof(lineBreak2), iceFishing2 && iceFishing);
            SetFieldVisible(nameof(fishTier2), iceFishing2 && iceFishing);

            SetFieldVisible(nameof(iceFishing3), iceFishing);
            SetFieldVisible(nameof(fishWeight3), iceFishing3 && iceFishing);
            SetFieldVisible(nameof(fishingTime3), iceFishing3 && iceFishing);
            SetFieldVisible(nameof(lineBreak3), iceFishing3 && iceFishing);
            SetFieldVisible(nameof(fishTier3), iceFishing3 && iceFishing);

            SetFieldVisible(nameof(iceFishing4), iceFishing);
            SetFieldVisible(nameof(fishWeight4), iceFishing4 && iceFishing);
            SetFieldVisible(nameof(fishingTime4), iceFishing4 && iceFishing);
            SetFieldVisible(nameof(lineBreak4), iceFishing4 && iceFishing);
            SetFieldVisible(nameof(fishTier4), iceFishing4 && iceFishing);

            SetFieldVisible(nameof(iceFishing5), iceFishing);
            SetFieldVisible(nameof(fishWeight5), iceFishing5 && iceFishing);
            SetFieldVisible(nameof(fishingTime5), iceFishing5 && iceFishing);
            SetFieldVisible(nameof(lineBreak5), iceFishing5 && iceFishing);
            SetFieldVisible(nameof(fishTier5), iceFishing5 && iceFishing);


            //Cooking
            SetFieldVisible(nameof(cooking1), cooking);
            SetFieldVisible(nameof(noCalorieLossLevel), cooking);
            SetFieldVisible(nameof(noPoisonLevel), cooking);

            SetFieldVisible(nameof(cooking1), cooking);
            SetFieldVisible(nameof(calorieBonus1), cooking1 && cooking);
            SetFieldVisible(nameof(reduceCookingTime1), cooking1 && cooking);
            SetFieldVisible(nameof(readyTimeIncrease1), cooking1 && cooking);

            SetFieldVisible(nameof(cooking2), cooking);
            SetFieldVisible(nameof(calorieBonus2), cooking2 && cooking);
            SetFieldVisible(nameof(reduceCookingTime2), cooking2 && cooking);
            SetFieldVisible(nameof(readyTimeIncrease2), cooking2 && cooking);
            SetFieldVisible(nameof(cookingTier2), cooking2 && cooking);

            SetFieldVisible(nameof(cooking3), cooking);
            SetFieldVisible(nameof(calorieBonus3), cooking3 && cooking);
            SetFieldVisible(nameof(reduceCookingTime3), cooking3 && cooking);
            SetFieldVisible(nameof(readyTimeIncrease3), cooking3 && cooking);
            SetFieldVisible(nameof(cookingTier3), cooking3 && cooking);

            SetFieldVisible(nameof(cooking4), cooking);
            SetFieldVisible(nameof(calorieBonus4), cooking4 && cooking);
            SetFieldVisible(nameof(reduceCookingTime4), cooking4 && cooking);
            SetFieldVisible(nameof(readyTimeIncrease4), cooking4 && cooking);
            SetFieldVisible(nameof(cookingTier4), cooking4 && cooking);

            SetFieldVisible(nameof(cooking5), cooking);
            SetFieldVisible(nameof(calorieBonus5), cooking5 && cooking);
            SetFieldVisible(nameof(reduceCookingTime5), cooking5 && cooking);
            SetFieldVisible(nameof(readyTimeIncrease5), cooking5 && cooking);
            SetFieldVisible(nameof(cookingTier5), cooking5 && cooking);


        }


        internal static Settings settings;
        internal static void OnLoad()
        {
            settings = new Settings();
            settings.AddToModSettings("Skill-Adjustment");
            settings.RefreshFields();
        }
    }
}
