# GUID To Asset Path Tool

A lightweight Unity Editor Window for converting asset GUIDs into their corresponding asset paths.

## Features

- Enter any Unity asset GUID and retrieve its asset path.
- Results are displayed in the Editor window and logged to the Console.
- Simple, standalone package compatible with Unity 2021.3 and above.

## Requirements

- Unity **2021.3** or later.
- Unity Editor (this tool runs in the Editor only).

## Installation

Install via Unity Package Manager using Git:

1. Open **Window > Package Manager** in your Unity project.
2. Click the **+** button and select **Add package from Git URL...**
3. Enter the Git URL for this package, including the tag (replace with your details):
   ```
   https://github.com/yourusername/com.yourname.guidtoassetpath.git#v1.0.0
   ```
4. Click **Add**. The package will be downloaded and available immediately.

## Usage

1. In the Unity Editor, navigate to **RiverSoft > Tools > GUIDToAssetPath**.
2. In the window that appears, paste or type the GUID of an asset.
3. Click **Get Asset Path**. The path will display below and a log entry will appear in the Console.
