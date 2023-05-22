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
                lista = JsonConvert.DeserializeObject<List<Animal>>(json);
            }


            return lista;


        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Animal> animales = new List<Animal>();
            albumes = archivo.Leer();

            //si es la primera vez que se corre hay que crear la lista de universidad
            //pues el archivo estará en blanco
            if (albumes == null)
                albumes = new List<Album>();

            //ver si la universidad que se está ingresando ya existe
            Album albumExiste = albumes.Find(u => u.Titulo == DropDownListAlbumes.SelectedValue);

            //si no existe la universidad crear una nueva
            if (albumExiste == null)
            {
                //Crear una nueva universidad
                Album albumNueva = new Album();

                //El nombre de la universidad se trae desde el dropdownlist
                albumNueva.Titulo = DropDownListAlbumes.SelectedValue;
                albumNueva.Artista = txtArtista.Text;
                albumNueva.Publicacion = txtFecha.Text;


                ////crear un nuevo alumno
                //Alumno alumnoNuevo = new Alumno();
                ////el nombre del alumno se trae desde el textbox
                //alumnoNuevo.Nombre = TextBoxAlumno.Text;

                //crear el nuevo curso
                Cancion cancionNueva = new Cancion();
                //el nombre del curso y la nota se traen desde los textbox
                cancionNueva.Nombre = txtcancion.Text;
                cancionNueva.Duracion = Convert.ToInt16(txtDuracion.Text);

                ////Al alumno se le agrega el curso nuevo
                //alumnoNuevo.Cursos.Add(cursoNuevo);

                //A la universidad se le agregar el alumno nuevo
                albumNueva.Canciones.Add(cancionNueva);

                //A la lista de universidades se le agrega la nueva universidad
                albumes.Add(albumNueva);
            }
            else //si la universidad ya existe
            {
                //Busar si el alumno ya existe dentro de esa universidad
                //Alumno alumnoExiste = universidadExiste.Alumnos.Find(a => a.Nombre == TextBoxAlumno.Text);
                Cancion cancionExiste = albumExiste.Canciones.Find(a => a.Nombre == txtcancion.Text);

                //Si el alumno no existe crear un nuevo alumno
                if (cancionExiste == null)
                {
                    //Alumno alumnoNuevo = new Alumno();
                    //alumnoNuevo.Nombre = TextBoxAlumno.Text;

                    Cancion cancionNueva = new Cancion();
                    cancionNueva.Nombre = txtcancion.Text;
                    cancionNueva.Duracion = Convert.ToInt32(txtDuracion.Text);


                    ////como es un alumno nuevo se crea el curso, sin buscar si ya existe
                    //Curso cursoNuevo = new Curso();
                    ////el nombre del curso y la nota se traen desde los textbox
                    //cursoNuevo.Nombre = TextBoxCurso.Text;
                    //cursoNuevo.Nota = Convert.ToInt16(TextBoxNota.Text);

                    //alumnoNuevo.Cursos.Add(cursoNuevo);

                    //agregamos al alumno con sus cursos a la universidad existente

                    albumExiste.Canciones.Add(cancionNueva);

                }
                //else //si el alumno ya existe, ver si el curso ya existe
                //{
                //    Curso cursoExiste = alumnoExiste.Cursos.Find(c => c.Nombre == TextBoxCurso.Text);

                //    //si el curso no existe se crea un nuevo curso
                //    if (cursoExiste == null)
                //    {
                //        //Se crea un nuevo curso
                //        Curso cursoNuevo = new Curso();
                //        //el nombre del curso y la nota se traen desde los textbox
                //        cursoNuevo.Nombre = TextBoxCurso.Text;
                //        cursoNuevo.Nota = Convert.ToInt16(TextBoxNota.Text);

                //        //se agrega el curso al alumno 
                //        alumnoExiste.Cursos.Add(cursoNuevo);
                //    }
                //}
            }

            //Se manda a grabar la lista de universidades
            Grabar(animales);

        }
    }
}
    }
}