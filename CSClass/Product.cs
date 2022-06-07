namespace CSClass
{
    internal class Product
    {
        public static int conuter=0;
        public string name = "노네임";
        public int price=1000;
        private int id=-1;

        public Product()
        {
        }

        public Product(string name, int price)
        {
            this.id = conuter;
            conuter = conuter++;
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return this.id + ":" +this.name +" : "+this.price;
        }

    }
}