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
    ///     The number of occurrences of a repeating event per unit time.
    /// </summary>
    public struct  Frequency
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly FrequencyUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public FrequencyUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public Frequency(double value, FrequencyUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static FrequencyUnit BaseUnit { get; } = FrequencyUnit.Hertz;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static Frequency MaxValue { get; } = new Frequency(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static Frequency MinValue { get; } = new Frequency(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Frequency Zero { get; } = new Frequency(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="FrequencyUnit.BeatPerMinute"/>
        /// </summary>
        public double BeatsPerMinute => As(FrequencyUnit.BeatPerMinute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="FrequencyUnit.BUnit"/>
        /// </summary>
        public double BUnits => As(FrequencyUnit.BUnit);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="FrequencyUnit.CyclePerHour"/>
        /// </summary>
        public double CyclesPerHour => As(FrequencyUnit.CyclePerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="FrequencyUnit.CyclePerMinute"/>
        /// </summary>
        public double CyclesPerMinute => As(FrequencyUnit.CyclePerMinute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="FrequencyUnit.Gigahertz"/>
        /// </summary>
        public double Gigahertz => As(FrequencyUnit.Gigahertz);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="FrequencyUnit.Hertz"/>
        /// </summary>
        public double Hertz => As(FrequencyUnit.Hertz);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="FrequencyUnit.Kilohertz"/>
        /// </summary>
        public double Kilohertz => As(FrequencyUnit.Kilohertz);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="FrequencyUnit.Megahertz"/>
        /// </summary>
        public double Megahertz => As(FrequencyUnit.Megahertz);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="FrequencyUnit.PerSecond"/>
        /// </summary>
        public double PerSecond => As(FrequencyUnit.PerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="FrequencyUnit.RadianPerSecond"/>
        /// </summary>
        public double RadiansPerSecond => As(FrequencyUnit.RadianPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="FrequencyUnit.Terahertz"/>
        /// </summary>
        public double Terahertz => As(FrequencyUnit.Terahertz);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="Frequency"/> from <see cref="FrequencyUnit.BeatPerMinute"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromBeatsPerMinute(double beatsperminute) => new Frequency(beatsperminute, FrequencyUnit.BeatPerMinute);

        /// <summary>
        ///     Creates a <see cref="Frequency"/> from <see cref="FrequencyUnit.BUnit"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromBUnits(double bunits) => new Frequency(bunits, FrequencyUnit.BUnit);

        /// <summary>
        ///     Creates a <see cref="Frequency"/> from <see cref="FrequencyUnit.CyclePerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromCyclesPerHour(double cyclesperhour) => new Frequency(cyclesperhour, FrequencyUnit.CyclePerHour);

        /// <summary>
        ///     Creates a <see cref="Frequency"/> from <see cref="FrequencyUnit.CyclePerMinute"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromCyclesPerMinute(double cyclesperminute) => new Frequency(cyclesperminute, FrequencyUnit.CyclePerMinute);

        /// <summary>
        ///     Creates a <see cref="Frequency"/> from <see cref="FrequencyUnit.Gigahertz"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromGigahertz(double gigahertz) => new Frequency(gigahertz, FrequencyUnit.Gigahertz);

        /// <summary>
        ///     Creates a <see cref="Frequency"/> from <see cref="FrequencyUnit.Hertz"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromHertz(double hertz) => new Frequency(hertz, FrequencyUnit.Hertz);

        /// <summary>
        ///     Creates a <see cref="Frequency"/> from <see cref="FrequencyUnit.Kilohertz"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromKilohertz(double kilohertz) => new Frequency(kilohertz, FrequencyUnit.Kilohertz);

        /// <summary>
        ///     Creates a <see cref="Frequency"/> from <see cref="FrequencyUnit.Megahertz"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromMegahertz(double megahertz) => new Frequency(megahertz, FrequencyUnit.Megahertz);

        /// <summary>
        ///     Creates a <see cref="Frequency"/> from <see cref="FrequencyUnit.PerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromPerSecond(double persecond) => new Frequency(persecond, FrequencyUnit.PerSecond);

        /// <summary>
        ///     Creates a <see cref="Frequency"/> from <see cref="FrequencyUnit.RadianPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromRadiansPerSecond(double radianspersecond) => new Frequency(radianspersecond, FrequencyUnit.RadianPerSecond);

        /// <summary>
        ///     Creates a <see cref="Frequency"/> from <see cref="FrequencyUnit.Terahertz"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromTerahertz(double terahertz) => new Frequency(terahertz, FrequencyUnit.Terahertz);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="FrequencyUnit" /> to <see cref="Frequency" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Frequency unit value.</returns>
        public static Frequency From(double value, FrequencyUnit fromUnit)
        {
            return new Frequency(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(FrequencyUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public Frequency ToUnit(FrequencyUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new Frequency(convertedValue, unit);
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
                FrequencyUnit.BeatPerMinute => _value/60,
                FrequencyUnit.BUnit => Math.Sqrt(_value * 1e3),
                FrequencyUnit.CyclePerHour => _value/3600,
                FrequencyUnit.CyclePerMinute => _value/60,
                FrequencyUnit.Gigahertz => (_value) * 1e9d,
                FrequencyUnit.Hertz => _value,
                FrequencyUnit.Kilohertz => (_value) * 1e3d,
                FrequencyUnit.Megahertz => (_value) * 1e6d,
                FrequencyUnit.PerSecond => _value,
                FrequencyUnit.RadianPerSecond => _value/6.2831853072,
                FrequencyUnit.Terahertz => (_value) * 1e12d,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(FrequencyUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                FrequencyUnit.BeatPerMinute => baseUnitValue*60,
                FrequencyUnit.BUnit => baseUnitValue * baseUnitValue * 1e-3,
                FrequencyUnit.CyclePerHour => baseUnitValue*3600,
                FrequencyUnit.CyclePerMinute => baseUnitValue*60,
                FrequencyUnit.Gigahertz => (baseUnitValue) / 1e9d,
                FrequencyUnit.Hertz => baseUnitValue,
                FrequencyUnit.Kilohertz => (baseUnitValue) / 1e3d,
                FrequencyUnit.Megahertz => (baseUnitValue) / 1e6d,
                FrequencyUnit.PerSecond => baseUnitValue,
                FrequencyUnit.RadianPerSecond => baseUnitValue*6.2831853072,
                FrequencyUnit.Terahertz => (baseUnitValue) / 1e12d,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion

    }
}

