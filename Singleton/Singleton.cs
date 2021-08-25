using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton instance = null;
        public string mensaje = "";

        private Singleton()
        {
            mensaje = "hola mundo";
        }

        public static Singleton Instace
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }

                return instance;
            }
        }
    }
}
