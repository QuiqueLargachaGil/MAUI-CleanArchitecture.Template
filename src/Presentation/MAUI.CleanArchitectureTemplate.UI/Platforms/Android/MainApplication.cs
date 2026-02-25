// --------------------------------------------------------------------------------------------------
// <copyright file="MainApplication.cs" company="YourCompany">
// Copyright (c) Enrique Largacha Gil.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------

using Android.App;
using Android.Runtime;

namespace MAUI.CleanArchitectureTemplate;

/// <summary>
/// Android-specific application entry point.
/// Integrates the .NET MAUI application with the Android runtime.
/// </summary>
[Application]
public class MainApplication : MauiApplication
{
	/// <summary>
	/// Initializes a new instance of the <see cref="MainApplication"/> class.
	/// </summary>
	/// <param name="handle">A pointer to the unmanaged Android instance.</param>
	/// <param name="ownership">Specifies ownership of the JNI handle.</param>
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
	}

	/// <inheritdoc/>
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
