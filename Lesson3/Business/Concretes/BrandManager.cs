using Business.Abtracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abtracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public CreatedBrandResponse TAdd(CreatedBrandRequest createdBrandRequest)
        {
            Brand brand = new Brand();
            brand.Name = createdBrandRequest.Name;
            brand.CreatedDate = DateTime.Now;

            _brandDal.Add(brand);

            CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse();
            createdBrandResponse.Name = createdBrandRequest.Name;
            createdBrandResponse.Id = 4;
            createdBrandResponse.CreatedDate = DateTime.Now;

            return createdBrandResponse;
        }

        public List<GetAllBrandResponse> TGetAll()
        {
            List<Brand> brands = _brandDal.GetAll();

            List<GetAllBrandResponse> getAllBrandResponses = new List<GetAllBrandResponse>();
            foreach (var brand in brands)
            {
                GetAllBrandResponse getAllBrandResponse = new GetAllBrandResponse();
                getAllBrandResponse.Name = brand.Name;
                getAllBrandResponse.Id = brand.Id;
                getAllBrandResponse.CreatedDate = brand.CreatedDate;

                getAllBrandResponses.Add(getAllBrandResponse);
            }
            return getAllBrandResponses;
        }
    }
}
