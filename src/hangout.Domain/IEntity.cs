﻿using System;
using System.ComponentModel.DataAnnotations;

namespace hangout.Domain
{
    public interface IEntity
    {
        [Key]
        Guid Id { get; }
    }
}