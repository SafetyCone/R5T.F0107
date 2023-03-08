using System;

using R5T.T0131;


namespace R5T.F0107
{
    [ValuesMarker]
    public partial interface ICharacters : IValuesMarker,
        Z0000.ICharacters
    {
        /// <summary>
        /// <inheritdoc cref="Z0000.ICharacters.Space" path="/name"/>,
        /// <inheritdoc cref="Z0000.ICharacters.OpenParenthesis" path="/value"/>,
        /// <inheritdoc cref="Z0000.ICharacters.CloseParenthesis" path="/value"/>
        /// </summary>
        private static Lazy<char[]> NameTrimCharacters_Internal { get; } = new Lazy<char[]>(() => new[]
        {
            Z0000.Characters.Instance.Space,
            Z0000.Characters.Instance.OpenParenthesis,
            Z0000.Characters.Instance.CloseParenthesis,
        });


        public char[] NameTrimCharacters => ICharacters.NameTrimCharacters_Internal.Value;
    }
}
