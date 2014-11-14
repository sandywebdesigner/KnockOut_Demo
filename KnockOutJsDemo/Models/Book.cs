//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KnockOutJsDemo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        public int Id { get; set; }
        public string Pickup_Location { get; set; }
        public string Pickup_Address { get; set; }
        public string Pickup_Suburb { get; set; }
        public string Flight_Number { get; set; }
        public Nullable<System.DateTime> Flight_Date { get; set; }
        public Nullable<System.TimeSpan> Flight_Time { get; set; }
        public string Dropoff_Location { get; set; }
        public string Dropoff_Address { get; set; }
        public string Dropoff_Suburb { get; set; }
        public string Return_Flight_Number { get; set; }
        public Nullable<System.DateTime> Return_Flight_Date { get; set; }
        public Nullable<System.TimeSpan> Return_Flight_Time { get; set; }
        public Nullable<bool> One_way { get; set; }
        public Nullable<bool> Round_trip { get; set; }
        public string Ref { get; set; }
        public string Ref_related { get; set; }
        public string Status { get; set; }
        public Nullable<int> Vehicle_Id { get; set; }
        public Nullable<int> Adult_Number { get; set; }
        public Nullable<int> Child_Number { get; set; }
        public Nullable<System.DateTime> Entry_Datetime { get; set; }
        public string Child_Restraints { get; set; }
        public Nullable<bool> Trailer { get; set; }
        public Nullable<bool> Champagne { get; set; }
        public Nullable<int> Id_Forword { get; set; }
        public Nullable<int> Id_Related { get; set; }
        public Nullable<int> City_Id { get; set; }
        public string Special_Request { get; set; }
        public string ContactName { get; set; }
        public string UserName { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string Paypal_txn_id { get; set; }
        public string Paypal_residence_country { get; set; }
        public string Direction { get; set; }
        public Nullable<System.TimeSpan> Forword_Pickup_Time { get; set; }
        public Nullable<System.DateTime> Forword_Pickup_Date { get; set; }
        public Nullable<System.TimeSpan> Return_Pickup_Time { get; set; }
        public Nullable<System.DateTime> Return_Pickup_Date { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public string Email { get; set; }
    
        public virtual City City { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
