using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch.AccessModifier
{
    class PermantTeacher:Teacher
    {
        string subject;
        public PermantTeacher()
        {
            Console.WriteLine("in default constructor");
        }
        public PermantTeacher(string sub)
        {
            this.Subject = sub;
        }

        public string Subject { get => subject; set => subject = value; }
    }
}
