
namespace Entities.ViewModels
{
    public class UserContentListVM //It is a model created to hold both user and content properties in a single model.
    {
        public int ContentId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Translated { get; set; }
        public string Text { get; set; }
        public string Translation { get; set; }
        public string PhotoAddress { get; set; }

    }
}
