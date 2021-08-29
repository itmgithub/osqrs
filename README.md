# OSQRS
## Intro
OSQRS is a tool that reads a QR-code from the screen. It does this by taking a partial screenshot and parsing the QR-code from that. OSQRS does not require or support a webcam. It is simply not the use-case for which it was build.

## Features
- Scan a QR code from screen
- Multi display and scaling aware (unlike some competitors)
- Put result in paste-buffer
- Open hyper-link with default browser

## Status
OSQRS is still in early testing. First results have been proven reliable but I would still consider this beta at-best due to its limited testing scenario’s.

## Configuration
All configuration in OSQRS does not require any configuration.

## TODO:
- Code-sign a release package.
- Document installation process.

## Screenshot
Sample use-case:
![Sample use-case](/ScreenShots/osqrs-screenshot1.png)

Result:
![Result](/ScreenShots/osqrs-screenshot1.png)

## Credits
OSQRS uses [ZXing.Net](https://github.com/micjahn/ZXing.Net/) to parse the QR-code. Please note that eventhough OSQRS is released under the 3-Clause BSD license, ZXing.Net is not. As of this writing ZXing.Net is release under the also very permissive Apache-2.0 license.
