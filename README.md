# BlazorApp8 Documentation

## Introduction

BlazorApp8 is an example project demonstrating how to create a Blazor Web App using .NET 8. This documentation provides a step-by-step guide to setting up and developing a Blazor Web App, including CRUD operations, database migrations, pagination, search functionality, and user authentication.

## Table of Contents

1. [Project Setup](#project-setup)
2. [Model Class](#model-class)
3. [CRUD Operations](#crud-operations)
4. [Database Migration](#database-migration)
5. [Pagination](#pagination)
6. [Search Functionality](#search-functionality)
7. [User Authentication](#user-authentication)

## 1. Project Setup

To start, create a new Blazor Web App project in Visual Studio.

## 2. Model Class

Add a model class to the project. In this example, we will use a `Vehicle` class.

## 3. CRUD Operations

Add components to manage CRUD operations for the model.

![CRUD Components](https://github.com/ale77x/BlazorApp8/raw/master/Docs/Screenshot_1.png)

### Razor Component for CRUD Operations

Select a new Razor component to implement CRUD operations.

![Select Razor Component](https://github.com/ale77x/BlazorApp8/raw/master/Docs/Screenshot_2.png)

Configure the options for the CRUD component:

![CRUD Options](https://github.com/ale77x/BlazorApp8/raw/master/Docs/Screenshot_3.png)

Now, you will find pages among the project's Pages folder that can manage operations on the model, including an Index page containing a QuickGrid component.

![Index Page](https://github.com/ale77x/BlazorApp8/raw/master/Docs/Screenshot_4.png)

## 4. Database Migration

Insert a migration operation to generate a database that reflects the structure of the model classes.

![Database Migration](https://github.com/ale77x/BlazorApp8/raw/master/Docs/Screenshot_5.png)

Name the migration and select the DBContext.

![DBContext Selection](https://github.com/ale77x/BlazorApp8/raw/master/Docs/Screenshot_6.png)

Once done, select "Update Database."

## 5. Pagination

To add pagination to the Index page, insert the following code:

```razor
<Paginator State="pagState" />
```

And the code for pagination:

```csharp
PaginationState pagState = new PaginationState() { ItemsPerPage = 1 };
```

Setting `pagState` in both places coordinates pagination between the QuickGrid component and the Paginator component.

## 6. Search Functionality

Add a search field by modifying the column header of the field you want to make searchable. Add an input field of type search, bound to a string variable, and indicate that it should filter with each user input via `bind:event="oninput"`.

```razor
<PropertyColumn Property="vehicle => vehicle.Model" Sortable="true">
    <ColumnOptions>
        <input type="search" autofocus @bind="modelFilter" @bind:event="oninput" />
    </ColumnOptions>
</PropertyColumn>

...

string modelFilter = string.Empty;
```

## 7. User Authentication

Create a scaffolding element by selecting Identity.

![Identity Scaffolding](https://github.com/ale77x/BlazorApp8/raw/master/Docs/Screenshot_10.png)

Add login and registration pages to the application.

![Login and Registration](https://github.com/ale77x/BlazorApp8/raw/master/Docs/Screenshot_10.png)

To enable access to pages only for authenticated users, modify (or add) the `_Imports.razor` file in the folder containing the pages to be protected, adding the following directive:

```razor
@using Microsoft.AspNetCore.Authorization
@attribute [Authorize]
```

 
