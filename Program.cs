using System;
using System.Collections.Generic;
using System.Threading;

namespace ModuloDeterminarPrecioRenta
{
    public class Program
    {
        static void Main(string[] args)
        {
            int seleccion = 1;
            int numeroOpciones = 0;
            double precioPorDia = 0;
            int dias = 0;
            var mc = new Program();

            List<ListaVehiculos> listaVehiculos = new List<ListaVehiculos>() //inicializa lista de vehiculos con componentes
            {
                new ListaVehiculos() { Name = "Toyota Yaris", Rate = 25000 },
                new ListaVehiculos() { Name = "Hyundai Tucson", Rate = 50000 },
                new ListaVehiculos() { Name = "Nissan Versa", Rate = 30000 },
                new ListaVehiculos() { Name = "Toyota Rush", Rate = 42000 },
            };

            while (seleccion != 0) //menu
            {

                Console.WriteLine("Lista de vehiculos disponibles:" + "\n");

                for (int i = 0; i < listaVehiculos.Count; i++) //imprime lista vehiculos
                {
                    Console.WriteLine(i + 1 + ") " + listaVehiculos[i].Name + "/ Costo por dia: " + listaVehiculos[i].Rate + " colones");
                    numeroOpciones = i + 1;
                }
                Console.WriteLine("\n" + "0) Salir del sistema"); //muestra opcion para salir del sistema

                Console.Write("\n" + "Seleccione una opcion: ");
                seleccion = int.Parse(Console.ReadLine());//toma la seleccion del usuario 

                if (seleccion > numeroOpciones) //compara si el numero seleccionado es mayor al numero de opciones
                {

                    Console.Write("\n" + "ERROR! - Seleccione una de las opciones disponibles");
                    Console.ReadKey();
                    Console.Clear();

                }
                else //si seleccion es correcta, se mueve al switch
                {
                    Console.Clear();
                    switch (seleccion)
                    {

                        case 1:
                            Console.Write("Seleccion: Vehiculo " + listaVehiculos[seleccion - 1].Name + " / Costo por dia: " + listaVehiculos[seleccion - 1].Rate + " colones"); //muestra datos del vehiculo

                            precioPorDia = mc.calcularPrecioRentaPorDia(listaVehiculos[seleccion - 1].Rate); //obtiene el precio por hora (aplique promocion o no)
                            Console.WriteLine("\n" + "- El costo por dia es de: " + precioPorDia + " colones"); //muestra el precio con descuento en caso de que aplique promocion, si no, muestra precio regular

                            Console.Write("\n" + "Ingrese el numero de dias que desea rentar: "); //solicita numero de dias
                            dias = int.Parse(Console.ReadLine()); //toma el numero de dias

                            Console.Write("\n--------------------------------------------------\n");
                            Console.Write("\nEl costo total por " + dias + " dia(s) es de: " + mc.calcularPrecioTotal(precioPorDia, dias) + " colones"); //muestra precio total con base a numero de dias

                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 2:
                            Console.Write("Seleccion: Vehiculo " + listaVehiculos[seleccion - 1].Name + " / Costo por dia: " + listaVehiculos[seleccion - 1].Rate + " colones"); //muestra datos del vehiculo

                            precioPorDia = mc.calcularPrecioRentaPorDia(listaVehiculos[seleccion - 1].Rate); //obtiene el precio por hora (aplique promocion o no)
                            Console.WriteLine("\n" + "- El costo por dia es de: " + precioPorDia + " colones"); //muestra el precio con descuento en caso de que aplique promocion, si no, muestra precio regular

                            Console.Write("\n" + "Ingrese el numero de dias que desea rentar: "); //solicita numero de dias
                            dias = int.Parse(Console.ReadLine()); //toma el numero de dias

                            Console.Write("\n--------------------------------------------------\n");
                            Console.Write("\nEl costo total por " + dias + " dia(s) es de: " + mc.calcularPrecioTotal(precioPorDia, dias) + " colones"); //muestra precio total con base a numero de dias

                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 3:
                            Console.Write("Seleccion: Vehiculo " + listaVehiculos[seleccion - 1].Name + " / Costo por dia: " + listaVehiculos[seleccion - 1].Rate + " colones"); //muestra datos del vehiculo

                            precioPorDia = mc.calcularPrecioRentaPorDia(listaVehiculos[seleccion - 1].Rate); //obtiene el precio por hora (aplique promocion o no)
                            Console.WriteLine("\n" + "- El costo por dia es de: " + precioPorDia + " colones"); //muestra el precio con descuento en caso de que aplique promocion, si no, muestra precio regular

                            Console.Write("\n" + "Ingrese el numero de dias que desea rentar: "); //solicita numero de dias
                            dias = int.Parse(Console.ReadLine()); //toma el numero de dias

                            Console.Write("\n--------------------------------------------------\n");
                            Console.Write("\nEl costo total por " + dias + " dia(s) es de: " + mc.calcularPrecioTotal(precioPorDia, dias) + " colones"); //muestra precio total con base a numero de dias

                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 4:
                            Console.Write("Seleccion: Vehiculo " + listaVehiculos[seleccion - 1].Name + " / Costo por dia: " + listaVehiculos[seleccion - 1].Rate + " colones"); //muestra datos del vehiculo

                            precioPorDia = mc.calcularPrecioRentaPorDia(listaVehiculos[seleccion - 1].Rate); //obtiene el precio por hora (aplique promocion o no)
                            Console.WriteLine("\n" + "- El costo por dia es de: " + precioPorDia + " colones"); //muestra el precio con descuento en caso de que aplique promocion, si no, muestra precio regular

                            Console.Write("\n" + "Ingrese el numero de dias que desea rentar: "); //solicita numero de dias
                            dias = int.Parse(Console.ReadLine()); //toma el numero de dias

                            Console.Write("\n--------------------------------------------------\n");
                            Console.Write("\nEl costo total por " + dias + " dia(s) es de: " + mc.calcularPrecioTotal(precioPorDia, dias) + " colones"); //muestra precio total con base a numero de dias

                            Console.ReadKey();
                            Console.Clear();
                            break;

                    }// FIN SWITCH
                }//FIN ELSE 
            } //FIN WHILE MENU
        } //FIN MAIN

        public double calcularPrecioRentaPorDia(double rate) // metodo que verifica si aplica promocion por decha y devuelve el precio con descuento en case de que sea el caso
        {
            double precioActual = rate;
            double precio = precioActual;
            var DateAndTime = DateTime.Now; //obtiene fecha actual con hora
            var date = DateAndTime.Date.ToString("dd-MM-yyyy");//combierte fecha a formato deseado
            var DayMonth = DateAndTime.Date.ToString("dd-MM");//guarda solo dia y mes para comparar con fecha actual

            //Console.Clear();
            Console.WriteLine("\n" + "Fecha actual: " + date + "\n--------------------------------------------------");

            if (DayMonth.CompareTo("08-12") > 0 && DayMonth.CompareTo("15-12") < 0) //verifica si la fecha actual esta dentro del 8-Dic y 15-Dic
            {
                Console.WriteLine("\n" + "*** Por fechas especiales, se ha aplicado un 25% de descuento al costo por dia ***");
                precio = precioActual * 0.75; //calcula precio nuevo con descuento
            }else if (DayMonth.CompareTo("16-12") > 0 && DayMonth.CompareTo("25-12") < 0){ //verifica si la fecha actual esta dentro del 16-Dic y 25-Dic

                Console.WriteLine("\n" + "*** Por fechas especiales, se ha aplicado un 15% de descuento al costo por dia ***");
                precio = precioActual * 0.85; //calcula precio nuevo con descuento
            }

            return precio; //retorna el precio con o sin descuento 

        }

        public double calcularPrecioTotal(double precioPorDia, int numeroDias) //metodo que calcula el precio total con base al numero de dias a rentar
        {

            double precioTotal = precioPorDia * numeroDias; //calcula precio total
            return precioTotal; //retorna precio

        }
    }
}
