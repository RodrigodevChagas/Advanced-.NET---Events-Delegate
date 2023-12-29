using Events_Delegate.DelegateEvents;

GeometricFigure geometricFigure = new GeometricFigure() 
{
    Height = 10,
    Width = 15,
    Depth = 20
};

geometricFigure.CalculateVolume += CalculateSquareVolume;
geometricFigure.EventHandler();

static void CalculateSquareVolume(double height, double width, double depth)
{
    double volume = height * width * depth;
    Console.WriteLine("Event triggered by client class");
    Console.WriteLine(volume);
}

// The use of Delegate is valuable in situations when the logic of execution of a generic method can vary and need to
// be injected dynamically