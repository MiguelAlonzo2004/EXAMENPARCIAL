using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EXAMENPARCIAL
{
    public partial class _Default : Page
    {
        public void Grabar(List<Animal> animales)
        {
            string json = JsonConvert.SerializeObject(animales);
            string archivo = System.Web.HttpContext.Current.Server.MapPath("Datos.json");
            System.IO.File.WriteAllText(archivo, json);
        }


        public List<Animal> Leer()
        {
            List<Animal> lista = new List<Animal>();
            string archivo = System.Web.HttpContext.Current.Server.MapPath("Datos.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            if (json != null)
            {
            }


            return lista;


        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Animal> animales = new List<Animal>();
            animales = Leer();


            if (animales == null)
                animales = new List<Animal>();

            Animal animalExiste = animales.Find(u => u.Nombre == TextBoxNombre.Text);
            if (animalExiste == null)
            {
                Animal animalNuevo = new Animal();

                animalNuevo.Nombre = TextBoxNombre.Text;
                animalNuevo.Especie = TextBoxEspecie.Text;
                animalNuevo.Alimentación = TextBoxAlimentacion.Text;
                animalNuevo.Tiempovida = Convert.ToInt32(TextBoxTiempo.Text);

                Ave aveNueva = new Ave();
                aveNueva.Vuelaono = DropDownList1.SelectedValue;
                aveNueva.Incubacion = Convert.ToInt32(TextBoxIncubacion.Text);

                animalNuevo.Aves.Add(aveNueva);

                
                animales.Add(animalNuevo);
            }
            else 
            {
                
                Ave aveExiste = animalExiste.Aves.Find(a => a.Nombre == TextBoxNombre.Text);


                if (aveExiste == null)
                {


                    Ave aveNueva = new Ave();
                    aveNueva.Vuelaono = DropDownList1.SelectedValue;
                    aveNueva.Incubacion = Convert.ToInt32(TextBoxIncubacion.Text);


                    

                    animalExiste.Aves.Add(aveNueva);

                }
               
            Grabar(animales);

        }
    }
}
    }
