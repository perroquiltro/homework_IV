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
        EscribeTextos();

    }
    protected void btn_calcular_Click(object sender, EventArgs e)
    {
        MuestraPesoIdeal(calculaPeso());
    }

    int calculaPeso(){
        int edad1 = Convert.ToInt16(CapturaTexto());
        int pesoIdeal = edad1*2+8;
         return pesoIdeal;
    }

    void MuestraPesoIdeal(int pesoideal) {
        lbl_pesoIdeal.Text = "El peso ideal del niño es: " + pesoideal;
    }

    void EscribeTextos() {
        lbl_mensaje.Text = "Peso Ideal de un niño/a";
        lbl_edad.Text = "Ingrese la Edad:";
        
    }

    String CapturaTexto() {
        string texto;
        texto = txt_edad.Text;
        return texto;
    }

 

}