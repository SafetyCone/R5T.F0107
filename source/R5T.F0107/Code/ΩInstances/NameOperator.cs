using System;


namespace R5T.F0107
{
    public class NameOperator : INameOperator
    {
        #region Infrastructure

        public static INameOperator Instance { get; } = new NameOperator();


        private NameOperator()
        {
        }

        #endregion
    }
}
