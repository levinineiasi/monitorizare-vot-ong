﻿using System.Collections.Generic;
using System.Linq;

namespace MonitorizareVot.Ong.Api.Extensions
{
    public static class ListExtensions
    {
        public static List<T> Paginate<T>(this List<T> unPagedList, int page, int pageSize)
        {
            return unPagedList
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }
    }
}
