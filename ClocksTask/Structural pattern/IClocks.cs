namespace Structural_pattern
{
    public interface IClocks
    {
        void GetTime();
        void SetTime(int hours, int minutes, int seconds);
    }
}