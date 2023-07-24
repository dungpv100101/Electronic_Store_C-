using Eletronic.DTO.Response;
using Eletronic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Eletronic.Client
{
    public class ProductTypeClient : BaseClient
    {
        public readonly string PRODUCT_TYPE_URL = "https://localhost:7246/v1/api/ProductType/";

        public List<ProductType> GetListProductType()
        {
            string apiUrl = PRODUCT_TYPE_URL + "List";

            BaseResponse baseResponse = Get(apiUrl);

            List<ProductType> productTypes = baseResponse.GetData<List<ProductType>>();

            return productTypes;
        }

        public bool Add(ProductType productType)
        {
            string apiUrl = PRODUCT_TYPE_URL + "Add";

            BaseResponse baseResponse = Post(apiUrl, productType);

            return baseResponse != null;
        }
    }
}
