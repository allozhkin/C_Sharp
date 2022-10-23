int a1 = 54;
int b1 = 33;
int c1 = 23;
int a2 = 1;
int b2 = 45;
int c2 = 98;
int a3 = 31;
int b3 = 48;
int c3 = 11;

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine(max);
