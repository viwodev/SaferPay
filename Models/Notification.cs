using System.Collections.Generic;

namespace SaferPay.Models
{
	public class Notification
	{
		public string MerchantEmail { get; set; }
		public string NotifyUrl { get; set; }

        public List<string> NotifyOn { get; set; }
    }
}