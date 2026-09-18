using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace Calamity_murasama_progression.Content.Items.RealMurasamaNotFake
{
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class RealMurasamaNotFake : ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.Calamity_murasama_progression.hjson' file.
		public override void SetDefaults()
		{
			Item.width = 10;
			Item.height = 10;
			Item.damage = 0;
			Item.DamageType = DamageClass.MeleeNoSpeed;
			Item.useTime = 70;
			Item.autoReuse = true;
			Item.value = Item.buyPrice(silver: 1);
			Item.useAnimation = 70;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.UseSound = new SoundStyle("Calamity_murasama_progression/Assets/Sounds/bowomp")
				{ Volume = 15f, PitchVariance = 0.3f };
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 1000);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}
