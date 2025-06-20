// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ShooterTestsRuntime : ModuleRules
{
	public ShooterTestsRuntime(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"LyraGame",
				"GameplayTags",
				"GameplayAbilities",
				"ModularGameplay",
				"AsyncMessageSystem"
				// ... add other public dependencies that you statically link with here ...
			}
		);
		
		//PrivateIncludePathModuleNames.AddRange(new string[]{"AsyncMessageSystem"});

		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"InputCore",
				"EnhancedInput",
				"CQTest",
				"CQTestEnhancedInput",
				// ... add private dependencies that you statically link with here ...	
			}
		);

		if (Target.bBuildEditor)
		{
			PrivateDependencyModuleNames.AddRange(
				new string[] {
					"EngineSettings",
					"LevelEditor",
					"UnrealEd"
			});
		}
	}
}
