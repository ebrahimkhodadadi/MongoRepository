# MongoDBAspNetCore
## _Mongo Database Repository in Asp.net Core_

 - Add Data.Mongo to your project
 - Add Mongo connection in AppSettings
 - Inject Mongo Repository

To use filters
```csharp
  await _repository.GetAsync(x => x.Created >= from && x.Created <= to);
```

