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
    ///     Volt-ampere reactive (var) is a unit by which reactive power is expressed in an AC electric power system. Reactive power exists in an AC circuit when the current and voltage are not in phase.
    /// </summary>
    public struct  ReactivePower
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ReactivePowerUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public ReactivePowerUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public ReactivePower(double value, ReactivePowerUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static ReactivePowerUnit BaseUnit { get; } = ReactivePowerUnit.VoltampereReactive;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static ReactivePower MaxValue { get; } = new ReactivePower(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static ReactivePower MinValue { get; } = new ReactivePower(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ReactivePower Zero { get; } = new ReactivePower(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ReactivePowerUnit.GigavoltampereReactive"/>
        /// </summary>
        public double GigavoltamperesReactive => As(ReactivePowerUnit.GigavoltampereReactive);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ReactivePowerUnit.KilovoltampereReactive"/>
        /// </summary>
        public double KilovoltamperesReactive => As(ReactivePowerUnit.KilovoltampereReactive);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ReactivePowerUnit.MegavoltampereReactive"/>
        /// </summary>
        public double MegavoltamperesReactive => As(ReactivePowerUnit.MegavoltampereReactive);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ReactivePowerUnit.VoltampereReactive"/>
        /// </summary>
        public double VoltamperesReactive => As(ReactivePowerUnit.VoltampereReactive);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="ReactivePower"/> from <see cref="ReactivePowerUnit.GigavoltampereReactive"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReactivePower FromGigavoltamperesReactive(double gigavoltamperesreactive) => new ReactivePower(gigavoltamperesreactive, ReactivePowerUnit.GigavoltampereReactive);

        /// <summary>
        ///     Creates a <see cref="ReactivePower"/> from <see cref="ReactivePowerUnit.KilovoltampereReactive"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReactivePower FromKilovoltamperesReactive(double kilovoltamperesreactive) => new ReactivePower(kilovoltamperesreactive, ReactivePowerUnit.KilovoltampereReactive);

        /// <summary>
        ///     Creates a <see cref="ReactivePower"/> from <see cref="ReactivePowerUnit.MegavoltampereReactive"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReactivePower FromMegavoltamperesReactive(double megavoltamperesreactive) => new ReactivePower(megavoltamperesreactive, ReactivePowerUnit.MegavoltampereReactive);

        /// <summary>
        ///     Creates a <see cref="ReactivePower"/> from <see cref="ReactivePowerUnit.VoltampereReactive"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReactivePower FromVoltamperesReactive(double voltamperesreactive) => new ReactivePower(voltamperesreactive, ReactivePowerUnit.VoltampereReactive);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ReactivePowerUnit" /> to <see cref="ReactivePower" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ReactivePower unit value.</returns>
        public static ReactivePower From(double value, ReactivePowerUnit fromUnit)
        {
            return new ReactivePower(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(ReactivePowerUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public ReactivePower ToUnit(ReactivePowerUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new ReactivePower(convertedValue, unit);
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
                ReactivePowerUnit.GigavoltampereReactive => (_value) * 1e9d,
                ReactivePowerUnit.KilovoltampereReactive => (_value) * 1e3d,
                ReactivePowerUnit.MegavoltampereReactive => (_value) * 1e6d,
                ReactivePowerUnit.VoltampereReactive => _value,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(ReactivePowerUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                ReactivePowerUnit.GigavoltampereReactive => (baseUnitValue) / 1e9d,
                ReactivePowerUnit.KilovoltampereReactive => (baseUnitValue) / 1e3d,
                ReactivePowerUnit.MegavoltampereReactive => (baseUnitValue) / 1e6d,
                ReactivePowerUnit.VoltampereReactive => baseUnitValue,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion

    }
}

