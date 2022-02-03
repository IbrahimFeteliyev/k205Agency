namespace K205Agency.Models
{
    public class Portfolio : Base
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public String Client { get; set; }
        public String PhotoURL { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }            
}
