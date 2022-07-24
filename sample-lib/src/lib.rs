#[repr(C)]
pub struct SampleStruct {
    pub first: i16,
    pub second: i16,
}

#[no_mangle]
pub extern fn get_sample_struct() -> SampleStruct {
    SampleStruct {
        first: 1,
        second: 2
    }
}

#[no_mangle]
pub extern fn fibonacci(n: u32) -> u32 {
    match n {
        0 => 1,
        1 => 1,
        _ => fibonacci(n - 1) + fibonacci(n - 2),
    }
}