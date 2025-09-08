static class AssemblyLine
{
    private static readonly int CarsPerHourAtMinSpeed = 221;

    public static double SuccessRate(int speed)
    {
        double successRate = 0;
        if (speed >= 1 && speed <= 4) {
            successRate = 100;
        } else if (speed >= 5 && speed <= 8) {
            successRate = 90;
        } else if (speed == 9) {
            successRate = 80;
        } else if (speed == 10) {
            successRate = 77;
        }
        return successRate / 100;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        double successRate = SuccessRate(speed);
        return (CarsPerHourAtMinSpeed * speed) * successRate;;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double ratePerHour = ProductionRatePerHour(speed);
        return (int) (ratePerHour / 60);
    }
}
