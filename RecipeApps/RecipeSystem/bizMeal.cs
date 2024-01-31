namespace RecipeSystem
{
    public class bizMeal : bizObject<bizMeal>
    {
        public bizMeal()
        {

        }

        private int _mealId;
        private int _staffId;
        private string _username = "";
        private string _mealName = "";
        private bool _active;
        private string _mealdesc = "";
        private DateTime _dateCreated;
        private string _imageName = "";

        public int MealId
        {
            get => _mealId;
            set
            {
                if (_mealId != value)
                {
                    _mealId = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int StaffId
        {
            get => _staffId;
            set
            {
                if (_staffId != value)
                {
                    _staffId = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string Username
        {
            get => _username;
            private set
            {
                if (value != _username)
                {
                    _username = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string MealName
        {
            get => _mealName;
            set
            {
                if (_mealName != value)
                {
                    _mealName = value;
                    InvokePropertyChanged();
                }
            }
        }

        public bool Active
        {
            get => _active;
            set
            {
                if (_active != value)
                {
                    _active = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string MealDesc
        {
            get => _mealdesc;
            set
            {
                if (_mealdesc != value)
                {
                    _mealdesc = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime DateCreated
        {
            get => _dateCreated;
            set
            {
                if (_dateCreated != value)
                {
                    _dateCreated = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string ImageName
        {
            get => _imageName.ToLower();
            private set
            {
                if (_imageName != value)
                {
                    _imageName = value.ToLower();
                    InvokePropertyChanged();
                }
            }
        }
    }
}
