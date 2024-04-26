using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Empresa.Proyecto.Core.Entities;
using Empresa.Proyecto.Core.Interfaces;
using Empresa.Proyecto.Core.Specifications;
using System.Data;
using Empresa.Proyecto.Web.Models;
using Microsoft.Extensions.Azure;

namespace Empresa.Proyecto.Web.Pages
{
    public class BaseCatalogPageModel<T>: PageModel where T : BaseEntity
    {
        private readonly IAsyncRepository<SimpleEntity> Repo;
        private readonly ILogger<BaseCatalogPageModel<T>> Logger;

        public IReadOnlyList<T> Entidades { get; set; } = null!;

        public BaseCatalogPageModel(ILogger<BaseCatalogPageModel<T>> logger, IAsyncRepository<SimpleEntity> repo)
        {
            Repo = repo;
            Logger = logger;
        }

        [BindProperty]
        public DataTablesRequest DataTablesRequest { get; set; }

        public async Task<JsonResult> OnPostCatalog()
        {
            int count = await Repo.CountAsync();

            var spec = new SimpleEntityAlphabeticalOrderSpecification(DataTablesRequest.Start,DataTablesRequest.Length);

            var catalog = await Repo.ListAsync(spec);

            return new JsonResult(new
            {
                draw = DataTablesRequest.Draw,
                recordsTotal = count,
                data = catalog
            });
        }
    }
}
