#!/bin/bash

if [ "$1" = "Release" ]; then
    release="--release"
fi

echo $release

arm_targets=("aarch64-apple-darwin") # ("aarch64-apple-darwin" "aarch64-unknown-linux-gnu" "aarch64-pc-windows-msvc")
x86_64_targets=("x86_64-pc-windows-gnu") # ("x86_64-apple-darwin" "x86_64-unknown-linux-gnu" "x86_64-pc-windows-gnu")

for target in "${arm_targets[@]}";
do
  echo "Building for ARM $target..."
  cargo build --target $target $release  
done

for target in "${x86_64_targets[@]}";
do
  echo "Building for x86_x64 $target..."
  cargo build --target $target $release  
done
