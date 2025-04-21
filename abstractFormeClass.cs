namespace app;

abstract class FormeGeometriche
{
    
    public abstract double CalcoloArea();
    
    public abstract double CalcoloPerimentro();
}

class Quadrato : FormeGeometriche
{
    private double _Lato;

    public Quadrato(double lato)
    {
        this.lato = lato;
    }

    public override double CalcoloArea()
    {
        return _Lato * _Lato;
    }

    public override double CalcoloPerimentro()
    {
        return _Lato * 4;
    }

    public double lato
    {
        get
        {
            return _Lato;
        }

        set
        {
            if (value < 0)
            {
                value = 0;
            }
            
        }
    }
}

class Rettangolo : FormeGeometriche
{
    public double Base { get; }
    public double Altezza { get; }

    public Rettangolo(double Base, double altezza)
    {
        this.Base = Base;
        this.Altezza = altezza;
    }

    public override double CalcoloArea()
    {
        return Altezza * Base;
    }

    public override double CalcoloPerimentro()
    {
        return (Altezza + Base) * 2;
    }
}

class Cerchio: FormeGeometriche
{
    public double Raggio { get;}

    public Cerchio(double raggio)
    {
        this.Raggio = raggio;
    }

    public override double CalcoloArea()
    {
        double raggioQuadrato = Math.Pow(Raggio, 2);
        double pi = Math.PI;
        
        return raggioQuadrato * pi;
    }

    public override double CalcoloPerimentro()
    {
        double Diametro = Raggio * 2;
        double Pi = Math.PI;
        
        return Diametro * Pi;
    }
}

class CalcoloFinale
{
    public List<double> GetShapesAreas(List<FormeGeometriche> shapes)
    {
        var risultato = new List<double>();

        foreach (var item in shapes)
        {
            risultato.Add(item.CalcoloArea());
        }

        return risultato;
    }
    public List<double> GetPerimentro(List<FormeGeometriche> shapes)
    {
        List<double> risultato = new List<double>();

        foreach (var item in shapes)
        {
            risultato.Add(item.CalcoloPerimentro());
        }
         
        return risultato;
    }
}
