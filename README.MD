# RustSharp

> WIP

Working sample of a dynamic Rust Library packed as a NuGet Package. Some more effort required to have it work cross platform.

## How To

### Prerequisites

* .NET 6 SDK
* Latest `rustup`/`cargo` installed

### macOS

```bash
rustup target add aarch64-apple-darwin
rustup target add x86_64-pc-windows-gnu

cd RustLib.Cli
sudo dotnet run -c Release
```

### Others

> WIP, Docker container will follow soon

```bash
docker build -t ruster .
docker run -v $(pwd):/build -it ruster /bin/bash
```

Then `cd sample-lib && ./build.sh`. Stuff will fail for now.
