using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MironovComposition
{
    public enum ObjectsTypes
    {
        Unknown,
        Cube,
        Triangle,
        Springboard,
        Lamp
    }

    public class Object
    {
        string name;
        int x;
        int y;
        int size;
        double opacity;
        int rotate;
        int R;
        int B;
        int G;
        bool enable;

        public Object()
        {
            name = string.Empty;
            x = 0;
            y = 0;
            size = 100;
            rotate = 0;
            R = 255;
            G = 255;
            B = 255;
        }

        public Object(string name, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;

            size = 100;
            rotate = 0;
            R = 252;
            G = 252;
            B = 252;
            enable = false;
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

        public int Rotate
        {
            set
            {
                if (value < 0)
                    rotate = 0;
                if (value > 360)
                    rotate = 360;
                else
                    rotate = value;
            }
            get
            {
                return rotate;
            }
        }


        public double Opacity
        {
            set
            {
                if (value < 0)
                    opacity = 0;
                else
                    opacity = value;
            }
            get
            {
                return opacity;
            }
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
            return $"{(int)GetObjectType()};{Name};{X};{Y};{Size};{Rotate};{R};{G};{B}";
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
            int rotate;
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
            if (!int.TryParse(sub[5], out rotate))
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
                    CubeObject c = new CubeObject(name, x, y);
                    c.Size = size;
                    c.Rotate = rotate;
                    c.ColorR = R;
                    c.ColorG = G;
                    c.ColorB = B;
                    v = c;
                    break;
                case 2:
                    TriangleObject t = new TriangleObject(name, x, y);
                    t.Size = size;
                    t.Rotate = rotate;
                    t.ColorR = R;
                    t.ColorG = G;
                    t.ColorB = B;
                    v = t;
                    break;
                case 3:
                    SpringboardObject s = new SpringboardObject(name, x, y);
                    s.Size = size;
                    s.Rotate = rotate;
                    s.ColorR = R;
                    s.ColorG = G;
                    s.ColorB = B;
                    v = s;
                    break;
                case 4: 
                    LampObject l = new LampObject(name, x, y);
                    l.Size = size;
                    l.Rotate = rotate;
                    l.ColorR = R;
                    l.ColorG = G;
                    l.ColorB = B;
                    v = l;
                    break;
            }

            return v;
        }



    }

    public class CubeObject : Object
    {
        public CubeObject()
            : base()
        {
        }

        public CubeObject(string name, int x, int y)
            : base(name, x, y)
        {
            Enabled = false;
        }

        public override ObjectsTypes GetObjectType()
        {
            // воздушный транспорт
            return ObjectsTypes.Cube;
        }

    }


    public class TriangleObject : Object
    {
        public TriangleObject()
            : base()
        {

        }

        public TriangleObject(string name, int x, int y)
            : base(name, x, y)
        {
            Enabled = false;
        }

        public override ObjectsTypes GetObjectType()
        {
            // воздушный транспорт
            return ObjectsTypes.Triangle;
        }

    }


    public class SpringboardObject : Object
    {

        public SpringboardObject()
            : base()
        {

        }

        public SpringboardObject(string name, int x, int y)
            : base(name, x, y)
        {
            Size = 150;
            Enabled = false;
        }

        public override ObjectsTypes GetObjectType()
        {
            // воздушный транспорт
            return ObjectsTypes.Springboard;
        }

    }

    public class LampObject : Object
    {
        public LampObject()
            : base()
        {

        }

        public LampObject(string name, int x, int y)
            : base(name, x, y)
        {
            Rotate = 110;
            Enabled = false;
        }

        public override ObjectsTypes GetObjectType()
        {
            // воздушный транспорт
            return ObjectsTypes.Lamp;
        }

    }

}
