# Marsyaat — Narrative and Historical Accuracy

Owner: Osama (research), with Tahleel. Every historical claim in here should be checkable against a real source before it ever becomes in-game text. This is the reference both for the story beats and for keeping us honest. The whole promise of Marsyaat is that the player learns things that actually happened, and that promise dies the second we ship something false. So when we're not sure about a claim, mark it UNVERIFIED and keep it out of anything the player sees until it's checked.

## The premise

The player is NASA's Opportunity rover (MER-B). We compress the real mission into playable acts and hand the player real discoveries as rewards. The rover narrates lightly, and NASA (Earth) sends the objectives and the replies.

## The real beats

Use these as the spine of the story, and confirm each date and sol against a cited timeline before locking any in-game text.

Opportunity landed on 25 Jan 2004 (sol 1), at Meridiani Planum inside Eagle crater. Early on it found hematite spherules (the "blueberries") and layered bedrock, which pointed to a site that had once been soaked in or covered by salty water; NASA's standing-water / salty-sea announcement came in the first half of 2004. In 2007 a global dust storm caused a severe power crisis, and the rover survived by cutting way back on activity; the Mini-TES instrument was degraded by dust around this period. It reached the rim of Endeavour crater (Cape York) in 2011 after driving roughly 20 km, and there it found clay and gypsum evidence of older, less-acidic (more habitable) water, helped along by orbiter data from MRO's CRISM. It was designed to last about 90 sols and ended up running for around 15 years, driving a marathon-plus distance and setting the off-world driving record. The end came with the 2018 planet-encircling dust storm, which caused loss of contact (last transmission June 2018); NASA declared the mission complete on 13 February 2019.

## Act by act

Act 1 is arrival, and it's the tutorial: land, get oriented, learn to drive, scan, photograph, and send a first packet, and settle into the day/night power rhythm. Act 2 is the water world, where you investigate the blueberries and layered bedrock, grind with the RAT, analyze, send your findings, and get back the salty-sea discovery card. Act 3 is the long drive and the storm, where you push toward Endeavour and the 2007 storm forces you into power triage and hibernation, and you lose Mini-TES. Act 4 is Endeavour and Cape York, where you call for orbiter help to reach a target and discover the older, gentler water; this is the emotional high point of the science payoff. Act 5 is the last storm: the 2018 storm rises, power fades, and you send the final transmission, closing on the memorial line for Opportunity.

## What a "sol" is (for the player)

A sol is a Martian day, a little longer than an Earth day. Sol 1 is landing day, not day zero. The mission counts in sols because the rover's whole schedule (wake, sunlight, sleep) runs on Mars time. We should introduce this early and keep the current sol on the HUD.

## Corrections to make before writing any in-game text

The original research notes have a handful of things stated as fact that are actually wrong, oversimplified, or opinions wearing a fact's clothes. Fix these before they reach players.

The self-cleaning panels claim is false. Opportunity could not clean its own panels. Dust came off by chance wind gusts (the "cleaning events"), and storm survival was about low-power hibernation. Jana flagged this in a comment on the source doc, and she's right; both the design and the text need to reflect it.

The "23-month window" figure is imprecise. The Earth-Mars launch window comes around roughly every 26 months (the synodic period), not 23. The general idea that you have to wait for a window is correct; the number should either be fixed or kept vague.

The radiation note ("blocks gamma rays, use aluminum or water") is oversimplified. The real hazard for hardware and future crews is galactic cosmic rays and solar energetic particles, and hydrogen-rich materials like water or polyethylene make good shielding. We shouldn't tell players that Mars radiation is specifically "gamma rays."

Optical communication was not an Opportunity feature. The rover used radio through orbiter relays and the Deep Space Network, not laser/optical comms. Optical comms is a real emerging technology, but it wasn't on this rover, so if we use it as an upgrade fantasy we label it as forward-looking rather than something Opportunity actually did.

The communication-delay numbers need care too. The "22 minutes" one-way figure is near the maximum; the round-trip range is roughly 6 to 44 minutes depending on where the planets are. If we state it as fact, present a range, not one fixed number.

And on rock names: "blueberries" for hematite spherules is correct (if informal). But confirm the specific mineral and place names (jarosite, Meridiani Planum, Cape York, the Homestake gypsum vein) against sources before we use them as answers.

## Tone

This is as much a memorial as a game, so keep the ending respectful and resist turning the rover's "death" into melodrama. The real story carries plenty of weight on its own.

## Sources to lean on (verify each)

NASA/JPL's Mars Exploration Rovers mission pages and image galleries, The Planetary Society's mission timeline for Opportunity and Spirit, and peer-reviewed summaries of the Meridiani Planum water findings. Every player-facing fact should trace back to one of these, and we should keep the specific URL and access date next to each discovery card in the content data (see the data-driven content note in doc 02).
