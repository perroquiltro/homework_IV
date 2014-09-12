using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default4 : System.Web.UI.Page
{
    double pesoIdeal;
    bool no_es;

    Boolean tipo_edad;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        MensajeInicial();
        
    }
    Double calcularPesoIdeal(double edad)
    {
        if (!unidad_edad() && edad >= 3 || !unidad_edad() && edad <= 12)
        {
            pesoIdeal = (edad + 9) / 2;
        }

        if (unidad_edad() && edad >= 2 || unidad_edad() && edad <= 6)
        {
            pesoIdeal = (edad * 2) + 8.5;
        }
        if (unidad_edad() && edad >= 7 || unidad_edad() && edad <= 15)
        {
            pesoIdeal = (edad * 3) + 3;
        }
            return (pesoIdeal);
    }

    void MostrarPesoIdeal(double pesoideal)
    {
        double peso_actual = Convert.ToDouble(txt_peso.Text);

        if (unidad_edad())
        {
            if (peso_actual > pesoideal)
            {
                lbl_mensaje2.Text = "El peso ideal de " + txt_nombre.Text + " es " + pesoideal + " Kilos. Está con sobrepeso";
            }
            if (peso_actual < pesoideal)
            {
                lbl_mensaje2.Text = "El peso ideal de " + txt_nombre.Text + " es " + pesoideal + " Kilos. Está bajo peso";
            }
            if (peso_actual == pesoideal)
            {
                lbl_mensaje2.Text = "El peso ideal de " + txt_nombre.Text + " es " + pesoideal + " Kilos. Está con peso ideal";
            }
            
        }

        if (!unidad_edad())
        {

            if (peso_actual > pesoideal)
            {
                lbl_mensaje2.Text = "El peso ideal de " + txt_nombre.Text + " es " + pesoideal + " gramos. Está con sobrepeso";
            }
            if (peso_actual < pesoideal)
            {
                lbl_mensaje2.Text = "El peso ideal de " + txt_nombre.Text + " es " + pesoideal + " gramos. Está bajo peso";
            }
            if (peso_actual == pesoideal)
            {
                lbl_mensaje2.Text = "El peso ideal de " + txt_nombre.Text + " es " + pesoideal + " gramos. Está con peso ideal";
            }
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
            MostrarPesoIdeal(calcularPesoIdeal(Convert.ToDouble(CapturaEdad())));

        }
        else {
            if (!PermiteEdad())
            {
                msj_close();

            }
        }
    }

    Boolean PermiteEdad()
    {
        int edad_ingresada = Convert.ToInt32(CapturaEdad());
        if (unidad_edad())
        {           
            if (edad_ingresada > 15 || edad_ingresada < 2)
            {
                no_es = false;
            }
        }
        if (!unidad_edad())
        {
            if (edad_ingresada > 12 || edad_ingresada < 3)
            {
                no_es = false;
            }
        }
        return no_es;
    }

    void msj_close()
    {
        lbl_mensaje2.Text = "Edad incorrecta para realizar el calculo";
    }
    Boolean unidad_edad() {
        if (radiobutton_month.Checked)
        {
            tipo_edad = false;
        }
        else {
            if (radiobutton_year.Checked)
            {
                tipo_edad = true;
            }
        }
        return tipo_edad;
    }
}

