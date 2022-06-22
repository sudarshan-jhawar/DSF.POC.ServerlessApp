using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using DSF.POC.Serverless.Library;

namespace DSF.POC.Serverless.Azure
{
    public static class ProductTrigger
    {
        [FunctionName("GetProducts")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            var productRepository = new ProductRepository();
            var products = await productRepository.GetProductsAsync();
            log.LogInformation($"Total products : {products.Count}");
            return new OkObjectResult(products);
        }
    }
}
