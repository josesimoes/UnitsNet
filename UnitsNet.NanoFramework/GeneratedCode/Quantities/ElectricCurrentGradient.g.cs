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
using UnitsNet.Units;

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     In electromagnetism, the current gradient describes how the current changes in time.
    /// </summary>
    public struct  ElectricCurrentGradient
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ElectricCurrentGradientUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public ElectricCurrentGradientUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public ElectricCurrentGradient(double value, ElectricCurrentGradientUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static ElectricCurrentGradientUnit BaseUnit { get; } = ElectricCurrentGradientUnit.AmperePerSecond;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static ElectricCurrentGradient MaxValue { get; } = new ElectricCurrentGradient(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static ElectricCurrentGradient MinValue { get; } = new ElectricCurrentGradient(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ElectricCurrentGradient Zero { get; } = new ElectricCurrentGradient(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricCurrentGradientUnit.AmperePerMicrosecond"/>
        /// </summary>
        public double AmperesPerMicrosecond => As(ElectricCurrentGradientUnit.AmperePerMicrosecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricCurrentGradientUnit.AmperePerMillisecond"/>
        /// </summary>
        public double AmperesPerMillisecond => As(ElectricCurrentGradientUnit.AmperePerMillisecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricCurrentGradientUnit.AmperePerNanosecond"/>
        /// </summary>
        public double AmperesPerNanosecond => As(ElectricCurrentGradientUnit.AmperePerNanosecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricCurrentGradientUnit.AmperePerSecond"/>
        /// </summary>
        public double AmperesPerSecond => As(ElectricCurrentGradientUnit.AmperePerSecond);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="ElectricCurrentGradient"/> from <see cref="ElectricCurrentGradientUnit.AmperePerMicrosecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrentGradient FromAmperesPerMicrosecond(double amperespermicrosecond) => new ElectricCurrentGradient(amperespermicrosecond, ElectricCurrentGradientUnit.AmperePerMicrosecond);

        /// <summary>
        ///     Creates a <see cref="ElectricCurrentGradient"/> from <see cref="ElectricCurrentGradientUnit.AmperePerMillisecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrentGradient FromAmperesPerMillisecond(double amperespermillisecond) => new ElectricCurrentGradient(amperespermillisecond, ElectricCurrentGradientUnit.AmperePerMillisecond);

        /// <summary>
        ///     Creates a <see cref="ElectricCurrentGradient"/> from <see cref="ElectricCurrentGradientUnit.AmperePerNanosecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrentGradient FromAmperesPerNanosecond(double amperespernanosecond) => new ElectricCurrentGradient(amperespernanosecond, ElectricCurrentGradientUnit.AmperePerNanosecond);

        /// <summary>
        ///     Creates a <see cref="ElectricCurrentGradient"/> from <see cref="ElectricCurrentGradientUnit.AmperePerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrentGradient FromAmperesPerSecond(double amperespersecond) => new ElectricCurrentGradient(amperespersecond, ElectricCurrentGradientUnit.AmperePerSecond);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ElectricCurrentGradientUnit" /> to <see cref="ElectricCurrentGradient" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ElectricCurrentGradient unit value.</returns>
        public static ElectricCurrentGradient From(double value, ElectricCurrentGradientUnit fromUnit)
        {
            return new ElectricCurrentGradient(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(ElectricCurrentGradientUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public ElectricCurrentGradient ToUnit(ElectricCurrentGradientUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new ElectricCurrentGradient(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double GetValueInBaseUnit()
        {
            return Unit switch
            {
                ElectricCurrentGradientUnit.AmperePerMicrosecond => _value*1E6,
                ElectricCurrentGradientUnit.AmperePerMillisecond => _value*1E3,
                ElectricCurrentGradientUnit.AmperePerNanosecond => _value*1E9,
                ElectricCurrentGradientUnit.AmperePerSecond => _value,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(ElectricCurrentGradientUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                ElectricCurrentGradientUnit.AmperePerMicrosecond => baseUnitValue/1E6,
                ElectricCurrentGradientUnit.AmperePerMillisecond => baseUnitValue/1E3,
                ElectricCurrentGradientUnit.AmperePerNanosecond => baseUnitValue/1E9,
                ElectricCurrentGradientUnit.AmperePerSecond => baseUnitValue,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion

    }
}

