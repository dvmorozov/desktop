﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Security.AntiXss;

namespace SocialApps.Models
{
    public class CategoryModel
    {
        private string _name;
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Name")]
        //  https://www.evernote.com/shard/s132/nl/14501366/8cc9b08f-c8b8-4f59-851e-39c444d2846d
        public string Name {
            get { return _name; } 
            set { _name = value; }
        }

        [DataType(DataType.Text)]
        [Display(Name = "Budget")]
        public string Limit { get; set; }

        [Display(Name = "Id")]
        public int Id { get; set; }

        //  https://www.evernote.com/shard/s132/nl/14501366/5ea53405-2fc4-4166-a9e3-e918f3583785
        [Display(Name = "Encrypted Name")]
        public string EncryptedName { get; set; }
    }

    public class BudgetModel
    {
        [DataType(DataType.Text)]
        [Display(Name = "Budget")]
        public string Budget { get; set; }

        [DataType(DataType.Custom)]
        [Display(Name = "Year")]
        public int Year { get; set; }

        [DataType(DataType.Custom)]
        [Display(Name = "Month")]
        public int Month { get; set; }

        //  https://www.evernote.com/shard/s132/nl/14501366/5b6f473a-b5ec-4a62-adf2-17362aea5d81
        [Display(Name = "Currency")]
        public string Currency { get; set; }
    }

    public class IncomeModel
    {
        [DataType(DataType.Text)]
        [Display(Name = "Income")]
        public string Income { get; set; }

        [DataType(DataType.Custom)]
        [Display(Name = "Year")]
        public int Year { get; set; }

        [DataType(DataType.Custom)]
        [Display(Name = "Month")]
        public int Month { get; set; }

        [DataType(DataType.Custom)]
        [Display(Name = "Reset")]
        public int Reset { get; set; }
    }

    //  https://www.evernote.com/shard/s132/nl/14501366/83a03e66-6551-43c0-816e-2b32be9640df
    public class LinkModel
    {
        public string URL { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }

    //  https://www.evernote.com/shard/s132/nl/14501366/83a03e66-6551-43c0-816e-2b32be9640df
    public class TodayExpense
    {
        //  TodayExpensesByUser3_Result attributes.
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public double? Cost { get; set; }
        public string Note { get; set; }
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string ExpenseEncryptedName { get; set; }
        public string CategoryEncryptedName { get; set; }
        public string Currency { get; set; }
        public bool HasLinkedDocs { get; set; }
        public short? Rating { get; set; }
        public short? Importance { get; set; }
        //  https://www.evernote.com/shard/s132/nl/14501366/333c0ad2-6962-4de1-93c1-591aa92bbcb3
        public string Project { get; set; }
    }

    //  https://www.evernote.com/shard/s132/nl/14501366/6ad181b9-a410-4aab-b47a-7ea111aefb04
    public class MonthImportance
    {
        public short Importance { get; set; }
        public double Sum { get; set; }
    }

    public class ExpenseNameWithCategory
    {
        private string _EncryptedName;
        private string _Name;

        public string Name { 
            get { return _Name != null ? _Name.Trim() : null; }
            set { _Name = value; }
        }
        public Nullable<int> Id { get; set; }
        //  https://www.evernote.com/shard/s132/nl/14501366/dcdd71da-7c07-42d8-9055-5f69fa04bc4f
        public string EncryptedName { 
            get { return _EncryptedName != null ? _EncryptedName.Trim() : null; }
            set { _EncryptedName = value; } 
        }
        public Nullable<int> Count { get; set; }
    }


    public class NewExpense
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Cost")]
        public string Cost { get; set; }
        [DataType(DataType.Custom)]
        [Display(Name = "Day")]
        public int Day { get; set; }
        [DataType(DataType.Custom)]
        [Display(Name = "Month")]
        public int Month { get; set; }
        [DataType(DataType.Custom)]
        [Display(Name = "Year")]
        public int Year { get; set; }
        [DataType(DataType.Custom)]
        [Display(Name = "Hour")]
        public int Hour { get; set; }
        [DataType(DataType.Custom)]
        [Display(Name = "Min")]
        public int Min { get; set; }
        [DataType(DataType.Custom)]
        [Display(Name = "Sec")]
        public int Sec { get; set; }

        private string _name;
        [DataType(DataType.Text)]
        [Display(Name = "Name")]
        //  https://www.evernote.com/shard/s132/nl/14501366/8cc9b08f-c8b8-4f59-851e-39c444d2846d
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DataType(DataType.Custom)]
        [Display(Name = "Start Month")]
        public int StartMonth { get; set; }
        [DataType(DataType.Custom)]
        [Display(Name = "Start Year")]
        public int StartYear { get; set; }

        [DataType(DataType.Custom)]
        [Display(Name = "End Month")]
        public int EndMonth { get; set; }
        [DataType(DataType.Custom)]
        [Display(Name = "End Year")]
        public int EndYear { get; set; }

        [DataType(DataType.Custom)]
        [Display(Name = "Monthly")]
        public bool Monthly { get; set; }

        [DataType(DataType.Custom)]
        [Display(Name = "Forever")]
        //  The last month is undefined.
        public bool Forever { get; set; }

        [DataType(DataType.Custom)]
        [Display(Name = "ExpenseId")]
        public int ExpenseId { get; set; }

        //  https://www.evernote.com/shard/s132/nl/14501366/5ea53405-2fc4-4166-a9e3-e918f3583785
        [Display(Name = "Encrypted Name")]
        public string EncryptedName { get; set; }

        //  https://www.evernote.com/shard/s132/nl/14501366/67b5959f-63bc-4cd5-af1a-a481a2859c50
        public NewExpense()
        {
            StartMonth = -1;
            StartYear = -1;
            EndMonth = -1;
            EndYear = -1;
            Forever = false;
            Monthly = false;
            ExpenseId = -1;
        }

        //  https://www.evernote.com/shard/s132/nl/14501366/5b6f473a-b5ec-4a62-adf2-17362aea5d81
        [Display(Name = "Currency")]
        public string Currency { get; set; }

        //  https://www.evernote.com/shard/s132/nl/14501366/36d02a05-79e5-4d03-b055-06cec8fb49d9
        [Display(Name = "Note")]
        public string Note { get; set; }

        //  https://www.evernote.com/shard/s132/nl/14501366/49348fc0-3dc6-45cb-8425-6fe72042eac2
        [DataType(DataType.Custom)]
        [Display(Name = "Rating")]
        public short? Rating { get; set; }

        //  https://www.evernote.com/shard/s132/nl/14501366/7e2676fe-39fd-4290-bd26-17a2b4b7af7e
        [DataType(DataType.Custom)]
        [Display(Name = "Importance")]
        public short? Importance { get; set; }

        //  https://www.evernote.com/shard/s132/nl/14501366/333c0ad2-6962-4de1-93c1-591aa92bbcb3
        [Display(Name = "Project")]
        public string Project { get; set; }
    }
}
