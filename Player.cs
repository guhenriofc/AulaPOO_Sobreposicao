using System;

namespace AulaPOO_Sobreposicao
{
    public abstract class Player
    {
        public virtual void Correr()
        {
            Console.WriteLine("Correndo em velocidade 10");
        }
    }
}