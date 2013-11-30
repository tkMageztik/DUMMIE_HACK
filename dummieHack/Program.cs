using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace dummieHack
{
    static class Program
    {


        /* US:
   * <Taurox is a program designed for an unlimited dowload of documents (e-books) of the website>
   * "Libros Tauro" (http://www.librostauro.com.ar/) >
   * Copyright (C) <2012>  <Juan José Ruiz de Castilla>
   * This program is free software: you can redistribute it and/or modify
   * it under the terms of the GNU General Public License as published by
   * the Free Software Foundation, either version 3 of the License, or
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
   * Derechos de copia (C) <2012>  <Juan José Ruiz de Castilla>
   *  Este programa es un software libre: tu puedes redistribuirlo y/o modificarlo
   *  bajo los terminos de GNU Licencia pública general publicada por 
   *  the Free Software Foundation,  ya sea la versión 3 de la Licencia, o
   * (A su elección) cualquier versión posterior.
   * Este programa es distribuido con la esperanza que sea útil,
   * pero SIN NINGUNA GARANTIA; incluso sin la garantía implícita de
   * COMERCIALIZACIÓN O IDONEIDAD POR UN PROPÓSITO EN PARTICULAR. Ver la 
   * GNU General Public License para más detalles.
   * Debería haber recibido una copia de la GNU General Public Licence
   * junto con este programa. Si no es así, ver <http://www.gnu.org/licenses/>
   * 
   * Cualquier consulta al respecto, les ruego escribirme a la siguiente dirección electrónica:
         * jruizdecastillaramirez@gmail.com     ó
         * jujex_90@hotmail.com
   */

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrincipal());
        }
    }
}
