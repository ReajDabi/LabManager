namespace ComLabManager.UI.Navigation
{
    // A page that can be opened already filtered, e.g. from a dashboard card
    public interface IFilterableView
    {
        void ApplyFilter(ViewFilter filter);
    }
}
