namespace ShN.DataModels
{
    public abstract class Element : Model
    {
        public int Id { get; set; }

        public virtual ElementType Type { get; set; }

        public abstract int[] GetNodes();
    }
}
