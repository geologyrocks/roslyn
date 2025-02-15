﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Options;

namespace Microsoft.CodeAnalysis.Structure;

internal static class BlockStructureOptionsStorage
{
    public static BlockStructureOptions GetBlockStructureOptions(this IGlobalOptionService globalOptions, Project project)
        => GetBlockStructureOptions(globalOptions, project.Language, isMetadataAsSource: project.Solution.WorkspaceKind == WorkspaceKind.MetadataAsSource);

    public static BlockStructureOptions GetBlockStructureOptions(this IGlobalOptionService globalOptions, string language, bool isMetadataAsSource)
        => new()
        {
            ShowBlockStructureGuidesForCommentsAndPreprocessorRegions = globalOptions.GetOption(ShowBlockStructureGuidesForCommentsAndPreprocessorRegions, language),
            ShowBlockStructureGuidesForDeclarationLevelConstructs = globalOptions.GetOption(ShowBlockStructureGuidesForDeclarationLevelConstructs, language),
            ShowBlockStructureGuidesForCodeLevelConstructs = globalOptions.GetOption(ShowBlockStructureGuidesForCodeLevelConstructs, language),
            ShowOutliningForCommentsAndPreprocessorRegions = globalOptions.GetOption(ShowOutliningForCommentsAndPreprocessorRegions, language),
            ShowOutliningForDeclarationLevelConstructs = globalOptions.GetOption(ShowOutliningForDeclarationLevelConstructs, language),
            ShowOutliningForCodeLevelConstructs = globalOptions.GetOption(ShowOutliningForCodeLevelConstructs, language),
            CollapseRegionsWhenFirstOpened = globalOptions.GetOption(CollapseRegionsWhenFirstOpened, language),
            CollapseImportsWhenFirstOpened = globalOptions.GetOption(CollapseImportsWhenFirstOpened, language),
            CollapseMetadataImplementationsWhenFirstOpened = globalOptions.GetOption(CollapseSourceLinkEmbeddedDecompiledFilesWhenFirstOpened, language),
            CollapseEmptyMetadataImplementationsWhenFirstOpened = globalOptions.GetOption(CollapseMetadataSignatureFilesWhenFirstOpened, language),
            CollapseRegionsWhenCollapsingToDefinitions = globalOptions.GetOption(CollapseRegionsWhenCollapsingToDefinitions, language),
            MaximumBannerLength = globalOptions.GetOption(MaximumBannerLength, language),
            IsMetadataAsSource = isMetadataAsSource,
        };

    public static readonly PerLanguageOption2<bool> ShowBlockStructureGuidesForCommentsAndPreprocessorRegions = new(
        "BlockStructureOptions_ShowBlockStructureGuidesForCommentsAndPreprocessorRegions", BlockStructureOptions.Default.ShowBlockStructureGuidesForCommentsAndPreprocessorRegions);

    public static readonly PerLanguageOption2<bool> ShowBlockStructureGuidesForDeclarationLevelConstructs = new(
        "BlockStructureOptions_ShowBlockStructureGuidesForDeclarationLevelConstructs", BlockStructureOptions.Default.ShowBlockStructureGuidesForDeclarationLevelConstructs);

    public static readonly PerLanguageOption2<bool> ShowBlockStructureGuidesForCodeLevelConstructs = new(
        "BlockStructureOptions_ShowBlockStructureGuidesForCodeLevelConstructs", BlockStructureOptions.Default.ShowBlockStructureGuidesForCodeLevelConstructs);

    public static readonly PerLanguageOption2<bool> ShowOutliningForCommentsAndPreprocessorRegions = new(
        "BlockStructureOptions_ShowOutliningForCommentsAndPreprocessorRegions", BlockStructureOptions.Default.ShowOutliningForCommentsAndPreprocessorRegions);

    public static readonly PerLanguageOption2<bool> ShowOutliningForDeclarationLevelConstructs = new(
        "BlockStructureOptions_ShowOutliningForDeclarationLevelConstructs", BlockStructureOptions.Default.ShowOutliningForDeclarationLevelConstructs);

    public static readonly PerLanguageOption2<bool> ShowOutliningForCodeLevelConstructs = new(
        "BlockStructureOptions_ShowOutliningForCodeLevelConstructs", BlockStructureOptions.Default.ShowOutliningForCodeLevelConstructs);

    public static readonly PerLanguageOption2<bool> CollapseRegionsWhenFirstOpened = new(
        "BlockStructureOptions_CollapseRegionsWhenFirstOpened", BlockStructureOptions.Default.CollapseRegionsWhenFirstOpened);

    public static readonly PerLanguageOption2<bool> CollapseImportsWhenFirstOpened = new(
        "BlockStructureOptions_CollapseImportsWhenFirstOpened", BlockStructureOptions.Default.CollapseImportsWhenFirstOpened);

    public static readonly PerLanguageOption2<bool> CollapseSourceLinkEmbeddedDecompiledFilesWhenFirstOpened = new(
        "BlockStructureOptions_CollapseMetadataImplementationsWhenFirstOpened", BlockStructureOptions.Default.CollapseMetadataImplementationsWhenFirstOpened);

    public static readonly PerLanguageOption2<bool> CollapseMetadataSignatureFilesWhenFirstOpened = new(
        "BlockStructureOptions_CollapseEmptyMetadataImplementationsWhenFirstOpened", BlockStructureOptions.Default.CollapseEmptyMetadataImplementationsWhenFirstOpened);

    public static readonly PerLanguageOption2<bool> CollapseRegionsWhenCollapsingToDefinitions = new(
        "BlockStructureOptions_CollapseRegionsWhenCollapsingToDefinitions", BlockStructureOptions.Default.CollapseRegionsWhenCollapsingToDefinitions);

    public static readonly PerLanguageOption2<int> MaximumBannerLength = new(
        "BlockStructureOptions_MaximumBannerLength", BlockStructureOptions.Default.MaximumBannerLength);
}
