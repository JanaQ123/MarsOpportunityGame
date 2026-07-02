# Git Workflow for the Team (Beginner Friendly)

Owner: Tahleel. This is written for people who've never touched Git or GitHub. Follow it as written and you'll be fine, and if any step is confusing, ask in the team chat BEFORE you click, not after. Nothing here can permanently break the project; Git keeps a history of everything.

## The one big idea

We never work directly on the main copy of the project. main is the safe, always-working version. Instead, each person makes their own temporary copy, called a branch, does their work there, and then asks the team to review it and merge it back into main through a Pull Request (a PR). That way nobody can accidentally break everyone else's work.

## One-time setup (do this once per computer)

First, install Git from git-scm.com with the default options. Then install Git LFS, which we need for the big art and audio files, by running this once in a terminal:

```
git lfs install
```

Next, install GitHub Desktop from desktop.github.com. It gives you buttons instead of typed commands, which is a gentler place to start (the command-line versions are shown below too, for reference). Sign in to GitHub Desktop with your GitHub account. Tahleel will have added you as a collaborator; if you can't see the repo, tell him. Finally, clone the repo: in GitHub Desktop go to File, then Clone repository, pick hyprtrop/marseeyat-vr, and choose a folder on your computer. Cloning just downloads the whole project.

## The everyday routine (memorize this)

Every single time you sit down to work:

1. Pull first, to get everyone else's latest changes before you start. In GitHub Desktop, click Fetch origin, then Pull. On the command line:

```
git checkout main
git pull
```

2. Make a new branch for your task. Never work on main. Name it after the task, like feature/scanning-system or art/rover-model. In GitHub Desktop: Branch, then New branch. On the command line:

```
git checkout -b feature/scanning-system
```

3. Do your work in Unity or your art tool, and save normally.

4. Commit often, in small pieces. A commit is a labeled save point, and you write a short message saying what you did. On the command line:

```
git add .
git commit -m "Add rock scanning interaction"
```

5. Push your branch to GitHub so others can see it and it's backed up:

```
git push
```

The first push of a new branch might ask you to confirm the branch name; just accept it.

6. Open a Pull Request when the task is ready for review. GitHub shows a "Compare and pull request" button. Fill in the template and create it.

7. A teammate reviews it, and once it's approved it gets merged into main. After the merge, delete the branch and start the routine again from step 1.

## Naming branches

Keep it simple and consistent. Use feature/... for gameplay or systems (feature/power-system), art/... for models, textures, and materials (art/mars-terrain), ui/... for interface work (ui/main-hud), fix/... for bug fixes (fix/teleport-offset), and docs/... for documentation changes. Branches are cheap and temporary: one task, one branch, and when it's merged the branch is done.

## Why we use Pull Requests instead of pushing straight to main

main is protected on purpose, so direct pushes are blocked and nobody can break the working game by accident. Every change gets a second pair of eyes before it lands, and if something's wrong we can talk it through on the PR before it affects everyone. It also leaves a clear record of who changed what and why.

## The golden rules that prevent disasters

Always pull before you start working; most conflicts come from skipping this. Never have two people editing the same Unity scene or the same prefab at once, because Unity scene files don't merge well, so coordinate in chat first and claim your work in the issue tracker. Commit small and often with clear messages, since big rare commits are painful to review and to fix. Don't commit the Library or Temp folders; our .gitignore already blocks them, but if you see them trying to sneak in, stop and ask. And big files (models, audio, images) are handled by Git LFS automatically, so just commit normally and don't try anything special.

## If something looks scary

A merge conflict just means two people changed the same lines. Don't panic and don't force anything; ask Tahleel or Osama to help resolve it. You basically can't lose committed work in Git, it's almost always recoverable, so when in doubt, stop and ask before running a command you don't understand. And never run a command you found online that includes the word force (like push --force) unless Osama tells you to.

## Who reviews what

Tahleel (team leader) approves and merges PRs and settles any disputes. Osama reviews the code PRs. Art PRs get reviewed by the other artist (Sara or Jana) plus a quick in-headset check. When you're not sure who should review, request Tahleel.
