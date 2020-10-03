namespace LanguageBasics
{
    public class UnitConvert
    {
        int ratio;
        public UnitConvert(int unitRatio) { ratio = unitRatio; }
        public int Convert(int unit) { return unit * ratio; }
    }
}