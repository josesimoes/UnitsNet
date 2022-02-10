//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Globalization;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;
using UnitsNet.InternalHelpers;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     Molar concentration, also called molarity, amount concentration or substance concentration, is a measure of the concentration of a solute in a solution, or of any chemical species, in terms of amount of substance in a given volume. 
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Molar_concentration
    /// </remarks>
    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
    public sealed partial class Molarity : IQuantity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly MolarityUnit? _unit;

        static Molarity()
        {
            BaseDimensions = new BaseDimensions(-3, 0, 0, 0, 0, 1, 0);
            BaseUnit = MolarityUnit.MolesPerCubicMeter;
            MaxValue = new Molarity(double.MaxValue, BaseUnit);
            MinValue = new Molarity(double.MinValue, BaseUnit);
            QuantityType = QuantityType.Molarity;
            Units = Enum.GetValues(typeof(MolarityUnit)).Cast<MolarityUnit>().Except(new MolarityUnit[]{ MolarityUnit.Undefined }).ToArray();
            Zero = new Molarity(0, BaseUnit);
            Info = new QuantityInfo(QuantityType.Molarity, Units.Cast<Enum>().ToArray(), BaseUnit, Zero, BaseDimensions);
        }

        /// <summary>
        ///     Creates the quantity with a value of 0 in the base unit MolesPerCubicMeter.
        /// </summary>
        /// <remarks>
        ///     Windows Runtime Component requires a default constructor.
        /// </remarks>
        public Molarity()
        {
            _value = 0;
            _unit = BaseUnit;
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <remarks>Value parameter cannot be named 'value' due to constraint when targeting Windows Runtime Component.</remarks>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        private Molarity(double value, MolarityUnit unit)
        {
            if (unit == MolarityUnit.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

            _value = Guard.EnsureValidNumber(value, nameof(value));
            _unit = unit;
        }

        #region Static Properties

        /// <summary>
        ///     Information about the quantity type, such as unit values and names.
        /// </summary>
        internal static QuantityInfo Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions { get; }

        /// <summary>
        ///     The base unit of Molarity, which is MolesPerCubicMeter. All conversions go via this value.
        /// </summary>
        public static MolarityUnit BaseUnit { get; }

        /// <summary>
        /// Represents the largest possible value of Molarity
        /// </summary>
        public static Molarity MaxValue { get; }

        /// <summary>
        /// Represents the smallest possible value of Molarity
        /// </summary>
        public static Molarity MinValue { get; }

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        [Obsolete("QuantityType will be removed in the future. Use the Info property instead.")]
        public static QuantityType QuantityType { get; }

        /// <summary>
        ///     All units of measurement for the Molarity quantity.
        /// </summary>
        public static MolarityUnit[] Units { get; }

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit MolesPerCubicMeter.
        /// </summary>
        public static Molarity Zero { get; }

        #endregion

        #region Properties

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => Convert.ToDouble(_value);

        /// <inheritdoc cref="IQuantity.Unit"/>
        object IQuantity.Unit => Unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public MolarityUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        internal QuantityInfo QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        [Obsolete("QuantityType will be removed in the future. Use the Info property instead.")]
        public QuantityType Type => Molarity.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => Molarity.BaseDimensions;

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MolarityUnit.CentimolePerLiter"/>
        /// </summary>
        public double CentimolesPerLiter => As(MolarityUnit.CentimolePerLiter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MolarityUnit.DecimolePerLiter"/>
        /// </summary>
        public double DecimolesPerLiter => As(MolarityUnit.DecimolePerLiter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MolarityUnit.MicromolePerLiter"/>
        /// </summary>
        public double MicromolesPerLiter => As(MolarityUnit.MicromolePerLiter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MolarityUnit.MillimolePerLiter"/>
        /// </summary>
        public double MillimolesPerLiter => As(MolarityUnit.MillimolePerLiter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MolarityUnit.MolePerCubicMeter"/>
        /// </summary>
        public double MolesPerCubicMeter => As(MolarityUnit.MolePerCubicMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MolarityUnit.MolePerLiter"/>
        /// </summary>
        public double MolesPerLiter => As(MolarityUnit.MolePerLiter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MolarityUnit.NanomolePerLiter"/>
        /// </summary>
        public double NanomolesPerLiter => As(MolarityUnit.NanomolePerLiter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MolarityUnit.PicomolePerLiter"/>
        /// </summary>
        public double PicomolesPerLiter => As(MolarityUnit.PicomolePerLiter);

        #endregion

        #region Static Methods

        internal static void MapGeneratedLocalizations(UnitAbbreviationsCache unitAbbreviationsCache)
        {
            unitAbbreviationsCache.PerformAbbreviationMapping(MolarityUnit.CentimolePerLiter, new CultureInfo("en-US"), false, true, new string[]{"cmol/L", "cM"});
            unitAbbreviationsCache.PerformAbbreviationMapping(MolarityUnit.CentimolesPerLiter, new CultureInfo("en-US"), false, false, new string[]{"cmol/L", "cM"});
            unitAbbreviationsCache.PerformAbbreviationMapping(MolarityUnit.DecimolePerLiter, new CultureInfo("en-US"), false, true, new string[]{"dmol/L", "dM"});
            unitAbbreviationsCache.PerformAbbreviationMapping(MolarityUnit.DecimolesPerLiter, new CultureInfo("en-US"), false, false, new string[]{"dmol/L", "dM"});
            unitAbbreviationsCache.PerformAbbreviationMapping(MolarityUnit.MicromolePerLiter, new CultureInfo("en-US"), false, true, new string[]{"µmol/L", "µM"});
            unitAbbreviationsCache.PerformAbbreviationMapping(MolarityUnit.MicromolesPerLiter, new CultureInfo("en-US"), false, false, new string[]{"µmol/L", "µM"});
            unitAbbreviationsCache.PerformAbbreviationMapping(MolarityUnit.MillimolePerLiter, new CultureInfo("en-US"), false, true, new string[]{"mmol/L", "mM"});
            unitAbbreviationsCache.PerformAbbreviationMapping(MolarityUnit.MillimolesPerLiter, new CultureInfo("en-US"), false, false, new string[]{"mmol/L", "mM"});
            unitAbbreviationsCache.PerformAbbreviationMapping(MolarityUnit.MolePerCubicMeter, new CultureInfo("en-US"), false, true, new string[]{"mol/m³"});
            unitAbbreviationsCache.PerformAbbreviationMapping(MolarityUnit.MolePerLiter, new CultureInfo("en-US"), false, true, new string[]{"mol/L", "M"});
            unitAbbreviationsCache.PerformAbbreviationMapping(MolarityUnit.MolesPerCubicMeter, new CultureInfo("en-US"), false, false, new string[]{"mol/m³"});
            unitAbbreviationsCache.PerformAbbreviationMapping(MolarityUnit.MolesPerLiter, new CultureInfo("en-US"), false, false, new string[]{"mol/L", "M"});
            unitAbbreviationsCache.PerformAbbreviationMapping(MolarityUnit.NanomolePerLiter, new CultureInfo("en-US"), false, true, new string[]{"nmol/L", "nM"});
            unitAbbreviationsCache.PerformAbbreviationMapping(MolarityUnit.NanomolesPerLiter, new CultureInfo("en-US"), false, false, new string[]{"nmol/L", "nM"});
            unitAbbreviationsCache.PerformAbbreviationMapping(MolarityUnit.PicomolePerLiter, new CultureInfo("en-US"), false, true, new string[]{"pmol/L", "pM"});
            unitAbbreviationsCache.PerformAbbreviationMapping(MolarityUnit.PicomolesPerLiter, new CultureInfo("en-US"), false, false, new string[]{"pmol/L", "pM"});
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(MolarityUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static string GetAbbreviation(MolarityUnit unit, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="Molarity"/> from <see cref="MolarityUnit.CentimolePerLiter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Molarity FromCentimolesPerLiter(double centimolesperliter)
        {
            double value = (double) centimolesperliter;
            return new Molarity(value, MolarityUnit.CentimolePerLiter);
        }
        /// <summary>
        ///     Creates a <see cref="Molarity"/> from <see cref="MolarityUnit.DecimolePerLiter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Molarity FromDecimolesPerLiter(double decimolesperliter)
        {
            double value = (double) decimolesperliter;
            return new Molarity(value, MolarityUnit.DecimolePerLiter);
        }
        /// <summary>
        ///     Creates a <see cref="Molarity"/> from <see cref="MolarityUnit.MicromolePerLiter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Molarity FromMicromolesPerLiter(double micromolesperliter)
        {
            double value = (double) micromolesperliter;
            return new Molarity(value, MolarityUnit.MicromolePerLiter);
        }
        /// <summary>
        ///     Creates a <see cref="Molarity"/> from <see cref="MolarityUnit.MillimolePerLiter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Molarity FromMillimolesPerLiter(double millimolesperliter)
        {
            double value = (double) millimolesperliter;
            return new Molarity(value, MolarityUnit.MillimolePerLiter);
        }
        /// <summary>
        ///     Creates a <see cref="Molarity"/> from <see cref="MolarityUnit.MolePerCubicMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Molarity FromMolesPerCubicMeter(double molespercubicmeter)
        {
            double value = (double) molespercubicmeter;
            return new Molarity(value, MolarityUnit.MolePerCubicMeter);
        }
        /// <summary>
        ///     Creates a <see cref="Molarity"/> from <see cref="MolarityUnit.MolePerLiter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Molarity FromMolesPerLiter(double molesperliter)
        {
            double value = (double) molesperliter;
            return new Molarity(value, MolarityUnit.MolePerLiter);
        }
        /// <summary>
        ///     Creates a <see cref="Molarity"/> from <see cref="MolarityUnit.NanomolePerLiter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Molarity FromNanomolesPerLiter(double nanomolesperliter)
        {
            double value = (double) nanomolesperliter;
            return new Molarity(value, MolarityUnit.NanomolePerLiter);
        }
        /// <summary>
        ///     Creates a <see cref="Molarity"/> from <see cref="MolarityUnit.PicomolePerLiter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Molarity FromPicomolesPerLiter(double picomolesperliter)
        {
            double value = (double) picomolesperliter;
            return new Molarity(value, MolarityUnit.PicomolePerLiter);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MolarityUnit" /> to <see cref="Molarity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Molarity unit value.</returns>
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static Molarity From(double value, MolarityUnit fromUnit)
        {
            return new Molarity((double)value, fromUnit);
        }

        #endregion

        #region Static Parse Methods

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static Molarity Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static Molarity Parse(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.Parse<Molarity, MolarityUnit>(
                str,
                provider,
                From);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out Molarity result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] string cultureName, out Molarity result)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.TryParse<Molarity, MolarityUnit>(
                str,
                provider,
                From,
                out result);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static MolarityUnit ParseUnit(string str)
        {
            return ParseUnit(str, null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static MolarityUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.Parse<MolarityUnit>(str, provider);
        }

        public static bool TryParseUnit(string str, out MolarityUnit unit)
        {
            return TryParseUnit(str, null, out unit);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="unit">The parsed unit if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.TryParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParseUnit(string str, [CanBeNull] string cultureName, out MolarityUnit unit)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.TryParse<MolarityUnit>(str, provider, out unit);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if (obj is null) throw new ArgumentNullException(nameof(obj));
            if (!(obj is Molarity objMolarity)) throw new ArgumentException("Expected type Molarity.", nameof(obj));

            return CompareTo(objMolarity);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        internal int CompareTo(Molarity other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        [Windows.Foundation.Metadata.DefaultOverload]
        public override bool Equals(object obj)
        {
            if (obj is null || !(obj is Molarity objMolarity))
                return false;

            return Equals(objMolarity);
        }

        public bool Equals(Molarity other)
        {
            return _value.Equals(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another Molarity within the given absolute or relative tolerance.
        ///     </para>
        ///     <para>
        ///     Relative tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a percentage of this quantity's value. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison. A relative tolerance of 0.01 means the absolute difference must be within +/- 1% of
        ///     this quantity's value to be considered equal.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within +/- 1% of a (0.02m or 2cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Relative);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Absolute tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a fixed number in this quantity's unit. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within 0.01 of a (0.01m or 1cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Absolute);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        ///     </para>
        /// </summary>
        /// <param name="other">The other quantity to compare to.</param>
        /// <param name="tolerance">The absolute or relative tolerance value. Must be greater than or equal to 0.</param>
        /// <param name="comparisonType">The comparison type: either relative or absolute.</param>
        /// <returns>True if the absolute difference between the two values is not greater than the specified relative or absolute tolerance.</returns>
        public bool Equals(Molarity other, double tolerance, ComparisonType comparisonType)
        {
            if (tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current Molarity.</returns>
        public override int GetHashCode()
        {
            return new { Info.Name, Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion Methods

        double IQuantity.As(object unit) => As((MolarityUnit)unit);

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(MolarityUnit unit)
        {
            if (Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this Molarity to another Molarity with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Molarity with the specified unit.</returns>
        public Molarity ToUnit(MolarityUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new Molarity(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double AsBaseUnit()
        {
            switch(Unit)
            {
                case MolarityUnit.CentimolePerLiter: return (_value / 1e-3) * 1e-2d;
                case MolarityUnit.CentimolesPerLiter: return (_value / 1e-3) * 1e-2d;
                case MolarityUnit.DecimolePerLiter: return (_value / 1e-3) * 1e-1d;
                case MolarityUnit.DecimolesPerLiter: return (_value / 1e-3) * 1e-1d;
                case MolarityUnit.MicromolePerLiter: return (_value / 1e-3) * 1e-6d;
                case MolarityUnit.MicromolesPerLiter: return (_value / 1e-3) * 1e-6d;
                case MolarityUnit.MillimolePerLiter: return (_value / 1e-3) * 1e-3d;
                case MolarityUnit.MillimolesPerLiter: return (_value / 1e-3) * 1e-3d;
                case MolarityUnit.MolePerCubicMeter: return _value;
                case MolarityUnit.MolePerLiter: return _value / 1e-3;
                case MolarityUnit.MolesPerCubicMeter: return _value;
                case MolarityUnit.MolesPerLiter: return _value / 1e-3;
                case MolarityUnit.NanomolePerLiter: return (_value / 1e-3) * 1e-9d;
                case MolarityUnit.NanomolesPerLiter: return (_value / 1e-3) * 1e-9d;
                case MolarityUnit.PicomolePerLiter: return (_value / 1e-3) * 1e-12d;
                case MolarityUnit.PicomolesPerLiter: return (_value / 1e-3) * 1e-12d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(MolarityUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case MolarityUnit.CentimolePerLiter: return (baseUnitValue * 1e-3) / 1e-2d;
                case MolarityUnit.CentimolesPerLiter: return (baseUnitValue * 1e-3) / 1e-2d;
                case MolarityUnit.DecimolePerLiter: return (baseUnitValue * 1e-3) / 1e-1d;
                case MolarityUnit.DecimolesPerLiter: return (baseUnitValue * 1e-3) / 1e-1d;
                case MolarityUnit.MicromolePerLiter: return (baseUnitValue * 1e-3) / 1e-6d;
                case MolarityUnit.MicromolesPerLiter: return (baseUnitValue * 1e-3) / 1e-6d;
                case MolarityUnit.MillimolePerLiter: return (baseUnitValue * 1e-3) / 1e-3d;
                case MolarityUnit.MillimolesPerLiter: return (baseUnitValue * 1e-3) / 1e-3d;
                case MolarityUnit.MolePerCubicMeter: return baseUnitValue;
                case MolarityUnit.MolePerLiter: return baseUnitValue * 1e-3;
                case MolarityUnit.MolesPerCubicMeter: return baseUnitValue;
                case MolarityUnit.MolesPerLiter: return baseUnitValue * 1e-3;
                case MolarityUnit.NanomolePerLiter: return (baseUnitValue * 1e-3) / 1e-9d;
                case MolarityUnit.NanomolesPerLiter: return (baseUnitValue * 1e-3) / 1e-9d;
                case MolarityUnit.PicomolePerLiter: return (baseUnitValue * 1e-3) / 1e-12d;
                case MolarityUnit.PicomolesPerLiter: return (baseUnitValue * 1e-3) / 1e-12d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(null);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] string cultureName)
        {
            var provider = cultureName;
            return ToString(provider, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString(string cultureName, int significantDigitsAfterRadix)
        {
            var provider = cultureName;
            var value = Convert.ToDouble(Value);
            var format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(provider, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implicitly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] string cultureName, [NotNull] string format, [NotNull] params object[] args)
        {
            var provider = GetFormatProviderFromCultureName(cultureName);
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? GlobalConfiguration.DefaultCulture;

            var value = Convert.ToDouble(Value);
            var formatArgs = UnitFormatter.GetFormatArgs(Unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        #endregion

        private static IFormatProvider GetFormatProviderFromCultureName([CanBeNull] string cultureName)
        {
            return cultureName != null ? new CultureInfo(cultureName) : (IFormatProvider)null;
        }
    }
}
