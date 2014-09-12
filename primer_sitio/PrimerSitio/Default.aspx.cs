using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MensajeInicial();

    }
    protected void btn_calcular_Click(object sender, EventArgs e)
    {
        MostrarPesoIdeal(calcularPesoIdeal(Convert.ToInt16(CapturaEdad())));
    }

    int calcularPesoIdeal(int edad){
        int pesoIdeal = edad*2+8;
         return pesoIdeal;
    }

    void MostrarPesoIdeal(int pesoideal) {
        lbl_pesoIdeal.Text = "El peso ideal del niño es: " + pesoideal;
    }

    void MensajeInicial() {
        lbl_mensaje.Text = "Peso Ideal de un niño/a";
        solicitarEdad();
        
    }

    void solicitarEdad() {
        lbl_edad.Text = "Ingrese la Edad: ";
    }

    String CapturaEdad() {
        string edad;
        edad = txt_edad.Text;
        return edad;
    }

 

}