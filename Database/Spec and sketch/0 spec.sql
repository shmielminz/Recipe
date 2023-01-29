--AS Great job! 100%
/*
We have a very popular recipe website where we have recipes, meals, and cookbooks, and so on. But the problem is that the more popular we get, the more we have to manage, 
and when we have things that can be viewed in multiple pages, for example a recipe that can be part of a meal etc, everything gets duplicated, 
and when we change something in one page, we need to change in other pages as well, and this causes a lot of problems.

A recipe has an AUTHOR, a unique name, a CUISINE type (Chinese, meditrainian, etc), then we have ingredients which has a unique MEASUREMENT type (example cups, tsp, etc) 
and amount (example 3 cups of flour), and a COURSE TYPE, (The ingredients are in a specific order and you need to record the sequence of the ingredients in the recipe), 
and there's a direction of steps (which have a number, and instructions) how to make the recipe.

We have a STATUS of a recipe for example when a recipe is being on trial it's in drafts then it's being published on the website and if it's to old it's archived, 
and it needs a date when it was live and for how long until it was archived (not deleted).

So, when we have a recipe, our staff then make MEALS where there are COURSE TYPES (appetisers, main, desert, etc. (all of which can have multiple recipes)), 
and a name (unique) for the meal, and the course type has a sequence in the meal (not to have the desert before the main), 
and the meal has multiple courses but can only have one per course type.

A COOKBOOK has a name, price, and recipes, which have a certain sequence how they are presented in the book.

Q. Do meals and cookbooks also have a status?
A. The recipe is the only one that needs a status and we need to know when it was added and removed, but meals etc. 
which is only a collection of recipes we just need to know if it's active (on the site) or inactive, without a date!

Q. You mentioned staff what do they do?
A. Staff have a first name and last name and a username, and everything thats created in the system we need to know who's the user.

Q: You mentioned that one course can have multiple recipes. Is it important to differentiate between the main dish and side dishes? 
A: Yes,  we need to record which recipe is the main dish and which are side dishes. This will allow us to display the course properly with the main dish in the center. 
    If there is no main and side then we will display all the recipes in the course the same without emphasis on a single recipe.

Q: Can the status of a recipe go straight from the drafted to archived? 
A: Yes, we may have a recipe which does not meet our standards and don't have time to work on it, so we archive it to get it out of the way, and then when we have time, 
    we'll take it out of archive back to draft, and then publish it.

Q: Do you want to record how many calories there are in a recipe? 
A: Yes. 

Q: You mentioned that the dates when meals and cookbooks become active or inactive are not important to you. However, would you be interested in keeping record of the dates 
    they were created instead? 
A: Yes.

Q from client: My website designer explained to me that the content for the web pages come from the database, and that the images on the web page are based on the file names, 
    and those file name have to be part of the data that populates the site. The developer told me to double check with you that the file name will be in the database. 
    Is that part of the spec?
A: Yes, for sure, I understood that from our interview and it will be done.

Q from client: Good, web designer also asked to double check that you got our picture file name format Entity-Entity-Name.jpg like Recipe-French-Toast.jpg. 
    Sorry for being paranoid, its just we worked hard on this and want to ensure that the new database integrates smoothly with our existing system.
A: Yes, I got the format, and no worries about double checking, it is best to be clear especially at early stages of the development process because 
    we are building the foundation of the system.

*/