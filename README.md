# Hello, EventBridge!

This is the code project for the [Hello, EventBridge!](https://davidpallmann.hashnode.dev/hello-eventbridge) blog post. 

This episode: Amazon EventBridge and event-based processing. In this Hello, Cloud blog series, we're covering the basics of AWS cloud services for newcomers who are .NET developers. If you love C# but are new to AWS, or to this particular service, this should give you a jumpstart.

In this post we'll introduce Amazon EventBridge and use it in a "Hello, Cloud" .NET program to connect software components using events. We'll do this step-by-step, making no assumptions other than familiarity with C# and Visual Studio. We're using Visual Studio 2022 and .NET 6.

## Our Hello, EventBridge Project

We will write a .NET producer program and a .NET consumer program, and connect them with EventBridge. We will also add CloudWatch Logs as another consumer. Each message sent by the producer will arrive at both consumers.

See the blog post for the tutorial to create this project and run it on AWS.

