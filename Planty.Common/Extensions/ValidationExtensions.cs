namespace Planty.Common.Extensions
{
    using System;

    public static class ValidationExtensions
    {
        public static void ValidateIsNotNull<TEntity>(this TEntity entity, string name)
            where TEntity : class
        {
            if (entity == null)
            {
                throw new ArgumentNullException(name);
            }
        }
    }
}
