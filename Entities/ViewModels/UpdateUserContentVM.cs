
namespace Entities.ViewModels
{
    public class UpdateUserContentVM  //It has been created so that the user and the content can be met with a single model.
    {
        public string UserName { get; set; }
        public int ContentId { get; set; }
        public string Content { get; set; }
    }
}
