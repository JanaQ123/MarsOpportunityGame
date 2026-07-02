# Marsyaat — VR Interaction and Comfort

Owner: Tahleel (UI/UX), with Jana. VR isn't just a big screen strapped to your face, and comfort here is a correctness thing, not a polish thing: if the game makes people sick, nothing else we do matters. This doc is about how the player moves, how they touch things, and where we put the UI.

## Comfort first, always

A few principles we don't bend on. We never take the camera away from the player, meaning no forced head movement, no camera shake, and no cutscenes that swing the view around. We hold framerate above everything else (the budget's in doc 02), because dropped frames are the number one thing that makes people queasy. We keep a stable horizon and some grounded reference points so the inner ear and the eyes agree with each other. And every comfort feature is a toggle, with the default set to the most comfortable option.

## Getting around

The player experiences the world as the rover, and since the rover moves slowly, we can lean into the comfortable options. The primary mode is teleport/waypoint movement between rover stops (through XRI's locomotion), which sidesteps the continuous-motion nausea trigger entirely. We can offer a smooth drive mode for people who tolerate it, but it should come with a strong vignette (tunneling) while moving, and snap-turn by default, with smooth-turn as an opt-in. One thing worth prototyping early: a seated cockpit framing. If the player can see a stable rover chassis around them, self-motion feels much more grounded and nausea drops, which is a great fit for a rover game specifically.

## How interaction works

We build on the XR Interaction Toolkit's interactors. For things nearby, use direct/poke interaction; for things far away, use a ray. Instruments like the camera and scanner are grab-or-aim interactables, and scanning is a hold action with clear haptic and visual feedback. Buttons and toggles are all world-space UI driven by XRI's UI interaction, and where it makes sense we support both ray-click and poke. Always give feedback of some kind: a hover highlight, a selection tint, a little haptic buzz on anything meaningful.

## Where UI sits, and how deep

The research tab gave us a comfortable depth window, and it's worth turning those numbers into firm rules. Don't put interactive UI closer than about 0.5 m; any closer and it strains the eyes (vergence) and is just uncomfortable to focus on. The sweet spot for primary, readable UI is roughly 0.5 m to 2 m, and stereo depth still reads well out to around 10 m. Past about 10 m the sense of 3D starts to fade, and past 20 m it's basically flat, so only use those far distances for background and world elements, never for UI the player has to read or touch. Anchor the persistent HUD (power, sol, comms status) to the world or to the rover frame, not rigidly to the head; head-locked UI is uncomfortable and breaks immersion, so if a HUD really has to travel with the player, use a soft, lazy billboard follow instead.

One caveat worth flagging: the original doc attributes those specific meter thresholds to Vincent McCurley. They're good working guidelines and they're rooted in how binocular depth weakens with distance, but treat them as design heuristics to check in-headset with the team, not as hard physiological constants. Test with real players and adjust.

## Making text readable

Use large, high-contrast type (TextMeshPro). Text that reads fine on a monitor is often a blurry mess in a headset. Keep the essential text in the central field of view so nobody has to crane their neck, and avoid pure white on pure black, since that smears on OLED; slightly toned values look better.

## Sound and presence

Spatialize the audio for wind, the motor, and the instruments; it reinforces both presence and direction. Keep the whole soundscape sparse and quiet to match the lonely tone, silence is genuinely a feature on Mars.

## Testing without a headset

Not everyone has a Quest, so use the XR Interaction Simulator (it ships with XRI) to build and test interactions on a desktop. That said, comfort and legibility have to be checked in a real headset before we call anything done, because the simulator can't tell you whether something makes you sick.

## Comfort settings we want in the shipping build

Locomotion (teleport or smooth, with a vignette intensity slider), turning (snap by default or smooth, with angle options), a vignette on/off plus intensity, seated/standing height calibration, dominant-hand swap, a UI distance and scale slider, and subtitles with text-size options.
