using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace Aws.SimpleLambda
{
    public class Function
    {
      
        public void FunctionHandler(ILambdaContext context)
        {
            context.Logger.LogInformation("Hello C#, it's working !!");
        }
    }
}