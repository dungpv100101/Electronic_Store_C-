using BusinessObject.DTO.Response;
using Eletronic.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Net.WebRequestMethods;

namespace Eletronic.Client
{
    public class ProductClient : BaseClient
    {
        public readonly string PRODUCT_URL = "https://localhost:7246/v1/api/Product/";

        public async Task<List<Product>> GetListProduct(int pageNumber = 1, int pageSize = 3, string productName = "", int categoryID = 0)
        {
            string apiUrl = PRODUCT_URL + "List" + $"?pageNumber={pageNumber}&pageSize={pageSize}&productName={productName}&categoryID={categoryID}";

            BaseResponse baseResponse = Get(apiUrl);

            List<Product> products = baseResponse.GetData<List<Product>>();

            return products;
        }

        public void AddProduct(Product product)
        {
            if (product == null) { MessageBox.Show("Error Common"); return; }

            string apiUrl = PRODUCT_URL + "Add";

            BaseResponse baseResponse = Post(apiUrl, product);

            MessageBox.Show("");
        }
    }
}
