# Marsyaat — Game Design Document

Owner: Tahleel (design + UI/UX). This is our shared reference for what the game actually is. If something isn't written down here, treat it as not decided yet. When you add something, try to be concrete enough that Osama, Sara, Jana and I would all picture the same thing reading it.

## The pitch, in one breath

You're NASA's Opportunity rover on Mars. The game is a compressed retelling of the real 15-year mission: you drive around, scan rocks, take photos, and send your findings back to Earth, all while nursing your battery, waiting out the signal delay, and surviving dust storms. It's slow and quiet on purpose. The whole point is doing real science under real constraints, not action.

## What we keep coming back to

Three ideas settle most of our arguments. If an idea doesn't serve at least one of them, we probably shouldn't build it.

The constraints ARE the game. Power, signal delay, temperature, dust: these aren't set dressing, they're the actual decisions the player makes. That's the thing the workshop slide was getting at, that a good space game turns a real limitation into a real choice.

The truth is the reward. Everything the player "discovers" actually happened. The payoff is emotional because it's real, from the ancient water and the salty sea all the way to the final storm and that last message home.

Presence beats spectacle. This is VR. Feeling small, feeling the scale and the silence of being one little machine on a huge empty planet, matters way more than flashy effects.

## Who the player is

Not a hero, not a soldier. You're a patient, fragile little robot that a team back on Earth is keeping alive. The tone should stay quiet and a bit lonely, awed early on and bittersweet by the end.

## The core loop

A single mission cycle goes like this: Earth sends you an objective (say, go sample a particular rock). You drive there, which is deliberately slow and eats power. You investigate by aiming an instrument, holding to scan, then taking a photo. You package the data and send it, and a transmission timer runs based on distance and conditions (see the comms section). Then you wait for the reply and manage your power while you do. Earth answers with the real scientific conclusion, shown as a little discovery card with the actual date and sol. The objective closes, the timeline moves forward, and a new objective comes in.

It's intentionally low-twitch. The tension is supposed to come from the resource math and the weather, not from reflexes.

## Power, and the day/night rhythm

Opportunity ran on solar power, so power is our central resource. It builds back up while the sun's up and the panels are clean, and it drains when you drive, scan, transmit, or run the heaters. At night there's no generation at all, so you have to keep enough in reserve to survive the cold; running dry overnight is a soft reset. Dust also builds up on the panels over time, and badly after storms.

One important correction here, which Jana flagged on the original doc and which is historically right: the rover can't clean its own panels. So we should NOT build a wipe-your-panels minigame as the main way to recover. In reality Opportunity got lucky with wind gusts (the "cleaning events"), and during the worst storms it just went into low-power hibernation and waited. So recovery should be two things: hoping for a wind cleaning event, and choosing to hibernate to save power. Turning a problem the player can't directly fix into a tense waiting decision is both more honest and more interesting than a chore.

## The signal delay

The communication delay should feel like a mechanic, not a loading screen. Every transmission carries a one-way light delay. In reality a round trip to Mars runs somewhere between roughly 6 and 44 minutes; we compress that down to seconds for game feel, but we keep the relative swing (fast when the planets are close, slow when they're far). Signals also relay through orbiters like Mars Odyssey and MRO, so an orbiter has to be overhead to push a big packet, which naturally creates send windows. Storms and antenna angle drag the throughput down. A higher-bandwidth link moves more data in the same window, which is a nice late-game upgrade fantasy, but we should label it carefully (see the accuracy notes in doc 04).

## Instruments

Opportunity's real instruments map neatly onto verbs. The Pancam is the "take a photo" verb, all about framing the shot. The Microscopic Imager is for close-up looks at texture, like those hematite spherules everyone nicknamed blueberries. Mini-TES (the thermal spectrometer) is the "compose a scan" verb, and it's actually damaged during the 2007 storm, so the player loses that ability partway through, which is both true and a good difficulty gate. The Rock Abrasion Tool plus APXS/Mössbauer are the grind-and-confirm tools for nailing down mineralogy (for example jarosite, which points to acidic water).

Scanning is hold-and-aim, and the quality of the result depends on framing, distance, and how steady you are, so careful play beats spamming.

## The shape of the story

Full detail lives in doc 04, but the beats are: Act 1, arrival and landing on 25 Jan 2004, where you learn to move, scan, and send. Act 2, the water world around Eagle and Endurance, where the blueberries and layered bedrock build toward the salty-sea announcement. Act 3, the long drive and the 2007 storm, where you survive and lose Mini-TES. Act 4, Endeavour crater at Cape York in 2011, where with MRO's help you find older, gentler water. And Act 5, the final storm in 2018 and the last communication, where the mission ends and we close on a line in memory of Opportunity.

## Difficulty and getting everyone in

There's no twitch skill gate; difficulty is just how hard the resource pressure is tuned, so it's a slider. We should offer an Explorer/Story mode that softens the penalties. And the VR comfort settings aren't optional, they're required (see doc 03).

## Session length

No harsh game-over screen: running out of power just gently restarts the sol. We're aiming for 20 to 40 minute sessions that you can put down and pick back up, with the full arc running a few hours and chaptered by act so we can demo any single act on its own.

## Still open

The bigger unknowns live in doc 07: how aggressively to compress time, whether traversal is free-roam or guided (comfort probably pushes us toward guided), and how much of the instrument suite we actually simulate versus abstract into one scan action.
