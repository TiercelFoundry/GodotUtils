# TiercelFoundry.GodotUtils

A collection of utilities assembled over time via gamedev. I make no guarantees about correctness, performance, or suitability for a project.

Includes C# Extension Methods for Godot4

To add this to your Nuget Sources:

1. Create a Github Personal Access Token that has the `read:packages` permission
2. Run the following command:
```dotnet nuget add source "https://nuget.pkg.github.com/tiercelfoundry/index.json" --name "Github" --username "GithubUserName" --password ACCESS_TOKEN --store-password-in-clear-text```
3. You can then view the available Tiercel Foundry Packages in NuGet by selecting "Github" from the Sources dropdown (in Visual Studio this is the top-right corner).

Note: You must be a member of the Tiercel Foundry organization (I think) to use this dependency