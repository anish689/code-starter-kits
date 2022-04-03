using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall.Interface
{
    public interface IFrame
    {
        int Score();
        int FirstRoll();
        int SecondRoll();
    }
}
