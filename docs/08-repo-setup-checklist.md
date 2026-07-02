# Repo Setup Checklist (for Tahleel)

The scaffolding is already done: the docs, .gitignore, .gitattributes (Git LFS), Packages/manifest.json, the PR template, and the issue template are all in place. What's left needs account or security permissions, so it has to be done by you as the repo owner, from the GitHub web UI. Do these before turning the team loose on it.

## Add the teammates as collaborators

This controls who can get into the private repo, so it's an access-control thing and only you can do it. Go to Settings, then Collaborators (under Access), then Add people, and invite each teammate by their GitHub username or email: Osama, Sara, and Jana (and Jana's added one already — jan20220973@std.psut.edu.jo). Give them the Write role so they can push branches and open PRs but can't change repo settings. Each of them gets an email invitation to accept.

## Protect the main branch

This is the bit that actually enforces our workflow, no direct pushes, everything through PRs, and it's a security setting, so again it's yours to set. Go to Settings, then Branches (or Settings, then Rules, then Rulesets), add a branch ruleset or rule targeting main, and turn on: require a pull request before merging, require at least 1 approval on each PR, and optionally require conversations to be resolved before merging, plus optionally don't allow bypassing the rules so even admins follow the flow. Save it. After that, nobody can push straight to main, and the beginner workflow in doc 06 just works.

## Optional: CODEOWNERS for auto-review

Once the collaborators are added and you know their GitHub usernames, you can add a CODEOWNERS file (in the repo root or in .github/) so the right person gets auto-requested as a reviewer. The idea is to route code and systems under /Assets/_Project/Scripts/ to the developer, art under /Assets/_Project/Art/ to the artists, and docs under /docs/ to you. Don't add this file with guessed usernames, though; GitHub warns if a listed owner isn't actually a collaborator.

## Optional: a Project board

On the Projects tab, make a board (To do, In progress, In review, Done). Use the Task issue template to file work items and drag them across the board. It keeps the day-to-day organized, as noted in doc 07.

## Sanity check

Once all that's done, make a test branch, open a PR, and confirm it can't be merged without a review and can't be pushed straight to main. When that holds, the team's safe to start.
