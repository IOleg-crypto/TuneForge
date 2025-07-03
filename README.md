# TuneForge

TuneForge is a Windows Forms application developed in C# for audio playback and visualization. The project leverages the powerful TagLib library for audio metadata handling, and integrates a real-time audio visualizer for an enhanced user experience.

## Features

- Audio playback with support for common audio formats (MP3, WAV, etc.)
- Metadata extraction and display using TagLib# 
- using RealTaiizor for API
- User-friendly Windows Forms interface
- Smooth playback controls including play, pause, stop, and track navigation
- Playlist management and song information display

## Technologies and Libraries Used

- **C# with Windows Forms**: For the desktop graphical user interface
- **TagLib#**: For reading and editing audio metadata tags
- **NAudio**: For audio playback and processing
- **RealTaiizor**: For rendering audio visualizations in real time
- **JetBrains Rider**: The IDE used for development

## Installation

1. Clone the repository:
````
https://github.com/IOleg-crypto/TuneForge.git
````
2. Install libraries using NuGet Package Manager
```
dotnet add package NAudio
dotnet add package taglib
dotnet add package ReaLTaiizor
```


3. Open the solution file in JetBrains Rider.
4. Restore NuGet packages (TagLib#, NAudio, ReaLTaiizor).
5. Build and run the project.

## Usage

- Load audio files into the player.
- Control playback via the provided interface buttons.
- View metadata such as artist, album, title extracted by TagLib.
- Enjoy live audio visualization synchronized with playback.

## Contributing

Contributions and suggestions are welcome. Feel free to open issues or submit pull requests.

## License

This project is licensed under the MIT License.

---

If you want me to customize this README based on more exact details or code files you provide, let me know!
