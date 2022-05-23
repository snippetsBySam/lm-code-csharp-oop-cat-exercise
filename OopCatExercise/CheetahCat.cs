namespace OopCatExercise
{
    public class CheetahCat : Cat
    {
        public CheetahCat() : base(averageHeight: 81, setting: "wild")
        {

        }
        public override string Eat()
        {
            return "Zzzzzzz";
        }
    }
}
