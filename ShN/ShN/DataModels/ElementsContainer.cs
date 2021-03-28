using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShN.DataModels
{
    public class ElementsContainer
    {
        public List<SimpleElement> Resistors { get; set; }
        public List<SimpleElement> Inductors { get; set; }
        public List<SimpleElement> Capacitors { get; set; }
        public List<EuW> EuW { get; set; }
        public List<Ei> Ei { get; set; }
        public List<Oui> Oui { get; set; }
        public List<Tu> Tu { get; set; }
    }
}
