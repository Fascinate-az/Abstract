namespace app;

class Program
{
    static void Main(string[] args)
    {
        FormeGeometriche quadrato = new Quadrato(-0.15);
        FormeGeometriche rettangolo = new Rettangolo(7.4, 5.5);
        FormeGeometriche cerchio = new Cerchio(10.4);
        CalcoloFinale calcoloFinale = new CalcoloFinale();

        List<FormeGeometriche>ListaFormeGeometriche = new List<FormeGeometriche>(){quadrato,rettangolo,cerchio};

        
        var calcoloAreeForme = calcoloFinale.GetShapesAreas(ListaFormeGeometriche);
        var calcoloPerimentroForme = calcoloFinale.GetPerimentro(ListaFormeGeometriche);

        foreach (var item in calcoloAreeForme)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("---------------");

        foreach (var item in calcoloPerimentroForme)
        {
            Console.WriteLine(item);
        }

        
            
        

        
        
    }
    
    
}
