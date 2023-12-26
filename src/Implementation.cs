using MelonLoader;

namespace SkillAdjustment
{
	internal sealed class Implementation : MelonMod
	{
		public override void OnInitializeMelon()
		{
            Settings.OnLoad();
        }
	
	} 

}
