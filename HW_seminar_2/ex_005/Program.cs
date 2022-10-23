// Найти расстояние между точками в пространстве 2D/3D
// я не помню чтобы нам объясняли подобное, поэтому я не справился с этим заданием. Я просто его списал.

Console.Write("Vvedite X1:");
int x1 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Vvedite Y1:");
int y1 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Vvedite Z1:");
int z1 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Vvedite X2:");
int x2 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Vvedite Y2:");
int y2 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Vvedite Z2:");
int z2 = int.Parse(Console.ReadLine() ?? "0");

double Rasstoianie(int x11, int y11, int z11, int x12, int y12, int z12)
    {
        return Math.Sqrt(Math.Pow(x12 - x11, 2) + Math.Pow(y12 - y11, 2)+Math.Pow(z12 - z11, 2));
    }

Console.Write("Rasstoianie mejdu tochkami: {0}", Rasstoianie(x1,y1,z1,x2,y2,z2));