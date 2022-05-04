using ListasDoblementeLigadas;

Listas lista = new Listas();
lista.AgregarNodo("Uno");
lista.AgregarNodo("Dos");
lista.AgregarNodo("Tres");
lista.AgregarNodo("Cuatro");
lista.AgregarNodo("Cinco");
Console.WriteLine(lista.RecorrerLista());
Console.WriteLine("Buscando nodo Cuatro");
Nodo nodoCuatro = lista.Buscar("Cuatro");
Console.WriteLine(nodoCuatro.Valor);
Console.WriteLine("Borrando Cuatro");
lista.BorrarNodo("Cuatro");
Console.WriteLine(lista.RecorrerLista());
