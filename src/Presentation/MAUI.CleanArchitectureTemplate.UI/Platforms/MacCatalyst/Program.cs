// --------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="YourCompany">
// Copyright (c) Enrique Largacha Gil.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------

using ObjCRuntime;
using UIKit;

namespace MAUI.CleanArchitectureTemplate;

/// <summary>
/// MacCatalyst entry point for the application.
/// </summary>
/// <remarks>
/// The <c>Program</c> class is the main entry point of the MacCatalyst project.
/// The operating system calls <c>Main</c> when launching the app, which in turn
/// delegates application startup to the <see cref="AppDelegate"/> class.
///
/// <para>
/// This class exists only to bootstrap the platform-specific runtime.
/// All shared application logic is executed via <see cref="MauiProgram"/>
/// and <see cref="App"/>.
/// </para>
/// </remarks>
public class Program
{
	/// <summary>
	/// Initializes and launches the application.
	/// </summary>
	/// <param name="args">Command-line arguments passed by the OS.</param>
	private static void Main(string[] args)
	{
		// if you want to use a different Application Delegate class from "AppDelegate"
		// you can specify it here.
		UIApplication.Main(args, null, typeof(AppDelegate));
	}
}
