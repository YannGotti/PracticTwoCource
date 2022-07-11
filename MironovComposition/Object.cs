using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MironovComposition
{
    public enum ObjectsTypes
    {
        Unknown,
        Square,
        Triangle,
        Springboard,
        Lamp,
    }

    public class Object
    {
        protected string name;
        protected int x;
        protected int y;
        protected int size;
        protected int R;
        protected int B;
        protected int G;
        protected bool enable;

        protected List<PointF> source;
        protected List<PointF> transformed;

        protected double angle;

        protected double scaleX;
        protected double scaleY;

        protected double xc;
        protected double yc;

        protected Rectangle bound;

        protected MatrixObject scaleMatrix;
        protected MatrixObject rotationMatrix;
        protected MatrixObject translationMatrix;

        protected MatrixObject resultMatrix;

        public Object()
        {}

        public Object(string name, int x, int y)
        {
            source = new List<PointF>();
            transformed = new List<PointF>();

            xc = 0;
            yc = 0;

            angle = 0;

            scaleX = 100;
            scaleY = 100;

            scaleMatrix = new MatrixObject();
            rotationMatrix = new MatrixObject();
            translationMatrix = new MatrixObject();

            resultMatrix = new MatrixObject();

            this.name = name;
            this.x = x;
            this.y = y;

            size = 100;
            R = 123;
            G = 123;
            B = 123;
            enable = false;
        }

        protected void CreateTransformedPoints()
        {
            // создание списка преобразованных точек
            transformed.Clear();
            for (int i = 0; i < source.Count; i++)
                transformed.Add(new PointF());
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public int X
        {
            set
            {
                if (value < 0)
                    x = 0;
                else
                    x = value;
            }
            get { return x; }
        }

        public int Y
        {
            set
            {
                if (value < 0)
                    y = 0;
                else
                    y = value;
            }
            get { return y; }
        }


        public int Size
        {
            set
            {
                if (value < 0)
                    size = 0;
                if (value > 200)
                    size = 200;
                else
                    size = value;
            }
            get
            {
                return size;
            }
        }

        public double ScaleX
        {
            set { scaleX = value; }
            get { return scaleX; }
        }

        public double ScaleY
        {
            set { scaleY = value; }
            get { return scaleY; }
        }

        public double Angle
        {
            set { angle = value; }
            get { return angle; }
        }

        public Rectangle Bound
        {
            set { bound = value; }
            get { return bound; }
        }


        public int ColorR
        {
            set
            {
                if (value < 0)
                    R = 0;
                if (value > 255)
                    R = 255;
                else
                    R = value;
            }
            get
            {
                return R;
            }
        }

        public int ColorG
        {
            set
            {
                if (value < 0)
                    G = 0;
                if (value > 255)
                    G = 255;
                else
                    G = value;
            }
            get
            {
                return G;
            }
        }

        public int ColorB
        {
            set
            {
                if (value < 0)
                    B = 0;
                if (value > 255)
                    B = 255;
                else
                    B = value;
            }
            get
            {
                return B;
            }
        }

        public bool Enabled
        {
            set
            {
                enable = value;
            }
            get
            {
                return enable;
            }
        }


        public void Draw(Graphics g, MatrixObject viewportMatrix)
        {
            Transform(viewportMatrix);
            DrawObject(g);
        }

        protected virtual void Transform(MatrixObject viewportMatrix)
        {
            if (transformed.Count != source.Count)
                CreateTransformedPoints();

            resultMatrix.Identity();

            translationMatrix.Translate(-xc, -yc);
            resultMatrix.AppendLeft(translationMatrix);

            scaleMatrix.Scale(scaleX, scaleY);
            resultMatrix.AppendLeft(scaleMatrix);

            rotationMatrix.Rotation(angle * Math.PI / 180);
            resultMatrix.AppendLeft(rotationMatrix);

            translationMatrix.Translate(x, y);
            resultMatrix.AppendLeft(translationMatrix);

            resultMatrix.AppendLeft(viewportMatrix);

            for (int i = 0; i < source.Count; i++)
                transformed[i] = resultMatrix.Transform(source[i]);
        }

        protected virtual void DrawObject(Graphics g)
        {
        }


        public virtual ObjectsTypes GetObjectType()
        {
            return ObjectsTypes.Unknown;
        }

        public override string ToString()
        {
            return name;
        }

        public virtual string GetDataString()
        {
            return $"{(int)GetObjectType()};{Name};{X};{Y};{Size};{Angle};{R};{G};{B}";
        }

        public static bool SaveData(string fileName, List<Object> objects)
        {
            bool success = false;
            if (string.IsNullOrEmpty(fileName) ||
                string.IsNullOrWhiteSpace(fileName) ||
                objects == null || objects.Count == 0)
                return success;

            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(fileName, false, Encoding.Default);

                for (int i = 0; i < objects.Count; i++)
                {
                    if (objects[i] != null)
                        writer.WriteLine(objects[i].GetDataString());
                }

                writer.Close();
                success = true;
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    ex.Message, "Ошибка при сохранении");
            }
            finally
            {
                if (writer != null)
                    writer.Dispose();
            }

            return success;
        }


        public static bool ReadData(string fileName, List<Object> objects)
        {
            bool success = false;
            StreamReader reader = null;

            if (string.IsNullOrEmpty(fileName) ||
                string.IsNullOrWhiteSpace(fileName))
                return success;

            // Очистить список
            objects.Clear();

            try
            {
                reader = new StreamReader(fileName, Encoding.Default);
                string str;

                Object v = null;

                while (!reader.EndOfStream)
                {
                    // Прочитать строку
                    str = reader.ReadLine();
                    // Получить экземпляр из строки
                    v = FromString(str);
                    if (v != null)
                        objects.Add(v);
                }

                reader.Close();
                success = true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    ex.Message, "Ошибка при чтении");
            }
            finally
            {
                if (reader != null)
                    reader.Dispose();
            }
            return success;
        }

        public static Object FromString(string str)
        {
            Object v = null;
            if (string.IsNullOrEmpty(str) ||
                string.IsNullOrWhiteSpace(str))
                return v;

            char[] del = { ';' };
            string[] sub = str.Split(del);

            if (sub.Length < 7)
                return v;

            int type;
            string name = sub[1];
            int x;
            int y;
            int size;
            int angle;
            int R;
            int B;
            int G;

            if (!int.TryParse(sub[0], out type))
                return v;
            if (!int.TryParse(sub[2], out x))
                return v;
            if (!int.TryParse(sub[3], out y))
                return v;
            if (!int.TryParse(sub[4], out size))
                return v;
            if (!int.TryParse(sub[5], out angle))
                return v;
            if (!int.TryParse(sub[6], out R))
                return v;
            if (!int.TryParse(sub[7], out G))
                return v;
            if (!int.TryParse(sub[8], out B))
                return v;
           
            switch (type)
            {
                case 1:
                    Square c = new Square(name, x, y);
                    c.Size = size;
                    c.ScaleX = size;
                    c.ScaleY = size;
                    c.Angle = angle;
                    c.ColorR = R;
                    c.ColorG = G;
                    c.ColorB = B;
                    v = c;
                    break;
                case 2:
                    Triangle t = new Triangle(name, x, y);
                    t.Size = size;
                    t.ScaleX = size;
                    t.ScaleY = size;
                    t.Angle = angle;
                    t.ColorR = R;
                    t.ColorG = G;
                    t.ColorB = B;
                    v = t;
                    break;
                case 3:
                    Springboard s = new Springboard(name, x, y);
                    s.Size = size;
                    s.ScaleX = size;
                    s.ScaleY = size;
                    s.Angle = angle;
                    s.ColorR = R;
                    s.ColorG = G;
                    s.ColorB = B;
                    v = s;
                    break;
                case 4: 
                    Lamp l = new Lamp(name, x, y);
                    l.Size = size;
                    l.Angle = angle;
                    l.ColorR = R;
                    l.ColorG = G;
                    l.ColorB = B;
                    v = l;
                    break;
            }

            return v;
        }

    }
}
