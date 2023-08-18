using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Risxpert
{


    public partial class Form_Risxpert : Form
    {
        List<Riesgo> Riesgos = new List<Riesgo>();


        int CELL_DANO = 0;
        int CELL_ID = 1;
        int CELL_NAME = 2;
        int CELL_TIPO = 3;
        int CELL_ACTIVO = 4;
        int CELL_ANALISTA = 5;
        int CELL_FECHA = 6;
        //int Row = 0;

        List<Riesgo2> Riesgos2 = new List<Riesgo2>();

        public int F { get; set; }
        public int S { get; set; }
        public int P { get; set; }
        public int E { get; set; }
        public int A { get; set; }
        public int V { get; set; }







        /*
         private void SaveData(int i)
         {
             MessageBox.Show("¡El botón fue clicado!");
             using (var db = new LiteDatabase(@"C:\Programación\Programación para Mecatrónicos\PPM\Tarea 9\Risxpert program\Risxpert\Data Base Lite DB Risxpert\Risxpert.txt")) { }
            
        /*var col = db.GetCollection
         }
        */

        /*
        private string nombre; // Variable para almacenar el nombre
        private string fecha; //Variable para almacenar el nombre
        private string activo;
        private string tipo;
        private string analista;
        private string daño;*/





        //Riesgo = new Riesgo(int n);







        public Form_Risxpert()
        {
            InitializeComponent();
            dataGridView4.CellFormatting += dataGridView4_CellFormatting;
        }










        private void Form1_Load(object sender, EventArgs e)
        {






            /*
            List<Riesgo> Riesgos = new List<Riesgo>();
            {
                Riesgos.Add(item: new Riesgo {Ref = 1, Id = 1, Activo = "", Nombre = "", Tipo = "", Daño = "" });
                ActualizarDataGridView();
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add("", "", "", "", "");


            }*/
            //lblMensaje.Text = "";
            /* if (FileDialog.Exists("database.txt"))
             {
                 return;
             }
             StreamWriter archivo = new StreamWriter("database.txt");
             archivo.Close();*/
        }





        //Añadir datos a la tabla


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex];
                int newValue;

                if (int.TryParse(cell.Value?.ToString(), out newValue))
                {
                    // Validar que el valor ingresado esté en el rango de 1 a 5
                    if (newValue < 1 || newValue > 5)
                    {
                        MessageBox.Show("Por favor ingrese un valor entre 1 y 5.");
                        cell.Value = null;
                        return;
                    }
                }
                else
                {
                    // Si no es un número entero válido, borra el valor ingresado
                    cell.Value = null;
                }
            }
        }

        private void dataGridView3_CellValueValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (!string.IsNullOrEmpty(e.FormattedValue?.ToString()))
                {
                    int newValue;
                    if (!int.TryParse(e.FormattedValue?.ToString(), out newValue))
                    {
                        e.Cancel = true;
                        dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Debe ingresar un número entero.";
                    }
                    else
                    {
                        dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = string.Empty;
                    }
                }
            }
        }

        private void EnviarDatosDataGridView3DataGridView4(DataGridView dataGridView3, DataGridView dataGridView4)
        {
            // Obtener la fila actualmente seleccionada en DataGridView3
            DataGridViewRow selectedRow = dataGridView3.CurrentRow;

            // Verificar si la fila no es nueva y contiene datos válidos
            if (!selectedRow.IsNewRow && !selectedRow.Cells.Cast<DataGridViewCell>().Any(cell => !string.IsNullOrEmpty(cell.ErrorText)))
            {
                // Obtener los valores de las celdas del DataGridView3
                int valorF = Convert.ToInt32(selectedRow.Cells["F"].Value);
                int valorS = Convert.ToInt32(selectedRow.Cells["S"].Value);
                int valorP = Convert.ToInt32(selectedRow.Cells["P"].Value);
                int valorE = Convert.ToInt32(selectedRow.Cells["E"].Value);
                int valorA = Convert.ToInt32(selectedRow.Cells["A"].Value);
                int valorV = Convert.ToInt32(selectedRow.Cells["V"].Value);

                // Agregar una nueva fila al DataGridView4 con los valores obtenidos
                int n = dataGridView4.Rows.Add(valorF, valorS, valorP, valorE, valorA, valorV);

                // Limpiar las celdas de la fila actual en DataGridView3 después de agregar los datos
                selectedRow.Cells["F"].Value = null;
                selectedRow.Cells["S"].Value = null;
                selectedRow.Cells["P"].Value = null;
                selectedRow.Cells["E"].Value = null;
                selectedRow.Cells["A"].Value = null;
                selectedRow.Cells["V"].Value = null;

                // Mover la selección a la siguiente fila si no es la última fila
                if (selectedRow.Index < dataGridView3.Rows.Count - 1)
                {
                    dataGridView3.CurrentCell = dataGridView3.Rows[selectedRow.Index + 1].Cells["F"];
                }
            }
        }


        private void dataGridView3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Obtener la fila actualmente seleccionada en DataGridView3
                DataGridViewRow selectedRow = dataGridView3.CurrentRow;

                // Verificar si la fila no es nueva y contiene datos válidos
                if (!selectedRow.IsNewRow && !selectedRow.Cells.Cast<DataGridViewCell>().Any(cell => !string.IsNullOrEmpty(cell.ErrorText)))
                {
                    // Obtener los valores de las celdas del DataGridView3
                    int valorF = Convert.ToInt32(selectedRow.Cells["F"].Value);
                    int valorS = Convert.ToInt32(selectedRow.Cells["S"].Value);
                    int valorP = Convert.ToInt32(selectedRow.Cells["P"].Value);
                    int valorE = Convert.ToInt32(selectedRow.Cells["E"].Value);
                    int valorA = Convert.ToInt32(selectedRow.Cells["A"].Value);
                    int valorV = Convert.ToInt32(selectedRow.Cells["V"].Value);

                    // Agregar una nueva fila al DataGridView4 con los valores obtenidos
                    int n = dataGridView4.Rows.Add(valorF, valorS, valorP, valorE, valorA, valorV);

                    // Limpiar las celdas de la fila actual en DataGridView3 después de agregar los datos
                    selectedRow.Cells["F"].Value = null;
                    selectedRow.Cells["S"].Value = null;
                    selectedRow.Cells["P"].Value = null;
                    selectedRow.Cells["E"].Value = null;
                    selectedRow.Cells["A"].Value = null;
                    selectedRow.Cells["V"].Value = null;

                    // Mover la selección a la siguiente fila si no es la última fila
                    if (selectedRow.Index < dataGridView3.Rows.Count - 1)
                    {
                        dataGridView3.CurrentCell = dataGridView3.Rows[selectedRow.Index + 1].Cells["F"];
                    }
                }

                // Evitar que se propague el evento
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }






        private void EliminarPrimeraFila(object sender, EventArgs e)
        {

            List<Riesgo> Riesgos = new List<Riesgo>();

            try
            {
                // Verificar si hay al menos una fila en la lista Riesgos
                if (Riesgos.Count > 0)
                {
                    // Eliminar la primera fila de la lista Riesgos
                    Riesgos.RemoveAt(0);

                    // Actualizar el DataGridView con los datos actualizados
                    //ActualizarDataGridView();

                    MessageBox.Show("Primera fila eliminada correctamente.");
                }
                else
                {
                    MessageBox.Show("La lista de Riesgos está vacía.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la primera fila: " + ex.Message);
            }
        }

        //private void ActualizarDataGridView()
        //{

        //    List<Riesgo> Riesgos = new List<Riesgo>();

        //    // Limpiar el DataGridView
        //    // dataGridView1.Rows.Clear();

        //    // Agregar los datos actualizados a partir de la lista Riesgos al DataGridView
        //    foreach (Riesgo riesgo in Riesgos)
        //    {
        //        dataGridView1.Rows.Add(riesgo.Id, riesgo.Activo, riesgo.Nombre, riesgo.Tipo, riesgo.Daño);
        //    }
        //    //dataGridView1.Rows.Clear();

        //}

        /*private void tabControl_Selected(object sender, TabControlEventArgs e)
        { 
            for (int i = 0; i < dataGridView1.Rows.Count;)
            {
                UpdateTab2(i);
                UpdateTab3(i);
                UpdateTab4(i);
            }
        }*/

        //private void UpdateTab2(int i)
        //{
        //    Riesgos = Riesgos[i];

        //}




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*  Analista = txtAnalista.Text;*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            // Verifica que el índice de fila y columna sea válido
            if (rowIndex >= 0 && columnIndex >= 0)
            {
                object cellValue = dataGridView1.Rows[rowIndex].Cells[columnIndex].Value;
            }




        }



        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            using (var db = new LiteDatabase(@"C:\Programación\Programación para Mecatrónicos\PPM\Tarea 9\RisXpert Final\RisXpert Final\Risxpert\Data Base Lite DB Risxpert\Risxpert.db"))
            {
                var datosCollection = db.GetCollection<Riesgo>("Riesgo");

                // Borra la colección antes de insertar si lo deseas
                datosCollection.DeleteAll();

                datosCollection.InsertBulk(Riesgos); // Insertar todos los documentos

                MessageBox.Show("Datos guardados en la base de datos.");
            }

        }



        private void TxtFecha_TextChanged(object sender, EventArgs e)
        {

        }


        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            Riesgo newRiesgo = new Riesgo();
            Riesgos.Add(newRiesgo);

            int n = dataGridView1.Rows.Add();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Riesgos;


            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Riesgo r1 = new Riesgo();
            r1.Id = Int32.Parse(txtId.Text);
            r1.Activo = txtActivo.Text;
            r1.Nombre = txtNombre.Text;
            r1.Tipo = txtTipo.Text;
            r1.Daño = txtDano.Text;
            r1.Analista = txtAnalista.Text;
            r1.Fecha = txtFecha.Text;
            


            Riesgos.Add(r1);


            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Riesgos;

            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDano.Text = string.Empty;
            txtActivo.Text = string.Empty;
            txtTipo.Text = string.Empty;
            txtAnalista.Text = string.Empty;
            txtFecha.Text = string.Empty;


            dataGridView1.Refresh();

            try
            {
                r1.Id = Int32.Parse(txtId.Text);
                r1.Activo = txtActivo.Text;
                r1.Nombre = txtNombre.Text;
                r1.Tipo = txtTipo.Text;
                r1.Daño = txtDano.Text;
                r1.Analista = txtAnalista.Text;
                r1.Fecha = txtFecha.Text;
            }
            catch (FormatException)
            {
                // MessageBox.Show("El valor de ID debe ser un número válido.");
            }

            AgregarDatosDataGridView2();
            AgregarDatosDataGridView5();


        }

        private void AgregarDatosDataGridView2()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = Riesgos;

        }
        private void AgregarDatosDataGridView4()
        {
            dataGridView4.DataSource = null;

            

            dataGridView4.DataSource = Riesgos;
            dataGridView4.DataSource = Riesgos2;

           
        }

        private void AgregarDatosDataGridView5()
        {
            dataGridView5.DataSource = null;
            dataGridView5.DataSource = Riesgos;

        }

        private void AgregarDatosDataGridView6()
        {
           
            dataGridView6.DataSource = null;
            dataGridView6.DataSource = Riesgos2;
        }


        private void UpdateData(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var r1 = dataGridView1.Rows[i];

                r1.Cells[CELL_ID].Value = txtId.Text;
                r1.Cells[CELL_ACTIVO].Value = txtActivo.Text;
                r1.Cells[CELL_NAME].Value = txtNombre.Text;
                r1.Cells[CELL_TIPO].Value = txtTipo.Text;
                r1.Cells[CELL_DANO].Value = txtDano.Text;
                r1.Cells[CELL_ANALISTA].Value = txtAnalista.Text;
                r1.Cells[CELL_FECHA].Value = txtFecha.Text;

            }
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {

            Riesgo2 r2 = new Riesgo2();

            r2.F = Int32.Parse(txtF.Text);
            r2.S = Int32.Parse(txtS.Text);
            r2.P = Int32.Parse(txtP.Text);
            r2.E = Int32.Parse(txtE.Text);
            r2.A = Int32.Parse(txtA.Text);
            r2.V = Int32.Parse(txtV.Text);

            Riesgos2.Add(r2);

            dataGridView3.DataSource = null;
            dataGridView3.DataSource = Riesgos2;

            txtF.Text = string.Empty;
            txtS.Text = string.Empty;
            txtP.Text = string.Empty;
            txtE.Text = string.Empty;
            txtA.Text = string.Empty;
            txtV.Text = string.Empty;


            dataGridView3.Refresh();

            try
            {
                r2.F = Int32.Parse(txtF.Text);
                r2.S = Int32.Parse(txtS.Text);
                r2.P = Int32.Parse(txtP.Text);
                r2.E = Int32.Parse(txtE.Text);
                r2.A = Int32.Parse(txtA.Text);
                r2.V = Int32.Parse(txtV.Text);
            }
            catch (FormatException)
            {
                //MessageBox.Show("El valor de ID debe ser un número válido.");
            }

            
                        AgregarDatosDataGridView4();


        }

        private void dataGridView4_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
                {
                    int valor = Convert.ToInt32(cell.Value);
                    Color color = GetColorForValue(valor);
                    cell.Style.BackColor = color;
                }
            }
        }

        private Color GetColorForValue(int valor)
        {
            switch (valor)
            {
                case 1:
                    return Color.LightGreen;
                case 2:
                    return Color.Green;
                case 3:
                    return Color.Yellow;
                case 4:
                    return Color.Orange;
                case 5:
                    return Color.Red;
                default:
                    return Color.White; // Color predeterminado si no coincide con ninguno de los valores anteriores
            }
        }


        private int mitigacionCounter = 1;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView4.Rows)
            {
                if (!row.IsNewRow)
                {
                    int F = Convert.ToInt32(row.Cells["F"].Value);
                    int S = Convert.ToInt32(row.Cells["S"].Value);
                    int P = Convert.ToInt32(row.Cells["P"].Value);
                    int E = Convert.ToInt32(row.Cells["E"].Value);
                    int A = Convert.ToInt32(row.Cells["A"].Value);
                    int V = Convert.ToInt32(row.Cells["V"].Value);

                    int I = F * S;
                    int D = P * E;
                    int C = I + D;
                    int PB = A * V;
                    int ER = C * PB;

                    // Actualizar las celdas PB y ER en el DataGridView4
                    row.Cells["PB"].Value = PB;
                    row.Cells["ER"].Value = ER;
                }
            }

            // Limpiar el DataGridView6 antes de agregar los datos calculados
            dataGridView6.Rows.Clear();

            // Definir las columnas del DataGridView6 si aún no están definidas
            if (dataGridView6.Columns.Count == 0)
            {
                dataGridView6.Columns.Add("ID", "ID");
                dataGridView6.Columns.Add("Nombre", "Nombre");
                dataGridView6.Columns.Add("CR", "CR");
                dataGridView6.Columns.Add("Mitigacion", "Mitigacion");
            }

            int mitigacionCounter = 1; // Inicializar el contador

            // Calcular la mitigación y agregarla al DataGridView6
            foreach (DataGridViewRow row in dataGridView4.Rows)
            {
                if (!row.IsNewRow)
                {
                    int ER;
                    int PB;
                    if (int.TryParse(row.Cells["ER"].Value?.ToString(), out ER) &&
                        int.TryParse(row.Cells["PB"].Value?.ToString(), out PB))
                    {
                        int CR = ER * PB;

                        // Obtener el Nombre del DataGridView1
                        string Nombre = dataGridView1.Rows[row.Index].Cells["Nombre"].Value.ToString();

                        // Agregar los valores al DataGridView6
                        dataGridView6.Rows.Add(txtId.Text, Nombre, CR, mitigacionCounter);

                        mitigacionCounter++;
                    }
                    else
                    {
                        MessageBox.Show("Error de formato en las celdas ER o PB en la fila " + (row.Index + 1));
                    }
                }
            }
        }




        public class Riesgo
        {
            //  public int Ref { get; set; }
            public int Id { get; set; }
            public string Activo { get; set; }
            public string Nombre { get; set; }
            public string Tipo { get; set; }
            public string Daño { get; set; }
            public string Analista { get; set; }
            public string Fecha { get; set; }
            //public bool Estado { get; set;}



            internal object Add(Riesgo riesgos)
            {
                throw new NotImplementedException();
            }
        }
        public class Riesgo2
        {
            //public int ID { get; set; }
            public int F { get; set; }
            public int S { get; set; }
            public int P { get; set; }
            public int E { get; set; }
            public int A { get; set; }
            public int V { get; set; }
            //public int I { get; set; }
            //public int D { get; set; }
            //public int C { get; set; }
            public int PB { get; set; }
            public int ER { get; set; }

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }
    }
}
