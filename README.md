# MSFS PROfile Editor

**MSFS PROfile Editor** is a lightweight Windows utility for **Microsoft Flight Simulator 2024** that makes managing multiple `UserCfg.opt` graphics configurations fast, safe, and simple.

Whether you fly **Bush**, **VFR**, **IFR**, or **VR**, you can maintain separate graphics configurations for different types of flying and switch between them with a few clicks — without manually copying files or worrying about overwriting the wrong configuration.

The application also includes a collection of maintenance tools for commonly used Microsoft Flight Simulator configuration files.

---

## Why I Created It

I originally created MSFS PROfile Editor because I was constantly copying and replacing `UserCfg.opt` files whenever I changed the type of flying I wanted to do.

Bush flying, local VFR, IFR, and VR can all benefit from different graphics settings. Manually changing those settings in the simulator every time was tedious, and maintaining multiple copies of `UserCfg.opt` made it too easy to overwrite or delete the wrong file.

MSFS PROfile Editor was created to make that process quick and repeatable while protecting the original simulator configuration.

---

## Features

### PROfile Management

- Create named graphics PROfiles from your current `UserCfg.opt`
- Quickly switch between saved PROfiles
- Automatically back up `UserCfg.opt` before applying a PROfile
- Display up to 20 PROfiles in an easy-to-use selector
- Migrate older `.opt` PROfiles to the new `.profx` format
- Store PROfiles outside the simulator installation
- Remember your selected PROfile folder

Example PROfiles might include:

- Bush Flying
- VFR
- IFR
- VR
- Ultra
- Performance

### Simulator Detection

MSFS PROfile Editor automatically detects supported Microsoft Flight Simulator 2024 installations:

- Microsoft Store / Xbox App
- Steam

If both installations are detected, the application allows you to select the simulator installation you want to manage.

### Simulator Launcher

Microsoft Flight Simulator 2024 can be launched directly from MSFS PROfile Editor.

The application also supports launching the simulator through an existing **FSUIPC7 `MSFS24.bat`** configuration.

### Maintenance Tools

Built-in maintenance functions provide quick access to several commonly used MSFS 2024 files and folders:

- Back up and edit `EXE.xml`
- Back up and edit `UserCfg.opt`
- Delete `RollingCache.ccc`
- Back up and clear `SceneryIndexes`
- Back up and edit `FlightSimulator2024.cfg`

Confirmation prompts and backups are used where appropriate to help protect important simulator files.

---

## What's New in v1.1.1

Version 1.1.1 introduces a redesigned PROfile management workflow.

- New interface for selecting PROfiles
- New `.profx` file extension for MSFS PROfile Editor profiles
- Migration tool for converting older `.opt` PROfiles to `.profx`
- Display of up to 20 PROfiles, arranged alphabetically
- One-click operation for applying a selected PROfile
- Improvements to simulator detection
- General UI improvements and fixes

---

## Download and Installation

Pre-built releases are available from the **Releases** section of this GitHub repository.

1. Download the latest release.
2. Extract the **MSFS PROfile Editor** folder from the ZIP file.
3. Place the folder wherever you would like to keep the application.
4. Run `MSFS PROfile Editor.exe`.

No installer is required.

You can optionally create a Windows shortcut to `MSFS PROfile Editor.exe` for quick access.

### Updating an Existing Installation

When upgrading to a newer version, overwrite the existing application files with the files from the new release.

Doing so preserves the application's existing settings, including the location of your PROfile folder.

---

## Basic PROfile Workflow

A PROfile is a saved copy of your Microsoft Flight Simulator 2024 `UserCfg.opt` graphics configuration.

A typical workflow is:

1. Start MSFS PROfile Editor.
2. Open the PROfile Manager.
3. Start Microsoft Flight Simulator.
4. Configure the simulator's graphics settings for the type of flying you want to do.
5. Apply and save the settings inside Microsoft Flight Simulator.
6. Return to MSFS PROfile Editor.
7. Select **New Profile** and give the configuration a descriptive name.
8. Repeat the process to create additional configurations.

Your saved PROfiles can then be selected and applied whenever you want to change configurations.

> **Important:** Microsoft Flight Simulator must be restarted after a different PROfile is applied. The simulator reads these configuration settings during startup.

---

## Backups and Safety

Before replacing the active `UserCfg.opt`, MSFS PROfile Editor automatically creates a timestamped backup of the existing file.

PROfiles cannot be stored inside the MSFS `LocalCache` directory.

Although the application includes safeguards and backup functions, users should always maintain backups of important simulator configuration files.

---

## System Requirements

- Windows 10 or Windows 11
- Microsoft Flight Simulator 2024
- Microsoft Store / Xbox App or Steam edition

---

## Feedback and Bug Reports

MSFS PROfile Editor is an actively developed project, and feedback from other Microsoft Flight Simulator users is welcome.

If you encounter a problem, unexpected simulator detection, or have an idea for an improvement, please open an **Issue** in this GitHub repository.

When reporting a problem, please include as much useful information as possible, such as:

- MSFS installation type (Steam or Microsoft Store / Xbox App)
- MSFS PROfile Editor version
- What you expected to happen
- What actually happened
- Any error message displayed

This information makes reproducing and correcting problems much easier.

---

## Contributing

The source code is being made available so other users and developers can inspect the project, provide feedback, report problems, and help improve MSFS PROfile Editor.

If you are interested in contributing code, please open an Issue first to discuss the proposed change.

Contribution and redistribution terms are governed by the project's license.

---

## Built With

- Visual Basic .NET
- Windows Forms
- .NET 8
- Visual Studio

---

## Disclaimer

This software is provided **"AS IS"**, without warranty of any kind, express or implied, including but not limited to warranties of merchantability, fitness for a particular purpose, and non-infringement.

The author shall not be liable for any claim, damages, data loss, or other liability arising from the use of this software.

Although every effort has been made to make the application safe to use, you are responsible for maintaining backups of your simulator files before making changes.

Use this software at your own risk.

---

## License

The source code and application are subject to the terms contained in the project's `LICENSE` file.

---

## Author

Developed by **Saugatek**.

MSFS PROfile Editor is an independent utility and is not affiliated with or endorsed by Microsoft.