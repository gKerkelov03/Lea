﻿using System.Collections;

namespace Lea.Services.AutoMapper.Extensions;

public static class EnumerableMappingExtensions
{
    public static IEnumerable<TDestination> To<TDestination>(
        this IEnumerable source)
    {
        if (source == null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        foreach (var src in source)
        {
            yield return AutoMapper.Mapper.Map<TDestination>(src);
        }
    }
}