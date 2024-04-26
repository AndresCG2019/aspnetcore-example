using Empresa.Proyecto.Core.Entities;
using Empresa.Proyecto.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Empresa.Proyecto.Web.Pages.Formularios
{
    public class NewEntityModel : FormNewEntityPageModel<NewEntity>
    {
        public NewEntityModel(ILogger<FormNewEntityPageModel<NewEntity>> logger, IAsyncRepository<NewEntity> repo, IAsyncRepository<SimpleEntity> simpleEntityRepo) 
            : base(logger, repo, simpleEntityRepo)
        {
        }

    }
}
