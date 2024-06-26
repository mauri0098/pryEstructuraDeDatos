﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDeDatos
{
    public partial class frmEstructurasDeDatos : Form
    {
        public frmEstructurasDeDatos()
        {
            InitializeComponent();
        }

        private void repasoDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDatosRepasoOperaciones frmBaseDatosRepasoOperaciones  = new   frmBaseDatosRepasoOperaciones();
            frmBaseDatosRepasoOperaciones.ShowDialog();
        }

        private void datosDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDeAlumnos alumnos = new frmDatosDeAlumnos();
            alumnos.ShowDialog();

        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstructuraDeDatos_Cola Cola = new frmEstructuraDeDatos_Cola();
            Cola.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstructuraDeDatos_Pila Pila = new frmEstructuraDeDatos_Pila();
            Pila.ShowDialog();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstructuraDeDatos_ListaSimple ListaSimple = new frmEstructuraDeDatos_ListaSimple();
            ListaSimple.ShowDialog();
        }

        private void frmEstructurasDeDatos_Load(object sender, EventArgs e)
        {

        }

        private void listaDespleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstructuraDeDatos_ListaDoble ListaDoble  = new frmEstructuraDeDatos_ListaDoble();
            ListaDoble.ShowDialog();    
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstructuraDeDatos_ArbolBinario ArbolBinario = new frmEstructuraDeDatos_ArbolBinario();
            ArbolBinario.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void operacioensConToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDatosOperaciones  BaseDatosOp = new frmBaseDatosOperaciones();
            BaseDatosOp.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDatosConsulta frmBaseDatosConsulta = new frmBaseDatosConsulta();
            frmBaseDatosConsulta.ShowDialog();
        }
    }
}
