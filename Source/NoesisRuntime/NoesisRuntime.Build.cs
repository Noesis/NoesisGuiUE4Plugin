////////////////////////////////////////////////////////////////////////////////////////////////////
// NoesisGUI - http://www.noesisengine.com
// Copyright (c) 2013 Noesis Technologies S.L. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using UnrealBuildTool;
using System;

public class NoesisRuntime : ModuleRules
{
	public NoesisRuntime(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.NoSharedPCHs;
		PrivatePCHHeaderFile = "Private/NoesisRuntimePrivatePCH.h";

		// In modular builds we want the Interactivity functions
		// dllexported from this module and
		// dllimported from the other modules.
		// That's why we use PrivateDefinitions.
		if (Target.LinkType == TargetLinkType.Modular)
		{
			PrivateDefinitions.Add("NS_APP_INTERACTIVITY_API=NS_DLL_EXPORT");
		}

		PublicIncludePaths.AddRange(
			new string[] {
			}
			);

		PrivateIncludePaths.AddRange(
			new string[] {
				"NoesisRuntime/Private",
			}
			);

		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"CoreUObject",
				"Engine",
				"RHI",
				"RenderCore",
				"SlateCore",
				"InputCore",
				"UMG",
				"ApplicationCore",
				"Slate",
				"Projects",
				"FreeType2",
				"zlib",
				"UElibPNG"
			}
			);

		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"Noesis",
			}
			);

		if (Target.bBuildEditor == true)
		{
			PrivateDependencyModuleNames.AddRange(
				new string[]
				{
					"UnrealEd"
				}
				);
		}

		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				"AssetRegistry"
			}
			);
	}
}
