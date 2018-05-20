# Marzhel.PentiaAssignment
C# project for Pentia Assignment

# Setup
The project is currently configured to use Entitry Framework with a Microsoft SQL Server

To set up the database connection:

Add the following to `Web.config`

```xml
<connectionStrings>
  <add connectionString="Data Source=<server>;Initial Catalog=pentia_project;User ID=<username>;Password=<password>" name="DefaultConnection" providerName="System.Data.SqlClient" />
</connectionStrings>
```

Replace `<server>`, `<username>` and `<password>` with appropriate values.
