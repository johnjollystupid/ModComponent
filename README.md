# ModComponent

![](https://img.shields.io/github/downloads/ds5678/ModComponent/total.svg) ![](https://img.shields.io/github/downloads/ds5678/ModComponent/latest/total.svg)

This is a library for modding **The Long Dark** by Hinterland Games Studio, Inc.

It allows:

* Creating Unity assets that can be used as fully compatible in-game items.
* Adding custom crafting blueprints.
* Adding spawn points for modded and vanilla game items.
* Modifying already existing items.

> This library is only infrastructure for mods and does not provide any assets or asset bundles.

Requires [ModSettings](https://github.com/zeobviouslyfakeacc/ModSettings)

## Special Thanks

[WulfMarius](https://github.com/WulfMarius) was the original creator of [ModComponent](https://github.com/WulfMarius/ModComponent) and [AssetLoader](https://github.com/WulfMarius/AssetLoader). I am very grateful for all the contributions he made to the modding community, and I'm honored to have adopted so many of his mods. Rebuilding and improving ModComponent has been incredibly fun despite all the time it's taken. Although much more than half of the code is my own now, this project was initially built on the framework he left behind.

ModComponent's Menu system was adapted from [zeobviouslyfakeacc](https://github.com/zeobviouslyfakeacc)'s [ModSettings](https://github.com/zeobviouslyfakeacc/ModSettings) and borrows heavily from its code base.

In addition, [zeobviouslyfakeacc](https://github.com/zeobviouslyfakeacc), [DigitalZombie](https://github.com/DigitalzombieTLD), and [Xpazeman](https://github.com/Xpazeman) all offered and continue to offer invaluable insights during the development of ModComponent.

## [Patreon](https://www.patreon.com/ds5678)

I know many people might skip over this, but I hope you don't. You are so special, and I would appreciate your support. Modding takes lots of time, and I have expenses like food, internet, and rent. If you feel that I have improved your playing experience, please consider supporting me on my [Patreon](https://www.patreon.com/ds5678). Your support helps to ensure that I can continue making mods for you at the pace I am :)

## Installation

* If you haven't done so already, install MelonLoader by downloading and running [MelonLoader.Installer.exe](https://github.com/HerpDerpinstine/MelonLoader/releases/latest/download/MelonLoader.Installer.exe)
* Install the latest version of [ModComponent](https://github.com/ds5678/ModComponent/releases/latest) by placing it in the mods folder.
* Install the dependencies:
  - [ModSettings](https://github.com/zeobviouslyfakeacc/ModSettings/releases/latest)
  - [GearSpawner](https://github.com/ds5678/GearSpawner/releases/latest)
  - [LocalizationUtilities](https://github.com/ds5678/LocalizationUtilities/releases/latest)
  - [CraftingRevisions](https://github.com/ds5678/CraftingRevisions/releases/latest)

## Alcohol

The alcohol mechanics can be enabled with [AlcoholMod](https://github.com/ds5678/AlcoholMod).

## ModComponent Files

ModComponent uses a custom file extension `.modcomponent` for item packs. These files can be edited like so:

 * Change the file extension from `.modcomponent` to `.zip`
 * Extract the files. They'll be placed into a root folder with the same name as the item pack.
 * Edit the files as you please.
 * Rezip the files.
   * Make sure you're zipping the contents of the root folder. Zipping the root folder itself won't work with ModComponent.
 * Change the file extension of your new zip file from `.zip` to `.modcomponent`
