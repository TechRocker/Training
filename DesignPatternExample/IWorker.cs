using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample
{
    public interface IWorker
    {
        string Name { get; set; }
        string Address { get; set; }
        string Number { get; set; }
        eWorkerType Type { get; set; }

        void Create(IWorker worker);
        void Update(IWorker worker);
        void Delete(IWorker worker);
    }

    public enum eWorkerType
    {
        Knitter=01,
        Dyer =02,
        Cutter=03,
        Sticher=04
    }
}
