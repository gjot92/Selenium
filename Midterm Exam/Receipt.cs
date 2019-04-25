using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Exam
{
    public class Receipt
    {
        private int receiptNumber; 
        public string dateOfPurchase { get; set; }
        public string customerName { get; set; }
        public string address { get; set; }
        private int phoneNumber { get; set; }
        private int itemNo;
        public double price { get; set; }
        private int quantityBought;

        public Receipt (int ReceiptNo,string DatePurchased,string CustomerName,string Address, int PhoneNo,int ItemNo,double UnitPrice, int QuantitySold)
        {
            ReceiptNumber = ReceiptNo;
            dateOfPurchase = DatePurchased;
            customerName = customerName;
            address = Address;
            phoneNumber = PhoneNo;
            ItemNumber = ItemNo;
            price = UnitPrice;
            QuantityBought = QuantitySold;

        }

        public Receipt( int ItemNo, int QuantitySold)
        {
            ItemNumber = ItemNo;
        }
        
        public Receipt(int ReceiptNo)
        {
            ReceiptNumber = ReceiptNo;
        }

      
        public int ReceiptNumber
        {
            get
            {
                return receiptNumber;
            }
            set
            {
                if (value > 0)
                {
                   receiptNumber = value;
                }
                else
                {
                    throw new Exception("Input is invalid");
                }
            }
        }
        public int ItemNumber
        {
            get
            {
                return itemNo;
            }
            set
            {
                if (value > 0 && value < 9999)
                {
                    itemNo = value;
                }
                else
                {
                    throw new Exception("Input is invalid");
                }
            }
        }
      
        public int QuantityBought
        {
            get
            {
                return quantityBought;
            }
            set
            {
                if (value > 0)
                {
                    quantityBought = value;
                }
                else
                {
                    throw new Exception("Input is invalid");
                }
            }
        }

        public double TotalCost()
        {
            double totalCost = quantityBought * price;
            return totalCost;
        }
    }
}
