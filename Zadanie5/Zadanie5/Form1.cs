using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentListBindingSource.DataSource = DCStudentDataContextForm1.StudentList;
        }
        private DataClasses1DataContext DCStudentDataContextForm1 = new DataClasses1DataContext();

        private void studentListBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
            
                try
                {
                    DCStudentDataContextForm1.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            

        }

        private void ButtonRunQuery_Click(object sender, EventArgs e)
        {
            var StudentQuery = from StudentList in DCStudentDataContextForm1.StudentList
                               where StudentList.Surname == textBoxLastN.Text
                               select StudentList;
            studentListBindingSource.DataSource = StudentQuery;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxLastN.Clear();

            studentListBindingSource.DataSource = DCStudentDataContextForm1.StudentList; // Установить новый источник данных

            // Обновить отображение DataGridView
            studentListDataGridView.Refresh();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

        }
    }
}
