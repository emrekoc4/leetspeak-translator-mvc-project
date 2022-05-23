# Summary of the project
*The project sends a text to https://api.funtranslations.com/translate/leetspeak.json and saves the response from that address to the database.</BR>
*Authorization is used in the project. There are two types of users, user and admin.</BR>
*There are three controllers in the MVC layer(HomeController,UserController,AdminController). The user logs in from the homecontroller and is redirected to one of the other controllers 
according to the user type.</BR>
*The searches made are recorded in the database together with the user information.</BR>
*The user can make search in the application, edit their profile and previous search, delete their searches.</BR>
*Admin can add new user, add new admin, delete any user's profile, delete any search and edit users' profile.</BR>
*Admin can do anything that user does.

