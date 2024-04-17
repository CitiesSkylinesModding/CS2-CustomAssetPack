## Getting Started:


1. Clone the repository OR Create a repository based on this ("Use this template", green button)
2. Open the repository with any IDE (Visual Studio, Rider)
   2A. If you are using an alternative Cities Skylines II installation path, enter it in the CustomAssetPack.csproj-file under "CustomManagedPath"
3. Put the assets you want to add into the "Resources/assets" folder in the solution explorer (subfolders allowed)
4. Edit the localization file "en-US.json" to include your assets. Otherwise, they will have missing localization
5. Add thumbnails to your assets. Make sure the icon path is set like this `coui://customassets/ExamplePack/CarProp.png`
6. Click on the Build Symbol (Hammer) at the top to build your project. This will load the assets into your local mods folder

Publish:
To publish your mod you have to do the following steps:
1. Edit Properties/PublishConfiguration.xml
2. Edit DisplayName, ShortDescription, LongDescription and Tag
3. Replace the thumbnail.png file by the thumbnail for your Asset Pack
4. From within your IDE select the Run Configuration "Publish New Mod"