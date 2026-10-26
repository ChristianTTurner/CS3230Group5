using System;
using System.Collections.Generic;
using System.Text;

namespace CS3230_Group5.Model
{
    public class SignedInUser
    {
        public static string? Username {  get; set; }
        public static string? Password { get; set; }
        public static int? UserID { get; set; }
        public static string? FirstName { get; set; }
        public static string? LastName { get; set; }
        public static DateOnly? DateOfBirth { get; set; }
        public static string? Phone {  get; set; }
        public static int? AddressId { get; set; }
        public static bool? IsAdmin {  get; set; }

        public static void Clear()
        {
            UserID = null;
            FirstName = null;
            LastName = null;
            DateOfBirth = null;
            Phone = null;
            AddressId = null;
            IsAdmin = false;
        }
    }
}
