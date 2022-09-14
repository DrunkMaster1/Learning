using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
     class Character
    {
        public int Health { get; private set; } = 100;
        
        public void Hit (int damage)
        {
            if (damage > Health)
                damage = Health;
        
            //если изменишь Health получишь по ебалу
            
            Health -= damage;
        }

    }
}
