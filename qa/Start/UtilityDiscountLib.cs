using System;  
using System.Text;  

// Simple Business Logic Project
// ======================================
// TYPE HERE THE SPECS FOR THIS FUNCTION
// ======================================


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

