using UnityEngine;

public static class GameController
{
    private static int collectableCount;
    private static bool jogadorPerdeu;

    public static bool gameOver
    {
        get { return collectableCount <= 0 || jogadorPerdeu; }
    }

    public static void Init()
    {
        collectableCount = 4;
        jogadorPerdeu = false;
    }

    public static void Collect()
    {
        collectableCount--;
    }

    public static void Perder()
    {
        jogadorPerdeu = true;
    }
}