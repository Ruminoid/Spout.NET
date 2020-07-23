# Spout.NET

![Nuget](https://img.shields.io/nuget/v/Spout.NET?style=flat-square) ![Downloads](https://img.shields.io/nuget/dt/Spout.NET?style=flat-square) ![Platform](https://img.shields.io/badge/platform-Windows-brightgreen?style=flat-square) ![LICENSE](https://img.shields.io/github/license/Ruminoid/Spout.NET?style=flat-square)

Spout.NET is a C# .NET Implementation for [Spout2](https://github.com/leadedge/Spout2), A video frame sharing system for Windows.

## Usage

The API of this mapping library is **completely consistent** with the Spout SDK, so you can refer to the [Spout SDK Documentation](https://github.com/leadedge/Spout2/blob/2.006/SpoutSDK/Documentation/SpoutSDK.pdf) for development. You can use Marshal Class to avoid unsafe code.

## A Simple Tutorial

1. Create an .NET Framework Console project.

2. Re-target the build config to `x64`.

3. Add the following nuget packages.

```ps1
Install-Package OpenGL.Net
Install-Package Ruminoid.Libraries
```

If you don't want to install the `Ruminoid.Libraries` package, you can maunally copy the [Spout.dll](https://github.com/leadedge/Spout2/blob/2.006/SpoutSDK/Source/VS2012/Binaries/x64/Spout.dll) to the `bin/x64/Debug/Libraries` folder.

4. Turn on `Allow Unsafe Code` in project config.

5. Put the following code into `Program.cs`.

```cs
using System;
using System.IO;
using System.Threading;
using OpenGL;
using Spout.Interop;

namespace SpoutTest
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            using (DeviceContext deviceContext = DeviceContext.Create()) // Create the DeviceContext
            {
                IntPtr glContext = IntPtr.Zero;
                glContext = deviceContext.CreateContext(IntPtr.Zero);
                deviceContext.MakeCurrent(glContext); // Make this become the primary context
                SpoutSender sender = new SpoutSender();
                sender.CreateSender("CsSender", 640, 360, 0); // Create the sender
                byte[] data = new byte[640 * 360 * 4];
                int i = 0;
                fixed (byte* pData = data) // Get the pointer of the byte array
                    while (true)
                    {
                        for (int j = 0; j < 640 * 360 * 4; j+=4)
                        {
                            data[j] = i == 0 ? byte.MaxValue : byte.MinValue;
                            data[j + 1] = i == 1 ? byte.MaxValue : byte.MinValue;
                            data[j + 2] = i == 2 ? byte.MaxValue : byte.MinValue;
                            data[j + 3] = byte.MaxValue;
                        }
                        Console.WriteLine($"Sending (i = {i})");
                        sender.SendImage(
                            pData, // Pixels
                            640, // Width
                            360, // Height
                            Gl.RGBA, // GL_RGBA
                            true, // B Invert
                            0 // Host FBO
                            );
                        Thread.Sleep(1000); // Delay
                        if (i < 2) i++;
                        else i = 0;
                    }
            }
        }
    }
}

```

6. Run this program and open the [SpoutReceiver.exe](https://github.com/leadedge/Spout2/blob/master/DEMO/SpoutReceiver.exe). You can now see the 640x360 window changing red, blue, green color.

## LICENSE

MIT
