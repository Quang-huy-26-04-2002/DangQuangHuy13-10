using CourseSignupSystem.Application.Catalog.Dtos;
using CourseSignupSystem.Application.Catalog.Products.Dtos;
using CourseSignupSystem.Application.Catalog.Products.Dtos.Public;
using CourseSignupSystem.Data.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseSignupSystem.Application.Catalog.Products
{
    public class PublicProductServise : IPublicProductServise
    {
        private readonly CSSDbContext _context;
        public PublicProductServise(CSSDbContext context)
        {
            _context = context;
        }
        public Task<PagedViewModel<ProducViewModel>> GetAllByCategory(GetProductPagingRequest reques)
        {
            throw new NotImplementedException();
        }
    }
}
