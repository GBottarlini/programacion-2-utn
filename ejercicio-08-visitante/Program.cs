// Creacion de los Objetos

Persona objPersona = new Persona ();
objPersona.Nombre ="Juan";
objPersona.Apellido ="Perez";
Console.WriteLine(objPersona.Presentarse());

Visitante objVisitante = new Visitante();
objVisitante.Nombre = "Gena";
objVisitante.Apellido = "Bottarlini";
objVisitante.DNI = 12345678;
Console.WriteLine(objVisitante.Presentarse());

Guardia objGuardia = new Guardia();
objGuardia.Nombre = "Sargento";
objGuardia.Apellido = "Garcia";
Console.WriteLine(objGuardia.Presentarse());
Console.WriteLine(objGuardia.ControlarDocumento(objVisitante));
