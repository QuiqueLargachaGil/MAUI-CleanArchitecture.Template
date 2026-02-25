// --------------------------------------------------------------------------------------------------
// <copyright file="AppDelegate.cs" company="YourCompany">
// Copyright (c) Enrique Largacha Gil.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------

using Foundation;

namespace MAUI.CleanArchitectureTemplate;

/// <summary>
/// iOS application delegate responsible for bootstrapping the .NET MAUI application.
/// </summary>
[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	/// <inheritdoc/>
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
