Script to create login is excluded from repo, and is ignored by git ignore.
Create a file called create-login.sql
And add the following steps to create a login.

--IMPORTANT create login in MASTER
--use MASTER
create login [loginname] with PASSWORD =  '[password]'

--important switch to RecipeDB
create user [username] from login [loginname]
