using System;

class Program {
    static void Main(string[] args) {
        // Solicitar que ejercicio quiere correr
        Console.WriteLine("Ingrese una de las siguiente opciones. 1. Ejercicio de renta 2. Ejercicio 2. Ejercicio sala de juegos 3. Ejercicio pizzeria 4. Ejercicio empleados");
        int opcion = Int32.Parse(Console.ReadLine());        

        switch(opcion){
            case 1:
                // Solicitar al usuario los valores trimestrales del año
                Console.WriteLine("Ingrese el valor del primer trimestre: ");
                double trim1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el valor del segundo trimestre: ");
                double trim2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el valor del tercer trimestre: ");
                double trim3 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el valor del cuarto trimestre: ");
                double trim4 = double.Parse(Console.ReadLine());

                // Calcular la renta anual
                double annualRent = trim1 + trim2 + trim3 + trim4;

                // Calcular la renta a pagar
                double rentToPay = 0;

                if (annualRent < 10000) {
                    rentToPay = annualRent * 0.05;
                } else if (annualRent < 20000) {
                    rentToPay = 10000 * 0.05 + (annualRent - 10000) * 0.1;
                } else if (annualRent < 35000) {
                    rentToPay = 10000 * 0.05 + 10000 * 0.1 + (annualRent - 20000) * 0.15;
                } else if (annualRent < 45000) {
                    rentToPay = 10000 * 0.05 + 10000 * 0.1 + 15000 * 0.15 + (annualRent - 35000) * 0.2;
                } else {
                    rentToPay = 10000 * 0.05 + 10000 * 0.1 + 15000 * 0.15 + 10000 * 0.2 + (annualRent - 45000) * 0.3;
                }

                // Renta a pagar
                double impuestoAgregado = rentToPay/annualRent * 100;

                // Mostrar los resultados en pantalla
                Console.WriteLine("Renta anual: " + annualRent);
                Console.WriteLine("Renta a pagar: " + rentToPay);
                Console.WriteLine("Porcentaje de impuesto agregado: " + impuestoAgregado + "%");
            break;
            case 2:
                // Solicitar al usuario el nombre completo y la edad del cliente
                Console.WriteLine("Ingrese su nombre completo: ");
                string nombreCompleto = Console.ReadLine();

                Console.WriteLine("Ingrese su edad: ");
                int edad = int.Parse(Console.ReadLine());

                // Calcular el precio de la entrada y el descuento correspondiente
                double precioEntrada = 15000;

                double descuento = 0;
                if (edad < 4) {
                    precioEntrada = 0;
                } else if (edad >= 4 && edad <= 18) {
                    descuento = 0.05;
                } else {
                    descuento = 0.03;
                }

                double descuentoAplicado = precioEntrada * descuento;
                double precioFinal = precioEntrada - descuentoAplicado;

                // Mostrar los resultados en pantalla
                Console.WriteLine("Nombre completo: " + nombreCompleto);
                Console.WriteLine("Precio de la entrada: " + precioFinal);

                if (descuento > 0) {
                    Console.WriteLine("Descuento aplicado: " + descuento * 100 + "%");
                }
            break;
            case 3:
                // Solicitar al usuario el tipo de pizza que desea
                Console.WriteLine("¿Desea una pizza vegetariana (ingrese '1') o no vegetariana(ingrese '2')?");
                int tipoPizza = Int32.Parse(Console.ReadLine());

                // Mostrar el menú de ingredientes según el tipo de pizza
                Console.WriteLine("Ingredientes disponibles:");

                if (tipoPizza == 1) {
                    Console.WriteLine("- Pimiento");
                    Console.WriteLine("- Champiñones");
                } else if (tipoPizza == 2) {
                    Console.WriteLine("- Pepperoni");
                    Console.WriteLine("- Salami");
                    Console.WriteLine("- Pollo");
                } else {
                    Console.WriteLine("Tipo de pizza no válido");
                    return;
                }

                // Solicitar al usuario que seleccione un ingrediente
                Console.WriteLine("Seleccione un ingrediente:");
                string ingrediente = Console.ReadLine();

                // Comprobar si la pizza es vegetariana o no y mostrar los ingredientes
                Console.WriteLine("Su pizza es:");

                if (tipoPizza == 1) {
                    Console.WriteLine("- Vegetariana");
                    Console.WriteLine("- Tomate");
                    Console.WriteLine("- Mozzarella");
                    Console.WriteLine("- " + ingrediente);
                } else if (tipoPizza == 2) {
                    Console.WriteLine("- No vegetariana");
                    Console.WriteLine("- Tomate");
                    Console.WriteLine("- Mozzarella");
                    Console.WriteLine("- Pepperoni");
                    Console.WriteLine("- Salami");
                    Console.WriteLine("- Pollo");
                    Console.WriteLine("- " + ingrediente);
                }

                // Esperar a que el usuario presione una tecla para salir
                Console.WriteLine("Presione una tecla para salir");
                Console.ReadKey();
            break;     
            case 4:
                // Solicitar al usuario la puntuación obtenida
                Console.WriteLine("Ingrese la puntuación obtenida (0.0, 0.4, 0.6): ");
                double puntuacion = double.Parse(Console.ReadLine());

                // Determinar el nivel correspondiente y la bonificación
                string nivel = "";
                double bonificacion = 0;

                switch(puntuacion){
                    case 0.0:
                        nivel = "Inaceptable";
                        bonificacion = 0;
                        break;
                    case 0.4:
                        nivel = "Aceptable";
                        bonificacion = 50000 * 0.4;
                        break;
                    case 0.6:
                        nivel = "Meritorio";
                        bonificacion = 50000 * 0.6;
                        break;
                    default:
                        Console.WriteLine("Puntuación inválida.");
                        return;
                }

                // Mostrar los resultados en pantalla
                Console.WriteLine("Nivel de evaluación: " + nivel);
                Console.WriteLine("Bonificación ganada: $" + bonificacion);
            break  ;     
        }

    }
}
