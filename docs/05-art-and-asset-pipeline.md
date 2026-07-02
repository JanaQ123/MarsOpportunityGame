# Marsyaat — Art and Asset Pipeline

Owners: Sara and Jana. This doc pins down the visual target, how we make and name assets, and how they get into the project cleanly so the repo stays healthy and VR performance holds up.

## What it should look like

The original doc left this open (realistic vs semi-stylized vs stylized), and here's the call we're recording: grounded, semi-stylized realism. The reasoning is that Mars has a strong, instantly recognizable real look, the rusty regolith, the pink sky, the flat rocky plains, and we want to honor that, but full photorealism is expensive and hard to keep smooth on standalone VR. So we aim for believable forms and materials with the detail dialed back a little.

Reference the real place: Meridiani Planum is fairly flat, with fine reddish dust, scattered rocks, and those famous hematite blueberries. Use real NASA imagery for reference only, and don't ship NASA images as textures without checking the usage terms first.

## Art rules that keep VR fast

Everything anyone makes has to run at 72+ Hz on a mobile GPU, so build to budget from the start; it's far cheaper than optimizing after the fact. Keep hero props lean and background props very lean, and agree exact triangle targets per asset class with Osama before you start modeling. Share materials across props (atlasing) to cut draw calls, because fewer unique materials beats higher-res textures. Prefer 1K to 2K textures for hero assets and smaller for props, in compressed formats (ASTC for Android/Quest). Bake lighting wherever you can and avoid dynamic lights and real-time shadows on everything. Don't overlap transparency, since overdraw murders mobile VR framerate, so skip big alpha-blended particles for dust and use something cheaper. And model at real-world scale (1 unit = 1 meter) so proportions feel right in the headset.

## Tools and exporting

Model in Blender (it's free and easy for the team to share). Export to FBX (or glTF) with transforms applied and the right scale and orientation for Unity (Y up). Keep the source .blend files in the repo under Art/Source, tracked with Git LFS (see .gitattributes), and export the game-ready FBX and textures into Assets/_Project/Art. Author textures in whatever tool you like, and deliver them as PNG/TGA, packed where it makes sense (for example metallic, smoothness, and AO packed into channels).

## Naming things

Consistent names keep the project from turning into chaos. Use PascalCase with a type prefix. Models get SM_ for a static mesh (SM_RoverBody) or SK_ for skeletal. Materials get M_ (M_MarsGround), and textures get T_ with a suffix for the map (T_MarsGround_BaseColor, _Normal, _MRA). Prefabs get P_ (P_Rover, P_ScanTarget_Blueberry). Scenes are named descriptively per act (Act1_Landing, Act4_Endeavour). One asset, one clear name, and no "final_final_v3" in the repo; that's literally what Git history is for.

## Folder layout under Assets/_Project

Art/Source holds the raw .blend and working files (LFS). Art/Models holds exported meshes. Art/Materials and Art/Textures hold materials and maps. Audio holds music and SFX (LFS). Prefabs holds assembled, reusable objects. Scenes holds one scene per act plus a Bootstrap scene. Scripts holds the code (see the layering in doc 02). And UI holds the world-space UI prefabs and fonts.

## The golden rule for binaries

Unity scenes and prefabs are painful to merge, so to avoid stomping on each other's work: never have two people editing the same scene or prefab at the same time, and coordinate in the team chat and the issue tracker. Lean on prefabs rather than dumping everything straight into a scene, since prefabs are safer to work on in parallel. Always pull before you start, and commit small and often (doc 06 has the exact Git steps written for people who've never used Git). Large binaries go through Git LFS automatically since it's already configured, so just commit normally.

## Reviewing art

Art comes in through a pull request like everything else, with a screenshot or a short clip in the PR so the team can see it in context before it merges. And check that it looks right in a headset, not just on the monitor.

## Placeholders are fine

Grab CC0 assets from Kenney.nl, or just use simple grey-box props, as placeholders so gameplay can get built before the final art is ready. Just mark placeholder assets clearly so nobody mistakes them for final.
