namespace Project5
{
    /// <summary>
    /// Basic interface for a any point-of-sale item
    /// 
    /// I would have approached this project very differently but
    /// because it requires certian methiods than here is the quick 
    /// and very messy abstract application layer.
    /// </summary>
    interface POSCharge
    {

        /// <summary>
        /// Gets a point-of-sale charge.
        /// </summary>
        double Charge
        {
            get;
        }

        /// <summary>
        /// Clear a point-of-sale charge.
        /// </summary>
        void ClearCharge();

    }
}
