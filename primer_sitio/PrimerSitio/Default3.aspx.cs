using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MensajeInicial();
    }
    int calcularPesoIdeal(int edad)
    {
        int pesoIdeal = edad * 2 + 8;
        return pesoIdeal;
    }

    void MostrarPesoIdeal(int pesoideal)
    {
        int peso_actual = Convert.ToInt32(txt_peso.Text);

        if (peso_actual > pesoideal)
        {
            lbl_mensaje2.Text = "El peso ideal de " + txt_nombre.Text +" es "+ pesoideal + " kilos. Está con sobrepeso";
        }
        if (peso_actual < pesoideal)
        {
            lbl_mensaje2.Text = "El peso ideal de " + txt_nombre.Text +" es "+ pesoideal + " kilos. Está bajo peso";
        }
        if (peso_actual == pesoideal)
        {
            lbl_mensaje2.Text = "El peso ideal de " + txt_nombre.Text + " es " + pesoideal + " kilos. Está con peso ideal";
        }

    }

    void MensajeInicial()
    {
        lbl_mensaje.Text = "Peso Ideal de un niño/a: ";
        lbl_edad.Text = "Ingrese la edad: ";
        lbl_nombre.Text = "Ingrese el nombre: ";
        lbl_peso.Text = "Ingrese el peso actual del niño/a: ";
    }


    String CapturaEdad()
    {
        string edad;
        edad = txt_edad.Text;
        return edad;
    }

    protected void btn_calcular_Click(object sender, EventArgs e)

    {
        
            if (PermiteEdad())
            {
                msj_close();
            }
            else
            {
                MostrarPesoIdeal(calcularPesoIdeal(Convert.ToInt16(CapturaEdad())));
            }   
       
        
    }

    Boolean PermiteEdad()
    {
        int edad_ingresada = Convert.ToInt32(CapturaEdad());
        

        bool no_es = false;
        if (edad_ingresada > 10 || edad_ingresada < 1)
            no_es = true;
        return no_es;
    }

    void msj_close() {
        lbl_mensaje2.Text = "Edad incorrecta para realizar el calculo";
    }
}