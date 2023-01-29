--replace //loginname// and //password// with secret values from vault
--IMPORTANT create login in MASTER
--use MASTER
create login //loginname// with PASSWORD =  '//password//'

--important switch to RecipeDB
create user dev_user from login //loginname//

alter role db_datareader add member dev_user
alter role db_datawriter add member dev_user