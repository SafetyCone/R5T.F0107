using System;


namespace R5T.F0107
{
    public static class Instances
    {
        public static ICharacters Characters => F0107.Characters.Instance;
        public static F0000.IStringOperator StringOperator => F0000.StringOperator.Instance;
    }
}