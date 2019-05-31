# UIPath.AppIntegrations.WolframLanguage

A set of custom UIPath activities to allow integration between RPA workflows and the Wolfram Language Engine using .NET/Link.

For example, when ![this workflow](https://github.com/JosephIaquinto/UIPath.AppIntegrations.WolframLanguage/blob/master/Examples/ShuttleFlow.png) is provided the expression ```ExampleData[{"Geometry3D", "SpaceShuttle"}]```, the image below will be produced.

![ShuttleExport.jpg](https://github.com/JosephIaquinto/UIPath.AppIntegrations.WolframLanguage/blob/master/Examples/ShuttleExport.jpg)

## Activities

### Wolfram Language Scope

Opens a wolfram engine kernel (MathKernel.exe). Requires path, optionally an argv style string array of arguments to open the kernel with.

### Evaluate <T>

Evaluates a string as a Wolfram Language expression in the parent scope's kernel.

### Evaluate To Image

### Evaluate To Input Form

### Evaluate To Output Form

See the Wolfram Language and .NET/Link documentation for more information. You need an installed copy of the Wolfram Engine on the machine where the robot will be running. Future work may include connection to a remote wolfram engine kernel.

NOTICE: I do not own the Wolfram Engine or any part therof. This was developed using the [Free Wolfram Engine™ for Developers](https://www.wolfram.com/legal/terms/wolfram-engine.html). You may not use this in production or for commercial use without purchasing a production wolfram engine license from the Wolfram Foundation.
