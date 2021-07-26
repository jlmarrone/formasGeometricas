using CodingChallenge.Data.Classes.Formas;
using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes
{
    public class Traductor
    {
        static Traductor _instance;

        protected Traductor() { }

        public static Traductor GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Traductor();
                }

                return _instance;
            }
        }

        public string Traducir(IFormaGeometrica formaGeometrica, int cantidad)
        {
            if (formaGeometrica.GetType() == typeof(Rectangulo))
            {
                return cantidad == 1 ? Language.RectanguloSingular : Language.RectanguloPlural;
            }
            else if (formaGeometrica.GetType() == typeof(Circulo))
            {
                return cantidad == 1 ? Language.CirculoSingular : Language.CirculoPlural;
            }
            else if (formaGeometrica.GetType() == typeof(Triangulo))
            {
                return cantidad == 1 ? Language.TrianguloSingular : Language.TrianguloPlural;
            }
            else if (formaGeometrica.GetType() == typeof(Trapecio))
            {
                return cantidad == 1 ? Language.TrapecioSingular : Language.TrapecioPlural;
            }
            else
                return string.Empty;
        }
    }
}
