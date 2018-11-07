using System.Runtime.InteropServices;

namespace Structural_pattern
{
    public class ClockUser 
    {
        public void WatchTime(IClocks clocks)
        {
            clocks.GetTime();
        }

        public void ChangeTime(IClocks clocks)
        {
            clocks.SetTime(10, 40, 36);
        }
    }
}