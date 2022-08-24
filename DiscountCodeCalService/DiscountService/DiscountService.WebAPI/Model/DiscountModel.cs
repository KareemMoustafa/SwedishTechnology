namespace DiscountService.WebAPI.Model
{
    public class DiscountModel
    {
        public int ProductId
        {
            get;
            set;
        }
        public string CustomerID
        {
            get;
            set;
        }
        public int ServiceID
        {
            get;
            set;
        }
        public int OrderID
        {
            get;
            set;
        }
        public string DiscountCode
        {
            get;
            set;
        }
    }

}

