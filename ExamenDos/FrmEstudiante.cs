using AppCore.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenDos
{
    public partial class FrmEstudiante : Form
    {
        public IEstudianteService estudianteService { get; set; }
        private List<Asignatura> asignaturas;
        private List<Nota> notas;
        private int contador = 0;
        public FrmEstudiante()
        {
            notas = new List<Nota>();
            asignaturas = new List<Asignatura>()
            {
                new Asignatura(){ Id=1, Nombre="Matematica2", Credito=2},
                new Asignatura(){ Id=2, Nombre="ContabiidadDeCostos", Credito=2},
                new Asignatura(){ Id=3, Nombre="AlgebraLineal", Credito=2},
                new Asignatura(){ Id=4, Nombre="Sociologia", Credito=2},
                new Asignatura(){ Id=5, Nombre="Ingles2", Credito=2},
                new Asignatura(){ Id=6, Nombre="Programacion1", Credito=2},

            };
            InitializeComponent();
        }

        private void RegistrarAsignatura_Click(object sender, EventArgs e)
        {
            if (contador<5)
            {
                Asignatura asignatura = asignaturas[contador];
                Nota nota = new Nota()
                {
                    Asignatura = asignatura,
                    SIstematico = (int)nudPrimerp.Value,
                    PrimerParcial = (int)nudPrimerp.Value,
                    SegundoParcial = (int)nud2doParcial.Value
                };
                notas.Add(nota);
                contador++;
                MessageBox.Show($"Añadio la nota de {nota.Asignatura.Nombre}");

                FrmEstudiante_Load(sender, e); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (contador<6)
            {
                MessageBox.Show("No puede añadir al estudiante porque no le ha puesto todas las notas");
            }
            else
            {
                Estudiante estudiante = new Estudiante()
                {
                    Id = estudianteService.GetLastId(),
                    Nombre = txtApellidos.Text,
                    Apellidos = txtApellidos.Text,
                    Carnet = txtCarnet.Text,
                    Municipio = txtMunicipio.Text,
                    Departamento = txtDepartamento.Text,
                    Notas = notas,
                };
                estudianteService.Add(estudiante);
                Dispose();
            }
        }

        private void FrmEstudiante_Load(object sender, EventArgs e)
        {
            lblClase.Text = asignaturas[contador].Nombre;
        }

        private void lblClase_Click(object sender, EventArgs e)
        {

        }
    }
}
