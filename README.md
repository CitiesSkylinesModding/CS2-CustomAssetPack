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
- Finished Assets (.Prefab and .Prefab.cid file, option Thumbnail files)

## Creating Assets
The process is called asset assembly, because we use existing assets and props and combine them into new assets. We can add Components to add functionality to the assets. You can find a full guide for the asset creation in the discord server.


Short compilation of the steps:
1. Open the Editor in Cities Skylines II
2. Create your Asset and click the save button on the top left when you are done
3. Your assets will now be found in `C:/Users/[USERNAME]/AppData/LocalLow/Colossal Order/Cities Skylines II/StreamingAssets~`
4. Copy the .Prefab and .Prefab.cid file. The file names should correspond to the ones you chose in the editor. These are the files you will be sharing.

## Creating your Asset Pack

1. Clone the [repository](https://github.com/kosch104/CS2-CustomAssetPack) OR Create a repository based on this ("Use this template", green button)
2. Open the repository in your windows explorer (file browser) and execute the `AssetPackCreatorUtilities.exe`. There you can rename your project. Choose a project name that contains no spaces or special characters and ends in `AssetPack`
3. Open the repository sln-file with any IDE (Visual Studio, Rider, but NOT Visual Studio Code, that doesn't work)
4. If you are using an alternative Cities Skylines II installation path, enter it in the `CustomAssetPack.csproj`-file under `<CustomManagedPath>`
5. Create a file called `pdx_account.txt` on your Desktop. Put your PDX Mods username in the first line, your password in the second line. This is required for the mod to be published under your name and will not be shared with anyone.
6. Put the assets you want to add into the "Resources/assets" folder in the solution explorer (subfolders allowed)
7. Edit the localization file "en-US.json" to include your assets. Otherwise, they will have missing localization
8. Add thumbnails to your assets. Make sure the icon path is set like this `coui://customassets/PackName/CarProp.png`
9. Click on the Build Symbol (Hammer in Rider) at the top to build your project. This will load the assets into your local mods folder

## Publishing your Asset Pack

To publish your mod you have to do the following steps:
1. Open `Properties/PublishConfiguration.xml` in Notepad
2. Edit `<DisplayName>`, `<ShortDescription>`, `<LongDescription>` and `<Tag>`
3. Replace the `thumbnail.png` file by the thumbnail for your Asset Pack
4. In Visual Studio, navigate to "Publish" and select "Publish New Mod". In Rider you can just select "Publish New Mod" next to the green arrow and press the arrow to execute the Publish Configuration.


## Support and Contact
To receive help and find other asset creators join the [Cities Skylines Modding Discord](https://discord.gg/UkKAfRqfCn). We have infrastructure with a knowledge base and a community of creators that can help you with your questions.
