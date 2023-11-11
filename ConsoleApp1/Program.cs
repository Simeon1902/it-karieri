int a = 9;
int b = 12;
int licep = a*b;
int obikp = 2*(a+b);
Console.WriteLine($"liceto na pravoukulnika e {licep}");
Console.WriteLine($"Obikolkata na pravoukulnika e {obikp}");
// 2. trigulunik
double s1 = 3.5d;
double v = 4.5d;
double licet = (s1*v)/2;
double obikt = 3*v;
Console.WriteLine($"liceto na triugulnika e {licet}");
Console.WriteLine($"Obikolkata na triugulnika e {obikt}");
// 3. sravnenie lice
if (licep>licet)
{
    Console.WriteLine("Liceto na pravougulnika e po-golqmo ot liceto na triugulnika");
}
else 
{
    Console.WriteLine("Liceto na triugulnika e po-golqmo ot liceto na pravougulnika" );
}
// 4. sravnenie obikolka
if (obikp>obikt)
{
    Console.WriteLine("Obikolkata na pravougulnika e po-golqma ot obikolkata na triugulnika");
}
else 
{
    Console.WriteLine("Obikolkata na triugulnika e po-golqma ot obikolkata na pravougulnika" );
}
// 5. sravnenie 
if (licep>licet && obikp>obikt)
{
    Console.WriteLine("Liceto i obikolkata na pravougulnika sa po-golemi");
}
else
{
    Console.WriteLine("Liceto i obikolkata na triugulnika sa po-golemi");
}
// 6. godini
Console.WriteLine("Vuvedi godini");
int age;
string ab = Console.ReadLine();
age = int.Parse(ab);
if (age<14)
{
    Console.WriteLine("Ti si maloleten");
}
else if(age<18)

    Console.WriteLine("Ti si nepulnoleten");
}
else
{    
    Console.WriteLine("Ti si pulnoleten");
}


