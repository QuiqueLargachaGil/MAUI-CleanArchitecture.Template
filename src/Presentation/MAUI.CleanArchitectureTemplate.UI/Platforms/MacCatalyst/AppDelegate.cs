// --------------------------------------------------------------------------------------------------
// <copyright file="AppDelegate.cs" company="YourCompany">
// Copyright (c) Enrique Largacha Gil.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------

using Foundation;

namespace MAUI.CleanArchitectureTemplate;

/// <summary>
/// MacCatalyst application delegate responsible for initializing the MAUI application.
/// </summary>
/// <remarks>
/// The MacCatalyst runtime instantiates this delegate during application startup.
/// It bridges the Apple platform lifecycle with the shared .NET MAUI application,
/// delegating construction to <see cref="MauiProgram"/>.
/// </remarks>
[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	/// <inheritdoc/>
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
