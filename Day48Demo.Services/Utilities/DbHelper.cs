using System;

namespace Day48Demo.Services.Utilities
{
    public static class DbHelper
    {
        public static T GetData<T>(this object dataField)
        {
            return dataField == DBNull.Value ? default(T): (T)dataField;
        }
    }
}