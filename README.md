# WebAPIEntityFrameworkCore.Jet
Web API EntityFrameworkCore.Jet example
- make project platform 86x or 64x not any
- Install-Package Microsoft.EntityFrameworkCore -Version 3.1.15 ((Version 3.1.15 must be selected and no higher version can be selected))
- Install-Package EntityFrameworkCore.Jet 
- Install-Package System.Data.OleDb 


Test host api in  myASP.NET

Controlpanel>Files

Select Data folder then click File permission then select Read/Write then press update

To do the data migration, make sure that you installed both :
- Install-Package Microsoft.EntityFrameworkCore.relational -Version 3.1.15 ((Version 3.1.15 must be selected and no higher version can be selected))
- Install-Package Microsoft.EntityFrameworkCore.design -Version 3.1.15 ((Version 3.1.15 must be selected and no higher version can be selected))
- Install-Package Microsoft.EntityFrameworkCore.tools -Version 3.1.15 ((Version 3.1.15 must be selected and no higher version can be selected))

then open PMC (Package Manager Console) (Tools->"NuGet package Manager"->Package Manager Console)
write 
>Add-Migration InitialCreate
then 
>Update-Database
If the migration fails, switch the platform to 64x
