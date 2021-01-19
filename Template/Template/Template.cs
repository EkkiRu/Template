using System;
using System.Collections.Generic;
using System.Text;

namespace Template
{
    public abstract class MachineAssembly
    {

        public void Make()
        {
            GetName();
            AddMotor();
            AddBox();
            AddWheels();
            AddBody();
        }
        public abstract string Name { get; }
        public abstract void GetName();
        public abstract void AddMotor();
        public abstract void AddBox();
        public abstract void AddWheels();
        public abstract void AddBody();

        public virtual void GetReadyAssembley()
        {
            Console.WriteLine("Получили сборку");
        }
    }


    public class Toyota : MachineAssembly
    {
        public override string Name { get { return "Toyota"; } }


        public override void AddBox()
        {
            Console.WriteLine("Добавляем Box");
        }

        public override void AddWheels()
        {
            Console.WriteLine("Добавляем Wheels");
        }

        public override void AddBody()
        {
            Console.WriteLine("Добавляем Body");
        }

        public override void AddMotor()
        {
            Console.WriteLine("Добавляем кипяченую воду");
        }

        public override void GetName()
        {
            Console.WriteLine($"Делаем {Name}");
        }
    }

    
}
