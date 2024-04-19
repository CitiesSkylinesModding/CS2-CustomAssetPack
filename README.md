## Custom Asset Pack

This repository is a template for creating custom asset packs for Cities: Skylines II. It depends on the [Asset Importer](https://github.com/kosch104/CS2-AssetImporter) mod to load the assets into the game.

## Features
- Support for Thumbnails
- Support for Localization (Using L18N Everywhere)

## Resources for Asset Creation
This section will include videos, knowledge bases and other resources to help you create your own assets.

## DISCLAIMER

Unofficial Custom Assets are highly experimental. They WILL crash your game at some point or throw errors. Create redundant copies of your savefiles and use at your own risk. There has not been a lot of testing done on custom assets, and I'm publishing this project to get feedback from the community.

## Requirements
- Modding Toolchain Installed
- Finished Assets (.Prefab and .Prefab.cid file, option Thumbnail files)

## Creating your Asset Pack

1. Clone the [repository](https://github.com/kosch104/CS2-CustomAssetPack) OR Create a repository based on this ("Use this template", green button)
2. Open the repository with any IDE (Visual Studio, Rider)
3. If you are using an alternative Cities Skylines II installation path, enter it in the `CustomAssetPack.csproj`-file under `<CustomManagedPath>`
4. Create a file called `pdx-account.txt` on your Desktop. Put your PDX Mods username in the first line, your password in the second line. This is required for the mod to be published under your name and will not be shared with anyone.
5. Put the assets you want to add into the "Resources/assets" folder in the solution explorer (subfolders allowed)
6. Edit the localization file "en-US.json" to include your assets. Otherwise, they will have missing localization
7. Add thumbnails to your assets. Make sure the icon path is set like this `coui://customassets/PackName/CarProp.png`
8. Click on the Build Symbol (Hammer) at the top to build your project. This will load the assets into your local mods folder

## Publishing your Asset Pack

To publish your mod you have to do the following steps:
1. Open `Properties/PublishConfiguration.xml` in Editor
2. Edit `<DisplayName>`, `<ShortDescription>`, `<LongDescription>` and `<Tag>`
3. Replace the `thumbnail.png` file by the thumbnail for your Asset Pack
4. From within your IDE select the Run Configuration "Publish New Mod"


## Support and Contact
To receive help and find other asset creators join the [Cities Skylines Modding Discord](https://discord.gg/UkKAfRqfCn). We have infrastructure with a knowledge base and a community of creators that can help you with your questions.