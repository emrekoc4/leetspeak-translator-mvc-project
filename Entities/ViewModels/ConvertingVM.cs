using Entities.Concrete;

namespace Entities.ViewModels
{
    public class ConvertingVM  //Data from the API includes two classes, Contents and Success. This VM handles data from the API.
    {
        public Contents Contents { get; set; } //class that represents the datatable where the data in the database is held (you can see the class in concrete folder)
        public Success Success { get; set; }
    }
}
