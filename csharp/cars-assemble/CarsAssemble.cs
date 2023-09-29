using System;

static class AssemblyLine
{
    private const ushort CARS_PRODUCED_PER_HOUR = 221;
    public static double SuccessRate(int speed)
    {
        if (speed == 0) return 0;
        if (speed <= 4) return 1.0;
        if (speed <= 8) return 0.9;
        if (speed == 9) return 0.8;
        
        return 0.77;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return speed * CARS_PRODUCED_PER_HOUR * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)ProductionRatePerHour(speed) / 60;
    }
}
