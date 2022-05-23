using Entities.Concrete;
using Entities.ViewModels;
using LeetSpeakTranslatorMVCApp.Controllers;
using System;
using Xunit;

namespace TestBasicTranslator
{
    public class UnitTest1 //I tested the core of the project.
    {
        [Fact]
        public void TestGetLink() //The method that types the string and gets the link is being tested here.
        {
            string textToTranslateLink = "Where this is lots of love there is lots of fighting.";
            string expectedLink = "https://api.funtranslations.com/translate/leetspeak.json?text=Where%20this%20is%20lots%20of%20love%20there%20is%20lots%20of%20fighting.";
            string result = UserController.GetLink(textToTranslateLink);
            Assert.Equal(expectedLink, result);
        }

        [Fact]
        public void TestConverting()  //The method that being tested here actually works but the data comes from API is always coming different. I am typing link to browser and gets the data from browser. Then i am adding the value to 'expectedConvertingVM.translated'. Method gets the same link and sending request to the API but API is answering different data on every refresh. The method obtains the same meaning from the translations, but only the shapes are different.  
        {
            string link = "https://api.funtranslations.com/translate/leetspeak.json?text=Where%20this%20is%20lots%20of%20love%20there%20is%20lots%20of%20fighting.";
            ConvertingVM expectedConvertingVM = new ConvertingVM();
            expectedConvertingVM.Contents = new Contents() { translated = "wHeR3 7]-[iS 1s lOtz Of 10Ve T]-[3R3 iz l()t5 0F FYgHTinG.", text = "Where this is lots of love there is lots of fighting.", translation = "leetspeak" };
            expectedConvertingVM.Success = new Success() { Total = 1 };
            ConvertingVM result = UserController.GetConvertingVM(link);
            Assert.Equal(expectedConvertingVM,result);
        }
    }
}
