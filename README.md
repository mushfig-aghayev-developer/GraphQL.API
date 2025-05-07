📘 GraphQL API Implementation in .NET Core Web API (Hot Chocolate)
🚀 Introduction
GraphQL is a powerful API query language that enables clients to request exactly the data they need. It improves flexibility, reduces over-fetching, and is especially effective for modern applications where REST becomes limiting.

Benefits:
Type-safe queries.

Single endpoint for all operations.

Supports complex nested data.

High control over data requested.

Strong developer tooling support.

🔧 Installation
To get started with GraphQL in ASP.NET Core, install the HotChocolate library:
Install-Package HotChocolate.AspNetCore

⚙️ Configuration in ASP.NET Core
Update your Program.cs file as follows:
builder.Services.AddGraphQLServer()
    .AddQueryType<Query>();

app.MapGraphQL();

This sets up the GraphQL server and maps the endpoint at /graphql. You also need to define your GraphQL schema through a class — commonly called Query.

Operation Types
GraphQL has three main types of operations:

Operation	Description	REST Equivalent
Query	Retrieve data (read)	GET
Mutation	Modify data (create, update, delete)	POST / PUT / DELETE
Subscription	Real-time data updates	No direct REST equivalent

GraphQL has three main types of operations:

Operation        	Description	                                   REST Equivalent
Query           	Retrieve data (read)	                         GET
Mutation	        Modify data (create, update, delete)	         POST / PUT / DELETE
Subscription	    Real-time data updates	                       No direct REST equivalent

🔍 Query Examples
/*===================================================================================================================================================================================*/
 query test {
 personInfo
 }

query FirstQuery($name: String!){
personInfoParams(name: $name)
people{
  id
  name
}
}

 query Secondary{
   people{
     id,
     name
   }
 }
/*===================================================================================================================================================================================*/
