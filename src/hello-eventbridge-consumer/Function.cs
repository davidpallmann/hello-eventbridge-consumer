using Amazon.Lambda.Core;
using Amazon.Lambda.CloudWatchEvents;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace hello_eventbridge_consumer;

public class Function
{
    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input">Test event</param>
    /// <param name="context">logging context</param>
    /// <returns></returns>
    public void FunctionHandler(CloudWatchEvent<TestEvent> input, ILambdaContext context)
    {
        context.Logger.LogLine($"Lambda consumer received test event Id: {input.Detail.Id}, Message: {input.Detail.Message}, Date: {input.Detail.Date}"); 
    }
}
