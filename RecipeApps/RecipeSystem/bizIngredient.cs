namespace RecipeSystem
{
    public class bizIngredient : bizObject<bizIngredient>
    {
        private int _ingredientid;
        private string _ingredient = "";

        public List<bizIngredient> Search(string ingredientval)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(this.GetSprocName);
            SQLUtility.SetParamValue(cmd, "Ingredient", ingredientval);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }

        public int IngredientId
        {
            get => _ingredientid;
            set
            {
                _ingredientid = value;
                InvokePropertyChanged();
            }
        }

        public string Ingredient
        {
            get => _ingredient;
            set
            {
                _ingredient = value;
                InvokePropertyChanged();
            }
        }
    }
}
