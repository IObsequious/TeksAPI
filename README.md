# Getting started

Texas Essential Knowledge and Skills API.

The Competencies and Academic Standards Exchange (CASE) Service enables the exchange of data between a Competency Records Service Provider and the consumers of the associated data. This service has been described using the IMS Model Driven Specification development approach: this being the Platform Specific Model (PSM) of the service.

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 for compilation."
1. Open the solution (TeksAPI.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=TeksAPI-CSharp&workspaceName=TeksAPI&projectName=TeksAPI.Standard)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the TeksAPI library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=TeksAPI-CSharp&workspaceName=TeksAPI&projectName=TeksAPI.Standard)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=TeksAPI-CSharp&workspaceName=TeksAPI&projectName=TeksAPI.Standard)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=TeksAPI-CSharp&workspaceName=TeksAPI&projectName=TeksAPI.Standard)

### 3. Add reference of the library project

In order to use the TeksAPI library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=TeksAPI-CSharp&workspaceName=TeksAPI&projectName=TeksAPI.Standard)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` TeksAPI.Standard ``` and click ``` OK ```. By doing this, we have added a reference of the ```TeksAPI.Standard``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=TeksAPI-CSharp&workspaceName=TeksAPI&projectName=TeksAPI.Standard)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=TeksAPI-CSharp&workspaceName=TeksAPI&projectName=TeksAPI.Standard)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### 

API client can be initialized as following.

```csharp

TeksAPIClient client = new TeksAPIClient();
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [AssociationsManagerController](#associations_manager_controller)
* [DefinitionsManagerController](#definitions_manager_controller)
* [DocumentsManagerController](#documents_manager_controller)
* [ItemsManagerController](#items_manager_controller)
* [PackagesManagerController](#packages_manager_controller)
* [RubricsManagerController](#rubrics_manager_controller)

## <a name="associations_manager_controller"></a>![Class: ](https://apidocs.io/img/class.png "TEKS.Controllers.AssociationsManagerController") AssociationsManagerController

### Get singleton instance

The singleton instance of the ``` AssociationsManagerController ``` class can be accessed from the API Client.

```csharp
AssociationsManagerController associationsManager = client.AssociationsManager;
```

### <a name="get_cf_association"></a>![Method: ](https://apidocs.io/img/method.png "TEKS.Controllers.AssociationsManagerController.GetCFAssociation") GetCFAssociation

> *Tags:*  ``` Skips Authentication ``` 

> This is a request to the service provider to provide the information for the specific Competency Framework Association. If the identified record cannot be found then the 'unknownobject' status code must be reported.


```csharp
Task<Models.CFAssociation> GetCFAssociation(string sourcedId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| sourcedId |  ``` Required ```  | The UUID that identifies the CFAssociation to be supplied. |


#### Example Usage

```csharp
string sourcedId = "sourcedId";

Models.CFAssociation result = await associationsManager.GetCFAssociation(sourcedId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | An invalid selection field was supplied and data filtering on the selection criteria was not possible i.e. 'invalid_selection_field'. This is accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 401 | The request was not correctly authorised i.e. 'unauthorisedrequest'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 403 | This is used to indicate that the server can be reached and process the request but refuses to take any further action i.e. 'forbidden'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 404 | Either the supplied identifier is unknown in the Service Provider and so the object could not be changed or an invalid UUID has been supplied. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. The statement 'Unknown Object' of 'Invalid UUID' should also be presented. |
| 429 | The server is receiving too many requests i.e. 'server_busy'. Retry at a later time. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 500 | This code should be used only if there is catastrophic error and there is not a more appropriate code i.e. 'internal_server_error'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 0 | This is the response data payload to be supplied when the HTTP code is NOT explicitly defined. This would be accompanied by the 'codeMajor/severity' values of 'failure/error' and the appropriate 'codeMinor' value. The associated HTTP code will also be supplied. |


### <a name="get_cf_item_associations"></a>![Method: ](https://apidocs.io/img/method.png "TEKS.Controllers.AssociationsManagerController.GetCFItemAssociations") GetCFItemAssociations

> *Tags:*  ``` Skips Authentication ``` 

> This is a request to the Service Provider to provide the all of the Competency Associations for the specified CFItem and the information about the CFItem itself.  If the identified record cannot be found then the 'unknownobject' status code must be reported.


```csharp
Task<Models.CFAssociationSet> GetCFItemAssociations(string sourcedId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| sourcedId |  ``` Required ```  | The UUID that identifies the CFItem for which ALL associations are to be supplied. |


#### Example Usage

```csharp
string sourcedId = "sourcedId";

Models.CFAssociationSet result = await associationsManager.GetCFItemAssociations(sourcedId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | An invalid selection field was supplied and data filtering on the selection criteria was not possible i.e. 'invalid_selection_field'. This is accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 401 | The request was not correctly authorised i.e. 'unauthorisedrequest'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 403 | This is used to indicate that the server can be reached and process the request but refuses to take any further action i.e. 'forbidden'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 404 | Either the supplied identifier is unknown in the Service Provider and so the object could not be changed or an invalid UUID has been supplied. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. The statement 'Unknown Object' of 'Invalid UUID' should also be presented. |
| 429 | The server is receiving too many requests i.e. 'server_busy'. Retry at a later time. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 500 | This code should be used only if there is catastrophic error and there is not a more appropriate code i.e. 'internal_server_error'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 0 | This is the response data payload to be supplied when the HTTP code is NOT explicitly defined. This would be accompanied by the 'codeMajor/severity' values of 'failure/error' and the appropriate 'codeMinor' value. The associated HTTP code will also be supplied. |


[Back to List of Controllers](#list_of_controllers)

## <a name="definitions_manager_controller"></a>![Class: ](https://apidocs.io/img/class.png "TEKS.Controllers.DefinitionsManagerController") DefinitionsManagerController

### Get singleton instance

The singleton instance of the ``` DefinitionsManagerController ``` class can be accessed from the API Client.

```csharp
DefinitionsManagerController definitionsManager = client.DefinitionsManager;
```

### <a name="get_cf_association_grouping"></a>![Method: ](https://apidocs.io/img/method.png "TEKS.Controllers.DefinitionsManagerController.GetCFAssociationGrouping") GetCFAssociationGrouping

> *Tags:*  ``` Skips Authentication ``` 

> This is a request to the Service Provider to provide the specified Competency Framework Association Grouping.  If the identified record cannot be found then the 'unknownobject' status code must be reported.


```csharp
Task<Models.CFAssociationGrouping> GetCFAssociationGrouping(string sourcedId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| sourcedId |  ``` Required ```  | The UUID that identifies the Competency Framework AssociationGrouping that is to be read from the service provider. |


#### Example Usage

```csharp
string sourcedId = "sourcedId";

Models.CFAssociationGrouping result = await definitionsManager.GetCFAssociationGrouping(sourcedId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | An invalid selection field was supplied and data filtering on the selection criteria was not possible i.e. 'invalid_selection_field'. This is accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 401 | The request was not correctly authorised i.e. 'unauthorisedrequest'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 403 | This is used to indicate that the server can be reached and process the request but refuses to take any further action i.e. 'forbidden'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 404 | Either the supplied identifier is unknown in the Service Provider and so the object could not be changed or an invalid UUID has been supplied. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. The statement 'Unknown Object' of 'Invalid UUID' should also be presented. |
| 429 | The server is receiving too many requests i.e. 'server_busy'. Retry at a later time. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 500 | This code should be used only if there is catastrophic error and there is not a more appropriate code i.e. 'internal_server_error'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 0 | This is the response data payload to be supplied when the HTTP code is NOT explicitly defined. This would be accompanied by the 'codeMajor/severity' values of 'failure/error' and the appropriate 'codeMinor' value. The associated HTTP code will also be supplied. |


### <a name="get_cf_concept"></a>![Method: ](https://apidocs.io/img/method.png "TEKS.Controllers.DefinitionsManagerController.GetCFConcept") GetCFConcept

> *Tags:*  ``` Skips Authentication ``` 

> This is a request to the Service Provider to provide the specified Competency Framework Concept and the set of children CFConcepts as identified by the hierarchy codes.  If the identified record cannot be found then the 'unknownobject' status code must be reported.


```csharp
Task<Models.CFConceptSet> GetCFConcept(string sourcedId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| sourcedId |  ``` Required ```  | The UUID that identifies the Competency Framework Concept that is to be read from the service provider. |


#### Example Usage

```csharp
string sourcedId = "sourcedId";

Models.CFConceptSet result = await definitionsManager.GetCFConcept(sourcedId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | An invalid selection field was supplied and data filtering on the selection criteria was not possible i.e. 'invalid_selection_field'. This is accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 401 | The request was not correctly authorised i.e. 'unauthorisedrequest'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 403 | This is used to indicate that the server can be reached and process the request but refuses to take any further action i.e. 'forbidden'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 404 | Either the supplied identifier is unknown in the Service Provider and so the object could not be changed or an invalid UUID has been supplied. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. The statement 'Unknown Object' of 'Invalid UUID' should also be presented. |
| 429 | The server is receiving too many requests i.e. 'server_busy'. Retry at a later time. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 500 | This code should be used only if there is catastrophic error and there is not a more appropriate code i.e. 'internal_server_error'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 0 | This is the response data payload to be supplied when the HTTP code is NOT explicitly defined. This would be accompanied by the 'codeMajor/severity' values of 'failure/error' and the appropriate 'codeMinor' value. The associated HTTP code will also be supplied. |


### <a name="get_cf_item_type"></a>![Method: ](https://apidocs.io/img/method.png "TEKS.Controllers.DefinitionsManagerController.GetCFItemType") GetCFItemType

> *Tags:*  ``` Skips Authentication ``` 

> This is a request to the Service Provider to provide the specified Competency Framework Item Type and the set of children CFItemTypes as identified by the hierarchy codes.  If the identified record cannot be found then the 'unknownobject' status code must be reported.


```csharp
Task<Models.CFItemTypeSet> GetCFItemType(string sourcedId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| sourcedId |  ``` Required ```  | The UUID that identifies the Competency Framework ItemType that is to be read from the service provider. |


#### Example Usage

```csharp
string sourcedId = "sourcedId";

Models.CFItemTypeSet result = await definitionsManager.GetCFItemType(sourcedId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | An invalid selection field was supplied and data filtering on the selection criteria was not possible i.e. 'invalid_selection_field'. This is accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 401 | The request was not correctly authorised i.e. 'unauthorisedrequest'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 403 | This is used to indicate that the server can be reached and process the request but refuses to take any further action i.e. 'forbidden'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 404 | Either the supplied identifier is unknown in the Service Provider and so the object could not be changed or an invalid UUID has been supplied. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. The statement 'Unknown Object' of 'Invalid UUID' should also be presented. |
| 429 | The server is receiving too many requests i.e. 'server_busy'. Retry at a later time. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 500 | This code should be used only if there is catastrophic error and there is not a more appropriate code i.e. 'internal_server_error'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 0 | This is the response data payload to be supplied when the HTTP code is NOT explicitly defined. This would be accompanied by the 'codeMajor/severity' values of 'failure/error' and the appropriate 'codeMinor' value. The associated HTTP code will also be supplied. |


### <a name="get_cf_license"></a>![Method: ](https://apidocs.io/img/method.png "TEKS.Controllers.DefinitionsManagerController.GetCFLicense") GetCFLicense

> *Tags:*  ``` Skips Authentication ``` 

> This is a request to the Service Provider to provide the specified Competency Framework License.  If the identified record cannot be found then the 'unknownobject' status code must be reported.


```csharp
Task<Models.CFLicense> GetCFLicense(string sourcedId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| sourcedId |  ``` Required ```  | The UUID that identifies the Competency Framework License that is to be read from the service provider. |


#### Example Usage

```csharp
string sourcedId = "sourcedId";

Models.CFLicense result = await definitionsManager.GetCFLicense(sourcedId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | An invalid selection field was supplied and data filtering on the selection criteria was not possible i.e. 'invalid_selection_field'. This is accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 401 | The request was not correctly authorised i.e. 'unauthorisedrequest'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 403 | This is used to indicate that the server can be reached and process the request but refuses to take any further action i.e. 'forbidden'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 404 | Either the supplied identifier is unknown in the Service Provider and so the object could not be changed or an invalid UUID has been supplied. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. The statement 'Unknown Object' of 'Invalid UUID' should also be presented. |
| 429 | The server is receiving too many requests i.e. 'server_busy'. Retry at a later time. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 500 | This code should be used only if there is catastrophic error and there is not a more appropriate code i.e. 'internal_server_error'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 0 | This is the response data payload to be supplied when the HTTP code is NOT explicitly defined. This would be accompanied by the 'codeMajor/severity' values of 'failure/error' and the appropriate 'codeMinor' value. The associated HTTP code will also be supplied. |


### <a name="get_cf_subject"></a>![Method: ](https://apidocs.io/img/method.png "TEKS.Controllers.DefinitionsManagerController.GetCFSubject") GetCFSubject

> *Tags:*  ``` Skips Authentication ``` 

> This is a request to the Service Provider to provide the specified Competency Framework Subject and the set of children CFSubjects as identified by the hierarchy codes.  If the identified record cannot be found then the 'unknownobject' status code must be reported.


```csharp
Task<Models.CFSubjectSet> GetCFSubject(string sourcedId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| sourcedId |  ``` Required ```  | The UUID that identifies the Competency Framework Subject that is to be read from the service provider. |


#### Example Usage

```csharp
string sourcedId = "sourcedId";

Models.CFSubjectSet result = await definitionsManager.GetCFSubject(sourcedId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | An invalid selection field was supplied and data filtering on the selection criteria was not possible i.e. 'invalid_selection_field'. This is accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 401 | The request was not correctly authorised i.e. 'unauthorisedrequest'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 403 | This is used to indicate that the server can be reached and process the request but refuses to take any further action i.e. 'forbidden'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 404 | Either the supplied identifier is unknown in the Service Provider and so the object could not be changed or an invalid UUID has been supplied. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. The statement 'Unknown Object' of 'Invalid UUID' should also be presented. |
| 429 | The server is receiving too many requests i.e. 'server_busy'. Retry at a later time. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 500 | This code should be used only if there is catastrophic error and there is not a more appropriate code i.e. 'internal_server_error'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 0 | This is the response data payload to be supplied when the HTTP code is NOT explicitly defined. This would be accompanied by the 'codeMajor/severity' values of 'failure/error' and the appropriate 'codeMinor' value. The associated HTTP code will also be supplied. |


[Back to List of Controllers](#list_of_controllers)

## <a name="documents_manager_controller"></a>![Class: ](https://apidocs.io/img/class.png "TEKS.Controllers.DocumentsManagerController") DocumentsManagerController

### Get singleton instance

The singleton instance of the ``` DocumentsManagerController ``` class can be accessed from the API Client.

```csharp
DocumentsManagerController documentsManager = client.DocumentsManager;
```

### <a name="get_all_cf_documents"></a>![Method: ](https://apidocs.io/img/method.png "TEKS.Controllers.DocumentsManagerController.GetAllCFDocuments") GetAllCFDocuments

> *Tags:*  ``` Skips Authentication ``` 

> This is a request to the Service Provider to provide all of the Competency Framework Documents. 


```csharp
Task<Models.CFDocumentSet> GetAllCFDocuments(
        int? limit = 100,
        int? offset = 0,
        string sort = null,
        Models.OrderByEnum? orderBy = null,
        string filter = null,
        List<string> fields = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| limit |  ``` Optional ```  ``` DefaultValue ```  | This is used as part of the data pagination mechanism to control the download rate of data. The 'limit' defines the download segmentation value i.e. the maximum number of records to be contained in the response. The form of implementation is described in the corresponding binding document(s). |
| offset |  ``` Optional ```  ``` DefaultValue ```  | This is used as part of the data pagination mechanism to control the download rate of data. The 'offset' is the number of the first record to be supplied in the segmented response message. The form of implementation is described in the corresponding binding document(s). |
| sort |  ``` Optional ```  | This is used as part of the sorting mechanism to be use by the service provider. The 'sort' identifies the sort criteria to be used for the records in the response message. Use with the orderBy parameter. The form of implementation is described in the corresponding binding document(s). |
| orderBy |  ``` Optional ```  | This is used as part of the sorting mechanism to be use by the service provider. This defines the form of ordering for response to the sorted request i.e. ascending (asc) or descending (desc). The form of implementation is described in the corresponding binding document(s). |
| filter |  ``` Optional ```  | This is used for the data filtering mechanism to be applied by the service provider. It defines the filtering rules to be applied when identifying the records to be supplied in the response message. The form of implementation is described in the corresponding binding document(s). |
| fields |  ``` Optional ```  ``` Collection ```  | This is used as part of the field selection mechanism to be applied by the service provider. This identifies the range of fields that should be supplied in the response message. The form of implementation is described in the corresponding binding document(s). |


#### Example Usage

```csharp
int? limit = 100;
int? offset = 0;
string sort = "sort";
var orderBy = Models.OrderByEnum?Helper.ParseString("asc");
string filter = "filter";
List<string> fields = new List<string> { "fields" };

Models.CFDocumentSet result = await documentsManager.GetAllCFDocuments(limit, offset, sort, orderBy, filter, fields);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | An invalid selection field was supplied and data filtering on the selection criteria was not possible i.e. 'invalid_selection_field'. This is accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 401 | The request was not correctly authorised i.e. 'unauthorisedrequest'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 403 | This is used to indicate that the server can be reached and process the request but refuses to take any further action i.e. 'forbidden'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 404 | Either the supplied identifier is unknown in the Service Provider and so the object could not be changed or an invalid UUID has been supplied. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. The statement 'Unknown Object' of 'Invalid UUID' should also be presented. |
| 429 | The server is receiving too many requests i.e. 'server_busy'. Retry at a later time. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 500 | This code should be used only if there is catastrophic error and there is not a more appropriate code i.e. 'internal_server_error'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 0 | This is the response data payload to be supplied when the HTTP code is NOT explicitly defined. This would be accompanied by the 'codeMajor/severity' values of 'failure/error' and the appropriate 'codeMinor' value. The associated HTTP code will also be supplied. |


### <a name="get_cf_document"></a>![Method: ](https://apidocs.io/img/method.png "TEKS.Controllers.DocumentsManagerController.GetCFDocument") GetCFDocument

> *Tags:*  ``` Skips Authentication ``` 

> This is a request to the service provider to provide the information for the specific Competency Framework Document. If the identified record cannot be found then the 'unknownobject' status code must be reported.


```csharp
Task<Models.CFDocument> GetCFDocument(string sourcedId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| sourcedId |  ``` Required ```  | The UUID that identifies the Competency Framework Document that is to be read from the service provider. |


#### Example Usage

```csharp
string sourcedId = "sourcedId";

Models.CFDocument result = await documentsManager.GetCFDocument(sourcedId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | An invalid selection field was supplied and data filtering on the selection criteria was not possible i.e. 'invalid_selection_field'. This is accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 401 | The request was not correctly authorised i.e. 'unauthorisedrequest'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 403 | This is used to indicate that the server can be reached and process the request but refuses to take any further action i.e. 'forbidden'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 404 | Either the supplied identifier is unknown in the Service Provider and so the object could not be changed or an invalid UUID has been supplied. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. The statement 'Unknown Object' of 'Invalid UUID' should also be presented. |
| 429 | The server is receiving too many requests i.e. 'server_busy'. Retry at a later time. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 500 | This code should be used only if there is catastrophic error and there is not a more appropriate code i.e. 'internal_server_error'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 0 | This is the response data payload to be supplied when the HTTP code is NOT explicitly defined. This would be accompanied by the 'codeMajor/severity' values of 'failure/error' and the appropriate 'codeMinor' value. The associated HTTP code will also be supplied. |


[Back to List of Controllers](#list_of_controllers)

## <a name="items_manager_controller"></a>![Class: ](https://apidocs.io/img/class.png "TEKS.Controllers.ItemsManagerController") ItemsManagerController

### Get singleton instance

The singleton instance of the ``` ItemsManagerController ``` class can be accessed from the API Client.

```csharp
ItemsManagerController itemsManager = client.ItemsManager;
```

### <a name="get_cf_item"></a>![Method: ](https://apidocs.io/img/method.png "TEKS.Controllers.ItemsManagerController.GetCFItem") GetCFItem

> *Tags:*  ``` Skips Authentication ``` 

> This is a request to the Service Provider to provide the specified Competency Framework Item.  If the identified record cannot be found then the 'unknownobject' status code must be reported.


```csharp
Task<Models.CFItem> GetCFItem(string sourcedId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| sourcedId |  ``` Required ```  | The UUID that identifies the Competency Framework Item that is to be read from the service provider. |


#### Example Usage

```csharp
string sourcedId = "sourcedId";

Models.CFItem result = await itemsManager.GetCFItem(sourcedId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | An invalid selection field was supplied and data filtering on the selection criteria was not possible i.e. 'invalid_selection_field'. This is accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 401 | The request was not correctly authorised i.e. 'unauthorisedrequest'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 403 | This is used to indicate that the server can be reached and process the request but refuses to take any further action i.e. 'forbidden'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 404 | Either the supplied identifier is unknown in the Service Provider and so the object could not be changed or an invalid UUID has been supplied. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. The statement 'Unknown Object' of 'Invalid UUID' should also be presented. |
| 429 | The server is receiving too many requests i.e. 'server_busy'. Retry at a later time. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 500 | This code should be used only if there is catastrophic error and there is not a more appropriate code i.e. 'internal_server_error'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 0 | This is the response data payload to be supplied when the HTTP code is NOT explicitly defined. This would be accompanied by the 'codeMajor/severity' values of 'failure/error' and the appropriate 'codeMinor' value. The associated HTTP code will also be supplied. |


[Back to List of Controllers](#list_of_controllers)

## <a name="packages_manager_controller"></a>![Class: ](https://apidocs.io/img/class.png "TEKS.Controllers.PackagesManagerController") PackagesManagerController

### Get singleton instance

The singleton instance of the ``` PackagesManagerController ``` class can be accessed from the API Client.

```csharp
PackagesManagerController packagesManager = client.PackagesManager;
```

### <a name="get_cf_package"></a>![Method: ](https://apidocs.io/img/method.png "TEKS.Controllers.PackagesManagerController.GetCFPackage") GetCFPackage

> *Tags:*  ``` Skips Authentication ``` 

> This is a request to the service provider to provide the information for the specific Competency Framework Package. If the identified record cannot be found then the 'unknownobject' status code must be reported.


```csharp
Task<Models.CFPackage> GetCFPackage(string sourcedId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| sourcedId |  ``` Required ```  | The UUID that identifies the Competency Framework Document that is to be read from the service provider and supplied with all of its component artefacts. |


#### Example Usage

```csharp
string sourcedId = "sourcedId";

Models.CFPackage result = await packagesManager.GetCFPackage(sourcedId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | An invalid selection field was supplied and data filtering on the selection criteria was not possible i.e. 'invalid_selection_field'. This is accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 401 | The request was not correctly authorised i.e. 'unauthorisedrequest'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 403 | This is used to indicate that the server can be reached and process the request but refuses to take any further action i.e. 'forbidden'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 404 | Either the supplied identifier is unknown in the Service Provider and so the object could not be changed or an invalid UUID has been supplied. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. The statement 'Unknown Object' of 'Invalid UUID' should also be presented. |
| 429 | The server is receiving too many requests i.e. 'server_busy'. Retry at a later time. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 500 | This code should be used only if there is catastrophic error and there is not a more appropriate code i.e. 'internal_server_error'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 0 | This is the response data payload to be supplied when the HTTP code is NOT explicitly defined. This would be accompanied by the 'codeMajor/severity' values of 'failure/error' and the appropriate 'codeMinor' value. The associated HTTP code will also be supplied. |


[Back to List of Controllers](#list_of_controllers)

## <a name="rubrics_manager_controller"></a>![Class: ](https://apidocs.io/img/class.png "TEKS.Controllers.RubricsManagerController") RubricsManagerController

### Get singleton instance

The singleton instance of the ``` RubricsManagerController ``` class can be accessed from the API Client.

```csharp
RubricsManagerController rubricsManager = client.RubricsManager;
```

### <a name="get_cf_rubric"></a>![Method: ](https://apidocs.io/img/method.png "TEKS.Controllers.RubricsManagerController.GetCFRubric") GetCFRubric

> *Tags:*  ``` Skips Authentication ``` 

> This is a request to the service provider to provide the information for the specific Competency Framework Rubric. If the identified record cannot be found then the 'unknownobject' status code must be reported.


```csharp
Task<Models.CFRubricType> GetCFRubric(string sourcedId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| sourcedId |  ``` Required ```  | The UUID that identifies the Competency Framework Rubric that is to be read from the service provider. |


#### Example Usage

```csharp
string sourcedId = "sourcedId";

Models.CFRubricType result = await rubricsManager.GetCFRubric(sourcedId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | An invalid selection field was supplied and data filtering on the selection criteria was not possible i.e. 'invalid_selection_field'. This is accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 401 | The request was not correctly authorised i.e. 'unauthorisedrequest'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 403 | This is used to indicate that the server can be reached and process the request but refuses to take any further action i.e. 'forbidden'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 404 | Either the supplied identifier is unknown in the Service Provider and so the object could not be changed or an invalid UUID has been supplied. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. The statement 'Unknown Object' of 'Invalid UUID' should also be presented. |
| 429 | The server is receiving too many requests i.e. 'server_busy'. Retry at a later time. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 500 | This code should be used only if there is catastrophic error and there is not a more appropriate code i.e. 'internal_server_error'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. |
| 0 | This is the response data payload to be supplied when the HTTP code is NOT explicitly defined. This would be accompanied by the 'codeMajor/severity' values of 'failure/error' and the appropriate 'codeMinor' value. The associated HTTP code will also be supplied. |


[Back to List of Controllers](#list_of_controllers)



