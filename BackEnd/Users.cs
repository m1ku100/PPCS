namespace BackEnd
{
    public class Users : ORM
    {
        public int _id_user { get; set; }
        public string _username { get; set; }
        public decimal _password { get; set; }
        public string _type { get; set; }

        public Users()
        {
            table_ = "users";
            pk_ = "id_user";
        }

    }
}
