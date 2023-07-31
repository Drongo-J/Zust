﻿using Zust.Core.Concrete;
using Zust.Entities.Models;

namespace Zust.DataAccess.Abstract
{
    /// <summary>
    /// Represents a data access layer for the Message entity.
    /// </summary>
    public interface IMessageDal : IEntityRepository<Message>
    {
    }
}
