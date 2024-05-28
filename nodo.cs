namespace LinkedListNodo
{
    public class Nodo
    {

        Object valor; // Valor
        Nodo? siguiente; // Puntero

        public Nodo(Object valor)
        {
            this.valor = valor;
        }
        public void ensalazarSiguiente(Nodo n)
        {
            siguiente = n;
        }
        public object obtenerValor()
        {
            return valor;
        }
        public Nodo obtenerSiguiente()
        {
            return siguiente!;
        }
    }
}
