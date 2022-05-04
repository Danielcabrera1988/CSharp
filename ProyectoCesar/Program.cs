using System;

namespace ProyectoCesar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msj = "tengo muchas ganas de escribir una canción pero no se me ocurre nada";
            string msjCesar = "kd wiqd géuúi tédbbúnq kdq wiqd iúígédíqsybyuqu";

            descifrarCesar(msjCesar);

            string msjCifrado = cifrarCesar(msj);

            descifrarCesar(msjCifrado);
        }
        static void descifrarCesar(string msj)
        {
            string baseCesar = "aábcdeéfghiíjklmnñoópqrstuúüvwxyz";//33 caracteres + 12 el movimiento
            string msjCesar = "";
            int pos;
            int ind = 0;
            for (int i = 0; i < msj.Length; i++)
            {
                if (msj[i] == ' ')
                {
                    msjCesar += ' ';
                }

                for (int j = 0; j < baseCesar.Length; j++)
                {
                    if (msj[i] == baseCesar[j])
                    {
                        if (j + 12 < baseCesar.Length)
                        {
                            msjCesar += baseCesar[j + 12];                            
                        }
                        else
                        {
                            pos = (j + 12) - baseCesar.Length;
                            msjCesar += baseCesar[ind + pos];
                        }
                    }
                }
            }
            Console.WriteLine(msjCesar);
        }
        static string cifrarCesar(string msj)
        {
            string baseCesar = "aábcdeéfghiíjklmnñoópqrstuúüvwxyz";//33 caracteres + 12 el movimiento
            string msjCesar = "";
            int pos;
            int ind = 0;
            for (int i = 0; i < msj.Length; i++)
            {
                if (msj[i] == ' ')
                {
                    msjCesar += ' ';
                }

                for (int j = 0; j < baseCesar.Length; j++)
                {
                    if (msj[i] == baseCesar[j])
                    {
                        if (j - 12 < 0)
                        {                            
                            int aux = baseCesar.Length - (Math.Abs(j - 12));
                            msjCesar += baseCesar[aux];
                        }
                        else
                        {
                            msjCesar += baseCesar[j - 12];
                        }
                    }
                }
            }
            return msjCesar;
        }
    }
}
