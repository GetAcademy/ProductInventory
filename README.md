# Product Inventory

Et lite ASP.NET Core API som bruker Dapper og SQL Server til å lese og endre produkter.

## Kom i gang

1. Kjør `ProductInventoryDb.sql` i SQL Server Management Studio. Skriptet oppretter databasen, tabellen, constraints og testdata.
2. Tilpass `ConnectionStrings:ProductInventory` i `ProductInventory.API/appsettings.json` dersom SQL Server ikke kjører lokalt med Windows-autentisering.
3. Start API-et:

   ```powershell
   dotnet run --project ProductInventory.API
   ```

Eksempelforespørsler for alle endepunktene ligger i `ProductInventory.API/ProductInventory.API.http`.

## Endepunkter

| Metode | Rute | Beskrivelse |
| --- | --- | --- |
| `GET` | `/products` | Hent alle produkter |
| `GET` | `/products/{id}` | Hent ett produkt |
| `POST` | `/products` | Opprett et produkt |
| `PATCH` | `/products/{id}/stock` | Endre lagerbeholdningen |
| `DELETE` | `/products/{id}` | Slett et produkt |

DTO-ene tilhører API-laget. `CreateProductDto` blir derfor mappet til `Product` i endpointet før serviceklassen kalles; Core har ingen avhengighet til API-prosjektet.
