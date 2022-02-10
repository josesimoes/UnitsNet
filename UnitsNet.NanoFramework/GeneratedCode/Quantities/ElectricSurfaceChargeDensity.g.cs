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
    ///     In electromagnetism, surface charge density is a measure of the amount of electric charge per surface area.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Charge_density
    /// </remarks>
    public struct  ElectricSurfaceChargeDensity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ElectricSurfaceChargeDensityUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public ElectricSurfaceChargeDensityUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public ElectricSurfaceChargeDensity(double value, ElectricSurfaceChargeDensityUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static ElectricSurfaceChargeDensityUnit BaseUnit { get; } = ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static ElectricSurfaceChargeDensity MaxValue { get; } = new ElectricSurfaceChargeDensity(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static ElectricSurfaceChargeDensity MinValue { get; } = new ElectricSurfaceChargeDensity(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ElectricSurfaceChargeDensity Zero { get; } = new ElectricSurfaceChargeDensity(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter"/>
        /// </summary>
        public double CoulombsPerSquareCentimeter => As(ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch"/>
        /// </summary>
        public double CoulombsPerSquareInch => As(ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter"/>
        /// </summary>
        public double CoulombsPerSquareMeter => As(ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="ElectricSurfaceChargeDensity"/> from <see cref="ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricSurfaceChargeDensity FromCoulombsPerSquareCentimeter(double coulombspersquarecentimeter) => new ElectricSurfaceChargeDensity(coulombspersquarecentimeter, ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricSurfaceChargeDensity"/> from <see cref="ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricSurfaceChargeDensity FromCoulombsPerSquareInch(double coulombspersquareinch) => new ElectricSurfaceChargeDensity(coulombspersquareinch, ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch);

        /// <summary>
        ///     Creates a <see cref="ElectricSurfaceChargeDensity"/> from <see cref="ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricSurfaceChargeDensity FromCoulombsPerSquareMeter(double coulombspersquaremeter) => new ElectricSurfaceChargeDensity(coulombspersquaremeter, ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ElectricSurfaceChargeDensityUnit" /> to <see cref="ElectricSurfaceChargeDensity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ElectricSurfaceChargeDensity unit value.</returns>
        public static ElectricSurfaceChargeDensity From(double value, ElectricSurfaceChargeDensityUnit fromUnit)
        {
            return new ElectricSurfaceChargeDensity(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(ElectricSurfaceChargeDensityUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public ElectricSurfaceChargeDensity ToUnit(ElectricSurfaceChargeDensityUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new ElectricSurfaceChargeDensity(convertedValue, unit);
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
                ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter => _value * 1.0e4,
                ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch => _value * 1.5500031000062000e3,
                ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter => _value,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(ElectricSurfaceChargeDensityUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter => baseUnitValue / 1.0e4,
                ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch => baseUnitValue / 1.5500031000062000e3,
                ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter => baseUnitValue,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion

    }
}

