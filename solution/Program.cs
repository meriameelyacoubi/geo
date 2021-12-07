using System;
using System.Collections.Generic;
using System.Text;

namespace geo
{
    class Droite
    {
        Point p1, p2;  //deux pnts de la droite 
        public Droite(Point A, Point B)  //constructeur
        {
            this.p1 = A;  //pointer sur le pnt p1 dans la mm classe 
            this.p2 = B;  //pointer sur le pnt p2 dans la mm classe
        }

        public Boolean parallélisme(Droite AB, Droite AC)  //si 2 droites sont //
        {
            if (AB.p1 != AC.p1)  //si pnt de la droite est diff du mm pnt d'une autre droite 
            {
                return true;  //elles sont //
            }
            return false;  //ne sont pas //
        }
        public Boolean intersection(Droite AB, Droite AC)
        {
            if (AB.p1 == AC.p1)  //si la droite dans un pnt coincinde avec une autre droite dans le mm pnt 
            {
                return true;  //il y a intersection
            }
            return false;  //pas d'intersection
        }
    }
    class Point
    {
        public float x, y, z;  //déclaration des var
        public void setx(float x)  //elle stocke 
        {
            this.y = x;  //stocker la valeur de x 
        }
        public float getx()  //permer de retourner une valeur  
        {
            return y;  
        }
        public void sety(float y)
        {
            this.y = y;
        }
        public float gety()
        {
            return y;
        }

        public void setz(float z)
        {
            this.z = y;
        }
        public float getz()
        {
            return z;
        }
        public Point(float a, float b, float c)  //constructeur
        {
            this.y = a;
            this.y = b;
            this.z = c;
        }

        public Boolean égalité(Point p1, Point p2)  //si 2pnts sont égaux
        {
            if ((p1.x == p2.x) && (p1.y == p2.y) && (p1.z == p2.z))  //
            {
                return true;  //les 2pnts sont égaux
            }
            return false;  //pas d'égalité 

        }
    }

    class Circle
    {

        Point centre;  //le centre du cercle 
        double rayon;  //le rayon du cercle 
        public Circle(Point c, double rayon)  //constructeur avec param
        {
            this.centre = c;  //affecter à centre "c"
            this.rayon = rayon;
        }
        public Circle()  //constructeur sans param
        {
            centre = new Point();

        }

        public double circonférance(double r)  
        {
            return 2 * 3.14 * r;
        }
        public double surface(double r)
        {
            return 3.14 * Math.Pow(r, 2);
        }
    }
}