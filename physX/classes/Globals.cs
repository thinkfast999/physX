using System;

namespace physX;

public static class Globals {
    public static string randomUID(int length) {
        string characters = "abcdefhijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890_";
        string buildString = "";

        char getRandom() {
            Random rand = new Random();
            int n = rand.Next(0,characters.Length - 1);
            return characters[n];
        }

        for (int i = 0; i < length; i++) {
            buildString += getRandom();
        }

        return buildString;
    }
}