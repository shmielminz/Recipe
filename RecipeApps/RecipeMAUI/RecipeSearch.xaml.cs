using RecipeSystem;
using System.Data;

namespace RecipeMAUI;

public partial class RecipeSearch : ContentPage
{
	public RecipeSearch()
	{
		InitializeComponent();
    }

    private void SearchRecipe()
    {
        bizRecipe recipe = new();
        var lstrecipe = recipe.Search(RecipeNameTxt.Text);
        RecipeLst.ItemsSource = lstrecipe;
    }

    private void SearchBtn_Clicked(object sender, EventArgs e)
    {
		SearchRecipe();
    }

    private async void RecipeLst_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        bizRecipe recipe = (bizRecipe)e.Item;
        await Navigation.PushAsync(new RecipeDetail(recipe.RecipeId));
    }
}