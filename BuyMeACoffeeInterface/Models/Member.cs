namespace BuyMeACoffeeInterface
{
    public class Member
    {
        public int subscription_id { get; set; }
        public object subscription_cancelled_on { get; set; }
        public string subscription_created_on { get; set; }
        public string subscription_updated_on { get; set; }
        public string subscription_current_period_start { get; set; }
        public string subscription_current_period_end { get; set; }
        public string subscription_coffee_price { get; set; }
        public int subscription_coffee_num { get; set; }
        public object subscription_is_cancelled { get; set; }
        public object subscription_is_cancelled_at_period_end { get; set; }
        public string subscription_currency { get; set; }
        public object subscription_message { get; set; }
        public int message_visibility { get; set; }
        public string subscription_duration_type { get; set; }
        public object referer { get; set; }
        public object country { get; set; }
        public string transaction_id { get; set; }
        public string payer_email { get; set; }
        public string payer_name { get; set; }
    }
}