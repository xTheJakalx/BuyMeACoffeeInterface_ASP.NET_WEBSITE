namespace BuyMeACoffeeInterface
{
    public class Supporter
    {
        public int support_id { get; set; }
        public object support_note { get; set; }
        public int support_coffees { get; set; }
        public string transaction_id { get; set; }
        public int support_visibility { get; set; }
        public string support_created_on { get; set; }
        public string support_updated_on { get; set; }
        public object transfer_id { get; set; }
        public object supporter_name { get; set; }
        public string support_coffee_price { get; set; }
        public string support_email { get; set; }
        public object is_refunded { get; set; }
        public string support_currency { get; set; }
        public int support_note_pinned { get; set; }
        public object referer { get; set; }
        public string country { get; set; }
        public string payer_email { get; set; }
        public string payment_platform { get; set; }
        public string payer_name { get; set; }
    }
}