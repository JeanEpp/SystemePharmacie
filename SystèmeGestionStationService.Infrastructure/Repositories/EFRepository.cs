using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using SystèmePharmacie.SharedKernel.Interfaces;
using SystèmePharmacie.SharedKernel;
using SystèmePharmacie.Infrastructure;
using EAISolutionFrontEnd.Infrastructure;

namespace SystèmePharmacie.Infrastructure.Repositories
{
    public class EfRepository<T> : IAsyncRepository<T> where T : BaseEntity, IAggregateRoot
    {
        protected readonly SystèmePharmacieContext _systèmePharmacieContext;

        public EfRepository(SystèmePharmacieContext systèmePharmacieContext)
        {
            _systèmePharmacieContext = systèmePharmacieContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _systèmePharmacieContext.Set<T>().AddAsync(entity);
            await _systèmePharmacieContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _systèmePharmacieContext.Set<T>().Remove(entity);
            await _systèmePharmacieContext.SaveChangesAsync();
        }

        public bool EntityExists(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await
             _systèmePharmacieContext.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _systèmePharmacieContext.Set<T>().ToListAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _systèmePharmacieContext.Entry(entity).State = EntityState.Modified;
            await _systèmePharmacieContext.SaveChangesAsync();
        }
        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(_systèmePharmacieContext.Set<T>().AsQueryable(), spec);
        }

        public async Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).ToListAsync();
        }

        public async Task<int> CountAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).CountAsync();
        }

    }
}
