namespace RecipeSystem
{
    public class bizStaff : bizObject<bizStaff>
    {
        private int _staffid;
        private string _firstname = "";
        private string _lastname = "";
        private string _username = "";

        public int StaffId
        {
            get => _staffid;
            set
            {
                if (_staffid != value)
                {
                    _staffid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string FirstName
        {
            get => _firstname;
            set
            {
                if (_firstname != value)
                {
                    _firstname = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string LastName
        {
            get => _lastname;
            set
            {
                if (_lastname != value)
                {
                    _lastname = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string Username
        {
            get => _username;
            set
            {
                if (_username != value)
                {
                    _username = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
