namespace BackEnd
{
    public class Client : ORM
    {
        public int _id_client { get; set; }
        public string _client_code { get; set; }
        public string _client_name { get; set; }
        public string _client_address { get; set; }
        public string _project_code { get; set; }
        public string _project_name { get; set; }
        public decimal _contract_cost { get; set; }
        public string _contract_date { get; set; }
        public string _contract_deadline { get; set; }
        public string _notes { get; set; }

        public Client()
        {
            table_ = "client";
            pk_ = "id_client";
        }

    }
}
