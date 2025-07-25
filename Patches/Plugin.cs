using System.ComponentModel;

namespace StupidTemplate.Patches
{

    public class HarmonyPatches
    {
        public static void OnEnable()
        {
            Menu.ApplyHarmonyPatches();
        }

        private void OnDisable()
        {
            Menu.RemoveHarmonyPatches();
        }
    }
}
