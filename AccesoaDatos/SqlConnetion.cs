using System;

namespace AccesoaDatos
{
    internal class SqlConnetion
    {
        private string v;

        public SqlConnetion(string v)
        {
            this.v = v;
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }
    }
}