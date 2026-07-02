# Marsyaat — Technical Design

Owner: Osama, with input from the whole team. This one is about HOW we build the thing. The goal is that a new person can read it, get the project running, understand roughly how the code is laid out, and know where their new code is supposed to go.

## Platform and engine

We're on Unity 6 (the 6000.x LTS line). Everyone uses the exact version pinned in ProjectSettings and noted in doc 06, so please don't mix major editor versions, it causes needless churn.

For rendering we use URP (the Universal Render Pipeline). The old Built-in pipeline is on its way out (deprecated from Unity 6.5 onward) and we're not supporting it, and URP is the recommended choice for standalone VR performance anyway. For XR we use the OpenXR plug-in through Unity's XR Plug-in Management, plus the XR Interaction Toolkit (XRI) 3.5+ for interactors, locomotion, and UI; note XRI 3.5 needs Unity 6000.0 or newer. Our main device target is the standalone Meta Quest, so we build for Android; a PCVR path over OpenXR would be nice but it's not what we're shipping. And importantly, anyone can test without a headset using the XR Interaction Simulator that comes with XRI, which matters because not everyone on the team has a Quest.

## Why we're not using DOTS/ECS

The workshop this all came out of was framed around converting a game to DOTS, so it's worth writing down plainly why we're deliberately going the other way and sticking with classic Unity (GameObjects and MonoBehaviours plus ScriptableObjects).

The short version: this game just doesn't have the problem DOTS solves. We've got one rover, a handful of instruments, and a modest pile of rocks. DOTS earns its keep when you've got tens of thousands of entities, and we don't. On top of that it has a steep learning curve, and we're an early-career team, so clarity and speed matter to us more than squeezing out micro-optimizations. Most VR tutorials, XRI, and Timeline all assume GameObjects too, so fighting that current would cost more than it saves.

Where Jobs/Burst could genuinely help down the line: something like a big dust/particle simulation or a lot of terrain boulders. If profiling ever shows a real bottleneck there, the plan is to carve just that piece out into a Jobs/Burst system, not to convert the whole game.

## How the code is organized

We keep it light and readable, in layers. Core holds game state, the sol/time model, and saving; it's plain C# and ScriptableObjects with no scene dependencies. Systems are the MonoBehaviour managers (Power, Comms, Weather, Objectives, Scanning) that read and write Core state and raise events, each with one job. Interaction is the VR layer, the XRI interactors and input actions, kept thin so it calls into Systems rather than holding any game rules itself. Presentation is UI, VFX, and audio, and it only ever subscribes to events; it's never the source of truth.

Systems talk to each other through events (plain C# events or ScriptableObject event channels) so they stay decoupled. Try to avoid a pile of singletons; one GameContext holder is fine.

## The systems, roughly

TimeSystem tracks the sol and time of day and runs the day/night cycle and the compressed timeline. PowerSystem handles generation, drain, hibernation, and the soft-reset threshold. WeatherSystem owns dust level, cleaning events, and storms, including the scripted 2007 and 2018 story storms. CommsSystem manages the transmission queue, orbiter windows, delay timers, and delivering Earth's replies as discovery cards. ScanSystem handles the aim/hold/quality evaluation for the instruments. ObjectiveSystem tracks the current objective, checks completion, and advances the timeline. SaveSystem writes the Core state to JSON and is resumable per sol.

## Content as data

Missions, discovery cards, rock definitions, and instrument stats all live as ScriptableObjects, so the designer and researcher can author content without touching code. The historical events (date, sol, the real conclusion, a source link) are authored as data straight from doc 04.

## Assembly definitions

We split Core, Systems, Interaction, and Presentation with .asmdef files. That keeps compile times sane and enforces the dependency direction, which is Presentation to Systems to Core, never the other way.

## Packages

Everything is pinned in Packages/manifest.json (which is committed): URP, XR Plug-in Management, OpenXR, XR Interaction Toolkit, Input System, TextMeshPro, and optionally Addressables if we end up streaming big environments. Adding a package should come in as a PR with a one-line reason, not a quiet change nobody noticed.

## Performance budget

In VR a stable framerate isn't a nice-to-have, it's a hard requirement, because dropped frames make people sick. So: hold at least 72 Hz on Quest (90 is better) and never dip. Keep draw calls down with the URP SRP Batcher and static batching, bake your lighting, and don't put real-time shadows on everything. Use single-pass instanced stereo rendering. And profile early and often with the Unity Profiler and the memory tools; don't leave it all to the end.

## Where things live in Assets

The full asset layout is in doc 05. Code sits under Assets/_Project/Scripts, split by the layers above. The leading underscore just keeps our folder pinned to the top of the Project window, away from the imported packages.

## Builds and CI

To start, we build manually to the Quest via the Android target. A nice later improvement would be automated Unity builds and tests through GitHub Actions (game-ci); that's optional and tracked in doc 07.
