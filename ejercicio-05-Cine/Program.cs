
Cine cine1 = new Cine();
cine1.Pelicula = "Avatar";
cine1.Horario = "20:00";
Console.WriteLine(cine1.ObtenerCartelera());

Cine cine2 = new Cine();
cine2.Pelicula = "SpiderMan";
cine2.Horario = "22:00";
Console.WriteLine(cine2.ObtenerCartelera());

cine1.Pelicula = "sherk";
cine1.Horario = "19:00";
Console.WriteLine(cine1.ObtenerCartelera());
