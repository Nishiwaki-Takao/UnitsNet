﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated (once) by \generate-code.bat, but will not be
//     regenerated when it already exists. The purpose of creating this file is to make
//     it easier to remember to implement all the unit conversion test cases.
//
//     Whenever a new unit is added to this quantity and \generate-code.bat is run,
//     the base test class will get a new abstract property and cause a compile error
//     in this derived class, reminding the developer to implement the test case
//     for the new unit.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class CoefficientOfThermalExpansionTests : CoefficientOfThermalExpansionTestsBase
    {
        protected override bool SupportsSIUnitSystem => true;

        protected override double InverseDegreeCelsiusInOneInverseKelvin => 1.0;

        protected override double InverseDegreeFahrenheitInOneInverseKelvin => 0.5555555555555556;

        protected override double InverseKelvinInOneInverseKelvin => 1.0;

        [Fact]
        public void CoefficientOfThermalExpansionTimesTemperatureDelta()
        {
            double temperatureDeltaDegC = 2.0;
            double ctePerDegC = 0.001;
            CoefficientOfThermalExpansion cte = CoefficientOfThermalExpansion.FromInverseDegreeCelsius(ctePerDegC);
            TemperatureDelta dT = TemperatureDelta.FromDegreesCelsius(temperatureDeltaDegC);
            AssertEx.EqualTolerance(cte * dT, ctePerDegC * temperatureDeltaDegC, 1e-10);
        }

        [Fact]
        public void TemperatureDeltaTimesCoefficientOfThermalExpansion()
        {
            double temperatureDeltaDegC = 2.0;
            double ctePerDegC = 0.001;
            CoefficientOfThermalExpansion cte = CoefficientOfThermalExpansion.FromInverseDegreeCelsius(ctePerDegC);
            TemperatureDelta dT = TemperatureDelta.FromDegreesCelsius(temperatureDeltaDegC);
            AssertEx.EqualTolerance(dT * cte, temperatureDeltaDegC * ctePerDegC, 1e-10);
        }
    }
}
