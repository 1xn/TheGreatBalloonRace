// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class TheGreatBalloonRace : ModuleRules
{
	public TheGreatBalloonRace(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "Slate", "SlateCore" });

        PrivateDependencyModuleNames.AddRange(new string[] { "HeadMountedDisplay", "SteamVR" });

        PublicIncludePaths.Add("C:/Users/Public/Public Projects/TheGreatBalloonRace/Source/TheGreatBalloonRace/VRBase");
        PublicIncludePaths.Add("C:/Users/Public/Documents/Public Projects/TheGreatBalloonRace/Source/TheGreatBalloonRace/VRBase");

        // Uncomment if you are using Slate UI
        // PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

        // Uncomment if you are using online features
        // PrivateDependencyModuleNames.Add("OnlineSubsystem");

        // To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
    }
}