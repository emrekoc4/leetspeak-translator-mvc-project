# About the project
* A project that translates texts into **leet.** </BR>
* The user can create an account for himself/herself and have a text translated. He or she can see the searches that made before. </BR>

# What is leet?
>Leet speak, also known as hackspeak or simply leet, is the substitution of a word's letters with numbers or special characters. "Leet" is derived from the word "elite," which refers to the hackers who originally turned leet speak into a sort of cult language in the 1980s. Over time, the label "leet" has broadened to include any term used by programmers that is a mystery to everyone else. You can see more [here](https://www.techtarget.com/whatis/definition/leet-speak-leet-leetspeak-leetspeek-or-hakspeak)</BR>

# How to use on local machine?
* You can use the app by modifying **DefaultConnectionString** to make a connection with database. </BR>
* You can find the **DefaultConnectionString** on **appsettings.json.**

# Technology of the project
* MVC design pattern and latered architecture are used in the project.
* The project sends a text to [this API](https://api.funtranslations.com/translate/leetspeak.json) and saves the response to database with the user information.</BR>
* Authorization is used in the project. There are three controllers in the MVC layer(HomeController,UserController,AdminController). The user logs in from the homecontroller and is redirected to one of the other controllers according to the user type(Admin or User).</BR>
* The user can make search within the application, edit his/her profile and previous search, delete own searches.</BR>
* Unit tests will be added the project. 


