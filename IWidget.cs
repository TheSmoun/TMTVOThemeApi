using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMTVO.ThemeApi
{
    public interface IWidget
    {
        bool Active { get; }
        void FadeOut();
        void Tick();
    }
}
