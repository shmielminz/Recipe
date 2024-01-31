namespace RecipeSystem
{
    public class bizRecipeIngredient : bizObject<bizRecipeIngredient>
    {
        private int _recipeingredientid;
        private int _recipeid;
        private int _ingredientid;
        private int _measurementid;
        private int _sequenceval;
        private decimal _measurementqty;

        public List<bizRecipeIngredient> LoadByRecipeId(int recipeid)
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeIngredientGet");
            SQLUtility.SetParamValue(cmd, "@RecipeId", recipeid);
            dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }

        public int RecipeIngredientId
        {
            get => _recipeingredientid;
            set
            {
                if (_recipeingredientid != value)
                {
                    _recipeingredientid = value;
                    InvokePropertyChanged();
                }
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

        public int IngredientId
        {
            get => _ingredientid;
            set
            {
                if (_ingredientid != value)
                {
                    _ingredientid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int MeasurementId
        {
            get => _measurementid;
            set
            {
                if (_measurementid != value)
                {
                    _measurementid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int SequenceVal
        {
            get => _sequenceval;
            set
            {
                if (_sequenceval != value)
                {
                    _sequenceval = value;
                    InvokePropertyChanged();
                }
            }
        }

        public decimal MeasurementQty
        {
            get => _measurementqty;
            set
            {
                if (_measurementqty != value)
                {
                    _measurementqty = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
