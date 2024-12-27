# BlazorApp8

Esempio per la realizzazione di una Web App Blazor in .NET 8

1-Crea in Visual Studio un progetto di tipo Blazor Web App

2-Aggiungi una Classe modello (in questo caso Vehicle)

3-Aggiungiamo i componenti che gestiranno le operazioni CRUD sul modello:

![Logo](https://github.com/ale77x/BlazorApp8/raw/master/Docs/Screenshot_1.png)

4-Selezioniamo un nuovo componente Razor che implementi le operazioni CRUD

![Logo](https://github.com/ale77x/BlazorApp8/raw/master/Docs/Screenshot_2.png)

5-Selezioniamo queste opzioni:

![Logo](https://github.com/ale77x/BlazorApp8/raw/master/Docs/Screenshot_3.png)

6-Ora troveremo tra le Pages, le pagine che potranno gestire le operazioni sull'oggetto,compresa una pagina Index contenente un componente QuickGrid

![Logo](https://github.com/ale77x/BlazorApp8/raw/master/Docs/Screenshot_4.png)

7-Inseriamo un operazione di migrazione in modo da generare un Database che rifletta la struttura delle nostre classi
![Logo](https://github.com/ale77x/BlazorApp8/raw/master/Docs/Screenshot_5.png)

8-Diamole un nome, selezioniamo il DBContext.

![Logo](https://github.com/ale77x/BlazorApp8/raw/master/Docs/Screenshot_6.png)

9-una volta fatto dovremo selezionare anche Update database

10-paginazione

nella pagina Index, aggiungere <Paginator  State="pagState" />
e il codice per la paginazione
    PaginationState pagState = new PaginationState() { ItemsPerPage=1 };

    impostare pagState in entrambi i posti serve per coordinare la paginazione tra il componente QuickGrid e il componente Paginator

11-aggiungere un campo di ricerca

modifico l'intestazione di colonna del campo che voglio rendere ricercabile, aggiungendo un campo di input di tipo search, bindato ad una variabile di tipo string
inoltre indico che deve filtrare ad ogni input dell'utente tramite bind:event="oninput"

    <PropertyColumn Property="vehicle => vehicle.Model" Sortable="true">
        <ColumnOptions>
            <input type="search" autofocus @bind="modelFilter" @bind:event="oninput" />
        </ColumnOptions>
    </PropertyColumn>
    
    ...
    string modelFilter = string.Empty;

12-profilazione degli utenti

si crea un elemento di scaffolding, selezionando Identity 

![Logo](https://github.com/ale77x/BlazorApp8/raw/master/Docs/Screenshot_10.png)

si aggiungeranno le pagine di login e registrazione all'applicazione 

![Logo](https://github.com/ale77x/BlazorApp8/raw/master/Docs/Screenshot_10.png)

13-per abilitare l'accesso delle pagine solo agli utenti autenticati, si modifica(o si aggiunge) il file _Imports.razor nella cartella contenente le pagine da proteggere,
aggiungendo la direttiva @attribute [Authorize]
    @using Microsoft.AspNetCore.Authorization
    @attribute [Authorize]

