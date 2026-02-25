// --------------------------------------------------------------------------------------------------
// <copyright file="App.xaml.cs" company="YourCompany">
// Copyright (c) Enrique Largacha Gil.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------

using Microsoft.Extensions.DependencyInjection;

namespace MAUI.CleanArchitectureTemplate;

/// <summary>
/// Represents the root application class.
/// Responsible for application lifecycle initialization and window creation.
/// </summary>
/// <remarks>
/// In a .NET MAUI application, <see cref="App"/> is instantiated by the platform-specific
/// bootstrap process. Each platform (Android, iOS, MacCatalyst, Windows) initializes
/// the runtime and delegates application construction to <see cref="MauiProgram"/>.
/// The resulting <see cref="MauiApp"/> instance ultimately creates this class
/// as the logical entry point of the shared application layer.
/// </remarks>
public partial class App : Application
{
	/// <summary>
	/// Initializes a new instance of the <see cref="App"/> class.
	/// </summary>
	public App()
	{
		InitializeComponent();
	}

	/// <inheritdoc/>
	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new AppShell());
	}
}
