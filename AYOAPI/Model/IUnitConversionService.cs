namespace AYOAPI.Model
{
    public interface IUnitConversionService : IDisposable
    {
        public Task<UnitConversionRate> GetConversionRateByNameAsync(List<string> units);

    }
}
