
namespace CEssential_hw_4
{
    abstract class Part
    {
        protected string content;
        abstract public string Content { get; set; }
        abstract public void Show();
    }
}
