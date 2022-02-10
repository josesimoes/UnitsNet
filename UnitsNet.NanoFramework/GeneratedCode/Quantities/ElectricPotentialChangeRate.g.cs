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
    ///     ElectricPotential change rate is the ratio of the electric potential change to the time during which the change occurred (value of electric potential changes per unit time).
    /// </summary>
    public struct  ElectricPotentialChangeRate
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ElectricPotentialChangeRateUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public ElectricPotentialChangeRateUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public ElectricPotentialChangeRate(double value, ElectricPotentialChangeRateUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static ElectricPotentialChangeRateUnit BaseUnit { get; } = ElectricPotentialChangeRateUnit.VoltPerSecond;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static ElectricPotentialChangeRate MaxValue { get; } = new ElectricPotentialChangeRate(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static ElectricPotentialChangeRate MinValue { get; } = new ElectricPotentialChangeRate(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ElectricPotentialChangeRate Zero { get; } = new ElectricPotentialChangeRate(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialChangeRateUnit.KilovoltPerHour"/>
        /// </summary>
        public double KilovoltsPerHours => As(ElectricPotentialChangeRateUnit.KilovoltPerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialChangeRateUnit.KilovoltPerMicrosecond"/>
        /// </summary>
        public double KilovoltsPerMicroseconds => As(ElectricPotentialChangeRateUnit.KilovoltPerMicrosecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialChangeRateUnit.KilovoltPerMinute"/>
        /// </summary>
        public double KilovoltsPerMinutes => As(ElectricPotentialChangeRateUnit.KilovoltPerMinute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialChangeRateUnit.KilovoltPerSecond"/>
        /// </summary>
        public double KilovoltsPerSeconds => As(ElectricPotentialChangeRateUnit.KilovoltPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialChangeRateUnit.MegavoltPerHour"/>
        /// </summary>
        public double MegavoltsPerHours => As(ElectricPotentialChangeRateUnit.MegavoltPerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialChangeRateUnit.MegavoltPerMicrosecond"/>
        /// </summary>
        public double MegavoltsPerMicroseconds => As(ElectricPotentialChangeRateUnit.MegavoltPerMicrosecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialChangeRateUnit.MegavoltPerMinute"/>
        /// </summary>
        public double MegavoltsPerMinutes => As(ElectricPotentialChangeRateUnit.MegavoltPerMinute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialChangeRateUnit.MegavoltPerSecond"/>
        /// </summary>
        public double MegavoltsPerSeconds => As(ElectricPotentialChangeRateUnit.MegavoltPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialChangeRateUnit.MicrovoltPerHour"/>
        /// </summary>
        public double MicrovoltsPerHours => As(ElectricPotentialChangeRateUnit.MicrovoltPerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialChangeRateUnit.MicrovoltPerMicrosecond"/>
        /// </summary>
        public double MicrovoltsPerMicroseconds => As(ElectricPotentialChangeRateUnit.MicrovoltPerMicrosecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialChangeRateUnit.MicrovoltPerMinute"/>
        /// </summary>
        public double MicrovoltsPerMinutes => As(ElectricPotentialChangeRateUnit.MicrovoltPerMinute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialChangeRateUnit.MicrovoltPerSecond"/>
        /// </summary>
        public double MicrovoltsPerSeconds => As(ElectricPotentialChangeRateUnit.MicrovoltPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialChangeRateUnit.MillivoltPerHour"/>
        /// </summary>
        public double MillivoltsPerHours => As(ElectricPotentialChangeRateUnit.MillivoltPerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialChangeRateUnit.MillivoltPerMicrosecond"/>
        /// </summary>
        public double MillivoltsPerMicroseconds => As(ElectricPotentialChangeRateUnit.MillivoltPerMicrosecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialChangeRateUnit.MillivoltPerMinute"/>
        /// </summary>
        public double MillivoltsPerMinutes => As(ElectricPotentialChangeRateUnit.MillivoltPerMinute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialChangeRateUnit.MillivoltPerSecond"/>
        /// </summary>
        public double MillivoltsPerSeconds => As(ElectricPotentialChangeRateUnit.MillivoltPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialChangeRateUnit.VoltPerHour"/>
        /// </summary>
        public double VoltsPerHours => As(ElectricPotentialChangeRateUnit.VoltPerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialChangeRateUnit.VoltPerMicrosecond"/>
        /// </summary>
        public double VoltsPerMicroseconds => As(ElectricPotentialChangeRateUnit.VoltPerMicrosecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialChangeRateUnit.VoltPerMinute"/>
        /// </summary>
        public double VoltsPerMinutes => As(ElectricPotentialChangeRateUnit.VoltPerMinute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialChangeRateUnit.VoltPerSecond"/>
        /// </summary>
        public double VoltsPerSeconds => As(ElectricPotentialChangeRateUnit.VoltPerSecond);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="ElectricPotentialChangeRate"/> from <see cref="ElectricPotentialChangeRateUnit.KilovoltPerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromKilovoltsPerHours(double kilovoltsperhours) => new ElectricPotentialChangeRate(kilovoltsperhours, ElectricPotentialChangeRateUnit.KilovoltPerHour);

        /// <summary>
        ///     Creates a <see cref="ElectricPotentialChangeRate"/> from <see cref="ElectricPotentialChangeRateUnit.KilovoltPerMicrosecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromKilovoltsPerMicroseconds(double kilovoltspermicroseconds) => new ElectricPotentialChangeRate(kilovoltspermicroseconds, ElectricPotentialChangeRateUnit.KilovoltPerMicrosecond);

        /// <summary>
        ///     Creates a <see cref="ElectricPotentialChangeRate"/> from <see cref="ElectricPotentialChangeRateUnit.KilovoltPerMinute"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromKilovoltsPerMinutes(double kilovoltsperminutes) => new ElectricPotentialChangeRate(kilovoltsperminutes, ElectricPotentialChangeRateUnit.KilovoltPerMinute);

        /// <summary>
        ///     Creates a <see cref="ElectricPotentialChangeRate"/> from <see cref="ElectricPotentialChangeRateUnit.KilovoltPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromKilovoltsPerSeconds(double kilovoltsperseconds) => new ElectricPotentialChangeRate(kilovoltsperseconds, ElectricPotentialChangeRateUnit.KilovoltPerSecond);

        /// <summary>
        ///     Creates a <see cref="ElectricPotentialChangeRate"/> from <see cref="ElectricPotentialChangeRateUnit.MegavoltPerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromMegavoltsPerHours(double megavoltsperhours) => new ElectricPotentialChangeRate(megavoltsperhours, ElectricPotentialChangeRateUnit.MegavoltPerHour);

        /// <summary>
        ///     Creates a <see cref="ElectricPotentialChangeRate"/> from <see cref="ElectricPotentialChangeRateUnit.MegavoltPerMicrosecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromMegavoltsPerMicroseconds(double megavoltspermicroseconds) => new ElectricPotentialChangeRate(megavoltspermicroseconds, ElectricPotentialChangeRateUnit.MegavoltPerMicrosecond);

        /// <summary>
        ///     Creates a <see cref="ElectricPotentialChangeRate"/> from <see cref="ElectricPotentialChangeRateUnit.MegavoltPerMinute"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromMegavoltsPerMinutes(double megavoltsperminutes) => new ElectricPotentialChangeRate(megavoltsperminutes, ElectricPotentialChangeRateUnit.MegavoltPerMinute);

        /// <summary>
        ///     Creates a <see cref="ElectricPotentialChangeRate"/> from <see cref="ElectricPotentialChangeRateUnit.MegavoltPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromMegavoltsPerSeconds(double megavoltsperseconds) => new ElectricPotentialChangeRate(megavoltsperseconds, ElectricPotentialChangeRateUnit.MegavoltPerSecond);

        /// <summary>
        ///     Creates a <see cref="ElectricPotentialChangeRate"/> from <see cref="ElectricPotentialChangeRateUnit.MicrovoltPerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromMicrovoltsPerHours(double microvoltsperhours) => new ElectricPotentialChangeRate(microvoltsperhours, ElectricPotentialChangeRateUnit.MicrovoltPerHour);

        /// <summary>
        ///     Creates a <see cref="ElectricPotentialChangeRate"/> from <see cref="ElectricPotentialChangeRateUnit.MicrovoltPerMicrosecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromMicrovoltsPerMicroseconds(double microvoltspermicroseconds) => new ElectricPotentialChangeRate(microvoltspermicroseconds, ElectricPotentialChangeRateUnit.MicrovoltPerMicrosecond);

        /// <summary>
        ///     Creates a <see cref="ElectricPotentialChangeRate"/> from <see cref="ElectricPotentialChangeRateUnit.MicrovoltPerMinute"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromMicrovoltsPerMinutes(double microvoltsperminutes) => new ElectricPotentialChangeRate(microvoltsperminutes, ElectricPotentialChangeRateUnit.MicrovoltPerMinute);

        /// <summary>
        ///     Creates a <see cref="ElectricPotentialChangeRate"/> from <see cref="ElectricPotentialChangeRateUnit.MicrovoltPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromMicrovoltsPerSeconds(double microvoltsperseconds) => new ElectricPotentialChangeRate(microvoltsperseconds, ElectricPotentialChangeRateUnit.MicrovoltPerSecond);

        /// <summary>
        ///     Creates a <see cref="ElectricPotentialChangeRate"/> from <see cref="ElectricPotentialChangeRateUnit.MillivoltPerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromMillivoltsPerHours(double millivoltsperhours) => new ElectricPotentialChangeRate(millivoltsperhours, ElectricPotentialChangeRateUnit.MillivoltPerHour);

        /// <summary>
        ///     Creates a <see cref="ElectricPotentialChangeRate"/> from <see cref="ElectricPotentialChangeRateUnit.MillivoltPerMicrosecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromMillivoltsPerMicroseconds(double millivoltspermicroseconds) => new ElectricPotentialChangeRate(millivoltspermicroseconds, ElectricPotentialChangeRateUnit.MillivoltPerMicrosecond);

        /// <summary>
        ///     Creates a <see cref="ElectricPotentialChangeRate"/> from <see cref="ElectricPotentialChangeRateUnit.MillivoltPerMinute"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromMillivoltsPerMinutes(double millivoltsperminutes) => new ElectricPotentialChangeRate(millivoltsperminutes, ElectricPotentialChangeRateUnit.MillivoltPerMinute);

        /// <summary>
        ///     Creates a <see cref="ElectricPotentialChangeRate"/> from <see cref="ElectricPotentialChangeRateUnit.MillivoltPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromMillivoltsPerSeconds(double millivoltsperseconds) => new ElectricPotentialChangeRate(millivoltsperseconds, ElectricPotentialChangeRateUnit.MillivoltPerSecond);

        /// <summary>
        ///     Creates a <see cref="ElectricPotentialChangeRate"/> from <see cref="ElectricPotentialChangeRateUnit.VoltPerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromVoltsPerHours(double voltsperhours) => new ElectricPotentialChangeRate(voltsperhours, ElectricPotentialChangeRateUnit.VoltPerHour);

        /// <summary>
        ///     Creates a <see cref="ElectricPotentialChangeRate"/> from <see cref="ElectricPotentialChangeRateUnit.VoltPerMicrosecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromVoltsPerMicroseconds(double voltspermicroseconds) => new ElectricPotentialChangeRate(voltspermicroseconds, ElectricPotentialChangeRateUnit.VoltPerMicrosecond);

        /// <summary>
        ///     Creates a <see cref="ElectricPotentialChangeRate"/> from <see cref="ElectricPotentialChangeRateUnit.VoltPerMinute"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromVoltsPerMinutes(double voltsperminutes) => new ElectricPotentialChangeRate(voltsperminutes, ElectricPotentialChangeRateUnit.VoltPerMinute);

        /// <summary>
        ///     Creates a <see cref="ElectricPotentialChangeRate"/> from <see cref="ElectricPotentialChangeRateUnit.VoltPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromVoltsPerSeconds(double voltsperseconds) => new ElectricPotentialChangeRate(voltsperseconds, ElectricPotentialChangeRateUnit.VoltPerSecond);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ElectricPotentialChangeRateUnit" /> to <see cref="ElectricPotentialChangeRate" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ElectricPotentialChangeRate unit value.</returns>
        public static ElectricPotentialChangeRate From(double value, ElectricPotentialChangeRateUnit fromUnit)
        {
            return new ElectricPotentialChangeRate(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(ElectricPotentialChangeRateUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public ElectricPotentialChangeRate ToUnit(ElectricPotentialChangeRateUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new ElectricPotentialChangeRate(convertedValue, unit);
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
                ElectricPotentialChangeRateUnit.KilovoltPerHour => (_value/3600) * 1e3d,
                ElectricPotentialChangeRateUnit.KilovoltPerMicrosecond => (_value*1E6) * 1e3d,
                ElectricPotentialChangeRateUnit.KilovoltPerMinute => (_value/60) * 1e3d,
                ElectricPotentialChangeRateUnit.KilovoltPerSecond => (_value) * 1e3d,
                ElectricPotentialChangeRateUnit.MegavoltPerHour => (_value/3600) * 1e6d,
                ElectricPotentialChangeRateUnit.MegavoltPerMicrosecond => (_value*1E6) * 1e6d,
                ElectricPotentialChangeRateUnit.MegavoltPerMinute => (_value/60) * 1e6d,
                ElectricPotentialChangeRateUnit.MegavoltPerSecond => (_value) * 1e6d,
                ElectricPotentialChangeRateUnit.MicrovoltPerHour => (_value/3600) * 1e-6d,
                ElectricPotentialChangeRateUnit.MicrovoltPerMicrosecond => (_value*1E6) * 1e-6d,
                ElectricPotentialChangeRateUnit.MicrovoltPerMinute => (_value/60) * 1e-6d,
                ElectricPotentialChangeRateUnit.MicrovoltPerSecond => (_value) * 1e-6d,
                ElectricPotentialChangeRateUnit.MillivoltPerHour => (_value/3600) * 1e-3d,
                ElectricPotentialChangeRateUnit.MillivoltPerMicrosecond => (_value*1E6) * 1e-3d,
                ElectricPotentialChangeRateUnit.MillivoltPerMinute => (_value/60) * 1e-3d,
                ElectricPotentialChangeRateUnit.MillivoltPerSecond => (_value) * 1e-3d,
                ElectricPotentialChangeRateUnit.VoltPerHour => _value/3600,
                ElectricPotentialChangeRateUnit.VoltPerMicrosecond => _value*1E6,
                ElectricPotentialChangeRateUnit.VoltPerMinute => _value/60,
                ElectricPotentialChangeRateUnit.VoltPerSecond => _value,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(ElectricPotentialChangeRateUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                ElectricPotentialChangeRateUnit.KilovoltPerHour => (baseUnitValue*3600) / 1e3d,
                ElectricPotentialChangeRateUnit.KilovoltPerMicrosecond => (baseUnitValue/1E6) / 1e3d,
                ElectricPotentialChangeRateUnit.KilovoltPerMinute => (baseUnitValue*60) / 1e3d,
                ElectricPotentialChangeRateUnit.KilovoltPerSecond => (baseUnitValue) / 1e3d,
                ElectricPotentialChangeRateUnit.MegavoltPerHour => (baseUnitValue*3600) / 1e6d,
                ElectricPotentialChangeRateUnit.MegavoltPerMicrosecond => (baseUnitValue/1E6) / 1e6d,
                ElectricPotentialChangeRateUnit.MegavoltPerMinute => (baseUnitValue*60) / 1e6d,
                ElectricPotentialChangeRateUnit.MegavoltPerSecond => (baseUnitValue) / 1e6d,
                ElectricPotentialChangeRateUnit.MicrovoltPerHour => (baseUnitValue*3600) / 1e-6d,
                ElectricPotentialChangeRateUnit.MicrovoltPerMicrosecond => (baseUnitValue/1E6) / 1e-6d,
                ElectricPotentialChangeRateUnit.MicrovoltPerMinute => (baseUnitValue*60) / 1e-6d,
                ElectricPotentialChangeRateUnit.MicrovoltPerSecond => (baseUnitValue) / 1e-6d,
                ElectricPotentialChangeRateUnit.MillivoltPerHour => (baseUnitValue*3600) / 1e-3d,
                ElectricPotentialChangeRateUnit.MillivoltPerMicrosecond => (baseUnitValue/1E6) / 1e-3d,
                ElectricPotentialChangeRateUnit.MillivoltPerMinute => (baseUnitValue*60) / 1e-3d,
                ElectricPotentialChangeRateUnit.MillivoltPerSecond => (baseUnitValue) / 1e-3d,
                ElectricPotentialChangeRateUnit.VoltPerHour => baseUnitValue*3600,
                ElectricPotentialChangeRateUnit.VoltPerMicrosecond => baseUnitValue/1E6,
                ElectricPotentialChangeRateUnit.VoltPerMinute => baseUnitValue*60,
                ElectricPotentialChangeRateUnit.VoltPerSecond => baseUnitValue,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion

    }
}

