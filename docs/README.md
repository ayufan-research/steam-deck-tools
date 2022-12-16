# README

[![GitHub release (latest SemVer)](https://img.shields.io/github/v/release/ayufan/steam-deck-tools?label=stable&style=flat-square)](https://github.com/ayufan/steam-deck-tools/releases/latest)
[![GitHub release (latest SemVer including pre-releases)](https://img.shields.io/github/v/release/ayufan/steam-deck-tools?color=red&include_prereleases&label=beta&style=flat-square)](https://github.com/ayufan/steam-deck-tools/releases)
![GitHub all releases](https://img.shields.io/github/downloads/ayufan/steam-deck-tools/total?style=flat-square)

**This software is provided on best-effort basis and can break your SteamDeck.**

<img src="images/power_control.png" height="250"/>

## Help this project

**This project is provided free of charge, but development of it is not free - it takes a lot of effort**:

- Consider donating to keep this project alive.
- Donating also helps to fund new features.

<a href='https://ko-fi.com/ayufan' target='_blank'><img height='35' style='border:0px;height:50px;' src='https://az743702.vo.msecnd.net/cdn/kofi3.png?v=0' alt='Buy Me a Coffee at ko-fi.com' /></a> <a href="https://www.paypal.com/donate/?hosted_button_id=DHNBE2YR9D5Y2" target='_blank'><img height='35' src="https://raw.githubusercontent.com/stefan-niedermann/paypal-donate-button/master/paypal-donate-button.png" alt="Donate with PayPal" style='border:0px;height:55px;'/></a>

## Applications

This project provides the following applications:

- [Fan Control](fan-control.md) - control Fan on Windows
- [Performance Overlay](performance-overlay.md) - see FPS and other stats
- [Power Control](power-control.md) - change TDP or refresh rate
- [Steam Controller](steam-controller.md) - use Steam Deck with Game Pass

## Install

Download and install latest `SteamDeckTools-<version>-setup.exe` from [Latest GitHub Releases](https://github.com/ayufan/steam-deck-tools/releases/latest).

This project requires those dependencies to be installed in order to function properly. Those dependencies needs to be manually installed if portable archive is to be used:

- [Microsoft Visual C++ Redistributable](https://aka.ms/vs/17/release/vc_redist.x64.exe)
- [Rivatuner Statistics Server](https://www.guru3d.com/files-details/rtss-rivatuner-statistics-server-download.html)
- [ViGEmBus](https://github.com/ViGEm/ViGEmBus/releases)

It is strongly advised that following software is uninstalled or disabled:

- [SWICD](https://github.com/mKenfenheuer/steam-deck-windows-usermode-driver)
- [GlosSI](https://github.com/Alia5/GlosSI)
- [HidHide](https://github.com/ViGEm/HidHide)

## Additional informations

- [Controller Shortcuts](shortcuts.md) - default shortcuts when using [Steam Controller](steam-controller.md).
- [Development](development.md) - how to compile this project.
- [Risks](risks.md) - this project uses kernel manipulation and might result in unstable system.
- [Troubleshooting](troubleshooting.md) - if you encounter any problems.
- The latest beta version can be found in [GitHub Releases](https://github.com/ayufan/steam-deck-tools/releases).

## Join Us

Join Us for help or chat. We are at [#windows of Steam Deck Discord](https://discord.com/channels/865611969661632521/867449233261985812).

## Anti-Cheat and Antivirus software

Since this project uses direct manipulation of kernel memory via `inpoutx64.dll`
it might trigger Antivirus and Anti-Cheat software.

If you use at least version `0.5.x` you can disable kernel drivers usage that should
avoid trippping Anti-Cheat detection. Set FAN to `Default` and disable `OSD Kernel Drivers`.
Of course you will miss some metrics due to that.

## Author

Kamil Trzciński, 2022

Steam Deck Tools is not affiliated with Valve, Steam, or any of their partners.

## License

[Creative Commons Attribution-NonCommercial (CC-BY-NC)](://creativecommons.org/licenses/by-nc/4.0/).

Free for personal use. Contact me in other cases (`ayufan@ayufan.eu`).
