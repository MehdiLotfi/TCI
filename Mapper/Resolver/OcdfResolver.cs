﻿using System.Collections.Generic;
using System.Linq;
using AutoMapper;

namespace TCI.Mapper.Resolver
{
    public class OcdfResolver : ValueResolver<Domain.Ocdf, List<Model.Cable>>
    {
        protected override List<Model.Cable> ResolveCore(Domain.Ocdf source)
        {
            if (source == null) return null;
            var result = AutoMapper.Mapper.Map<List<Model.Cable>>(source.FromCables.ToList());
            result.AddRange(AutoMapper.Mapper.Map<List<Model.Cable>>(source.ToCables.ToList()));
            return result;
        }
    }
}
