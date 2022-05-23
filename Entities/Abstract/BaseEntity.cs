/*
 * The Entities layer is the layer containing datatables and models.
*/

namespace Entities.Abstract 

{
    public abstract class BaseEntity  //BaseClass that gives Id(int type) to the classes. 
    {
        public int Id { get; set; }
    }
}
