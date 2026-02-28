// --------------------------------------------------------------------------------------------------
// <copyright file="MauiProgram.cs" company="YourCompany">
// Copyright (c) Enrique Largacha Gil.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------

using Microsoft.Extensions.Logging;

namespace MAUI.CleanArchitectureTemplate;

/// <summary>
/// Provides the application bootstrap configuration.
/// </summary>
/// <remarks>
/// <see cref="MauiProgram"/> centralizes application startup configuration,
/// including dependency injection, fonts, logging, and framework services.
///
/// This class is invoked by each platform-specific entry point
/// (e.g., Android <c>MainApplication</c>, iOS/MacCatalyst <c>AppDelegate</c>)
/// to build and configure the shared <see cref="MauiApp"/> instance.
///
/// It acts as the single source of truth for application composition.
/// </remarks>
public static class MauiProgram
{
	/// <summary>
	/// Creates and configures the <see cref="MauiApp"/> instance.
	/// </summary>
	/// <returns>The configured <see cref="MauiApp"/>.</returns>
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
