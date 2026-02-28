# MAUI-CleanArchitecture.Template
A flexible starter template for building .NET MAUI applications, designed to support different architectural styles depending on project complexity and long-term goals.

This repository is not limited to a single rigid structure. Instead, it provides multiple branches exploring different approaches, from lightweight MVVM setups to more structured Clean Architecture implementations.

The goal is simple:
Bootstrap new MAUI projects quickly and consistently, choosing the structure that best fits your needs.

## 🎯 Purpose

When starting a new MAUI project, one of the first decisions is architectural:

- Should this be a small app with minimal structure?
- Should it follow Clean Architecture?
- Should it use Shell?
- Should it rely on CommunityToolkit?
- Should navigation be abstracted?

This repository centralizes those decisions into different branches so you can:
1. Clone the repository
2. Checkout the branch that matches your needs
3. Start building immediately

## 🌿 Branch Strategy

Each branch represents a different architectural approach or feature combination.

Examples:
- basic-mvvm → Minimal structure, ideal for small apps
- clean-architecture → Layered solution following Clean Architecture principles
- with-communitytoolkit → Uses CommunityToolkit MVVM
- without-communitytoolkit → Manual MVVM implementation
- with-shell → Navigation using MAUI Shell
- without-shell → Custom navigation approach

Branches may evolve over time as patterns mature.

The `master` branch represents the most stable and recommended structure.

## 🏗 Architectural Philosophy

This repository explores two main directions:

### 1️⃣ Lightweight MVVM
- Simple project structure
- Minimal abstractions
- Fast setup
- Ideal for small or short-lived applications

### 2️⃣ Clean Architecture
- Clear separation of concerns
- Domain and Application layers isolated
- Infrastructure and Presentation separated
- Test-friendly design
- Scalable for long-term projects

You can decide which direction fits your project before you even write your first feature.

## 🔄 Why Multiple Variants?

There is no one-size-fits-all architecture.

A small internal app does not need the same structure as a long-term production system.

Instead of enforcing a single opinionated approach, this repository embraces flexibility while maintaining consistency.

## 🚀 How to Use
```
git clone https://github.com/your-user/MAUI-CleanArchitecture.Template.git
cd MAUI-CleanArchitecture.Template
git checkout <desired-branch>
```

Rename the solution, update namespaces, and start building.

### 🧪 Future Improvements
- More architectural variants
- Optional feature toggles
- Improved navigation abstractions
- Enhanced test scaffolding
- Additional documentation per branch

## 📌 Philosophy

Architecture should serve the project — not the other way around.

This template aims to provide structured starting points without locking you into a single rigid pattern.
