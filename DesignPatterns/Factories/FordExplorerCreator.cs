using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

namespace DesignPatterns.Factories
{
    public class FordExplorerCreator:Creator
    {
        public override Vehicle create()
        {
            var builder=new CarBuilder();
            return builder.SetModel("Explorer").SetColor("Black").Build();
        }
    }
}
