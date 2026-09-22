using Calamity_murasama_progression.Content.config;
using Calamity_murasama_progression.Content.murasama.util;
using Terraria;
using Terraria.ModLoader;

namespace Calamity_murasama_progression.Content.murasama
{
    public class MurasamaProgressionGlobalItem : GlobalItem
    {

        public override void ModifyWeaponDamage(Item item, Player player, ref StatModifier damage)
        {
            bool isEnableProgression = ModContent.GetInstance<MurasamaConfig>().EnableMurasamaProgression;
            if (isEnableProgression && item.ModItem != null && item.ModItem.Mod.Name == "CalamityMod" && item.ModItem.Name == "Murasama")
            {
                damage *= DamageCounterUtil.CountDamage();
            }
        }
    }
}