namespace GitVersion
{
    public class CommitFilter
    {
        public bool FirstParentOnly { get; set; }
        public object IncludeReachableFrom { get; set; }
        public object ExcludeReachableFrom { get; set; }
        public CommitSortStrategies SortBy { get; set; }
    }
}
