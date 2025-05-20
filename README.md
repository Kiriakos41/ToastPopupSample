# .NET MAUI Toast Popup

A simple, reusable toast notification popup for .NET MAUI apps using the [Mopups](https://github.com/LouisDor/mopups) library.

## Features

- Smooth slide-down and slide-up animations  
- Auto-dismiss after a configurable delay (default 2 seconds)  
- Easily customizable position, duration, and style  
- Simple helper method to show toast from anywhere in your app  
- No platform-specific code needed — works cross-platform  

## Getting Started

### Prerequisites

- .NET MAUI project  
- [Mopups](https://github.com/LouisDor/mopups) installed via NuGet

### Installation

Add Mopups to your project:

```bash
dotnet add package Mopups

### Usage

1. Add the `ToastPopup` page (or your popup class) to your project.

2. Call the toast helper method anywhere to show a toast:

<pre> ``` await ToastPopup.ShowAsync("Your message here"); ``` </pre>
