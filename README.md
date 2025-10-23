# 🖐️ Meta XR Hand Grab Pose Tutorial (Unity)

A Unity project demonstrating how to create and customize **Hand Grab Poses** using the **Meta XR Interaction SDK**.  
This project follows the official Meta documentation tutorial for recording, adjusting, and mirroring hand grab poses to make VR interactions feel natural and responsive.

---

## 🎮 Project Overview

This Unity scene shows how to:
- Record a **custom hand grab pose**.
- Adjust finger positions, scaling, and constraints.
- Add **grab surfaces** for grabbing from multiple angles.
- Mirror hand poses for both **left and right hands**.
- Test realistic hand interactions in VR using **Meta Quest**.

---

## 🧰 Tools & Technologies

| Tool / Package | Version | Purpose |
|----------------|----------|----------|
| **Unity** | 6.2 LTS | Game engine |
| **Meta XR All-in-One SDK** | v65 | VR input, hand tracking, grab system |
| **XR Interaction Toolkit** | 3.2.1 | Extended VR interactions |
| **URP (Universal Render Pipeline)** | — | Rendering & lighting |
| **Visual Studio 2022** | — | C# scripting |

---

## 🚀 Setup & Usage

 **Install Unity 6.2 LTS** (or compatible version).

Open the project in Unity Hub.

Import the Meta XR All-in-One SDK (v65).

Open the HandGrabPoseScene.unity scene.

Press Play (in Editor) or Build for your Meta Quest device.

🖐️ Features
✅ Customizable hand poses (Free / Constrained / Locked fingers)

✅ Automatic scaling for different hand sizes (0.7x to 1.3x)

✅ Multi-angle grabbing using Sphere Grab Surface

✅ Left and right hand pose mirroring

✅ Physics-enabled grabbable objects

🧩 How It Works
Each HandGrabPose defines finger positions and rotation relative to the object.

The HandGrabInteractable manages how the object reacts to grabs.

Grab Surfaces let users grab from different angles for natural interactions.

Mirroring creates right-hand equivalents automatically.

🧠 Learning Goals
This project helps you understand:

The Interaction SDK workflow for VR hands.

How to record and customize grab poses.

The relationship between hand tracking, physics, and user interaction.



<img width="777" height="393" alt="image" src="https://github.com/user-attachments/assets/212239e9-b8bb-441f-93fc-a818fc6ca75c" />

