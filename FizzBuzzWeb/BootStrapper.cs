using StructureMap;
using StructureMap.Configuration.DSL;
//using FizzBuzzStructureMap.Models;
using FizzBuzzBusinessInterfaces;
using FizzBuzzBusiness;

namespace FizzBuzzStructureMap
{
    public class BootStrapper
    {
        public static void ConfigureDependencies()
        {
            ObjectFactory.Initialize(x => x.AddRegistry<ControllerRegistry>());
        }
    }
    public class ControllerRegistry : Registry
    {
        public ControllerRegistry()
        {
            For<IFizzBuzzManager>().Use<FizzBuzzManager>();
        }
    }
}