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
/// Provides the application entry point.
/// </summary>
public class Program
{
	/// <summary>
	/// The main entry point of the application.
	/// </summary>
	/// <param name="args">
	/// Command-line arguments passed to the application.
	/// </param>
	private static void Main(string[] args)
	{
		// if you want to use a different Application Delegate class from "AppDelegate"
		// you can specify it here.
		UIApplication.Main(args, null, typeof(AppDelegate));
	}
}
