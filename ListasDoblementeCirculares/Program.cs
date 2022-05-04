using ListasDoblementeCirculares;

Lista lista = new Lista();
lista.AgregarNodo("Uno");
lista.AgregarNodo("Dos");
lista.AgregarNodo("Tres");
lista.AgregarNodo("Cuatro");
lista.AgregarNodo("Cinco");
Console.WriteLine(lista.RecorrerLista());

Nodo nodoCinco = lista.Buscar("Cinco");
Console.WriteLine("Buscando nodo Cinco");
Console.WriteLine(nodoCinco.nodoAnterior.Valor);
Console.WriteLine(lista.RecorrerLista());

Console.WriteLine("Buscando nodo Cuatro");
Nodo nodoCuatro = lista.Buscar("Cuatro");
Console.WriteLine("Borrando Cuatro");
Console.WriteLine(nodoCuatro.Valor);
lista.BorrarNodo("Cuatro");
Console.WriteLine(nodoCuatro.Valor);

nodoCinco = lista.Buscar("Cinco");
Console.WriteLine("Nodo anterior Cinco");
Console.WriteLine(nodoCinco.nodoAnterior.Valor);
Console.WriteLine(lista.RecorrerLista());

return;
