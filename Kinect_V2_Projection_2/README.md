# Kinect V2 Projection 2.0

Unity project for real-time Kinect V2 body tracking on a 3D concert stage.

## Open the Project

1. Install Unity **2020.1.6f1**.
2. In Unity Hub, choose **Add project from disk**.
3. Select this folder (`Kinect_V2_Projection_2`).
4. Open `Assets/Scenes/SampleScene.unity`.
5. Press Play with Kinect V2 connected.

If the Hierarchy looks empty, make sure `SampleScene.unity` is open (not an untitled new scene).

## Hardware Setup

1. Install [Kinect for Windows SDK 2.0](https://www.microsoft.com/en-us/download/details.aspx?id=44561).
2. Connect Kinect V2 to a USB 3.0 port.
3. Stand 0.5–4 meters in front of the sensor.

## Scene Overview

`SampleScene` contains:

- `KinectController` — `KinectManager`, gesture listener, and sensor settings
- `free_male_1` avatar — driven by `AvatarController`
- Stage geometry — planes, cubes, spot lights, optional background video plane

## Custom Code

Project-specific scripts live in `Assets/Scripts/Stage/`:

- `Change_Color.cs` — spotlight color animation
- `Rotation.cs` — prop rotation

Do not refactor `Assets/K2Examples/` unless you know the Kinect SDK internals.

## Troubleshooting

| Problem | Check |
|---------|-------|
| Empty scene on open | Open `Assets/Scenes/SampleScene.unity` |
| Kinect not detected | SDK installed, USB 3.0, sensor powered |
| Character not moving | `KinectController` enabled, user in sensor range |
| Missing background video | Video file is optional and not in git |

## Build

Target platform: **Windows x64 Standalone**.

Build settings already include `SampleScene` as the startup scene.
