# leetspeak-translator-mvc-project
 --The project sends a text to https://api.funtranslations.com/translate/leetspeak.json and saves the response from that address to the database.
--Authorization is used in the project. There are two types of users, user and admin.
--There are three controllers in the MVC layer(HomeController,UserController,AdminController). The user logs in from the homecontroller and is redirected to one of the other controllers 
according to the user type.
--The searches made are recorded in the database together with the user information.
--The user can make search in the application, edit their profile and previous search, delete their searches.
--Admin can add new user, add new admin, delete any user's profile, delete any search and edit users' profile.
--Admin can do anything that user does.
