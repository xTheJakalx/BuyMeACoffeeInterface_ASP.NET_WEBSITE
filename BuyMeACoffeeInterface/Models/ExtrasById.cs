namespace BuyMeACoffeeInterface
{
    public class ExtrasById
    {

        public int purchase_id { get; set; }
        public string purchased_on { get; set; }
        public string purchase_updated_on { get; set; }
        public bool purchase_is_revoked { get; set; }
        public double purchase_amount { get; set; }
        public string purchase_currency { get; set; }

        public string purchase_question { get; set; }
        public string payer_email { get; set; }
        public string payer_name { get; set; }
        public Extra data { get; set; }
    }
}