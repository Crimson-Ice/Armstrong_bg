// See https://aka.ms/new-console-template for more information
bool Armstrong(int nombre)
{
    int c ,d , u;
    c = (nombre/100);
    d = ((nombre%100)/10);
    u = ((nombre%100)%10);
    int cal = (c*c*c) + (d*d*d) + (u*u*u);
    if(cal == nombre)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.WriteLine(Armstrong(153));


