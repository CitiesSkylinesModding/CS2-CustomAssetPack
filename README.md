## Custom Asset Pack

This repository is a template for creating custom asset packs for Cities: Skylines II. It depends on the [Asset Packs Manager (Formerly Asset Importer)](https://github.com/kosch104/CS2-AssetPacksManager) mod to load the assets into the game.

## Features
- Support for Thumbnails
- Support for Localization (Using L18N Everywhere)

## Resources for Asset Creation
Check out the [Cities Skylines Modding Discord](https://discord.gg/UkKAfRqfCn) for guides, videos and other resources for aspiring asset creators. You can also ask for help there or share your progress and ask for feedback

## DISCLAIMER

Unofficial Custom Assets are highly experimental. They WILL crash your game at some point or throw errors. Create redundant copies of your save files and use at your own risk. There has not been a lot of testing done on custom assets, and I'm publishing this project to get feedback from the community.

## Requirements
- Modding Toolchain Installed
- Finished Assets (.Prefab and .Prefab.cid file, optional Thumbnail files)

## Creating Assets
The process is called asset assembly, because we use existing assets and props and combine them into new assets. We can add Components to add functionality to the assets. You can find a full guide for the asset creation in the discord server.


Short compilation of the steps:
1. Open the Editor in Cities Skylines II
2. Choose an asset to use as template and place it in the editor. Click on the asset and click "Duplicate template"
3. Edit your duplicate to your liking
4. Open the hierarchy on the top left object list. click the save button next to the asset when you are done
5. Your assets will now be found in `C:/Users/[USERNAME]/AppData/LocalLow/Colossal Order/Cities Skylines II/StreamingAssets~`
6. Copy the .Prefab and .Prefab.cid file. The file names should correspond to the ones you chose in the editor. These are the files you will be sharing

## Creating your Asset Pack
There are two ways to create your asset pack:
1. [Using the provided `AssetPackCreator.exe` for Windows (recommended)](AssetPackCreator.md)
2. [Manually creating your Asset Pack](ManualAssetPackCreation.md)

## Support and Contact
To receive help and find other asset creators join the [Cities Skylines Modding Discord](https://discord.gg/UkKAfRqfCn). We have infrastructure with a knowledge base and a community of creators that can help you with your questions.
