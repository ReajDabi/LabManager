namespace ComLabManager.UI.Navigation
{
    // Pre-filters a page can be opened with; each IFilterableView handles the ones that apply to it
    public enum ViewFilter
    {
        None,
        ActiveAssets,
        HighUsage,
        UnderRepair,
        PendingApprovals,
        ActiveBorrows,
        Overdue,
        LowStock
    }
}
