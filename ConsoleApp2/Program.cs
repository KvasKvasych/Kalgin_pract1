using System;
using System.Data.SqlTypes;

Console.WriteLine("Задание №1");

double R, t1, l;

Console.WriteLine("Введите значение переменной t");
t1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной l");
l = Convert.ToDouble(Console.ReadLine());

R = 3 * Math.Pow(t1, 2) + 3 * Math.Pow(l, 5) + 4.9;

Console.WriteLine($"Значение R = {R}");



Console.WriteLine("Задание №2");

double K, p, y2;

Console.WriteLine("Введите значение переменной p");
p = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y");
y2 = Convert.ToDouble(Console.ReadLine());

K = Math.Log10(Math.Pow(p,2) + Math.Pow(y2,3)) + Math.Exp(p);

Console.WriteLine($"Значение К = {K}");



Console.WriteLine("Задание №3");

double G, n, y;

Console.WriteLine("Введите значение переменной n");
n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y");
y = Convert.ToDouble(Console.ReadLine());

G = n + (y + 3.5) + Math.Sqrt(y);

Console.WriteLine($"Значение G = {G}");




Console.WriteLine("Задание №4");

double D, a, t4;

Console.WriteLine("Введите значение переменной a");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной t");
t4 = Convert.ToDouble(Console.ReadLine());

D = 9.8 * Math.Pow(a, 2) + 5.52 * Math.Cos(Math.Pow(t4, 5));

Console.WriteLine($"Значение D = {D}");



Console.WriteLine("Задание №5");

double L, x;

Console.WriteLine("Введите значение переменной x");
x = Convert.ToDouble(Console.ReadLine());

L = 1.51 * Math.Cos(Math.Pow(x, 2)) + 2 * Math.Pow(x, 3);

Console.WriteLine($"Значение L = {L}");



Console.WriteLine("Задание №6");

double M, y6;

Console.WriteLine("Введите значение переменной y");
y6 = Convert.ToDouble(Console.ReadLine());

M = Math.Cos(2 * y6) + 3.6 * Math.Exp(x);

Console.WriteLine($"Значение M = {M}");



Console.WriteLine("Задание №7");

double N, m;

Console.WriteLine("Введите значение переменной m");
m = Convert.ToDouble(Console.ReadLine());

N = Math.Pow(m,2) + 2.8* Math.Abs(m) + 0.55;

Console.WriteLine($"Значение N = {N}");



Console.WriteLine("Задание №8");

double T, y8;

Console.WriteLine("Введите значение переменной y");
y8 = Convert.ToDouble(Console.ReadLine());

T = Math.Sqrt(Math.Abs(6 * Math.Pow(y8, 2) - 0.1 * y8 + 4));

Console.WriteLine($"Значение T = {T}");



Console.WriteLine("Задание №9");

double V, y9, x9;

Console.WriteLine("Введите значение переменной y");
y9 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x9 = Convert.ToDouble(Console.ReadLine());

V = Math.Log10(y9 + 0.95) + Math.Sin(Math.Pow(x9, 4));

Console.WriteLine($"Значение V = {V}");



Console.WriteLine("Задание №10");

double U, k10, x10;

Console.WriteLine("Введите значение переменной k");
k10 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x10 = Convert.ToDouble(Console.ReadLine());

U = Math.Exp(x10) + 7.335 * Math.Pow(k10, 2) + Math.Pow(Math.Sin(x10), 2);

Console.WriteLine($"Значение U = {U}");

Console.WriteLine("Задание №11");

double S, y11, x11;

Console.WriteLine("Введите значение переменной y");
y11 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x11 = Convert.ToDouble(Console.ReadLine());

S = 9.756 * Math.Pow(y11, 7) + 2 * Math.Tan(x11);

Console.WriteLine($"Значение S = {S}");



Console.WriteLine("Задание №12");

double K12, t12, x12;

Console.WriteLine("Введите значение переменной t");
t12 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x12 = Convert.ToDouble(Console.ReadLine());

K12 = 7 * Math.Pow(t12, 2) + 3 * Math.Sin(Math.Pow(x12, 3)) + 9.2;

Console.WriteLine($"Значение K = {K12}");



Console.WriteLine("Задание №13");

double E, y13;

Console.WriteLine("Введите значение переменной y");
y13 = Convert.ToDouble(Console.ReadLine());

E = Math.Sqrt(Math.Abs(3 * Math.Pow(y13, 2) + 0.5 + 4));

Console.WriteLine($"Значение E = {E}");



Console.WriteLine("Задание №14");

double R14, y14, x14;

Console.WriteLine("Введите значение переменной y");
y14 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x14 = Convert.ToDouble(Console.ReadLine());


R14 = Math.Abs(Math.Sqrt(Math.Pow(Math.Sin(y14), 2) + 6.835) + Math.Exp(x14));

Console.WriteLine($"Значение R = {R14}");



Console.WriteLine("Задание №15");

double H, y15;

Console.WriteLine("Введите значение переменной y");
y15 = Convert.ToDouble(Console.ReadLine());

H = Math.Sin(Math.Pow(y15, 2)) - 2.8 * y15 + Math.Sqrt(Math.Abs(y));

Console.WriteLine($"Значение H = {H}");



Console.WriteLine("Задание №16");

double S16, y16;

Console.WriteLine("Введите значение переменной y");
y16 = Convert.ToDouble(Console.ReadLine());

S16 = Math.Sqrt(Math.Cos(4 * Math.Pow(y16, 2))+ 7.151);

Console.WriteLine($"Значение S = {S16}");



Console.WriteLine("Задание №17");

double N17, y17;

Console.WriteLine("Введите значение переменной y");
y17 = Convert.ToDouble(Console.ReadLine());

N17 = 3 * Math.Pow(y17, 2) + Math.Sqrt(y17 + 1);

Console.WriteLine($"Значение N = {N17}");



Console.WriteLine("Задание №18");

double Z, y18;

Console.WriteLine("Введите значение переменной y");
y18 = Convert.ToDouble(Console.ReadLine());

Z = 3 * Math.Pow(y18, 2) + Math.Sqrt(Math.Pow(y,3) + 1);

Console.WriteLine($"Значение Z = {Z}");



Console.WriteLine("Задание №19");

double P, n19, y19, g;

Console.WriteLine("Введите значение переменной n");
n19 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y");
y19 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной g");
g = Convert.ToDouble(Console.ReadLine());

P = n19 * Math.Sqrt(Math.Pow(y19, 3)) + 1.09 * g;

Console.WriteLine($"Значение P = {P}");



Console.WriteLine("Задание №20");

double U20,k20, x20, y20;

Console.WriteLine("Введите значение переменной k");
k20 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x20 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y");
y20 = Convert.ToDouble(Console.ReadLine());

U20 = Math.Exp(k20+y) + Math.Tan(x20) * Math.Sqrt(y20);

Console.WriteLine($"Значение U = {U20}");



Console.WriteLine("Задание №21");

double P21, y21, h21;

Console.WriteLine("Введите значение переменной y");
y21 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной h");
h21 = Convert.ToDouble(Console.ReadLine());

P21 = Math.Exp(y21 + 5.5) + 9.1 * Math.Pow(h21, 3);

Console.WriteLine($"Значение P = {P21}");



Console.WriteLine("Задание №22");

double T22, u, y22, x22;

Console.WriteLine("Введите значение переменной u");
u = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y");
y22 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x22 = Convert.ToDouble(Console.ReadLine());

T22 = Math.Sin(2 * u) * Math.Log10(2 * Math.Pow(y22, 2) + Math.Sqrt(x22));

Console.WriteLine($"Значение T = {T22}");



Console.WriteLine("Задание №23");

double G23, f23, y23;


Console.WriteLine("Введите значение переменной y");
y23 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной f");
f23 = Convert.ToDouble(Console.ReadLine());

G23 = Math.Exp(2 * y23) + Math.Sin(f23);

Console.WriteLine($"Значение G = {G23}");


Console.WriteLine("Задание №24");

double F, y24;

Console.WriteLine("Введите значение переменной y");
y24 = Convert.ToDouble(Console.ReadLine());

F = 2 * Math.Sin(0.214 * Math.Pow(y24, 5) + 1);

Console.WriteLine($"Значение F = {F}");



Console.WriteLine("Задание №25");

double G25, f25, y25;


Console.WriteLine("Введите значение переменной y");
y25 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной f");
f25 = Convert.ToDouble(Console.ReadLine());

G25 = Math.Exp(2 * y25) + Math.Sin(Math.Pow(f25, 2));

Console.WriteLine($"Значение G = {G25}");


Console.WriteLine("Задание №26");

double Z26, p26;

Console.WriteLine("Введите значение переменной p");
p26 = Convert.ToDouble(Console.ReadLine());

Z26 = Math.Sin(Math.Pow(p26, 2) + 0.4);

Console.WriteLine($"Значение Z = {Z26}");



Console.WriteLine("Задание №27");

double W27, v27, x27, y27;

Console.WriteLine("Введите значение переменной v");
v27 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x27 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y");
y27 = Convert.ToDouble(Console.ReadLine());

W27 = 1.03 * v27 + Math.Exp(2 * y27) + Math.Tan(Math.Abs(x27));

Console.WriteLine($"Значение W = {W27}");





Console.WriteLine("Задание №28");

double T28, y28, h28;

Console.WriteLine("Введите значение переменной y");
y28 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной h");
h28 = Convert.ToDouble(Console.ReadLine());

T28 = Math.Exp(y28 + h28) + Math.Sqrt(Math.Abs(6.4 * y));

Console.WriteLine($"Значение T = {T28}");




Console.WriteLine("Задание №29");

double N29, y29;

Console.WriteLine("Введите значение переменной y");
y29 = Convert.ToDouble(Console.ReadLine());

N29 = 3 * Math.Pow(y29, 2) + Math.Sqrt(Math.Abs(y29 + 1));

Console.WriteLine($"Значение N = {N29}");




Console.WriteLine("Задание №30");

double W, r, y30;

Console.WriteLine("Введите значение переменной r");
r = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y");
y30 = Convert.ToDouble(Console.ReadLine());

W = Math.Exp(y30 + r) + 7.2 * Math.Sin(r);

Console.WriteLine($"Значение W = {W}");



Console.WriteLine("Задание №31");

double G31, f31, y31;

Console.WriteLine("Введите значение переменной f");
f31 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y");
y31 = Convert.ToDouble(Console.ReadLine());

G31 = (Math.Exp(2 * y31) + Math.Sin(f31)) / (Math.Log10(3.8 * y31 + f31));

Console.WriteLine($"Значение G = {G31}");


Console.WriteLine("Задание №32");

double F32, d32, y32;

Console.WriteLine("Введите значение переменной d");
d32 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y");
y32 = Convert.ToDouble(Console.ReadLine());

F32 = Math.Log10(d32) + ((3.5 * Math.Pow(d32, 2) + 1)) / (Math.Cos(2 * y32));

Console.WriteLine($"Значение F = {F32}");



Console.WriteLine("Задание №33");

double U33, k33, y33;

Console.WriteLine("Введите значение переменной k");
k33 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y");
y33 = Convert.ToDouble(Console.ReadLine());

U33 = (Math.Log10(k33-y33)+Math.Pow(y,4)) / (Math.Exp(y) + 2.3555* Math.Pow(K,2));

Console.WriteLine($"Значение U = {U33}");



Console.WriteLine("Задание №34");

double G34, w34, y34;

Console.WriteLine("Введите значение переменной w");
w34 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y");
y34 = Convert.ToDouble(Console.ReadLine());

G34 = (9.33 * Math.Pow(w34, 3) + Math.Sqrt(w34)) / (Math.Log10(y34 + 3.5) + Math.Sqrt(y34));

Console.WriteLine($"Значение G = {G34}");



Console.WriteLine("Задание №35");

double D35, a35, t35, y35;

Console.WriteLine("Введите значение переменной a");
a35 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной t");
t35 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y");
y35 = Convert.ToDouble(Console.ReadLine());

D35 = (7.8 * Math.Pow(a35, 2) + 3.52 * t35) / (Math.Log10(a35 + 2 * y35) + Math.Exp(y35));

Console.WriteLine($"Значение D = {D35}");



Console.WriteLine("Задание №36");

double L36, i36, y36;

Console.WriteLine("Введите значение переменной i");
i36 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y");
y36 = Convert.ToDouble(Console.ReadLine());

L36 = (0.81 * Math.Cos(i36)) / (Math.Log10(y36) + 2 * Math.Pow(i36, 3));

Console.WriteLine($"Значение L = {L36}");



Console.WriteLine("Задание №37");

double N37, m37, y37;

Console.WriteLine("Введите значение переменной m");
m37 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y");
y37 = Convert.ToDouble(Console.ReadLine());

N37 = (Math.Pow(m37, 2) + 2.8 * m37 + 0.355) / (Math.Cos(2 * y37) + 3.6);

Console.WriteLine($"Значение N = {N37}");



Console.WriteLine("Задание №38");

double T38, t38, y38;

Console.WriteLine("Введите значение переменной t");
t38 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y");
y38 = Convert.ToDouble(Console.ReadLine());

T38 = (2.37 * Math.Sin(t38 + 1)) / (Math.Sqrt(4 * Math.Pow(y38, 2) - 0.1 * y + 5));

Console.WriteLine($"Значение T = {T38}");



Console.WriteLine("Задание №39");

double V39, y39, w39;

Console.WriteLine("Введите значение переменной y");
y39 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной w");
w39 = Convert.ToDouble(Console.ReadLine());

V39 = (Math.Pow(y39 + 2 * w39, 3)) / (Math.Log10(y39 + 0.75));

Console.WriteLine($"Значение V = {V39}");



Console.WriteLine("Задание №40");

double Z40, y40, t40;

Console.WriteLine("Введите значение переменной y");
y40 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной t");
t40 = Convert.ToDouble(Console.ReadLine());

Z40 = (2 * t40 + y40 * Math.Cos(t40)) / (Math.Sqrt(y40 + 4.831));

Console.WriteLine($"Значение Z = {Z40}");




Console.WriteLine("Задание №41");

double D41, y41, n41;

Console.WriteLine("Введите значение переменной y");
y41 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной n");
n41 = Convert.ToDouble(Console.ReadLine());

D41 = Math.Pow(y41, 2) + (0.5 * n41 + 4.8) / (Math.Sin(y41));

Console.WriteLine($"Значение D = {D41}");



Console.WriteLine("Задание №42");

double R42, y42, t42;

Console.WriteLine("Введите значение переменной y");
y42 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной t");
t42 = Convert.ToDouble(Console.ReadLine());

R42 = (Math.Sin(Math.Pow((2 * t42 + 1), 2)) + 0.3) / (Math.Log10(t42 + y42));

Console.WriteLine($"Значение R = {R42}");



Console.WriteLine("Задание №43");

double A43, y43, h43;

Console.WriteLine("Введите значение переменной y");
y43 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной h");
h43 = Convert.ToDouble(Console.ReadLine());

A43 = (Math.Sin(2 * y43 + h43) + Math.Pow(h43, 2)) / (Math.Exp(h43) + y43);

Console.WriteLine($"Значение A = {A43}");



Console.WriteLine("Задание №43");

double P44, y44, h44;

Console.WriteLine("Введите значение переменной y");
y44 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной h");
h44 = Convert.ToDouble(Console.ReadLine());

P44 = (Math.Exp(y44 + 2.5) + 7.1 * Math.Pow(h44, 3)) / Math.Log10(Math.Sqrt(y44 + 0.04 * h44));

Console.WriteLine($"Значение P = {P44}");



Console.WriteLine("Задание №45");

double F45, y45, j45;

Console.WriteLine("Введите значение переменной y");
y45 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной j");
j45 = Convert.ToDouble(Console.ReadLine());

F45 = (2 * Math.Sin(0.354 * y45 + 1)) / (Math.Log10(y45 = 2 * j45));

Console.WriteLine($"Значение F = {F45}");



Console.WriteLine("Задание №46");

double W46, y46, r46, t46;

Console.WriteLine("Введите значение переменной y");
y46 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной r");
r46 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной t");
t46 = Convert.ToDouble(Console.ReadLine());

W46 = (4 * Math.Pow(t46, 3) + Math.Log10(r46)) / Math.Exp(y46 + r46) + 7.2 * Math.Sin(r46);

Console.WriteLine($"Значение W = {W46}");



Console.WriteLine("Задание №47");

double H47, y47, n47;

Console.WriteLine("Введите значение переменной y");
y47 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной n");
n47 = Convert.ToDouble(Console.ReadLine());

H47 = (Math.Pow(y47, 2) - 0.8 * y47 + Math.Sqrt(y47)) / (23.1 * Math.Pow(n47, 2) + Math.Cos(n47));

Console.WriteLine($"Значение H = {H47}");



Console.WriteLine("Задание №48");

double R48, y48, k48;

Console.WriteLine("Введите значение переменной y");
y48 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной k");
k48 = Convert.ToDouble(Console.ReadLine());

R48 = (Math.Sqrt(Math.Pow(Math.Sin(y48), 2) + 6.835)) / (Math.Log10(y48+k48)+3*Math.Pow(y48,2));

Console.WriteLine($"Значение R = {R48}");



Console.WriteLine("Задание №49");

double E49, y49, q49;

Console.WriteLine("Введите значение переменной y");
y49 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной q");
q49 = Convert.ToDouble(Console.ReadLine());

E49 = (Math.Log10(0.7 * y49 + 2 * q49)) / (Math.Sqrt(3 * Math.Pow(y48, 2) + 0.5 * y49 + 4));

Console.WriteLine($"Значение E = {E49}");



Console.WriteLine("Задание №50");

double K50, y50, t50, l50;

Console.WriteLine("Введите значение переменной y");
y50 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной t");
t50 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной l");
l50 = Convert.ToDouble(Console.ReadLine());

K50 = (2 * Math.Pow(t50, 2) + 3 * l50 + 7.2) / (Math.Log10(y50 + Math.Exp(2 * t50)));

Console.WriteLine($"Значение K = {K50}");



Console.WriteLine("Задание №51");

double Q51, k51, p51, x51, d51;

Console.WriteLine("Введите значение переменной k");
k51 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной p");
p51 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x51 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной d");
d51 = Convert.ToDouble(Console.ReadLine());


Q51 = (Math.Sqrt(k51 + 2.6 * p51 * Math.Sin(k51))) / (x51 - Math.Pow(d51, 3));

Console.WriteLine($"Значение Q = {Q51}");



Console.WriteLine("Задание №52");

double S52, y52, t52;

Console.WriteLine("Введите значение переменной y");
y52 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной t");
t52 = Convert.ToDouble(Console.ReadLine());

S52 = (4.351*Math.Pow(y52,3)+2*t52*Math.Log(t52)) / (Math.Sqrt(Math.Cos(2*y52) + 4.351));

Console.WriteLine($"Значение S = {S52}");



Console.WriteLine("Задание №53");

double R53, y53, d53;

Console.WriteLine("Введите значение переменной y");
y53 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной d");
d53 = Convert.ToDouble(Console.ReadLine());

R53 = (Math.Pow(Math.Sin(y53),2)+0.3*d53) / (Math.Exp(y53)+ Math.Log10(d53));

Console.WriteLine($"Значение R = {R53}");



Console.WriteLine("Задание №54");

double U54, y54, k54;

Console.WriteLine("Введите значение переменной y");
y54 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной k");
k54 = Convert.ToDouble(Console.ReadLine());

U54 = (Math.Log10(2*k54+4.3)) / (Math.Exp(k54+ y54)+Math.Sqrt(y54));

Console.WriteLine($"Значение U = {U54}");



Console.WriteLine("Задание №55");

double L55, c55, t55;

Console.WriteLine("Введите значение переменной c");
c55 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной k");
t55 = Convert.ToDouble(Console.ReadLine());

L55 = Math.Pow(Math.Cos(c55), 2) + (3*Math.Pow(t55,2)+4) / (Math.Sqrt(c55 + t55));

Console.WriteLine($"Значение L = {L55}");



Console.WriteLine("Задание №56");

double T56, y56, u56;

Console.WriteLine("Введите значение переменной y");
y56 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной u");
u56 = Convert.ToDouble(Console.ReadLine());

T56 = (Math.Sin(2*u56)) / (Math.Log10(2*y56 + u56));

Console.WriteLine($"Значение T = {T56}");



Console.WriteLine("Задание №57");

double Z57, p57, y57;

Console.WriteLine("Введите значение переменной y");
y57 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной p");
p57 = Convert.ToDouble(Console.ReadLine());

Z57 = (Math.Pow(Math.Sin(p57+0.4),2)) / (Math.Pow(y57,2)+7.325*p57);

Console.WriteLine($"Значение Z = {Z57}");



Console.WriteLine("Задание №58");

double W58, y58, v58;

Console.WriteLine("Введите значение переменной y");
y58 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной v");
v58 = Convert.ToDouble(Console.ReadLine());

W58 = (0.004 * v58 + Math.Exp(2 * y58)) / (Math.Exp(y58 / 2));

Console.WriteLine($"Значение W = {W58}");



Console.WriteLine("Задание №59");

double T59, y59, h59;

Console.WriteLine("Введите значение переменной y");
y59 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной h");
h59 = Convert.ToDouble(Console.ReadLine());

T59 = (0.355*Math.Pow(h59, 2)- 4.355) / (Math.Exp(y59+h59)+Math.Sqrt(2.7*y59));

Console.WriteLine($"Значение T = {T59}");



Console.WriteLine("Задание №60");

double N60, y60, p60;

Console.WriteLine("Введите значение переменной y");
y60 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной p");
p60 = Convert.ToDouble(Console.ReadLine());

N60 = (3*Math.Pow(y60,2)+Math.Sqrt(y60+1)) / (Math.Log10(p60+y60)+Math.Exp(p60));

Console.WriteLine($"Значение N = {N60}");



Console.WriteLine("Задание №61");

double L61, x61, a61, c61, e61;

Console.WriteLine("Введите значение переменной x");
x61 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a");
a61 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной c");
c61 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной e");
e61 = Convert.ToDouble(Console.ReadLine());

L61 = (Math.Sqrt(Math.Exp(x61)-Math.Pow(Math.Cos(Math.Pow(x61,2)*Math.Pow(a61,5)),4))+Math.Atan(a61-Math.Pow(x61,5))) / (e61*Math.Sqrt(Math.Abs(a61=x61*Math.Pow(c61,4))));

Console.WriteLine($"Значение L = {L61}");



Console.WriteLine("Задание №62");

double L62, c62, x62, t62;

Console.WriteLine("Введите значение переменной c");
c62 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x62 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной t");
t62 = Convert.ToDouble(Console.ReadLine());

L62 = Math.Pow((1 / (Math.Tan(c62))), 2) + (2 * Math.Pow(x62, 2) + 5) / (Math.Sqrt(c62 + t62));

Console.WriteLine($"Значение L = {L62}");



Console.WriteLine("Задание №63");

double A63, y63, h63;

Console.WriteLine("Введите значение переменной y");
y63 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной h");
h63 = Convert.ToDouble(Console.ReadLine());

A63 = (Math.Tan(Math.Pow(y63,3)-Math.Pow(h63,4))+Math.Pow(h63,2)) / (Math.Pow(Math.Sin(h63),3)+y63);

Console.WriteLine($"Значение A = {A63}");



Console.WriteLine("Задание №64");

double F64, y64, x64;

Console.WriteLine("Введите значение переменной y");
y64 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x64 = Convert.ToDouble(Console.ReadLine());

F64 = (Math.Sqrt(Math.Pow(2+y64,2)+Math.Pow(Math.Sin(y64+5),1/7)) / (Math.Log10(x64+1)-Math.Pow(y64,3)));

Console.WriteLine($"Значение F = {F64}");



Console.WriteLine("Задание №65");

double G65, x65, y65, z65, c65;

Console.WriteLine("Введите значение переменной x");
x65 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y");
y65 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной c");
c65 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной z");
z65 = Convert.ToDouble(Console.ReadLine());

G65 = (Math.Tan(Math.Pow(x65,4)-6)-Math.Pow(Math.Cos(z65 +x65*y65),3)) / (Math.Pow(Math.Cos(Math.Pow(x65,3)),3)*Math.Pow(c65,2));

Console.WriteLine($"Значение G = {G65}");



Console.WriteLine("Задание №66");

double K66, x66, y66, b66, a66;

Console.WriteLine("Введите значение переменной x");
x66 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y");
y66 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной b");
b66 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a");
a66 = Convert.ToDouble(Console.ReadLine());

K66 = (Math.Sqrt(x66+b66-a66)+Math.Log10(y66)) / (Math.Atan(b66+a66));

Console.WriteLine($"Значение K = {K66}");



Console.WriteLine("Задание №67");

double D67, x67, y67, a67;

Console.WriteLine("Введите значение переменной y");
y67 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x67 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a");
a67 = Convert.ToDouble(Console.ReadLine());

D67 = (Math.Cos(Math.Pow(x67,3)+6)-Math.Sin(y67-a67)) / (Math.Log10(Math.Pow(x67,4))-2*Math.Pow(Math.Sin(x67),5));

Console.WriteLine($"Значение D = {D67}");



Console.WriteLine("Задание №68");

double P68, x68, y68, c68, a68;

Console.WriteLine("Введите значение переменной x");
x68 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y");
y68 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной c");
c68 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a");
a68 = Convert.ToDouble(Console.ReadLine());

P68 = (Math.Pow(a68,5)+Math.Pow(Math.Sin(y68-c68),4)) / (Math.Pow(Math.Sin(x68+y68),3)+Math.Abs(x68-y68));

Console.WriteLine($"Значение P = {P68}");



Console.WriteLine("Задание №67");

double R69, y69, d69, x69;

Console.WriteLine("Введите значение переменной y");
y69 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x69 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной d");
d69 = Convert.ToDouble(Console.ReadLine());

R69 = (Math.Pow(Math.Cos(y69),3)+ Math.Pow(2,x69)*d69) / (Math.Exp(y69)+Math.Log10(Math.Pow(Math.Sin(x69),2))+7.4);

Console.WriteLine($"Значение R = {R69}");



Console.WriteLine("Задание №70");

double U70, y70, x70;

Console.WriteLine("Введите значение переменной y");
y70 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x70 = Convert.ToDouble(Console.ReadLine());

U70 = (Math.Exp(Math.Pow(x70,3))+ Math.Pow(Math.Cos(x70-4),2)) / (Math.Atan(x70)+5.2*y70);

Console.WriteLine($"Значение U = {U70}");



Console.WriteLine("Задание №71");

double I71, y71, x71;

Console.WriteLine("Введите значение переменной y");
y71 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x71 = Convert.ToDouble(Console.ReadLine());

I71 = (2.33*Math.Log10(Math.Sqrt(1 + Math.Pow(Math.Cos(y71),2)))) / (Math.Exp(y71)+ Math.Pow(Math.Sin(x71),2));

Console.WriteLine($"Значение I = {I71}");



Console.WriteLine("Задание №72");

double G72, y72, a72, x72;

Console.WriteLine("Введите значение переменной y");
y72 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x72 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a");
a72 = Convert.ToDouble(Console.ReadLine());

G72 = (Math.Pow(Math.Cos(Math.Abs(y72+x72)),3)-(x72-y72)) / (Math.Pow(Math.Atan(x72+a72),4)*Math.Pow(x,5));

Console.WriteLine($"Значение G = {G72}");



Console.WriteLine("Задание №73");

double R73, a73, b73, x73;

Console.WriteLine("Введите значение переменной a");
a73 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x73 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной b");
b73 = Convert.ToDouble(Console.ReadLine());

R73 = (a73) / (x73-a73) + (Math.Pow(b73,x73) + Math.Pow(Math.Cos(x73), 3)) / (Math.Pow(Math.Log(a73 + 4.5),3));

Console.WriteLine($"Значение R = {R73}");



Console.WriteLine("Задание №74");

double R74, x74;

Console.WriteLine("Введите значение переменной x");
x74 = Convert.ToDouble(Console.ReadLine());


R74 = (Math.Sin(Math.Pow(Math.Pow(x74,2)+4,3)+4.3) / (Math.Pow(Math.Sin(Math.Pow(x74,4)), 3)));

Console.WriteLine($"Значение R74 = {R74}");



Console.WriteLine("Задание №75");

double N75, y75, m75;

Console.WriteLine("Введите значение переменной y");
y75 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной m");
m75 = Convert.ToDouble(Console.ReadLine());

N75 = (Math.Pow(m75,2)+2.8*m75 + 0.355) / (Math.Cos(2*y75)+3.6);

Console.WriteLine($"Значение N = {N75}");



Console.WriteLine("Задание №76");

double P76, y76, t76, x76;

Console.WriteLine("Введите значение переменной y");
y76 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x76 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной t");
t76 = Convert.ToDouble(Console.ReadLine());

P76 = (Math.Pow(Math.Sin(x76),3)+Math.Log10(2*y76+3*x76)) / (Math.Pow(t76,2)+Math.Sqrt(x76));

Console.WriteLine($"Значение P = {P76}");



Console.WriteLine("Задание №77");

double T77, x77, y77, a77, b77;

Console.WriteLine("Введите значение переменной x");
x77 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y");
y77 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной b");
b77 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a");
a77 = Convert.ToDouble(Console.ReadLine());

T77 = (Math.Sqrt(x77+b77-a77)+Math.Log10(y77)) / (Math.Atan(b77+a77));

Console.WriteLine($"Значение T = {T77}");



Console.WriteLine("Задание №78");

double S78, y78, t78;

Console.WriteLine("Введите значение переменной y");
y78 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной t");
t78 = Convert.ToDouble(Console.ReadLine());

S78 = (4.351*Math.Pow(y78,3)+2*t78*Math.Log10(t78)) / (Math.Sqrt(Math.Cos(2*y78)+ 4.351));

Console.WriteLine($"Значение S = {S78}");



Console.WriteLine("Задание №77");

double D79, y79, a79, b79;

Console.WriteLine("Введите значение переменной y");
y79 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной b");
b79 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a");
a79 = Convert.ToDouble(Console.ReadLine());

D79 = (a79*(Math.Sqrt(b79))-Math.Cos(3*a79*b79)) / (Math.Pow(Math.Sin(a79*Math.Asin(a79)+ Math.Log10(y79)),2)); 

Console.WriteLine($"Значение D = {D79}");



Console.WriteLine("Задание №80");

double U80, x80, y80, c80, b80, a80;

Console.WriteLine("Введите значение переменной x");
x80 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y");
y80 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной b");
b80 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной c");
c80 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a");
a80 = Convert.ToDouble(Console.ReadLine());

U80 = (Math.Pow(Math.Tan(y80),3)+Math.Pow(Math.Sin(x80*Math.Sqrt(b80-c80)),5)) / (Math.Sqrt(a80-b80+c80));

Console.WriteLine($"Значение U = {U80}");



Console.WriteLine("Задание №81");

double N81, z81, x81, a81;

Console.WriteLine("Введите значение переменной z");
z81 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x81 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a");
a81 = Convert.ToDouble(Console.ReadLine());

N81 = (Math.Pow(z81+Math.Sqrt(z81*x81),1/5))/(Math.Exp(x81) + Math.Pow(a81,5)*Math.Atan(x81));

Console.WriteLine($"Значение N = {N81}");



Console.WriteLine("Задание №82");

double F82, y82, x82;

Console.WriteLine("Введите значение переменной y");
y82 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x82 = Convert.ToDouble(Console.ReadLine());

F82 = Math.Cos(Math.Pow(x82, 2) + 2) + (3.5*Math.Pow(x82,2)+1) / (Math.Pow(Math.Cos(y82),2));

Console.WriteLine($"Значение F = {F82}");



Console.WriteLine("Задание №83");

double F83, x83, z83, a83, b83;

Console.WriteLine("Введите значение переменной x");
x83 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной z");
z83 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной b");
b83 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a");
a83 = Convert.ToDouble(Console.ReadLine());

F83 = (Math.Sqrt(Math.Abs(x83)+Math.Pow(Math.Cos(x83),3))+Math.Pow(z83,4)) / (Math.Log10(x83)-Math.Asin(b83*x83-a83));

Console.WriteLine($"Значение F = {F83}");



Console.WriteLine("Задание №84");

double f84, x84, z84, a84, b84;

Console.WriteLine("Введите значение переменной x");
x84 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной z");
z84 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной b");
b84 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a");
a84 = Convert.ToDouble(Console.ReadLine());

f84 = (Math.Pow(Math.Cos(b84*Math.Pow(x84,5)),7)-(Math.Sin(Math.Pow(a84,2))+Math.Cos(Math.Pow(x84,3))+Math.Pow(z84,5)-Math.Pow(a84,2))) / (Math.Asin(Math.Pow(a84,2))-Math.Acos(Math.Pow(x84,7)-Math.Pow(a84,2)));

Console.WriteLine($"Значение f = {f84}");



Console.WriteLine("Задание №85");

double J85, y85, a85, x85;

Console.WriteLine("Введите значение переменной y");
y85 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x85 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a");
a85 = Convert.ToDouble(Console.ReadLine());

J85 = (Math.Pow(1/Math.Tan(Math.Pow(a85,3)),3)+Math.Pow(Math.Atan(a85),2)) / (Math.Sqrt(Math.Pow(y85,Math.Tan(x85))));

Console.WriteLine($"Значение J = {J85}");



Console.WriteLine("Задание №86");

double U86, y86, k86, x86;

Console.WriteLine("Введите значение переменной y");
y86 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x86 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной k");
k86 = Convert.ToDouble(Console.ReadLine());

U86 = (Math.Log10(Math.Pow(x86,3)+y86)-Math.Pow(y86,4)) / (Math.Exp(y86)+ 5.4*Math.Pow(k86,3));

Console.WriteLine($"Значение U = {U86}");



Console.WriteLine("Задание №87");

double P87, x87, y87, a87, c87;

Console.WriteLine("Введите значение переменной x");
x87 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y");
y87 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной c");
c87 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a");
a87 = Convert.ToDouble(Console.ReadLine());

P87 = (Math.Pow(a87,5)+Math.Acos(a87=Math.Pow(x87,3))-Math.Pow(Math.Sin(y87-c87),4)) / (Math.Pow(Math.Sin(x87+y87),3)+Math.Abs(x87-y87)); 

Console.WriteLine($"Значение P = {P87}");



Console.WriteLine("Задание №88");

double G88, x88, z88, y88, c88;

Console.WriteLine("Введите значение переменной x");
x88 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной z");
z88 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y");
y88 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной c");
c88 = Convert.ToDouble(Console.ReadLine());

G88 = (Math.Tan(Math.Pow(x,4)-6)-Math.Pow(Math.Cos(z88+Math.Pow(x88,3)*y88),3*x88)) / (Math.Pow(Math.Sin(Math.Pow(x88,3)*Math.Pow(c88,2)),3));

Console.WriteLine($"Значение G = {G88}");



Console.WriteLine("Задание №89");

double R89, y89, d89, x89;

Console.WriteLine("Введите значение переменной y");
y89 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x89 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной d");
d89 = Convert.ToDouble(Console.ReadLine());

R89 = (Math.Pow(Math.Cos(y89),2)+2.4*d89) / (Math.Exp(y89)+ Math.Asin(6*Math.Pow(x,2)));

Console.WriteLine($"Значение R = {R89}");



Console.WriteLine("Задание №90");

double K90, x90;

Console.WriteLine("Введите значение переменной x");
x90 = Convert.ToDouble(Console.ReadLine());


K90 = (Math.Sqrt(Math.Pow(3+x90,6)-Math.Log10(x90))) / (Math.Exp(x)+ Math.Asin(6*Math.Pow(x90,2)));

Console.WriteLine($"Значение K = {K90}");



















