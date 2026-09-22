using Calamity_murasama_progression.Content.config;
using Calamity_murasama_progression.Content.murasama.util;
using Terraria;
using Terraria.ModLoader;

namespace Calamity_murasama_progression.Content.murasama;

public class MurasamaProjectileGlobal : GlobalProjectile
{
    
    public override void ModifyHitNPC(Projectile projectile, NPC target, ref NPC.HitModifiers modifiers)
    {
        bool isEnableProgression = ModContent.GetInstance<MurasamaConfig>().EnableMurasamaProgression;
        if (isEnableProgression && projectile.GetGlobalProjectile<MurasamaProjectileGlobal>().IsMurasamaProjectile(projectile))
        {
            modifiers.SourceDamage *= DamageCounterUtil.CountDamage();
        }
        else
        {
            base.ModifyHitNPC(projectile, target, ref modifiers);
        }
    }
     
    private bool IsMurasamaProjectile(Projectile projectile)
    {
        int pOwner = projectile.owner;
        if (pOwner >= 0 && pOwner < Main.maxPlayers)
        {
            Player player = Main.player[pOwner];
            Item item = player.HeldItem; 
            
            if (item != null && !item.IsAir && item.ModItem != null && 
                item.ModItem.Mod.Name == "CalamityMod" && item.ModItem.Name == "Murasama")
            {
                string damageClassName = projectile.DamageType.GetType().FullName;
                return damageClassName != null && 
                       (damageClassName.Contains("TrueMeleeNoSpeedDamageClass") 
                        || damageClassName.Contains("TrueMeleeDamageClass"));
            }
        }
        return false;
    }
    
}