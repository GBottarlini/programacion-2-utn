Robot miRobot = new Robot();

RuedaCaucho rueda = new RuedaCaucho();
miRobot.SistemaTraccion = rueda;
miRobot.MostrarDatos();

Oruga oruga = new Oruga();
miRobot.SistemaTraccion = oruga;
miRobot.MostrarDatos();
