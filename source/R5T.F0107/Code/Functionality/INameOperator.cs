using System;
using System.Linq;

using R5T.T0132;
using R5T.T0164;
using R5T.T0164.Extensions;


namespace R5T.F0107
{
    [FunctionalityMarker]
    public partial interface INameOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="Get_LastName(string)"/>
        public LastName Get_LastName(FullName fullName)
        {
            var output = this.Get_LastName_WithTrimming(fullName);
            return output;
        }

        /// <inheritdoc cref="Get_LastName_WithTrimming(string)"/>
        public LastName Get_LastName_WithTrimming(FullName fullName)
        {
            var nameTokens = this.Split(fullName.Value);

            var lastNameToken = nameTokens.Last();

            var trimmed = Instances.StringOperator.Trim(
                lastNameToken,
                Instances.Characters.NameTrimCharacters);

            return trimmed.ToLastName();
        }

        /// <summary>
        /// Selects <see cref="Get_LastName_WithTrimming(FullName)"/> as the default.
        /// </summary>
        public LastName Get_LastName(string fullName)
        {
            var output = this.Get_LastName_WithTrimming(fullName);
            return output;
        }

        /// <summary>
        /// Gets the final name of the full name, and then trims any excess characters from the name.
        /// Trimmed characters include:
        /// <inheritdoc cref="ICharacters.NameTrimCharacters_Internal" path="/summary"/>
        /// </summary>
        public LastName Get_LastName_WithTrimming(string fullName)
        {
            var nameTokens = this.Split(fullName);

            var lastNameToken = nameTokens.Last();

            var trimmed = Instances.StringOperator.Trim(
                lastNameToken,
                Instances.Characters.NameTrimCharacters);

            return trimmed.ToLastName();
        }

        public string[] Split(string fullName)
        {
            var output = Instances.StringOperator.Split(
                Instances.Characters.Space,
                fullName,
                StringSplitOptions.RemoveEmptyEntries);

            return output;
        }
    }
}
