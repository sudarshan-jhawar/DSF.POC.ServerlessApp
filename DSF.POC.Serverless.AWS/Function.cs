using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using DSF.POC.Serverless.Library;
using DSF.POC.Serverless.Library.Entities;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace DSF.POC.Serverless.AWS;

public class Function
{
    
    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public List<Product> FunctionHandler(APIGatewayProxyRequest request, ILambdaContext context)
    {
        var repo = new ProductRepository();
        var prods = repo.GetProductsAsync().Result;
        return prods;
    }
}
