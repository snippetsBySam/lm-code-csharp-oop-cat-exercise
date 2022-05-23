using System;
namespace OopCatExercise
{
    public class DomesticCat : Cat
    {
        public DomesticCat () : base(averageHeight: 23, setting: "domestic")
        {

        }
        public override string Eat()
        {
            return (new Random().NextDouble() < 0.5) ? "Purrrrrrr" : "It will do I suppose";
        }

    }
}
