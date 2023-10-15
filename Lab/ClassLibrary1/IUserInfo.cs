namespace ClassLibrary1
{
    public interface IUserInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PlaceOfResidence { get; set; }
        public Gender Gender { get; set; }
        public string ErrorMessage { get; set; }
        public bool ShowFormErrors { get; set; }
        public event EventHandler SaveAttempted;
    }
}