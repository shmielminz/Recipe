namespace RecipeSystem
{
    public class bizRecipe : bizObject<bizRecipe>
    {
        public bizRecipe()
        {

        }

        private int _recipeid;
        private int _staffid;
        private string _username = "";
        private int _cuisineid;
        private string _recipename = "";
        private int _calories;
        private int _numingredients;
        private DateTime _datedrafted;
        private DateTime? _datepublished;
        private DateTime? _datearchived;
        private bool _isvegan;
        private string _imagename = "";
        private string _recipestatus = "";
        private List<bizStaff>? _lststaff;
        private List<bizCuisine>? _lstcuisine;
        private List<bizRecipeIngredient> _lstrecipeingredient;
        private List<bizRecipeStep> _lstrecipestep;


        public List<bizRecipe> Search(string recipenameval)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(this.GetSprocName);
            SQLUtility.SetParamValue(cmd, "RecipeName", recipenameval);
            if (recipenameval == "")
            {
                SQLUtility.SetParamValue(cmd, "All", 1);
            }
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }

        public List<bizRecipe> GetRecipesFromCookbook(string cookbookname)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            SQLUtility.SetParamValue(cmd, "CookbookName", cookbookname);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }

        private List<bizStaff> StaffList
        {
            get
            {
                if (_lststaff == null)
                {
                    _lststaff = new bizStaff().GetList(true);
                }
                return _lststaff;
            }
        }

        private bizStaff? Staff
        {
            get => _lststaff?.FirstOrDefault(s => s.StaffId == this.StaffId);
            set
            {
                this.StaffId = value == null ? 0 : value.StaffId;
                InvokePropertyChanged();
            }
        }

        private List<bizCuisine> CuisineList
        {
            get
            {
                if (_lstcuisine == null)
                {
                    _lstcuisine = new bizCuisine().GetList(true);
                }
                return _lstcuisine;
            }
        }

        private bizCuisine? Cuisine
        {
            get => _lstcuisine?.FirstOrDefault(s => s.CuisineId == this.CuisineId);
            set
            {
                this.CuisineId = value == null ? 0 : value.CuisineId;
                InvokePropertyChanged();
            }
        }

        public List<bizRecipeIngredient> RecipeIngredientList
        {
            get
            {
                if (_lstrecipeingredient == null)
                {
                    _lstrecipeingredient = new bizRecipeIngredient().LoadByRecipeId(this.RecipeId);
                }
                return _lstrecipeingredient;
            }
        }

        public List<bizRecipeStep> RecipeStepList
        {
            get
            {
                if (_lstrecipestep == null)
                {
                    _lstrecipestep = new bizRecipeStep().LoadByRecipeId(this.RecipeId);
                }
                return _lstrecipestep;
            }
        }

        public int RecipeId
        {
            get => _recipeid;
            set
            {
                if (_recipeid != value)
                {
                    _recipeid = value;
                    InvokePropertyChanged();
                }
            }
        }

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

        public string Username
        {
            get => _username;
            private set
            {
                if (_username != value)
                {
                    _username = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int CuisineId
        {
            get => _cuisineid;
            set
            {
                if (_cuisineid != value)
                {
                    _cuisineid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string RecipeName
        {
            get => _recipename;
            set
            {
                if (_recipename != value)
                {
                    _recipename = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int Calories
        {
            get => _calories;
            set
            {
                if (_calories != value)
                {
                    _calories = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int NumIngredients
        {
            get => _numingredients;
            private set
            {
                if (_numingredients != value)
                {
                    _numingredients = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime DateDrafted
        {
            get => _datedrafted;
            set
            {
                if (_datedrafted != value)
                {
                    _datedrafted = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime? DatePublished
        {
            get => _datepublished;
            set
            {
                if (_datepublished != value)
                {
                    _datepublished = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime? DateArchived
        {
            get => _datearchived;
            set
            {
                if (_datearchived != value)
                {
                    _datearchived = value;
                    InvokePropertyChanged();
                }
            }
        }

        public bool IsVegan
        {
            get => _isvegan;
            set
            {
                if (_isvegan != value)
                {
                    _isvegan = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string ImageName
        {
            get => _imagename.ToLower();
            private set
            {
                if (_imagename != value)
                {
                    _imagename = value.ToLower();
                    InvokePropertyChanged();
                }
            }
        }

        public string RecipeStatus
        {
            get => _recipestatus;
            private set
            {
                if (_recipestatus != value)
                {
                    _recipestatus = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
