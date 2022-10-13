using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace trabalho_3
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button_iniciar_Click(object sender, EventArgs e)
        {
            String agitação = "em ingles é chamado de shaking ou cocktail \n\n" +
                "complexidade: é de O(n^2) para o pior caso ou caso medio mas se a lista tiver parcialmente ordenada a complexidade é de o(n) " +
                "estabilidade: não estavel ";
            String bolha = "em ingles é chamado de bubble sort \n" +
                "complexidade: é de O(n^2) para o pior caso ou caso medio e O(n) se a lista ja tiver ordenada \n" +
                "estabilidade: estavel";
            String heapSort="em ingles é HeapSort \n" +
                "complexidade: é de O(n log n) em todos os casos \n" +
                "estabilidade: não estavel";
            String insercao = "em ingles é chamado de insetion\n" +
                "complexidade: é de O(n^2) para o pior ou medio caso e no melhor caso é de O(n) \n" +
                "estabilidade: estavel ";
            
            String pente = "em ingles é chamado de Comb Sort \n" +
                "complexidade: é de O(n^2) no pior caso, O(n^2/2^p) onde p é o numero de incremento e O(n log n) para o melhor caso \n" +
                "estabilidade: não estavel";
            String quick ="em ingles é chamado de quicksort \n" +
                "complexidade: é de O(n^2) no pior caso, e no medio ou melhor caso é de O(n log n) \n" +
                "estabilidade: não estavel";
            String selecao = "em ingles é chamado de selection sort \n" +
                "complexidade: em todos os casos é de O(n^2) \n" +
                "estabilidade: não estavel \n";
                
            String shellSort = "em ingles é chamado de shell sort \n" +
                "complexidade: a media é de O(n log n) porem a complexidade desse algoritimo varia bastante porque depende do gap(numero de sublistas criadas) \n" +
                "estabilidade: não estavel";

            
            panel_inf.Visible = false;
            if(comboBox.SelectedIndex == 0)
            {
                textBox_inf.Text = agitação;
            }
            if (comboBox.SelectedIndex == 1)
            {
                textBox_inf.Text = bolha;
            }
            if (comboBox.SelectedIndex == 2)
            {
                textBox_inf.Text = heapSort;
            }
            if (comboBox.SelectedIndex == 3)
            {
                textBox_inf.Text = insercao;
            }
            if (comboBox.SelectedIndex == 4)
            {
                textBox_inf.Text = pente;
            }
            if (comboBox.SelectedIndex == 5)
            {
                textBox_inf.Text = quick;
            }
            if (comboBox.SelectedIndex == 6)
            {
                textBox_inf.Text = selecao;
            }
            if (comboBox.SelectedIndex == 7)
            {
                textBox_inf.Text = shellSort;
            }
        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            textBox_inf.Clear();
            textBox_comp.Clear();
            textBox.Clear();
            panel_comp.Visible = true;
            panel_inf.Visible = true;
        }

        private void button_exec_Click(object sender, EventArgs e)
        {
            panel_comp.Visible = false;
            List<int> list = new List<int>();
            int valor =  int.Parse(textBox.Text);
            Random r = new Random();
            for(int i = 0; i < valor; i++)
            {
                list.Add(r.Next(1000));  
            }
            if (comboBox.SelectedIndex == 0)
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                Ordena.agitacao(list);
                stopwatch.Stop();
                textBox_comp.Text = "Tempo passado: "+stopwatch.Elapsed.TotalSeconds;



            }
            if (comboBox.SelectedIndex == 1)
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                Ordena.bolha(list);
                stopwatch.Stop();
                textBox_comp.Text = "Tempo passado: " + stopwatch.Elapsed.TotalSeconds;
            }
            if (comboBox.SelectedIndex == 2)
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                Ordena.heapSort(list);
                stopwatch.Stop();
                textBox_comp.Text = "Tempo passado: " + stopwatch.Elapsed.TotalSeconds;
            }
            if (comboBox.SelectedIndex == 3)
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                Ordena.insercao(list);
                stopwatch.Stop();
                textBox_comp.Text = "Tempo passado: " + stopwatch.Elapsed.TotalSeconds;
            }
            if (comboBox.SelectedIndex == 4)
            {
                Ordena.pente(list);
                for (int i = 0; i < list.Count; i++)
                {
                    textBox_comp.Text = textBox_comp.Text + list[i].ToString() + "\n";
                }
            }
            if (comboBox.SelectedIndex == 5)
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                Ordena.quick(list,0,list.Count-1);
                stopwatch.Stop();
                textBox_comp.Text = "Tempo passado: " + stopwatch.Elapsed.TotalSeconds;
            }
            if (comboBox.SelectedIndex == 6)
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                Ordena.selecao(list);
                stopwatch.Stop();
                textBox_comp.Text = "Tempo passado: " + stopwatch.Elapsed.TotalSeconds;
            }
            if (comboBox.SelectedIndex == 7)
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                Ordena.shell(list);
                stopwatch.Stop();
                textBox_comp.Text = "Tempo passado: " + stopwatch.Elapsed.TotalSeconds;
            }

        }
    }
}
