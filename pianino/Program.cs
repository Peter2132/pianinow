
class Pianino
{
    static int[] Octave1 = { 1047, 1175, 1319, 1397, 1568, 1760, 1976, 1109, 1245, 1480, 1661, 1865 };
    static int[] Octave2 = { 2093, 2349, 2637, 2794, 3136, 3520, 3951, 2217, 2489, 2960, 3322, 3729 };
    static int[] Octave3 = { 4126, 4699, 5274, 5588, 6272, 7040, 7902, 4435, 4978, 5920, 6645, 7459 };
    static int Octavenow = 1;
    static int[] Noti = Octave1;


    static void Beep(int vod, int vod2)
    {
        Console.Beep(vod, vod2);
    }


    static int[][] OctaveA = new int[][]
  {
    Octave1,
    Octave2,
    Octave3
  };

    static void MakeNext(int Octave)
    {
        if (Octave >= 1 && Octave <= OctaveA.Length)
        {
            Noti = OctaveA[Octave - 1];
        }
        else
        {
            Noti = OctaveA[0]; 
        }
    }

    static void Main(string[] name)
    {
        ConsoleKeyInfo KeyInfo;

        do
        {
            KeyInfo = Console.ReadKey(true);

            if (KeyInfo.Key == ConsoleKey.Enter)
                break;

            Console.WriteLine("F1, F2, F3 для переключения.");
            Console.WriteLine("Нажмите Enter для выхода.");

            if (KeyInfo.Key == ConsoleKey.F1)
                Octavenow = 1;

            else if (KeyInfo.Key == ConsoleKey.F2)
                Octavenow = 2;

            else if (KeyInfo.Key == ConsoleKey.F3)
                Octavenow = 3;

            MakeNext(Octavenow);

            if (KeyInfo.Key == ConsoleKey.Q)
                Beep(Noti[0], 400);
            else if (KeyInfo.Key == ConsoleKey.W)
                Beep(Noti[1], 400);
            else if (KeyInfo.Key == ConsoleKey.E)
                Beep(Noti[2], 400);
            else if (KeyInfo.Key == ConsoleKey.R)
                Beep(Noti[3], 400);
            else if (KeyInfo.Key == ConsoleKey.T)
                Beep(Noti[4], 400);
            else if (KeyInfo.Key == ConsoleKey.Y)
                Beep(Noti[5], 400);
            else if (KeyInfo.Key == ConsoleKey.U)
                Beep(Noti[6], 400);
            else if (KeyInfo.Key == ConsoleKey.A)
                Beep(Noti[7], 400);
            else if (KeyInfo.Key == ConsoleKey.S)
                Beep(Noti[8], 400);
            else if (KeyInfo.Key == ConsoleKey.D)
                Beep(Noti[9], 400);
            else if (KeyInfo.Key == ConsoleKey.F)
                Beep(Noti[10], 400);
            else if (KeyInfo.Key == ConsoleKey.G)
                Beep(Noti[11], 400);

        } while (true);
    }
}