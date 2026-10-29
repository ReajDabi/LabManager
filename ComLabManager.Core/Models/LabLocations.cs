namespace ComLabManager.Core.Models
{
    // The single list of lab locations shared by every form
    public static class LabLocations
    {
        // Rooms that can hold classes and be reserved
        public static readonly string[] Rooms = { "CLV1", "CLV2", "CLV3", "Engineering", "ICT" };

        // Every place equipment can be kept, including storage
        public static readonly string[] All = { "CLV1", "CLV2", "CLV3", "Engineering", "ICT", "Storage" };
    }
}
