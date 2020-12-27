using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PortalPROJECT
{
    public class Portal
    {
        public int X; // Координата портала
        public int Y; // Координата портала
        public int Radius = 100; // Радиус портала
        public int OutX; // Координата X выхода из портала
        public int OutY; // Координата Y выхода из портала
        public float OutDirection = 0; // Направление при выходе из портала
        public float OutSpeed = 5; // Скорость при выходе из портала

        public void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY); // считаем расстояние от центра точки до центра частицы
            if (r + particle.Radius < Radius / 2) // если частица оказалась внутри окружности, то обновляю её поля
            {
                particle.X = OutX + -gX;
                particle.Y = OutY + -gY;

                particle.SpeedX = (float)(Math.Cos(OutDirection / 180 * Math.PI) * OutSpeed);
                particle.SpeedY = -(float)(Math.Sin(OutDirection / 180 * Math.PI) * OutSpeed);
            }
        }

        public void Render(Graphics g)
        {
            // Это линия между порталом и точкой выхода
            g.DrawLine(new Pen(Color.White), X, Y, OutX, OutY);
            // Это точка выхода портала
            g.DrawEllipse(
                new Pen(Color.AntiqueWhite),
                OutX - Radius / 2,
                OutY - Radius / 2,
                Radius,
                Radius
            );
            // Сам портал
            g.DrawEllipse(
                   new Pen(Color.Red),
                   X - Radius / 2,
                   Y - Radius / 2,
                   Radius,
                   Radius
               );
        }
    }
}
