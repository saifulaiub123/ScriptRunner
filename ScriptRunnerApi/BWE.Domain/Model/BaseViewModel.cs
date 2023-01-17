﻿using BWE.Domain.IEntity;

namespace BWE.Domain.Model
{
    public class BaseViewModel<TId> : IBaseEntity<TId>
    {
        public TId? Id { get; set; }
    }
}
