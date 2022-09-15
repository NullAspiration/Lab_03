//invalid parameter for SSN
//Source: https://secure.ssa.gov/poms.nsf/lnx/0110201035

namespace Lab_03
{
    public class SSN
    {
        public string Number { get; init; }

        public SSN()
        {
            Number = DummySSN();
        }

        public string DummySSN()
        {
            string regulatedInvalidSSN = string.Empty;
            Random random = new Random();


            var nineHunderedSeries = random.Next(900, 1000).ToString();
            var DigitsArray = new string[] { "000", "666", nineHunderedSeries };

            var firstDigits = DigitsArray[random.Next(3)];
            var secondDigits = "00";
            var thirdDigits = "0000";

            regulatedInvalidSSN = string.Concat(firstDigits, secondDigits, thirdDigits);
            return regulatedInvalidSSN;

        }

        public override string ToString()
        {
            string safeSocialSecurityNumber = Number;
            safeSocialSecurityNumber = safeSocialSecurityNumber.Insert(3, "-");
            safeSocialSecurityNumber = safeSocialSecurityNumber.Insert(6, "-");
            return safeSocialSecurityNumber;
        }
    }

}
