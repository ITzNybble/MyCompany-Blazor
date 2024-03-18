# MyCompany-Blazor

**Step 1**: Download or clone MyCompany-Blazor Repository

**---Set up the Database----**

**Step 2:** Download the SQL Scripts Here and unzip them: [SQL scripts.zip](https://github.com/ITzNybble/MyCompany-Blazor/files/14630646/SQL.scripts.zip)

**Step 3:** There are two options here:

  Option A: Run the SQL file, "00_CreateDatabase_Tables_Populate.sql" against the SQL server instance. This script contains scripts "01" through "05" as one large script. 

** NOTE: If you use this script there is no need to run the other scripts.**
  
  **or**

  Option B: Run each seperate script files starting with "01_CreateDirectorTable.sql" and progress through "05_PopulateTables.sql" in numerical order

**---Publish solution files---**

**Step 4:** Launch the solution with Visual Studio

**Step 5:** Within the MyCompany-Blazor.WebUI project, Open, appsettings.json

![image](https://github.com/ITzNybble/MyCompany-Blazor/assets/14057570/be96046c-6976-49b1-a04a-0a8ec8d2cc79)

**Step 6:** Update DefaultConnection string to point to the newly created MyCompany database

**NOTE: Verify a login is being used that has access to the SQL Server instance**

![image](https://github.com/ITzNybble/MyCompany-Blazor/assets/14057570/0ccdd34f-fc29-4276-8b88-5a0331d89a6c)

**Step 7:** Right click on the "MyCompany-Blazor.WebUI and click, "Publish..."

**Step 8:** In the Publish Window, Click, "New Profile"

![image](https://github.com/ITzNybble/MyCompany-Blazor/assets/14057570/4798c500-35b5-4b59-b61a-24370a09eec5)

**Step 9:** Select Folder as your target for this profile, then click, "Next"

![image](https://github.com/ITzNybble/MyCompany-Blazor/assets/14057570/256319ff-d49e-431e-b276-7936e0fc739a)

**Step 10:** For this Demo, we will use the default folder location, click "Finish"

![image](https://github.com/ITzNybble/MyCompany-Blazor/assets/14057570/458d7580-bc2e-4e57-a5ea-b3693d65076a)

**Step 11:** Click, "Show all settings" and verify we are using the Release configuration (Any CPU), Also verify the connection strings are valid for the SQL Server Instance. Then click, "Save"

![image](https://github.com/ITzNybble/MyCompany-Blazor/assets/14057570/8cfbc10c-acd3-4f55-a38e-92fcfa95ba05)

**Step 12:** Click, "Publish" and remember the folder path.

![image](https://github.com/ITzNybble/MyCompany-Blazor/assets/14057570/4adcda2e-b880-46b6-88dc-dffc800ab17c)


---Configure IIS---

NOTE: IIS will need to have the AspNetCoreModuleV2. If it is not present in your IIS Modules, you will need to navigate to https://dotnet.microsoft.com/en-us/download/dotnet/8.0 and install the ASP.NET Core Runtime 8.0.3 Hosting Bundle for Windows.

![image](https://github.com/ITzNybble/MyCompany-Blazor/assets/14057570/4931bb02-ccf5-494a-b3bf-548ca43a53d2)


![image](https://github.com/ITzNybble/MyCompany-Blazor/assets/14057570/a5ca7761-5ca1-44fc-a97b-3379da57a95e)

**Step 13:** Open IIS and Right Click on Sites -> select, "Add Website"

![image](https://github.com/ITzNybble/MyCompany-Blazor/assets/14057570/80013a56-6bb7-4b28-8a09-8cd5e2d97226)

**Step 14:** For this Demo, it is acceptable to use the DefaultAppPool.

**Note: the ApplicationPool's User needs to have access to the SQL Server Database.**

**Step 15:** Fill out the website info as in the picture below with the exception of the physical path. Select a physical path where we will put the project files we published in Step 12. The port can be any port which is available. Click, "OK" when finished

![image](https://github.com/ITzNybble/MyCompany-Blazor/assets/14057570/2d50db92-8bca-4a8f-81e6-437a5a868e23)

**Step 16:** Open the Authentication window within the Security Category. Verify Anonymous Authentication is **Enabled**. If it is not then please enable it.

![image](https://github.com/ITzNybble/MyCompany-Blazor/assets/14057570/bea791f8-f9ec-4bb3-bbc1-cc89ca41a3a6)

![image](https://github.com/ITzNybble/MyCompany-Blazor/assets/14057570/bf7050cc-a354-4900-866a-34751438a56c)

**Step 17:** Copy all files from the folder in Step 12 into the folder we specified in Step 15.

**Step 18:** Once files are copied over, start the website. Select the MyCompanyDemo site within IIS and click, "start" on the right panel under "Manage Website"

![image](https://github.com/ITzNybble/MyCompany-Blazor/assets/14057570/32b9e8f5-be77-4685-bc7c-602f18493cd1)

**Step 19:** Click Browse and the Demo will launch in a browser window.







