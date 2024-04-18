// See https://aka.ms/new-console-template for more information
    MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
    MoonRover apollo = new MoonRover("Apollo", 1971);
    MarsRover sojourner = new MarsRover("Sojourner", 1997);
    Satellite sputnik = new Satellite("Sputnik", 1957);

    //Rover[] rovers = new Rover[] {lunokhod, apollo, sojourner};

    //DirectAll(rovers);

    Object[] probes = new Object[] {lunokhod, apollo, sojourner, sputnik};

    foreach (Object element in probes) {
        Console.WriteLine($"Tracking a {element.GetType()}");
      }

    IDirectable[] probes2 = new IDirectable[] {lunokhod, apollo, sojourner, sputnik};
    DirectAll(probes2);



static void DirectAll(IDirectable[] probes2) {
    foreach (IDirectable element in probes2) {
        Console.WriteLine(element.GetInfo());
        Console.WriteLine(element.Explore());
        Console.WriteLine(element.Collect());
      }

    }



