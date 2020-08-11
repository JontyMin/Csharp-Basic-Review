namespace Pet
{
    public class Labrador : Dog
    {
        public Labrador(string name) : base(name)
        {
        }

        // Dog的Speak方法是密闭的 不能重写
        /* public override void Speak()
        {

        }*/
    }
}