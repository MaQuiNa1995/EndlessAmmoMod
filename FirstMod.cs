using Terraria.ModLoader;

namespace FirstMod
{
	class FirstMod : Mod
	{
		public FirstMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
