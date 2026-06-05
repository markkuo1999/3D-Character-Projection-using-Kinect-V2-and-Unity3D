# 3D Character Projection using Kinect V2 and Unity3D

Kinect V2 captures body joints in real time and drives a 3D character on a concert stage built in Unity.

![Concert Scene](https://i.ibb.co/7RLwQpr/image.jpg)

## Requirements

- Windows 10/11 (64-bit)
- [Unity 2020.1.6f1](https://unity.com/releases/editor/whats-new/2020.1.6f1)
- [Kinect for Windows SDK 2.0](https://www.microsoft.com/en-us/download/details.aspx?id=44561)
- Xbox One Kinect + USB 3.0 adapter

## Quick Start

1. Clone this repository.
2. Open `Kinect_V2_Projection_2/` in Unity Hub.
3. Open `Assets/Scenes/SampleScene.unity`.
4. Connect Kinect V2 and press Play.

See [Kinect_V2_Projection_2/README.md](Kinect_V2_Projection_2/README.md) for project layout and troubleshooting.

## Project Structure

```
Kinect_V2_Projection_2/
├── Assets/
│   ├── Scenes/SampleScene.unity      Main concert scene
│   ├── Scripts/Stage/                Custom stage scripts
│   ├── K2Examples/                   Kinect SDK integration
│   └── Supercyan Character Pack...   Avatar model
├── NuiDatabase/                      Kinect runtime data
└── ProjectSettings/
```

## Custom Scripts

| Script | Purpose |
|--------|---------|
| `Change_Color.cs` | Animates spotlight colors |
| `Rotation.cs` | Random rotation for stage props |

Kinect motion mapping uses `KinectManager` and `AvatarController` from K2Examples.

## Notes

- `Library/` and `Temp/` are generated locally and not tracked in git.
- Background music video is optional and not included in the repository.
