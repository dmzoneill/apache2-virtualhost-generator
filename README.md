# Apache2 Virtual Host Generator

A VB.NET console program that creates Apache virtual hosts for every
site folder on a Windows development machine.

## What it does

For each folder in the sites directory it:

- Adds a `<VirtualHost>` block to
  `C:\apache2triad\conf\virtual-hosts.conf` with the folder as the
  `DocumentRoot` and a matching `ServerName`.
- Adds a matching entry to the Windows `hosts` file.

It also writes a default `localhost` host. The Apache2Triad and
sites paths are hardcoded in the source.

## Tech

- Visual Basic .NET console application
- Apache2Triad (Apache for Windows)

## Building

Open the `.sln` file in Visual Studio and build it. Windows only.

See [apache-config-gui](https://github.com/dmzoneill/apache-config-gui)
for a Windows Forms version.

## License

Licensed under the Apache License 2.0. See [LICENSE](LICENSE).
