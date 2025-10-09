using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Lab3
{
    
    abstract class Bird : IBird
    {
        public abstract string Name { get; set; }
        protected abstract void Sleep();
        public abstract void Move();
        public abstract void Eat();

        public abstract void FlyUp(int h);

        public abstract void Die();
    }

    class Eagle : Bird
    {
        private int height = 0;
        public override string Name { get; set; }

        public static int amountOfEagles = 0;
        public Eagle(string Name)
        {
            this.Name = Name;
            amountOfEagles++;
        }  
        public override void Eat()
        {
            Console.WriteLine("Ням ням!!");
        }

        public override void Move()
        {
            Console.WriteLine("Фiу фiу! Я Орел!");
        }
        protected override void Sleep()
        {
            Console.WriteLine("/..."); 
        }

        public void Fly(int h)
        {
            height += h;
        }
        public void Land()
        {
            height = 0;
        }
        public int GetHeight()
        {
            return height;
        }

        public override void FlyUp(int h)
        {
            Console.WriteLine($"I fly at {h} meters"); 
        }

        public override void Die()
        {
            Console.WriteLine("x_x");
        }
    }

    class Duck : Bird
    {
        private int depth = 0;
        public override string Name { get; set; }
        public Duck(string Name)
        {
            this.Name = Name;
        }

        public override void Eat()
        {
            Console.WriteLine("Кря! Смачно кря!"); 
        }

        public override void Move()
        {
            Console.WriteLine("Фир фир!!");
        }

        protected override void Sleep()
        {
            Console.WriteLine("Храп..храп.."); 
        }

        public void Dive(int m)
        {
            depth += m;
        }
        public void FlowOut()
        {
            depth = 0;
        }
        public int GetDepth()
        {
            return depth;
        }
        public override bool Equals(object? obj)
        {
            if(obj is Bird bird)
            {
                return this.Name == bird.Name;
            }
            return false;
        }

        public override void FlyUp(int h)
        {
            Console.WriteLine($"I fly at {h} meters that is very good for a duck!"); 
        }

        public override void Die()
        {
            Console.WriteLine("x-x"); 
        }
    }
}
