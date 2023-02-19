using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _08._02._23__dz
{
    internal class Vector
    {
        public int coordinateX { get; set; }
        public int coordinateY { get; set; }
        public int coordinateZ { get; set; }
        public Vector()
        {

        }
        public Vector(int coordinateX) : this(coordinateX, 0, 0)
        {
        
        }
        public Vector(int coordinateX, int coordinateY, int coordinateZ)
        {
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
            this.coordinateZ = coordinateZ;
        }
        public void PrintVector()
        {
            Console.WriteLine($"X: {coordinateX}\nY: {coordinateY}\nZ: {coordinateZ}");
        }
        public void InputVector()
        {
            Console.WriteLine($"X: {coordinateX = Convert.ToInt32(Console.ReadLine())}");
            Console.WriteLine($"Y: {coordinateY = Convert.ToInt32(Console.ReadLine())}");
            Console.WriteLine($"Z: {coordinateZ = Convert.ToInt32(Console.ReadLine())}");
        }
        public double VectorLength()
        {
            return Math.Abs(Math.Sqrt(Math.Pow(coordinateX, 2)+Math.Pow(coordinateY,2)+Math.Pow(coordinateZ,2)));
        }
        public void Increase(int value)
        {
            coordinateX += value;
            coordinateY += value;
            coordinateZ += value;
        }
        public void Decrease(int value)
        {
            coordinateX -= value;
            coordinateY -= value;
            coordinateZ -= value;
        }
        static public Vector operator+(Vector a, Vector b)
        {
            Vector v = new Vector();
            v.coordinateX = a.coordinateX+b.coordinateX;
            v.coordinateY = a.coordinateY+b.coordinateY;
            v.coordinateZ = a.coordinateZ+b.coordinateZ;
            return v;
        }
        static public Vector operator -(Vector a, Vector b)
        {
            Vector v = new Vector();
            v.coordinateX = a.coordinateX - b.coordinateX;
            v.coordinateY = a.coordinateY - b.coordinateY;
            v.coordinateZ = a.coordinateZ - b.coordinateZ;
            return v;
        }
        static public Vector operator *(Vector a, Vector b)
        {
            Vector v = new Vector();
            v.coordinateX = a.coordinateX*b.coordinateX;
            v.coordinateY = a.coordinateY*b.coordinateY;
            v.coordinateZ = a.coordinateY * b.coordinateY;
            return v;
        }
        static public bool operator ==(Vector a, Vector b)
        {
            if (a.coordinateX != b.coordinateX || a.coordinateY != b.coordinateY || a.coordinateZ != b.coordinateZ) 
                    { return false; }
            return true;
        }
        static public bool operator !=(Vector a, Vector b)
        {
            if (a.coordinateX == b.coordinateX || a.coordinateY == b.coordinateY || a.coordinateZ == b.coordinateZ) 
            { return false; }
                return true;
        }
    }
}
