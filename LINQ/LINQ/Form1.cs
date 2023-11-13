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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Students db = new Students(@"Data Source = HOME-PC\SQLEXPRESS; Initial Catalog= Students; Integrated Security = SSPI");

        private void button1_Click(object sender, EventArgs e)
        {
            // Получение параметра для проверки хранимой процедуры 
            int param = Convert.ToInt32(textBox1.Text);

            // Объявление переменной для хранения результата, возвращаемого процедурой
            var custquery = db.PipinGetStudentById(param);

            // Исполнение хранимой процедуры и отображение результата в виде таблицы. 
            List<PipinGetStudentByIdResult> test = new
            List<PipinGetStudentByIdResult>(); // объявление переменной списка типа «результат работы процедуры» и его инициализация
            foreach (PipinGetStudentByIdResult PipinSProcedure in custquery)
            {
                test.Add(PipinSProcedure);//Добавление нового элемента в списко

            }

            dataGridView1.DataSource = test; // Присваивание источнику данных DataGrid созданного выше списка. 


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Получение параметра для проверки хранимой процедуры 
            string param2 = Convert.ToString(textBox2.Text);

            // Объявление переменной для хранения результата, возвращаемого процедурой
            var custquery2 = db.PipinGetStudentByName(param2);

            // Исполнение хранимой процедуры и отображение результата в виде таблицы. 
            List<PipinGetStudentByNameResult> test = new
            List<PipinGetStudentByNameResult>(); // объявление переменной списка типа «результат работы процедуры» и его инициализация
            foreach (PipinGetStudentByNameResult PipinSProcedure in custquery2)
            {
                test.Add(PipinSProcedure);//Добавление нового элемента в списко

            }

            dataGridView1.DataSource = test; // Присваивание источнику данных DataGrid созданного выше списка. 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

        }
    }
}
