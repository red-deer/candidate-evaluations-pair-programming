using System;  
using System.Text;  

// Simple Business Logic Project
// In the following, we are implementing Discounts on specific sales made by customers 
// such as 5% discount on purchases of $1000 to $1999, 10% on $2000 to $4999, and so on. 
// Such a discount will be deducted automatically in the final payment based on some 
// implicit calculation stated in the business logic.

namespace UnitTest {  
    public classUtilityLib {  
        public double calculateDiscount(double SalesAmnt) {  
            double DiscountPrice = 0.0;  
            if (SalesAmnt == 0 || SalesAmnt < 0) {  
                thrownew ArgumentException(" Sales Amount should not be 'Zero/Negative'");  
            } else if (SalesAmnt >= 1000 && SalesAmnt < 2000) {  
                // 5% Discount  
                DiscountPrice = SalesAmnt - (SalesAmnt * 0.05);  
            } else if (SalesAmnt >= 2000 && SalesAmnt < 5000) {  
                // 10% Discount  
                DiscountPrice = SalesAmnt - (SalesAmnt * 0.1);  
            } else if (SalesAmnt >= 5000 && SalesAmnt < 20000) {  
                // 50% Discount  
                DiscountPrice = SalesAmnt - (SalesAmnt * 0.5);  
            } else {  
                // No Discount  
                DiscountPrice = SalesAmnt - 0.0;  
            }  
            return DiscountPrice;  
        }  
    }  
}  

