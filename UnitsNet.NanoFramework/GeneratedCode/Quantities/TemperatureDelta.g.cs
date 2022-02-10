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
    ///     Difference between two temperatures. The conversions are different than for Temperature.
    /// </summary>
    public struct  TemperatureDelta
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly TemperatureDeltaUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public TemperatureDeltaUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public TemperatureDelta(double value, TemperatureDeltaUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static TemperatureDeltaUnit BaseUnit { get; } = TemperatureDeltaUnit.Kelvin;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static TemperatureDelta MaxValue { get; } = new TemperatureDelta(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static TemperatureDelta MinValue { get; } = new TemperatureDelta(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static TemperatureDelta Zero { get; } = new TemperatureDelta(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TemperatureDeltaUnit.DegreeCelsius"/>
        /// </summary>
        public double DegreesCelsius => As(TemperatureDeltaUnit.DegreeCelsius);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TemperatureDeltaUnit.DegreeDelisle"/>
        /// </summary>
        public double DegreesDelisle => As(TemperatureDeltaUnit.DegreeDelisle);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TemperatureDeltaUnit.DegreeFahrenheit"/>
        /// </summary>
        public double DegreesFahrenheit => As(TemperatureDeltaUnit.DegreeFahrenheit);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TemperatureDeltaUnit.DegreeNewton"/>
        /// </summary>
        public double DegreesNewton => As(TemperatureDeltaUnit.DegreeNewton);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TemperatureDeltaUnit.DegreeRankine"/>
        /// </summary>
        public double DegreesRankine => As(TemperatureDeltaUnit.DegreeRankine);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TemperatureDeltaUnit.DegreeReaumur"/>
        /// </summary>
        public double DegreesReaumur => As(TemperatureDeltaUnit.DegreeReaumur);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TemperatureDeltaUnit.DegreeRoemer"/>
        /// </summary>
        public double DegreesRoemer => As(TemperatureDeltaUnit.DegreeRoemer);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TemperatureDeltaUnit.Kelvin"/>
        /// </summary>
        public double Kelvins => As(TemperatureDeltaUnit.Kelvin);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TemperatureDeltaUnit.MillidegreeCelsius"/>
        /// </summary>
        public double MillidegreesCelsius => As(TemperatureDeltaUnit.MillidegreeCelsius);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="TemperatureDelta"/> from <see cref="TemperatureDeltaUnit.DegreeCelsius"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureDelta FromDegreesCelsius(double degreescelsius) => new TemperatureDelta(degreescelsius, TemperatureDeltaUnit.DegreeCelsius);

        /// <summary>
        ///     Creates a <see cref="TemperatureDelta"/> from <see cref="TemperatureDeltaUnit.DegreeDelisle"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureDelta FromDegreesDelisle(double degreesdelisle) => new TemperatureDelta(degreesdelisle, TemperatureDeltaUnit.DegreeDelisle);

        /// <summary>
        ///     Creates a <see cref="TemperatureDelta"/> from <see cref="TemperatureDeltaUnit.DegreeFahrenheit"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureDelta FromDegreesFahrenheit(double degreesfahrenheit) => new TemperatureDelta(degreesfahrenheit, TemperatureDeltaUnit.DegreeFahrenheit);

        /// <summary>
        ///     Creates a <see cref="TemperatureDelta"/> from <see cref="TemperatureDeltaUnit.DegreeNewton"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureDelta FromDegreesNewton(double degreesnewton) => new TemperatureDelta(degreesnewton, TemperatureDeltaUnit.DegreeNewton);

        /// <summary>
        ///     Creates a <see cref="TemperatureDelta"/> from <see cref="TemperatureDeltaUnit.DegreeRankine"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureDelta FromDegreesRankine(double degreesrankine) => new TemperatureDelta(degreesrankine, TemperatureDeltaUnit.DegreeRankine);

        /// <summary>
        ///     Creates a <see cref="TemperatureDelta"/> from <see cref="TemperatureDeltaUnit.DegreeReaumur"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureDelta FromDegreesReaumur(double degreesreaumur) => new TemperatureDelta(degreesreaumur, TemperatureDeltaUnit.DegreeReaumur);

        /// <summary>
        ///     Creates a <see cref="TemperatureDelta"/> from <see cref="TemperatureDeltaUnit.DegreeRoemer"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureDelta FromDegreesRoemer(double degreesroemer) => new TemperatureDelta(degreesroemer, TemperatureDeltaUnit.DegreeRoemer);

        /// <summary>
        ///     Creates a <see cref="TemperatureDelta"/> from <see cref="TemperatureDeltaUnit.Kelvin"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureDelta FromKelvins(double kelvins) => new TemperatureDelta(kelvins, TemperatureDeltaUnit.Kelvin);

        /// <summary>
        ///     Creates a <see cref="TemperatureDelta"/> from <see cref="TemperatureDeltaUnit.MillidegreeCelsius"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureDelta FromMillidegreesCelsius(double millidegreescelsius) => new TemperatureDelta(millidegreescelsius, TemperatureDeltaUnit.MillidegreeCelsius);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="TemperatureDeltaUnit" /> to <see cref="TemperatureDelta" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>TemperatureDelta unit value.</returns>
        public static TemperatureDelta From(double value, TemperatureDeltaUnit fromUnit)
        {
            return new TemperatureDelta(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(TemperatureDeltaUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public TemperatureDelta ToUnit(TemperatureDeltaUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new TemperatureDelta(convertedValue, unit);
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
                TemperatureDeltaUnit.DegreeCelsius => _value,
                TemperatureDeltaUnit.DegreeDelisle => _value*-2/3,
                TemperatureDeltaUnit.DegreeFahrenheit => _value*5/9,
                TemperatureDeltaUnit.DegreeNewton => _value*100/33,
                TemperatureDeltaUnit.DegreeRankine => _value*5/9,
                TemperatureDeltaUnit.DegreeReaumur => _value*5/4,
                TemperatureDeltaUnit.DegreeRoemer => _value*40/21,
                TemperatureDeltaUnit.Kelvin => _value,
                TemperatureDeltaUnit.MillidegreeCelsius => (_value) * 1e-3d,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(TemperatureDeltaUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                TemperatureDeltaUnit.DegreeCelsius => baseUnitValue,
                TemperatureDeltaUnit.DegreeDelisle => baseUnitValue*-3/2,
                TemperatureDeltaUnit.DegreeFahrenheit => baseUnitValue*9/5,
                TemperatureDeltaUnit.DegreeNewton => baseUnitValue*33/100,
                TemperatureDeltaUnit.DegreeRankine => baseUnitValue*9/5,
                TemperatureDeltaUnit.DegreeReaumur => baseUnitValue*4/5,
                TemperatureDeltaUnit.DegreeRoemer => baseUnitValue*21/40,
                TemperatureDeltaUnit.Kelvin => baseUnitValue,
                TemperatureDeltaUnit.MillidegreeCelsius => (baseUnitValue) / 1e-3d,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion

    }
}

