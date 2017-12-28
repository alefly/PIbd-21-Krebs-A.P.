using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        private Potato[] potatos;

        private Salt salt;

        private Oil oil;

        private WaterTap waterTap;

        private Knife knife;

        private Fryer fryer;

        private int ingr = 0;

        private bool ready;

        public Form1()
        {
            InitializeComponent();
            waterTap = new WaterTap();
            knife = new Knife();
            fryer = new Fryer();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                if (!waterTap.State)
                {
                    MessageBox.Show("Кран закрыт, как мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                potatos = new Potato[Convert.ToInt32(numericUpDown1.Value)];
                fryer.Init(Convert.ToInt32(numericUpDown1.Value));
                for (int i = 0; i < potatos.Length; ++i)
                {
                    potatos[i] = new Potato();
                }
                for (int i = 0; i < potatos.Length; ++i)
                {
                    potatos[i].Dirty = 0;
                }
                numericUpDown1.Enabled = false;
                radioButton2.Checked = true;
                MessageBox.Show("Картошку помыли, можно чистить", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Картошки то нет, что мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            oil = new Oil();
            fryer.AddOil(oil);
            ingr += 5;
                MessageBox.Show("Масло добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                if (!waterTap.State)
                {
                    MessageBox.Show("Кран закрыт, как мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                potatos = new Potato[Convert.ToInt32(numericUpDown1.Value)];
                fryer.Init(Convert.ToInt32(numericUpDown1.Value));
                for (int i = 0; i < potatos.Length; ++i)
                {
                    potatos[i] = new Potato();
                }
                for (int i = 0; i < potatos.Length; ++i)
                {
                    potatos[i].Dirty = 0;
                }
                numericUpDown1.Enabled = false;
                radioButton2.Checked = true;
                MessageBox.Show("Картошку помыли, можно чистить", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Картошки то нет, что мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                waterTap.State = true;
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                waterTap.State = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (potatos == null)
            {
                MessageBox.Show("Картошки то нет, что чистить?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (potatos.Length == 0)
            {
                MessageBox.Show("Картошки то нет, что чистить?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < potatos.Length; ++i)
            {
                if (potatos[i].Dirty > 0)
                {
                    MessageBox.Show("Картошка грязная!!! Помыть бы ее сначала, а уж потом чистить", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < potatos.Length; ++i)
            {
                knife.Clean(potatos[i]);
            }
      
            MessageBox.Show("Картошку помыли, можно резать", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (potatos == null)
            {
                MessageBox.Show("Картошки то нет, что резать?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (potatos.Length == 0)
            {
                MessageBox.Show("Картошки то нет, что резать?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < potatos.Length; ++i)
            {
                if (potatos[i].Dirty > 0)
                {
                    MessageBox.Show("Картошка грязная!!! Помыть бы ее сначала, а уж потом резать", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < potatos.Length; ++i)
            {
                knife.Cut(potatos[i]);
            }
            MessageBox.Show("Картошку порезали, можно добавлять в фритюрницу", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            salt = new Salt();
            salt.Count = Convert.ToInt32(numericUpDown2.Value);
            if (salt.Count > 0)
            {
                fryer.AddSalt(salt);
                ingr += 10;
                MessageBox.Show("Соль добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Соли же нет, что добавлять?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (potatos == null)
            {
                MessageBox.Show("Картошки то нет, что жарить собрались?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (potatos.Length == 0)
            {
                MessageBox.Show("Картошки то нет, что жарить собрались?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < potatos.Length; ++i)
            {
                if (potatos[i].Dirty > 0)
                {
                    MessageBox.Show("Картошка грязная!!! Как ее жарить, а ну мыть ее быстро!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (potatos[i].Have_skin)
                {
                    MessageBox.Show("У нас обычная картошка, не в мундире. Надо почистить!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (potatos[i].Have_wholeness)
                {
                    MessageBox.Show("У нас обычная картошка, не порезанная. Надо порезать!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < potatos.Length; ++i)
            {
                fryer.AddPotato(potatos[i]);
            }
            
            ingr += 1;
            MessageBox.Show("Картошку положили, можно готовить", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                MessageBox.Show("Фритюрница не включена.", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
         
            fryer.Cook();
            if (ingr == 16)
            {
                ready = true;
                MessageBox.Show("Приготовилось!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Что-то пошло не так, картошка не сварилась", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ready)
            {
                MessageBox.Show("Приятного аппетита", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Картошка не приготовилась!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }
    }
}
