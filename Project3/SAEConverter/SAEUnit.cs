using System;

/// <summary>
/// The possbile units and conversion values used to calculate 
/// a conversion factor.
/// 
/// </summary>
public enum SAEUnit
{
    Inches = 1, // 1 inch = 1 inch
    Feet = 12,  // 12 inches = 1 foot
    Yards = 36  // 36 inches = 1 foot
}

/// <summary>
/// It took a lot of years for Java to get an Enum but they are more
/// flexiable than C# enum. There is a lot of wiring and reflection to work
/// with them. Nonetheless, I wanted to work more with the data structures and 
/// extension classes.
/// </summary>
public static class SAEUnitExtension
{

    /// <summary>
    /// Gets the factor for to convert one SAEUnit to another.
    /// </summary>
    /// <param name="convertFrom"></param>
    /// <param name="convertTo"></param>
    /// <returns>Double the Factory</returns>
    public static double Factor(this SAEUnit convertFrom, SAEUnit convertTo)
    {
        double factor = 1.0;                                    // Same units factor of 1.0
        if(convertFrom > convertTo)                     
        {
            factor = (double) convertFrom / (double) convertTo; // Larger-to-smaller factor
        } else if(convertFrom < convertTo)
        {
            factor = (double)convertTo / (double)convertFrom;   // Smaller-to-lager factor
        }
        return factor;
    }

    /// <summary>
    /// Converts an input value from one SAEUnit to another
    /// 
    /// </summary>
    /// <param name="convertFrom"></param>
    /// <param name="convertTo"></param>
    /// <param name="inputValue"></param>
    /// <returns></returns>
    public static double Convert(this SAEUnit convertFrom, SAEUnit convertTo, double inputValue)
    {
        double convertedValue = inputValue;                              // Same unit conversion
        if(convertFrom > convertTo)
        {
            convertedValue = inputValue * convertFrom.Factor(convertTo); // Larger-to-smaller conversion (multiply)
        } else if (convertFrom < convertTo)
        {
            convertedValue = inputValue / convertFrom.Factor(convertTo); // Smaller-to-laerger conversion (divide)
        }
        return convertedValue;
    }

    /// <summary>
    /// My little utility method to determine the character
    /// representation of the operation used to convert the 
    /// units.
    /// </summary>
    /// <param name="convertFrom"></param>
    /// <param name="convertTo"></param>
    /// <returns></returns>
    public static Char Operation(this SAEUnit convertFrom, SAEUnit convertTo)
    {
        Char operatorChar = 'x';            // Same unit or Larger-to-smaller conversion
        if(convertFrom < convertTo)         // Smaller-to-larger conversion
        {
            operatorChar = '÷'; //Alt+246 -- learn something new everyday
        }

        return operatorChar;

    }

}