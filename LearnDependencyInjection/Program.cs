using Chapter01Library;
using Microsoft.Extensions.Configuration;
using System.Security.Principal;


//IMessageWriter writer = new ConsoleMessageWriter();
/*
 * Enable late binding
 * 
 * Late binding an IMessageWriter implementation
 */

IConfigurationRoot configuration = new ConfigurationBuilder()
    // to be able to use the SetBasePath(Directory.GetCurrentDirectory())
    // an appsettings.json copy must be place in bin/Debug/net6.0
    //.SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

string typeName = configuration["messageWriter"];
Type type = Type.GetType(typeName, throwOnError: true);

IMessageWriter writer = new SecureMessageWriter(new ConsoleMessageWriter(), WindowsIdentity.GetCurrent());

/*
 * *********************************************
 */


var salutation = new Salutation(writer);
salutation.Exclaim();