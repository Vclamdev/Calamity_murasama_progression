using System;
using System.Reflection;
using MonoMod.RuntimeDetour;
using Terraria.ModLoader;

namespace Calamity_murasama_progression.Content.murasama.hooks;

public class ModHookSystem : ModSystem
{
    private Hook _murasamaHook;
    
    public override void OnModLoad()
    {
        try
        {
            if (ModLoader.TryGetMod("CalamityMod", out Mod calamity))
            {
                Type murasamaType = calamity.GetType().Assembly.GetType("CalamityMod.Items.Weapons.Melee.Murasama");

                if (murasamaType != null)
                {
                    var targetMethod = murasamaType.GetMethod(
                        "IDUnlocked", BindingFlags.Public | BindingFlags.Instance
                    );

                    if (targetMethod != null)
                    {
                        _murasamaHook = new Hook(
                            targetMethod,
                            typeof(ModHookSystem).GetMethod(
                                nameof(FakeIDUnlocked),
                                BindingFlags.NonPublic | BindingFlags.Static
                            ) ?? throw new InvalidOperationException()
                        );
                    }
                }
            }
        }
        catch (InvalidOperationException)
        {
            
        }

    }
    
    public override void OnModUnload()
    {
        _murasamaHook?.Dispose();
        _murasamaHook = null;
    }
    
    private delegate bool OrigIdUnlocked(object self, Terraria.Player player);
        
    private static bool FakeIDUnlocked(OrigIdUnlocked orig, object self, Terraria.Player player)
    {
        return true;
    }
    
}