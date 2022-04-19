using System.Collections.Generic;

namespace HSUrlaubsPlaner.GrpcService.Mapping;

    public interface IMappingService<E,D>
            where E : class, new()
            where D : class, new()
    {
        //Mapper AutoMapper { get; }

        D ToDto(E e);

        E ToEntity(D d);

        //List<E> ToEntity(IEnumerable<D> ds);

        //void UpdateValues(in D dto, ref E entity);

    }