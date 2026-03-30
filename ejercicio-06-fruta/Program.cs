Fruta manzana = new Fruta();
manzana.Color = "rojo";
manzana.Peso = 150;
manzana.EsEstacional = true;

Fruta banana = new Fruta("amarillo", 100, false);

Console.WriteLine(manzana.esComestible());
Console.WriteLine(banana.esComestible());
