public class Lasagna {
    private const int CookTimePerLayer = 2;

    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int timeInOven) {
        return ExpectedMinutesInOven() - timeInOven;
    }

    public int PreparationTimeInMinutes(int layers) {
        return layers * CookTimePerLayer;
    }

    public int ElapsedTimeInMinutes(int layers, int timeInOven) {
        return PreparationTimeInMinutes(layers) + timeInOven;
    }
}
