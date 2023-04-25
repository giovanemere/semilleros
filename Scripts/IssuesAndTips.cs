using UnityEngine;

public class IssuesAndTips : MonoBehaviour
{
    public string[] tips, issues;
    public bool[] isShownMessage;
    public static int questionsCounter;
    public static int selectedAnswer;
    void Start()
    {
        InitializateTips();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void InitializateTips()
    {
        tips[0] = "Todo buen negocio empieza con una buena idea y antes de empezar cualquier empresa debes crear un plan de negocios que te permita conseguir inversores para tener un capital.";
        tips[1] = "Una empresa se puede dividir en varios departamentos para que puedan trabajar de forma eficiente y desarrollar funciones especificas. Una empresa al menos tiene un área de: producción, finanzas, tecnologías, marketing y recursos humanos.";
        tips[2] = "Es el departamento encargado de organizar, gestionar y administrar los empleados de una empresa.";
        tips[3] = "La idea del capital humano como valor empresarial nació por Frederick Taylor, el cual introdujo conceptos sobre la eficiencia y la productividad.";
        tips[4] = "El jefe de producción siempre debe cuidar que los procesos y el producto sea de la calidad que corresponde, sin olvidar que se deben mantener los costos y cumplir los plazos.";
        tips[5] = "Si pones precios muy altos , tus clientes podrían irse con la competencia y si tus precios son muy bajos puedes perder dinero";
        tips[6] = "El marketing es el conjunto de estrategias y estudios que tienen como objeto la mejora de la comercialización de un producto";
        tips[7] = "Artículo 269F: Violación de datos personales. El que obtenga, sustraiga o ofrezca datos personales contenidas en bases de datos o archivos";
        tips[8] = "Artículo 269E: Uso de software malicioso. El que produzca, adquiera o introduzca programas con efectos dañinos a un sistema.";
        tips[9] = "Artículo 269D: Daño Informático. El que destruya, dañe o borre datos informáticos, incurrirá en una pena de prisión de 48 meses y una multa del 100 a 1000 SMLV";
        tips[10] = "El DOFA es un método de análisis empresarial que permite conocer los diferentes aspectos internos y externos de la empresa para ayudarnos a definir los problemas y posibles soluciones";
        tips[11] = "La función principal del área de producción es transformar insumos o recursos en productos o servicios para los consumidores";
        tips[12] = "Recuerda que Los factores de producción son el trabajo, el capital y los recursos naturales.";
        tips[13] = "Medir el clima y satisfacción laboral de los empleados sirve para detectar problemas a tiempo y incrementa la productividad de los empleados";
        tips[14] = "La gestión administrativa del personal son las tareas jurídico-administrativas relacionadas con los contratos, nóminas, seguros sociales, permisos, bajas por enfermedad, vacaciones, ausencias, control horario y similares.";
        tips[15] = "Inflación: es el aumento de los precios por un periodo de tiempo prologado.";
        tips[16] = "Oferta: cantidad de un bien o servicio que hay en el mercado.";
        tips[17] = "Demanda: cantidad de un bien o servicio que es consumido por los compadores.";
        tips[18] = "Costo de  oportunidad: es el valor más alto al que se debe renunciar cuando se cuenta con varias alternativas y se decide por una opción determinada.";
        tips[19] = "Principio de escazes: El trabajo, el capital y la tierra son recursos escasos y por lo tanto tienen un costo de oportunidad";
        tips[20] = "Inversión: es una cantidad limitada de dinero que se pone a disposición de terceros con el fin de lograr beneficios o ganancias.";
        tips[21] = "Oferta: cantidad de un bien o servicio que hay en el mercado y Demanda: cantidad de un bien o servicio que es consumido por los compadores.";
    }

    void InitializateIssues()
    {

    }
}
