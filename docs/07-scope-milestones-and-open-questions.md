# Marsyaat — Scope, Milestones, and Open Questions

Owner: Tahleel. This is our roadmap plus the running list of decisions we still owe ourselves. Update it whenever we answer a question or a milestone shifts.

## How we think about scope

We're four people with a slot inside a 14-day bootcamp, so the real enemy here is over-scoping. The plan is to build the smallest version that proves the idea, then grow it, because one polished, comfortable act beats five broken ones every time.

Our Minimum Viable Experience is one complete act (Act 2, the water discovery) playable in VR, with the full core loop working end to end: drive, scan, photograph, send, wait, receive a real discovery card, plus working power and comfort settings. If that's all we finish, we still have a real game.

## Milestones

M0 is setup: the repo, a project skeleton, Unity 6 with URP and XR configured, and a grey-box scene you can stand in and look around comfortably in a headset. M1 is the core loop in greybox: drive to a rock, scan, photograph, send, get a reply, all with placeholder art, and power that drains and regenerates. M2 is one vertical slice of Act 2: real-ish Mars ground, the rover, a discovery card carrying a true fact and a source, and the full comfort settings. M3 is the content pass: the remaining acts as data (discovery cards, objectives), the storm-and-hibernation mechanic, and the Mini-TES loss gate. M4 is polish: audio, VFX within budget, a UI legibility pass, and performance nailed to a steady 72+ Hz. M5 is the presentation build: a stable demo for the pitch, one act minimum.

## Who owns what

Tahleel is team leader, game designer, and UI/UX, and owns the GDD and this roadmap. Osama is the space researcher and Unity developer, and owns the technical design and accuracy. Sara is the 3D artist, owning the environment and rover art. Jana is artist and 3D game developer, owning props and UI art and helping on implementation.

## Open questions (decide, then record the answer here)

These come from the source doc or fall out of the design, and each needs an owner and a decision. What visual style do we land on, realistic, semi-stylized, or stylized (Sara's call; currently leaning semi-stylized realism per doc 05)? Is traversal free-roam driving or guided waypoint stops (Tahleel's call; comfort favors waypoints, decide after the M1 playtest)? What's the time-compression ratio for the communication delay, meaning how many real seconds stand in for the minutes of light delay (Osama's call)? How much of the instrument suite do we actually simulate versus abstract into a single scan action (Osama and Tahleel)? What's the locomotion default on the shipping build, teleport only or smooth-with-vignette offered too (Tahleel's call, after headset testing)? Do we localize, for example Arabic and English, and if so we plan text as data from the start (Tahleel's call)? Which Quest models must run well (Osama's call)? And is optional CI (GitHub Actions / game-ci) worth it for this timeline (Osama's call)?

## Explicitly out of scope, for now

To protect the timeline, these are parked unless the MVE lands early: multiplayer or shared VR, full free-roam of the entire 45 km traverse, hand-tracking (controllers only for the first version), a DOTS/ECS conversion (doc 02 explains why), and photorealistic rendering.

## How we track work

Day-to-day tasks live in GitHub Issues and the Project board, not in this file. This file is for the big-picture scope and the decisions. When one of the open questions above gets answered, write the decision and the date right here so we don't end up re-arguing it later.
