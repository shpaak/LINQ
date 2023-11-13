using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        Students db = new Students(@"Data Source = HOME-PC\SQLEXPRESS; Initial Catalog= Students; Integrated Security = SSPI");

        private void button1_Click(object sender, EventArgs e)
        {
            // Получение параметра для проверки хранимой процедуры 
            string param = Convert.ToString(textBox1.Text);

            // Объявление переменной для хранения результата, возвращаемого процедурой
            var custquery2 = db.PipinGetStudentBySubject(param);

            // Исполнение хранимой процедуры и отображение результата в виде таблицы. 
            List<PipinGetStudentBySubjectResult> test = new
            List<PipinGetStudentBySubjectResult>(); // объявление переменной списка типа «результат работы процедуры» и его инициализация
            foreach (PipinGetStudentBySubjectResult PipinSProcedure in custquery2)
            {
                test.Add(PipinSProcedure);//Добавление нового элемента в списко

            }

            dataGridView1.DataSource = test; // Присваивание источнику данных DataGrid созданного выше списка. 
        }
    }
}
