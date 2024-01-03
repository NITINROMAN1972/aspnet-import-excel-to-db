# aspnet-import-excel-to-db
importing the uploaded excel file into the database records using ASP.NET C# and MS SQL Server

 ### `EPPlus Library`
To install EPPlus via the NuGet Package Manager Console, you can use the following command:`Install-Package EPPlus`

### `EPPlus Library`
EPPlus requires a license for certain types of usage. You can obtain a license from the EPPlus website:  https://epplussoftware.com/developers/licenseexception

Please note that EPPlus is generally free to use, but they do require a license for some commercial applications and certain types of usage.  
If your usage falls under the categories that require a license, you should obtain one from the provided link.

If you are using EPPlus for non-commercial purposes or your usage falls within their free usage terms, you might need to set the license context as mentioned in the exception.  

You can set the license context in your code like this:
`ExcelPackage.LicenseContext = LicenseContext.NonCommercial;` in code behind
