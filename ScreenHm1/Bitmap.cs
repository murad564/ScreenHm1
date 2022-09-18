internal class Bitmap
{
    private int v1;
    private int v2;

    public Bitmap(int v1, int v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }

    public object Size { get; internal set; }

    internal void Save(string fileName)
    {
        throw new NotImplementedException();
    }
}