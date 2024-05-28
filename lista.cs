using LinkedListNodo;

namespace LinkedListLista
{
    class Lista
    {
        Nodo? cabeza;
        int size;

        private static Lista? _instance = null;
        private Lista()
        {
            cabeza = null;
            size = 0;
        }

        public static Lista ObtenerInstancia()
        {
            if (_instance == null)
            {
                    _instance = new Lista();
            }
            return _instance;
        }
        public Boolean estaVacia()
        {
            return (cabeza == null) ? true : false;
        }
        public void addPrimero(object obj)
        {
            if (estaVacia())
            {
                cabeza = new(obj);
            }
            else
            {
                Nodo temp = cabeza!;
                Nodo nuevo = new(obj);
                nuevo.ensalazarSiguiente(temp);
                cabeza = nuevo;
            }
            size++;
        }
        public void listar()
        {
            if (!estaVacia())
            {
                int contador = 0;
                Nodo temp = cabeza!;
                System.Console.WriteLine("Lista de tareas");
                while (contador < size)
                {
                    System.Console.WriteLine($"{contador + 1}. {temp.obtenerValor()}");
                    temp = temp.obtenerSiguiente();
                    contador++;
                }
            }
        }
        public int Size()
        {
            return size;
        }
        public object obtener(int index)
        {
            int contador = 0;
            Nodo temp = cabeza!;
            while (contador < index - 1)
            {
                temp = temp.obtenerSiguiente();
            }
            return temp.obtenerValor();
        }
        public void Eliminar(object dato)
        {
            if (estaVacia())
            {
                System.Console.WriteLine("Lista de tareas vacia.");
                return;
            }

            Nodo temp = cabeza!;
            Nodo anterior = null!;

            while (!estaVacia())
            {
                if (temp.obtenerValor().Equals(dato))
                {
                    if (anterior == null)
                    {
                        // El nodo a eliminar es la cabeza
                        cabeza = temp.obtenerSiguiente();
                    }
                    else
                    {
                        // El nodo a eliminar no es la cabeza
                        anterior.ensalazarSiguiente(temp.obtenerSiguiente());
                    }
                    System.Console.WriteLine("Tarea eliminada correctamente.");
                    size--;
                    return;
                }
                anterior = temp;
                temp = temp.obtenerSiguiente();
            }

            System.Console.WriteLine($"({dato}) tarea no encontrada en la lista. ");
        }
    }
}
