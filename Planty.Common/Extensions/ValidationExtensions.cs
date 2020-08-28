namespace Planty.Common.Extensions
{
    using System;
    using Planty.Common.Exceptions;

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

        public static void RejectEntityNotFound<TEntity>(this TEntity entity, string name)
            where TEntity : class
        {
            if (entity == null)
            {
                throw new NotFoundException(name);
            }
        }
    }
}
