#pragma checksum "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\Pages\Fila.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f718e951c1583b8ca895c3f521a94f001ddcf30"
// <auto-generated/>
#pragma warning disable 1591
namespace AtendimentoMedico.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\_Imports.razor"
using AtendimentoMedico;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\_Imports.razor"
using AtendimentoMedico.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\Pages\Fila.razor"
using AtendimentoMedico.Data.AppContext;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\Pages\Fila.razor"
using AtendimentoMedico.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\Pages\Fila.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\Pages\Fila.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fila")]
    public partial class Fila : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Chamado Atual</h1>\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-dark");
            __builder.AddMarkupContent(3, "<thead><tr><td>Ordem</td>\r\n        <td>PACIENTE</td>\r\n        <td>MEDICO</td>\r\n        <td>SALA</td></tr></thead>\r\n    ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 20 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\Pages\Fila.razor"
     if (_medico is not null)
    {
        var ultimo = _medico.First();

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.AddMarkupContent(6, "<td>AGORA</td>\r\n            ");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 25 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\Pages\Fila.razor"
                 ultimo.Atendimento.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 26 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\Pages\Fila.razor"
                 ultimo.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 27 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\Pages\Fila.razor"
                 ultimo.Sala

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\Pages\Fila.razor"
        if (_medico.Count != 1)
        {
            var penultimo = _medico.ElementAt(1);

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "tr");
            __builder.AddMarkupContent(16, "<td>ULTIMO CHAMADO</td>\r\n                ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 34 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\Pages\Fila.razor"
                     penultimo.Atendimento.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 35 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\Pages\Fila.razor"
                     penultimo.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 36 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\Pages\Fila.razor"
                     penultimo.Sala

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\Pages\Fila.razor"
        }
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n");
            __builder.AddMarkupContent(26, "<h1>Fila de Espera</h1>\r\n");
            __builder.OpenElement(27, "table");
            __builder.AddAttribute(28, "class", "table-responsive-md table-striped table ");
            __builder.AddMarkupContent(29, "<thead><tr><td>Nome</td>\r\n        <td>Prioridade</td></tr></thead>\r\n    ");
            __builder.OpenElement(30, "tbody");
#nullable restore
#line 52 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\Pages\Fila.razor"
     if (_atendimentos != null)
    {
        foreach (var atendimento in _atendimentos)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\Pages\Fila.razor"
             if (!atendimento.Atendido)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "tr");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 59 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\Pages\Fila.razor"
                         atendimento.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 60 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\Pages\Fila.razor"
                         atendimento.Prioridade

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 62 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\Pages\Fila.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\Pages\Fila.razor"
             

        }
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\Users\José\RiderProjects\AtendimentoMedico\AtendimentoMedico\Pages\Fila.razor"
 
    [Inject]
    AppDbContext AppDbContext { get; set; }

    [Inject]
    NavigationManager NavigationManager { get; set; }

    private HubConnection hubConnection;
    private List<Atendimento> _atendimentos { get; set; }
    private List<Medico> _medico { get; set; }

    protected override async Task OnInitializedAsync()
    {
        _atendimentos = await AppDbContext
            .Atendimento
            .Where(c => c.Atendido==false)
            .OrderBy(c=>c.Prioridade).ToListAsync();

        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/serverHub"))
            .Build();

        await hubConnection.StartAsync();

        hubConnection.On("ReceiveMessage", () =>
        {
            LoadData();
            StateHasChanged();
        });


        LoadData();
    }


    protected async void LoadData()
    {
        _atendimentos = await AppDbContext
            .Atendimento
            .Where(c => c.Atendido==false)
            .OrderBy(c=>c.Prioridade).ToListAsync();
        
        _medico = await AppDbContext.Medico.OrderBy(c => c.Id)
            .Reverse()
            .Include(c => c.Atendimento)
            .ToListAsync();
        
        StateHasChanged();
    }


    public async ValueTask DisposeAsync()
    {
        if (hubConnection is not null)
        {
            await hubConnection.DisposeAsync();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591