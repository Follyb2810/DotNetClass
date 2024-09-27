Null-coalescing (??)

public void CalculateSalesTax(IStateSalesTax? salesTax = null)
{
    salesTax ??= DefaultStateSalesTax.Value;

    // Safely use salesTax object.
}