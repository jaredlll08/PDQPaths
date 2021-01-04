using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using StardewValley.TerrainFeatures;

namespace PDQPaths
{
    public class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
        {
            helper.Events.GameLoop.UpdateTicked += (sender, args) =>
            {
                if (Game1.currentLocation == null || !Game1.currentLocation.terrainFeatures.ContainsKey(Game1.player.getTileLocation()))
                {
                    return;
                }

                if (Game1.currentLocation.terrainFeatures[Game1.player.getTileLocation()] is Flooring)
                {
                    Game1.player.temporarySpeedBuff = 3;
                }
            };
        }
    }
}

/*
 * public override void Entry(IModHelper helper)
        {

            GameEvents.UpdateTick += (sender, args) =>
            {
                if (Game1.currentLocation == null || !Game1.currentLocation.terrainFeatures.ContainsKey(Game1.player.getTileLocation()))
                {
                    return;
                }
                if (Game1.currentLocation.terrainFeatures[Game1.player.getTileLocation()] is Flooring)
                {
                    Game1.player.temporarySpeedBuff = 3;
                }
            };
        }
 */