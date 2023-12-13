using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Track.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        [Range(1,int.MaxValue,ErrorMessage ="Please Select a Category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Amount Should Be Greater Than 0")]
        public int Amount { get; set; }
        public string? Note { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
        [NotMapped]
        public string CategoryTitlewithicon 
        {
            get
            {
                return Category==null ? "" : Category.Icon+" "+Category.Title;
            }
        }
        [NotMapped]
        public string FormatAmount
        {
            get
            {
                return ((Category==null || Category.Type=="Expense") ? " - " : " + " )+ Amount.ToString("C0");
            }
        }
    }

}
