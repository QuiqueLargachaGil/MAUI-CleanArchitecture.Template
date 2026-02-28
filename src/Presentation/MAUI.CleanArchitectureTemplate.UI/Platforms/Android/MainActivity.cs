// --------------------------------------------------------------------------------------------------
// <copyright file="MainActivity.cs" company="YourCompany">
// Copyright (c) Enrique Largacha Gil.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------

using Android.App;
using Android.Content.PM;
using Android.OS;

namespace MAUI.CleanArchitectureTemplate;

/// <summary>
/// Android activity that serves as the main entry point for the application UI.
/// </summary>
/// <remarks>
/// This activity is launched by the Android operating system and hosts
/// the .NET MAUI application within an Android-compatible container.
///
/// The MAUI framework bridges the Android lifecycle with the shared
/// application layer configured in <see cref="MauiProgram"/>.
/// </remarks>
[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
}
