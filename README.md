# MongoDBAspNetCore
## _Mongo Database Repository in Asp.net Core_

 - Add Data.Mongo to your project
 - Add Mongo connection in AppSettings
 - Inject Mongo Repository

To use filters
```csharp
    _repository.AsQueryable().Where(x => x.Created >= from && x.Created <= to);
```

> **Warning**
**Dont use AsEnumerable** as much as you can it will decrease the speed and performance so much

