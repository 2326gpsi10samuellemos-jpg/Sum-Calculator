using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace somasuperiora100
{
    public partial class Form1 : Form
    {
        int nr,count=0,media,total=0;
        public Form1()
        {
            InitializeComponent();
        }

        public class Exception1 : Exception
        {
            public string erro;
            public Exception1(String str)
            {
                erro = "Erro 404 \n" + str;
                MessageBox.Show($"{erro}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try{
                nr = Int32.Parse(tb_nrin.Text);
                count++;
                total += nr;
                media = total / count;
                if(count==1)
                lb_visuall.Text = "";
                Addconteudos();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Insira números mais pequenos.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Insira apenas números.");
            }
            catch (Exception1)
            {

            }
            catch
            {
                MessageBox.Show("Erro geral.");
            }
        }
        private void Addconteudos()
        {
            if(total<100)
                lb_visuall.Text += $"Nr inserido- {nr} || Soma: {total} || Ordem: {count} || Média: {media}" + Environment.NewLine;
            else
            {
                total = total - nr;
                throw new Exception1("Limite Alcançado");
            }
        }
        private void load(object sender,EventArgs e)
        {
            lb_visuall.Text = "Aguardando entrada de números...";
        }
    }
}
