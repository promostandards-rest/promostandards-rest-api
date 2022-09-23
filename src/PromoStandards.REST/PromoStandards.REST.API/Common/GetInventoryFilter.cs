namespace PromoStandards.REST.API.Common
{
    public class GetInventoryFilter
    {
        /// <summary>
        /// Filter.partIdArray, implemented as a comma separated list of partIds
        /// Example: SL238PR-32,SL238PR-37
        /// </summary>
        public string? PartIds { get; set; }

        /// <summary>
        /// Filter.colorArray, implemented as a comma separated list of partColors
        /// Example: Black,Blue
        /// </summary>
        public string? PartColors { get; set; }

        /// <summary>
        /// Filter.LabelSizes, not implemented, always returns all label sizes
        /// </summary>
        public string? LableSizes { get; set; }

    }
}
