# WebAPIEntityFrameworkCore.Jet
Web API EntityFrameworkCore.Jet example
- make project platform 86x or 64x not any
- Install-Package Microsoft.EntityFrameworkCore -Version 3.1.15 ((Version 3.1.15 must be selected and no higher version can be selected))
- Install-Package EntityFrameworkCore.Jet 
- Install-Package System.Data.OleDb 


Test host api in  myASP.NET

Controlpanel>Files

Select Data folder then click File permission then select Read/Write then press update

To do the data migration
1- make sure that you installed both :
  - Install-Package Microsoft.EntityFrameworkCore.relational -Version 3.1.15 ((Version 3.1.15 must be selected and no higher version can be selected))
  - Install-Package Microsoft.EntityFrameworkCore.design -Version 3.1.15 ((Version 3.1.15 must be selected and no higher version can be selected))
  - Install-Package Microsoft.EntityFrameworkCore.tools -Version 3.1.15 ((Version 3.1.15 must be selected and no higher version can be selected))
2- Make sure all models have 
  - using System.ComponentModel.DataAnnotations;
3- switch the platform to 64x.
4- Install (AccessDatabaseEngine_X64.exe) . Most to command "Update-Database"
  if your office 32bit see "Installing the Microsoft.ACE.OLEDB.12.0 Provider for Both 64-bit and 32-bit Processing"
  In https://datasavvy.me/2017/07/20/installing-the-microsoft-ace-oledb-12-0-provider-for-both-64-bit-and-32-bit-processing/


then open PMC (Package Manager Console) (Tools->"NuGet package Manager"->Package Manager Console)
write 
>Add-Migration InitialCreate
then 
>Update-Database
