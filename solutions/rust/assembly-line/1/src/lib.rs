const CARS_PER_HOUR: f64 = 221.0;
const MINUTES_PER_HOUR: f64 = 60.0;

pub fn production_rate_per_hour(speed: u8) -> f64 {
    let rate_per_hour: f64 = (speed as f64) * CARS_PER_HOUR;
    if speed >= 1 && speed <= 4 {
        rate_per_hour
    } else if speed >= 5 && speed <= 8 {
        rate_per_hour * 0.9
    } else {
        rate_per_hour * 0.77
    }
}

pub fn working_items_per_minute(speed: u8) -> u32 {
    (production_rate_per_hour(speed) / MINUTES_PER_HOUR) as u32
}
