using LinkedListNodo;
using LinkedListLista;
namespace LinkedListProgram
{
    /*
    Desarrolla un pequeño programa en C# que utilice una lista enlazada simple para gestionar una lista de tareas pendientes. Permite a los usuarios agregar y eliminar tareas.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Lista listaTarea = Lista.ObtenerInstancia();

            //Agregar tarea
            listaTarea.addPrimero("Hacer tarea de ingles");
            listaTarea.addPrimero("Hacer tarea de Estructuta de datos");
            // Listar tareas
            listaTarea.listar();
            System.Console.WriteLine();
            //Eliminar tarea
            listaTarea.Eliminar("Hacer tarea de ingles");
            System.Console.WriteLine();
            // Listar tareas
            listaTarea.listar();
            System.Console.WriteLine();
            // Cantidad de tareas
            listaTarea.Size();
            System.Console.WriteLine();
            // buscar por id
            listaTarea.obtener(1);
        }
    }
}
