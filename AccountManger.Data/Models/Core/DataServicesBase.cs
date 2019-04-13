using Microsoft.EntityFrameworkCore;
using System;
using AutoMapper;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace AccountManger.Data.Models.Core
{
    public abstract class DataServicesBase<TEntity,TContet>
        where TEntity:class
        where TContet: DbContext

    {
        protected TContet Context { get; set; }
        protected IMapper Mapper { get; set; }

        public DataServicesBase(IMapper mapper, TContet contet)
        {
            Context = contet;
            Mapper = mapper;

        }
        

        public IQueryable<TDto> GeTall<TDto>()
        {
            DbSet<TEntity> table = Context.Set<TEntity>();
            return Mapper.ProjectTo<TDto>(table);
        }


        public IQueryable<TDto> GeTall<TDto>(Expression<Func<TEntity,bool>> Filter)
        {
            DbSet<TEntity> table = Context.Set<TEntity>();
            return Mapper.ProjectTo<TDto>(table.Where(Filter));
        }



    }
}
