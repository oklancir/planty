﻿namespace Planty.Data.Interfaces
{
    using System;

    public interface IEntity
    {
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
