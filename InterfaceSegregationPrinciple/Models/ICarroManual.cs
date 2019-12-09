using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Models
{
    public interface ICarroManual: ICarro
    {
        void TrocaMarcha();
    }
}
