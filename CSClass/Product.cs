namespace CSClass
{
    internal class Product
    {
        public string name = "노네임";
        public int price=1000;

        public override string ToString()
        {
            return this.name + ":" +this.price;
        }

    }
}