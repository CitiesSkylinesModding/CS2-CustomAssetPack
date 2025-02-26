﻿using Colossal.Logging;
using Game;
using Game.Modding;
using Game.SceneFlow;

namespace CustomAssetPack
{
    public class Mod : IMod
    {
        public static ILog log = LogManager.GetLogger($"AssetPacksManager.Packs")
            .SetShowsErrorsInUI(false);

        public void OnLoad(UpdateSystem updateSystem)
        {

        }

        public void OnDispose()
        {
        }
    }
}