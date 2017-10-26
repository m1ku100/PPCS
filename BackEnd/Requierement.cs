
namespace BackEnd
{
    public class Requierement : ORM
    {
        public int _id_requierement { get; set; }
        public int _id_client_fk { get; set; }
        public string _cost_code { get; set; }
        public string _cost_name { get; set; }
        public decimal _price_per_quantity { get; set; }
        public decimal _quantity { get; set; }
        public string _unit { get; set; }
        public decimal _total_price { get; set; }
        public string _type_cost { get; set; }
        public string _id_user_fk { get; set; }// Direct or Indirect

        public Requierement()
        {
            table_ = "requierement";
            pk_ = "id_requierement";
        }
    }
}
