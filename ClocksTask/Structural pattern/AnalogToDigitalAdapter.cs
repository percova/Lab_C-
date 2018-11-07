namespace Structural_pattern
{
    public class AnalogToDigitalAdapter: IClocks
    {
        private AnalogClocks analogClocks = new AnalogClocks();

        public AnalogToDigitalAdapter(AnalogClocks ac)
        {
            analogClocks = ac;
        }

        public void SetTime(int h, int m, int s)
        {
            analogClocks.SetAnalogTime(h, m, s);
        }
        
        public void GetTime()
        {
            analogClocks.GetAnalogTime();
        }
    }
}