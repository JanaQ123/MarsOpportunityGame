# Marsyaat (marseeyat-vr)

A VR game about NASA's Opportunity Mars rover, built in Unity 6 with the XR Interaction Toolkit. You play as the rover, scanning rocks, taking photos, and relaying what you find back to Earth while nursing your power, waiting out the signal delay, and surviving dust storms. It follows Opportunity's real 15-year mission, and everything you "discover" actually happened.

Made by Team Marsyaat.

## What it is

A slow, quiet, historically grounded VR experience. The whole idea is that a good space game turns a real constraint (power, latency, dust) into a real choice for the player. The full design lives in the docs below.

## Tech

Unity 6 (6000.x LTS) on URP, with OpenXR and the XR Interaction Toolkit for VR. We target the standalone Meta Quest (Android build). You don't need a headset to develop, since the XR Interaction Simulator ships with XRI. Package versions are pinned in Packages/manifest.json.

## Docs (read before you build)

The knowledge base is in the docs folder. If you're new to Git, start with doc 06. Otherwise: doc 01 is what the game is (the GDD), doc 02 is how it's built and why we're not using DOTS, doc 03 covers VR locomotion, interaction, UI and comfort, doc 04 is the story beats and fact-checking, doc 05 is the art and asset pipeline, doc 06 is Git and GitHub for beginners, and doc 07 is the roadmap and the open decisions.

## Getting started (developers)

Install the pinned Unity 6 editor with Android build support, and clone this repo with Git LFS installed (run git lfs install first). Open it in Unity and let it pull the packages from the manifest, then set up XR Plug-in Management (OpenXR) for your target device. Read docs 02 and 03 before you start writing gameplay or VR code.

## How we work

We protect main, so nobody pushes to it directly. Everything comes in as a Pull Request from a short-lived branch (feature/..., art/..., ui/..., or fix/...), which keeps main always working and puts a reviewer on every change. If you've never used Git, read doc 06 first; it's written for you, with copy-paste steps. The short version of the rules is in CONTRIBUTING.md.

## Team

Tahleel Khalid leads the team and handles game design and UI/UX (tahleelkhalid@gmail.com). Osama Alawneh is the space researcher and Unity developer. Sara Dweekat is the 3D artist. Jana Qudah is an artist and 3D game developer.

## Credits and sources

Inspired by NASA/JPL's Opportunity (MER-B) rover. Historical facts have to be sourced (see doc 04). NASA imagery is reference only, so check the usage terms before shipping any real image or texture. Placeholder art may come from Kenney.nl (CC0).

## Status

Early setup. Milestones are in doc 07. The first real goal is a comfortable, playable vertical slice of one act in VR.
