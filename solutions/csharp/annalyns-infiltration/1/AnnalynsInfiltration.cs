static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return !knightIsAwake;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if (!knightIsAwake && !archerIsAwake && !prisonerIsAwake) {
            return false;
        }
        return true;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if (archerIsAwake || !prisonerIsAwake) {
            return false;
        }
        return true;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if (petDogIsPresent && !archerIsAwake) {
            return true;
        }
        if (!archerIsAwake && !knightIsAwake && prisonerIsAwake) {
            return true;
        }
        return false;
    }
}
