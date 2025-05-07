📘 GraphQL API Implementation in .NET Core Web API (Hot Chocolate)
🚀 Introduction
GraphQL is a powerful API query language that enables clients to request exactly the data they need. It improves flexibility, reduces over-fetching, and is especially effective for modern applications where REST becomes limiting.

Benefits:
    Type-safe queries.
    Single endpoint for all operations.
    Supports complex nested data.
    High control over data requested.
    Strong developer tooling support.

🔧 Installation GraphQL in ASP.NET Core, install the HotChocolate library:
   Install-Package HotChocolate.AspNetCore

GraphQL has three main types of operations:
    GraphQL defines three main types of operations:
    Query – equivalent to HTTP GET (used for data retrieval)
    Mutation – equivalent to HTTP POST/PUT/DELETE/PATCH (used for data modification)
    Subscription – has no REST equivalent
