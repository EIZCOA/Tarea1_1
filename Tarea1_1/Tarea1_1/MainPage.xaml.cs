using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea1_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void btnsuma_Clicked(object sender, EventArgs e)
        {
            //Hacemos la operacion y mandamos el resultado

            int nu1 = Convert.ToInt32(edtnum1.Text);
            int nu2 = Convert.ToInt32(edtnum2.Text);
            float suma = nu1 + nu2;
            string resultadosum = suma.ToString();

            //Aqui envio parametros
             await Navigation.PushAsync(new PageMain(resultadosum));
        }

        async private void btnmultiplica_Clicked(object sender, EventArgs e)
        {
            int nu1 = Convert.ToInt32(edtnum1.Text);
            int nu2 = Convert.ToInt32(edtnum2.Text);
            float multiplica = nu1 * nu2;
            string resultadmult = multiplica.ToString();

            await Navigation.PushAsync(new PageMain(resultadmult));
        }

        async private void btndivision_Clicked(object sender, EventArgs e)
        {
            int nu1 = Convert.ToInt32(edtnum1.Text);
            int nu2 = Convert.ToInt32(edtnum2.Text);
            float division = nu1 / nu2;
            string resultadodiv = division.ToString();

            await Navigation.PushAsync(new PageMain(resultadodiv));
        }

        async private void btnresta_Clicked(object sender, EventArgs e)
        {
            int nu1 = Convert.ToInt32(edtnum1.Text);
            int nu2 = Convert.ToInt32(edtnum2.Text);
            float resta = nu1 - nu2;
            string resultadoresta = resta.ToString();
            await Navigation.PushAsync(new PageMain(resultadoresta));
        }

    }
}
