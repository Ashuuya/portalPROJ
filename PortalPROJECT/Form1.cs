using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortalPROJECT
{
    public partial class Form1 : Form
    {
        Emitter emitter; // поле для эмиттера
        Emitter emitter1; // поле для эмиттера
        Portal teleport; // поле для портала

        public Form1()
        {
            InitializeComponent();
            picDisplay.MouseWheel += picDisplay_MouseWheel;
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);


            // Инициализируем эмиттер и портал
            emitter = new Emitter
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.White,
                ColorTo = Color.FromArgb(0, Color.Black),
                ParticlesPerTick = 10,
                ParticlesCount = 1000,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2 - 100,
            };

            teleport = new Portal
            {
                X = picDisplay.Width / 2 + 100,
                Y = picDisplay.Height / 2,
                OutX = 50,
                OutY = 50,
            };

            // привязываем портал к эмиттеру
            emitter.teleport = teleport;
        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            // Событие для управления направлением движения частиц при выходе из портала
            teleport.OutDirection = tbDirection.Value;
            lblDirection.Text = $"{tbDirection.Value}°";
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ЗАДАЧА: Реализовать телепорт, попадая в радиус действия которой частицы телепортируются в другую указанную точку: \n1) По клику левой кнопки мыши перемещать ВХОД телепорта в точку клика. \n2) По клику правой кнопки мыши перемещать ВЫХОД телепорта в точку клика. \n3) Добавить TrackBar для управления радиусом телепорта (необязательно) \n4) Добавить TrackBar для управления направлением движения частиц на выходе (необязательно)");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lbPerTick_Click(object sender, EventArgs e)
        {

        }

        private void tbPerTick_Scroll(object sender, EventArgs e)
        {
            // Событие для управления разбросом частиц
            emitter.ParticlesPerTick = tbPerTick.Value;
            lbPerTick.Text = $"{tbPerTick.Value}";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbSpreading_Click(object sender, EventArgs e)
        {

        }

        private void tbSpreading_Scroll(object sender, EventArgs e)
        {
            // Событие для управления разбросом частиц
            emitter.Spreading = tbSpreading.Value;
            lbSpreading.Text = $"{tbSpreading.Value}";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbSpeed_Click(object sender, EventArgs e)
        {

        }

        private void tbSpeed_Scroll(object sender, EventArgs e)
        {
            // Событие для управления скорости движения частиц при выходе из портала
            teleport.OutSpeed = tbSpeed.Value;
            lbSpeed.Text = $"{tbSpeed.Value}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDirection_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                // а тут теперь вручную создаем
                emitter1 = new TopEmitter
                {
                    Width = picDisplay.Width,
                    GravitationY = 0.25f
                };

                // привязываем портал к эмиттеру
                emitter1.teleport = teleport;
            }
            else
            {
                emitter1 = null;
            }
        }

        private void picDisplay_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Каждый тик обновляем состояние и рендерим по новой
            var g = Graphics.FromImage(picDisplay.Image);
            g.Clear(Color.Black);

            emitter.UpdateState();
            emitter.Render(g);

            if (checkBox3.Checked)
            {
                emitter1.UpdateState();
                emitter1.Render(g);
            }

            picDisplay.Invalidate();
        }

        private void picDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            // Событие для перемещение портала по клику мышкой
            string button = e.Button.ToString();
            if (button == "Left")
            {
                teleport.X = e.X;
                teleport.Y = e.Y;
            }
            else if (button == "Right")
            {
                teleport.OutX = e.X;
                teleport.OutY = e.Y;
            }
        }

        private void picDisplay_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0 && teleport.Radius > 5)
            {
                teleport.Radius -= 5;
            }
            else if (e.Delta > 0 && teleport.Radius < 300)
            {
                teleport.Radius += 5;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ЗАДАЧА: Реализовать телепорт, попадая в радиус действия которой частицы телепортируются в другую указанную точку: \n1) По клику левой кнопки мыши перемещать ВХОД телепорта в точку клика. \n2) По клику правой кнопки мыши перемещать ВЫХОД телепорта в точку клика. \n3) Добавить TrackBar для управления радиусом телепорта (необязательно) \n4) Добавить TrackBar для управления направлением движения частиц на выходе (необязательно)");
        }
    }
}
