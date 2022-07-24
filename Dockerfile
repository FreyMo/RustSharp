FROM rust:1.62-buster

WORKDIR /build

RUN rustup target add aarch64-apple-darwin && \
    rustup target add aarch64-pc-windows-msvc && \
    rustup target add x86_64-apple-darwin && \
    rustup target add x86_64-unknown-linux-gnu && \
    rustup target add x86_64-pc-windows-gnu
    
RUN cargo --help